﻿
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' WFin_ApproverPage1.aspx page.  The Row or RecordControl classes are the 
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
Imports System.Data.SqlClient


#End Region

  
Namespace ePortalWFApproval.UI.Controls.WFin_ApproverPage1

#Region "Section 1: Place your customizations here."

    
Public Class WFinRep_HeadRecordControl
        Inherits BaseWFinRep_HeadRecordControl
        ' The BaseWFinRep_HeadRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

        Private Sub MyPreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender

            Dim script As String = "<script language=""javascript"">" & vbCrLf & _
            "function ConfirmSubmission(event){" & vbCrLf & _
            "  event.returnValue = false;" & vbCrLf & _
            "  var t;" & vbCrLf & _
            "  var s;" & vbCrLf & _
            "  t = document.getElementById('" & Me.txtRemarks.ClientID & "');" & vbCrLf & _
            "  s = t.value;" & vbCrLf & _
            "  s = s.replace(/^\s*/, '').replace(/\s*$/, '');" & vbCrLf & _
            "  if (s == '') {" & vbCrLf & _
            "    alert('Please put remarks when rejecting.'); return false;}" & vbCrLf & _
            "  else { ShowConfirm(event,'Submit Action','Continue submission of this document with (Reject) Action setting? Press OK to confirm document submission or press Cancel to abort operation.','Concerned approver or requester will be notified through email.');}" & vbCrLf & _
            "}" & vbCrLf & _
            "" & vbCrLf & _
            "</script>" & vbCrLf

            Me.Page.ClientScript.RegisterStartupScript(GetType(Page), "ConfirmSubmission", script)
        End Sub

        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            'Remove javascript confirm button action
            'Me.pApproved.Attributes.Add("onclick", "ShowConfirm(event,'Submit Action','Continue submission of this document? Press OK to confirm document submission or press Cancel to abort operation.','Concerned approver or requester will be notified through email.');")
            'Me.pReject.Attributes.Add("onclick", "ConfirmSubmission(event);")
            'Me.pReturned.Attributes.Add("onclick", "ConfirmSubmission(event);")

            AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
            AddHandler Me.pApproved.Click, AddressOf pApproved_Click

            AddHandler Me.pReject.Click, AddressOf pReject_Click
            AddHandler Me.pReturned.Click, AddressOf pReturned_Click

            'AddHandler Me.btnReject.Button.Click, AddressOf btnReject_Click

            AddHandler Me.HFIN_DT_ID1.SelectedIndexChanged, AddressOf HFIN_DT_ID1_SelectedIndexChanged

            AddHandler Me.HFIN_FinID.TextChanged, AddressOf HFIN_FinID_TextChanged

            AddHandler Me.HFIN_Remark.TextChanged, AddressOf HFIN_Remark_TextChanged

            AddHandler Me.HFIN_U_ID.TextChanged, AddressOf HFIN_U_ID_TextChanged

            AddHandler Me.ddlMoveTo.SelectedIndexChanged, AddressOf ddlMoveTo_SelectedIndexChanged

            AddHandler Me.txtRemarks.TextChanged, AddressOf txtRemarks_TextChanged

            If Me.HFIN_Status.Text = "Completed" Then
                Me.pReturned.Visible = True
                Me.pApproved.Visible = False
                Me.pReject.Visible = False
            Else
                Me.pReturned.Visible = False
                Me.pApproved.Visible = True
                Me.pReject.Visible = True
            End If

            Me.ddlMoveTo.Attributes.Add("style", "display:none")
        End Sub


		Public Overrides Sub SetHFIN_Remark()

            Me.HFIN_Remark.Text = " "

        End Sub

		Public Overrides Sub SetHFIN_C_ID1()


            ' Set the HFIN_C_ID Literal on the webpage with value from the
            ' WFinRep_Head database record.

            ' Me.DataSource is the WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then

                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value

                Me.HFIN_C_ID1.Text = Me.DataSource.HFIN_C_ID.ToString()

            Else

                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.HFIN_C_ID1.Text = WFinRep_Head1Table.HFIN_C_ID.Format(WFinRep_Head1Table.HFIN_C_ID.DefaultValue)

            End If

        End Sub

        Private Sub Send_Email_Notification(ByVal SendTo_User_ID As String, ByVal Subject As String, ByVal Content As String)
            Dim sEmail As String = ""

            Try

                Dim wc2 As WhereClause = New WhereClause
                Dim itemValue2 As W_User1Record
                wc2.iAND(W_User1Table.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, SendTo_User_ID)

                If W_User1Table.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue2 In W_User1Table.GetRecords(wc2, Nothing, 0, 100)
                        If itemValue2.W_U_IDSpecified Then
                            sEmail = itemValue2.W_U_Email.ToString()
                        End If
                    Next
                End If

                Dim email As New BaseClasses.Utils.MailSender

                ''sEmail = "jfpimentera@anflocor.com"

                email.AddFrom("noreply@anflocor.com")
                email.AddTo(sEmail)
                email.SetSubject(Subject)
                email.SetContent(Content)
                email.SetIsHtmlContent(True)
                email.SendMessage()
            Catch ex As Exception
                ' RegisterAlert(Me.Title, ex.Message, True)
                Utils.MiscUtils.RegisterJScriptAlert(Me, "Send Email Error", ex.Message)

            End Try
        End Sub

        Private Function Content_Formatter(ByVal User_ID As String, ByVal Title As String, ByVal Company As String, ByVal Details As String, _
          ByVal ReportDate As String, ByVal Remarks As String, ByVal FSType As String, ByVal Requester_ID As String, ByVal Color_Hex As String, _
          ByVal Page As String, ByVal Document As String, ByVal ApproverRem As String, ByVal Status As String, Optional ByVal Default_Type As String = "") As String
            Dim wc2 As WhereClause = New WhereClause
            Dim itemValue2 As W_Email1Record
            Dim sDirectory As String = ""
            Dim sSite As String = ""
            Dim sTemplate As String = ""

            If Default_Type = "" Then
                wc2.iAND(W_Email1Table.WE_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)
                wc2.iAND(W_Email1Table.WE_Directory, BaseFilter.ComparisonOperator.EqualsTo, "eportal")

                If W_Email1Table.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue2 In W_Email1Table.GetRecords(wc2, Nothing, 0, 100)
                        If itemValue2.WE_U_IDSpecified Then
                            sDirectory = itemValue2.WE_Directory.ToString()
                            sSite = itemValue2.WE_Site.ToString()
                            sTemplate = itemValue2.WE_Template.ToString()
                        End If
                    Next
                End If
            Else
                wc2.iAND(W_Email_Default1Table.WED_Type, BaseFilter.ComparisonOperator.EqualsTo, Default_Type)

                If W_Email_Default1Table.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue21 As W_Email_Default1Record In W_Email_Default1Table.GetRecords(wc2, Nothing, 0, 100)
                        If itemValue21.WED_IDSpecified Then
                            sDirectory = "eportal" 'itemValue21.WE_Directory.ToString()
                            sSite = "http://eportal.anflocor.com/" 'itemValue21.WE_Site.ToString()
                            sTemplate = itemValue21.WED_Template.ToString()
                        End If
                    Next
                End If
            End If

            sTemplate = Replace(sTemplate, "@TITLE", Title)
            sTemplate = Replace(sTemplate, "@COM", Company)
            sTemplate = Replace(sTemplate, "@DET", Details)
            sTemplate = Replace(sTemplate, "@DTE", ReportDate)
            sTemplate = Replace(sTemplate, "@REM", Remarks)
            sTemplate = Replace(sTemplate, "@TOT", FSType)
            sTemplate = Replace(sTemplate, "@SITE", sSite)
            sTemplate = Replace(sTemplate, "@LOC", sDirectory)

            Dim wc3 As WhereClause = New WhereClause
            Dim itemValue3 As W_User1Record
            Dim sFullName As String = "" 'creator
            Dim sUserEmail As String = "" 'creator
            wc3.iAND(W_User1Table.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, Requester_ID)

            If W_User1Table.GetRecords(wc3, Nothing, 0, 100).Length > 0 Then
                For Each itemValue3 In W_User1Table.GetRecords(wc3, Nothing, 0, 100)
                    If itemValue3.W_U_IDSpecified Then
                        sFullName = itemValue3.W_U_Full_Name.ToString()
                        sUserEmail = itemValue3.W_U_Email.ToString()
                    End If
                Next
            End If

            sTemplate = Replace(sTemplate, "@USR", sUserEmail)
            sTemplate = Replace(sTemplate, "@REQ", sFullName)

            sTemplate = Replace(sTemplate, "@PAGE", Page)
            sTemplate = Replace(sTemplate, "@DOC", "MRIS# " & Document)
            sTemplate = Replace(sTemplate, "@COLOR", Color_Hex)
            sTemplate = Replace(sTemplate, "@APPREM", ApproverRem)
            sTemplate = Replace(sTemplate, "@STAT", Status)
            sTemplate = Replace(sTemplate, "@TOT", FSType)
            'sTemplate = Replace(sTemplate, "@WF", WF_Type)

            Return sTemplate
        End Function


        Public Overrides Sub pApproved_Click(ByVal sender As Object, ByVal args As EventArgs)

            Try
                Dim sFinID As String = Me.HFIN_ID.Text ''oRec.FIN_ID.Text
                Dim sCo1 As String = Me.HFIN_C_ID.Text ''oRec.FIN_Company1.SelectedItem.ToString
                Dim sYr As String = Me.HFIN_Year.Text ''oRec.FIN_Year1.Text
                Dim sMo As String = MonthName(CInt(Me.HFIN_Month2.Text)) ''MonthName(CInt(oRec.FIN_Month1.Text))
                Dim sDesc As String = "FS PACKAGE"
                Dim sType As String = ""
                Dim sCo As String = Me.HFIN_C_ID1.Text



                Dim wc1 As WhereClause = New WhereClause
                Dim sCurStep As String = ""
                Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Report Details:" & "@D" & vbCrLf & _
                vbCrLf & "Date: @RD" & vbCrLf & vbCrLf & "Comment(s): @Rem" & vbCrLf & "Type: @T"

                Dim sFSDetail As String = " "
                Dim sDeyt As String = sMo & vbCrLf & vbCrLf & sYr

                Dim sWhere1 As String = W_User1Table.W_U_ID.UniqueName & " = " & Me.HFIN_U_ID.Text
                Dim sUser As String = ""
                For Each oRec2 As W_User1Record In W_User1Table.GetRecords(sWhere1, Nothing, 0, 100)
                    sUser = oRec2.W_U_Full_Name.ToString()
                Next
                sFSDetail = Me.HFIN_Description1.Text

                sEmailContent = Replace(sEmailContent, "@C", Me.HFIN_C_ID.Text) ''oRec.FIN_Company1.SelectedItem.ToString)
                sEmailContent = Replace(sEmailContent, "@D", sFSDetail)
                sEmailContent = Replace(sEmailContent, "@RD", sDeyt)
                sEmailContent = Replace(sEmailContent, "@Rem", "Report Name: " & sDesc & "</br>" & Me.txtRemarks.Text)
                sEmailContent = Replace(sEmailContent, "@T", sType)
                sEmailContent &= vbCrLf & "Requester: " & sUser
                sEmailContent &= vbCrLf & vbCrLf & "https://eportal2.anflocor.com/"

                'wc1.iAND(WFinRep_Activity1Table.AFIN_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc1.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc1.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc1.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                'note: check to see if record is still submitted, if not then do not save
                If WFinRep_Activity1Table.GetRecords(wc1, Nothing, 0, 100).Length > 0 Then
                    'note: get Current step to be used in wc2
                    For Each itemValue1 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc1, Nothing, 0, 100)
                        sCurStep = itemValue1.AFIN_WS_ID.ToString()
                    Next

                    Dim wc2 As WhereClause = New WhereClause
                    Dim iApprovers As Integer = 0
                    Dim sNextStep As String = ""

                    wc2.iAND(WFinRep_Step_StepDetail1View.WFIN_S_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)
                    ''below wc2 not included - 2-12-11
                    For Each itemValue2 As WFinRep_Step_StepDetail1Record In WFinRep_Step_StepDetail1View.GetRecords(wc2, Nothing, 0, 100)
                        iApprovers = itemValue2.WFIN_S_Approval_Needed
                        sNextStep = itemValue2.WFIN_S_ID_Next.ToString
                    Next

                    Dim wc3 As WhereClause = New WhereClause
                    Dim colUser As New Collection

                    wc3.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc3.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                    wc3.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")
                    wc3.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                    For Each itemValue3 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                        'note: do not include previous same step if wf has been 'Rejected'
                        If Not colUser.Contains(itemValue3.AFIN_W_U_ID.ToString) Then
                            colUser.Add(itemValue3.AFIN_W_U_ID, itemValue3.AFIN_W_U_ID.ToString)
                        End If
                    Next

                    '--------------------------------------------------------------------------------------------------------
                    If iApprovers = colUser.Count + 1 Then 'met the # of approvers requirement (+1 -> means the current user)
                        If (sNextStep = "0") Or (sNextStep = Nothing) Then  'no next step (end workflow here)
                            'note: set current user status task to 'Approved' & set CAR doc status to 'Completed'
                            Dim wc5 As WhereClause = New WhereClause


                            wc5.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc5.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                            wc5.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                            wc5.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)


                            If WFinRep_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                For Each itemValue5 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                    'note: update Activity table (current user) -> 'Approved'
                                    WFinRep_Activity1Record.UpdateRecord(itemValue5.AFIN_ID.ToString(), "6")
                                    WFinRep_Activity1Record.UpdateRecord_Final_Approved(itemValue5.AFIN_ID.ToString())
                                Next
                            End If

                            Dim wc6 As WhereClause = New WhereClause

                            wc6.iAND(WFinRep_Head1Table.HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc6.iAND(WFinRep_Head1Table.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, sCo)
                            For Each itemValue6 As WFinRep_Head1Record In WFinRep_Head1Table.GetRecords(wc6, Nothing, 0, 100)
                                Update_WFinRep_Head(CInt(sCo), 6, CInt(sFinID))
                                Update_WFinRep_DocAttach(CInt(sCo), 6, sFinID, True)
                                '##################
                                '### EMAIL HERE ###
                                '##################
                                sEmailContent = Content_Formatter(itemValue6.HFIN_U_ID.ToString(), _
                                "FS Report Approval Completed (FS Document ID#  " & sFinID & ")", CStr(sCo1), _
                                sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                                itemValue6.HFIN_U_ID.ToString(), "#4682b4", "WFinRep_Head1/WFin-Approver-Table1.aspx", sFinID, _
                                "FS Workflow Completed", "Completed")

                                Send_Email_Notification(itemValue6.HFIN_U_ID.ToString(), "FS Report Approval Completed (Report Name: " & Me.HFIN_Description1.Text & _
                                ")", sEmailContent)

                            Next

                        Else
                            'note: if # of approvers needed < multiple approvers then set other 'Pending' status to 'System Approved'
                            'note: set current user status to 'Approved'
                            'note: get user(s) for the next step & insert to Activity table
                            Dim wc4 As WhereClause = New WhereClause


                            wc4.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc4.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                            wc4.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                            wc4.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                            For Each itemValue4 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                                'note: update Activity table (other user(s) if multiple approvers) -> 'System Approved'
                                WFinRep_Activity1Record.UpdateRecord(itemValue4.AFIN_ID.ToString(), "11")
                            Next

                            Dim wc5 As WhereClause = New WhereClause

                            wc5.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc5.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                            wc5.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                            wc5.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                            '' ''MsgBox(sFinID & vbNewLine & System.Web.HttpContext.Current.Session("UserIDNorth").ToString() & vbNewLine & sCurStep)

                            If WFinRep_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                For Each itemValue5 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                    'note: update Activity table (current user) -> 'Approved'
                                    WFinRep_Activity1Record.UpdateRecord(itemValue5.AFIN_ID.ToString(), "5")
                                    WFinRep_Activity1Record.UpdateRecord_Final_Approved(itemValue5.AFIN_ID.ToString()) ''additional: to make IsDone = True
                                Next
                            End If


                            Dim wc6 As WhereClause = New WhereClause
                            wc6.iAND(WFinRep_Step_StepDetail1View.WFIN_S_ID, BaseFilter.ComparisonOperator.EqualsTo, sNextStep)
                            For Each itemValue6 As WFinRep_Step_StepDetail1Record In WFinRep_Step_StepDetail1View.GetRecords(wc6, Nothing, 0, 100)
                                'note: use returned items to insert to Activity table
                                'note: do not insert(update) delegate until task expires

                                WFinRep_Activity1Record.AddRecord(itemValue6.WFIN_S_ID, itemValue6.WFIN_SD_ID, _
                                CInt(Me.HFIN_DT_ID1.SelectedValue), _
                                itemValue6.WFIN_SD_W_U_ID, 0, CInt(sFinID), _
                               (DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & Me.txtRemarks.Text))


                                ' '' MsgBox(itemValue6.WFIN_S_ID & vbNewLine & itemValue6.WFIN_SD_ID & vbNewLine & _
                                ' '' CInt(Me.HFIN_DT_ID1.SelectedValue) & vbNewLine & _
                                ' '' itemValue6.WFIN_SD_W_U_ID & vbNewLine & CInt(sFinID) & vbNewLine & _
                                ' ''(DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ' '' ": " & Me.txtRemarks.Text))

                                Dim nStep As String = itemValue6.W_U_Full_Name.ToString()
                                sEmailContent &= vbCrLf & vbCrLf & "Next Approver: " & nStep
                                sEmailContent &= vbCrLf & vbCrLf & "https://eportal2.anflocor.com/"

                                '******control this notification for GGP*****
                                Select Case itemValue6.WFIN_SD_W_U_ID.ToString
                                    Case "8"

                                    Case Else
                                        '##################
                                        '### EMAIL HERE ###
                                        '##################
                                        Dim sInfo As String = ""
                                        'Dim sDelegate As String = FindDelegate(itemValue6.MRS_SD_W_U_ID.ToString(), sInfo)
                                        '' ''Dim esUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                                        sEmailContent = Content_Formatter(CStr(itemValue6.WFIN_SD_W_U_ID), _
                                        "FS Report Approval Needed (FS Document ID# " & sFinID & ")", CStr(sCo1), _
                                        sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                                        System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#4682b4", "Security/HomePage.aspx", sFinID, _
                                        "Next Approver: " & nStep, "Pending Approval")



                                        Send_Email_Notification(CStr(itemValue6.WFIN_SD_W_U_ID), "FS Approval Needed (Report Name: " & Me.HFIN_Description1.Text & _
                                                                 ")", sEmailContent)

                                End Select

                            Next

                        End If
                    Else 'just set current user status to 'Approved'
                        'note: this routine: requires another user to approve for the WF to move, so just update user's status
                        Dim wc5 As WhereClause = New WhereClause

                        'wc5.iAND(WFinRep_Activity1Table.AFIN_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc5.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc5.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                        wc5.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                        wc5.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        If WFinRep_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue5 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                'note: update Activity table (current user) -> 'Approved'
                                WFinRep_Activity1Record.UpdateRecord(itemValue5.AFIN_ID.ToString(), "5")

                            Next
                        End If

                        'Update_WFinRep_Head(CInt(sCo), CInt(6), CInt(sFinID))

                    End If
                End If


                ' ''Select Case System.Web.HttpContext.Current.Session("UserIDNorth").ToString
                ' ''    Case "8"
                ' ''        Dim url As String = "../WFinRep_Head1/WFinRep-Head1Record"
                ' ''        url = Me.ModifyRedirectUrl(url, "", False)
                ' ''        url = Me.Page.ModifyRedirectUrl(url, "", False)
                ' ''        Me.Page.ShouldSaveControlsToSession = True
                ' ''        Me.Page.Response.Redirect(url)
                ' ''    Case Else
                ' ''        Dim url As String = "../Security/HomePage.aspx"
                ' ''        ' ''Dim url As String = "../WFinRep_Head1/WFin-Approver-Table1.aspx"
                ' ''        url = Me.ModifyRedirectUrl(url, "", False)
                ' ''        url = Me.Page.ModifyRedirectUrl(url, "", False)
                ' ''        Me.Page.ShouldSaveControlsToSession = True
                ' ''        Me.Page.Response.Redirect(url)
                ' ''End Select

                Dim url As String = "../Security/HomePage.aspx"
                url = Me.ModifyRedirectUrl(url, "", False)
                url = Me.Page.ModifyRedirectUrl(url, "", False)
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            Catch ex As Exception
                Me.Page.ErrorOnPage = True

                'Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub


        Public Overrides Sub pReject_Click(ByVal sender As Object, ByVal args As EventArgs)

            Try

                Dim sFinID As String = Me.HFIN_ID.Text ''oRec.FIN_ID.Text
                Dim sCo1 As String = Me.HFIN_C_ID.Text ''oRec.FIN_Company1.SelectedItem.ToString
                Dim sYr As String = Me.HFIN_Year.Text ''oRec.FIN_Year1.Text
                Dim sMo As String = MonthName(CInt(Me.HFIN_Month2.Text)) ''MonthName(CInt(oRec.FIN_Month1.Text))
                Dim sDesc As String = "FS PACKAGE"
                Dim sType As String = ""
                Dim sCo As String = Me.HFIN_C_ID1.Text

                Dim drop As DropDownList = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlMoveTo"), System.Web.UI.WebControls.DropDownList)

                Dim wc1 As WhereClause = New WhereClause
                Dim sCurStep As String = ""
                Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Report Details:" & "@D" & vbCrLf & _
                vbCrLf & "Date: @RD" & vbCrLf & vbCrLf & "Comment(s): @Rem" & vbCrLf & "Type: @T"


                Dim sFSDetail As String = " "
                Dim sDeyt As String = sMo & vbCrLf & vbCrLf & sYr

                Dim sWhere1 As String = W_User1Table.W_U_ID.UniqueName & " = " & Me.HFIN_U_ID.Text
                Dim sUser As String = ""
                For Each oRec2 As W_User1Record In W_User1Table.GetRecords(sWhere1, Nothing, 0, 100)
                    sUser = oRec2.W_U_Full_Name.ToString()
                Next
                sFSDetail = Me.HFIN_Description1.Text


                Dim wc3 As WhereClause = New WhereClause


                sEmailContent = Replace(sEmailContent, "@C", Me.HFIN_C_ID.Text)
                sEmailContent = Replace(sEmailContent, "@D", sFSDetail)
                sEmailContent = Replace(sEmailContent, "@RD", sDeyt)
                sEmailContent = Replace(sEmailContent, "@Rem", "Report Name: " & sDesc & "</br>" & Me.txtRemarks.Text)
                sEmailContent = Replace(sEmailContent, "@T", sType)
                sEmailContent &= vbCrLf & "Requester: " & sUser
                sEmailContent &= vbCrLf & vbCrLf & "https://eportal2.anflocor.com"


                wc3.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc3.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc3.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                'note: check to see if record is still submitted, if not then do not save
                If WFinRep_Activity1Table.GetRecords(wc3, Nothing, 0, 100).Length > 0 Then
                    'note: get Current step to be used in wc2
                    For Each itemValue3 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                        sCurStep = itemValue3.AFIN_WS_ID.ToString
                    Next

                    Dim wc4 As WhereClause = New WhereClause

                    wc4.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc4.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                    wc4.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                    wc4.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                    For Each itemValue4 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                        'note: update Activity table (other user(s) if multiple approvers) -> 'System Rejected'
                        WFinRep_Activity1Record.UpdateRecord(itemValue4.AFIN_ID.ToString(), "12")
                    Next
                    'note: update current task status -> 'Rejected
                    Dim wc5 As WhereClause = New WhereClause

                    wc5.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc5.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                    wc5.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                    wc5.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                    If WFinRep_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                        For Each itemValue5 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                            'note: update Activity table (current user) -> 'Rejected'
                            'WFinRep_Activity1Record.UpdateRecord(itemValue5.AFIN_ID.ToString, "7")

                            Update_WFinRep_Activity(CInt(sCo), 7, CInt(sFinID), itemValue5.AFIN_ID.ToString, (DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & Me.txtRemarks.Text))
                        Next
                    End If

                    'note: insert user(s) to Activity using the chosen Return To field
                    Dim wc6 As WhereClause = New WhereClause
                    Dim Remarks As String = Me.HFIN_Remark.Text

                    If drop.SelectedValue.ToString() <> "0" Then 'not the creator
                        wc6.iAND(WFinRep_Step_StepDetail1View.WFIN_S_ID, BaseFilter.ComparisonOperator.EqualsTo, drop.SelectedValue.ToString())

                        For Each itemValue6 As WFinRep_Step_StepDetail1Record In WFinRep_Step_StepDetail1View.GetRecords(wc6, Nothing, 0, 100)
                            'note: use returned items to insert to Activity table
                            'note: do not insert(update) delegate until task expires
                            WFinRep_Activity1Record.AddRecord(itemValue6.WFIN_S_ID, itemValue6.WFIN_SD_ID, _
                                CInt(Me.HFIN_DT_ID1.SelectedValue), _
                                itemValue6.WFIN_SD_W_U_ID, 4, CInt(sFinID), _
                               (DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & Me.txtRemarks.Text))

                            '##################
                            '### EMAIL HERE ###
                            '##################
                            'email to Returned user
                            Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                            sEmailContent = Content_Formatter(itemValue6.WFIN_SD_W_U_ID.ToString(), _
                                 "FS INFORMATION NEEDED (Report Description " & sDesc & ")", CStr(sCo1), _
                                 sFSDetail, sDeyt, Me.txtRemarks.Text, sType, _
                                 System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#64d04b", "Security/HomePage.aspx", sFinID, _
                                 "Returned By " & sUserRej, "FS Rejected")

                            Send_Email_Notification(CStr(itemValue6.WFIN_SD_W_U_ID), "FS Information Needed (FS Report: " & _
                            sDesc & ")", sEmailContent)


                        Next
                    Else

                        wc6.iAND(WFinRep_Head1Table.HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        For Each itemValue6 As WFinRep_Head1Record In WFinRep_Head1Table.GetRecords(wc6, Nothing, 0, 100)

                            Update_WF_Status_Submit(sCo, "7", "0", sFinID, _
                            DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                            ": " & Me.txtRemarks.Text)
                            Update_WFinRep_Head(CInt(sCo), CInt(7), CInt(sFinID))
                            Update_WFinRep_DocAttach(CInt(sCo), CInt(7), CStr(sFinID), False)

                            '##################
                            '### EMAIL HERE ###
                            '##################
                            Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()
                            sEmailContent = Content_Formatter(itemValue6.HFIN_U_ID.ToString(), _
                                  "FS Information Needed (Report Description " & sDesc & ")", CStr(sCo1), _
                                  sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                                  System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#64d04b", "Security/HomePage.aspx", sFinID, _
                                  "Returned By " & sUserRej, "FS Rejected")


                            Send_Email_Notification(CStr(itemValue6.HFIN_U_ID), "FS Information Needed (Report Name: " & _
                            sDesc & ")", sEmailContent)

                            ' UPDATE GL_TRANSACTIONS_SUMMARY ISPOSTED FIELD
                            Dim reportType As String = Nothing


                            Dim result As String = Me.UpdatePostFlag(Me.HFIN_Year.Text, Me.HFIN_Month2.Text, Me.HFIN_C_ID1.Text, "0", "0")

                            If result <> "OK" Then
                                Throw New Exception(result.ToString)
                            End If

                            'WFinRep_DocAttachRecord.UpdateFinPost(Me.HFIN_ID.Text, 0)
                        Next
                    End If

                End If



                ' ''Select Case System.Web.HttpContext.Current.Session("UserIDNorth").ToString
                ' ''    Case "8"
                ' ''        Dim url As String = "../WFinRep_Head1/WFinRep-Head1Record"
                ' ''        url = Me.ModifyRedirectUrl(url, "", False)
                ' ''        url = Me.Page.ModifyRedirectUrl(url, "", False)
                ' ''        Me.Page.ShouldSaveControlsToSession = True
                ' ''        Me.Page.Response.Redirect(url)
                ' ''    Case Else
                ' ''        Dim url As String = "../WFinRep_Head1/WFIN-Approver-Table1.aspx"
                ' ''        url = Me.ModifyRedirectUrl(url, "", False)
                ' ''        url = Me.Page.ModifyRedirectUrl(url, "", False)
                ' ''        Me.Page.ShouldSaveControlsToSession = True
                ' ''        Me.Page.Response.Redirect(url)
                ' ''End Select

                Dim url As String = "../Security/HomePage.aspx"
                url = Me.ModifyRedirectUrl(url, "", False)
                url = Me.Page.ModifyRedirectUrl(url, "", False)
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            Catch ex As Exception
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        Public Overrides Sub pReturned_Click(ByVal sender As Object, ByVal args As EventArgs)

            'Dim oRec As WFinRep_DocAttachRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_DocAttachRecordControl"), WFinRep_DocAttachRecordControl)

            Dim sFinID As String = Me.HFIN_ID.Text ''oRec.FIN_ID.Text
            Dim sCo1 As String = Me.HFIN_C_ID.Text ''oRec.FIN_Company1.SelectedItem.ToString
            Dim sYr As String = Me.HFIN_Year.Text ''oRec.FIN_Year1.Text
            Dim sMo As String = MonthName(CInt(Me.HFIN_Month2.Text)) ''MonthName(CInt(oRec.FIN_Month1.Text))
            Dim sDesc As String = "FS PACKAGE"
            Dim sType As String = ""
            Dim sCo As String = Me.HFIN_C_ID1.Text

            Dim wc As WhereClause = New WhereClause

            wc.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
            wc.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
            wc.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")

            If WFinRep_Activity1Table.GetRecords(wc, Nothing, 0, 100).Length > 0 Then
                Dim currentStep As String = Nothing
                For Each itemValue As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc, Nothing, 0, 100)
                    currentStep = itemValue.AFIN_WS_ID.ToString
                Next

                'update co-approvers of the return status

                Dim wc2 As WhereClause = New WhereClause

                wc2.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc2.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc2.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")
                wc2.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, currentStep)

                For Each itemValue2 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc2, Nothing, 0, 100)
                    'note: update Activity table (other user(s) if multiple approvers) -> 'System Rejected'
                    WFinRep_Activity1Record.UpdateRecord(itemValue2.AFIN_ID.ToString(), "14")
                Next


                'Update CurrentStep as 'RETURNED' and other transaction tables.

                Dim wc3 As WhereClause = New WhereClause

                wc3.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc3.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc3.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")
                wc3.iAND(WFinRep_Activity1Table.AFIN_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, currentStep)

                If WFinRep_Activity1Table.GetRecords(wc3, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue3 As WFinRep_Activity1Record In WFinRep_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                        'note: update Activity table (current user) -> 'Rejected'
                        WFinRep_Activity1Record.UpdateRecord(itemValue3.AFIN_ID.ToString, "9")
                        Update_WFinRep_Head(CInt(sCo), CInt(9), CInt(sFinID))
                        Update_WFinRep_DocAttach(CInt(sCo), CInt(9), CStr(sFinID), False) ' UPDATE DOC_ATTACH TO NOT SUBMITTED
                        Update_WFinRep_Activity(CInt(sCo), 9, CInt(sFinID), itemValue3.AFIN_ID.ToString, DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                            ": " & Me.txtRemarks.Text)
                    Next
                End If

                'EMAIL HERE ALL APPROVERS of this DOCUMENT
                Dim whereClauseEmail As WhereClause = New WhereClause

                whereClauseEmail.iAND(WFinRep_Step_StepDetail1View.WFIN_S_WDT_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.HFIN_DT_ID1.SelectedValue)
                whereClauseEmail.iAND(WFinRep_Step_StepDetail1View.WFIN_SD_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                Dim sFSDetail As String = " "
                Dim sDeyt As String = sMo & vbCrLf & vbCrLf & sYr

                Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Report Details:" & "@D" & vbCrLf & _
                vbCrLf & "Date: @RD" & vbCrLf & vbCrLf & "Comment(s): @Rem" & vbCrLf & "Type: @T"
                sEmailContent = Replace(sEmailContent, "@C", Me.HFIN_C_ID.Text)
                sEmailContent = Replace(sEmailContent, "@D", sFSDetail)
                sEmailContent = Replace(sEmailContent, "@RD", sDeyt)
                sEmailContent = Replace(sEmailContent, "@Rem", "Report Name: " & sDesc & "</br>" & Me.txtRemarks.Text)
                sEmailContent = Replace(sEmailContent, "@T", sType)
                sEmailContent &= vbCrLf & "Requester: " & System.Web.HttpContext.Current.Session("UserIDNorth").ToString()
                sEmailContent &= vbCrLf & vbCrLf & "https://eportal2.anflocor.com"

                sFSDetail &= "Report Description: " & sDesc & vbCrLf & vbCrLf & _
                            "Year: " & sYr & vbCrLf & vbCrLf & _
                            "Month: " & sMo & "<br>"
                Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                If WFinRep_Step_StepDetail1View.GetRecords(whereClauseEmail, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue4 As WFinRep_Step_StepDetail1Record In WFinRep_Step_StepDetail1View.GetRecords(whereClauseEmail, Nothing, 0, 100)
                        If Not IsNothing(itemValue4.WFIN_SD_W_U_ID.ToString) Then
                            sEmailContent = Content_Formatter(itemValue4.WFIN_SD_W_U_ID.ToString, _
                             "FS RETURNED FOR REVISION INFORMATION (Report Description " & sDesc & ")", CStr(sCo1), _
                             sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                             System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#64d04b", "Security/HomePage.aspx", sFinID, _
                             "Returned By " & sUserRej, "FS Returned for Revision")

                            Send_Email_Notification(CStr(itemValue4.WFIN_SD_W_U_ID.ToString), "FS Returned for Revision Information (FS Report: " & _
                           sDesc & ")", sEmailContent)
                        End If
                    Next
                End If

                'EMAIL HERE CREATOR
                sEmailContent = Content_Formatter(Me.HFIN_U_ID.Text, _
                             "FS RETURNED FOR REVISION INFORMATION (Report Description " & sDesc & ")", CStr(sCo1), _
                             sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                             System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#64d04b", "WFinRep_Head1/WFin-Approver-Table1.aspx", sFinID, _
                             "Returned By " & sUserRej, "FS Returned for Revision")

                Send_Email_Notification(CStr(Me.HFIN_U_ID.Text), "FS Returned for Revision Information (FS Report: " & _
               sDesc & ")", sEmailContent)

            End If


            Dim del_result As String = Me.delete_GLTransactions_Summary(Me.HFIN_Year.Text, Me.HFIN_Month2.Text, Me.HFIN_C_ID1.Text, "0")

            If del_result <> "OK" Then
                Throw New Exception("ERROR: " & del_result & ".. Inform system administrator.")

            End If

            Dim update_result As String = Me.UpdatePostFlag(Me.HFIN_Year.Text, Me.HFIN_Month2.Text, Me.HFIN_C_ID1.Text, "0", "0")

            If update_result <> "OK" Then
                Throw New Exception("ERROR: " & update_result & ".. Inform system administrator.")

            End If

            'WFinRep_DocAttachRecord.UpdateFinPost(oRec.FIN_ID.Text, 0)

            Dim url As String = "../Security/HomePage.aspx"

            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = TargetKey
            Dim id As String = DFKA
            Dim value As String = id

            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", False)
                url = Me.Page.ModifyRedirectUrl(url, "", False)

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
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.CloseWindow(True)

            End If
        End Sub


        Private Function Update_WFinRep_Head(ByVal Company As Integer, ByVal Status As Integer, ByVal FIN_ID As Integer) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@FIN_ID", FIN_ID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)


            Dim parameterList(2) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "upd_WFinRep_Head", parameterList)

            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function

        Private Function Update_WFinRep_Activity(ByVal Company As Integer, ByVal Status As Integer, ByVal FIN_ID As Integer, ByVal activityID As String, ByVal remarks As String) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@FIN_ID", FIN_ID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)

            Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@ActivityID", activityID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)

            Dim fifthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            fifthParameter = New BaseClasses.Data.StoredProcedureParameter("@Remarks", remarks, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

            Dim parameterList(4) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = fifthParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "upd_WFinRep_Activity", parameterList)

            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function

        Private Function Update_WFinRep_DocAttach(ByVal Company As Integer, ByVal Status As Integer, ByVal FIN_ID As String, ByVal PostFlag As Boolean) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@FIN_ID", FIN_ID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)

            Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@PostFlag", PostFlag, System.Data.SqlDbType.Bit, System.Data.ParameterDirection.Input)


            Dim parameterList(3) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing
            ''original: upd_FS_WF_Status
            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "upd_FS_WF_Status", parameterList)

            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function


        Private Function Update_WF_Status_Submit(ByVal Company As String, ByVal Status As String, ByVal Submit As String, ByVal FIN_ID As String, ByVal Remarks As String) As String

            '' USE THIS TO UPDATE THE WFINREP_HEAD

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@FIN_ID", FIN_ID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

            Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@Submit", Submit, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

            Dim fifthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            fifthParameter = New BaseClasses.Data.StoredProcedureParameter("@Remarks", Remarks, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)



            Dim parameterList(4) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter
            parameterList(4) = fifthParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "upd_FSWF_Status_Submit", parameterList)

            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return "ERR"
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function


        Public Function UpdatePostFlag(ByVal inputYear As String, ByVal inputMonth As String, ByVal inputCompany As String, ByVal reportID As String, ByVal postFlag As String) As String

            Dim sqlCmd As New SqlCommand
            Dim sqlCnn As SqlConnection = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("DatabaseANFLO-WFN").ConnectionString)
            Try
                With sqlCmd
                    .Connection = sqlCnn 'New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("DatabaseANFLO-WF1").ConnectionString)
                    .Connection.Open()
                    .CommandType = System.Data.CommandType.StoredProcedure
                    .CommandText = "upd_GL_Transactions_Summary_PostFlag"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Company", CInt(inputCompany))
                    .Parameters.AddWithValue("@Month", CInt(inputMonth))
                    .Parameters.AddWithValue("@Year", CInt(inputYear))
                    .Parameters.AddWithValue("@ReportID", CInt(reportID))
                    .Parameters.AddWithValue("@PostFlag", CInt(postFlag))
                    .ExecuteNonQuery()
                End With
                Dim postmsg As String = Nothing
                If postFlag = "0" Then
                    postmsg = "Closed"
                Else : postmsg = "Opened"
                End If

                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "MyAlertName", "Successfully " & postmsg & " report data.")

                Return "OK"

                sqlCmd.Dispose()
                sqlCmd.Connection.Close()
            Catch ex As Exception
                Throw New Exception("Error occured: " & ex.Message)
                Return ex.Message

            End Try

        End Function

        Public Function delete_GLTransactions_Summary(ByVal inputYear As String, ByVal inputMonth As String, ByVal inputCompany As String, ByVal reportID As String) As String

            Dim sqlCmd As New SqlCommand
            Dim sqlCnn As SqlConnection = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("DatabaseANFLO-WFN").ConnectionString)
            Try
                With sqlCmd
                    .Connection = sqlCnn 'New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("DatabaseANFLO-WF1").ConnectionString)
                    .Connection.Open()
                    .CommandType = System.Data.CommandType.StoredProcedure
                    .CommandText = "del_GL_Transactions_Summary"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Company", CInt(inputCompany))
                    .Parameters.AddWithValue("@Month", CInt(inputMonth))
                    .Parameters.AddWithValue("@Year", CInt(inputYear))
                    .Parameters.AddWithValue("@ReportID", CInt(reportID))
                    .ExecuteNonQuery()
                End With


                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "MyAlertName", "Successfully deleted all report data.")

                Return "OK"

                sqlCmd.Dispose()
                sqlCmd.Connection.Close()
            Catch ex As Exception
                Throw New Exception("Error occured: " & ex.Message)
                Return ex.Message

            End Try

        End Function

        Public Overrides Sub SetDescription_MY()

            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.Description_MY.Text = "Some value"
            Me.Description_MY.Text = Me.DataSource.HFIN_Description.ToString & " " & MonthName(CInt(Me.DataSource.HFIN_Month.ToString)) & " " & Me.DataSource.HFIN_Year.ToString
        End Sub

    
		Public Overrides Sub SetHFIN_Description1()
            
        
            ' Set the HFIN_Description Literal on the webpage with value from the
            ' WFinRep_Head database record.

            ' Me.DataSource is the WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Description1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Description1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DescriptionSpecified Then
                				
                ' If the HFIN_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Description1.Text = Me.DataSource.HFIN_Description.ToString & " " & MonthName(CInt(Me.DataSource.HFIN_Month.ToString)) & " " & Me.DataSource.HFIN_Year.ToString
                
            Else 
            
                ' HFIN_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.HFIN_Description1.Text = WFinRep_Head1Table.HFIN_Description.Format(WFinRep_Head1Table.HFIN_Description.DefaultValue)
                        		
                End If
                 
        End Sub

        Protected Overrides Sub PopulateddlMoveToDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)

            Me.ddlMoveTo.Items.Clear()

            Dim oHeader As WFinRep_HeadRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadRecordControl"), WFinRep_HeadRecordControl)

            Dim wc As WhereClause = CreateWhereClause_ddlMoveToDropDownList()


            Dim drop As DropDownList = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlMoveTo"), System.Web.UI.WebControls.DropDownList)

            drop.Enabled = True
            drop.Items.Clear()
            'note: this populates the Return To drop down
            Dim wc1 As WhereClause = New WhereClause

            wc1.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.HFIN_ID.ToString)
            wc1.iAND(WFinRep_Activity1Table.AFIN_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
            wc1.iAND(WFinRep_Activity1Table.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
            Dim sWhere As String = WFinRep_Activity1Table.AFIN_HFIN_ID.UniqueName & "='" & Me.DataSource.HFIN_ID.ToString & "' And " & WFinRep_Activity1Table.AFIN_W_U_ID.UniqueName & _
            " = '" & System.Web.HttpContext.Current.Session("UserIDNorth").ToString() & "' And " & WFinRep_Activity1Table.AFIN_Status.UniqueName & " = 4"

            Dim itemValue1 As WFinRep_Activity1Record
            Dim bNoParent As Boolean = False
            Dim sStepID As String = ""
            Dim sStepType As String = ""
            For Each itemValue1 In WFinRep_Activity1Table.GetRecords(sWhere, Nothing, 0, 100)
                If (itemValue1.AFIN_IDSpecified) Then
                    sStepID = itemValue1.AFIN_WS_ID.ToString()

                    Do While sStepType <> "Start"
                        Dim wc2 As WhereClause = New WhereClause
                        Dim itemValue2 As WFinRep_Step1Record
                        wc2.iAND(WFinRep_Step1Table.WFIN_S_ID_Next, BaseFilter.ComparisonOperator.EqualsTo, sStepID)


                        If WFinRep_Step1Table.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue2 In WFinRep_Step1Table.GetRecords(wc2, Nothing, 0, 100)
                                If itemValue2.WFIN_S_IDSpecified Then
                                    Dim cvalue As String = Nothing
                                    Dim fvalue As String = Nothing

                                    cvalue = itemValue2.WFIN_S_ID.ToString()
                                    fvalue = itemValue2.WFIN_S_Desc.ToString()
                                    sStepID = cvalue
                                    sStepType = itemValue2.WFIN_S_Step_Type

                                    Dim item As ListItem = New ListItem(fvalue, cvalue)
                                    drop.Items.Add(item)
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
            fvalue1 = "Bookeeper"

            Dim item1 As ListItem = New ListItem(fvalue1, cvalue1)
            Me.ddlMoveTo.Items.Add(item1)

            If Me.ddlMoveTo.Items.Count > 0 Then
                'note: default to first step
                Me.ddlMoveTo.SelectedIndex = Me.ddlMoveTo.Items.Count - 1
            End If

        End Sub
End Class



    Public Class WFinRep_HeadTableControl
        Inherits BaseWFinRep_HeadTableControl

        ' The BaseWFinRep_HeadTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WFinRep_HeadTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    End Class
    Public Class WFinRep_HeadTableControlRow
        Inherits BaseWFinRep_HeadTableControlRow
        ' The BaseWFinRep_HeadTableControlRow implements code for a ROW within the
        ' the WFinRep_HeadTableControl table.  The BaseWFinRep_HeadTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_HeadTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.

        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
            Me.Page.LoadFocusScripts(Me)


            ' Register the event handlers.

            'AddHandler Me.btnPreview.Button.Click, AddressOf btnPreview_Click

            AddHandler Me.HFIN_C_ID3.TextChanged, AddressOf HFIN_C_ID3_TextChanged

            AddHandler Me.HFIN_Month1.TextChanged, AddressOf HFIN_Month1_TextChanged


            Dim oHeader As WFinRep_HeadRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadRecordControl"), WFinRep_HeadRecordControl)

            Me.btnPreview.Button.Attributes.Add("onClick", "OpenRptViewerApp('" & Me.HFIN_Year1.ClientID & "','" & Me.HFIN_Month1.ClientID & "', '" & oHeader.HFIN_C_ID1.ClientID & "', '" & oHeader.HFIN_Description1.ClientID & "');return false;")

        End Sub

		Public Overrides Sub SetHFIN_File()

            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_FileSpecified Then

                Me.HFIN_File.Text = Page.GetResourceValue("Txt:OpenFile", "EPORTAL")

                Me.HFIN_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRep_Head1") & _
                            "&Field=" & Me.Page.Encrypt("HFIN_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                Me.btnPreview1.Button.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRep_Head1") & _
                            "&Field=" & Me.Page.Encrypt("HFIN_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                ' Me.HFIN_File.Visible = True
            Else
                '  Me.HFIN_File.Visible = False
            End If
        End Sub

            
    End Class
    Public Class WFinRep_Activity1TableControl
        Inherits BaseWFinRep_Activity1TableControl

        ' The BaseWFinRep_Activity1TableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WFinRep_Activity1TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    End Class
    Public Class WFinRep_Activity1TableControlRow
        Inherits BaseWFinRep_Activity1TableControlRow
        ' The BaseWFinRep_Activity1TableControlRow implements code for a ROW within the
        ' the WFinRep_Activity1TableControl table.  The BaseWFinRep_Activity1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_Activity1TableControl.

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
    Public Class WFinRep_DocAttachTableControl
        Inherits BaseWFinRep_DocAttachTableControl

        ' The BaseWFinRep_DocAttachTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WFinRep_DocAttachTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRep_DocAttach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            Dim wFinRep_HeadTableControlObjRow As WFinRep_HeadTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControlRow"), WFinRep_HeadTableControlRow)

            Dim sFinID As String = wFinRep_HeadTableControlObjRow.HFIN_ID1.Text 'CStr(Me.Page.Request.QueryString("WFinRep_Head"))


            wc.iAND(WFinRep_DocAttach1Table.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID.ToString)

            Dim selectedRecordKeyValue As KeyValue = New KeyValue()

            Dim wFinRep_HeadRecordObj As KeyValue
            wFinRep_HeadRecordObj = Nothing


            If (Not IsNothing(wFinRep_HeadTableControlObjRow) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord().HFIN_FinID)) Then
                wc.iAND(WFinRep_DocAttach1Table.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_HeadTableControlObjRow.GetRecord().HFIN_ID.ToString())
            Else
                wc.RunQuery = False
                Return wc
            End If

            HttpContext.Current.Session("WFinRep_DocAttachTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()

            Return wc
        End Function
    End Class
    Public Class WFinRep_DocAttachTableControlRow
        Inherits BaseWFinRep_DocAttachTableControlRow
        ' The BaseWFinRep_DocAttachTableControlRow implements code for a ROW within the
        ' the WFinRep_DocAttachTableControl table.  The BaseWFinRep_DocAttachTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_DocAttachTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


    End Class
#End Region



#Region "Section 2: Do not modify this section."
    
    
' Base class for the Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow control on the WFin_ApproverPage1 page.
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
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseVw_FS_WFinRep_Attachment_PerReportTypeTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Vw_FS_WFinRep_Attachment_PerReportType1Record()
          
    
    
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
            ' DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRA_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRA_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRA_DescSpecified Then
                				
                ' If the WFRA_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRA_Desc.Text = formattedValue
                
            Else 
            
                ' WFRA_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRA_Desc.Text = Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc.DefaultValue)
                        		
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
                            Me.Page.Encrypt("Vw_FS_WFinRep_Attachment_PerReportType1") & _
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
            ' DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRT_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRT_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRT_DescriptionSpecified Then
                				
                ' If the WFRT_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.Vw_FS_WFinRep_Attachment_PerReportType1View, App_Code\"",\""" _
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
        
                 Me.WFRT_Description.Text = Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.DefaultValue)
                        		
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
        
        Dim parentCtrl As WFinRep_HeadRecordControl
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadRecordControl"), WFinRep_HeadRecordControl)				  
              
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
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
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
          Vw_FS_WFinRep_Attachment_PerReportType1View.DeleteRecord(pkValue)
          
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
            
        Public Property DataSource() As Vw_FS_WFinRep_Attachment_PerReportType1Record
            Get
                Return DirectCast(MyBase._DataSource, Vw_FS_WFinRep_Attachment_PerReportType1Record)
            End Get
            Set(ByVal value As Vw_FS_WFinRep_Attachment_PerReportType1Record)
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
            
            Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing
             
        
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
            
            Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Vw_FS_WFinRep_Attachment_PerReportType1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Vw_FS_WFinRep_Attachment_PerReportTypeTableControl control on the WFin_ApproverPage1 page.
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
            
              AddHandler Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.FirstPage.Click, AddressOf Vw_FS_WFinRep_Attachment_PerReportTypePagination_FirstPage_Click
                        
              AddHandler Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.LastPage.Click, AddressOf Vw_FS_WFinRep_Attachment_PerReportTypePagination_LastPage_Click
                        
              AddHandler Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.NextPage.Click, AddressOf Vw_FS_WFinRep_Attachment_PerReportTypePagination_NextPage_Click
                        
              AddHandler Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.PageSizeButton.Click, AddressOf Vw_FS_WFinRep_Attachment_PerReportTypePagination_PageSizeButton_Click
                        
              AddHandler Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.PreviousPage.Click, AddressOf Vw_FS_WFinRep_Attachment_PerReportTypePagination_PreviousPage_Click
                                    
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1Record)), Vw_FS_WFinRep_Attachment_PerReportType1Record())
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
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1Record)), Vw_FS_WFinRep_Attachment_PerReportType1Record())
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
            ByVal pageSize As Integer) As Vw_FS_WFinRep_Attachment_PerReportType1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column1, True)         
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column2, True)          
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New Vw_FS_WFinRep_Attachment_PerReportType1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1Record)), Vw_FS_WFinRep_Attachment_PerReportType1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column1, True)         
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column2, True)          
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Vw_FS_WFinRep_Attachment_PerReportType1View
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
                    
                Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.CurrentPage.Text = "0"
            End If
            Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.PageSize.Text = Me.PageSize.ToString()
            Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for Vw_FS_WFinRep_Attachment_PerReportTypeTableControl pagination.
        
            Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


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
            Vw_FS_WFinRep_Attachment_PerReportType1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim wFinRep_HeadRecordControlObj as WFinRep_HeadRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadRecordControl") ,WFinRep_HeadRecordControl)
                              
                If (Not IsNothing(wFinRep_HeadRecordControlObj) AndAlso Not IsNothing(wFinRep_HeadRecordControlObj.GetRecord()) AndAlso wFinRep_HeadRecordControlObj.GetRecord().IsCreated AndAlso Not IsNothing(wFinRep_HeadRecordControlObj.GetRecord().HFIN_ID))
                    wc.iAND(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_HeadRecordControlObj.GetRecord().HFIN_ID.ToString())
                    selectedRecordKeyValue.AddElement(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID.InternalName, wFinRep_HeadRecordControlObj.GetRecord().HFIN_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If          
              
      HttpContext.Current.Session("Vw_FS_WFinRep_Attachment_PerReportTypeTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Vw_FS_WFinRep_Attachment_PerReportType1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRep_HeadRecordControl as String = DirectCast(HttpContext.Current.Session("Vw_FS_WFinRep_Attachment_PerReportTypeTableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRep_HeadRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRep_HeadRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRep_HeadRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID) Then
            wc.iAND(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID).ToString())
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
        
            If Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.PageSize.Text)
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
                        Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = New Vw_FS_WFinRep_Attachment_PerReportType1Record()
        
                        If recControl.WFRA_Desc.Text <> "" Then
                            rec.Parse(recControl.WFRA_Desc.Text, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc)
                        End If
                        If recControl.WFRA_Doc.Text <> "" Then
                            rec.Parse(recControl.WFRA_Doc.Text, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Doc)
                        End If
                        If recControl.WFRT_Description.Text <> "" Then
                            rec.Parse(recControl.WFRT_Description.Text, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New Vw_FS_WFinRep_Attachment_PerReportType1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1Record)), Vw_FS_WFinRep_Attachment_PerReportType1Record())
              
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
            
            
            Dim Pagination As Control = Me.FindControl("Vw_FS_WFinRep_Attachment_PerReportTypePagination")
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
        Public Overridable Sub Vw_FS_WFinRep_Attachment_PerReportTypePagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Vw_FS_WFinRep_Attachment_PerReportTypePagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Vw_FS_WFinRep_Attachment_PerReportTypePagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Vw_FS_WFinRep_Attachment_PerReportTypePagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Vw_FS_WFinRep_Attachment_PerReportTypePagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Vw_FS_WFinRep_Attachment_PerReportTypePagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
                    _TotalRecords = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As Vw_FS_WFinRep_Attachment_PerReportType1Record ()
            Get
                Return DirectCast(MyBase._DataSource, Vw_FS_WFinRep_Attachment_PerReportType1Record())
            End Get
            Set(ByVal value() As Vw_FS_WFinRep_Attachment_PerReportType1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Vw_FS_WFinRep_Attachment_PerReportTypePagination() As ePortalWFApproval.UI.IPaginationMedium
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportTypePagination"), ePortalWFApproval.UI.IPaginationMedium)
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
                Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing     
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
                Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing     
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

  
' Base class for the WFinRep_Activity1TableControlRow control on the WFin_ApproverPage1 page.
' Do not modify this class. Instead override any method in WFinRep_Activity1TableControlRow.
Public Class BaseWFinRep_Activity1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_Activity1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_Activity1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRep_Activity record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_Activity1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_Activity1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_Activity1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_Activity1TableControlRow.
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
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Date_Action is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_ActionSpecified Then
                				
                ' If the AFIN_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Action.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Action.Text = WFinRep_Activity1Table.AFIN_Date_Action.Format(WFinRep_Activity1Table.AFIN_Date_Action.DefaultValue, "g")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetAFIN_Date_Assign()

                  
            
        
            ' Set the AFIN_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_AssignSpecified Then
                				
                ' If the AFIN_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Assign.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Assign.Text = WFinRep_Activity1Table.AFIN_Date_Assign.Format(WFinRep_Activity1Table.AFIN_Date_Assign.DefaultValue, "g")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetAFIN_Remark()

                  
            
        
            ' Set the AFIN_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_RemarkSpecified Then
                				
                ' If the AFIN_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Remark)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(WFinRep_Activity1Table.AFIN_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WFinRep_Activity1Table, App_Code\"",\""" _
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
        
                 Me.AFIN_Remark.Text = WFinRep_Activity1Table.AFIN_Remark.Format(WFinRep_Activity1Table.AFIN_Remark.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetAFIN_Status()

                  
            
        
            ' Set the AFIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_StatusSpecified Then
                				
                ' If the AFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Activity1Table.AFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Activity1Table.AFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Activity1Table.GetDFKA(Me.DataSource.AFIN_Status.ToString(),WFinRep_Activity1Table.AFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Status.Text = formattedValue
                
            Else 
            
                ' AFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Status.Text = WFinRep_Activity1Table.AFIN_Status.Format(WFinRep_Activity1Table.AFIN_Status.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetAFIN_W_U_ID()

                  
            
        
            ' Set the AFIN_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_W_U_IDSpecified Then
                				
                ' If the AFIN_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Activity1Table.AFIN_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Activity1Table.AFIN_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Activity1Table.GetDFKA(Me.DataSource.AFIN_W_U_ID.ToString(),WFinRep_Activity1Table.AFIN_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_W_U_ID.Text = formattedValue
                
            Else 
            
                ' AFIN_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_W_U_ID.Text = WFinRep_Activity1Table.AFIN_W_U_ID.Format(WFinRep_Activity1Table.AFIN_W_U_ID.DefaultValue)
                        		
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

      
        
        ' To customize, override this method in WFinRep_Activity1TableControlRow.
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
        
        Dim parentCtrl As WFinRep_HeadRecordControl
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadRecordControl"), WFinRep_HeadRecordControl)				  
              
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
              
                DirectCast(GetParentControlObject(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl).ResetData = True
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

        ' To customize, override this method in WFinRep_Activity1TableControlRow.
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
                
      
        ' To customize, override this method in WFinRep_Activity1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRep_Activity1TableControlRow.
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
          WFinRep_Activity1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWFinRep_Activity1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRep_Activity1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRep_Activity1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Activity1Record)
            End Get
            Set(ByVal value As WFinRep_Activity1Record)
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
            
            Dim rec As WFinRep_Activity1Record = Nothing
             
        
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
            
            Dim rec As WFinRep_Activity1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_Activity1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_Activity1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRep_Activity1TableControl control on the WFin_ApproverPage1 page.
' Do not modify this class. Instead override any method in WFinRep_Activity1TableControl.
Public Class BaseWFinRep_Activity1TableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_Activity1Record)), WFinRep_Activity1Record())
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
                    For Each rc As WFinRep_Activity1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_Activity1Record)), WFinRep_Activity1Record())
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
            ByVal pageSize As Integer) As WFinRep_Activity1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_Activity1Table.Column1, True)         
            ' selCols.Add(WFinRep_Activity1Table.Column2, True)          
            ' selCols.Add(WFinRep_Activity1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_Activity1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_Activity1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_Activity1Record)), WFinRep_Activity1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_Activity1Table.Column1, True)         
            ' selCols.Add(WFinRep_Activity1Table.Column2, True)          
            ' selCols.Add(WFinRep_Activity1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_Activity1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_Activity1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRep_Activity1TableControlRow = DirectCast(repItem.FindControl("WFinRep_Activity1TableControlRow"), WFinRep_Activity1TableControlRow)
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
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_W_U_ID, Me.DataSource)
          
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
        

            ' Bind the buttons for WFinRep_Activity1TableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRep_Activity1TableControlRow
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
            WFinRep_Activity1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim wFinRep_HeadRecordControlObj as WFinRep_HeadRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadRecordControl") ,WFinRep_HeadRecordControl)
                              
                If (Not IsNothing(wFinRep_HeadRecordControlObj) AndAlso Not IsNothing(wFinRep_HeadRecordControlObj.GetRecord()) AndAlso wFinRep_HeadRecordControlObj.GetRecord().IsCreated AndAlso Not IsNothing(wFinRep_HeadRecordControlObj.GetRecord().HFIN_ID))
                    wc.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_HeadRecordControlObj.GetRecord().HFIN_ID.ToString())
                    selectedRecordKeyValue.AddElement(WFinRep_Activity1Table.AFIN_HFIN_ID.InternalName, wFinRep_HeadRecordControlObj.GetRecord().HFIN_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If          
              
      HttpContext.Current.Session("WFinRep_Activity1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRep_Activity1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRep_HeadRecordControl as String = DirectCast(HttpContext.Current.Session("WFinRep_Activity1TableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRep_HeadRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRep_HeadRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRep_HeadRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRep_Activity1Table.AFIN_HFIN_ID) Then
            wc.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRep_Activity1Table.AFIN_HFIN_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_Activity1TableControlRow = DirectCast(repItem.FindControl("WFinRep_Activity1TableControlRow"), WFinRep_Activity1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_Activity1Record = New WFinRep_Activity1Record()
        
                        If recControl.AFIN_Date_Action.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Action.Text, WFinRep_Activity1Table.AFIN_Date_Action)
                        End If
                        If recControl.AFIN_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Assign.Text, WFinRep_Activity1Table.AFIN_Date_Assign)
                        End If
                        If recControl.AFIN_Remark.Text <> "" Then
                            rec.Parse(recControl.AFIN_Remark.Text, WFinRep_Activity1Table.AFIN_Remark)
                        End If
                        If recControl.AFIN_Status.Text <> "" Then
                            rec.Parse(recControl.AFIN_Status.Text, WFinRep_Activity1Table.AFIN_Status)
                        End If
                        If recControl.AFIN_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_W_U_ID.Text, WFinRep_Activity1Table.AFIN_W_U_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_Activity1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_Activity1Record)), WFinRep_Activity1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRep_Activity1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRep_Activity1TableControlRow) As Boolean
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

            Dim orderByStr As String = CType(ViewState("WFinRep_Activity1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRep_Activity1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WFinRep_Activity1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRep_Activity1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Activity1Record())
            End Get
            Set(ByVal value() As WFinRep_Activity1Record)
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
                Dim recCtl As WFinRep_Activity1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_Activity1Record = Nothing     
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
                Dim recCtl As WFinRep_Activity1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_Activity1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRep_Activity1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRep_Activity1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRep_Activity1TableControlRow)), WFinRep_Activity1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRep_Activity1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRep_Activity1TableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRep_Activity1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRep_Activity1TableControlRow")
            Dim list As New List(Of WFinRep_Activity1TableControlRow)
            For Each recCtrl As WFinRep_Activity1TableControlRow In recCtrls
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

  
' Base class for the WFinRep_DocAttachTableControlRow control on the WFin_ApproverPage1 page.
' Do not modify this class. Instead override any method in WFinRep_DocAttachTableControlRow.
Public Class BaseWFinRep_DocAttachTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_DocAttachTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_DocAttachTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_DocAttach1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_DocAttachTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_DocAttach1Record()
          
    
    
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
        
                SetFIn_Description()
                SetFIN_RWRem()
                SetFIN_Type()
      
      
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
        
        
        Public Overridable Sub SetFIn_Description()

                  
            
        
            ' Set the FIn_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIn_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIn_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIn_DescriptionSpecified Then
                				
                ' If the FIn_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIn_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIn_Description.Text = formattedValue
                
            Else 
            
                ' FIn_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIn_Description.Text = WFinRep_DocAttach1Table.FIn_Description.Format(WFinRep_DocAttach1Table.FIn_Description.DefaultValue)
                        		
                End If
                 
            ' If the FIn_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIn_Description.Text Is Nothing _
                OrElse Me.FIn_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIn_Description.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_RWRem()

                  
            
        
            ' Set the FIN_RWRem Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_RWRem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_RWRem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_RWRemSpecified Then
                				
                ' If the FIN_RWRem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_RWRem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_RWRem.Text = formattedValue
                
            Else 
            
                ' FIN_RWRem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_RWRem.Text = WFinRep_DocAttach1Table.FIN_RWRem.Format(WFinRep_DocAttach1Table.FIN_RWRem.DefaultValue)
                        		
                End If
                 
            ' If the FIN_RWRem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_RWRem.Text Is Nothing _
                OrElse Me.FIN_RWRem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_RWRem.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Type()

                  
            
        
            ' Set the FIN_Type Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Type is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_TypeSpecified Then
                				
                ' If the FIN_Type is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_Type)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Type.Text = formattedValue
                
            Else 
            
                ' FIN_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Type.Text = WFinRep_DocAttach1Table.FIN_Type.Format(WFinRep_DocAttach1Table.FIN_Type.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Type is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Type.Text Is Nothing _
                OrElse Me.FIN_Type.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Type.Text = "&nbsp;"
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
        
            GetFIn_Description()
            GetFIN_RWRem()
            GetFIN_Type()
        End Sub
        
        
        Public Overridable Sub GetFIn_Description()
            
        End Sub
                
        Public Overridable Sub GetFIN_RWRem()
            
        End Sub
                
        Public Overridable Sub GetFIN_Type()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_DocAttachTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
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
          WFinRep_DocAttach1Table.DeleteRecord(pkValue)
          
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
            
        Public Property DataSource() As WFinRep_DocAttach1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_DocAttach1Record)
            End Get
            Set(ByVal value As WFinRep_DocAttach1Record)
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
        
        Public ReadOnly Property FIn_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIn_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_RWRem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_RWRem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_Type() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Type"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WFinRep_DocAttach1Record = Nothing
             
        
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
            
            Dim rec As WFinRep_DocAttach1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_DocAttach1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_DocAttach1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRep_DocAttachTableControl control on the WFin_ApproverPage1 page.
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
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "1000"))
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_DocAttach1Record)), WFinRep_DocAttach1Record())
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
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_DocAttach1Record)), WFinRep_DocAttach1Record())
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
            ByVal pageSize As Integer) As WFinRep_DocAttach1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_DocAttach1Table.Column1, True)         
            ' selCols.Add(WFinRep_DocAttach1Table.Column2, True)          
            ' selCols.Add(WFinRep_DocAttach1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_DocAttach1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_DocAttach1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_DocAttach1Record)), WFinRep_DocAttach1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_DocAttach1Table.Column1, True)         
            ' selCols.Add(WFinRep_DocAttach1Table.Column2, True)          
            ' selCols.Add(WFinRep_DocAttach1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_DocAttach1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_DocAttach1Table
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
        
                SetFIn_DescriptionLabel()
                SetFIN_RWRemLabel()
                SetFIN_TypeLabel()
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
        

            ' Bind the buttons for WFinRep_DocAttachTableControl pagination.
        


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
            WFinRep_DocAttach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRep_Head1RecordObj as KeyValue
        wFinRep_Head1RecordObj = Nothing
      
              Dim wFinRep_HeadTableControlObjRow As WFinRep_HeadTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_HeadTableControlRow") ,WFinRep_HeadTableControlRow)
            
                If (Not IsNothing(wFinRep_HeadTableControlObjRow) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRep_HeadTableControlObjRow.GetRecord().HFIN_FinID))
                    wc.iAND(WFinRep_DocAttach1Table.FIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_HeadTableControlObjRow.GetRecord().HFIN_FinID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WFinRep_DocAttachTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRep_DocAttach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRep_HeadTableControl as String = DirectCast(HttpContext.Current.Session("WFinRep_DocAttachTableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRep_HeadTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRep_HeadTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRep_HeadTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRep_DocAttach1Table.FIN_ID) Then
            wc.iAND(WFinRep_DocAttach1Table.FIN_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRep_DocAttach1Table.FIN_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_DocAttachTableControlRow = DirectCast(repItem.FindControl("WFinRep_DocAttachTableControlRow"), WFinRep_DocAttachTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_DocAttach1Record = New WFinRep_DocAttach1Record()
        
                        If recControl.FIn_Description.Text <> "" Then
                            rec.Parse(recControl.FIn_Description.Text, WFinRep_DocAttach1Table.FIn_Description)
                        End If
                        If recControl.FIN_RWRem.Text <> "" Then
                            rec.Parse(recControl.FIN_RWRem.Text, WFinRep_DocAttach1Table.FIN_RWRem)
                        End If
                        If recControl.FIN_Type.Text <> "" Then
                            rec.Parse(recControl.FIN_Type.Text, WFinRep_DocAttach1Table.FIN_Type)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_DocAttach1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_DocAttach1Record)), WFinRep_DocAttach1Record())
              
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
        
        Public Overridable Sub SetFIn_DescriptionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FIn_DescriptionLabel.Text = "Some value"
                    
                  End Sub
                
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
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WFinRep_DocAttach1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRep_DocAttach1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_DocAttach1Record())
            End Get
            Set(ByVal value() As WFinRep_DocAttach1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property FIn_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIn_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
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
                Dim rec As WFinRep_DocAttach1Record = Nothing     
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
                Dim rec As WFinRep_DocAttach1Record = Nothing     
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

  
' Base class for the WFinRep_HeadTableControlRow control on the WFin_ApproverPage1 page.
' Do not modify this class. Instead override any method in WFinRep_HeadTableControlRow.
Public Class BaseWFinRep_HeadTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_HeadTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_HeadTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.btnPreview.Button.Click, AddressOf btnPreview_Click
                        
              AddHandler Me.btnPreview1.Button.Click, AddressOf btnPreview1_Click
                        
              AddHandler Me.HFIN_C_ID3.TextChanged, AddressOf HFIN_C_ID3_TextChanged
            
              AddHandler Me.HFIN_ID1.TextChanged, AddressOf HFIN_ID1_TextChanged
            
              AddHandler Me.HFIN_Month1.TextChanged, AddressOf HFIN_Month1_TextChanged
            
              AddHandler Me.HFIN_Status2.TextChanged, AddressOf HFIN_Status2_TextChanged
            
              AddHandler Me.HFIN_Year2.TextChanged, AddressOf HFIN_Year2_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_Head1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_HeadTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_Head1Record()
          
    
    
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
        
                
                
                SetHFIN_C_ID2()
                SetHFIN_C_ID3()
                SetHFIN_Description()
                SetHFIN_File()
                SetHFIN_ID1()
                SetHFIN_Month()
                SetHFIN_Month1()
                SetHFIN_Remark1()
                SetHFIN_RptCount()
                SetHFIN_Status2()
                SetHFIN_Year1()
                SetHFIN_Year2()
                SetWfin_HeadTabContainer()
                
                SetbtnPreview()
              
                SetbtnPreview1()
              
      
      
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
                      
        SetWFinRep_DocAttachTableControl()
        
        End Sub
        
        
        Public Overridable Sub SetHFIN_C_ID2()

                  
            
        
            ' Set the HFIN_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then
                				
                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_C_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_C_ID.ToString(),WFinRep_Head1Table.HFIN_C_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_C_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_C_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_C_ID2.Text = formattedValue
                
            Else 
            
                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_C_ID2.Text = WFinRep_Head1Table.HFIN_C_ID.Format(WFinRep_Head1Table.HFIN_C_ID.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_C_ID2.Text Is Nothing _
                OrElse Me.HFIN_C_ID2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_C_ID2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_C_ID3()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_C_ID3.ID) Then
            
                Me.HFIN_C_ID3.Text = Me.PreviousUIData(Me.HFIN_C_ID3.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_C_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID3 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID3()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then
                				
                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_C_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_C_ID.ToString(),WFinRep_Head1Table.HFIN_C_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_C_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_C_ID.ToString()
                End If
                                
                Me.HFIN_C_ID3.Text = formattedValue
                
            Else 
            
                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_C_ID3.Text = WFinRep_Head1Table.HFIN_C_ID.Format(WFinRep_Head1Table.HFIN_C_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_C_ID3.TextChanged, AddressOf HFIN_C_ID3_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Description()

                  
            
        
            ' Set the HFIN_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DescriptionSpecified Then
                				
                ' If the HFIN_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Description.Text = formattedValue
                
            Else 
            
                ' HFIN_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Description.Text = WFinRep_Head1Table.HFIN_Description.Format(WFinRep_Head1Table.HFIN_Description.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Description.Text Is Nothing _
                OrElse Me.HFIN_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Description.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_FileSpecified Then
                
                Me.HFIN_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.HFIN_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRep_Head1") & _
                            "&Field=" & Me.Page.Encrypt("HFIN_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.HFIN_File.Visible = True
            Else
                Me.HFIN_File.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetHFIN_ID1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_ID1.ID) Then
            
                Me.HFIN_ID1.Text = Me.PreviousUIData(Me.HFIN_ID1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_IDSpecified Then
                				
                ' If the HFIN_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_ID)
                              
                Me.HFIN_ID1.Text = formattedValue
                
            Else 
            
                ' HFIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_ID1.Text = WFinRep_Head1Table.HFIN_ID.Format(WFinRep_Head1Table.HFIN_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_ID1.TextChanged, AddressOf HFIN_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Month()

                  
            
        
            ' Set the HFIN_Month Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Month is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_MonthSpecified Then
                				
                ' If the HFIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_Month.ToString(),WFinRep_Head1Table.HFIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Month.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Month.Text = formattedValue
                
            Else 
            
                ' HFIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Month.Text = WFinRep_Head1Table.HFIN_Month.Format(WFinRep_Head1Table.HFIN_Month.DefaultValue)
                        		
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
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Month1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Month1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_MonthSpecified Then
                				
                ' If the HFIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_Month.ToString(),WFinRep_Head1Table.HFIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Month.ToString()
                End If
                                
                Me.HFIN_Month1.Text = formattedValue
                
            Else 
            
                ' HFIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Month1.Text = WFinRep_Head1Table.HFIN_Month.Format(WFinRep_Head1Table.HFIN_Month.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Month1.TextChanged, AddressOf HFIN_Month1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Remark1()

                  
            
        
            ' Set the HFIN_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Remark1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Remark1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_RemarkSpecified Then
                				
                ' If the HFIN_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Remark)
                              
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    Dim originalLength As Integer = maxLength
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                                      
                        formattedValue = HttpUtility.HtmlEncode(formattedValue)
                          
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If originalLength >= popupThreshold Then
                      
                        Dim name As String = HttpUtility.HtmlEncode(WFinRep_Head1Table.HFIN_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WFinRep_Head1Table, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""HFIN_Remark\"", \""HFIN_Remark1\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, Len(formattedValue))))
                      
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        Else
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    End If
                End If  
                
                Me.HFIN_Remark1.Text = formattedValue
                
            Else 
            
                ' HFIN_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Remark1.Text = WFinRep_Head1Table.HFIN_Remark.Format(WFinRep_Head1Table.HFIN_Remark.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Remark1.Text Is Nothing _
                OrElse Me.HFIN_Remark1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Remark1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_RptCount()

                  
            
        
            ' Set the HFIN_RptCount Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_RptCount is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_RptCount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_RptCountSpecified Then
                				
                ' If the HFIN_RptCount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_RptCount)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_RptCount.Text = formattedValue
                
            Else 
            
                ' HFIN_RptCount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_RptCount.Text = WFinRep_Head1Table.HFIN_RptCount.Format(WFinRep_Head1Table.HFIN_RptCount.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_RptCount is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_RptCount.Text Is Nothing _
                OrElse Me.HFIN_RptCount.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_RptCount.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Status2()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Status2.ID) Then
            
                Me.HFIN_Status2.Text = Me.PreviousUIData(Me.HFIN_Status2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Status2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Status2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_StatusSpecified Then
                				
                ' If the HFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_Status.ToString(),WFinRep_Head1Table.HFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Status.ToString()
                End If
                                
                Me.HFIN_Status2.Text = formattedValue
                
            Else 
            
                ' HFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Status2.Text = WFinRep_Head1Table.HFIN_Status.Format(WFinRep_Head1Table.HFIN_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Status2.TextChanged, AddressOf HFIN_Status2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Year1()

                  
            
        
            ' Set the HFIN_Year Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Year1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Year1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_YearSpecified Then
                				
                ' If the HFIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Year)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Year1.Text = formattedValue
                
            Else 
            
                ' HFIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Year1.Text = WFinRep_Head1Table.HFIN_Year.Format(WFinRep_Head1Table.HFIN_Year.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Year is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Year1.Text Is Nothing _
                OrElse Me.HFIN_Year1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Year1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Year2()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Year2.ID) Then
            
                Me.HFIN_Year2.Text = Me.PreviousUIData(Me.HFIN_Year2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Year2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Year2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_YearSpecified Then
                				
                ' If the HFIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Year)
                              
                Me.HFIN_Year2.Text = formattedValue
                
            Else 
            
                ' HFIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Year2.Text = WFinRep_Head1Table.HFIN_Year.Format(WFinRep_Head1Table.HFIN_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Year2.TextChanged, AddressOf HFIN_Year2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWfin_HeadTabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "Wfin_HeadTabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "Wfin_HeadTabContainer").Visible = False
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
        
            GetHFIN_C_ID2()
            GetHFIN_C_ID3()
            GetHFIN_Description()
            GetHFIN_ID1()
            GetHFIN_Month()
            GetHFIN_Month1()
            GetHFIN_Remark1()
            GetHFIN_RptCount()
            GetHFIN_Status2()
            GetHFIN_Year1()
            GetHFIN_Year2()
        End Sub
        
        
        Public Overridable Sub GetHFIN_C_ID2()
            
        End Sub
                
        Public Overridable Sub GetHFIN_C_ID3()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Description()
            
        End Sub
                
        Public Overridable Sub GetHFIN_ID1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Month()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Month1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Remark1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_RptCount()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Status2()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Year1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Year2()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_HeadTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
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
          WFinRep_Head1Table.DeleteRecord(pkValue)
          
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
        
        Public Overridable Sub SetbtnPreview()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnPreview1()                
              
   
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
        
        Protected Overridable Sub HFIN_C_ID3_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Month1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Status2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Year2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
            
        Public Property DataSource() As WFinRep_Head1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Head1Record)
            End Get
            Set(ByVal value As WFinRep_Head1Record)
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
        
        Public ReadOnly Property btnPreview1() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnPreview1"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property HFIN_C_ID2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_ID2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_C_ID3() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_ID3"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_ID1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_ID1"), System.Web.UI.WebControls.TextBox)
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
            
        Public ReadOnly Property HFIN_Remark1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Remark1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_RptCount() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RptCount"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Status2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Status2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Year1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Year1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Year2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Year2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property Wfin_HeadTabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Wfin_HeadTabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_DocAttachTableControl() As WFinRep_DocAttachTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttachTableControl"), WFinRep_DocAttachTableControl)
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
            
            Dim rec As WFinRep_Head1Record = Nothing
             
        
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
            
            Dim rec As WFinRep_Head1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_Head1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_Head1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRep_HeadTableControl control on the WFin_ApproverPage1 page.
' Do not modify this class. Instead override any method in WFinRep_HeadTableControl.
Public Class BaseWFinRep_HeadTableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_Head1Record)), WFinRep_Head1Record())
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
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_Head1Record)), WFinRep_Head1Record())
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
            ByVal pageSize As Integer) As WFinRep_Head1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_Head1Table.Column1, True)         
            ' selCols.Add(WFinRep_Head1Table.Column2, True)          
            ' selCols.Add(WFinRep_Head1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_Head1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_Head1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_Head1Record)), WFinRep_Head1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_Head1Table.Column1, True)         
            ' selCols.Add(WFinRep_Head1Table.Column2, True)          
            ' selCols.Add(WFinRep_Head1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_Head1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_Head1Table
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
        
                
                SetHFIN_C_IDLabel()
                SetHFIN_DescriptionLabel1()
                SetHFIN_MonthLabel()
                SetHFIN_RemarkLabel1()
                SetHFIN_RemarkLabel2()
                SetHFIN_RptCountLabel()
                SetHFIN_YearLabel()
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
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_C_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_C_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_Status, Me.DataSource)
          
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
        

            ' Bind the buttons for WFinRep_HeadTableControl pagination.
        


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
            WFinRep_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            ' Get the static clause defined at design time on the Table Panel Wizard
            Dim qc As WhereClause = Me.CreateQueryClause()
            If Not(IsNothing(qc)) Then
                wc.iAND(qc)
            End If
              
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRep_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
        
          Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Get the static clause defined at design time on the Table Panel Wizard
            Dim qc As WhereClause = Me.CreateQueryClause()
            If Not(IsNothing(qc)) Then
                wc.iAND(qc)
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
      
      
            Return wc
        End Function

      
        Protected Overridable Function CreateQueryClause() As WhereClause
            ' Create a where clause for the Static clause defined at design time.
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
            Dim whereClause As WhereClause = New WhereClause()
            
            If EvaluateFormula("WFinRep_HeadRecordControl.HFIN_ID.Text", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("ePortalWFApproval.Business.WFinRep_Head1Table, App_Code").TableDefinition.ColumnList.GetByUniqueName("WFinRep_Head_.HFIN_ID"), EvaluateFormula("WFinRep_HeadRecordControl.HFIN_ID.Text", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("WFinRep_HeadRecordControl.HFIN_ID.Text", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("WFinRep_HeadRecordControl.HFIN_ID.Text", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)
    
            Return whereClause
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_HeadTableControlRow = DirectCast(repItem.FindControl("WFinRep_HeadTableControlRow"), WFinRep_HeadTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_Head1Record = New WFinRep_Head1Record()
        
                        If recControl.HFIN_C_ID2.Text <> "" Then
                            rec.Parse(recControl.HFIN_C_ID2.Text, WFinRep_Head1Table.HFIN_C_ID)
                        End If
                        If recControl.HFIN_C_ID3.Text <> "" Then
                            rec.Parse(recControl.HFIN_C_ID3.Text, WFinRep_Head1Table.HFIN_C_ID)
                        End If
                        If recControl.HFIN_Description.Text <> "" Then
                            rec.Parse(recControl.HFIN_Description.Text, WFinRep_Head1Table.HFIN_Description)
                        End If
                        If recControl.HFIN_File.Text <> "" Then
                            rec.Parse(recControl.HFIN_File.Text, WFinRep_Head1Table.HFIN_File)
                        End If
                        If recControl.HFIN_ID1.Text <> "" Then
                            rec.Parse(recControl.HFIN_ID1.Text, WFinRep_Head1Table.HFIN_ID)
                        End If
                        If recControl.HFIN_Month.Text <> "" Then
                            rec.Parse(recControl.HFIN_Month.Text, WFinRep_Head1Table.HFIN_Month)
                        End If
                        If recControl.HFIN_Month1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Month1.Text, WFinRep_Head1Table.HFIN_Month)
                        End If
                        If recControl.HFIN_Remark1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Remark1.Text, WFinRep_Head1Table.HFIN_Remark)
                        End If
                        If recControl.HFIN_RptCount.Text <> "" Then
                            rec.Parse(recControl.HFIN_RptCount.Text, WFinRep_Head1Table.HFIN_RptCount)
                        End If
                        If recControl.HFIN_Status2.Text <> "" Then
                            rec.Parse(recControl.HFIN_Status2.Text, WFinRep_Head1Table.HFIN_Status)
                        End If
                        If recControl.HFIN_Year1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Year1.Text, WFinRep_Head1Table.HFIN_Year)
                        End If
                        If recControl.HFIN_Year2.Text <> "" Then
                            rec.Parse(recControl.HFIN_Year2.Text, WFinRep_Head1Table.HFIN_Year)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_Head1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_Head1Record)), WFinRep_Head1Record())
              
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
                
        Public Overridable Sub SetHFIN_DescriptionLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_DescriptionLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_MonthLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_MonthLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_RemarkLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_RemarkLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_RemarkLabel2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_RemarkLabel2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_RptCountLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_RptCountLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_YearLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_YearLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WFinRep_HeadTableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRep_HeadTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WFinRep_Head1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRep_Head1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Head1Record())
            End Get
            Set(ByVal value() As WFinRep_Head1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property HFIN_C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_DescriptionLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_DescriptionLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_MonthLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_MonthLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_RemarkLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RemarkLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_RemarkLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RemarkLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_RptCountLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RptCountLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_YearLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_YearLabel"), System.Web.UI.WebControls.Literal)
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
                Dim rec As WFinRep_Head1Record = Nothing     
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
                Dim rec As WFinRep_Head1Record = Nothing     
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

  
' Base class for the WFinRep_HeadRecordControl control on the WFin_ApproverPage1 page.
' Do not modify this class. Instead override any method in WFinRep_HeadRecordControl.
Public Class BaseWFinRep_HeadRecordControl
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_HeadRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

      
            ' Setup the filter and search events.
            
        End Sub

        '  To customize, override this method in WFinRep_HeadRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.pApproved.Click, AddressOf pApproved_Click
                        
              AddHandler Me.pReject.Click, AddressOf pReject_Click
                        
              AddHandler Me.pReturned.Click, AddressOf pReturned_Click
                        
              AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
                        
              AddHandler Me.HFIN_DT_ID1.SelectedIndexChanged, AddressOf HFIN_DT_ID1_SelectedIndexChanged
            
              AddHandler Me.HFIN_U_ID1.SelectedIndexChanged, AddressOf HFIN_U_ID1_SelectedIndexChanged
            
              AddHandler Me.HFIN_C_ID1.TextChanged, AddressOf HFIN_C_ID1_TextChanged
            
              AddHandler Me.HFIN_FinID.TextChanged, AddressOf HFIN_FinID_TextChanged
            
              AddHandler Me.HFIN_ID.TextChanged, AddressOf HFIN_ID_TextChanged
            
              AddHandler Me.HFIN_Month2.TextChanged, AddressOf HFIN_Month2_TextChanged
            
              AddHandler Me.HFIN_Remark.TextChanged, AddressOf HFIN_Remark_TextChanged
            
              AddHandler Me.HFIN_Status1.TextChanged, AddressOf HFIN_Status1_TextChanged
            
              AddHandler Me.HFIN_U_ID.TextChanged, AddressOf HFIN_U_ID_TextChanged
            
              AddHandler Me.HFIN_Year.TextChanged, AddressOf HFIN_Year_TextChanged
            
              AddHandler Me.ddlMoveTo.SelectedIndexChanged, AddressOf ddlMoveTo_SelectedIndexChanged
                					
              AddHandler Me.txtRemarks.TextChanged, AddressOf txtRemarks_TextChanged
                    
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_Head1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WFinRep_HeadRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New WFinRep_Head1Record()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As WFinRep_Head1Record = WFinRep_Head1Table.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = WFinRep_Head1Table.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_HeadRecordControl.
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
        
                
                SetddlMoveTo()
                SetDescription()
                SetDescription_MY()
                SetHFIN_C_ID()
                SetHFIN_C_ID1()
                SetHFIN_Description1()
                SetHFIN_DT_ID()
                SetHFIN_DT_ID1()
                SetHFIN_DT_IDLabel()
                SetHFIN_FinID()
                SetHFIN_ID()
                SetHFIN_Month2()
                SetHFIN_Remark()
                SetHFIN_RemarkLabel()
                SetHFIN_Status()
                SetHFIN_Status1()
                SetHFIN_StatusLabel()
                SetHFIN_U_ID()
                SetHFIN_U_ID1()
                SetHFIN_Year()
                
                
                
                SetTabContainer()
                
                
                
                SettxtRemarks()
                
                
                
                
                SetpApproved()
              
                SetpReject()
              
                SetpReturned()
              
                SetCancelButton()
              
      
      
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
            
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.ResetControl()
            End IF
                    
        SetVw_FS_WFinRep_Attachment_PerReportTypeTableControl()
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              WFinRep_Activity1TableControl.ResetControl()
            End IF
                    
        SetWFinRep_Activity1TableControl()
        
        SetWFinRep_HeadTableControl()
        
        End Sub
        
        
        Public Overridable Sub SetHFIN_C_ID()

                  
            
        
            ' Set the HFIN_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then
                				
                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_C_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_C_ID.ToString(),WFinRep_Head1Table.HFIN_C_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_C_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_C_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_C_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_C_ID.Text = WFinRep_Head1Table.HFIN_C_ID.Format(WFinRep_Head1Table.HFIN_C_ID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetHFIN_C_ID1()

                  
            
        
            ' Set the HFIN_C_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then
                				
                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.HFIN_C_ID.ToString()
                                
                            
                Me.HFIN_C_ID1.Text = formattedValue
                
            Else 
            
                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_C_ID1.Text = WFinRep_Head1Table.HFIN_C_ID.DefaultValue		
                End If
                 
              AddHandler Me.HFIN_C_ID1.TextChanged, AddressOf HFIN_C_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Description1()

                  
            
        
            ' Set the HFIN_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Description1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Description1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DescriptionSpecified Then
                				
                ' If the HFIN_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Description1.Text = formattedValue
                
            Else 
            
                ' HFIN_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Description1.Text = WFinRep_Head1Table.HFIN_Description.Format(WFinRep_Head1Table.HFIN_Description.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetHFIN_DT_ID()

                  
            
        
            ' Set the HFIN_DT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_DT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_DT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DT_IDSpecified Then
                				
                ' If the HFIN_DT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_DT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_DT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_DT_ID.ToString(),WFinRep_Head1Table.HFIN_DT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_DT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_DT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_DT_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_DT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_DT_ID.Text = WFinRep_Head1Table.HFIN_DT_ID.Format(WFinRep_Head1Table.HFIN_DT_ID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetHFIN_DT_ID1()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the HFIN_DT_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_DT_ID1 is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_DT_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DT_IDSpecified Then
                            
                ' If the HFIN_DT_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.HFIN_DT_ID.ToString()
            Else
                
                ' HFIN_DT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WFinRep_Head1Table.HFIN_DT_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateHFIN_DT_ID1DropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetHFIN_FinID()

                  
            
        
            ' Set the HFIN_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_FinID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_FinID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_IDSpecified Then
                				
                ' If the HFIN_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_ID)
                              
                Me.HFIN_FinID.Text = formattedValue
                
            Else 
            
                ' HFIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_FinID.Text = WFinRep_Head1Table.HFIN_ID.Format(WFinRep_Head1Table.HFIN_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_FinID.TextChanged, AddressOf HFIN_FinID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_ID()

                  
            
            ' Set AutoPostBack to true so that when the control value is changed, to refresh WFinRep_HeadTableControl controls
            Me.HFIN_ID.AutoPostBack = True
            
        
            ' Set the HFIN_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_IDSpecified Then
                				
                ' If the HFIN_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_ID)
                              
                Me.HFIN_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_ID.Text = WFinRep_Head1Table.HFIN_ID.Format(WFinRep_Head1Table.HFIN_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_ID.TextChanged, AddressOf HFIN_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Month2()

                  
            
        
            ' Set the HFIN_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Month2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Month2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_MonthSpecified Then
                				
                ' If the HFIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.HFIN_Month.ToString()
                                
                            
                Me.HFIN_Month2.Text = formattedValue
                
            Else 
            
                ' HFIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Month2.Text = WFinRep_Head1Table.HFIN_Month.DefaultValue		
                End If
                 
              AddHandler Me.HFIN_Month2.TextChanged, AddressOf HFIN_Month2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Remark()

                  
            
        
            ' Set the HFIN_Remark TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Remark is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_RemarkSpecified Then
                				
                ' If the HFIN_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Remark)
                              
                Me.HFIN_Remark.Text = formattedValue
                
            Else 
            
                ' HFIN_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Remark.Text = WFinRep_Head1Table.HFIN_Remark.Format(WFinRep_Head1Table.HFIN_Remark.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Remark.TextChanged, AddressOf HFIN_Remark_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Status()

                  
            
        
            ' Set the HFIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_StatusSpecified Then
                				
                ' If the HFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_Status.ToString(),WFinRep_Head1Table.HFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Status.Text = formattedValue
                
            Else 
            
                ' HFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Status.Text = WFinRep_Head1Table.HFIN_Status.Format(WFinRep_Head1Table.HFIN_Status.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetHFIN_Status1()

                  
            
        
            ' Set the HFIN_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Status1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Status1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_StatusSpecified Then
                				
                ' If the HFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.HFIN_Status.ToString()
                                
                            
                Me.HFIN_Status1.Text = formattedValue
                
            Else 
            
                ' HFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Status1.Text = WFinRep_Head1Table.HFIN_Status.DefaultValue		
                End If
                 
              AddHandler Me.HFIN_Status1.TextChanged, AddressOf HFIN_Status1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_U_ID()

                  
            
        
            ' Set the HFIN_U_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_U_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_U_IDSpecified Then
                				
                ' If the HFIN_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.HFIN_U_ID.ToString()
                                
                            
                Me.HFIN_U_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_U_ID.Text = WFinRep_Head1Table.HFIN_U_ID.DefaultValue		
                End If
                 
              AddHandler Me.HFIN_U_ID.TextChanged, AddressOf HFIN_U_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_U_ID1()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the HFIN_U_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_U_ID1 is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_U_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_U_IDSpecified Then
                            
                ' If the HFIN_U_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.HFIN_U_ID.ToString()
            Else
                
                ' HFIN_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WFinRep_Head1Table.HFIN_U_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateHFIN_U_ID1DropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetHFIN_Year()

                  
            
        
            ' Set the HFIN_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Year is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_YearSpecified Then
                				
                ' If the HFIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Year)
                              
                Me.HFIN_Year.Text = formattedValue
                
            Else 
            
                ' HFIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Year.Text = WFinRep_Head1Table.HFIN_Year.Format(WFinRep_Head1Table.HFIN_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Year.TextChanged, AddressOf HFIN_Year_TextChanged
                                 
        End Sub
                


        Public Overridable Sub SetddlMoveTo()

                  
            
            Me.PopulateddlMoveToDropDownList(Nothing, 100)
                
        End Sub
                
        Public Overridable Sub SetDescription()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Description.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetDescription_MY()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Description_MY.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_DT_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_DT_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_RemarkLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SettxtRemarks()

                  
                  
                  End Sub
                
        Public Overridable Sub SetTabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "TabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "TabContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetVw_FS_WFinRep_Attachment_PerReportTypeTableControl()           
        
        
            If Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.Visible Then
                Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.LoadData()
                Vw_FS_WFinRep_Attachment_PerReportTypeTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRep_Activity1TableControl()           
        
        
            If WFinRep_Activity1TableControl.Visible Then
                WFinRep_Activity1TableControl.LoadData()
                WFinRep_Activity1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRep_HeadTableControl()           
        
        
            If WFinRep_HeadTableControl.Visible Then
                WFinRep_HeadTableControl.LoadData()
                WFinRep_HeadTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub ResetControl()
          
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

      
        
        ' To customize, override this method in WFinRep_HeadRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WFinRep_HeadRecordControlPanel"), System.Web.UI.WebControls.Panel)

          If ((Not IsNothing(Panel)) AndAlso (Not Panel.Visible)) OrElse IsNothing(Me.DataSource) Then
              Return
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
          
        Dim recWFinRep_Activity1TableControl as WFinRep_Activity1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl)
        recWFinRep_Activity1TableControl.SaveData()
          
        Dim recWFinRep_HeadTableControl as WFinRep_HeadTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTableControl"), WFinRep_HeadTableControl)
        recWFinRep_HeadTableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WFinRep_HeadRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetHFIN_C_ID()
            GetHFIN_C_ID1()
            GetHFIN_Description1()
            GetHFIN_DT_ID()
            GetHFIN_DT_ID1()
            GetHFIN_FinID()
            GetHFIN_ID()
            GetHFIN_Month2()
            GetHFIN_Remark()
            GetHFIN_Status()
            GetHFIN_Status1()
            GetHFIN_U_ID()
            GetHFIN_U_ID1()
            GetHFIN_Year()
        End Sub
        
        
        Public Overridable Sub GetHFIN_C_ID()
            
        End Sub
                
        Public Overridable Sub GetHFIN_C_ID1()
            
            ' Retrieve the value entered by the user on the HFIN_C_ID ASP:TextBox, and
            ' save it into the HFIN_C_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.HFIN_C_ID1.Text, WFinRep_Head1Table.HFIN_C_ID)			

                      
        End Sub
                
        Public Overridable Sub GetHFIN_Description1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_DT_ID()
            
        End Sub
                
        Public Overridable Sub GetHFIN_DT_ID1()
         
            ' Retrieve the value entered by the user on the HFIN_DT_ID ASP:DropDownList, and
            ' save it into the HFIN_DT_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.HFIN_DT_ID1), WFinRep_Head1Table.HFIN_DT_ID)				
            
        End Sub
                
        Public Overridable Sub GetHFIN_FinID()
            
            ' Retrieve the value entered by the user on the HFIN_ID ASP:TextBox, and
            ' save it into the HFIN_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.HFIN_FinID.Text, WFinRep_Head1Table.HFIN_ID)			

                      
        End Sub
                
        Public Overridable Sub GetHFIN_ID()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Month2()
            
            ' Retrieve the value entered by the user on the HFIN_Month ASP:TextBox, and
            ' save it into the HFIN_Month field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.HFIN_Month2.Text, WFinRep_Head1Table.HFIN_Month)			

                      
        End Sub
                
        Public Overridable Sub GetHFIN_Remark()
            
            ' Retrieve the value entered by the user on the HFIN_Remark ASP:TextBox, and
            ' save it into the HFIN_Remark field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.HFIN_Remark.Text, WFinRep_Head1Table.HFIN_Remark)			

                      
        End Sub
                
        Public Overridable Sub GetHFIN_Status()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Status1()
            
            ' Retrieve the value entered by the user on the HFIN_Status ASP:TextBox, and
            ' save it into the HFIN_Status field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.HFIN_Status1.Text, WFinRep_Head1Table.HFIN_Status)			

                      
        End Sub
                
        Public Overridable Sub GetHFIN_U_ID()
            
            ' Retrieve the value entered by the user on the HFIN_U_ID ASP:TextBox, and
            ' save it into the HFIN_U_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.HFIN_U_ID.Text, WFinRep_Head1Table.HFIN_U_ID)			

                      
        End Sub
                
        Public Overridable Sub GetHFIN_U_ID1()
         
            ' Retrieve the value entered by the user on the HFIN_U_ID ASP:DropDownList, and
            ' save it into the HFIN_U_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.HFIN_U_ID1), WFinRep_Head1Table.HFIN_U_ID)				
            
        End Sub
                
        Public Overridable Sub GetHFIN_Year()
            
            ' Retrieve the value entered by the user on the HFIN_Year ASP:TextBox, and
            ' save it into the HFIN_Year field in DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.HFIN_Year.Text, WFinRep_Head1Table.HFIN_Year)			

                      
        End Sub
                
      
        ' To customize, override this method in WFinRep_HeadRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
      
        Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
      
            Dim wc As WhereClause
            WFinRep_Head1Table.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Get the static clause defined at design time on the Record Panel Wizard
            
            Dim qc As WhereClause = Me.CreateQueryClause()
            If Not(IsNothing(qc)) Then
                wc.iAND(qc)
            End If
            
            Return wc
          
        End Function
        
        Protected Overridable Function CreateQueryClause() As WhereClause
            ' Create a where clause for the Static clause defined at design time.
            Dim filter As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
            Dim whereClause As WhereClause = New WhereClause()
            
            If EvaluateFormula("URL(""WFinRep_Head"")", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("ePortalWFApproval.Business.WFinRep_Head1Table, App_Code").TableDefinition.ColumnList.GetByUniqueName("WFinRep_Head_.HFIN_ID"), EvaluateFormula("URL(""WFinRep_Head"")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("URL(""WFinRep_Head"")", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("URL(""WFinRep_Head"")", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)
    
            Return whereClause
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            WFinRep_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportTypeTableControl As Boolean = False
              
                Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
              
                Dim hasFiltersWFinRep_DocAttachTableControl As Boolean = False
              
                Dim hasFiltersWFinRep_HeadRecordControl As Boolean = False
              
                Dim hasFiltersWFinRep_HeadTableControl As Boolean = False
              
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)

            
            ' Get the static clause defined at design time on the Table Panel Wizard
            Dim qc As WhereClause = Me.CreateQueryClause()
            If Not(IsNothing(qc)) Then
                wc.iAND(qc) ''nope nothing
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
         
        'Formats the resultItem and adds it to the list of suggestions.
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
        
    

        ' To customize, override this method in WFinRep_HeadRecordControl.
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
          WFinRep_Head1Table.DeleteRecord(pkValue)
          
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
        
        
        ' Generate the event handling functions for pagination events.
            
      
        ' Generate the event handling functions for filter and search events.
            
    
        ' Generate set method for buttons
        
        Public Overridable Sub SetpApproved()                
              
   
        End Sub
            
        Public Overridable Sub SetpReject()                
              
   
        End Sub
            
        Public Overridable Sub SetpReturned()                
              
   
        End Sub
            
        Public Overridable Sub SetCancelButton()                
              
   
        End Sub
            
                        
        Public Overridable Function CreateWhereClause_HFIN_DT_ID1DropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.WFinRep_DocType table.
            ' Examples:
            ' wc.iAND(WFinRep_DocType1Table.WFIN_DT_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(WFinRep_DocType1Table.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
                        
        Public Overridable Function CreateWhereClause_HFIN_U_ID1DropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.sel_WASP_User table.
            ' Examples:
            ' wc.iAND(Sel_WASP_User1View.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(Sel_WASP_User1View.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
        ' Fill the HFIN_DT_ID1 list.
        Protected Overridable Sub PopulateHFIN_DT_ID1DropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.HFIN_DT_ID1.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_DT_ID1.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_DT_ID1DropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_HFIN_DT_ID1DropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WFinRep_DocType1Table.WFIN_DT_Name, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As WFinRep_DocType1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = WFinRep_DocType1Table.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As WFinRep_DocType1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WFIN_DT_IDSpecified Then
                            cvalue = itemValue.WFIN_DT_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.HFIN_DT_ID1.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_DT_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_DT_ID.IsApplyDisplayAs Then
                                fvalue = WFinRep_Head1Table.GetDFKA(itemValue, WFinRep_Head1Table.HFIN_DT_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(WFinRep_DocType1Table.WFIN_DT_ID)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.HFIN_DT_ID1.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_DT_ID1.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                                End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.HFIN_DT_ID1, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.HFIN_DT_ID1, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WFinRep_DocType.WFIN_DT_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WFinRep_DocType1Table.WFIN_DT_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WFinRep_DocType1Record = WFinRep_DocType1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WFinRep_DocType1Record = DirectCast(rc(0), WFinRep_DocType1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WFIN_DT_IDSpecified Then
                            cvalue = itemValue.WFIN_DT_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_DT_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_DT_ID.IsApplyDisplayAs Then
                          fvalue = WFinRep_Head1Table.GetDFKA(itemValue, WFinRep_Head1Table.HFIN_DT_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WFinRep_DocType1Table.WFIN_DT_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.HFIN_DT_ID1, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        ' Fill the HFIN_U_ID1 list.
        Protected Overridable Sub PopulateHFIN_U_ID1DropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.HFIN_U_ID1.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_U_ID1.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_U_ID1DropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_HFIN_U_ID1DropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Sel_WASP_User1View.W_U_User_Name, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As Sel_WASP_User1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = Sel_WASP_User1View.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As Sel_WASP_User1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.W_U_IDSpecified Then
                            cvalue = itemValue.W_U_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.HFIN_U_ID1.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_U_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_U_ID.IsApplyDisplayAs Then
                                fvalue = WFinRep_Head1Table.GetDFKA(itemValue, WFinRep_Head1Table.HFIN_U_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(Sel_WASP_User1View.W_U_ID)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.HFIN_U_ID1.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_U_ID1.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                                End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.HFIN_U_ID1, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.HFIN_U_ID1, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.sel_WASP_User.W_U_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Sel_WASP_User1View.W_U_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Sel_WASP_User1Record = Sel_WASP_User1View.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As Sel_WASP_User1Record = DirectCast(rc(0), Sel_WASP_User1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.W_U_IDSpecified Then
                            cvalue = itemValue.W_U_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_U_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_U_ID.IsApplyDisplayAs Then
                          fvalue = WFinRep_Head1Table.GetDFKA(itemValue, WFinRep_Head1Table.HFIN_U_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(Sel_WASP_User1View.W_U_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.HFIN_U_ID1, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        Public Overridable Function CreateWhereClause_ddlMoveToDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        

        ' Fill the ddlMoveTo list.
        Protected Overridable Sub PopulateddlMoveToDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
                
            Me.ddlMoveTo.Items.Clear()

                      
                    
            ' 1. Setup the static list items        
            		  
            ' Skip step 2 and 3 because no need to load data from database and insert data
                    
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.ddlMoveTo, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.ddlMoveTo, selectedValue)Then

            
            End If					
                
                
        End Sub
                
        ' event handler for PushButton
        Public Overridable Sub pApproved_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for PushButton
        Public Overridable Sub pReject_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for PushButton
        Public Overridable Sub pReturned_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub CancelButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    

                ' if target is specified meaning that is opened on popup or new window
                If Page.Request("target") <> "" Then
                    shouldRedirect = False
                    AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "ClosePopup", "closePopupPage();", True)                   
                End If
      
            Catch ex As Exception
            
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
      Me.Page.RedirectBack()
        
            End If
        End Sub
        
        Protected Overridable Sub HFIN_DT_ID1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(HFIN_DT_ID1.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(HFIN_DT_ID1.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.HFIN_DT_ID1.Items.Add(New ListItem(displayText, val))
                Me.HFIN_DT_ID1.SelectedIndex = Me.HFIN_DT_ID1.Items.Count - 1
                Me.Page.Session.Remove(HFIN_DT_ID1.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(HFIN_DT_ID1.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub HFIN_U_ID1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(HFIN_U_ID1.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(HFIN_U_ID1.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.HFIN_U_ID1.Items.Add(New ListItem(displayText, val))
                Me.HFIN_U_ID1.SelectedIndex = Me.HFIN_U_ID1.Items.Count - 1
                Me.Page.Session.Remove(HFIN_U_ID1.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(HFIN_U_ID1.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub HFIN_C_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_FinID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()
                ' Because Set methods will be called, it is important to initialize the data source ahead of time
                
                
                If Not Me.RecordUniqueId Is Nothing Then Me.DataSource = Me.GetRecord()                                        
                  
                
                
                Me.Page.CommitTransaction(sender)


            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
            Finally
                DbUtils.EndTransaction()
            End Try			
                            
                        
              End Sub
            
        Protected Overridable Sub HFIN_Month2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Remark_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Status1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_U_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Year_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ddlMoveTo_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
                		
        Protected Overridable Sub txtRemarks_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
             
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
                Return CType(Me.ViewState("BaseWFinRep_HeadRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRep_HeadRecordControl_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRep_Head1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Head1Record)
            End Get
            Set(ByVal value As WFinRep_Head1Record)
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
    
        Private _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property
    
        Private _TotalRecords As Integer
        Public Property TotalRecords() As Integer
            Get
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                End If

                Me._TotalRecords = value
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
        
        Public ReadOnly Property CancelButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CancelButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property ddlMoveTo() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlMoveTo"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Description_MY() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Description_MY"), System.Web.UI.WebControls.Literal)
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
            
        Public ReadOnly Property HFIN_Description1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Description1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_DT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_DT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_DT_ID1() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_DT_ID1"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_DT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_DT_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_FinID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_FinID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Month2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Month2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Remark() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Remark"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Status1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Status1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_U_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_U_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_U_ID1() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_U_ID1"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Year() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Year"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pApproved() As System.Web.UI.WebControls.Button
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pApproved"), System.Web.UI.WebControls.Button)
            End Get
        End Property
        
        Public ReadOnly Property pReject() As System.Web.UI.WebControls.Button
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pReject"), System.Web.UI.WebControls.Button)
            End Get
        End Property
        
        Public ReadOnly Property pReturned() As System.Web.UI.WebControls.Button
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pReturned"), System.Web.UI.WebControls.Button)
            End Get
        End Property
        
        Public ReadOnly Property TabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property txtRemarks() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "txtRemarks"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property Vw_FS_WFinRep_Attachment_PerReportTypeTableControl() As Vw_FS_WFinRep_Attachment_PerReportTypeTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportTypeTableControl"), Vw_FS_WFinRep_Attachment_PerReportTypeTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_Activity1TableControl() As WFinRep_Activity1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_HeadTableControl() As WFinRep_HeadTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTableControl"), WFinRep_HeadTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_HeadTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTitle"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WFinRep_Head1Record = Nothing
             
        
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
            
            Dim rec As WFinRep_Head1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_Head1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_Head1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

#End Region
    
  
End Namespace

  