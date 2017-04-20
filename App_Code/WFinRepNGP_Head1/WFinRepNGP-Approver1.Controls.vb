
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' WFinRepNGP_Approver1.aspx page.  The Row or RecordControl classes are the 
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


Namespace ePortalWFApproval.UI.Controls.WFinRepNGP_Approver1

#Region "Section 1: Place your customizations here."


    Public Class WFinRepNGP_Activity1TableControlRow
        Inherits BaseWFinRepNGP_Activity1TableControlRow
        ' The BaseWFinRepNGP_Activity1TableControlRow implements code for a ROW within the
        ' the WFinRepNGP_Activity1TableControl table.  The BaseWFinRepNGP_Activity1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRepNGP_Activity1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


    End Class



    Public Class WFinRepNGP_Activity1TableControl
        Inherits BaseWFinRepNGP_Activity1TableControl

        ' The BaseWFinRepNGP_Activity1TableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WFinRepNGP_Activity1TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    End Class


    Public Class WFinRepNGP_Attachment1TableControlRow
        Inherits BaseWFinRepNGP_Attachment1TableControlRow
        ' The BaseWFinRepNGP_Attachment1TableControlRow implements code for a ROW within the
        ' the WFinRepNGP_Attachment1TableControl table.  The BaseWFinRepNGP_Attachment1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRepNGP_Attachment1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


    End Class



    Public Class WFinRepNGP_Attachment1TableControl
        Inherits BaseWFinRepNGP_Attachment1TableControl

        ' The BaseWFinRepNGP_Attachment1TableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WFinRepNGP_Attachment1TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    End Class


    Public Class WFinRepNGP_Head1RecordControl
        Inherits BaseWFinRepNGP_Head1RecordControl
        ' The BaseWFinRepNGP_Head1RecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.



        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ' Setup the pagination events.	  


            ' Register the event handlers.
            AddHandler Me.pApproved.Click, AddressOf pApproved_Click

            AddHandler Me.pReject.Click, AddressOf pReject_Click

            AddHandler Me.pReturned.Click, AddressOf pReturned_Click

            AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click

            AddHandler Me.WFRCHNGP_U_ID.SelectedIndexChanged, AddressOf WFRCHNGP_U_ID_SelectedIndexChanged

            AddHandler Me.WFRCHNGP_Submit.CheckedChanged, AddressOf WFRCHNGP_Submit_CheckedChanged

            AddHandler Me.WFRCHNGP_C_ID.TextChanged, AddressOf WFRCHNGP_C_ID_TextChanged

            AddHandler Me.WFRCHNGP_C_ID1.TextChanged, AddressOf WFRCHNGP_C_ID1_TextChanged

            AddHandler Me.WFRCHNGP_Month.TextChanged, AddressOf WFRCHNGP_Month_TextChanged

            AddHandler Me.WFRCHNGP_Remark.TextChanged, AddressOf WFRCHNGP_Remark_TextChanged

            AddHandler Me.WFRCHNGP_U_ID1.TextChanged, AddressOf WFRCHNGP_U_ID1_TextChanged

            AddHandler Me.WFRCHNGP_Year.TextChanged, AddressOf WFRCHNGP_Year_TextChanged

            AddHandler Me.txtRemarks.TextChanged, AddressOf txtRemarks_TextChanged

            If Me.WFRCHNGP_Status.Text = "Completed" Then
                Me.pReturned.Visible = True
                Me.pApproved.Visible = False
                Me.pReject.Visible = False
            Else
                Me.pReturned.Visible = False
                Me.pApproved.Visible = True
                Me.pReject.Visible = True
            End If
        End Sub
        Public Overrides Sub SetWFRCHNGP_Month()


            ' Set the WFRCHNGP_Month TextBox on the webpage with value from the
            ' WFinRepNGP_Head database record.

            ' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Month is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Month()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_MonthSpecified Then

                ' If the WFRCHNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value



                Me.WFRCHNGP_Month.Text = Me.DataSource.WFRCHNGP_Month.ToString()

            Else

                ' WFRCHNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_Month.Text = WFinRepNGP_Head1Table.WFRCHNGP_Month.DefaultValue
            End If

        End Sub
        Public Overrides Sub SetWFRCHNGP_C_ID1()


            ' Set the WFRCHNGP_C_ID TextBox on the webpage with value from the
            ' WFinRepNGP_Head database record.

            ' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID1 is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then


                Me.WFRCHNGP_C_ID1.Text = Me.DataSource.WFRCHNGP_C_ID.ToString()

            Else

                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_C_ID1.Text = WFinRepNGP_Head1Table.WFRCHNGP_C_ID.DefaultValue
            End If

        End Sub

        Public Overrides Sub SetWFRCHNGP_DT_ID1()


            ' Set the WFRCHNGP_DT_ID Literal on the webpage with value from the
            ' WFinRepNGP_Head database record.

            ' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_DT_ID1 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_DT_ID1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_DT_IDSpecified Then

                ' If the WFRCHNGP_DT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value

                Me.WFRCHNGP_DT_ID1.Text = Me.DataSource.WFRCHNGP_DT_ID.ToString()

            Else

                ' WFRCHNGP_DT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_DT_ID1.Text = WFinRepNGP_Head1Table.WFRCHNGP_DT_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_DT_ID.DefaultValue)

            End If

        End Sub

        Public Overrides Sub SetWFRCHNGP_Description()
            Me.WFRCHNGP_Description.Text = Me.DataSource.WFRCHNGP_Description.ToString & " " & MonthName(CInt(Me.DataSource.WFRCHNGP_Month.ToString)) & " " & Me.DataSource.WFRCHNGP_Year.ToString

        End Sub

        Public Overrides Sub SetWFRCHNGP_C_ID()


            ' Set the WFRCHNGP_C_ID TextBox on the webpage with value from the
            ' WFinRepNGP_Head database record.

            ' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then

                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_HeadTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Head1Table.WFRCHNGP_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Head1Table.WFRCHNGP_C_ID.IsApplyDisplayAs Then

                    formattedValue = WFinRepNGP_Head1Table.GetDFKA(Me.DataSource.WFRCHNGP_C_ID.ToString(), WFinRepNGP_Head1Table.WFRCHNGP_C_ID, Nothing)

                    If (formattedValue Is Nothing) Then
                        formattedValue = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID)
                    End If
                Else
                    formattedValue = Me.DataSource.WFRCHNGP_C_ID.ToString()
                End If

                formattedValue = HttpUtility.HtmlEncode(formattedValue)

                Me.WFRCHNGP_C_ID.Text = formattedValue

            Else

                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_C_ID.Text = WFinRepNGP_Head1Table.WFRCHNGP_C_ID.DefaultValue
            End If

        End Sub

        Public Overrides Sub pApproved_Click(ByVal sender As Object, ByVal args As EventArgs)
            Try


                Dim sFinID As String = Me.WFRCHNGP_ID.Text
                Dim sCo1 As String = Me.WFRCHNGP_C_ID.Text
                Dim sYr As String = Me.WFRCHNGP_Year.Text
                Dim sMo As String = MonthName(CInt(Me.WFRCHNGP_Month.Text))
                Dim sDesc As String = "FS PACKAGE"
                Dim sType As String = ""
                Dim sCo As String = Me.WFRCHNGP_C_ID1.Text


                Dim wc1 As WhereClause = New WhereClause
                Dim sCurStep As String = ""
                Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Report Details:" & "@D" & vbCrLf & _
                vbCrLf & "Date: @RD" & vbCrLf & vbCrLf & "Comment(s): @Rem" & vbCrLf & "Type: @T"


                Dim sFSDetail As String = " "
                Dim sDeyt As String = sMo & vbCrLf & vbCrLf & sYr

                Dim sWhere1 As String = W_User1Table.W_U_ID.UniqueName & " = " & Me.WFRCHNGP_U_ID.Text
                Dim sUser As String = ""
                For Each oRec2 As W_User1Record In W_User1Table.GetRecords(sWhere1, Nothing, 0, 100)
                    sUser = oRec2.W_U_Full_Name.ToString()
                Next
                sFSDetail = Me.WFRCHNGP_Description.Text

                sEmailContent = Replace(sEmailContent, "@C", Me.WFRCHNGP_C_ID.Text) ''oRec.FIN_Company1.SelectedItem.ToString)
                sEmailContent = Replace(sEmailContent, "@D", sFSDetail)
                sEmailContent = Replace(sEmailContent, "@RD", sDeyt)
                sEmailContent = Replace(sEmailContent, "@Rem", "Report Name: " & sDesc & "</br>" & Me.txtRemarks.Text)
                sEmailContent = Replace(sEmailContent, "@T", sType)
                sEmailContent &= vbCrLf & "Requester: " & sUser
                sEmailContent &= vbCrLf & vbCrLf & "http://eportal.anflocor.com/"

                'wc1.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc1.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc1.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                wc1.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                'note: check to see if record is still submitted, if not then do not save
                If WFinRepNGP_Activity1Table.GetRecords(wc1, Nothing, 0, 100).Length > 0 Then
                    'note: get Current step to be used in wc2
                    For Each itemValue1 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc1, Nothing, 0, 100)
                        sCurStep = itemValue1.WFRNGPA_WS_ID.ToString()
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
                    'wc3.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                    For Each itemValue3 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                        'note: do not include previous same step if wf has been 'Rejected'
                        If Not colUser.Contains(itemValue3.WFRNGPA_W_U_ID.ToString) Then
                            colUser.Add(itemValue3.WFRNGPA_W_U_ID, itemValue3.WFRNGPA_W_U_ID.ToString)
                        End If
                    Next

                    '--------------------------------------------------------------------------------------------------------
                    If iApprovers = colUser.Count + 1 Then 'met the # of approvers requirement (+1 -> means the current user)
                        If (sNextStep = "0") Or (sNextStep = Nothing) Then  'no next step (end workflow here)
                            'note: set current user status task to 'Approved' & set CAR doc status to 'Completed'
                            Dim wc5 As WhereClause = New WhereClause

                            'wc5.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                            wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                            wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)


                            If WFinRepNGP_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                For Each itemValue5 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                    'note: update Activity table (current user) -> 'Approved'
                                    ''#Ryan_Test
                                    'MsgBox("Approved: UpdateRecord")
                                    WFinRepNGP_Activity1Record.UpdateRecord(itemValue5.WFRNGPA_ID.ToString(), "6")
                                    WFinRepNGP_Activity1Record.UpdateRecord_Final_Approved(itemValue5.WFRNGPA_ID.ToString())
                                Next
                            End If

                            Dim wc6 As WhereClause = New WhereClause
                            ''wc6.iAND(WFinRepNGP_HeadTable.WFRCHNGP_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc6.iAND(WFinRepNGP_Head1Table.WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc6.iAND(WFinRepNGP_Head1Table.WFRCHNGP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, sCo)
                            For Each itemValue6 As WFinRepNGP_Head1Record In WFinRepNGP_Head1Table.GetRecords(wc6, Nothing, 0, 100)
                                Update_WFinRepNGP_Head(CInt(sCo), 6, CInt(sFinID), True)
                                Update_WFinRepNGP_DocAttach(CInt(sCo), 6, sFinID)

                                '##################
                                '### EMAIL HERE ###
                                '##################
                                sEmailContent = Content_Formatter(itemValue6.WFRCHNGP_U_ID.ToString(), _
                                "FS Report Approval Completed (FS Document ID#  " & sFinID & ")", CStr(sCo1), _
                                sFSDetail, sDeyt, Me.txtRemarks.Text, sType, _
                                itemValue6.WFRCHNGP_U_ID.ToString(), "#64d04b", "WFinRep_Head/WFin_ApproverTable1.aspx", sFinID, _
                                "FS WF Completed", "FS WF Completed", "FS Creator")


                                Send_Email_Notification(itemValue6.WFRCHNGP_U_ID.ToString(), "FS Report Approval Completed (Report Name: " & Me.WFRCHNGP_Description.Text & _
                                ")", sEmailContent)

                                updTrx_SummaryNGP(CInt(sFinID), True)

                            Next
                        Else
                            'note: if # of approvers needed < multiple approvers then set other 'Pending' status to 'System Approved'
                            'note: set current user status to 'Approved'
                            'note: get user(s) for the next step & insert to Activity table
                            Dim wc4 As WhereClause = New WhereClause

                            'wc4.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc4.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc4.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                            wc4.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                            wc4.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                            For Each itemValue4 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                                'note: update Activity table (other user(s) if multiple approvers) -> 'System Approved'
                                ''#Ryan_Test
                                'MsgBox("System Approved: UpdateRecord")
                                WFinRepNGP_Activity1Record.UpdateRecord(itemValue4.WFRNGPA_ID.ToString(), "11")
                            Next

                            Dim wc5 As WhereClause = New WhereClause
                            'wc5.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                            wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                            wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                            wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                            If WFinRepNGP_ActivityTable.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                For Each itemValue5 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                    'note: update Activity table (current user) -> 'Approved'
                                    '#Ryan_Test
                                    'MsgBox("Approved: UpdateRecord")
                                    WFinRepNGP_Activity1Record.UpdateRecord(itemValue5.WFRNGPA_ID.ToString(), "5")
                                    WFinRepNGP_Activity1Record.UpdateRecord_Final_Approved(itemValue5.WFRNGPA_ID.ToString()) ''additional: to make IsDone = True
                                Next
                            End If

                            Dim wc6 As WhereClause = New WhereClause
                            wc6.iAND(WFinRep_Step_StepDetail1View.WFIN_S_ID, BaseFilter.ComparisonOperator.EqualsTo, sNextStep)
                            For Each itemValue6 As WFinRep_Step_StepDetail1Record In WFinRep_Step_StepDetail1View.GetRecords(wc6, Nothing, 0, 100)
                                'note: use returned items to insert to Activity table
                                'note: do not insert(update) delegate until task expires
                                '#Ryan_Test
                                'MsgBox("insert to Activity : WFinRepNGP_ActivityRecord")
                                WFinRepNGP_Activity1Record.AddRecord(itemValue6.WFIN_S_ID, itemValue6.WFIN_SD_ID, _
                                CInt(Me.WFRCHNGP_DT_ID1.Text), _
                                itemValue6.WFIN_SD_W_U_ID, 0, CInt(sFinID), _
                               (DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & Me.txtRemarks.Text))

                                Dim nStep As String = itemValue6.W_U_Full_Name.ToString()
                                sEmailContent &= vbCrLf & vbCrLf & "Next Approver: " & nStep
                                sEmailContent &= vbCrLf & vbCrLf & "http://eportal.anflocor.com/"

                                '******control this notification for GGP*****
                                Select Case itemValue6.WFIN_SD_W_U_ID.ToString
                                    Case "8"

                                    Case Else
                                        '##################
                                        '### EMAIL HERE ###
                                        '##################
                                        Dim sInfo As String = ""
                                        'Dim sDelegate As String = FindDelegate(itemValue6.MRS_SD_W_U_ID.ToString(), sInfo)
                                        Dim esUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                                        sEmailContent = Content_Formatter(CStr(itemValue6.WFIN_SD_W_U_ID), _
                                        "FS Report Approval Needed (FS Document ID# " & sFinID & ")", CStr(sCo1), _
                                        sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                                        System.Web.HttpContext.Current.Session("UserIdNorth").ToString(), "#4682b4", "WFinRep_Head/WFin_ApproverTable1.aspx", sFinID, _
                                        "Next Approver: " & nStep, "Pending Approval")



                                        Send_Email_Notification(CStr(itemValue6.WFIN_SD_W_U_ID), "FS Approval Needed (Report Name: " & Me.WFRCHNGP_Description.Text & _
                                                                 ")", sEmailContent)

                                End Select

                            Next
                        End If
                    Else 'just set current user status to 'Approved'
                        'note: this routine: requires another user to approve for the WF to move, so just update user's status
                        Dim wc5 As WhereClause = New WhereClause

                        'wc5.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                        wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                        wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        If WFinRepNGP_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue5 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                'note: update Activity table (current user) -> 'Approved'
                                '#Ryan_Test
                                'MsgBox("Approved: WFinRepNGP_ActivityRecord")
                                WFinRepNGP_Activity1Record.UpdateRecord(itemValue5.WFRNGPA_ID.ToString(), "5")
                            Next
                        End If


                    End If
                End If


                Select Case System.Web.HttpContext.Current.Session("UserIdNorth").ToString
                    Case "8"
                        Dim url As String = "../Security/HomePage.aspx" '"../WFinRep_Head/WFinRepNGP_HeadRecord"
                        url = Me.ModifyRedirectUrl(url, "", False)
                        url = Me.Page.ModifyRedirectUrl(url, "", False)
                        Me.Page.ShouldSaveControlsToSession = True
                        Me.Page.Response.Redirect(url)
                    Case Else
                        Dim url As String = "../Security/HomePage.aspx"
                        url = Me.ModifyRedirectUrl(url, "", False)
                        url = Me.Page.ModifyRedirectUrl(url, "", False)
                        Me.Page.ShouldSaveControlsToSession = True
                        Me.Page.Response.Redirect(url)
                End Select

            Catch ex As Exception
                Me.Page.ErrorOnPage = True

                'Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        Public Overrides Sub pReject_Click(ByVal sender As Object, ByVal args As EventArgs)
            If Me.txtRemarks.Text.Trim = "" Then
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "MyAlertName", "Please put remarks when rejecting.")
            Else

                Try

                    Dim sFinID As String = Me.WFRCHNGP_ID.Text
                    Dim sCo1 As String = Me.WFRCHNGP_C_ID.Text
                    Dim sYr As String = Me.WFRCHNGP_Year.Text
                    Dim sMo As String = MonthName(CInt(Me.WFRCHNGP_Month.Text))
                    Dim sDesc As String = "FS PACKAGE"
                    Dim sType As String = ""
                    Dim sCo As String = Me.WFRCHNGP_C_ID1.Text

                    Dim drop As DropDownList = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlMoveTo"), System.Web.UI.WebControls.DropDownList)

                    Dim wc3 As WhereClause = New WhereClause
                    Dim sCurStep As String = " "
                    Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Report Details:" & "@D" & vbCrLf & _
                    vbCrLf & "Date: @RD" & vbCrLf & vbCrLf & "Comment(s): @Rem" & vbCrLf & "Type: @T"


                    Dim sFSDetail As String = " "
                    Dim sDeyt As String = sMo & vbCrLf & vbCrLf & sYr

                    Dim sWhere1 As String = W_User1Table.W_U_ID.UniqueName & " = " & Me.WFRCHNGP_U_ID.Text
                    Dim sUser As String = ""
                    For Each oRec2 As W_User1Record In W_User1Table.GetRecords(sWhere1, Nothing, 0, 100)
                        sUser = oRec2.W_U_Full_Name.ToString()
                    Next

                    sFSDetail = Me.WFRCHNGP_Description.Text


                    sEmailContent = Replace(sEmailContent, "@C", Me.WFRCHNGP_C_ID.Text) ''oRec.FIN_Company1.SelectedItem.ToString)
                    sEmailContent = Replace(sEmailContent, "@D", sFSDetail)
                    sEmailContent = Replace(sEmailContent, "@RD", sDeyt)
                    sEmailContent = Replace(sEmailContent, "@Rem", "Report Name: " & sDesc & "</br>" & Me.txtRemarks.Text)
                    sEmailContent = Replace(sEmailContent, "@T", sType)
                    sEmailContent &= vbCrLf & "Requester: " & sUser
                    sEmailContent &= vbCrLf & vbCrLf & "http://eportal.anflocor.com/"


                    'wc3.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                    'note: check to see if record is still submitted, if not then do not save
                    If WFinRepNGP_Activity1Table.GetRecords(wc3, Nothing, 0, 100).Length > 0 Then
                        'note: get Current step to be used in wc2
                        For Each itemValue3 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                            sCurStep = itemValue3.WFRNGPA_WS_ID.ToString
                        Next

                        Dim wc4 As WhereClause = New WhereClause

                        'wc4.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc4.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc4.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                        wc4.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                        wc4.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        For Each itemValue4 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                            'note: update Activity table (other user(s) if multiple approvers) -> 'System Rejected'
                            ''#Ryan_Test
                            'MsgBox("System Rejected: WFinRepNGP_ActivityRecord")
                            WFinRepNGP_Activity1Record.UpdateRecord(itemValue4.WFRNGPA_ID.ToString(), "12")
                        Next
                        'note: update current task status -> 'Rejected
                        Dim wc5 As WhereClause = New WhereClause

                        'wc5.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                        wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                        wc5.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        If WFinRepNGP_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue5 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                'note: update Activity table (current user) -> 'Rejected'
                                ''#Ryan_Test
                                'MsgBox("Update_WFinRepNGP_Activity")
                                Update_WFinRepNGP_Activity(CInt(sCo), 7, itemValue5.WFRNGPA_ID.ToString, (DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                    ": " & Me.txtRemarks.Text))
                            Next
                        End If

                        'note: insert user(s) to Activity using the chosen Return To field
                        Dim wc6 As WhereClause = New WhereClause
                        Dim Remarks As String = Me.WFRCHNGP_Remark.Text


                        'wc6.iAND(WFinRepNGP_HeadTable.WFRCHNGP_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        wc6.iAND(WFinRepNGP_Head1Table.WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                        For Each itemValue6 As WFinRepNGP_Head1Record In WFinRepNGP_Head1Table.GetRecords(wc6, Nothing, 0, 100)

                            Update_WF_Status_Submit(sCo, "7", "0", sFinID, _
                            DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                            ": " & Me.txtRemarks.Text)
                            Update_WFinRepNGP_Head(CInt(sCo), CInt(7), CInt(sFinID), False)
                            Update_WFinRepNGP_DocAttach(CInt(sCo), CInt(7), CStr(sFinID))

                            '##################
                            '### EMAIL HERE ###
                            '##################
                            Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()
                            sEmailContent = Content_Formatter(itemValue6.WFRCHNGP_U_ID.ToString(), _
                                  "FS Information Needed (FS Document ID# " & sFinID & ")", CStr(sCo1), _
                                  sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                                  System.Web.HttpContext.Current.Session("UserIdNorth").ToString(), "#f46f6f", "WFinRep_Head/WFin_ApproverTable1.aspx", sFinID, _
                                  "Returned By " & sUserRej, "FS Rejected", "FS Creator")



                            Send_Email_Notification(CStr(itemValue6.WFRCHNGP_U_ID), "FS Information Needed (Report Name: " & Me.WFRCHNGP_Description.Text & _
                            ")", sEmailContent)


                            For Each recDocAttach As WFinRepNGP_DocAttach1Record In WFinRepNGP_DocAttach1Table.GetRecords("WFRCDNGP_WFRCHNGP_ID =" & CInt(Me.WFRCHNGP_ID.Text))
                                If Not IsNothing(recDocAttach) Then
                                    '#Ryan_Test
                                    'MsgBox("WFinRepNGP_DocAttachRecord.UpdateFinPost(recDocAttach.WFRCDNGP_ID.ToString, 0)")
                                    WFinRepNGP_DocAttach1Record.UpdateFinPost(recDocAttach.WFRCDNGP_ID.ToString, 0)
                                End If
                            Next
                            updTrx_SummaryNGP(CInt(Me.WFRCHNGP_ID.Text), False)
                        Next
                    End If

                    Select Case System.Web.HttpContext.Current.Session("UserIdNorth").ToString
                        Case "8"
                            Dim url As String = "../Security/HomePage.aspx" ' "../WFinRepNGP_Head1/WFinRepNGP_HeadRecord"
                            url = Me.ModifyRedirectUrl(url, "", False)
                            url = Me.Page.ModifyRedirectUrl(url, "", False)
                            Me.Page.ShouldSaveControlsToSession = True
                            Me.Page.Response.Redirect(url)
                        Case Else
                            Dim url As String = "../Security/HomePage.aspx"
                            url = Me.ModifyRedirectUrl(url, "", False)
                            url = Me.Page.ModifyRedirectUrl(url, "", False)
                            Me.Page.ShouldSaveControlsToSession = True
                            Me.Page.Response.Redirect(url)
                    End Select


                Catch ex As Exception
                    Me.Page.ErrorOnPage = True

                    ' Report the error message to the end user
                    Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

                Finally

                End Try
            End If
        End Sub

        Public Overrides Sub pReturned_Click(ByVal sender As Object, ByVal args As EventArgs)
            If Me.txtRemarks.Text.Trim = "" Then
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "MyAlertName", "Remarks is required.")
            Else

                Dim sFinID As String = Me.WFRCHNGP_ID.Text
                Dim sCo As String = Me.WFRCHNGP_C_ID1.Text
                Dim sYr As String = Me.WFRCHNGP_Year.Text
                Dim sMo As String = MonthName(CInt(Me.WFRCHNGP_Month.Text))
                Dim sDesc As String = "FS PACKAGE"
                Dim sType As String = ""
                Dim sCo1 As String = Me.WFRCHNGP_C_ID.Text

                Dim wc As WhereClause = New WhereClause

                'wc.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                wc.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                wc.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")

                If WFinRepNGP_Activity1Table.GetRecords(wc, Nothing, 0, 100).Length > 0 Then
                    Dim currentStep As String = Nothing
                    For Each itemValue As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc, Nothing, 0, 100)
                        currentStep = itemValue.WFRNGPA_WS_ID.ToString
                    Next

                    'update co-approvers of the return status

                    Dim wc2 As WhereClause = New WhereClause

                    'wc2.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc2.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc2.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                    wc2.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")
                    wc2.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, currentStep)

                    For Each itemValue2 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc2, Nothing, 0, 100)
                        'note: update Activity table (other user(s) if multiple approvers) -> 'System Rejected'
                        ''#Ryan_Test
                        'MsgBox("System Rejected: WFinRepNGP_ActivityRecord.UpdateRecord(itemValue2.WFRNGPA_ID.ToString(), 14)")
                        WFinRepNGP_Activity1Record.UpdateRecord(itemValue2.WFRNGPA_ID.ToString(), "14")
                    Next


                    'Update CurrentStep as 'RETURNED' and other transaction tables.

                    Dim wc3 As WhereClause = New WhereClause

                    'wc3.iAND(WFinRepNGP_ActivityTable.WFRNGPA_FinID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, sFinID)
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")
                    wc3.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, currentStep)

                    If WFinRepNGP_Activity1Table.GetRecords(wc3, Nothing, 0, 100).Length > 0 Then
                        For Each itemValue3 As WFinRepNGP_Activity1Record In WFinRepNGP_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                            'note: update Activity table (current user) -> 'Rejected'
                            ''#Ryan_Test
                            'MsgBox(" Rejected: WFinRepNGP_ActivityRecord.UpdateRecord(itemValue3.WFRNGPA_ID.ToString, 9)")
                            WFinRepNGP_Activity1Record.UpdateRecord(itemValue3.WFRNGPA_ID.ToString, "9")
                            Update_WFinRepNGP_Head(CInt(sCo), CInt(9), CInt(sFinID), False)
                            Update_WFinRepNGP_DocAttach(CInt(sCo), CInt(9), CStr(sFinID)) ' UPDATE DOC_ATTACH TO NOT SUBMITTED
                            Update_WFinRepNGP_Activity(CInt(sCo), 9, itemValue3.WFRNGPA_ID.ToString, DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                                ": " & Me.txtRemarks.Text)
                        Next
                    End If

                    'EMAIL HERE ALL APPROVERS of this DOCUMENT
                    Dim whereClauseEmail As WhereClause = New WhereClause

                    whereClauseEmail.iAND(WFinRep_Step_StepDetail1View.WFIN_S_WDT_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WFRCHNGP_DT_ID1.Text)
                    whereClauseEmail.iAND(WFinRep_Step_StepDetail1View.WFIN_SD_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIdNorth").ToString())
                    Dim sFSDetail As String = " "
                    Dim sDeyt As String = sMo & vbCrLf & vbCrLf & sYr

                    Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Report Details:" & "@D" & vbCrLf & _
                    vbCrLf & "Date: @RD" & vbCrLf & vbCrLf & "Comment(s): @Rem" & vbCrLf & "Type: @T"
                    sEmailContent = Replace(sEmailContent, "@C", Me.WFRCHNGP_C_ID.Text) ''oRec.FIN_Company1.SelectedItem.ToString)
                    sEmailContent = Replace(sEmailContent, "@D", sFSDetail)
                    sEmailContent = Replace(sEmailContent, "@RD", sDeyt)
                    sEmailContent = Replace(sEmailContent, "@Rem", "Report Name: " & sDesc & "</br>" & Me.txtRemarks.Text)
                    sEmailContent = Replace(sEmailContent, "@T", sType)
                    sEmailContent &= vbCrLf & "Requester: " & System.Web.HttpContext.Current.Session("UserIdNorth").ToString()
                    sEmailContent &= vbCrLf & vbCrLf & "http://eportal.anflocor.com/"

                    sFSDetail = Me.WFRCHNGP_Description.Text
                    Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                    If WFinRep_Step_StepDetail1View.GetRecords(whereClauseEmail, Nothing, 0, 100).Length > 0 Then
                        For Each itemValue4 As WFinRep_Step_StepDetail1Record In WFinRep_Step_StepDetail1View.GetRecords(whereClauseEmail, Nothing, 0, 100)
                            If Not IsNothing(itemValue4.WFIN_SD_W_U_ID.ToString) Then
                                sEmailContent = Content_Formatter(itemValue4.WFIN_SD_W_U_ID.ToString, _
                                 "FS RETURNED FOR REVISION INFORMATION (FS Document ID#  " & sFinID & ")", CStr(sCo1), _
                                 sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                                 System.Web.HttpContext.Current.Session("UserIdNorth").ToString(), "#f46f6f", "WFinRep_Head/WFin_ApproverTable1.aspx", sFinID, _
                                 "Returned By " & sUserRej, "FS Returned for Revision", "FS Creator")

                                Send_Email_Notification(CStr(itemValue4.WFIN_SD_W_U_ID.ToString), "FS Returned for Revision Information (Report Name: " & Me.WFRCHNGP_Description.Text & _
                                ")", sEmailContent)
                            End If
                        Next
                    End If

                    sEmailContent = Content_Formatter(Me.WFRCHNGP_U_ID.Text, _
                                 "FS RETURNED FOR REVISION INFORMATION (FS Document ID#  " & sFinID & ")", CStr(sCo1), _
                                 sFSDetail, sDeyt.ToString, Me.txtRemarks.Text, sType, _
                                 System.Web.HttpContext.Current.Session("UserIdNorth").ToString(), "#f46f6f", "WFinRep_Head/WFin_ApproverTable1.aspx", sFinID, _
                                 "Returned By " & sUserRej, "FS Returned for Revision", "FS Creator")

                    Send_Email_Notification(CStr(Me.WFRCHNGP_U_ID.Text), "FS Returned for Revision Information (Report Name: " & Me.WFRCHNGP_Description.Text & _
                            ")", sEmailContent)

                    updTrx_SummaryNGP(CInt(sFinID), False)
                End If



                For Each recDocAttach As WFinRepNGP_DocAttach1Record In WFinRepNGP_DocAttach1Table.GetRecords("WFRCDNGP_WFRCHNGP_ID =" & CInt(Me.WFRCHNGP_ID.Text))
                    If Not IsNothing(recDocAttach) Then
                        ''#Ryan_Test
                        'MsgBox("WFinRepNGP_DocAttachRecord.UpdateFinPost(recDocAttach.WFRCDNGP_ID.ToString, 0)")
                        WFinRepNGP_DocAttach1Record.UpdateFinPost(recDocAttach.WFRCDNGP_ID.ToString, 0)
                    End If
                Next

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
            End If


        End Sub

        Private Function Update_WFinRepNGP_Head(ByVal Company As Integer, ByVal Status As Integer, ByVal FIN_ID As Integer, ByVal Submit As Boolean) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@WFRCHNGP_ID", FIN_ID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)


            Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@Submit", Submit, System.Data.SqlDbType.Bit, System.Data.ParameterDirection.Input)


            Dim parameterList(3) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing
            ''original: upd_WFinRep_Head
            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "sp_upd_WFinRepNGP_Head_App", parameterList)



            ''#Ryan_Test
            'MsgBox("Execute Update_WFinRepNGP_Head")
            'Return "OK"
            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function

        Private Function Update_WFinRepNGP_DocAttach(ByVal Company As Integer, ByVal Status As Integer, ByVal FIN_ID As String) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@WFRCHNGP_ID", FIN_ID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)


            Dim parameterList(2) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing
            ''original: upd_FS_WF_Status
            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "sp_upd_WFinRepNGP_DocAttach_App", parameterList)



            ''#Ryan_Test
            'MsgBox("Execute Update_WFinRepNGP_DocAttach")
            'Return "OK"
            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function


        Public Function updTrx_SummaryNGP(ByVal WFRCH_ID As Integer, ByVal IsPosted As Boolean) As String

            Dim sqlCmd As New SqlCommand
            Dim sqlCnn As SqlConnection = New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("DatabaseANFLODW").ConnectionString)
            Try
                With sqlCmd
                    .Connection = sqlCnn 'New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("DatabaseANFLO-WF1").ConnectionString)
                    .Connection.Open()
                    .CommandType = System.Data.CommandType.StoredProcedure
                    .CommandText = "usp_upd_Trx_SummaryNGP"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@p_WFRCH_ID", WFRCH_ID)
                    .Parameters.AddWithValue("@p_IsPosted", IsPosted)
                    '#Ryan_Test
                    'MsgBox("Execute updTrx_SummaryNGP")
                    .ExecuteNonQuery()
                End With
                'BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "MyAlertName", "Successfully updated report data.")
                Return "OK"

                sqlCmd.Dispose()
                sqlCmd.Connection.Close()
            Catch ex As Exception
                Throw New Exception("Error occured: " & ex.Message)
                Return ex.Message

            End Try

        End Function


        Private Function Update_WFinRepNGP_Activity(ByVal Company As Integer, ByVal Status As Integer, ByVal activityID As String, ByVal remarks As String) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@ActivityID", activityID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)

            Dim fourthParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            fourthParameter = New BaseClasses.Data.StoredProcedureParameter("@Remarks", remarks, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

            Dim parameterList(3) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter
            parameterList(3) = fourthParameter


            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing
            ''original: upd_WFinRep_Activity
            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "sp_upd_WFinRepNGP_Activity_App", parameterList)


            ''#Ryan_Test
            'MsgBox("Execute sp_upd_WFinRepNGP_Activity_App")
            'Return "OK"
            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function

        Private Function Update_WF_Status_Submit(ByVal Company As String, ByVal Status As String, ByVal Submit As String, ByVal WFRCHNGP_ID As String, ByVal Remarks As String) As String

            '' USE THIS TO UPDATE THE WFINREP_HEAD

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@WFRCHNGP_ID", WFRCHNGP_ID, System.Data.SqlDbType.Int, System.Data.ParameterDirection.Input)

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
            ''original upd_FSWF_Status_Submit

            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "sp_upd_WFinRepNGP_Head_App_Reject", parameterList)

            ''#Ryan_Test
            'MsgBox("Execute sp_upd_WFinRepNGP_Head_App_Reject")
            'Return "OK"
            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return "ERR"
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function

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

                email.AddFrom("noreply@anflocor.com")
                email.AddTo(sEmail)
                email.SetSubject(Subject)
                email.SetContent(Content)
                email.SetIsHtmlContent(True)
                '#Ryan_Test
                MsgBox("Send Email")
                'email.SendMessage()

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
            sTemplate = Replace(sTemplate, "@DOC", "FS NGP# " & Document)
            sTemplate = Replace(sTemplate, "@COLOR", Color_Hex)
            sTemplate = Replace(sTemplate, "@APPREM", ApproverRem)
            sTemplate = Replace(sTemplate, "@STAT", Status)
            sTemplate = Replace(sTemplate, "@TOT", FSType)
            'sTemplate = Replace(sTemplate, "@WF", WF_Type)

            Return sTemplate
        End Function




End Class

  

Public Class WFinRepNGP_Head1TableControl
        Inherits BaseWFinRepNGP_Head1TableControl

    ' The BaseWFinRepNGP_Head1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRepNGP_Head1TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.



        Public Overrides Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRepNGP_HeadTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_HeadRecordControl As Boolean = False

            Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            'DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRep_ActivityTableControl"), WFinRep_ActivityTableControl)
            'Dim recWFinRepNGP_ActivityTableControl As WFinRepNGP_ActivityTableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_ActivityTableControl"), WFinRepNGP_ActivityTableControl)

            Dim wFinRepNGP_H As WFinRepNGP_Head1RecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_Head1RecordControl"), WFinRepNGP_Head1RecordControl)

            wc.iAND(WFinRepNGP_Head1Table.WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRepNGP_H.WFRCHNGP_ID.Text)


            Return wc
        End Function



End Class
Public Class WFinRepNGP_Head1TableControlRow
        Inherits BaseWFinRepNGP_Head1TableControlRow
        ' The BaseWFinRepNGP_Head1TableControlRow implements code for a ROW within the
        ' the WFinRepNGP_Head1TableControl table.  The BaseWFinRepNGP_Head1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRepNGP_Head1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.



        Public Overrides Function CreateWhereClause() As WhereClause

            Dim hasFiltersWFinRepNGP_ActivityTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_AttachmentTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_DocAttachTableControl As Boolean = False

            Dim hasFiltersWFinRepNGP_HeadRecordControl As Boolean = False

            Dim hasFiltersWFinRepNGP_HeadTableControl As Boolean = False
            Dim wc As WhereClause = New WhereClause()
            Dim wFinRepNGP_H As WFinRepNGP_Head1RecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Head1RecordControl"), WFinRepNGP_Head1RecordControl)

            wc.iAND(WFinRepNGP_HeadTable.WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRepNGP_H.WFRCHNGP_ID.ToString)

            Return wc

        End Function
        '  To customize, override this method in WFinRepNGP_HeadTableControlRow.
        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


            ' Register the event handlers.

            AddHandler Me.btnPreview.Button.Click, AddressOf btnPreview_Click

            AddHandler Me.btnPreview1.Button.Click, AddressOf btnPreview1_Click

            'AddHandler Me.WFRCHNGP_Status1.SelectedIndexChanged, AddressOf WFRCHNGP_Status1_SelectedIndexChanged

            AddHandler Me.WFRCHNGP_C_ID3.TextChanged, AddressOf WFRCHNGP_C_ID3_TextChanged

            AddHandler Me.WFRCHNGP_Description1.TextChanged, AddressOf WFRCHNGP_Description1_TextChanged

            AddHandler Me.WFRCHNGP_ID1.TextChanged, AddressOf WFRCHNGP_ID1_TextChanged

            AddHandler Me.WFRCHNGP_Month2.TextChanged, AddressOf WFRCHNGP_Month2_TextChanged

            AddHandler Me.WFRCHNGP_Year2.TextChanged, AddressOf WFRCHNGP_Year2_TextChanged

            Me.btnPreview.Button.Attributes.Add("onClick", "OpenRptViewerApp2NGPNorthApp('" & Me.WFRCHNGP_Year2.ClientID & "','" & Me.WFRCHNGP_Month2.ClientID & "', '" & Me.WFRCHNGP_Description1.ClientID & "', '" & Me.WFRCHNGP_Description1.ClientID & "', '" & Me.WFRCHNGP_C_ID3.ClientID & "', '" & Me.WFRCHNGP_Status1.ClientID & "', '" & Me.WFRCHNGP_ID1.ClientID & "');return false;")

        End Sub


        Public Overrides Sub SetWFRCHNGP_File()

            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_FileSpecified Then

                Me.WFRCHNGP_File.Text = Page.GetResourceValue("Txt:OpenFile", "WebFS")

                Me.WFRCHNGP_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRepNGP_Head") & _
                            "&Field=" & Me.Page.Encrypt("WFRCHNGP_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                Me.btnPreview1.Button.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRepNGP_Head") & _
                            "&Field=" & Me.Page.Encrypt("WFRCHNGP_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"

                'Me.WFRCHNGP_File.Visible = True
            Else
                'Me.WFRCHNGP_File.Visible = False
            End If
        End Sub


        Public Overrides Sub SetWFRCHNGP_Month2()

            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Month2.ID) Then

                Me.WFRCHNGP_Month2.Text = Me.PreviousUIData(Me.WFRCHNGP_Month2.ID).ToString()

                Return
            End If


            ' Set the WFRCHNGP_Month TextBox on the webpage with value from the
            ' WFinRepNGP_Head database record.

            ' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Month2 is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Month2()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_MonthSpecified Then

                ' If the WFRCHNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value

                Me.WFRCHNGP_Month2.Text = Me.DataSource.WFRCHNGP_Month.ToString()

            Else

                ' WFRCHNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_Month2.Text = WFinRepNGP_Head1Table.WFRCHNGP_Month.Format(WFinRepNGP_Head1Table.WFRCHNGP_Month.DefaultValue)

            End If

        End Sub

        Public Overrides Sub SetWFRCHNGP_Status1()

            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Status1.ID) Then

                Me.WFRCHNGP_Status1.Text = Me.PreviousUIData(Me.WFRCHNGP_Status1.ID).ToString()

                Return
            End If


            ' Set the WFRCHNGP_Status TextBox on the webpage with value from the
            ' WFinRepNGP_Head database record.

            ' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Status1 is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Status1()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_StatusSpecified Then

                ' If the WFRCHNGP_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value


                Me.WFRCHNGP_Status1.Text = Me.DataSource.WFRCHNGP_Status.ToString()

            Else

                ' WFRCHNGP_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_Status1.Text = WFinRepNGP_Head1Table.WFRCHNGP_Status.Format(WFinRepNGP_Head1Table.WFRCHNGP_Status.DefaultValue)

            End If

        End Sub

        Public Overrides Sub SetWFRCHNGP_C_ID3()

            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_C_ID3.ID) Then

                Me.WFRCHNGP_C_ID3.Text = Me.PreviousUIData(Me.WFRCHNGP_C_ID3.ID).ToString()

                Return
            End If


            ' Set the WFRCHNGP_C_ID TextBox on the webpage with value from the
            ' WFinRepNGP_Head database record.

            ' Me.DataSource is the WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID3 is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID3()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then

                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value


                Me.WFRCHNGP_C_ID3.Text = Me.DataSource.WFRCHNGP_C_ID.ToString()

            Else

                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_C_ID3.Text = WFinRepNGP_Head1Table.WFRCHNGP_C_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID.DefaultValue)

            End If

        End Sub






        Public Overrides Sub SetWFRCHNGP_C_ID2()




            ' Set the WFRCHNGP_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID2 is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID2()
            ' and add your own code before or after the call to the MyBase function.


            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then

                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID)

                Dim sWhere As String = ""
                Dim ordB As New OrderBy(False, False)

                ordB.Add(View_DW_CompanyView.wass_C_ID, OrderByItem.OrderDir.Asc)
                sWhere = "DynamicsCompanyID ='" & formattedValue & "'"

                Dim dw_company As View_DW_CompanyRecord = View_DW_CompanyView.GetRecord(sWhere, ordB)

                If IsNothing(dw_company) = False Then

                    formattedValue = dw_company.ShortName
                End If

                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_C_ID2.Text = formattedValue

            Else

                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WFRCHNGP_C_ID2.Text = WFinRepNGP_Head1Table.WFRCHNGP_C_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID.DefaultValue)

            End If

            ' If the WFRCHNGP_C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRCHNGP_C_ID2.Text Is Nothing _
                OrElse Me.WFRCHNGP_C_ID2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRCHNGP_C_ID2.Text = "&nbsp;"
            End If




            'If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then

            ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

            ' The Format method will use the Display Format
            '   Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID)

            '  formattedValue = HttpUtility.HtmlEncode(formattedValue)
            ' Me.WFRCHNGP_C_ID2.Text = formattedValue

            'Else 

            ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
            ' Default Value could also be NULL.

            '    Me.WFRCHNGP_C_ID2.Text = WFinRepNGP_HeadTable.WFRCHNGP_C_ID.Format(WFinRepNGP_HeadTable.WFRCHNGP_C_ID.DefaultValue)

            '  End If

        End Sub


        

End Class
Public Class WFinRepNGP_DocAttach1TableControl
        Inherits BaseWFinRepNGP_DocAttach1TableControl

    ' The BaseWFinRepNGP_DocAttach1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRepNGP_DocAttach1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class
Public Class WFinRepNGP_DocAttach1TableControlRow
        Inherits BaseWFinRepNGP_DocAttach1TableControlRow
        ' The BaseWFinRepNGP_DocAttach1TableControlRow implements code for a ROW within the
        ' the WFinRepNGP_DocAttach1TableControl table.  The BaseWFinRepNGP_DocAttach1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRepNGP_DocAttach1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class
#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the WFinRepNGP_Activity1TableControlRow control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_Activity1TableControlRow.
Public Class BaseWFinRepNGP_Activity1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_Activity1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRepNGP_Activity1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_Activity1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRepNGP_Activity1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRepNGP_Activity1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_Activity1TableControlRow.
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
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_Date_Action is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_Date_ActionSpecified Then
                				
                ' If the WFRNGPA_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Activity1Table.WFRNGPA_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPA_Date_Action.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_Date_Action.Text = WFinRepNGP_Activity1Table.WFRNGPA_Date_Action.Format(WFinRepNGP_Activity1Table.WFRNGPA_Date_Action.DefaultValue, "g")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRNGPA_Date_Assign()

                  
            
        
            ' Set the WFRNGPA_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_Date_AssignSpecified Then
                				
                ' If the WFRNGPA_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Activity1Table.WFRNGPA_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPA_Date_Assign.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_Date_Assign.Text = WFinRepNGP_Activity1Table.WFRNGPA_Date_Assign.Format(WFinRepNGP_Activity1Table.WFRNGPA_Date_Assign.DefaultValue, "g")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRNGPA_Remark()

                  
            
        
            ' Set the WFRNGPA_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_RemarkSpecified Then
                				
                ' If the WFRNGPA_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Activity1Table.WFRNGPA_Remark)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(WFinRepNGP_Activity1Table.WFRNGPA_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WFinRepNGP_Activity1Table, App_Code\"",\""" _
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
        
                 Me.WFRNGPA_Remark.Text = WFinRepNGP_Activity1Table.WFRNGPA_Remark.Format(WFinRepNGP_Activity1Table.WFRNGPA_Remark.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRNGPA_Status()

                  
            
        
            ' Set the WFRNGPA_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_StatusSpecified Then
                				
                ' If the WFRNGPA_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Activity1Table.WFRNGPA_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Activity1Table.WFRNGPA_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_Activity1Table.GetDFKA(Me.DataSource.WFRNGPA_Status.ToString(),WFinRepNGP_Activity1Table.WFRNGPA_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_Activity1Table.WFRNGPA_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRNGPA_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPA_Status.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_Status.Text = WFinRepNGP_Activity1Table.WFRNGPA_Status.Format(WFinRepNGP_Activity1Table.WFRNGPA_Status.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRNGPA_W_U_ID()

                  
            
        
            ' Set the WFRNGPA_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Activity record retrieved from the database.
            ' Me.WFRNGPA_W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPA_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPA_W_U_IDSpecified Then
                				
                ' If the WFRNGPA_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_Activity1Table.GetDFKA(Me.DataSource.WFRNGPA_W_U_ID.ToString(),WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRNGPA_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPA_W_U_ID.Text = formattedValue
                
            Else 
            
                ' WFRNGPA_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPA_W_U_ID.Text = WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID.Format(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID.DefaultValue)
                        		
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

      
        
        ' To customize, override this method in WFinRepNGP_Activity1TableControlRow.
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
        
        Dim parentCtrl As WFinRepNGP_Head1RecordControl
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_Head1RecordControl"), WFinRepNGP_Head1RecordControl)				  
              
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
              
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_Activity1TableControl"), WFinRepNGP_Activity1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_Activity1TableControl"), WFinRepNGP_Activity1TableControl).ResetData = True
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

        ' To customize, override this method in WFinRepNGP_Activity1TableControlRow.
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
                
      
        ' To customize, override this method in WFinRepNGP_Activity1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRepNGP_Activity1TableControlRow.
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
          WFinRepNGP_Activity1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_Activity1TableControl"), WFinRepNGP_Activity1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_Activity1TableControl"), WFinRepNGP_Activity1TableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWFinRepNGP_Activity1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_Activity1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_Activity1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_Activity1Record)
            End Get
            Set(ByVal value As WFinRepNGP_Activity1Record)
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
            
            Dim rec As WFinRepNGP_Activity1Record = Nothing
             
        
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
            
            Dim rec As WFinRepNGP_Activity1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRepNGP_Activity1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_Activity1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRepNGP_Activity1TableControl control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_Activity1TableControl.
Public Class BaseWFinRepNGP_Activity1TableControl
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
            
              AddHandler Me.Pagination.FirstPage.Click, AddressOf Pagination_FirstPage_Click
                        
              AddHandler Me.Pagination.LastPage.Click, AddressOf Pagination_LastPage_Click
                        
              AddHandler Me.Pagination.NextPage.Click, AddressOf Pagination_NextPage_Click
                        
              AddHandler Me.Pagination.PageSizeButton.Click, AddressOf Pagination_PageSizeButton_Click
                        
              AddHandler Me.Pagination.PreviousPage.Click, AddressOf Pagination_PreviousPage_Click
                                    
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRepNGP_Activity1Record)), WFinRepNGP_Activity1Record())
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
                    For Each rc As WFinRepNGP_Activity1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRepNGP_Activity1Record)), WFinRepNGP_Activity1Record())
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
            ByVal pageSize As Integer) As WFinRepNGP_Activity1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_Activity1Table.Column1, True)         
            ' selCols.Add(WFinRepNGP_Activity1Table.Column2, True)          
            ' selCols.Add(WFinRepNGP_Activity1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRepNGP_Activity1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRepNGP_Activity1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRepNGP_Activity1Record)), WFinRepNGP_Activity1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_Activity1Table.Column1, True)         
            ' selCols.Add(WFinRepNGP_Activity1Table.Column2, True)          
            ' selCols.Add(WFinRepNGP_Activity1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRepNGP_Activity1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRepNGP_Activity1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRepNGP_Activity1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_Activity1TableControlRow"), WFinRepNGP_Activity1TableControlRow)
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
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_Activity1Table.WFRNGPA_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID, Me.DataSource)
          
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
                    
                Me.Pagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination.CurrentPage.Text = "0"
            End If
            Me.Pagination.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for WFinRepNGP_Activity1TableControl pagination.
        
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
            
            Dim recCtl As WFinRepNGP_Activity1TableControlRow
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
            WFinRepNGP_Activity1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim wFinRepNGP_Head1RecordControlObj as WFinRepNGP_Head1RecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_Head1RecordControl") ,WFinRepNGP_Head1RecordControl)
                              
                If (Not IsNothing(wFinRepNGP_Head1RecordControlObj) AndAlso Not IsNothing(wFinRepNGP_Head1RecordControlObj.GetRecord()) AndAlso wFinRepNGP_Head1RecordControlObj.GetRecord().IsCreated AndAlso Not IsNothing(wFinRepNGP_Head1RecordControlObj.GetRecord().WFRCHNGP_ID))
                    wc.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRepNGP_Head1RecordControlObj.GetRecord().WFRCHNGP_ID.ToString())
                    selectedRecordKeyValue.AddElement(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID.InternalName, wFinRepNGP_Head1RecordControlObj.GetRecord().WFRCHNGP_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If          
              
      HttpContext.Current.Session("WFinRepNGP_Activity1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRepNGP_Activity1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRepNGP_Head1RecordControl as String = DirectCast(HttpContext.Current.Session("WFinRepNGP_Activity1TableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRepNGP_Head1RecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRepNGP_Head1RecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRepNGP_Head1RecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID) Then
            wc.iAND(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRepNGP_Activity1Table.WFRNGPA_WFRCHNGP_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRepNGP_Activity1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_Activity1TableControlRow"), WFinRepNGP_Activity1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRepNGP_Activity1Record = New WFinRepNGP_Activity1Record()
        
                        If recControl.WFRNGPA_Date_Action.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_Date_Action.Text, WFinRepNGP_Activity1Table.WFRNGPA_Date_Action)
                        End If
                        If recControl.WFRNGPA_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_Date_Assign.Text, WFinRepNGP_Activity1Table.WFRNGPA_Date_Assign)
                        End If
                        If recControl.WFRNGPA_Remark.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_Remark.Text, WFinRepNGP_Activity1Table.WFRNGPA_Remark)
                        End If
                        If recControl.WFRNGPA_Status.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_Status.Text, WFinRepNGP_Activity1Table.WFRNGPA_Status)
                        End If
                        If recControl.WFRNGPA_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.WFRNGPA_W_U_ID.Text, WFinRepNGP_Activity1Table.WFRNGPA_W_U_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRepNGP_Activity1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRepNGP_Activity1Record)), WFinRepNGP_Activity1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRepNGP_Activity1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRepNGP_Activity1TableControlRow) As Boolean
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
                    Dim added As Boolean = Me.AddNewRecord > 0
                    Me.LoadData()
                    Me.DataBind()
                    
                    If added Then
                        Me.SetFocusToAddedRow()
                    End If
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        'this function sets focus to the first editable element in the new added row in the editable table	
        Protected Overridable Sub SetFocusToAddedRow()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("WFinRepNGP_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
                Dim recControl As WFinRepNGP_Activity1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_Activity1TableControlRow"), WFinRepNGP_Activity1TableControlRow)
                If recControl.IsNewRecord Then
                    For Each field As Control In recControl.Controls
                        If field.Visible AndAlso Me.Page.IsControlEditable(field, False) Then
                            'set focus on the first editable field in the new row
                            field.Focus()
                            Dim updPan As UpdatePanel = DirectCast(Me.Page.FindControlRecursively("UpdatePanel1"), UpdatePanel)
                            If Not updPan Is Nothing Then updPan.Update()
                            Return
                        End If
                    Next
                    Return
                End If
            Next
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

            Dim orderByStr As String = CType(ViewState("WFinRepNGP_Activity1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRepNGP_Activity1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
        
      

        ' Generate the event handling functions for filter and search events.
        
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WFinRepNGP_Activity1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRepNGP_Activity1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_Activity1Record())
            End Get
            Set(ByVal value() As WFinRepNGP_Activity1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Pagination() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination"), ePortalWFApproval.UI.IPaginationModern)
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
                Dim recCtl As WFinRepNGP_Activity1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_Activity1Record = Nothing     
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
                Dim recCtl As WFinRepNGP_Activity1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_Activity1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRepNGP_Activity1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRepNGP_Activity1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRepNGP_Activity1TableControlRow)), WFinRepNGP_Activity1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRepNGP_Activity1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRepNGP_Activity1TableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRepNGP_Activity1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRepNGP_Activity1TableControlRow")
            Dim list As New List(Of WFinRepNGP_Activity1TableControlRow)
            For Each recCtrl As WFinRepNGP_Activity1TableControlRow In recCtrls
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

  
' Base class for the WFinRepNGP_Attachment1TableControlRow control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_Attachment1TableControlRow.
Public Class BaseWFinRepNGP_Attachment1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_Attachment1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRepNGP_Attachment1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Attachment record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_Attachment1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRepNGP_Attachment1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRepNGP_Attachment1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_Attachment1TableControlRow.
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
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Attachment database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Attachment record retrieved from the database.
            ' Me.WFRNGPAt_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRNGPAt_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPAt_DescSpecified Then
                				
                ' If the WFRNGPAt_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Attachment1Table.WFRNGPAt_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRNGPAt_Desc.Text = formattedValue
                
            Else 
            
                ' WFRNGPAt_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRNGPAt_Desc.Text = WFinRepNGP_Attachment1Table.WFRNGPAt_Desc.Format(WFinRepNGP_Attachment1Table.WFRNGPAt_Desc.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRNGPAt_Doc()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRNGPAt_DocSpecified Then
                
                Me.WFRNGPAt_Doc.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WFRNGPAt_Doc.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRepNGP_Attachment1") & _
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

      
        
        ' To customize, override this method in WFinRepNGP_Attachment1TableControlRow.
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
        
        Dim parentCtrl As WFinRepNGP_Head1RecordControl
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_Head1RecordControl"), WFinRepNGP_Head1RecordControl)				  
              
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
              
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_Attachment1TableControl"), WFinRepNGP_Attachment1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_Attachment1TableControl"), WFinRepNGP_Attachment1TableControl).ResetData = True
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

        ' To customize, override this method in WFinRepNGP_Attachment1TableControlRow.
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
                
      
        ' To customize, override this method in WFinRepNGP_Attachment1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRepNGP_Attachment1TableControlRow.
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
          WFinRepNGP_Attachment1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_Attachment1TableControl"), WFinRepNGP_Attachment1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_Attachment1TableControl"), WFinRepNGP_Attachment1TableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWFinRepNGP_Attachment1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_Attachment1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_Attachment1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_Attachment1Record)
            End Get
            Set(ByVal value As WFinRepNGP_Attachment1Record)
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
            
            Dim rec As WFinRepNGP_Attachment1Record = Nothing
             
        
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
            
            Dim rec As WFinRepNGP_Attachment1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRepNGP_Attachment1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_Attachment1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRepNGP_Attachment1TableControl control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_Attachment1TableControl.
Public Class BaseWFinRepNGP_Attachment1TableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRepNGP_Attachment1Record)), WFinRepNGP_Attachment1Record())
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
                    For Each rc As WFinRepNGP_Attachment1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRepNGP_Attachment1Record)), WFinRepNGP_Attachment1Record())
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
            ByVal pageSize As Integer) As WFinRepNGP_Attachment1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_Attachment1Table.Column1, True)         
            ' selCols.Add(WFinRepNGP_Attachment1Table.Column2, True)          
            ' selCols.Add(WFinRepNGP_Attachment1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRepNGP_Attachment1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRepNGP_Attachment1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRepNGP_Attachment1Record)), WFinRepNGP_Attachment1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_Attachment1Table.Column1, True)         
            ' selCols.Add(WFinRepNGP_Attachment1Table.Column2, True)          
            ' selCols.Add(WFinRepNGP_Attachment1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRepNGP_Attachment1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRepNGP_Attachment1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Attachment1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRepNGP_Attachment1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_Attachment1TableControlRow"), WFinRepNGP_Attachment1TableControlRow)
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
                    
                Me.Pagination1.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination1.CurrentPage.Text = "0"
            End If
            Me.Pagination1.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for WFinRepNGP_Attachment1TableControl pagination.
        
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
            
            Dim recCtl As WFinRepNGP_Attachment1TableControlRow
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
            WFinRepNGP_Attachment1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim wFinRepNGP_Head1RecordControlObj as WFinRepNGP_Head1RecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_Head1RecordControl") ,WFinRepNGP_Head1RecordControl)
                              
                If (Not IsNothing(wFinRepNGP_Head1RecordControlObj) AndAlso Not IsNothing(wFinRepNGP_Head1RecordControlObj.GetRecord()) AndAlso wFinRepNGP_Head1RecordControlObj.GetRecord().IsCreated AndAlso Not IsNothing(wFinRepNGP_Head1RecordControlObj.GetRecord().WFRCHNGP_ID))
                    wc.iAND(WFinRepNGP_Attachment1Table.WFRNGPAt_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRepNGP_Head1RecordControlObj.GetRecord().WFRCHNGP_ID.ToString())
                    selectedRecordKeyValue.AddElement(WFinRepNGP_Attachment1Table.WFRNGPAt_WFRCHNGP_ID.InternalName, wFinRepNGP_Head1RecordControlObj.GetRecord().WFRCHNGP_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If          
              
      HttpContext.Current.Session("WFinRepNGP_Attachment1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRepNGP_Attachment1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRepNGP_Head1RecordControl as String = DirectCast(HttpContext.Current.Session("WFinRepNGP_Attachment1TableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRepNGP_Head1RecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRepNGP_Head1RecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRepNGP_Head1RecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRepNGP_Attachment1Table.WFRNGPAt_WFRCHNGP_ID) Then
            wc.iAND(WFinRepNGP_Attachment1Table.WFRNGPAt_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRepNGP_Attachment1Table.WFRNGPAt_WFRCHNGP_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Attachment1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRepNGP_Attachment1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_Attachment1TableControlRow"), WFinRepNGP_Attachment1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRepNGP_Attachment1Record = New WFinRepNGP_Attachment1Record()
        
                        If recControl.WFRNGPAt_Desc.Text <> "" Then
                            rec.Parse(recControl.WFRNGPAt_Desc.Text, WFinRepNGP_Attachment1Table.WFRNGPAt_Desc)
                        End If
                        If recControl.WFRNGPAt_Doc.Text <> "" Then
                            rec.Parse(recControl.WFRNGPAt_Doc.Text, WFinRepNGP_Attachment1Table.WFRNGPAt_Doc)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRepNGP_Attachment1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRepNGP_Attachment1Record)), WFinRepNGP_Attachment1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRepNGP_Attachment1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRepNGP_Attachment1TableControlRow) As Boolean
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
                    Dim added As Boolean = Me.AddNewRecord > 0
                    Me.LoadData()
                    Me.DataBind()
                    
                    If added Then
                        Me.SetFocusToAddedRow()
                    End If
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        'this function sets focus to the first editable element in the new added row in the editable table	
        Protected Overridable Sub SetFocusToAddedRow()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("WFinRepNGP_Attachment1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
                Dim recControl As WFinRepNGP_Attachment1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_Attachment1TableControlRow"), WFinRepNGP_Attachment1TableControlRow)
                If recControl.IsNewRecord Then
                    For Each field As Control In recControl.Controls
                        If field.Visible AndAlso Me.Page.IsControlEditable(field, False) Then
                            'set focus on the first editable field in the new row
                            field.Focus()
                            Dim updPan As UpdatePanel = DirectCast(Me.Page.FindControlRecursively("UpdatePanel1"), UpdatePanel)
                            If Not updPan Is Nothing Then updPan.Update()
                            Return
                        End If
                    Next
                    Return
                End If
            Next
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

            Dim orderByStr As String = CType(ViewState("WFinRepNGP_Attachment1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRepNGP_Attachment1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WFinRepNGP_Attachment1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRepNGP_Attachment1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_Attachment1Record())
            End Get
            Set(ByVal value() As WFinRepNGP_Attachment1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Pagination1() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination1"), ePortalWFApproval.UI.IPaginationModern)
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
                Dim recCtl As WFinRepNGP_Attachment1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_Attachment1Record = Nothing     
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
                Dim recCtl As WFinRepNGP_Attachment1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_Attachment1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRepNGP_Attachment1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRepNGP_Attachment1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRepNGP_Attachment1TableControlRow)), WFinRepNGP_Attachment1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRepNGP_Attachment1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRepNGP_Attachment1TableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRepNGP_Attachment1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRepNGP_Attachment1TableControlRow")
            Dim list As New List(Of WFinRepNGP_Attachment1TableControlRow)
            For Each recCtrl As WFinRepNGP_Attachment1TableControlRow In recCtrls
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

  
' Base class for the WFinRepNGP_DocAttach1TableControlRow control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_DocAttach1TableControlRow.
Public Class BaseWFinRepNGP_DocAttach1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_DocAttach1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRepNGP_DocAttach1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_DocAttach record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_DocAttach1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRepNGP_DocAttach1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRepNGP_DocAttach1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_DocAttach1TableControlRow.
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
        
                SetWFRCDNGP_Description()
                SetWFRCDNGP_RWRem()
                SetWFRCDNGP_Type()
      
      
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
        
        
        Public Overridable Sub SetWFRCDNGP_Description()

                  
            
        
            ' Set the WFRCDNGP_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_DescriptionSpecified Then
                				
                ' If the WFRCDNGP_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_DocAttach1Table.WFRCDNGP_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCDNGP_Description.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_Description.Text = WFinRepNGP_DocAttach1Table.WFRCDNGP_Description.Format(WFinRepNGP_DocAttach1Table.WFRCDNGP_Description.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_RWRem()

                  
            
        
            ' Set the WFRCDNGP_RWRem Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_RWRem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_RWRem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_RWRemSpecified Then
                				
                ' If the WFRCDNGP_RWRem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_DocAttach1Table.WFRCDNGP_RWRem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCDNGP_RWRem.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_RWRem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_RWRem.Text = WFinRepNGP_DocAttach1Table.WFRCDNGP_RWRem.Format(WFinRepNGP_DocAttach1Table.WFRCDNGP_RWRem.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCDNGP_Type()

                  
            
        
            ' Set the WFRCDNGP_Type Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_DocAttach record retrieved from the database.
            ' Me.WFRCDNGP_Type is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCDNGP_Type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCDNGP_TypeSpecified Then
                				
                ' If the WFRCDNGP_Type is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_DocAttach1Table.WFRCDNGP_Type)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_DocAttach1Table.WFRCDNGP_Type.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_DocAttach1Table.GetDFKA(Me.DataSource.WFRCDNGP_Type.ToString(),WFinRepNGP_DocAttach1Table.WFRCDNGP_Type, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_DocAttach1Table.WFRCDNGP_Type)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCDNGP_Type.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCDNGP_Type.Text = formattedValue
                
            Else 
            
                ' WFRCDNGP_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCDNGP_Type.Text = WFinRepNGP_DocAttach1Table.WFRCDNGP_Type.Format(WFinRepNGP_DocAttach1Table.WFRCDNGP_Type.DefaultValue)
                        		
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

      
        
        ' To customize, override this method in WFinRepNGP_DocAttach1TableControlRow.
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
        
        Dim parentCtrl As WFinRepNGP_Head1TableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_Head1TableControlRow"), WFinRepNGP_Head1TableControlRow)				  
              
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
              
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_DocAttach1TableControl"), WFinRepNGP_DocAttach1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_DocAttach1TableControl"), WFinRepNGP_DocAttach1TableControl).ResetData = True
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

        ' To customize, override this method in WFinRepNGP_DocAttach1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWFRCDNGP_Description()
            GetWFRCDNGP_RWRem()
            GetWFRCDNGP_Type()
        End Sub
        
        
        Public Overridable Sub GetWFRCDNGP_Description()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_RWRem()
            
        End Sub
                
        Public Overridable Sub GetWFRCDNGP_Type()
            
        End Sub
                
      
        ' To customize, override this method in WFinRepNGP_DocAttach1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRepNGP_DocAttach1TableControlRow.
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
          WFinRepNGP_DocAttach1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_DocAttach1TableControl"), WFinRepNGP_DocAttach1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_DocAttach1TableControl"), WFinRepNGP_DocAttach1TableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWFinRepNGP_DocAttach1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_DocAttach1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_DocAttach1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_DocAttach1Record)
            End Get
            Set(ByVal value As WFinRepNGP_DocAttach1Record)
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
        
        Public ReadOnly Property WFRCDNGP_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_RWRem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_RWRem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCDNGP_Type() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_Type"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WFinRepNGP_DocAttach1Record = Nothing
             
        
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
            
            Dim rec As WFinRepNGP_DocAttach1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRepNGP_DocAttach1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_DocAttach1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRepNGP_DocAttach1TableControl control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_DocAttach1TableControl.
Public Class BaseWFinRepNGP_DocAttach1TableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRepNGP_DocAttach1Record)), WFinRepNGP_DocAttach1Record())
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
                    For Each rc As WFinRepNGP_DocAttach1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRepNGP_DocAttach1Record)), WFinRepNGP_DocAttach1Record())
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
            ByVal pageSize As Integer) As WFinRepNGP_DocAttach1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_DocAttach1Table.Column1, True)         
            ' selCols.Add(WFinRepNGP_DocAttach1Table.Column2, True)          
            ' selCols.Add(WFinRepNGP_DocAttach1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRepNGP_DocAttach1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRepNGP_DocAttach1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRepNGP_DocAttach1Record)), WFinRepNGP_DocAttach1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_DocAttach1Table.Column1, True)         
            ' selCols.Add(WFinRepNGP_DocAttach1Table.Column2, True)          
            ' selCols.Add(WFinRepNGP_DocAttach1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRepNGP_DocAttach1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRepNGP_DocAttach1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_DocAttach1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRepNGP_DocAttach1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_DocAttach1TableControlRow"), WFinRepNGP_DocAttach1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                SetWFRCDNGP_DescriptionLabel()
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
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_DocAttach1Table.WFRCDNGP_Type, Me.DataSource)
          
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
        

            ' Bind the buttons for WFinRepNGP_DocAttach1TableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRepNGP_DocAttach1TableControlRow
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
            WFinRepNGP_DocAttach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRepNGP_Head1RecordObj as KeyValue
        wFinRepNGP_Head1RecordObj = Nothing
      
              Dim wFinRepNGP_Head1TableControlObjRow As WFinRepNGP_Head1TableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRepNGP_Head1TableControlRow") ,WFinRepNGP_Head1TableControlRow)
            
                If (Not IsNothing(wFinRepNGP_Head1TableControlObjRow) AndAlso Not IsNothing(wFinRepNGP_Head1TableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRepNGP_Head1TableControlObjRow.GetRecord().WFRCHNGP_ID))
                    wc.iAND(WFinRepNGP_DocAttach1Table.WFRCDNGP_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRepNGP_Head1TableControlObjRow.GetRecord().WFRCHNGP_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WFinRepNGP_DocAttach1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRepNGP_DocAttach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRepNGP_Head1TableControl as String = DirectCast(HttpContext.Current.Session("WFinRepNGP_DocAttach1TableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRepNGP_Head1TableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRepNGP_Head1TableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRepNGP_Head1TableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRepNGP_DocAttach1Table.WFRCDNGP_WFRCHNGP_ID) Then
            wc.iAND(WFinRepNGP_DocAttach1Table.WFRCDNGP_WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRepNGP_DocAttach1Table.WFRCDNGP_WFRCHNGP_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_DocAttach1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRepNGP_DocAttach1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_DocAttach1TableControlRow"), WFinRepNGP_DocAttach1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRepNGP_DocAttach1Record = New WFinRepNGP_DocAttach1Record()
        
                        If recControl.WFRCDNGP_Description.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_Description.Text, WFinRepNGP_DocAttach1Table.WFRCDNGP_Description)
                        End If
                        If recControl.WFRCDNGP_RWRem.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_RWRem.Text, WFinRepNGP_DocAttach1Table.WFRCDNGP_RWRem)
                        End If
                        If recControl.WFRCDNGP_Type.Text <> "" Then
                            rec.Parse(recControl.WFRCDNGP_Type.Text, WFinRepNGP_DocAttach1Table.WFRCDNGP_Type)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRepNGP_DocAttach1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRepNGP_DocAttach1Record)), WFinRepNGP_DocAttach1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRepNGP_DocAttach1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRepNGP_DocAttach1TableControlRow) As Boolean
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
        
        Public Overridable Sub SetWFRCDNGP_DescriptionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCDNGP_DescriptionLabel.Text = "Some value"
                    
                  End Sub
                
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

            Dim orderByStr As String = CType(ViewState("WFinRepNGP_DocAttach1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRepNGP_DocAttach1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WFinRepNGP_DocAttach1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRepNGP_DocAttach1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_DocAttach1Record())
            End Get
            Set(ByVal value() As WFinRepNGP_DocAttach1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Title1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCDNGP_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCDNGP_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
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
                Dim recCtl As WFinRepNGP_DocAttach1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_DocAttach1Record = Nothing     
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
                Dim recCtl As WFinRepNGP_DocAttach1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_DocAttach1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRepNGP_DocAttach1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRepNGP_DocAttach1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRepNGP_DocAttach1TableControlRow)), WFinRepNGP_DocAttach1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRepNGP_DocAttach1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRepNGP_DocAttach1TableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRepNGP_DocAttach1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRepNGP_DocAttach1TableControlRow")
            Dim list As New List(Of WFinRepNGP_DocAttach1TableControlRow)
            For Each recCtrl As WFinRepNGP_DocAttach1TableControlRow In recCtrls
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

  
' Base class for the WFinRepNGP_Head1TableControlRow control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_Head1TableControlRow.
Public Class BaseWFinRepNGP_Head1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_Head1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRepNGP_Head1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.btnPreview.Button.Click, AddressOf btnPreview_Click
                        
              AddHandler Me.btnPreview1.Button.Click, AddressOf btnPreview1_Click
                        
              AddHandler Me.WFRCHNGP_C_ID3.TextChanged, AddressOf WFRCHNGP_C_ID3_TextChanged
            
              AddHandler Me.WFRCHNGP_Description1.TextChanged, AddressOf WFRCHNGP_Description1_TextChanged
            
              AddHandler Me.WFRCHNGP_ID1.TextChanged, AddressOf WFRCHNGP_ID1_TextChanged
            
              AddHandler Me.WFRCHNGP_Month2.TextChanged, AddressOf WFRCHNGP_Month2_TextChanged
            
              AddHandler Me.WFRCHNGP_Status1.TextChanged, AddressOf WFRCHNGP_Status1_TextChanged
            
              AddHandler Me.WFRCHNGP_Year2.TextChanged, AddressOf WFRCHNGP_Year2_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_Head1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRepNGP_Head1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRepNGP_Head1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_Head1TableControlRow.
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
        
                
                
                SetTabPanel3()
                
                SetWFinRepNGP_HeadTableControlTabContainer()
                SetWFRCHNGP_C_ID2()
                SetWFRCHNGP_C_ID3()
                SetWFRCHNGP_Description1()
                SetWFRCHNGP_Description2()
                SetWFRCHNGP_File()
                SetWFRCHNGP_ID1()
                SetWFRCHNGP_Month1()
                SetWFRCHNGP_Month2()
                SetWFRCHNGP_Remark1()
                SetWFRCHNGP_RptCount()
                SetWFRCHNGP_Status1()
                SetWFRCHNGP_Year1()
                SetWFRCHNGP_Year2()
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
                      
        SetWFinRepNGP_DocAttach1TableControl()
        
        End Sub
        
        
        Public Overridable Sub SetWFRCHNGP_C_ID2()

                  
            
        
            ' Set the WFRCHNGP_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then
                				
                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_C_ID2.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_C_ID2.Text = WFinRepNGP_Head1Table.WFRCHNGP_C_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_C_ID3()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_C_ID3.ID) Then
            
                Me.WFRCHNGP_C_ID3.Text = Me.PreviousUIData(Me.WFRCHNGP_C_ID3.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_C_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID3 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID3()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then
                				
                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID)
                              
                Me.WFRCHNGP_C_ID3.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_C_ID3.Text = WFinRepNGP_Head1Table.WFRCHNGP_C_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_C_ID3.TextChanged, AddressOf WFRCHNGP_C_ID3_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Description1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Description1.ID) Then
            
                Me.WFRCHNGP_Description1.Text = Me.PreviousUIData(Me.WFRCHNGP_Description1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_Description TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Description1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Description1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_DescriptionSpecified Then
                				
                ' If the WFRCHNGP_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Description)
                              
                Me.WFRCHNGP_Description1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Description1.Text = WFinRepNGP_Head1Table.WFRCHNGP_Description.Format(WFinRepNGP_Head1Table.WFRCHNGP_Description.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_Description1.TextChanged, AddressOf WFRCHNGP_Description1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Description2()

                  
            
        
            ' Set the WFRCHNGP_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Description2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Description2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_DescriptionSpecified Then
                				
                ' If the WFRCHNGP_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Description2.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Description2.Text = WFinRepNGP_Head1Table.WFRCHNGP_Description.Format(WFinRepNGP_Head1Table.WFRCHNGP_Description.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_FileSpecified Then
                
                Me.WFRCHNGP_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WFRCHNGP_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRepNGP_Head1") & _
                            "&Field=" & Me.Page.Encrypt("WFRCHNGP_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.WFRCHNGP_File.Visible = True
            Else
                Me.WFRCHNGP_File.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_ID1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_ID1.ID) Then
            
                Me.WFRCHNGP_ID1.Text = Me.PreviousUIData(Me.WFRCHNGP_ID1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_IDSpecified Then
                				
                ' If the WFRCHNGP_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_ID)
                              
                Me.WFRCHNGP_ID1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_ID1.Text = WFinRepNGP_Head1Table.WFRCHNGP_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_ID1.TextChanged, AddressOf WFRCHNGP_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Month1()

                  
            
        
            ' Set the WFRCHNGP_Month Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Month1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Month1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_MonthSpecified Then
                				
                ' If the WFRCHNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Head1Table.WFRCHNGP_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Head1Table.WFRCHNGP_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_Head1Table.GetDFKA(Me.DataSource.WFRCHNGP_Month.ToString(),WFinRepNGP_Head1Table.WFRCHNGP_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_Month.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Month1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Month1.Text = WFinRepNGP_Head1Table.WFRCHNGP_Month.Format(WFinRepNGP_Head1Table.WFRCHNGP_Month.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Month2()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Month2.ID) Then
            
                Me.WFRCHNGP_Month2.Text = Me.PreviousUIData(Me.WFRCHNGP_Month2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Month2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Month2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_MonthSpecified Then
                				
                ' If the WFRCHNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.WFRCHNGP_Month.ToString()
                                
                            
                Me.WFRCHNGP_Month2.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Month2.Text = WFinRepNGP_Head1Table.WFRCHNGP_Month.DefaultValue		
                End If
                 
              AddHandler Me.WFRCHNGP_Month2.TextChanged, AddressOf WFRCHNGP_Month2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Remark1()

                  
            
        
            ' Set the WFRCHNGP_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Remark1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Remark1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_RemarkSpecified Then
                				
                ' If the WFRCHNGP_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Remark)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(WFinRepNGP_Head1Table.WFRCHNGP_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WFinRepNGP_Head1Table, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WFRCHNGP_Remark\"", \""WFRCHNGP_Remark1\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
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
                
                Me.WFRCHNGP_Remark1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Remark1.Text = WFinRepNGP_Head1Table.WFRCHNGP_Remark.Format(WFinRepNGP_Head1Table.WFRCHNGP_Remark.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_RptCount()

                  
            
        
            ' Set the WFRCHNGP_RptCount Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_RptCount is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_RptCount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_RptCountSpecified Then
                				
                ' If the WFRCHNGP_RptCount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_RptCount)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_RptCount.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_RptCount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_RptCount.Text = WFinRepNGP_Head1Table.WFRCHNGP_RptCount.Format(WFinRepNGP_Head1Table.WFRCHNGP_RptCount.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Status1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Status1.ID) Then
            
                Me.WFRCHNGP_Status1.Text = Me.PreviousUIData(Me.WFRCHNGP_Status1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Status1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Status1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_StatusSpecified Then
                				
                ' If the WFRCHNGP_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.WFRCHNGP_Status.ToString()
                                
                            
                Me.WFRCHNGP_Status1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Status1.Text = WFinRepNGP_Head1Table.WFRCHNGP_Status.DefaultValue		
                End If
                 
              AddHandler Me.WFRCHNGP_Status1.TextChanged, AddressOf WFRCHNGP_Status1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Year1()

                  
            
        
            ' Set the WFRCHNGP_Year Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Year1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Year1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_YearSpecified Then
                				
                ' If the WFRCHNGP_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Year)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Year1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Year1.Text = WFinRepNGP_Head1Table.WFRCHNGP_Year.Format(WFinRepNGP_Head1Table.WFRCHNGP_Year.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Year2()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WFRCHNGP_Year2.ID) Then
            
                Me.WFRCHNGP_Year2.Text = Me.PreviousUIData(Me.WFRCHNGP_Year2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WFRCHNGP_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Year2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Year2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_YearSpecified Then
                				
                ' If the WFRCHNGP_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Year)
                              
                Me.WFRCHNGP_Year2.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Year2.Text = WFinRepNGP_Head1Table.WFRCHNGP_Year.Format(WFinRepNGP_Head1Table.WFRCHNGP_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_Year2.TextChanged, AddressOf WFRCHNGP_Year2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetTabPanel3()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWFinRepNGP_HeadTableControlTabContainer()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWFinRepNGP_DocAttach1TableControl()           
        
        
            If WFinRepNGP_DocAttach1TableControl.Visible Then
                WFinRepNGP_DocAttach1TableControl.LoadData()
                WFinRepNGP_DocAttach1TableControl.DataBind()
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

      
        
        ' To customize, override this method in WFinRepNGP_Head1TableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_Head1TableControl"), WFinRepNGP_Head1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRepNGP_Head1TableControl"), WFinRepNGP_Head1TableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recWFinRepNGP_DocAttach1TableControl as WFinRepNGP_DocAttach1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_DocAttach1TableControl"), WFinRepNGP_DocAttach1TableControl)
        recWFinRepNGP_DocAttach1TableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WFinRepNGP_Head1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWFRCHNGP_C_ID2()
            GetWFRCHNGP_C_ID3()
            GetWFRCHNGP_Description1()
            GetWFRCHNGP_Description2()
            GetWFRCHNGP_ID1()
            GetWFRCHNGP_Month1()
            GetWFRCHNGP_Month2()
            GetWFRCHNGP_Remark1()
            GetWFRCHNGP_RptCount()
            GetWFRCHNGP_Status1()
            GetWFRCHNGP_Year1()
            GetWFRCHNGP_Year2()
        End Sub
        
        
        Public Overridable Sub GetWFRCHNGP_C_ID2()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_C_ID3()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_C_ID ASP:TextBox, and
            ' save it into the WFRCHNGP_C_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_C_ID3.Text, WFinRepNGP_Head1Table.WFRCHNGP_C_ID)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Description1()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_Description ASP:TextBox, and
            ' save it into the WFRCHNGP_Description field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_Description1.Text, WFinRepNGP_Head1Table.WFRCHNGP_Description)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Description2()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_ID1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Month1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Month2()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_Month ASP:TextBox, and
            ' save it into the WFRCHNGP_Month field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_Month2.Text, WFinRepNGP_Head1Table.WFRCHNGP_Month)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Remark1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_RptCount()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Status1()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_Status ASP:TextBox, and
            ' save it into the WFRCHNGP_Status field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_Status1.Text, WFinRepNGP_Head1Table.WFRCHNGP_Status)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Year1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Year2()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_Year ASP:TextBox, and
            ' save it into the WFRCHNGP_Year field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_Year2.Text, WFinRepNGP_Head1Table.WFRCHNGP_Year)			

                      
        End Sub
                
      
        ' To customize, override this method in WFinRepNGP_Head1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRepNGP_Head1TableControlRow.
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
          WFinRepNGP_Head1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_Head1TableControl"), WFinRepNGP_Head1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRepNGP_Head1TableControl"), WFinRepNGP_Head1TableControl).ResetData = True
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
        
        Protected Overridable Sub WFRCHNGP_C_ID3_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Description1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Month2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Status1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Year2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseWFinRepNGP_Head1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_Head1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_Head1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_Head1Record)
            End Get
            Set(ByVal value As WFinRepNGP_Head1Record)
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
        
        Public ReadOnly Property TabPanel3() As AjaxControlToolkit.TabPanel
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TabPanel3"), AjaxControlToolkit.TabPanel)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_DocAttach1TableControl() As WFinRepNGP_DocAttach1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_DocAttach1TableControl"), WFinRepNGP_DocAttach1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_HeadTableControlTabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_HeadTableControlTabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_C_ID2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_ID2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_C_ID3() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_ID3"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Description1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Description1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Description2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Description2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_ID1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_ID1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Month1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Month1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Month2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Month2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Remark1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Remark1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_RptCount() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_RptCount"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Status1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Status1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Year1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Year1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Year2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Year2"), System.Web.UI.WebControls.TextBox)
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
            
            Dim rec As WFinRepNGP_Head1Record = Nothing
             
        
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
            
            Dim rec As WFinRepNGP_Head1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRepNGP_Head1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_Head1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRepNGP_Head1TableControl control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_Head1TableControl.
Public Class BaseWFinRepNGP_Head1TableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
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
                    For Each rc As WFinRepNGP_Head1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
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
            ByVal pageSize As Integer) As WFinRepNGP_Head1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_Head1Table.Column1, True)         
            ' selCols.Add(WFinRepNGP_Head1Table.Column2, True)          
            ' selCols.Add(WFinRepNGP_Head1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRepNGP_Head1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRepNGP_Head1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRepNGP_Head1Table.Column1, True)         
            ' selCols.Add(WFinRepNGP_Head1Table.Column2, True)          
            ' selCols.Add(WFinRepNGP_Head1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRepNGP_Head1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRepNGP_Head1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Head1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRepNGP_Head1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_Head1TableControlRow"), WFinRepNGP_Head1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetWFRCHNGP_C_IDLabel()
                SetWFRCHNGP_DescriptionLabel1()
                SetWFRCHNGP_MonthLabel()
                SetWFRCHNGP_RemarkLabel1()
                SetWFRCHNGP_RptCountLabel()
                SetWFRCHNGP_YearLabel()
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
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_Head1Table.WFRCHNGP_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_Head1Table.WFRCHNGP_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRepNGP_Head1Table.WFRCHNGP_Status, Me.DataSource)
          
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
        

            ' Bind the buttons for WFinRepNGP_Head1TableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRepNGP_Head1TableControlRow
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
            WFinRepNGP_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRepNGP_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
        
          Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
        
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
        
        End Sub

        Protected Overridable Sub AddNewRecords()
          
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Head1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRepNGP_Head1TableControlRow = DirectCast(repItem.FindControl("WFinRepNGP_Head1TableControlRow"), WFinRepNGP_Head1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRepNGP_Head1Record = New WFinRepNGP_Head1Record()
        
                        If recControl.WFRCHNGP_C_ID2.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_C_ID2.Text, WFinRepNGP_Head1Table.WFRCHNGP_C_ID)
                        End If
                        If recControl.WFRCHNGP_C_ID3.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_C_ID3.Text, WFinRepNGP_Head1Table.WFRCHNGP_C_ID)
                        End If
                        If recControl.WFRCHNGP_Description1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Description1.Text, WFinRepNGP_Head1Table.WFRCHNGP_Description)
                        End If
                        If recControl.WFRCHNGP_Description2.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Description2.Text, WFinRepNGP_Head1Table.WFRCHNGP_Description)
                        End If
                        If recControl.WFRCHNGP_File.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_File.Text, WFinRepNGP_Head1Table.WFRCHNGP_File)
                        End If
                        If recControl.WFRCHNGP_ID1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_ID1.Text, WFinRepNGP_Head1Table.WFRCHNGP_ID)
                        End If
                        If recControl.WFRCHNGP_Month1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Month1.Text, WFinRepNGP_Head1Table.WFRCHNGP_Month)
                        End If
                        If recControl.WFRCHNGP_Month2.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Month2.Text, WFinRepNGP_Head1Table.WFRCHNGP_Month)
                        End If
                        If recControl.WFRCHNGP_Remark1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Remark1.Text, WFinRepNGP_Head1Table.WFRCHNGP_Remark)
                        End If
                        If recControl.WFRCHNGP_RptCount.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_RptCount.Text, WFinRepNGP_Head1Table.WFRCHNGP_RptCount)
                        End If
                        If recControl.WFRCHNGP_Status1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Status1.Text, WFinRepNGP_Head1Table.WFRCHNGP_Status)
                        End If
                        If recControl.WFRCHNGP_Year1.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Year1.Text, WFinRepNGP_Head1Table.WFRCHNGP_Year)
                        End If
                        If recControl.WFRCHNGP_Year2.Text <> "" Then
                            rec.Parse(recControl.WFRCHNGP_Year2.Text, WFinRepNGP_Head1Table.WFRCHNGP_Year)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRepNGP_Head1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRepNGP_Head1Record)), WFinRepNGP_Head1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRepNGP_Head1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRepNGP_Head1TableControlRow) As Boolean
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
                
        Public Overridable Sub SetWFRCHNGP_DescriptionLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_DescriptionLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_MonthLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_MonthLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_RemarkLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_RemarkLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_RptCountLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_RptCountLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_YearLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_YearLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WFinRepNGP_Head1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRepNGP_Head1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WFinRepNGP_Head1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRepNGP_Head1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_Head1Record())
            End Get
            Set(ByVal value() As WFinRepNGP_Head1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property WFRCHNGP_C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_DescriptionLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_DescriptionLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_MonthLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_MonthLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_RemarkLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_RemarkLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_RptCountLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_RptCountLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_YearLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_YearLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WFinRepNGP_Head1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_Head1Record = Nothing     
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
                Dim recCtl As WFinRepNGP_Head1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRepNGP_Head1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRepNGP_Head1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRepNGP_Head1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRepNGP_Head1TableControlRow)), WFinRepNGP_Head1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRepNGP_Head1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRepNGP_Head1TableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRepNGP_Head1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRepNGP_Head1TableControlRow")
            Dim list As New List(Of WFinRepNGP_Head1TableControlRow)
            For Each recCtrl As WFinRepNGP_Head1TableControlRow In recCtrls
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

  
' Base class for the WFinRepNGP_Head1RecordControl control on the WFinRepNGP_Approver1 page.
' Do not modify this class. Instead override any method in WFinRepNGP_Head1RecordControl.
Public Class BaseWFinRepNGP_Head1RecordControl
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRepNGP_Head1RecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

      
            ' Setup the filter and search events.
            
        End Sub

        '  To customize, override this method in WFinRepNGP_Head1RecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.pApproved.Click, AddressOf pApproved_Click
                        
              AddHandler Me.pReject.Click, AddressOf pReject_Click
                        
              AddHandler Me.pReturned.Click, AddressOf pReturned_Click
                        
              AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
                        
              AddHandler Me.WFRCHNGP_U_ID.SelectedIndexChanged, AddressOf WFRCHNGP_U_ID_SelectedIndexChanged
            
              AddHandler Me.WFRCHNGP_Submit.CheckedChanged, AddressOf WFRCHNGP_Submit_CheckedChanged
            
              AddHandler Me.WFRCHNGP_C_ID.TextChanged, AddressOf WFRCHNGP_C_ID_TextChanged
            
              AddHandler Me.WFRCHNGP_C_ID1.TextChanged, AddressOf WFRCHNGP_C_ID1_TextChanged
            
              AddHandler Me.WFRCHNGP_Month.TextChanged, AddressOf WFRCHNGP_Month_TextChanged
            
              AddHandler Me.WFRCHNGP_Remark.TextChanged, AddressOf WFRCHNGP_Remark_TextChanged
            
              AddHandler Me.WFRCHNGP_U_ID1.TextChanged, AddressOf WFRCHNGP_U_ID1_TextChanged
            
              AddHandler Me.WFRCHNGP_Year.TextChanged, AddressOf WFRCHNGP_Year_TextChanged
            					
              AddHandler Me.txtRemarks.TextChanged, AddressOf txtRemarks_TextChanged
                    
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRepNGP_Head1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Head1RecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New WFinRepNGP_Head1Record()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As WFinRepNGP_Head1Record = WFinRepNGP_Head1Table.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = WFinRepNGP_Head1Table.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRepNGP_Head1RecordControl.
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
        
                
                
                
                
                SetTabPanel()
                SetTabPanel1()
                SetTabPanel2()
                
                SettxtRemarks()
                
                
                SetWFinRepNGP_Head1TabContainer()
                
                SetWFRCHNGP_C_ID()
                SetWFRCHNGP_C_ID1()
                SetWFRCHNGP_Description()
                SetWFRCHNGP_DescriptionLabel()
                SetWFRCHNGP_DT_ID()
                SetWFRCHNGP_DT_ID1()
                SetWFRCHNGP_DT_IDLabel()
                SetWFRCHNGP_ID()
                SetWFRCHNGP_Month()
                SetWFRCHNGP_Remark()
                SetWFRCHNGP_RemarkLabel()
                SetWFRCHNGP_Status()
                SetWFRCHNGP_StatusLabel()
                SetWFRCHNGP_Submit()
                SetWFRCHNGP_U_ID()
                SetWFRCHNGP_U_ID1()
                SetWFRCHNGP_Year()
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
              WFinRepNGP_Activity1TableControl.ResetControl()
            End IF
                    
        SetWFinRepNGP_Activity1TableControl()
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              WFinRepNGP_Attachment1TableControl.ResetControl()
            End IF
                    
        SetWFinRepNGP_Attachment1TableControl()
        
        SetWFinRepNGP_Head1TableControl()
        
        End Sub
        
        
        Public Overridable Sub SetWFRCHNGP_C_ID()

                  
            
        
            ' Set the WFRCHNGP_C_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then
                				
                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID)
                              
                Me.WFRCHNGP_C_ID.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_C_ID.Text = WFinRepNGP_Head1Table.WFRCHNGP_C_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_C_ID.TextChanged, AddressOf WFRCHNGP_C_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_C_ID1()

                  
            
        
            ' Set the WFRCHNGP_C_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_C_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_C_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_C_IDSpecified Then
                				
                ' If the WFRCHNGP_C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID)
                              
                Me.WFRCHNGP_C_ID1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_C_ID1.Text = WFinRepNGP_Head1Table.WFRCHNGP_C_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_C_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_C_ID1.TextChanged, AddressOf WFRCHNGP_C_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Description()

                  
            
        
            ' Set the WFRCHNGP_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_DescriptionSpecified Then
                				
                ' If the WFRCHNGP_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Description.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Description.Text = WFinRepNGP_Head1Table.WFRCHNGP_Description.Format(WFinRepNGP_Head1Table.WFRCHNGP_Description.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_DT_ID()

                  
            
        
            ' Set the WFRCHNGP_DT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_DT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_DT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_DT_IDSpecified Then
                				
                ' If the WFRCHNGP_DT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Head1Table.WFRCHNGP_DT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Head1Table.WFRCHNGP_DT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_Head1Table.GetDFKA(Me.DataSource.WFRCHNGP_DT_ID.ToString(),WFinRepNGP_Head1Table.WFRCHNGP_DT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_DT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_DT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_DT_ID.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_DT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_DT_ID.Text = WFinRepNGP_Head1Table.WFRCHNGP_DT_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_DT_ID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_DT_ID1()

                  
            
        
            ' Set the WFRCHNGP_DT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_DT_ID1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_DT_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_DT_IDSpecified Then
                				
                ' If the WFRCHNGP_DT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Head1Table.WFRCHNGP_DT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Head1Table.WFRCHNGP_DT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_Head1Table.GetDFKA(Me.DataSource.WFRCHNGP_DT_ID.ToString(),WFinRepNGP_Head1Table.WFRCHNGP_DT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_DT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_DT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_DT_ID1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_DT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_DT_ID1.Text = WFinRepNGP_Head1Table.WFRCHNGP_DT_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_DT_ID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_ID()

                  
            
        
            ' Set the WFRCHNGP_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_IDSpecified Then
                				
                ' If the WFRCHNGP_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_ID.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_ID.Text = WFinRepNGP_Head1Table.WFRCHNGP_ID.Format(WFinRepNGP_Head1Table.WFRCHNGP_ID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Month()

                  
            
        
            ' Set the WFRCHNGP_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Month is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_MonthSpecified Then
                				
                ' If the WFRCHNGP_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.WFRCHNGP_Month.ToString()
                                
                            
                Me.WFRCHNGP_Month.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Month.Text = WFinRepNGP_Head1Table.WFRCHNGP_Month.DefaultValue		
                End If
                 
              AddHandler Me.WFRCHNGP_Month.TextChanged, AddressOf WFRCHNGP_Month_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Remark()

                  
            
        
            ' Set the WFRCHNGP_Remark TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Remark is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_RemarkSpecified Then
                				
                ' If the WFRCHNGP_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Remark)
                              
                Me.WFRCHNGP_Remark.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Remark.Text = WFinRepNGP_Head1Table.WFRCHNGP_Remark.Format(WFinRepNGP_Head1Table.WFRCHNGP_Remark.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_Remark.TextChanged, AddressOf WFRCHNGP_Remark_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Status()

                  
            
        
            ' Set the WFRCHNGP_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_StatusSpecified Then
                				
                ' If the WFRCHNGP_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Head1Table.WFRCHNGP_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Head1Table.WFRCHNGP_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRepNGP_Head1Table.GetDFKA(Me.DataSource.WFRCHNGP_Status.ToString(),WFinRepNGP_Head1Table.WFRCHNGP_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WFRCHNGP_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRCHNGP_Status.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Status.Text = WFinRepNGP_Head1Table.WFRCHNGP_Status.Format(WFinRepNGP_Head1Table.WFRCHNGP_Status.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Submit()

                      
            
        
            ' Set the WFRCHNGP_Submit CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Submit is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWFRCHNGP_Submit()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_SubmitSpecified Then
                									
                ' If the WFRCHNGP_Submit is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.WFRCHNGP_Submit.Checked = Me.DataSource.WFRCHNGP_Submit
            Else
            
                ' WFRCHNGP_Submit is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WFRCHNGP_Submit.Checked = WFinRepNGP_Head1Table.WFRCHNGP_Submit.ParseValue(WFinRepNGP_Head1Table.WFRCHNGP_Submit.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_U_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WFRCHNGP_U_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_U_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_U_IDSpecified Then
                            
                ' If the WFRCHNGP_U_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WFRCHNGP_U_ID.ToString()
            Else
                
                ' WFRCHNGP_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WFinRepNGP_Head1Table.WFRCHNGP_U_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWFRCHNGP_U_IDDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_U_ID1()

                  
            
        
            ' Set the WFRCHNGP_U_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_U_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_U_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_U_IDSpecified Then
                				
                ' If the WFRCHNGP_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.WFRCHNGP_U_ID.ToString()
                                
                            
                Me.WFRCHNGP_U_ID1.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_U_ID1.Text = WFinRepNGP_Head1Table.WFRCHNGP_U_ID.DefaultValue		
                End If
                 
              AddHandler Me.WFRCHNGP_U_ID1.TextChanged, AddressOf WFRCHNGP_U_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFRCHNGP_Year()

                  
            
        
            ' Set the WFRCHNGP_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRepNGP_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record retrieved from the database.
            ' Me.WFRCHNGP_Year is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRCHNGP_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRCHNGP_YearSpecified Then
                				
                ' If the WFRCHNGP_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRepNGP_Head1Table.WFRCHNGP_Year)
                              
                Me.WFRCHNGP_Year.Text = formattedValue
                
            Else 
            
                ' WFRCHNGP_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRCHNGP_Year.Text = WFinRepNGP_Head1Table.WFRCHNGP_Year.Format(WFinRepNGP_Head1Table.WFRCHNGP_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WFRCHNGP_Year.TextChanged, AddressOf WFRCHNGP_Year_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetTabPanel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetTabPanel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetTabPanel2()

                  
                  
                  End Sub
                
        Public Overridable Sub SettxtRemarks()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWFinRepNGP_Head1TabContainer()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_DescriptionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_DescriptionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_DT_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_DT_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_RemarkLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFRCHNGP_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WFRCHNGP_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWFinRepNGP_Activity1TableControl()           
        
        
            If WFinRepNGP_Activity1TableControl.Visible Then
                WFinRepNGP_Activity1TableControl.LoadData()
                WFinRepNGP_Activity1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRepNGP_Attachment1TableControl()           
        
        
            If WFinRepNGP_Attachment1TableControl.Visible Then
                WFinRepNGP_Attachment1TableControl.LoadData()
                WFinRepNGP_Attachment1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRepNGP_Head1TableControl()           
        
        
            If WFinRepNGP_Head1TableControl.Visible Then
                WFinRepNGP_Head1TableControl.LoadData()
                WFinRepNGP_Head1TableControl.DataBind()
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

      
        
        ' To customize, override this method in WFinRepNGP_Head1RecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Head1RecordControlPanel"), System.Web.UI.WebControls.Panel)

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
          
        Dim recWFinRepNGP_Activity1TableControl as WFinRepNGP_Activity1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Activity1TableControl"), WFinRepNGP_Activity1TableControl)
        recWFinRepNGP_Activity1TableControl.SaveData()
          
        Dim recWFinRepNGP_Attachment1TableControl as WFinRepNGP_Attachment1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Attachment1TableControl"), WFinRepNGP_Attachment1TableControl)
        recWFinRepNGP_Attachment1TableControl.SaveData()
          
        Dim recWFinRepNGP_Head1TableControl as WFinRepNGP_Head1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Head1TableControl"), WFinRepNGP_Head1TableControl)
        recWFinRepNGP_Head1TableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WFinRepNGP_Head1RecordControl.
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
            GetWFRCHNGP_DT_ID()
            GetWFRCHNGP_DT_ID1()
            GetWFRCHNGP_ID()
            GetWFRCHNGP_Month()
            GetWFRCHNGP_Remark()
            GetWFRCHNGP_Status()
            GetWFRCHNGP_Submit()
            GetWFRCHNGP_U_ID()
            GetWFRCHNGP_U_ID1()
            GetWFRCHNGP_Year()
        End Sub
        
        
        Public Overridable Sub GetWFRCHNGP_C_ID()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_C_ID ASP:TextBox, and
            ' save it into the WFRCHNGP_C_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_C_ID.Text, WFinRepNGP_Head1Table.WFRCHNGP_C_ID)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_C_ID1()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_C_ID ASP:TextBox, and
            ' save it into the WFRCHNGP_C_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_C_ID1.Text, WFinRepNGP_Head1Table.WFRCHNGP_C_ID)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Description()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_DT_ID()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_DT_ID1()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_ID()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Month()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_Month ASP:TextBox, and
            ' save it into the WFRCHNGP_Month field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_Month.Text, WFinRepNGP_Head1Table.WFRCHNGP_Month)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Remark()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_Remark ASP:TextBox, and
            ' save it into the WFRCHNGP_Remark field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_Remark.Text, WFinRepNGP_Head1Table.WFRCHNGP_Remark)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Status()
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Submit()
        
        
            ' Retrieve the value entered by the user on the WFRCHNGP_Submit ASP:CheckBox, and
            ' save it into the WFRCHNGP_Submit field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.WFRCHNGP_Submit = Me.WFRCHNGP_Submit.Checked
                    
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_U_ID()
         
            ' Retrieve the value entered by the user on the WFRCHNGP_U_ID ASP:DropDownList, and
            ' save it into the WFRCHNGP_U_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WFRCHNGP_U_ID), WFinRepNGP_Head1Table.WFRCHNGP_U_ID)				
            
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_U_ID1()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_U_ID ASP:TextBox, and
            ' save it into the WFRCHNGP_U_ID field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_U_ID1.Text, WFinRepNGP_Head1Table.WFRCHNGP_U_ID)			

                      
        End Sub
                
        Public Overridable Sub GetWFRCHNGP_Year()
            
            ' Retrieve the value entered by the user on the WFRCHNGP_Year ASP:TextBox, and
            ' save it into the WFRCHNGP_Year field in DataSource DatabaseANFLO-WFN%dbo.WFinRepNGP_Head record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WFRCHNGP_Year.Text, WFinRepNGP_Head1Table.WFRCHNGP_Year)			

                      
        End Sub
                
      
        ' To customize, override this method in WFinRepNGP_Head1RecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
      
        Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
      
            Dim wc As WhereClause
            WFinRepNGP_Head1Table.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
                  Dim recId As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString.Item("WFinRepNGP_Head1"))
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "ePortalWFApproval").Replace("{URL}", "WFinRepNGP_Head1"))
            End If
            HttpContext.Current.Session("QueryString in WFinRepNGP-Approver1") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(WFinRepNGP_Head1Table.WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(WFinRepNGP_Head1Table.WFRCHNGP_ID))
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(WFinRepNGP_Head1Table.WFRCHNGP_ID, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            WFinRepNGP_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersWFinRepNGP_Activity1TableControl As Boolean = False
              
                Dim hasFiltersWFinRepNGP_Attachment1TableControl As Boolean = False
              
                Dim hasFiltersWFinRepNGP_DocAttach1TableControl As Boolean = False
              
                Dim hasFiltersWFinRepNGP_Head1RecordControl As Boolean = False
              
                Dim hasFiltersWFinRepNGP_Head1TableControl As Boolean = False
              
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
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
        
    

        ' To customize, override this method in WFinRepNGP_Head1RecordControl.
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
          WFinRepNGP_Head1Table.DeleteRecord(pkValue)
          
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
            
                        
        Public Overridable Function CreateWhereClause_WFRCHNGP_U_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.sel_WASP_User table.
            ' Examples:
            ' wc.iAND(Sel_WASP_User1View.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(Sel_WASP_User1View.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
        ' Fill the WFRCHNGP_U_ID list.
        Protected Overridable Sub PopulateWFRCHNGP_U_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WFRCHNGP_U_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WFRCHNGP_U_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WFRCHNGP_U_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WFRCHNGP_U_IDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Sel_WASP_User1View.W_U_Full_Name, OrderByItem.OrderDir.Asc)

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
                            
                            If counter < maxItems AndAlso Me.WFRCHNGP_U_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Head1Table.WFRCHNGP_U_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Head1Table.WFRCHNGP_U_ID.IsApplyDisplayAs Then
                                fvalue = WFinRepNGP_Head1Table.GetDFKA(itemValue, WFinRepNGP_Head1Table.WFRCHNGP_U_ID)
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

                                Dim dupItem As ListItem = Me.WFRCHNGP_U_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WFRCHNGP_U_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WFRCHNGP_U_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WFRCHNGP_U_ID, selectedValue)Then

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
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRepNGP_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRepNGP_Head1Table.WFRCHNGP_U_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WFinRepNGP_Head1Table.WFRCHNGP_U_ID.IsApplyDisplayAs Then
                          fvalue = WFinRepNGP_Head1Table.GetDFKA(itemValue, WFinRepNGP_Head1Table.WFRCHNGP_U_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(Sel_WASP_User1View.W_U_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WFRCHNGP_U_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

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
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Security/Homepage.aspx"
                  
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
        
        Protected Overridable Sub WFRCHNGP_U_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WFRCHNGP_U_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WFRCHNGP_U_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WFRCHNGP_U_ID.Items.Add(New ListItem(displayText, val))
                Me.WFRCHNGP_U_ID.SelectedIndex = Me.WFRCHNGP_U_ID.Items.Count - 1
                Me.Page.Session.Remove(WFRCHNGP_U_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WFRCHNGP_U_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WFRCHNGP_Submit_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WFRCHNGP_C_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_C_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Month_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Remark_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_U_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WFRCHNGP_Year_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseWFinRepNGP_Head1RecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRepNGP_Head1RecordControl_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRepNGP_Head1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRepNGP_Head1Record)
            End Get
            Set(ByVal value As WFinRepNGP_Head1Record)
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
        
        Public ReadOnly Property TabPanel() As AjaxControlToolkit.TabPanel
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TabPanel"), AjaxControlToolkit.TabPanel)
            End Get
        End Property
        
        Public ReadOnly Property TabPanel1() As AjaxControlToolkit.TabPanel
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TabPanel1"), AjaxControlToolkit.TabPanel)
            End Get
        End Property
        
        Public ReadOnly Property TabPanel2() As AjaxControlToolkit.TabPanel
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TabPanel2"), AjaxControlToolkit.TabPanel)
            End Get
        End Property
        
        Public ReadOnly Property Title0() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title0"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property txtRemarks() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "txtRemarks"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_Activity1TableControl() As WFinRepNGP_Activity1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Activity1TableControl"), WFinRepNGP_Activity1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_Attachment1TableControl() As WFinRepNGP_Attachment1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Attachment1TableControl"), WFinRepNGP_Attachment1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_Head1TabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Head1TabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property WFinRepNGP_Head1TableControl() As WFinRepNGP_Head1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRepNGP_Head1TableControl"), WFinRepNGP_Head1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_C_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_C_ID"), System.Web.UI.WebControls.TextBox)
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
            
        Public ReadOnly Property WFRCHNGP_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_DT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_DT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_DT_ID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_DT_ID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_DT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_DT_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Month() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Month"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Remark() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Remark"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRCHNGP_Submit() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Submit"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_U_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_U_ID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_U_ID1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_U_ID1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WFRCHNGP_Year() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRCHNGP_Year"), System.Web.UI.WebControls.TextBox)
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
            
            Dim rec As WFinRepNGP_Head1Record = Nothing
             
        
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
            
            Dim rec As WFinRepNGP_Head1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRepNGP_Head1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRepNGP_Head1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  