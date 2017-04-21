
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' WPO_WFTaskN.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.WPO_WFTaskN

#Region "Section 1: Place your customizations here."

    
Public Class Sel_WPO_WFTaskRecordControl
        Inherits BaseSel_WPO_WFTaskRecordControl
        ' The BaseSel_WPO_WFTaskRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

        Public Overrides Sub SaveData()

            Me.LoadData()

            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "EPORTAL"))
                End If
            End If

            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskRecordControlPanel"), System.Web.UI.WebControls.Panel)

            If ((Not IsNothing(Panel)) AndAlso (Not Panel.Visible)) OrElse IsNothing(Me.DataSource) Then
                Return
            End If

            Me.Validate()
            Me.GetUIData()

            If Me.DataSource.IsAnyValueChanged Then
                Me.DataSource.Save()
            End If

            Me.DataChanged = True
            Me.ResetData = True

            Me.CheckSum = ""
        End Sub

End Class

  

Public Class Sel_WPO_WFTaskActivity_RemarksRecordControl
        Inherits BaseSel_WPO_WFTaskActivity_RemarksRecordControl
        ' The BaseSel_WPO_WFTaskActivity_RemarksRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
   	Public Overrides Function CreateWhereClause() As WhereClause
            Sel_WPO_WFTaskActivity_RemarksView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim ctlHead As Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_WFTaskRecordControl"), Sel_WPO_WFTaskRecordControl)

            wc.iAND(Sel_WPO_WFTaskActivity_RemarksView.WPOP_PONMBR, BaseFilter.ComparisonOperator.EqualsTo, ctlHead.PONUMBER.Text)
            wc.iAND(Sel_WPO_WFTaskActivity_RemarksView.WPOP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, ctlHead.CompanyID2.Text)



            Return wc
        End Function

End Class
Public Class WPOP10100RecordControl
        Inherits BaseWPOP10100RecordControl
        ' The BaseWPOP10100RecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
   
        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Select Case System.Web.HttpContext.Current.Session("UserIDNorth").ToString
                Case "7", "8", "34"
                    'Me.btnReject.Attributes.Add("onclick", "ConfirmSubmission(event);")
                    Me.btnApprove.Attributes.Add("onclick", "return confirm('Continue submission of this document with (Approve) Action setting? Press OK to confirm document submission or press Cancel to abort operation.');")
                    Me.btnReject.Attributes.Add("onclick", "return confirm('Continue submission of this document with (Reject) Action setting? Press OK to confirm document submission or press Cancel to abort operation.');")
                    Me.btnReturn.Attributes.Add("onclick", "return confirm('Continue submission of this document with (Return) Action setting? Press OK to confirm document submission or press Cancel to abort operation.');")
                Case Else
                    'Me.btnApprove.Attributes.Add("onclick", "ShowConfirm(event,'Submit Action','Continue submission of this document? Press OK to confirm document submission or press Cancel to abort operation.','Concerned approver or requester will be notified through email.');")
                    'Me.btnReject.Attributes.Add("onclick", "ConfirmSubmission(event);")
                    'Me.btnReturn.Attributes.Add("onclick", "ConfirmSubmissionReturn(event);")
                    Me.btnApprove.Attributes.Add("onclick", "return confirm('Continue submission of this document with (Approve) Action setting? Press OK to confirm document submission or press Cancel to abort operation.');")
                    Me.btnReject.Attributes.Add("onclick", "return ConfirmSubmissionNative(event);")
                    Me.btnReturn.Attributes.Add("onclick", "return ConfirmSubmissionNativeReturn(event);")
            End Select

            AddHandler Me.btnApprove.Click, AddressOf btnApprove_Click
            AddHandler Me.btnReject.Click, AddressOf btnReject_Click
            AddHandler Me.btnReturn.Click, AddressOf btnReturn_Click
        End Sub

        Private Sub MyPreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            Dim script As String = "<script language=""javascript"">" & vbCrLf & _
            "function ConfirmSubmissionNativeReturn(event){" & vbCrLf & _
            "  //event.returnValue = false;" & vbCrLf & _
            "  var t;" & vbCrLf & _
            "  var s;" & vbCrLf & _
            "  t = document.getElementById('" & Me.WPOP_Remark.ClientID & "');" & vbCrLf & _
            "  s = t.value;" & vbCrLf & _
            "  s = s.replace(/^\s*/, '').replace(/\s*$/, '');" & vbCrLf & _
            "  if (s == '') {" & vbCrLf & _
            "    alert('Please put remarks when returning.'); return false;}" & vbCrLf & _
            "  else{return confirm('Continue submission of this document with Return action? Press OK to confirm document submission or press Cancel to abort operation.');}" & vbCrLf & _
            "}" & vbCrLf & _
            "" & vbCrLf & _
            "function ConfirmSubmissionNative(event){" & vbCrLf & _
            "  //event.returnValue = false;" & vbCrLf & _
            "  var t;" & vbCrLf & _
            "  var s;" & vbCrLf & _
            "  t = document.getElementById('" & Me.WPOP_Remark.ClientID & "');" & vbCrLf & _
            "  s = t.value;" & vbCrLf & _
            "  s = s.replace(/^\s*/, '').replace(/\s*$/, '');" & vbCrLf & _
            "  if (s == '') {" & vbCrLf & _
            "    alert('Please put remarks when rejecting.'); return false;}" & vbCrLf & _
            "  else{return confirm('Continue submission of this document with Reject action? Press OK to confirm document submission or press Cancel to abort operation.');}" & vbCrLf & _
            "}" & vbCrLf & _
            "" & vbCrLf & _
            "function ConfirmSubmission(event){" & vbCrLf & _
            "  event.returnValue = false;" & vbCrLf & _
            "  var t;" & vbCrLf & _
            "  var s;" & vbCrLf & _
            "  t = document.getElementById('" & Me.WPOP_Remark.ClientID & "');" & vbCrLf & _
            "  s = t.value;" & vbCrLf & _
            "  s = s.replace(/^\s*/, '').replace(/\s*$/, '');" & vbCrLf & _
            "  if (s == '') {" & vbCrLf & _
            "    alert('Please put remarks when rejecting.'); return false;}" & vbCrLf & _
            "  else { ShowConfirm(event,'Submit Action','Continue submission of this document with (Reject) Action setting? Press OK to confirm document submission or press Cancel to abort operation.','Concerned approver or requester will be notified through email.');}" & vbCrLf & _
            "}" & vbCrLf & _
            "" & vbCrLf & _
            "function ConfirmSubmissionReturn(event){" & vbCrLf & _
            "  event.returnValue = false;" & vbCrLf & _
            "  var t;" & vbCrLf & _
            "  var s;" & vbCrLf & _
            "  t = document.getElementById('" & Me.WPOP_Remark.ClientID & "');" & vbCrLf & _
            "  s = t.value;" & vbCrLf & _
            "  s = s.replace(/^\s*/, '').replace(/\s*$/, '');" & vbCrLf & _
            "  if (s == '') {" & vbCrLf & _
            "    alert('Please put remarks when returning this PO to the creator.'); return false;}" & vbCrLf & _
            "  else { ShowConfirm(event,'Submit Action','Continue submission of this document with (Return) Action setting? Press OK to confirm document submission or press Cancel to abort operation.','Concerned requester will be notified through email.');}" & vbCrLf & _
            "}" & vbCrLf & _
            "" & vbCrLf & _
            "</script>" & vbCrLf

            Me.Page.ClientScript.RegisterStartupScript(GetType(Page), "ConfirmSubmission", script)
        End Sub

        Public Overrides Sub DataBind()
            MyBase.DataBind()
            Me.PopulateMoveTo()
        End Sub

		Public Overrides Function CreateWhereClause() As WhereClause
            WPOP101001Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            Dim ctlHeader As Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_WFTaskRecordControl"), Sel_WPO_WFTaskRecordControl)

            wc.iAND(WPOP101001Table.WPOP_PONMBR, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.PONUMBER.Text)
            wc.iAND(WPOP101001Table.WPOP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)

            Return wc
        End Function

        Public Overrides Sub SetWPOP_Remark()
            Me.WPOP_Remark.Text = " "
        End Sub

        Private Function Content_Formatter(User_ID As String, Title As String, Company As String, Details As String, _
        DocDate As String, Remarks As String, Total As String, Requester_ID As String, Color_Hex As String, _
        Page As String, Document As String, ApproverRem As String, Status As String, WF_Type As String, Optional Default_Type As String = "") As String
            Dim wc2 As WhereClause = New WhereClause
            Dim itemValue2 As W_Email1Record
            Dim sDirectory As String
            Dim sSite As String
            Dim sTemplate As String

            If Default_Type = "" Then
                wc2.iAND(W_Email1Table.WE_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)
                wc2.iAND(W_Email1Table.WE_Directory, BaseFilter.ComparisonOperator.EqualsTo, "eportal") '6/1/2015

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
                            sSite = "https://eportal.anflocor.com" 'itemValue21.WE_Site.ToString()
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
            Dim itemValue3 As W_User1Record
            Dim sFullName As String 'creator
            Dim sUserEmail As String 'creator
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
            sTemplate = Replace(sTemplate, "@DOC", "PO# " & Document)
            sTemplate = Replace(sTemplate, "@COLOR", Color_Hex)
            sTemplate = Replace(sTemplate, "@APPREM", ApproverRem)
            sTemplate = Replace(sTemplate, "@STAT", Status)
            sTemplate = Replace(sTemplate, "@WF", WF_Type)
            'sTemplate &= "</table><br><table cellpadding=""0"" cellspacing=""0"" frame=""void"" border=""0"" width=""100%"">" & _
            '"<tr><td style=""font-size: small; width: 20%; font-family: Calibri, Tahoma; height: 21px; padding-left: 3px; " & _
            '"padding-right: 3px; padding-bottom: 3px; padding-top: 3px; background-color: #ffffff;"">" & _
            '"***Click <a href=""http://eportal2.anflocor.com:8091/eportal"""" >here</a> if you are accessing ePortal outside the network.</td></tr>" & _
            '"</table>"

            Return sTemplate
        End Function

        Private Sub Get_Currency(ByVal PO As String, ByVal Comp As String, ByRef Desc As String, ByRef Rate As Single)
            Dim sCanvass As String = ""
            Dim sMarker As String = ""
            Dim sVendor As String = ""
            Dim sCurID As String = ""
            Dim sCurDesc As String = ""
            Dim sCurRate As Single = 0

            Dim sWhere As String = WCanvass_PO_Map1Table.WCPOM_PO_No.UniqueName & "='" & PO & "' And " & _
            WCanvass_PO_Map1Table.WCPOM_C_ID.UniqueName & "=" & Comp
            For Each oItem As WCanvass_PO_Map1Record In WCanvass_PO_Map1Table.GetRecords(sWhere, Nothing, 0, 5)
                sCanvass = oItem.WCPOM_WCDI_ID.ToString()
                sMarker = oItem.WCPOM_Col_Marker.ToString()
                sVendor = oItem.WCPOM_PM00200_Vendor.ToString().Trim()
            Next

            sWhere = WCanvass_PO_Map_Temp1Table.WCDI_ID.UniqueName & "=" & sCanvass & " And " & _
            WCanvass_PO_Map_Temp1Table.Col_Marker.UniqueName & "=" & sMarker & " And " & _
            WCanvass_PO_Map_Temp1Table.WCDI_PM00200_Vendor.UniqueName & "='" & sVendor & "'"
            For Each oItem1 As WCanvass_PO_Map_Temp1Record In WCanvass_PO_Map_Temp1Table.GetRecords(sWhere, Nothing, 0, 5)
                sCurID = oItem1.WCDI_WCur_ID.ToString()
            Next

            sWhere = WCurrency1Table.WCur_ID.UniqueName & " = " & sCurID
            For Each oItem2 As WCurrency1Record In WCurrency1Table.GetRecords(sWhere, Nothing, 0, 5)
                sCurDesc = oItem2.WCur_Desc.ToString()
            Next

            sWhere = Sel_WCurrency_sel_WForeign_Exch_Latest1View.WCur_Desc.UniqueName & " ='" & sCurDesc & "'"
            For Each oItem3 As Sel_WCurrency_sel_WForeign_Exch_Latest1Record In Sel_WCurrency_sel_WForeign_Exch_Latest1View.GetRecords(sWhere, Nothing, 0, 5)
                sCurRate = oItem3.WFE_Peso_Rate
                sCurDesc = oItem3.WCur_Short
            Next
            Rate = sCurRate
            Desc = sCurDesc
        End Sub

        Public Overrides Sub btnApprove_Click(ByVal sender As Object, ByVal args As EventArgs)

            Dim coId As String = CStr(System.Web.HttpContext.Current.Session("CMPNY"))
            Dim poNum As String = CStr(System.Web.HttpContext.Current.Session("PONO"))
            Dim deyt As String = CStr(System.Web.HttpContext.Current.Session("DOCDATE"))
            Dim coDesc As String = CStr(System.Web.HttpContext.Current.Session("CMPNYDESC"))
                Dim xUser As String = System.Web.HttpContext.Current.Session("UserIDNorth").ToString()


                Dim ctlHeader As WPO_WFTaskN.Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskRecordControl"), WPO_WFTaskN.Sel_WPO_WFTaskRecordControl)

            ''Accessing controls in WPOP10100RecordControl''
            Dim oHeader As WPO_WFTaskN.WPOP10100RecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), WPO_WFTaskN.WPOP10100RecordControl)


            Dim wc1 As WhereClause = New WhereClause
            Dim sCurStep As String
            Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Item Details:" & "@D" & _
            "OrderDate: @RD" & "Comment(s): @Rem"



                Dim ctlDetails As WPO_WFTaskN.Sel_WPO_InquireDetailsTableControlRow = DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetailsTableControlRow"), WPO_WFTaskN.Sel_WPO_InquireDetailsTableControlRow)
            Dim sPODetail As String = " "

            Dim ctlWF As WPO_WFTaskN.WPOP10100RecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), WPO_WFTaskN.WPOP10100RecordControl)


            Dim wc As WhereClause = New WhereClause
            wc.iAND(Sel_WPO_InquireDetails1View.PONUMBER, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.PONUMBER.Text)
            wc.iAND(Sel_WPO_InquireDetails1View.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text) 'sCoID

            Dim sngTotal As Single = 0

            For Each recCtl As Sel_WPO_InquireDetails1Record In Sel_WPO_InquireDetails1View.GetRecords(wc, Nothing, 0, 100)

                'sPODetail &= "PO#: " & Trim(ctlHeader.PONUMBER.Text) & vbCrLf & _
                '"Item: " & Trim(recCtl.ITEMDESC.ToString()) & "UOFM: " & recCtl.UOFM.ToString() & "Unit Cost: " & recCtl.UNITCOST.ToString() & " Qty Order: " & recCtl.QTYORDER.ToString() & _
                '" Sub Ttl: " & recCtl.EXTDCOST.ToString()
                sPODetail &= "PO#: " & Trim(ctlHeader.PONUMBER.Text) & vbCrLf & _
                "Item: " & Trim(recCtl.ITEMDESC.ToString()) & "UOFM: " & recCtl.UOFM.ToString() & " Qty Order: " & recCtl.QTYORDER.ToString() & " Unit Cost: " & recCtl.UNITCOST.ToString()

                sngTotal += CSng(recCtl.EXTDCOST.ToString())
            Next

            Dim sngRate As Single = 0
            Dim sngForex As Single = 0
            Dim sCurr As String = ""
            Get_Currency(ctlHeader.PONUMBER.Text, ctlHeader.CompanyID2.Text, sCurr, sngRate)
            If sngRate > 0 Then
                sngForex = sngTotal / sngRate
                sCurr = " (" & sCurr & " " & sngForex.ToString() & ")"
            Else
                sCurr = ""
            End If
            'Dim sVendor As String = Sel_PM00200View.Company_ID.UniqueName & " = " & ctlHeader.CompanyID2.Text & _
            '" And " & Sel_PM00200View.VENDORID.UniqueName & " = '" & 

            sEmailContent = Replace(sEmailContent, "@C", CStr(coDesc.ToString()))
            sEmailContent = Replace(sEmailContent, "@D", sPODetail)
            sEmailContent = Replace(sEmailContent, "@RD", CStr(deyt))
            sEmailContent = Replace(sEmailContent, "@Rem", "SUPPLIER: " & ctlHeader.VENDNAME.Text.Trim() & "</br>" & ctlWF.WPOP_Remark.Text) 'include foreign currency
            'sEmailContent = Replace(sEmailContent, "@NApprove", nStep)

            'sEmailContent &= vbCrLf & vbCrLf & "http://agridata/gpwx/"

            wc1.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                wc1.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc1.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                wc1.iAND(WPO_Activity1Table.WPO_WDT_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.WPOP_DT_ID1.SelectedValue.ToString()) 'added: 3/1/2016
                'note: check to see if record is still submitted, if not then do not save

                If WPO_Activity1Table.GetRecords(wc1, Nothing, 0, 100).Length > 0 Then
                    'note: get Current step to be used in wc2
                    For Each itemValue1 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc1, Nothing, 0, 100)
                        sCurStep = itemValue1.WPO_WS_ID.ToString()
                    Next

                    Dim wc2 As WhereClause = New WhereClause
                    Dim iApprovers As Integer = 0
                    Dim sNextStep As String = ""

                    wc2.iAND(WPO_Step_WPO_StepDetail1View.WPO_S_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)
                    ''below wc2 not included - 2-12-11
                    'wc2.iAND(WPO_Step_WPO_StepDetail1View.WPO_SD_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("ActivityUserID").ToString())
                    For Each itemValue2 As WPO_Step_WPO_StepDetail1Record In WPO_Step_WPO_StepDetail1View.GetRecords(wc2, Nothing, 0, 100)
                        iApprovers = itemValue2.WPO_S_Approval_Needed
                        sNextStep = itemValue2.WPO_S_ID_Next.ToString
                    Next

                    Dim wc3 As WhereClause = New WhereClause
                    Dim colUser As New Collection
                    wc3.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                    wc3.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                    wc3.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "6")
                    wc3.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                    For Each itemValue3 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                        'note: do not include previous same step if wf has been 'Rejected'
                        If Not colUser.Contains(itemValue3.WPO_W_U_ID.ToString) Then
                            colUser.Add(itemValue3.WPO_W_U_ID, itemValue3.WPO_W_U_ID.ToString)
                        End If
                    Next

                    '--------------------------------------------------------------------------------------------------------
                    If iApprovers = colUser.Count + 1 Then 'met the # of approvers requirement (+1 -> means the current user)
                        If sNextStep = "0" Then 'no next step (end workflow here)
                            'note: set current user status task to 'Approved' & set CAR doc status to 'Completed'
                            Dim wc5 As WhereClause = New WhereClause

                            wc5.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                            wc5.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                            wc5.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
                            wc5.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                            If WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                For Each itemValue5 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                    'note: update Activity table (current user) -> 'Approved'
                                WPO_Activity1Record.UpdateRecord(itemValue5.WPO_ID.ToString(), "6")
                                WPO_Activity1Record.UpdateRecord_Final_Approved(itemValue5.WPO_ID.ToString())
                                Next
                            End If
                            'note: set WPOP10100 status to 'Completed - 6'
                            Dim wc6 As WhereClause = New WhereClause
                            wc6.iAND(WPOP101001Table.WPOP_PONMBR, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                            wc6.iAND(WPOP101001Table.WPOP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, coId)
                            For Each itemValue6 As WPOP101001Record In WPOP101001Table.GetRecords(wc6, Nothing, 0, 100)
                            Update_WF_Status(CInt(ctlHeader.CompanyID2.Text), CInt("9"), poNum) 'NOTE:Change this from 6 to 9 inorder to view the po in GP
                            Update_WPOP10100(CInt(ctlHeader.CompanyID2.Text), CInt("6"), poNum)
                            Update_WF_HOLD(CInt(ctlHeader.CompanyID2.Text), CInt("0"), poNum) 'NOTE: Tag the hold field as "0" if completely approved 
                                '##################
                                '### EMAIL HERE ###
                                '##################
                                sEmailContent = Content_Formatter(itemValue6.WPOP_U_ID.ToString(), _
                                "PO Approval Completed (PO# " & poNum.Trim() & ")", CStr(coDesc.ToString()), _
                                sPODetail, CStr(deyt), "SUPPLIER: " & ctlHeader.VENDNAME.Text.Trim() & "<br>" & ctlWF.WPOP_Remark.Text, sngTotal.ToString("#,#.00") & sCurr, _
                                System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#64d04b", "wf_po/Show_WPO_POP10100.aspx", poNum.Trim(), _
                                "PO WF Completed", "PO WF Completed", "PO", "PO Creator")

                                Send_Email_Notification(itemValue6.WPOP_U_ID.ToString(), "PO Approval Completed (PO# " & _
                                poNum.Trim() & ")", sEmailContent)

                                'Send_Email_Notification(itemValue6.WPOP_U_ID.ToString(), "PO Approval Completed (PO# " & _
                                'poNum & ")", sEmailContent)
                            Next
                        Else
                            'note: if # of approvers needed < multiple approvers then set other 'Pending' status to 'System Approved'
                            'note: set current user status to 'Approved'
                            'note: get user(s) for the next step & insert to Activity table
                            Dim wc4 As WhereClause = New WhereClause

                            wc4.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                            wc4.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                            wc4.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                            wc4.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                            For Each itemValue4 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                                'note: update Activity table (other user(s) if multiple approvers) -> 'System Approved'
                            WPO_Activity1Record.UpdateRecord(itemValue4.WPO_ID.ToString(), "11")
                            Next

                            Dim wc5 As WhereClause = New WhereClause
                            wc5.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                            wc5.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                            wc5.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                            wc5.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                            If WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                                For Each itemValue5 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                    'note: update Activity table (current user) -> 'Approved'
                                WPO_Activity1Record.UpdateRecord(itemValue5.WPO_ID.ToString(), "6")
                                WPO_Activity1Record.UpdateRecord_Final_Approved(itemValue5.WPO_ID.ToString()) ''additional: to make IsDone = True
                                Next
                            End If

                            Dim wc6 As WhereClause = New WhereClause
                            wc6.iAND(WPO_Step_WPO_StepDetail1View.WPO_S_ID, BaseFilter.ComparisonOperator.EqualsTo, sNextStep)
                            For Each itemValue6 As WPO_Step_WPO_StepDetail1Record In WPO_Step_WPO_StepDetail1View.GetRecords(wc6, Nothing, 0, 100)
                                'note: use returned items to insert to Activity table
                                'note: do not insert(update) delegate until task expires
                            WPO_Activity1Record.AddRecord(itemValue6.WPO_S_ID.ToString(), itemValue6.WPO_SD_ID.ToString(), _
                            Me.WPOP_DT_ID1.SelectedValue.ToString(), _
                            FindDelegate(itemValue6.WPO_SD_W_U_ID.ToString()), "0", _
                            poNum.ToString(), _
                            DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                            ": " & oHeader.WPOP_Remark.Text)

                                Dim nStep As String = itemValue6.W_U_Full_Name.ToString()
                                sEmailContent &= vbCrLf & vbCrLf & "Next Approver: " & nStep
                                sEmailContent &= vbCrLf & vbCrLf & "https://eportal.anflocor.com/"

                                '******control this notification for GGP*****
                                Select Case itemValue6.WPO_SD_W_U_ID.ToString
                                    Case "8"

                                    Case Else
                                        '##################
                                        '### EMAIL HERE ###
                                        '##################
                                        Dim sInfo As String = ""
                                        Dim sDelegate As String = FindDelegate(itemValue6.WPO_SD_W_U_ID.ToString(), sInfo)
                                    Dim esUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                                    sEmailContent = Content_Formatter(sDelegate, _
         "PO Approval Needed (PO# " & poNum.Trim() & ")", CStr(coDesc.ToString()), _
         sPODetail, CStr(deyt), "SUPPLIER: " & ctlHeader.VENDNAME.Text.Trim() & "<br>" & ctlWF.WPOP_Remark.Text, sngTotal.ToString("#,#.00") & sCurr, _
         System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#4682b4", "Security/HomePage.aspx", poNum.Trim(), _
         "Next Approver: " & nStep, "", "PO")


                                    'MsgBox(sDelegate)
                                    Send_Email_Notification(sDelegate, "PO Approval Needed (PO# " & _
                                                            poNum.Trim() & ")", sEmailContent)

                                        'Send_Email_Notification(itemValue6.WPO_SD_W_U_ID.ToString(), "PO Approval Needed (PO# " & _
                                        'poNum.ToString & ")", sEmailContent)
                                End Select

                                'Send_Email_Notification(itemValue6.WPO_SD_W_U_ID.ToString(), "PO Approval Needed (PO# " & _
                                'poNum.ToString & ")", sEmailContent)
                            Next
                        End If
                    Else 'just set current user status to 'Approved'
                        'note: this routine: requires another user to approve for the WF to move, so just update user's status
                        Dim wc5 As WhereClause = New WhereClause

                        wc5.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                        wc5.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                        wc5.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                        wc5.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                        If WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue5 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                'note: update Activity table (current user) -> 'Approved'
                            WPO_Activity1Record.UpdateRecord(itemValue5.WPO_ID.ToString(), "6")
                                'WPO_Activity1Record.UpdateRecord_Final_Approved(itemValue5.WPO_ID.ToString()) ''additional:to make IsDone = True ''temp hide for testing 2-12-11
                            Next
                        End If

                    Update_WF_Status(CInt(ctlHeader.CompanyID2.Text), CInt("9"), poNum) 'NOTE: Change it from 6 to 9 in updating the POP10100 table
                    'Update_WF_HOLD(CInt(ctlHeader.CompanyID2.Text), CInt("0"), poNum) 'NOTE: Tag the hold field as "0" if completely approved 
                    Update_WPOP10100(CInt(ctlHeader.CompanyID2.Text), CInt("6"), poNum)

                    End If
                End If


            Dim url As String = "../Security/HomePage.aspx"
            url = Me.ModifyRedirectUrl(url, "", False)
            url = Me.Page.ModifyRedirectUrl(url, "", False)
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.Response.Redirect(url)

        End Sub

        Public Overrides Sub btnReject_Click(ByVal sender As Object, ByVal args As EventArgs)

            'System.Web.HttpContext.Current.Session("PO_Rej") = "OK"
            If Trim(Me.WPOP_Remark.Text) = "" Then
                'Throw New Exception("Please provide the comment field for purchaser's reference.")
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(Me, "MyAlertName", "Please provide the comment field for purchaser's reference.")
                'Utils.MiscUtils.RegisterJScriptAlert(Me, "Please provide the comment field for purchaser's reference.", "Reject Error")
            End If

            'Dim coId As String = CStr(System.Web.HttpContext.Current.Session("CMPNY"))
            Dim poNum As String = CStr(System.Web.HttpContext.Current.Session("PONO"))
            Dim deyt As String = CStr(System.Web.HttpContext.Current.Session("DOCDATE"))
            Dim coDesc As String = CStr(System.Web.HttpContext.Current.Session("CMPNYDESC"))
            Dim xUser As String = System.Web.HttpContext.Current.Session("UserIDNorth").ToString()

            Dim ctlHeader As Controls.WPO_WFTaskN.Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskRecordControl"), Controls.WPO_WFTaskN.Sel_WPO_WFTaskRecordControl)

            Dim oHeader As Controls.WPO_WFTaskN.WPOP10100RecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), Controls.WPO_WFTaskN.WPOP10100RecordControl)
            Dim drop As DropDownList = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlMoveTo"), System.Web.UI.WebControls.DropDownList)

            'Me.PopulateMoveTo()
            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Dim wc3 As WhereClause = New WhereClause
            Dim sCurStep As String
            Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Item Details:" & "@D" & _
            "OrderDate: @RD" & "Comment(s): @Rem"

            Dim ctlDetails As Controls.WPO_WFTaskN.Sel_WPO_InquireDetailsTableControlRow = DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetailsTableControlRow"), Controls.WPO_WFTaskN.Sel_WPO_InquireDetailsTableControlRow)
            Dim sPODetail As String = " "
            Dim ctlWF As Controls.WPO_WFTaskN.WPOP10100RecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), Controls.WPO_WFTaskN.WPOP10100RecordControl)
            Dim wc As WhereClause = New WhereClause

            wc.iAND(Sel_WPO_InquireDetails1View.PONUMBER, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.PONUMBER.Text)
            wc.iAND(Sel_WPO_InquireDetails1View.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)

            Dim sngTotal As Single = 0

            For Each recCtl As Sel_WPO_InquireDetails1Record In Sel_WPO_InquireDetails1View.GetRecords(wc, Nothing, 0, 100)
                'sPODetail &= "PO#: " & Trim(ctlHeader.PONUMBER.Text) & vbCrLf & _
                '"Item: " & Trim(recCtl.ITEMDESC.ToString()) & "UOFM: " & recCtl.UOFM.ToString() & "Unit Cost: " & recCtl.UNITCOST.ToString() & " Qty Order: " & recCtl.QTYORDER.ToString() & _
                '" Sub Ttl: " & recCtl.EXTDCOST.ToString()
                sPODetail &= "PO#: " & Trim(ctlHeader.PONUMBER.Text) & vbCrLf & _
               "Item: " & Trim(recCtl.ITEMDESC.ToString()) & "UOFM: " & recCtl.UOFM.ToString() & " Qty Order: " & recCtl.QTYORDER.ToString() & " Unit Cost: " & recCtl.UNITCOST.ToString()

                sngTotal += CSng(recCtl.EXTDCOST.ToString())
            Next

            Dim sngRate As Single = 0
            Dim sngForex As Single = 0
            Dim sCurr As String = ""
            Get_Currency(ctlHeader.PONUMBER.Text, ctlHeader.CompanyID2.Text, sCurr, sngRate)
            If sngRate > 0 Then
                sngForex = sngTotal / sngRate
                sCurr = " (" & sCurr & " " & sngForex.ToString() & ")"
            Else
                sCurr = ""
            End If

            sEmailContent = Replace(sEmailContent, "@C", CStr(coDesc.ToString()))
            sEmailContent = Replace(sEmailContent, "@D", sPODetail)
            sEmailContent = Replace(sEmailContent, "@RD", CStr(deyt))
            sEmailContent = Replace(sEmailContent, "@Rem", "SUPPLIER: " & ctlHeader.VENDNAME.Text.Trim() & "</br>" & ctlWF.WPOP_Remark.Text)

            wc3.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
            wc3.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
            wc3.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
            'note: check to see if record is still submitted, if not then do not save
            If WPO_Activity1Table.GetRecords(wc3, Nothing, 0, 100).Length > 0 Then
                'note: get Current step to be used in wc2
                For Each itemValue3 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                    sCurStep = itemValue3.WPO_WS_ID.ToString()
                Next

                Dim wc4 As WhereClause = New WhereClause

                wc4.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                wc4.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc4.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                wc4.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                For Each itemValue4 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                    'note: update Activity table (other user(s) if multiple approvers) -> 'System Rejected'
                    WPO_Activity1Record.UpdateRecord(itemValue4.WPO_ID.ToString(), "12")
                Next
                'note: update current task status -> 'Rejected
                Dim wc5 As WhereClause = New WhereClause

                wc5.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                wc5.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc5.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                wc5.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                If WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue5 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                        'note: update Activity table (current user) -> 'Rejected'
                        WPO_Activity1Record.UpdateRecord(itemValue5.WPO_ID.ToString(), "7")
                        Update_WF_Status(CInt(ctlHeader.CompanyID2.Text), CInt("0"), poNum)     'UPDATE POP10100
                        Update_WPOP10100(CInt(ctlHeader.CompanyID2.Text), CInt("7"), poNum)     'UPDATE WPOP10100

                    Next
                End If

                'note: insert user(s) to Activity using the chosen Return To field
                Dim wc6 As WhereClause = New WhereClause
                Dim Remarks As String = oHeader.WPOP_Remark.Text

                If drop.SelectedValue.ToString() <> "0" Then 'not the creator
                    wc6.iAND(WPO_Step_WPO_StepDetail1View.WPO_S_ID, BaseFilter.ComparisonOperator.EqualsTo, drop.SelectedValue.ToString())

                    For Each itemValue6 As WPO_Step_WPO_StepDetail1Record In WPO_Step_WPO_StepDetail1View.GetRecords(wc6, Nothing, 0, 100)
                        'note: use returned items to insert to Activity table
                        'note: do not insert(update) delegate until task expires
                        WPO_Activity1Record.AddRecord(itemValue6.WPO_S_ID.ToString(), itemValue6.WPO_SD_ID.ToString(), _
                            Me.WPOP_DT_ID1.SelectedValue.ToString(), _
                            itemValue6.WPO_SD_W_U_ID.ToString(), "0", _
                            poNum.ToString(), _
                            DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                            ": " & Remarks.ToString)

                        '##################
                        '### EMAIL HERE ###
                        '##################
                        'email to Returned user
                        Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                        sEmailContent = Content_Formatter(itemValue6.WPO_SD_W_U_ID.ToString(), _
                        "PO Information Needed (PO# " & poNum.Trim() & ")", CStr(coDesc.ToString()), _
                        sPODetail, CStr(deyt), "SUPPLIER: " & ctlHeader.VENDNAME.Text.Trim() & "<br>" & ctlWF.WPOP_Remark.Text, sngTotal.ToString("#,#.00") & sCurr, _
                        System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#f46f6f", "Security/Homepage.aspx", poNum.Trim(), _
                        "Rejected By " & sUserRej, "", "PO")

                        Send_Email_Notification(itemValue6.WPO_SD_W_U_ID.ToString(), "PO Information Needed (PO# " & _
                        poNum.Trim() & ")", sEmailContent)
                        'avgrado 5/30/16
                        ' ''Send_Email_Notification("24", "PO Information Needed (PO# " & _
                        ' ''poNum.Trim() & ")", sEmailContent)

                        'Send_Email_Notification(itemValue6.WPO_SD_W_U_ID.ToString(), "PO Approval Needed (PO# " & _
                        'poNum.ToString & ")", "Returned By " & sUserRej & vbCrLf & vbCrLf & sEmailContent & _
                        'vbCrLf & vbCrLf & "Remark(s):" & vbCrLf & Remarks.ToString)
                    Next
                Else

                    'note: if the 1st step rejected the task and the task has nowhere to go -> set the document's
                    'submitted status to 'False' and set Doc Status to 'For Review' this enables the user(Creator)
                    'to submit the Document again.
                    wc6.iAND(WPOP101001Table.WPOP_PONMBR, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                    'wc6.iAND(WPOP101001Table.WPOP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)
                    For Each itemValue6 As WPOP101001Record In WPOP101001Table.GetRecords(wc6, Nothing, 0, 100)


                        Update_WF_Status_Submit(ctlHeader.CompanyID2.Text, "7", "0", poNum, _
                        DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                        ": " & Me.WPOP_Remark.Text) '' Use this to update the WPOP10100
                        Update_WF_Status(CInt(ctlHeader.CompanyID2.Text), CInt("0"), poNum)                      '' Use this to update the POP10100


                        '##################
                        '### EMAIL HERE ###
                        '##################
                        Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                        sEmailContent = Content_Formatter(itemValue6.WPOP_U_ID.ToString(), _
                        "PO Information Needed (PO# " & poNum.Trim() & ")", CStr(coDesc.ToString()), _
                        sPODetail, CStr(deyt), "SUPPLIER: " & ctlHeader.VENDNAME.Text.Trim() & "<br>" & ctlWF.WPOP_Remark.Text, sngTotal.ToString("#,#.00") & sCurr, _
                        System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#f46f6f", "Security/Homepage.aspx", poNum.Trim(), _
                        "Rejected By " & sUserRej, "", "PO")

                        Send_Email_Notification(itemValue6.WPOP_U_ID.ToString(), "PO Information Needed (PO# " & _
                        poNum.Trim() & ")", sEmailContent)
                        'avgrado 5/30/16
                        ' ''Send_Email_Notification("24", "PO Information Needed (PO# " & _
                        ' ''poNum.Trim() & ")", sEmailContent)
                    Next
                End If

            End If

        Dim url As String = "../Security/Homepage.aspx"
            url = Me.ModifyRedirectUrl(url, "", False)
            url = Me.Page.ModifyRedirectUrl(url, "", False)
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.Response.Redirect(url)

        End Sub

        Public Overrides Sub btnReturn_Click(ByVal sender As Object, ByVal args As EventArgs)
            Dim poNum As String = CStr(System.Web.HttpContext.Current.Session("PONO"))
            Dim deyt As String = CStr(System.Web.HttpContext.Current.Session("DOCDATE"))
            Dim coDesc As String = CStr(System.Web.HttpContext.Current.Session("CMPNYDESC"))
            Dim xUser As String = System.Web.HttpContext.Current.Session("UserIDNorth").ToString()

            Dim ctlHeader As Controls.WPO_WFTaskN.Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskRecordControl"), Controls.WPO_WFTaskN.Sel_WPO_WFTaskRecordControl)
            Dim oHeader As Controls.WPO_WFTaskN.WPOP10100RecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), Controls.WPO_WFTaskN.WPOP10100RecordControl)
            Dim drop As DropDownList = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlMoveTo"), System.Web.UI.WebControls.DropDownList)

            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            Dim wc3 As WhereClause = New WhereClause
            Dim sCurStep As String
            Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Item Details:" & "@D" & _
            "OrderDate: @RD" & "Comment(s): @Rem"

            Dim ctlDetails As Controls.WPO_WFTaskN.Sel_WPO_InquireDetailsTableControlRow = DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetailsTableControlRow"), Controls.WPO_WFTaskN.Sel_WPO_InquireDetailsTableControlRow)
            Dim sPODetail As String = " "
            Dim ctlWF As Controls.WPO_WFTaskN.WPOP10100RecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), Controls.WPO_WFTaskN.WPOP10100RecordControl)
            Dim wc As WhereClause = New WhereClause

            wc.iAND(Sel_WPO_InquireDetails1View.PONUMBER, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.PONUMBER.Text)
            wc.iAND(Sel_WPO_InquireDetails1View.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)

            Dim sngTotal As Single = 0

            For Each recCtl As Sel_WPO_InquireDetails1Record In Sel_WPO_InquireDetails1View.GetRecords(wc, Nothing, 0, 100)
                sPODetail &= "PO#: " & Trim(ctlHeader.PONUMBER.Text) & vbCrLf & _
               "Item: " & Trim(recCtl.ITEMDESC.ToString()) & "UOFM: " & recCtl.UOFM.ToString() & " Qty Order: " & recCtl.QTYORDER.ToString() & " Unit Cost: " & recCtl.UNITCOST.ToString()

                sngTotal += CSng(recCtl.EXTDCOST.ToString())
            Next

            Dim sngRate As Single = 0
            Dim sngForex As Single = 0
            Dim sCurr As String = ""
            Get_Currency(ctlHeader.PONUMBER.Text, ctlHeader.CompanyID2.Text, sCurr, sngRate)
            If sngRate > 0 Then
                sngForex = sngTotal / sngRate
                sCurr = " (" & sCurr & " " & sngForex.ToString() & ")"
            Else
                sCurr = ""
            End If

            sEmailContent = Replace(sEmailContent, "@C", CStr(coDesc.ToString()))
            sEmailContent = Replace(sEmailContent, "@D", sPODetail)
            sEmailContent = Replace(sEmailContent, "@RD", CStr(deyt))
            sEmailContent = Replace(sEmailContent, "@Rem", "SUPPLIER: " & ctlHeader.VENDNAME.Text.Trim() & "</br>" & ctlWF.WPOP_Remark.Text)

            wc3.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
            wc3.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
            wc3.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
            'note: check to see if record is still submitted, if not then do not save
            If WPO_Activity1Table.GetRecords(wc3, Nothing, 0, 100).Length > 0 Then
                'note: get Current step to be used in wc2
                For Each itemValue3 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc3, Nothing, 0, 100)
                    sCurStep = itemValue3.WPO_WS_ID.ToString()
                Next

                Dim wc4 As WhereClause = New WhereClause

                wc4.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                wc4.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.Not_Equals, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc4.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                wc4.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                For Each itemValue4 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                    'note: update Activity table (other user(s) if multiple approvers) -> 'System Rejected'
                    WPO_Activity1Record.UpdateRecord(itemValue4.WPO_ID.ToString(), "13") 'orig:12(System Rejected)
                Next
                'note: update current task status -> 'Rejected
                Dim wc5 As WhereClause = New WhereClause

                wc5.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                wc5.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
                wc5.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4") 'NOTE:Change WFApprovalStatus from 4 to 9
                wc5.iAND(WPO_Activity1Table.WPO_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)

                If WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue5 As WPO_Activity1Record In WPO_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                        'note: update Activity table (current user) -> 'Rejected'
                        WPO_Activity1Record.UpdateRecord(itemValue5.WPO_ID.ToString(), "13")
                        Update_WF_Status(CInt(ctlHeader.CompanyID2.Text), CInt("13"), poNum) '0(orig)     'UPDATE POP10100
                        Update_WPOP10100(CInt(ctlHeader.CompanyID2.Text), CInt("13"), poNum) '7(orig)     'UPDATE WPOP10100

                    Next
                End If

                'note: insert user(s) to Activity using the chosen Return To field
                Dim wc6 As WhereClause = New WhereClause
                Dim Remarks As String = oHeader.WPOP_Remark.Text

                wc6.iAND(WPOP101001Table.WPOP_PONMBR, BaseFilter.ComparisonOperator.EqualsTo, poNum)
                wc6.iAND(WPOP101001Table.WPOP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)
                For Each itemValue6 As WPOP101001Record In WPOP101001Table.GetRecords(wc6, Nothing, 0, 100)
                    Update_WF_Status_Submit(ctlHeader.CompanyID2.Text, "13", "0", poNum, _
                    DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & _
                    ": " & Me.WPOP_Remark.Text) '' Use this to update the WPOP10100
                    Update_WF_Status(CInt(ctlHeader.CompanyID2.Text), CInt("13"), poNum)                      '' Use this to update the POP10100
                    'Update_WPOP10100(CInt(coId), CInt("7"), poNum)
                    '##################
                    '### EMAIL HERE ###
                    '##################
                    Dim sUserRej As String = System.Web.HttpContext.Current.Session("UserFullName").ToString()

                    sEmailContent = Content_Formatter(itemValue6.WPOP_U_ID.ToString(), _
                    "PO Information Needed (PO# " & poNum.Trim() & ")", CStr(coDesc.ToString()), _
                    sPODetail, CStr(deyt), "SUPPLIER: " & ctlHeader.VENDNAME.Text.Trim() & "<br>" & ctlWF.WPOP_Remark.Text, sngTotal.ToString("#,#.00") & sCurr, _
                    System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#f46f6f", "wf_po/ShowSel_WPO_Activity_WPOP10100Table.aspx", poNum.Trim(), _
                    "Returned By " & sUserRej, "", "PO")

                    Send_Email_Notification(itemValue6.WPOP_U_ID.ToString(), "PO Information Needed (PO# " & _
                    poNum.Trim() & ")", sEmailContent)
                    'avgrado 5/30/2016
                    Send_Email_Notification("24", "PO Information Needed (PO# " & _
                    poNum.Trim() & ")", sEmailContent)
                Next
            End If

            ' ''Select Case System.Web.HttpContext.Current.Session("UserIDNorth").ToString
            ' ''    Case "8", "274", "34"
            ' ''        Dim url As String = "../wf_PO/ShowSel_WPO_Activity_WPOP10100Table.aspx"
            ' ''        url = Me.ModifyRedirectUrl(url, "", False)
            ' ''        url = Me.Page.ModifyRedirectUrl(url, "", False)
            ' ''        Me.Page.ShouldSaveControlsToSession = True
            ' ''        Me.Page.Response.Redirect(url)
            ' ''    Case Else
            ' ''        Dim url As String = "../Security/HomePage.aspx"
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
        End Sub

        Private Sub PopulateMoveTo()

            'Dim coId As String = CStr(System.Web.HttpContext.Current.Session("CMPNY"))
            Dim poNum As String = CStr(System.Web.HttpContext.Current.Session("PONO"))
            Dim deyt As String = CStr(System.Web.HttpContext.Current.Session("DOCDATE"))
            Dim coDesc As String = CStr(System.Web.HttpContext.Current.Session("CMPNYDESC"))
            Dim xUser As String = System.Web.HttpContext.Current.Session("UserIDNorth").ToString()



            Dim oHeader As WPO_WFTaskN.WPOP10100RecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), WPO_WFTaskN.WPOP10100RecordControl)
            Dim drop As DropDownList = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlMoveTo"), System.Web.UI.WebControls.DropDownList)

            drop.Enabled = True
            drop.Items.Clear()
            'note: this populates the Return To drop down
            Dim wc1 As WhereClause = New WhereClause

            wc1.iAND(WPO_Activity1Table.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, poNum)
            wc1.iAND(WPO_Activity1Table.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, System.Web.HttpContext.Current.Session("UserIDNorth").ToString())
            wc1.iAND(WPO_Activity1Table.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")
            Dim sWhere As String = WPO_Activity1Table.WPO_PONum.UniqueName & "='" & poNum & "' And " & WPO_Activity1Table.WPO_W_U_ID.UniqueName & _
            " = '" & System.Web.HttpContext.Current.Session("UserIDNorth").ToString() & "' And " & WPO_Activity1Table.WPO_Status.UniqueName & " = 4"

            Dim itemValue1 As WPO_Activity1Record
            Dim bNoParent As Boolean = False
            Dim sStepID As String = ""
            Dim sStepType As String = ""
            For Each itemValue1 In WPO_Activity1Table.GetRecords(sWhere, Nothing, 0, 100)
                If (itemValue1.WPO_WS_IDSpecified) Then
                    sStepID = itemValue1.WPO_WS_ID.ToString()

                    Do While sStepType <> "Start"
                        Dim wc2 As WhereClause = New WhereClause
                        Dim itemValue2 As WPO_Step1Record
                        wc2.iAND(WPO_Step1Table.WPO_S_ID_Next, BaseFilter.ComparisonOperator.EqualsTo, sStepID)


                        If WPO_Step1Table.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue2 In WPO_Step1Table.GetRecords(wc2, Nothing, 0, 100)
                                If itemValue2.WPO_S_IDSpecified Then
                                    Dim cvalue As String = Nothing
                                    Dim fvalue As String = Nothing

                                    cvalue = itemValue2.WPO_S_ID.ToString()
                                    fvalue = itemValue2.WPO_S_Desc.ToString()
                                    sStepID = cvalue
                                    sStepType = itemValue2.WPO_S_Step_Type

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
            fvalue1 = oHeader.WPOP_U_ID.Text '"Creator"

            Dim item1 As ListItem = New ListItem(fvalue1, cvalue1)
            drop.Items.Add(item1)

            If drop.Items.Count > 0 Then
                'note: default to first step
                drop.SelectedIndex = drop.Items.Count - 1
            End If

            'drop.Items.Clear()
            'drop.Enabled = False

            'Return

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

        Private Function FindDelegate(ByVal AssignedApprover As String, Optional ByRef Info As String = "") As String

            Dim ctlHeader As Controls.WPO_WFTaskN.Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskRecordControl"), Controls.WPO_WFTaskN.Sel_WPO_WFTaskRecordControl)

            Dim sApprover As String = AssignedApprover
            Dim sCheck As String = AssignedApprover
            Dim bNoMoreDelegate As Boolean = False
            Dim sWhereDelegate As String = ""
            Dim iCircular As Integer = 0
            Do While Not bNoMoreDelegate
                sWhereDelegate = WTask_Delegation1Table.WTD_W_U_ID.UniqueName & " = '" & sApprover & _
                "' And " & WTask_Delegation1Table.WTD_WDT_Type.UniqueName & " = 'PO' And " & _
                WTask_Delegation1Table.WTD_From.UniqueName & " <= '" & Now.ToShortDateString() & _
                "' And " & WTask_Delegation1Table.WTD_To.UniqueName & " >= '" & Now.ToShortDateString() & "'" & _
                " And " & WTask_Delegation1Table.WTD_C_ID.UniqueName & " = " & ctlHeader.CompanyID2.Text

                sCheck = ""
                For Each oDelegate As WTask_Delegation1Record In WTask_Delegation1Table.GetRecords(sWhereDelegate, Nothing, 0, 5)
                    sApprover = oDelegate.WTD_W_U_ID_Delegate.ToString()
                    sCheck = oDelegate.WTD_W_U_ID_Delegate.ToString()
                Next

                If sCheck = "" Then bNoMoreDelegate = True
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

        Private Function Update_WF_HOLD(ByVal Company As Integer, ByVal Hold As Integer, ByVal PO As String) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("Hold", Hold, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@PO", PO, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)


            Dim parameterList(2) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "upd_WPO_WF_HOLD", parameterList)

            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function

        Private Function Update_WF_Status(ByVal Company As Integer, ByVal Status As Integer, ByVal PO As String) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@PO", PO, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)


            Dim parameterList(2) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "upd_WPO_WF_Status", parameterList)

            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function

        Private Function Update_WF_Status_Submit(ByVal Company As String, ByVal Status As String, ByVal Submit As String, ByVal PO As String, ByVal Remarks As String) As String

            '' USE THIS TO UPDATE THE WPOP10100

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@PO", PO, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)

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

            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "upd_WPO_WF_Status_Submit", parameterList)

            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return "ERR"
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function

        Private Function Update_WPOP10100(ByVal Company As Integer, ByVal Status As Integer, ByVal PO As String) As String

            Dim firstParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            firstParameter = New BaseClasses.Data.StoredProcedureParameter("@Company", Company, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim secondParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            secondParameter = New BaseClasses.Data.StoredProcedureParameter("@Status", Status, System.Data.SqlDbType.SmallInt, System.Data.ParameterDirection.Input)

            Dim thirdParameter As BaseClasses.Data.StoredProcedureParameter = Nothing
            thirdParameter = New BaseClasses.Data.StoredProcedureParameter("@PO", PO, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input)


            Dim parameterList(2) As BaseClasses.Data.StoredProcedureParameter
            parameterList(0) = firstParameter
            parameterList(1) = secondParameter
            parameterList(2) = thirdParameter

            Dim myStoredProcedure As BaseClasses.Data.StoredProcedure = Nothing

            myStoredProcedure = New BaseClasses.Data.StoredProcedure("DatabaseANFLO-WFN", "upd_WPOP10100", parameterList)

            If (myStoredProcedure.RunNonQuery()) Then

                Return "OK"
            Else
                Return myStoredProcedure.ErrorMessage
                ' myStoredProcedure.ErrorMessage to get the text of the error message and use RegisterJScriptAlert to report this to the user.
            End If
        End Function
    End Class
    Public Class WPO_WFHistory_Details_newTableControl
        Inherits BaseWPO_WFHistory_Details_newTableControl

        ' The BaseWPO_WFHistory_Details_newTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WPO_WFHistory_Details_newTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            WPO_WFHistory_Details_new1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim ctlHead As Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_WFTaskRecordControl"), Sel_WPO_WFTaskRecordControl)

            wc.iAND(WPO_WFHistory_Details_new1View.WPO_PONum, BaseFilter.ComparisonOperator.EqualsTo, ctlHead.PONUMBER.Text)
            wc.iAND(WPO_WFHistory_Details_new1View.WPOP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, ctlHead.CompanyID2.Text)


            Return wc
        End Function
    End Class
    Public Class WPO_WFHistory_Details_newTableControlRow
        Inherits BaseWPO_WFHistory_Details_newTableControlRow
        ' The BaseWPO_WFHistory_Details_newTableControlRow implements code for a ROW within the
        ' the WPO_WFHistory_Details_newTableControl table.  The BaseWPO_WFHistory_Details_newTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WPO_WFHistory_Details_newTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


    End Class
    Public Class WPO_PRNo_QDetailsTableControl
        Inherits BaseWPO_PRNo_QDetailsTableControl

        ' The BaseWPO_PRNo_QDetailsTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WPO_PRNo_QDetailsTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            WPO_PRNo_QDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()


            Dim ctlHeader As Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_WFTaskRecordControl"), Sel_WPO_WFTaskRecordControl)
            'Dim sPOP1 As String = WPOP101001Table.WPOP_PONMBR.UniqueName & " = '" & ctlHeader.PONUMBER.Text & "'"
            'Dim sCoID As String = ""
            'For Each oPOP1 As WPOP10100Record In WPOP101001Table.GetRecords(sPOP1, Nothing, 0, 100)
            '    sCoID = oPOP1.WPOP_C_ID.ToString()
            'Next

            wc.iAND(WPO_PRNo_QDetails1View.PONo, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.PONUMBER.Text)
            wc.iAND(WPO_PRNo_QDetails1View.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)


            Return wc
        End Function
    End Class
    Public Class WPO_PRNo_QDetailsTableControlRow
        Inherits BaseWPO_PRNo_QDetailsTableControlRow
        ' The BaseWPO_PRNo_QDetailsTableControlRow implements code for a ROW within the
        ' the WPO_PRNo_QDetailsTableControl table.  The BaseWPO_PRNo_QDetailsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WPO_PRNo_QDetailsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


    
		Public Overrides Sub ImageButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
                DbUtils.StartTransaction
              
                  Dim url As String = "../WPR_Doc/Show-WPR-Doc1.aspx?WPR_Doc1=" & Me.WPRD_ID.Text 'Me.GetRecords.WPRD_ID.ToString
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                
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
End Class
    Public Class WPO_Doc_AttachTableControl
        Inherits BaseWPO_Doc_AttachTableControl

        ' The BaseWPO_Doc_AttachTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WPO_Doc_AttachTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            WPO_Doc_Attach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()


            Dim ctlHeader As Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_WFTaskRecordControl"), Sel_WPO_WFTaskRecordControl)

            wc.iAND(WPO_Doc_Attach1Table.WPODA_PONo, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.PONUMBER.Text)
            wc.iAND(WPO_Doc_Attach1Table.WPODA_CMPNY, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)


            Return wc
        End Function
    End Class
    Public Class WPO_Doc_AttachTableControlRow
        Inherits BaseWPO_Doc_AttachTableControlRow
        ' The BaseWPO_Doc_AttachTableControlRow implements code for a ROW within the
        ' the WPO_Doc_AttachTableControl table.  The BaseWPO_Doc_AttachTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WPO_Doc_AttachTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


    End Class
    Public Class WPO_CARNo_QDetailsTableControl
        Inherits BaseWPO_CARNo_QDetailsTableControl

        ' The BaseWPO_CARNo_QDetailsTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WPO_CARNo_QDetailsTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            WPO_CARNo_QDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()


            Dim ctlDetail As Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_WFTaskRecordControl"), Sel_WPO_WFTaskRecordControl)
            'Dim sPOP1 As String = WPOP101001Table.WPOP_PONMBR.UniqueName & " = '" & ctlDetail.PONUMBER.Text & "'"
            'Dim sCoID As String = ""
            'For Each oPOP1 As WPOP10100Record In WPOP101001Table.GetRecords(sPOP1, Nothing, 0, 100)
            '    sCoID = oPOP1.WPOP_C_ID.ToString()
            'Next

            wc.iAND(WPO_CARNo_QDetails1View.PONum, BaseFilter.ComparisonOperator.EqualsTo, ctlDetail.PONUMBER.Text)
            wc.iAND(WPO_CARNo_QDetails1View.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, ctlDetail.CompanyID2.Text)


            Return wc
        End Function
    End Class
    Public Class WPO_CARNo_QDetailsTableControlRow
        Inherits BaseWPO_CARNo_QDetailsTableControlRow
        ' The BaseWPO_CARNo_QDetailsTableControlRow implements code for a ROW within the
        ' the WPO_CARNo_QDetailsTableControl table.  The BaseWPO_CARNo_QDetailsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WPO_CARNo_QDetailsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.

        Public Overrides Sub DataBind()
            MyBase.DataBind()

            If Me.DataSource Is Nothing Then
                Return
            End If

            If Me.DataSource.WCD_ID.ToString = "0" Then
                Me.ImageButton1.Visible = False
            Else
                Me.ImageButton1.Visible = True
            End If

        End Sub

		

    End Class
    Public Class View_WCPO_Canvass1TableControl
        Inherits BaseView_WCPO_Canvass1TableControl

        ' The BaseView_WCPO_Canvass1TableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The View_WCPO_Canvass1TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            View_WCPO_Canvass11View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()


            Dim ctlHeader As Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_WFTaskRecordControl"), Sel_WPO_WFTaskRecordControl)

            wc.iAND(View_WCPO_Canvass11View.PONo, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.PONUMBER.Text)
            wc.iAND(View_WCPO_Canvass11View.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)



            Return wc
        End Function
    End Class
    Public Class View_WCPO_Canvass1TableControlRow
        Inherits BaseView_WCPO_Canvass1TableControlRow
        ' The BaseView_WCPO_Canvass1TableControlRow implements code for a ROW within the
        ' the View_WCPO_Canvass1TableControl table.  The BaseView_WCPO_Canvass1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of View_WCPO_Canvass1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.

		

    
		Public Overrides Sub ImageButton2_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
                DbUtils.StartTransaction
            
              
                  Dim url As String = "../WCanvass_Internal/Show-WCanvass-Internal1.aspx?WCanvass_Internal1=" & Me.WCI_ID.Text '}"
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                
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
End Class
    Public Class Sel_WPO_InquireDetailsTableControl
        Inherits BaseSel_WPO_InquireDetailsTableControl

        ' The BaseSel_WPO_InquireDetailsTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The Sel_WPO_InquireDetailsTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            Sel_WPO_InquireDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()


            Dim ctlHeader As Sel_WPO_WFTaskRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_WFTaskRecordControl"), Sel_WPO_WFTaskRecordControl)
            'Dim sPOP1 As String = WPOP101001Table.WPOP_PONMBR.UniqueName & " = '" & ctlHeader.PONUMBER.Text & "'"
            'Dim sCoID As String = ""
            'For Each oPOP1 As WPOP10100Record In WPOP101001Table.GetRecords(sPOP1, Nothing, 0, 100)
            '    sCoID = oPOP1.WPOP_C_ID.ToString()
            'Next

            wc.iAND(Sel_WPO_InquireDetails1View.PONUMBER, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.PONUMBER.Text)
            wc.iAND(Sel_WPO_InquireDetails1View.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.CompanyID2.Text)


            Return wc
        End Function
    End Class
Public Class Sel_WPO_InquireDetailsTableControlRow
        Inherits BaseSel_WPO_InquireDetailsTableControlRow
        ' The BaseSel_WPO_InquireDetailsTableControlRow implements code for a ROW within the
        ' the Sel_WPO_InquireDetailsTableControl table.  The BaseSel_WPO_InquireDetailsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Sel_WPO_InquireDetailsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.

        Public Overrides Sub DataBind()

            MyBase.DataBind()
            Me.iComment.Attributes.Add("onclick", "window.open('../sel_WPO_WFTask/WPO-Comment1.aspx?ord1=" & Me.ORD.Text & "&po1=" & Me.PONUMBER1.Text & "&com1=" & Me.CompanyID1.Text & "', '', 'menubar=no,width=640,height=240,top=(screen.height  - 240)/2,left=(screen.width  - 640)/2');return false;")
        End Sub


End Class
Public Class Sel_WPO_InquireDetails1TableControl1
        Inherits BaseSel_WPO_InquireDetails1TableControl1

    ' The BaseSel_WPO_InquireDetails1TableControl1 class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Sel_WPO_InquireDetails1TableControl1Row class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

        Private Sub Sel_WPO_InquireDetails1TableControl1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
            Dim inqDetHeader As Sel_WPO_InquireDetailsTableControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_InquireDetailsTableControl"), Sel_WPO_InquireDetailsTableControl)

            Select Case System.Web.HttpContext.Current.Session("UserIDNorth").ToString
                Case "1", "34", "8"
                    'inqDetHeader.FindControl("selInqDet2Header").Visible = True
                    'For Each row As Sel_WPO_InquireDetails_2TableControlRow In GetRecordControls()
                    '    row.FindControl("selInqDet2Cell").Visible = True
                    'Next

                    Dim repeatedRows() As Sel_WPO_InquireDetailsTableControlRow = inqDetHeader.GetRecordControls()
                    For Each repeatedRow As Sel_WPO_InquireDetailsTableControlRow In repeatedRows
                        Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "selInqDet2Cell"), System.Web.UI.Control)
                        If (altRow IsNot Nothing) Then
                            altRow.Visible = True
                            Me.Visible = True
                        End If
                    Next
                Case Else
                    inqDetHeader.FindControl("selInqDet2Header").Visible = False
                    'For Each row As Sel_WPO_InquireDetails_2TableControlRow In GetRecordControls()
                    '    row.FindControl("selInqDet2Cell").Visible = False
                    'Next
                    Dim repeatedRows() As Sel_WPO_InquireDetailsTableControlRow = inqDetHeader.GetRecordControls()
                    For Each repeatedRow As Sel_WPO_InquireDetailsTableControlRow In repeatedRows
                        Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "selInqDet2Cell"), System.Web.UI.Control)
                        If (altRow IsNot Nothing) Then
                            altRow.Visible = False
                            Me.Visible = False
                        End If
                    Next
            End Select
        End Sub

        Protected Overrides Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                Me.CurrentSortOrder.Add(Sel_WPO_InquireDetails1View.DOCDATE, BaseClasses.Data.OrderByItem.OrderDir.Desc)
            End If

            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "3"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))

            Me.ClearControlsFromSession()
        End Sub

        Public Overrides Function CreateWhereClause() As WhereClause
            Sel_WPO_InquireDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            Dim ctlHeader As Sel_WPO_InquireDetailsTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WPO_InquireDetailsTableControlRow"), Sel_WPO_InquireDetailsTableControlRow)

            wc.iAND(Sel_WPO_InquireDetails1View.ITEMNMBR, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.GetRecord().ITEMNMBR.ToString)
            wc.iAND(Sel_WPO_InquireDetails1View.PONUMBER, BaseFilter.ComparisonOperator.Not_Equals, ctlHeader.GetRecord().PONUMBER.ToString)
            wc.iAND(Sel_WPO_InquireDetails1View.CompanyID, BaseFilter.ComparisonOperator.EqualsTo, ctlHeader.GetRecord().CompanyID.ToString)

            Return wc
        End Function

End Class
Public Class Sel_WPO_InquireDetails1TableControl1Row
        Inherits BaseSel_WPO_InquireDetails1TableControl1Row
        ' The BaseSel_WPO_InquireDetails1TableControl1Row implements code for a ROW within the
        ' the Sel_WPO_InquireDetails1TableControl1 table.  The BaseSel_WPO_InquireDetails1TableControl1Row implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Sel_WPO_InquireDetails1TableControl1.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class
#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Sel_WPO_InquireDetails1TableControl1Row control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in Sel_WPO_InquireDetails1TableControl1Row.
Public Class BaseSel_WPO_InquireDetails1TableControl1Row
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_WPO_InquireDetails1TableControl1Row.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in Sel_WPO_InquireDetails1TableControl1Row.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Sel_WPO_InquireDetails1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSel_WPO_InquireDetails1TableControl1 when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Sel_WPO_InquireDetails1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_WPO_InquireDetails1TableControl1Row.
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
        
                SetLiteral10()
                SetLiteral11()
                SetLiteral9()
                SetPONUMBER2()
                SetUNITCOST1()
                SetVENDNAME1()
      
      
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
        
        
        Public Overridable Sub SetPONUMBER2()

                  
            
        
            ' Set the PONUMBER Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.PONUMBER2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPONUMBER2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PONUMBERSpecified Then
                				
                ' If the PONUMBER is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.PONUMBER)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PONUMBER2.Text = formattedValue
                
            Else 
            
                ' PONUMBER is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.PONUMBER2.Text = Sel_WPO_InquireDetails1View.PONUMBER.Format(Sel_WPO_InquireDetails1View.PONUMBER.DefaultValue)
                        		
                End If
                 
            ' If the PONUMBER is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PONUMBER2.Text Is Nothing _
                OrElse Me.PONUMBER2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PONUMBER2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetUNITCOST1()

                  
            
        
            ' Set the UNITCOST Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.UNITCOST1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUNITCOST1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UNITCOSTSpecified Then
                				
                ' If the UNITCOST is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.UNITCOST, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UNITCOST1.Text = formattedValue
                
            Else 
            
                ' UNITCOST is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.UNITCOST1.Text = Sel_WPO_InquireDetails1View.UNITCOST.Format(Sel_WPO_InquireDetails1View.UNITCOST.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the UNITCOST is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UNITCOST1.Text Is Nothing _
                OrElse Me.UNITCOST1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UNITCOST1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetVENDNAME1()

                  
            
        
            ' Set the VENDNAME Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.VENDNAME1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetVENDNAME1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.VENDNAMESpecified Then
                				
                ' If the VENDNAME is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.VENDNAME)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.VENDNAME1.Text = formattedValue
                
            Else 
            
                ' VENDNAME is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.VENDNAME1.Text = Sel_WPO_InquireDetails1View.VENDNAME.Format(Sel_WPO_InquireDetails1View.VENDNAME.DefaultValue)
                        		
                End If
                 
            ' If the VENDNAME is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.VENDNAME1.Text Is Nothing _
                OrElse Me.VENDNAME1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.VENDNAME1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetLiteral10()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal10.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral11()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal11.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral9()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal9.Text = "Some value"
                    
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

      
        
        ' To customize, override this method in Sel_WPO_InquireDetails1TableControl1Row.
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
              
                DirectCast(GetParentControlObject(Me, "Sel_WPO_InquireDetails1TableControl1"), Sel_WPO_InquireDetails1TableControl1).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Sel_WPO_InquireDetails1TableControl1"), Sel_WPO_InquireDetails1TableControl1).ResetData = True
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

        ' To customize, override this method in Sel_WPO_InquireDetails1TableControl1Row.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetPONUMBER2()
            GetUNITCOST1()
            GetVENDNAME1()
        End Sub
        
        
        Public Overridable Sub GetPONUMBER2()
            
        End Sub
                
        Public Overridable Sub GetUNITCOST1()
            
        End Sub
                
        Public Overridable Sub GetVENDNAME1()
            
        End Sub
                
      
        ' To customize, override this method in Sel_WPO_InquireDetails1TableControl1Row.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in Sel_WPO_InquireDetails1TableControl1Row.
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
          Sel_WPO_InquireDetails1View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Sel_WPO_InquireDetails1TableControl1"), Sel_WPO_InquireDetails1TableControl1).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Sel_WPO_InquireDetails1TableControl1"), Sel_WPO_InquireDetails1TableControl1).ResetData = True
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
                Return CType(Me.ViewState("BaseSel_WPO_InquireDetails1TableControl1Row_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSel_WPO_InquireDetails1TableControl1Row_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As Sel_WPO_InquireDetails1Record
            Get
                Return DirectCast(MyBase._DataSource, Sel_WPO_InquireDetails1Record)
            End Get
            Set(ByVal value As Sel_WPO_InquireDetails1Record)
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
        
        Public ReadOnly Property Literal10() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal10"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal11() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal11"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal9() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal9"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property PONUMBER2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PONUMBER2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property UNITCOST1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UNITCOST1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property VENDNAME1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "VENDNAME1"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As Sel_WPO_InquireDetails1Record = Nothing
             
        
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
            
            Dim rec As Sel_WPO_InquireDetails1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Sel_WPO_InquireDetails1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Sel_WPO_InquireDetails1View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Sel_WPO_InquireDetails1TableControl1 control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in Sel_WPO_InquireDetails1TableControl1.
Public Class BaseSel_WPO_InquireDetails1TableControl1
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
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "30"))
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_WPO_InquireDetails1Record)), Sel_WPO_InquireDetails1Record())
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
                    For Each rc As Sel_WPO_InquireDetails1TableControl1Row In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_WPO_InquireDetails1Record)), Sel_WPO_InquireDetails1Record())
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
            ByVal pageSize As Integer) As Sel_WPO_InquireDetails1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column1, True)         
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column2, True)          
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return Sel_WPO_InquireDetails1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New Sel_WPO_InquireDetails1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Sel_WPO_InquireDetails1Record)), Sel_WPO_InquireDetails1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column1, True)         
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column2, True)          
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return Sel_WPO_InquireDetails1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Sel_WPO_InquireDetails1View
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetails1TableControl1Repeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As Sel_WPO_InquireDetails1TableControl1Row = DirectCast(repItem.FindControl("Sel_WPO_InquireDetails1TableControl1Row"), Sel_WPO_InquireDetails1TableControl1Row)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
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
        

            ' Bind the buttons for Sel_WPO_InquireDetails1TableControl1 pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Sel_WPO_InquireDetails1TableControl1Row
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
            Sel_WPO_InquireDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Sel_WPO_InquireDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
        
          Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
        
          Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
        
          Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
        
          Dim hasFiltersWPOP10100RecordControl As Boolean = False
        
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetails1TableControl1Repeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As Sel_WPO_InquireDetails1TableControl1Row = DirectCast(repItem.FindControl("Sel_WPO_InquireDetails1TableControl1Row"), Sel_WPO_InquireDetails1TableControl1Row)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_WPO_InquireDetails1Record = New Sel_WPO_InquireDetails1Record()
        
                        If recControl.PONUMBER2.Text <> "" Then
                            rec.Parse(recControl.PONUMBER2.Text, Sel_WPO_InquireDetails1View.PONUMBER)
                        End If
                        If recControl.UNITCOST1.Text <> "" Then
                            rec.Parse(recControl.UNITCOST1.Text, Sel_WPO_InquireDetails1View.UNITCOST)
                        End If
                        If recControl.VENDNAME1.Text <> "" Then
                            rec.Parse(recControl.VENDNAME1.Text, Sel_WPO_InquireDetails1View.VENDNAME)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New Sel_WPO_InquireDetails1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Sel_WPO_InquireDetails1Record)), Sel_WPO_InquireDetails1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Sel_WPO_InquireDetails1TableControl1Row)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Sel_WPO_InquireDetails1TableControl1Row) As Boolean
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

            Dim orderByStr As String = CType(ViewState("Sel_WPO_InquireDetails1TableControl1_OrderBy"), String)
          
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
                Me.ViewState("Sel_WPO_InquireDetails1TableControl1_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = Sel_WPO_InquireDetails1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As Sel_WPO_InquireDetails1Record ()
            Get
                Return DirectCast(MyBase._DataSource, Sel_WPO_InquireDetails1Record())
            End Get
            Set(ByVal value() As Sel_WPO_InquireDetails1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
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
                Dim recCtl As Sel_WPO_InquireDetails1TableControl1Row = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Sel_WPO_InquireDetails1Record = Nothing     
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
                Dim recCtl As Sel_WPO_InquireDetails1TableControl1Row = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Sel_WPO_InquireDetails1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As Sel_WPO_InquireDetails1TableControl1Row
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Sel_WPO_InquireDetails1TableControl1Row()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Sel_WPO_InquireDetails1TableControl1Row)), Sel_WPO_InquireDetails1TableControl1Row())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Sel_WPO_InquireDetails1TableControl1Row = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As Sel_WPO_InquireDetails1TableControl1Row
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

        Public Overridable Function GetRecordControls() As Sel_WPO_InquireDetails1TableControl1Row()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Sel_WPO_InquireDetails1TableControl1Row")
            Dim list As New List(Of Sel_WPO_InquireDetails1TableControl1Row)
            For Each recCtrl As Sel_WPO_InquireDetails1TableControl1Row In recCtrls
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

  
' Base class for the Sel_WPO_InquireDetailsTableControlRow control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in Sel_WPO_InquireDetailsTableControlRow.
Public Class BaseSel_WPO_InquireDetailsTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_WPO_InquireDetailsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in Sel_WPO_InquireDetailsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.iComment.Click, AddressOf iComment_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Sel_WPO_InquireDetails1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSel_WPO_InquireDetailsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Sel_WPO_InquireDetails1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_WPO_InquireDetailsTableControlRow.
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
        
                SetCOMMENT_4()
                SetCOMMENTS()
                SetCompanyID1()
                SetExtCostForex()
                SetEXTDCOST()
                
                SetITEMDESC()
                SetITEMNMBR()
                SetLineNumber()
                SetLiteral()
                SetORD()
                SetPONUMBER1()
                SetQTYORDER()
                SetREQSTDBY()
                
                SetUNITCOST()
                SetUOFM()
                SetWCur_Short()
                SetWPOFR_Rate()
                SetiComment()
              
      
      
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
            
        SetSel_WPO_InquireDetails1TableControl1()
        
        End Sub
        
        
        Public Overridable Sub SetCOMMENT_4()

                  
            
        
            ' Set the COMMENT_4 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.COMMENT_4 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCOMMENT_4()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.COMMENT_4Specified Then
                				
                ' If the COMMENT_4 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.COMMENT_4)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.COMMENT_4.Text = formattedValue
                
            Else 
            
                ' COMMENT_4 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.COMMENT_4.Text = Sel_WPO_InquireDetails1View.COMMENT_4.Format(Sel_WPO_InquireDetails1View.COMMENT_4.DefaultValue)
                        		
                End If
                 
            ' If the COMMENT_4 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.COMMENT_4.Text Is Nothing _
                OrElse Me.COMMENT_4.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.COMMENT_4.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetCOMMENTS()

                  
            
        
            ' Set the COMMENTS Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.COMMENTS is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCOMMENTS()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.COMMENTSSpecified Then
                				
                ' If the COMMENTS is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.COMMENTS)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.COMMENTS.Text = formattedValue
                
            Else 
            
                ' COMMENTS is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.COMMENTS.Text = Sel_WPO_InquireDetails1View.COMMENTS.Format(Sel_WPO_InquireDetails1View.COMMENTS.DefaultValue)
                        		
                End If
                 
            ' If the COMMENTS is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.COMMENTS.Text Is Nothing _
                OrElse Me.COMMENTS.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.COMMENTS.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetCompanyID1()

                  
            
        
            ' Set the CompanyID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.CompanyID1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCompanyID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CompanyIDSpecified Then
                				
                ' If the CompanyID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.CompanyID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CompanyID1.Text = formattedValue
                
            Else 
            
                ' CompanyID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.CompanyID1.Text = Sel_WPO_InquireDetails1View.CompanyID.Format(Sel_WPO_InquireDetails1View.CompanyID.DefaultValue)
                        		
                End If
                 
            ' If the CompanyID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CompanyID1.Text Is Nothing _
                OrElse Me.CompanyID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CompanyID1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetExtCostForex()

                  
            
        
            ' Set the ExtCostForex Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.ExtCostForex is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetExtCostForex()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ExtCostForexSpecified Then
                				
                ' If the ExtCostForex is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.ExtCostForex, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ExtCostForex.Text = formattedValue
                
            Else 
            
                ' ExtCostForex is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.ExtCostForex.Text = Sel_WPO_InquireDetails1View.ExtCostForex.Format(Sel_WPO_InquireDetails1View.ExtCostForex.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the ExtCostForex is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ExtCostForex.Text Is Nothing _
                OrElse Me.ExtCostForex.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ExtCostForex.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetEXTDCOST()

                  
            
        
            ' Set the EXTDCOST Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.EXTDCOST is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetEXTDCOST()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.EXTDCOSTSpecified Then
                				
                ' If the EXTDCOST is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.EXTDCOST, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.EXTDCOST.Text = formattedValue
                
            Else 
            
                ' EXTDCOST is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.EXTDCOST.Text = Sel_WPO_InquireDetails1View.EXTDCOST.Format(Sel_WPO_InquireDetails1View.EXTDCOST.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the EXTDCOST is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.EXTDCOST.Text Is Nothing _
                OrElse Me.EXTDCOST.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.EXTDCOST.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetITEMDESC()

                  
            
        
            ' Set the ITEMDESC Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.ITEMDESC is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetITEMDESC()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ITEMDESCSpecified Then
                				
                ' If the ITEMDESC is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.ITEMDESC)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ITEMDESC.Text = formattedValue
                
            Else 
            
                ' ITEMDESC is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.ITEMDESC.Text = Sel_WPO_InquireDetails1View.ITEMDESC.Format(Sel_WPO_InquireDetails1View.ITEMDESC.DefaultValue)
                        		
                End If
                 
            ' If the ITEMDESC is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ITEMDESC.Text Is Nothing _
                OrElse Me.ITEMDESC.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ITEMDESC.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetITEMNMBR()

                  
            
        
            ' Set the ITEMNMBR Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.ITEMNMBR is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetITEMNMBR()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ITEMNMBRSpecified Then
                				
                ' If the ITEMNMBR is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.ITEMNMBR)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ITEMNMBR.Text = formattedValue
                
            Else 
            
                ' ITEMNMBR is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.ITEMNMBR.Text = Sel_WPO_InquireDetails1View.ITEMNMBR.Format(Sel_WPO_InquireDetails1View.ITEMNMBR.DefaultValue)
                        		
                End If
                 
            ' If the ITEMNMBR is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ITEMNMBR.Text Is Nothing _
                OrElse Me.ITEMNMBR.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ITEMNMBR.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetLineNumber()

                  
            
        
            ' Set the LineNumber Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.LineNumber is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetLineNumber()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.LineNumberSpecified Then
                				
                ' If the LineNumber is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.LineNumber)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.LineNumber.Text = formattedValue
                
            Else 
            
                ' LineNumber is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.LineNumber.Text = Sel_WPO_InquireDetails1View.LineNumber.Format(Sel_WPO_InquireDetails1View.LineNumber.DefaultValue)
                        		
                End If
                 
            ' If the LineNumber is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.LineNumber.Text Is Nothing _
                OrElse Me.LineNumber.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.LineNumber.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetORD()

                  
            
        
            ' Set the ORD Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.ORD is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetORD()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ORDSpecified Then
                				
                ' If the ORD is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.ORD)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ORD.Text = formattedValue
                
            Else 
            
                ' ORD is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.ORD.Text = Sel_WPO_InquireDetails1View.ORD.Format(Sel_WPO_InquireDetails1View.ORD.DefaultValue)
                        		
                End If
                 
            ' If the ORD is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ORD.Text Is Nothing _
                OrElse Me.ORD.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ORD.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetPONUMBER1()

                  
            
        
            ' Set the PONUMBER Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.PONUMBER1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPONUMBER1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PONUMBERSpecified Then
                				
                ' If the PONUMBER is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.PONUMBER)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PONUMBER1.Text = formattedValue
                
            Else 
            
                ' PONUMBER is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.PONUMBER1.Text = Sel_WPO_InquireDetails1View.PONUMBER.Format(Sel_WPO_InquireDetails1View.PONUMBER.DefaultValue)
                        		
                End If
                 
            ' If the PONUMBER is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PONUMBER1.Text Is Nothing _
                OrElse Me.PONUMBER1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PONUMBER1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetQTYORDER()

                  
            
        
            ' Set the QTYORDER Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.QTYORDER is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetQTYORDER()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.QTYORDERSpecified Then
                				
                ' If the QTYORDER is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.QTYORDER, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.QTYORDER.Text = formattedValue
                
            Else 
            
                ' QTYORDER is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.QTYORDER.Text = Sel_WPO_InquireDetails1View.QTYORDER.Format(Sel_WPO_InquireDetails1View.QTYORDER.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the QTYORDER is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.QTYORDER.Text Is Nothing _
                OrElse Me.QTYORDER.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.QTYORDER.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetREQSTDBY()

                  
            
        
            ' Set the REQSTDBY Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.REQSTDBY is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetREQSTDBY()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.REQSTDBYSpecified Then
                				
                ' If the REQSTDBY is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.REQSTDBY)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.REQSTDBY.Text = formattedValue
                
            Else 
            
                ' REQSTDBY is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.REQSTDBY.Text = Sel_WPO_InquireDetails1View.REQSTDBY.Format(Sel_WPO_InquireDetails1View.REQSTDBY.DefaultValue)
                        		
                End If
                 
            ' If the REQSTDBY is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.REQSTDBY.Text Is Nothing _
                OrElse Me.REQSTDBY.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.REQSTDBY.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetUNITCOST()

                  
            
        
            ' Set the UNITCOST Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.UNITCOST is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUNITCOST()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UNITCOSTSpecified Then
                				
                ' If the UNITCOST is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.UNITCOST, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UNITCOST.Text = formattedValue
                
            Else 
            
                ' UNITCOST is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.UNITCOST.Text = Sel_WPO_InquireDetails1View.UNITCOST.Format(Sel_WPO_InquireDetails1View.UNITCOST.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the UNITCOST is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UNITCOST.Text Is Nothing _
                OrElse Me.UNITCOST.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UNITCOST.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetUOFM()

                  
            
        
            ' Set the UOFM Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.UOFM is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUOFM()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UOFMSpecified Then
                				
                ' If the UOFM is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.UOFM)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UOFM.Text = formattedValue
                
            Else 
            
                ' UOFM is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.UOFM.Text = Sel_WPO_InquireDetails1View.UOFM.Format(Sel_WPO_InquireDetails1View.UOFM.DefaultValue)
                        		
                End If
                 
            ' If the UOFM is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UOFM.Text Is Nothing _
                OrElse Me.UOFM.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UOFM.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCur_Short()

                  
            
        
            ' Set the WCur_Short Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.WCur_Short is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCur_Short()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCur_ShortSpecified Then
                				
                ' If the WCur_Short is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.WCur_Short)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCur_Short.Text = formattedValue
                
            Else 
            
                ' WCur_Short is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCur_Short.Text = Sel_WPO_InquireDetails1View.WCur_Short.Format(Sel_WPO_InquireDetails1View.WCur_Short.DefaultValue)
                        		
                End If
                 
            ' If the WCur_Short is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCur_Short.Text Is Nothing _
                OrElse Me.WCur_Short.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCur_Short.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPOFR_Rate()

                  
            
        
            ' Set the WPOFR_Rate Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_InquireDetails record retrieved from the database.
            ' Me.WPOFR_Rate is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPOFR_Rate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPOFR_RateSpecified Then
                				
                ' If the WPOFR_Rate is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_InquireDetails1View.WPOFR_Rate, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPOFR_Rate.Text = formattedValue
                
            Else 
            
                ' WPOFR_Rate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPOFR_Rate.Text = Sel_WPO_InquireDetails1View.WPOFR_Rate.Format(Sel_WPO_InquireDetails1View.WPOFR_Rate.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the WPOFR_Rate is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPOFR_Rate.Text Is Nothing _
                OrElse Me.WPOFR_Rate.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPOFR_Rate.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetLiteral()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSel_WPO_InquireDetails1TableControl1()           
        
        
            If Sel_WPO_InquireDetails1TableControl1.Visible Then
                Sel_WPO_InquireDetails1TableControl1.LoadData()
                Sel_WPO_InquireDetails1TableControl1.DataBind()
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

      
        
        ' To customize, override this method in Sel_WPO_InquireDetailsTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "Sel_WPO_InquireDetailsTableControl"), Sel_WPO_InquireDetailsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Sel_WPO_InquireDetailsTableControl"), Sel_WPO_InquireDetailsTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recSel_WPO_InquireDetails1TableControl1 as Sel_WPO_InquireDetails1TableControl1= DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetails1TableControl1"), Sel_WPO_InquireDetails1TableControl1)
        recSel_WPO_InquireDetails1TableControl1.SaveData()
          
        End Sub

        ' To customize, override this method in Sel_WPO_InquireDetailsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetCOMMENT_4()
            GetCOMMENTS()
            GetCompanyID1()
            GetExtCostForex()
            GetEXTDCOST()
            GetITEMDESC()
            GetITEMNMBR()
            GetLineNumber()
            GetORD()
            GetPONUMBER1()
            GetQTYORDER()
            GetREQSTDBY()
            GetUNITCOST()
            GetUOFM()
            GetWCur_Short()
            GetWPOFR_Rate()
        End Sub
        
        
        Public Overridable Sub GetCOMMENT_4()
            
        End Sub
                
        Public Overridable Sub GetCOMMENTS()
            
        End Sub
                
        Public Overridable Sub GetCompanyID1()
            
        End Sub
                
        Public Overridable Sub GetExtCostForex()
            
        End Sub
                
        Public Overridable Sub GetEXTDCOST()
            
        End Sub
                
        Public Overridable Sub GetITEMDESC()
            
        End Sub
                
        Public Overridable Sub GetITEMNMBR()
            
        End Sub
                
        Public Overridable Sub GetLineNumber()
            
        End Sub
                
        Public Overridable Sub GetORD()
            
        End Sub
                
        Public Overridable Sub GetPONUMBER1()
            
        End Sub
                
        Public Overridable Sub GetQTYORDER()
            
        End Sub
                
        Public Overridable Sub GetREQSTDBY()
            
        End Sub
                
        Public Overridable Sub GetUNITCOST()
            
        End Sub
                
        Public Overridable Sub GetUOFM()
            
        End Sub
                
        Public Overridable Sub GetWCur_Short()
            
        End Sub
                
        Public Overridable Sub GetWPOFR_Rate()
            
        End Sub
                
      
        ' To customize, override this method in Sel_WPO_InquireDetailsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in Sel_WPO_InquireDetailsTableControlRow.
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
          Sel_WPO_InquireDetails1View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Sel_WPO_InquireDetailsTableControl"), Sel_WPO_InquireDetailsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Sel_WPO_InquireDetailsTableControl"), Sel_WPO_InquireDetailsTableControl).ResetData = True
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
        
        Public Overridable Sub SetiComment()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub iComment_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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

        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseSel_WPO_InquireDetailsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSel_WPO_InquireDetailsTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As Sel_WPO_InquireDetails1Record
            Get
                Return DirectCast(MyBase._DataSource, Sel_WPO_InquireDetails1Record)
            End Get
            Set(ByVal value As Sel_WPO_InquireDetails1Record)
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
        
        Public ReadOnly Property COMMENT_4() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "COMMENT_4"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property COMMENTS() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "COMMENTS"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CompanyID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CompanyID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ExtCostForex() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExtCostForex"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property EXTDCOST() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EXTDCOST"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property iComment() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "iComment"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property ITEMDESC() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ITEMDESC"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ITEMNMBR() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ITEMNMBR"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property LineNumber() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LineNumber"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Literal() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ORD() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ORD"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property PONUMBER1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PONUMBER1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property QTYORDER() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "QTYORDER"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property REQSTDBY() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "REQSTDBY"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Sel_WPO_InquireDetails1TableControl1() As Sel_WPO_InquireDetails1TableControl1
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetails1TableControl1"), Sel_WPO_InquireDetails1TableControl1)
            End Get
        End Property
        
        Public ReadOnly Property UNITCOST() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UNITCOST"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property UOFM() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UOFM"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCur_Short() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCur_Short"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPOFR_Rate() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOFR_Rate"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As Sel_WPO_InquireDetails1Record = Nothing
             
        
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
            
            Dim rec As Sel_WPO_InquireDetails1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Sel_WPO_InquireDetails1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Sel_WPO_InquireDetails1View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Sel_WPO_InquireDetailsTableControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in Sel_WPO_InquireDetailsTableControl.
Public Class BaseSel_WPO_InquireDetailsTableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_WPO_InquireDetails1Record)), Sel_WPO_InquireDetails1Record())
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
                    For Each rc As Sel_WPO_InquireDetailsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_WPO_InquireDetails1Record)), Sel_WPO_InquireDetails1Record())
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
                
            Me.EXTDCOSTPageTotal.Text = Me.GetEXTDCOSTPageTotal()
            If Me.EXTDCOSTPageTotal.Text Is Nothing OrElse _
                Me.EXTDCOSTPageTotal.Text.Trim() = "" Then
                Me.EXTDCOSTPageTotal.Text = "&nbsp;"
            End If
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
            ByVal pageSize As Integer) As Sel_WPO_InquireDetails1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column1, True)         
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column2, True)          
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return Sel_WPO_InquireDetails1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New Sel_WPO_InquireDetails1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Sel_WPO_InquireDetails1Record)), Sel_WPO_InquireDetails1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column1, True)         
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column2, True)          
            ' selCols.Add(Sel_WPO_InquireDetails1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return Sel_WPO_InquireDetails1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Sel_WPO_InquireDetails1View
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetailsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As Sel_WPO_InquireDetailsTableControlRow = DirectCast(repItem.FindControl("Sel_WPO_InquireDetailsTableControlRow"), Sel_WPO_InquireDetailsTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetCOMMENTSLabel()
                SetExtCostForexLabel()
                SetEXTDCOSTLabel()
                
                SetITEMDESCLabel()
                SetITEMNMBRLabel()
                SetLineNumberLabel()
                SetLiteral12()
                SetQTYORDERLabel()
                SetREQSTDBYLabel()
                
                SetUNITCOSTLabel()
                SetUNITCOSTLabel2()
                SetUOFMLabel()
                SetWCur_ShortLabel()
                SetWPOFR_RateLabel()
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
        

            ' Bind the buttons for Sel_WPO_InquireDetailsTableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Sel_WPO_InquireDetailsTableControlRow
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
            Sel_WPO_InquireDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Sel_WPO_InquireDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
        
          Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
        
          Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
        
          Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
        
          Dim hasFiltersWPOP10100RecordControl As Boolean = False
        
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetailsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As Sel_WPO_InquireDetailsTableControlRow = DirectCast(repItem.FindControl("Sel_WPO_InquireDetailsTableControlRow"), Sel_WPO_InquireDetailsTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_WPO_InquireDetails1Record = New Sel_WPO_InquireDetails1Record()
        
                        If recControl.COMMENT_4.Text <> "" Then
                            rec.Parse(recControl.COMMENT_4.Text, Sel_WPO_InquireDetails1View.COMMENT_4)
                        End If
                        If recControl.COMMENTS.Text <> "" Then
                            rec.Parse(recControl.COMMENTS.Text, Sel_WPO_InquireDetails1View.COMMENTS)
                        End If
                        If recControl.CompanyID1.Text <> "" Then
                            rec.Parse(recControl.CompanyID1.Text, Sel_WPO_InquireDetails1View.CompanyID)
                        End If
                        If recControl.ExtCostForex.Text <> "" Then
                            rec.Parse(recControl.ExtCostForex.Text, Sel_WPO_InquireDetails1View.ExtCostForex)
                        End If
                        If recControl.EXTDCOST.Text <> "" Then
                            rec.Parse(recControl.EXTDCOST.Text, Sel_WPO_InquireDetails1View.EXTDCOST)
                        End If
                        If recControl.ITEMDESC.Text <> "" Then
                            rec.Parse(recControl.ITEMDESC.Text, Sel_WPO_InquireDetails1View.ITEMDESC)
                        End If
                        If recControl.ITEMNMBR.Text <> "" Then
                            rec.Parse(recControl.ITEMNMBR.Text, Sel_WPO_InquireDetails1View.ITEMNMBR)
                        End If
                        If recControl.LineNumber.Text <> "" Then
                            rec.Parse(recControl.LineNumber.Text, Sel_WPO_InquireDetails1View.LineNumber)
                        End If
                        If recControl.ORD.Text <> "" Then
                            rec.Parse(recControl.ORD.Text, Sel_WPO_InquireDetails1View.ORD)
                        End If
                        If recControl.PONUMBER1.Text <> "" Then
                            rec.Parse(recControl.PONUMBER1.Text, Sel_WPO_InquireDetails1View.PONUMBER)
                        End If
                        If recControl.QTYORDER.Text <> "" Then
                            rec.Parse(recControl.QTYORDER.Text, Sel_WPO_InquireDetails1View.QTYORDER)
                        End If
                        If recControl.REQSTDBY.Text <> "" Then
                            rec.Parse(recControl.REQSTDBY.Text, Sel_WPO_InquireDetails1View.REQSTDBY)
                        End If
                        If recControl.UNITCOST.Text <> "" Then
                            rec.Parse(recControl.UNITCOST.Text, Sel_WPO_InquireDetails1View.UNITCOST)
                        End If
                        If recControl.UOFM.Text <> "" Then
                            rec.Parse(recControl.UOFM.Text, Sel_WPO_InquireDetails1View.UOFM)
                        End If
                        If recControl.WCur_Short.Text <> "" Then
                            rec.Parse(recControl.WCur_Short.Text, Sel_WPO_InquireDetails1View.WCur_Short)
                        End If
                        If recControl.WPOFR_Rate.Text <> "" Then
                            rec.Parse(recControl.WPOFR_Rate.Text, Sel_WPO_InquireDetails1View.WPOFR_Rate)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New Sel_WPO_InquireDetails1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Sel_WPO_InquireDetails1Record)), Sel_WPO_InquireDetails1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Sel_WPO_InquireDetailsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Sel_WPO_InquireDetailsTableControlRow) As Boolean
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
        
        Public Overridable Sub SetCOMMENTSLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.COMMENTSLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetExtCostForexLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ExtCostForexLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetEXTDCOSTLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.EXTDCOSTLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetITEMDESCLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ITEMDESCLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetITEMNMBRLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.ITEMNMBRLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLineNumberLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.LineNumberLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral12()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal12.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetQTYORDERLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.QTYORDERLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetREQSTDBYLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.REQSTDBYLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetUNITCOSTLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.UNITCOSTLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetUNITCOSTLabel2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.UNITCOSTLabel2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetUOFMLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.UOFMLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCur_ShortLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCur_ShortLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPOFR_RateLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPOFR_RateLabel.Text = "Some value"
                    
                  End Sub
                
        Protected Overridable Function GetEXTDCOSTPageTotal() As String

            Dim wc As WhereClause = Me.CreateWhereClause()            
            Dim joinFilter As CompoundFilter = Me.CreateCompoundJoinFilter()
              
            Dim orderBy As OrderBy = Me.CreateOrderBy()      
            
                Dim EXTDCOSTSum As String = Sel_WPO_InquireDetails1View.GetSum(Sel_WPO_InquireDetails1View.EXTDCOST, joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
              
            Return Sel_WPO_InquireDetails1View.EXTDCOST.Format(EXTDCOSTSum)
              

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

            Dim orderByStr As String = CType(ViewState("Sel_WPO_InquireDetailsTableControl_OrderBy"), String)
          
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
                Me.ViewState("Sel_WPO_InquireDetailsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = Sel_WPO_InquireDetails1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As Sel_WPO_InquireDetails1Record ()
            Get
                Return DirectCast(MyBase._DataSource, Sel_WPO_InquireDetails1Record())
            End Get
            Set(ByVal value() As Sel_WPO_InquireDetails1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property COMMENTSLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "COMMENTSLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ExtCostForexLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExtCostForexLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EXTDCOSTLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EXTDCOSTLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property EXTDCOSTPageTotal() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EXTDCOSTPageTotal"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property ITEMDESCLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ITEMDESCLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ITEMNMBRLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ITEMNMBRLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property LineNumberLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LineNumberLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal12() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal12"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property QTYORDERLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "QTYORDERLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property REQSTDBYLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "REQSTDBYLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UNITCOSTLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UNITCOSTLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UNITCOSTLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UNITCOSTLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UOFMLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UOFMLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCur_ShortLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCur_ShortLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPOFR_RateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOFR_RateLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As Sel_WPO_InquireDetailsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Sel_WPO_InquireDetails1Record = Nothing     
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
                Dim recCtl As Sel_WPO_InquireDetailsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Sel_WPO_InquireDetails1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As Sel_WPO_InquireDetailsTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Sel_WPO_InquireDetailsTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Sel_WPO_InquireDetailsTableControlRow)), Sel_WPO_InquireDetailsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Sel_WPO_InquireDetailsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As Sel_WPO_InquireDetailsTableControlRow
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

        Public Overridable Function GetRecordControls() As Sel_WPO_InquireDetailsTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Sel_WPO_InquireDetailsTableControlRow")
            Dim list As New List(Of Sel_WPO_InquireDetailsTableControlRow)
            For Each recCtrl As Sel_WPO_InquireDetailsTableControlRow In recCtrls
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

  
' Base class for the View_WCPO_Canvass1TableControlRow control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in View_WCPO_Canvass1TableControlRow.
Public Class BaseView_WCPO_Canvass1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in View_WCPO_Canvass1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in View_WCPO_Canvass1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.ImageButton2.Click, AddressOf ImageButton2_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = View_WCPO_Canvass11View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseView_WCPO_Canvass1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New View_WCPO_Canvass11Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in View_WCPO_Canvass1TableControlRow.
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
        
                SetBuyer()
                SetCanvassDate()
                SetClassification()
                
                SetPRID()
                SetWCI_ID()
                SetWCI_Status()
                SetWCI_Submit()
                SetImageButton2()
              
      
      
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
        
        
        Public Overridable Sub SetBuyer()

                  
            
        
            ' Set the Buyer Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 record retrieved from the database.
            ' Me.Buyer is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetBuyer()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.BuyerSpecified Then
                				
                ' If the Buyer is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(View_WCPO_Canvass11View.Buyer)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Buyer.Text = formattedValue
                
            Else 
            
                ' Buyer is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Buyer.Text = View_WCPO_Canvass11View.Buyer.Format(View_WCPO_Canvass11View.Buyer.DefaultValue)
                        		
                End If
                 
            ' If the Buyer is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Buyer.Text Is Nothing _
                OrElse Me.Buyer.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Buyer.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetCanvassDate()

                  
            
        
            ' Set the CanvassDate Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 record retrieved from the database.
            ' Me.CanvassDate is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCanvassDate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CanvassDateSpecified Then
                				
                ' If the CanvassDate is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(View_WCPO_Canvass11View.CanvassDate, "d")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CanvassDate.Text = formattedValue
                
            Else 
            
                ' CanvassDate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.CanvassDate.Text = View_WCPO_Canvass11View.CanvassDate.Format(View_WCPO_Canvass11View.CanvassDate.DefaultValue, "d")
                        		
                End If
                 
            ' If the CanvassDate is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CanvassDate.Text Is Nothing _
                OrElse Me.CanvassDate.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CanvassDate.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetClassification()

                  
            
        
            ' Set the Classification Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 record retrieved from the database.
            ' Me.Classification is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetClassification()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ClassificationSpecified Then
                				
                ' If the Classification is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = View_WCPO_Canvass11View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_WCPO_Canvass11View.Classification)
                If _isExpandableNonCompositeForeignKey AndAlso View_WCPO_Canvass11View.Classification.IsApplyDisplayAs Then
                                  
                       formattedValue = View_WCPO_Canvass11View.GetDFKA(Me.DataSource.Classification.ToString(),View_WCPO_Canvass11View.Classification, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(View_WCPO_Canvass11View.Classification)
                       End If
                Else
                       formattedValue = Me.DataSource.Classification.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Classification.Text = formattedValue
                
            Else 
            
                ' Classification is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Classification.Text = View_WCPO_Canvass11View.Classification.Format(View_WCPO_Canvass11View.Classification.DefaultValue)
                        		
                End If
                 
            ' If the Classification is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Classification.Text Is Nothing _
                OrElse Me.Classification.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Classification.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetPRID()

                  
            
        
            ' Set the PRID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 record retrieved from the database.
            ' Me.PRID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPRID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PRIDSpecified Then
                				
                ' If the PRID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = View_WCPO_Canvass11View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(View_WCPO_Canvass11View.PRID)
                If _isExpandableNonCompositeForeignKey AndAlso View_WCPO_Canvass11View.PRID.IsApplyDisplayAs Then
                                  
                       formattedValue = View_WCPO_Canvass11View.GetDFKA(Me.DataSource.PRID.ToString(),View_WCPO_Canvass11View.PRID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(View_WCPO_Canvass11View.PRID)
                       End If
                Else
                       formattedValue = Me.DataSource.PRID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PRID.Text = formattedValue
                
            Else 
            
                ' PRID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.PRID.Text = View_WCPO_Canvass11View.PRID.Format(View_WCPO_Canvass11View.PRID.DefaultValue)
                        		
                End If
                 
            ' If the PRID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PRID.Text Is Nothing _
                OrElse Me.PRID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PRID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCI_ID()

                  
            
        
            ' Set the WCI_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 record retrieved from the database.
            ' Me.WCI_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_IDSpecified Then
                				
                ' If the WCI_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(View_WCPO_Canvass11View.WCI_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCI_ID.Text = formattedValue
                
            Else 
            
                ' WCI_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCI_ID.Text = View_WCPO_Canvass11View.WCI_ID.Format(View_WCPO_Canvass11View.WCI_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCI_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCI_ID.Text Is Nothing _
                OrElse Me.WCI_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCI_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCI_Status()

                  
            
        
            ' Set the WCI_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 record retrieved from the database.
            ' Me.WCI_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_StatusSpecified Then
                				
                ' If the WCI_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(View_WCPO_Canvass11View.WCI_Status)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCI_Status.Text = formattedValue
                
            Else 
            
                ' WCI_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCI_Status.Text = View_WCPO_Canvass11View.WCI_Status.Format(View_WCPO_Canvass11View.WCI_Status.DefaultValue)
                        		
                End If
                 
            ' If the WCI_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCI_Status.Text Is Nothing _
                OrElse Me.WCI_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCI_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCI_Submit()

                  
            
        
            ' Set the WCI_Submit Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.view_WCPO_Canvass1 record retrieved from the database.
            ' Me.WCI_Submit is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_Submit()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_SubmitSpecified Then
                				
                ' If the WCI_Submit is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(View_WCPO_Canvass11View.WCI_Submit)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCI_Submit.Text = formattedValue
                
            Else 
            
                ' WCI_Submit is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCI_Submit.Text = View_WCPO_Canvass11View.WCI_Submit.Format(View_WCPO_Canvass11View.WCI_Submit.DefaultValue)
                        		
                End If
                 
            ' If the WCI_Submit is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCI_Submit.Text Is Nothing _
                OrElse Me.WCI_Submit.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCI_Submit.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in View_WCPO_Canvass1TableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "View_WCPO_Canvass1TableControl"), View_WCPO_Canvass1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "View_WCPO_Canvass1TableControl"), View_WCPO_Canvass1TableControl).ResetData = True
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

        ' To customize, override this method in View_WCPO_Canvass1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetBuyer()
            GetCanvassDate()
            GetClassification()
            GetPRID()
            GetWCI_ID()
            GetWCI_Status()
            GetWCI_Submit()
        End Sub
        
        
        Public Overridable Sub GetBuyer()
            
        End Sub
                
        Public Overridable Sub GetCanvassDate()
            
        End Sub
                
        Public Overridable Sub GetClassification()
            
        End Sub
                
        Public Overridable Sub GetPRID()
            
        End Sub
                
        Public Overridable Sub GetWCI_ID()
            
        End Sub
                
        Public Overridable Sub GetWCI_Status()
            
        End Sub
                
        Public Overridable Sub GetWCI_Submit()
            
        End Sub
                
      
        ' To customize, override this method in View_WCPO_Canvass1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in View_WCPO_Canvass1TableControlRow.
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
          View_WCPO_Canvass11View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "View_WCPO_Canvass1TableControl"), View_WCPO_Canvass1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "View_WCPO_Canvass1TableControl"), View_WCPO_Canvass1TableControl).ResetData = True
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
        
        Public Overridable Sub SetImageButton2()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub ImageButton2_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WCanvass_Internal/Show-WCanvass-Internal1.aspx?WCanvass_Internal={View_WCPO_Canvass1TableControlRow:FV:WCI_ID}"
                  
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
                Return CType(Me.ViewState("BaseView_WCPO_Canvass1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseView_WCPO_Canvass1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As View_WCPO_Canvass11Record
            Get
                Return DirectCast(MyBase._DataSource, View_WCPO_Canvass11Record)
            End Get
            Set(ByVal value As View_WCPO_Canvass11Record)
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
        
        Public ReadOnly Property Buyer() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Buyer"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CanvassDate() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CanvassDate"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Classification() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Classification"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ImageButton2() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImageButton2"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PRID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PRID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCI_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCI_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCI_Submit() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_Submit"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As View_WCPO_Canvass11Record = Nothing
             
        
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
            
            Dim rec As View_WCPO_Canvass11Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As View_WCPO_Canvass11Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return View_WCPO_Canvass11View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the View_WCPO_Canvass1TableControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in View_WCPO_Canvass1TableControl.
Public Class BaseView_WCPO_Canvass1TableControl
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
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "5"))
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(View_WCPO_Canvass11Record)), View_WCPO_Canvass11Record())
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
                    For Each rc As View_WCPO_Canvass1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(View_WCPO_Canvass11Record)), View_WCPO_Canvass11Record())
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
            ByVal pageSize As Integer) As View_WCPO_Canvass11Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(View_WCPO_Canvass11View.Column1, True)         
            ' selCols.Add(View_WCPO_Canvass11View.Column2, True)          
            ' selCols.Add(View_WCPO_Canvass11View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return View_WCPO_Canvass11View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New View_WCPO_Canvass11View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(View_WCPO_Canvass11Record)), View_WCPO_Canvass11Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(View_WCPO_Canvass11View.Column1, True)         
            ' selCols.Add(View_WCPO_Canvass11View.Column2, True)          
            ' selCols.Add(View_WCPO_Canvass11View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return View_WCPO_Canvass11View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New View_WCPO_Canvass11View
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "View_WCPO_Canvass1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As View_WCPO_Canvass1TableControlRow = DirectCast(repItem.FindControl("View_WCPO_Canvass1TableControlRow"), View_WCPO_Canvass1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetBuyerLabel()
                SetCanvassDateLabel()
                SetClassificationLabel()
                SetPRIDLabel()
                SetWCI_StatusLabel()
                SetWCI_SubmitLabel()
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
          
            Me.Page.PregetDfkaRecords(View_WCPO_Canvass11View.Classification, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(View_WCPO_Canvass11View.PRID, Me.DataSource)
          
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
        

            ' Bind the buttons for View_WCPO_Canvass1TableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As View_WCPO_Canvass1TableControlRow
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
            View_WCPO_Canvass11View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            View_WCPO_Canvass11View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
        
          Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
        
          Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
        
          Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
        
          Dim hasFiltersWPOP10100RecordControl As Boolean = False
        
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "View_WCPO_Canvass1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As View_WCPO_Canvass1TableControlRow = DirectCast(repItem.FindControl("View_WCPO_Canvass1TableControlRow"), View_WCPO_Canvass1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As View_WCPO_Canvass11Record = New View_WCPO_Canvass11Record()
        
                        If recControl.Buyer.Text <> "" Then
                            rec.Parse(recControl.Buyer.Text, View_WCPO_Canvass11View.Buyer)
                        End If
                        If recControl.CanvassDate.Text <> "" Then
                            rec.Parse(recControl.CanvassDate.Text, View_WCPO_Canvass11View.CanvassDate)
                        End If
                        If recControl.Classification.Text <> "" Then
                            rec.Parse(recControl.Classification.Text, View_WCPO_Canvass11View.Classification)
                        End If
                        If recControl.PRID.Text <> "" Then
                            rec.Parse(recControl.PRID.Text, View_WCPO_Canvass11View.PRID)
                        End If
                        If recControl.WCI_ID.Text <> "" Then
                            rec.Parse(recControl.WCI_ID.Text, View_WCPO_Canvass11View.WCI_ID)
                        End If
                        If recControl.WCI_Status.Text <> "" Then
                            rec.Parse(recControl.WCI_Status.Text, View_WCPO_Canvass11View.WCI_Status)
                        End If
                        If recControl.WCI_Submit.Text <> "" Then
                            rec.Parse(recControl.WCI_Submit.Text, View_WCPO_Canvass11View.WCI_Submit)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New View_WCPO_Canvass11Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(View_WCPO_Canvass11Record)), View_WCPO_Canvass11Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As View_WCPO_Canvass1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As View_WCPO_Canvass1TableControlRow) As Boolean
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
        
        Public Overridable Sub SetBuyerLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetCanvassDateLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.CanvassDateLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetClassificationLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetPRIDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.PRIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCI_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCI_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCI_SubmitLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCI_SubmitLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("View_WCPO_Canvass1TableControl_OrderBy"), String)
          
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
                Me.ViewState("View_WCPO_Canvass1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = View_WCPO_Canvass11View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As View_WCPO_Canvass11Record ()
            Get
                Return DirectCast(MyBase._DataSource, View_WCPO_Canvass11Record())
            End Get
            Set(ByVal value() As View_WCPO_Canvass11Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property BuyerLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "BuyerLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CanvassDateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CanvassDateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ClassificationLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ClassificationLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property PRIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PRIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCI_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCI_SubmitLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_SubmitLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As View_WCPO_Canvass1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As View_WCPO_Canvass11Record = Nothing     
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
                Dim recCtl As View_WCPO_Canvass1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As View_WCPO_Canvass11Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As View_WCPO_Canvass1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As View_WCPO_Canvass1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(View_WCPO_Canvass1TableControlRow)), View_WCPO_Canvass1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As View_WCPO_Canvass1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As View_WCPO_Canvass1TableControlRow
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

        Public Overridable Function GetRecordControls() As View_WCPO_Canvass1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "View_WCPO_Canvass1TableControlRow")
            Dim list As New List(Of View_WCPO_Canvass1TableControlRow)
            For Each recCtrl As View_WCPO_Canvass1TableControlRow In recCtrls
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

  
' Base class for the WPO_CARNo_QDetailsTableControlRow control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPO_CARNo_QDetailsTableControlRow.
Public Class BaseWPO_CARNo_QDetailsTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WPO_CARNo_QDetailsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WPO_CARNo_QDetailsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.ImageButton1.Click, AddressOf ImageButton1_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WPO_CARNo_QDetails1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWPO_CARNo_QDetailsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WPO_CARNo_QDetails1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WPO_CARNo_QDetailsTableControlRow.
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
        
                SetCARID()
                
                SetPRNum()
                SetWCD_Exp_Total()
                SetWCD_No()
                SetWCD_Project_Title()
                SetWCD_Remark()
                SetImageButton1()
              
      
      
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
        
        
        Public Overridable Sub SetCARID()

                  
            
        
            ' Set the CARID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails record retrieved from the database.
            ' Me.CARID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCARID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CARIDSpecified Then
                				
                ' If the CARID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_CARNo_QDetails1View.CARID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CARID.Text = formattedValue
                
            Else 
            
                ' CARID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.CARID.Text = WPO_CARNo_QDetails1View.CARID.Format(WPO_CARNo_QDetails1View.CARID.DefaultValue)
                        		
                End If
                 
            ' If the CARID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.CARID.Text Is Nothing _
                OrElse Me.CARID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.CARID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetPRNum()

                  
            
        
            ' Set the PRNum Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails record retrieved from the database.
            ' Me.PRNum is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPRNum()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PRNumSpecified Then
                				
                ' If the PRNum is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WPO_CARNo_QDetails1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPO_CARNo_QDetails1View.PRNum)
                If _isExpandableNonCompositeForeignKey AndAlso WPO_CARNo_QDetails1View.PRNum.IsApplyDisplayAs Then
                                  
                       formattedValue = WPO_CARNo_QDetails1View.GetDFKA(Me.DataSource.PRNum.ToString(),WPO_CARNo_QDetails1View.PRNum, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WPO_CARNo_QDetails1View.PRNum)
                       End If
                Else
                       formattedValue = Me.DataSource.PRNum.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PRNum.Text = formattedValue
                
            Else 
            
                ' PRNum is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.PRNum.Text = WPO_CARNo_QDetails1View.PRNum.Format(WPO_CARNo_QDetails1View.PRNum.DefaultValue)
                        		
                End If
                 
            ' If the PRNum is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PRNum.Text Is Nothing _
                OrElse Me.PRNum.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PRNum.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Total()

                  
            
        
            ' Set the WCD_Exp_Total Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails record retrieved from the database.
            ' Me.WCD_Exp_Total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_TotalSpecified Then
                				
                ' If the WCD_Exp_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_CARNo_QDetails1View.WCD_Exp_Total, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Total.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Total.Text = WPO_CARNo_QDetails1View.WCD_Exp_Total.Format(WPO_CARNo_QDetails1View.WCD_Exp_Total.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the WCD_Exp_Total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Total.Text Is Nothing _
                OrElse Me.WCD_Exp_Total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Total.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_No()

                  
            
        
            ' Set the WCD_No Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails record retrieved from the database.
            ' Me.WCD_No is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_No()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_NoSpecified Then
                				
                ' If the WCD_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_CARNo_QDetails1View.WCD_No)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_No.Text = formattedValue
                
            Else 
            
                ' WCD_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_No.Text = WPO_CARNo_QDetails1View.WCD_No.Format(WPO_CARNo_QDetails1View.WCD_No.DefaultValue)
                        		
                End If
                 
            ' If the WCD_No is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_No.Text Is Nothing _
                OrElse Me.WCD_No.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_No.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Project_Title()

                  
            
        
            ' Set the WCD_Project_Title Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails record retrieved from the database.
            ' Me.WCD_Project_Title is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Project_Title()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Project_TitleSpecified Then
                				
                ' If the WCD_Project_Title is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_CARNo_QDetails1View.WCD_Project_Title)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(WPO_CARNo_QDetails1View.WCD_Project_Title.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WPO_CARNo_QDetails1View, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WCD_Project_Title\"", \""WCD_Project_Title\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
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
                
                Me.WCD_Project_Title.Text = formattedValue
                
            Else 
            
                ' WCD_Project_Title is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Project_Title.Text = WPO_CARNo_QDetails1View.WCD_Project_Title.Format(WPO_CARNo_QDetails1View.WCD_Project_Title.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Project_Title is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Project_Title.Text Is Nothing _
                OrElse Me.WCD_Project_Title.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Project_Title.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Remark()

                  
            
        
            ' Set the WCD_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_CARNo_QDetails record retrieved from the database.
            ' Me.WCD_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_RemarkSpecified Then
                				
                ' If the WCD_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_CARNo_QDetails1View.WCD_Remark)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Remark.Text = formattedValue
                
            Else 
            
                ' WCD_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Remark.Text = WPO_CARNo_QDetails1View.WCD_Remark.Format(WPO_CARNo_QDetails1View.WCD_Remark.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Remark.Text Is Nothing _
                OrElse Me.WCD_Remark.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Remark.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in WPO_CARNo_QDetailsTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WPO_CARNo_QDetailsTableControl"), WPO_CARNo_QDetailsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WPO_CARNo_QDetailsTableControl"), WPO_CARNo_QDetailsTableControl).ResetData = True
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

        ' To customize, override this method in WPO_CARNo_QDetailsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetCARID()
            GetPRNum()
            GetWCD_Exp_Total()
            GetWCD_No()
            GetWCD_Project_Title()
            GetWCD_Remark()
        End Sub
        
        
        Public Overridable Sub GetCARID()
            
        End Sub
                
        Public Overridable Sub GetPRNum()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Total()
            
        End Sub
                
        Public Overridable Sub GetWCD_No()
            
        End Sub
                
        Public Overridable Sub GetWCD_Project_Title()
            
        End Sub
                
        Public Overridable Sub GetWCD_Remark()
            
        End Sub
                
      
        ' To customize, override this method in WPO_CARNo_QDetailsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WPO_CARNo_QDetailsTableControlRow.
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
          WPO_CARNo_QDetails1View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WPO_CARNo_QDetailsTableControl"), WPO_CARNo_QDetailsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WPO_CARNo_QDetailsTableControl"), WPO_CARNo_QDetailsTableControl).ResetData = True
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
        
        Public Overridable Sub SetImageButton1()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub ImageButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WCAR_Doc1/Show-WCAR-Doc1.aspx?WCAR_Doc1={WPO_CARNo_QDetailsTableControlRow:FV:CARID}"
                  
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
                Return CType(Me.ViewState("BaseWPO_CARNo_QDetailsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWPO_CARNo_QDetailsTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WPO_CARNo_QDetails1Record
            Get
                Return DirectCast(MyBase._DataSource, WPO_CARNo_QDetails1Record)
            End Get
            Set(ByVal value As WPO_CARNo_QDetails1Record)
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
        
        Public ReadOnly Property CARID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CARID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ImageButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImageButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PRNum() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PRNum"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_No() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_No"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Project_Title() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_Title"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Remark"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WPO_CARNo_QDetails1Record = Nothing
             
        
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
            
            Dim rec As WPO_CARNo_QDetails1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WPO_CARNo_QDetails1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WPO_CARNo_QDetails1View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WPO_CARNo_QDetailsTableControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPO_CARNo_QDetailsTableControl.
Public Class BaseWPO_CARNo_QDetailsTableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WPO_CARNo_QDetails1Record)), WPO_CARNo_QDetails1Record())
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
                    For Each rc As WPO_CARNo_QDetailsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WPO_CARNo_QDetails1Record)), WPO_CARNo_QDetails1Record())
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
            ByVal pageSize As Integer) As WPO_CARNo_QDetails1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WPO_CARNo_QDetails1View.Column1, True)         
            ' selCols.Add(WPO_CARNo_QDetails1View.Column2, True)          
            ' selCols.Add(WPO_CARNo_QDetails1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WPO_CARNo_QDetails1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WPO_CARNo_QDetails1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WPO_CARNo_QDetails1Record)), WPO_CARNo_QDetails1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WPO_CARNo_QDetails1View.Column1, True)         
            ' selCols.Add(WPO_CARNo_QDetails1View.Column2, True)          
            ' selCols.Add(WPO_CARNo_QDetails1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WPO_CARNo_QDetails1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WPO_CARNo_QDetails1View
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_CARNo_QDetailsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WPO_CARNo_QDetailsTableControlRow = DirectCast(repItem.FindControl("WPO_CARNo_QDetailsTableControlRow"), WPO_CARNo_QDetailsTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetPRNumLabel()
                SetWCD_Exp_TotalLabel()
                SetWCD_NoLabel()
                SetWCD_Project_TitleLabel()
                SetWCD_RemarkLabel()
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
          
            Me.Page.PregetDfkaRecords(WPO_CARNo_QDetails1View.PRNum, Me.DataSource)
          
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
        

            ' Bind the buttons for WPO_CARNo_QDetailsTableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WPO_CARNo_QDetailsTableControlRow
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
            WPO_CARNo_QDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WPO_CARNo_QDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
        
          Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
        
          Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
        
          Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
        
          Dim hasFiltersWPOP10100RecordControl As Boolean = False
        
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_CARNo_QDetailsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WPO_CARNo_QDetailsTableControlRow = DirectCast(repItem.FindControl("WPO_CARNo_QDetailsTableControlRow"), WPO_CARNo_QDetailsTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WPO_CARNo_QDetails1Record = New WPO_CARNo_QDetails1Record()
        
                        If recControl.CARID.Text <> "" Then
                            rec.Parse(recControl.CARID.Text, WPO_CARNo_QDetails1View.CARID)
                        End If
                        If recControl.PRNum.Text <> "" Then
                            rec.Parse(recControl.PRNum.Text, WPO_CARNo_QDetails1View.PRNum)
                        End If
                        If recControl.WCD_Exp_Total.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Total.Text, WPO_CARNo_QDetails1View.WCD_Exp_Total)
                        End If
                        If recControl.WCD_No.Text <> "" Then
                            rec.Parse(recControl.WCD_No.Text, WPO_CARNo_QDetails1View.WCD_No)
                        End If
                        If recControl.WCD_Project_Title.Text <> "" Then
                            rec.Parse(recControl.WCD_Project_Title.Text, WPO_CARNo_QDetails1View.WCD_Project_Title)
                        End If
                        If recControl.WCD_Remark.Text <> "" Then
                            rec.Parse(recControl.WCD_Remark.Text, WPO_CARNo_QDetails1View.WCD_Remark)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WPO_CARNo_QDetails1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WPO_CARNo_QDetails1Record)), WPO_CARNo_QDetails1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WPO_CARNo_QDetailsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WPO_CARNo_QDetailsTableControlRow) As Boolean
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
        
        Public Overridable Sub SetPRNumLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.PRNumLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_TotalLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Exp_TotalLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_NoLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_NoLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Project_TitleLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Project_TitleLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_RemarkLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WPO_CARNo_QDetailsTableControl_OrderBy"), String)
          
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
                Me.ViewState("WPO_CARNo_QDetailsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WPO_CARNo_QDetails1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WPO_CARNo_QDetails1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WPO_CARNo_QDetails1Record())
            End Get
            Set(ByVal value() As WPO_CARNo_QDetails1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property PRNumLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PRNumLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_TotalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_TotalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_NoLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_NoLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Project_TitleLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_TitleLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_RemarkLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WPO_CARNo_QDetailsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WPO_CARNo_QDetails1Record = Nothing     
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
                Dim recCtl As WPO_CARNo_QDetailsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WPO_CARNo_QDetails1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WPO_CARNo_QDetailsTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WPO_CARNo_QDetailsTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WPO_CARNo_QDetailsTableControlRow)), WPO_CARNo_QDetailsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WPO_CARNo_QDetailsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WPO_CARNo_QDetailsTableControlRow
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

        Public Overridable Function GetRecordControls() As WPO_CARNo_QDetailsTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WPO_CARNo_QDetailsTableControlRow")
            Dim list As New List(Of WPO_CARNo_QDetailsTableControlRow)
            For Each recCtrl As WPO_CARNo_QDetailsTableControlRow In recCtrls
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

  
' Base class for the WPO_Doc_AttachTableControlRow control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPO_Doc_AttachTableControlRow.
Public Class BaseWPO_Doc_AttachTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WPO_Doc_AttachTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WPO_Doc_AttachTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WPO_Doc_Attach record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WPO_Doc_Attach1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWPO_Doc_AttachTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WPO_Doc_Attach1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WPO_Doc_AttachTableControlRow.
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
        
                SetWPODA_Desc()
                SetWPODA_File()
      
      
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
        
        
        Public Overridable Sub SetWPODA_Desc()

                  
            
        
            ' Set the WPODA_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_Doc_Attach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_Doc_Attach record retrieved from the database.
            ' Me.WPODA_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPODA_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPODA_DescSpecified Then
                				
                ' If the WPODA_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_Doc_Attach1Table.WPODA_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPODA_Desc.Text = formattedValue
                
            Else 
            
                ' WPODA_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPODA_Desc.Text = WPO_Doc_Attach1Table.WPODA_Desc.Format(WPO_Doc_Attach1Table.WPODA_Desc.DefaultValue)
                        		
                End If
                 
            ' If the WPODA_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPODA_Desc.Text Is Nothing _
                OrElse Me.WPODA_Desc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPODA_Desc.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPODA_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPODA_FileSpecified Then
                
                Me.WPODA_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WPODA_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WPO_Doc_Attach1") & _
                            "&Field=" & Me.Page.Encrypt("WPODA_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.WPODA_File.Visible = True
            Else
                Me.WPODA_File.Visible = False
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

      
        
        ' To customize, override this method in WPO_Doc_AttachTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WPO_Doc_AttachTableControl"), WPO_Doc_AttachTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WPO_Doc_AttachTableControl"), WPO_Doc_AttachTableControl).ResetData = True
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

        ' To customize, override this method in WPO_Doc_AttachTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWPODA_Desc()
        End Sub
        
        
        Public Overridable Sub GetWPODA_Desc()
            
        End Sub
                
      
        ' To customize, override this method in WPO_Doc_AttachTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WPO_Doc_AttachTableControlRow.
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
          WPO_Doc_Attach1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WPO_Doc_AttachTableControl"), WPO_Doc_AttachTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WPO_Doc_AttachTableControl"), WPO_Doc_AttachTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWPO_Doc_AttachTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWPO_Doc_AttachTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WPO_Doc_Attach1Record
            Get
                Return DirectCast(MyBase._DataSource, WPO_Doc_Attach1Record)
            End Get
            Set(ByVal value As WPO_Doc_Attach1Record)
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
        
        Public ReadOnly Property WPODA_Desc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPODA_Desc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPODA_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPODA_File"), System.Web.UI.WebControls.LinkButton)
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
            
            Dim rec As WPO_Doc_Attach1Record = Nothing
             
        
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
            
            Dim rec As WPO_Doc_Attach1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WPO_Doc_Attach1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WPO_Doc_Attach1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WPO_Doc_AttachTableControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPO_Doc_AttachTableControl.
Public Class BaseWPO_Doc_AttachTableControl
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
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "5"))
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WPO_Doc_Attach1Record)), WPO_Doc_Attach1Record())
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
                    For Each rc As WPO_Doc_AttachTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WPO_Doc_Attach1Record)), WPO_Doc_Attach1Record())
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
            ByVal pageSize As Integer) As WPO_Doc_Attach1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WPO_Doc_Attach1Table.Column1, True)         
            ' selCols.Add(WPO_Doc_Attach1Table.Column2, True)          
            ' selCols.Add(WPO_Doc_Attach1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WPO_Doc_Attach1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WPO_Doc_Attach1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WPO_Doc_Attach1Record)), WPO_Doc_Attach1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WPO_Doc_Attach1Table.Column1, True)         
            ' selCols.Add(WPO_Doc_Attach1Table.Column2, True)          
            ' selCols.Add(WPO_Doc_Attach1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WPO_Doc_Attach1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WPO_Doc_Attach1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Doc_AttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WPO_Doc_AttachTableControlRow = DirectCast(repItem.FindControl("WPO_Doc_AttachTableControlRow"), WPO_Doc_AttachTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetWPODA_DescLabel()
                SetWPODA_FileLabel()
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
        

            ' Bind the buttons for WPO_Doc_AttachTableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WPO_Doc_AttachTableControlRow
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
            WPO_Doc_Attach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WPO_Doc_Attach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
        
          Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
        
          Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
        
          Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
        
          Dim hasFiltersWPOP10100RecordControl As Boolean = False
        
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Doc_AttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WPO_Doc_AttachTableControlRow = DirectCast(repItem.FindControl("WPO_Doc_AttachTableControlRow"), WPO_Doc_AttachTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WPO_Doc_Attach1Record = New WPO_Doc_Attach1Record()
        
                        If recControl.WPODA_Desc.Text <> "" Then
                            rec.Parse(recControl.WPODA_Desc.Text, WPO_Doc_Attach1Table.WPODA_Desc)
                        End If
                        If recControl.WPODA_File.Text <> "" Then
                            rec.Parse(recControl.WPODA_File.Text, WPO_Doc_Attach1Table.WPODA_File)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WPO_Doc_Attach1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WPO_Doc_Attach1Record)), WPO_Doc_Attach1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WPO_Doc_AttachTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WPO_Doc_AttachTableControlRow) As Boolean
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
        
        Public Overridable Sub SetWPODA_DescLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPODA_DescLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPODA_FileLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPODA_FileLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WPO_Doc_AttachTableControl_OrderBy"), String)
          
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
                Me.ViewState("WPO_Doc_AttachTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WPO_Doc_Attach1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WPO_Doc_Attach1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WPO_Doc_Attach1Record())
            End Get
            Set(ByVal value() As WPO_Doc_Attach1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property WPODA_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPODA_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPODA_FileLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPODA_FileLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WPO_Doc_AttachTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WPO_Doc_Attach1Record = Nothing     
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
                Dim recCtl As WPO_Doc_AttachTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WPO_Doc_Attach1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WPO_Doc_AttachTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WPO_Doc_AttachTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WPO_Doc_AttachTableControlRow)), WPO_Doc_AttachTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WPO_Doc_AttachTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WPO_Doc_AttachTableControlRow
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

        Public Overridable Function GetRecordControls() As WPO_Doc_AttachTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WPO_Doc_AttachTableControlRow")
            Dim list As New List(Of WPO_Doc_AttachTableControlRow)
            For Each recCtrl As WPO_Doc_AttachTableControlRow In recCtrls
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

  
' Base class for the WPO_PRNo_QDetailsTableControlRow control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPO_PRNo_QDetailsTableControlRow.
Public Class BaseWPO_PRNo_QDetailsTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WPO_PRNo_QDetailsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WPO_PRNo_QDetailsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.ImageButton.Click, AddressOf ImageButton_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WPO_PRNo_QDetails1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWPO_PRNo_QDetailsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WPO_PRNo_QDetails1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WPO_PRNo_QDetailsTableControlRow.
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
        
                SetComment()
                SetCommentLabel()
                
                SetPRNo()
                SetWPRD_Created()
                SetWPRD_ID()
                SetWPRD_Title()
                SetWPRD_Total()
                SetImageButton()
              
      
      
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
        
        
        Public Overridable Sub SetComment()

                  
            
        
            ' Set the Comment Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails record retrieved from the database.
            ' Me.Comment is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetComment()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CommentSpecified Then
                				
                ' If the Comment is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_PRNo_QDetails1View.Comment)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(WPO_PRNo_QDetails1View.Comment.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WPO_PRNo_QDetails1View, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""Comment\"", \""Comment\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
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
                
                Me.Comment.Text = formattedValue
                
            Else 
            
                ' Comment is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Comment.Text = WPO_PRNo_QDetails1View.Comment.Format(WPO_PRNo_QDetails1View.Comment.DefaultValue)
                        		
                End If
                 
            ' If the Comment is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Comment.Text Is Nothing _
                OrElse Me.Comment.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Comment.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetPRNo()

                  
            
        
            ' Set the PRNo Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails record retrieved from the database.
            ' Me.PRNo is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPRNo()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PRNoSpecified Then
                				
                ' If the PRNo is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_PRNo_QDetails1View.PRNo)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PRNo.Text = formattedValue
                
            Else 
            
                ' PRNo is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.PRNo.Text = WPO_PRNo_QDetails1View.PRNo.Format(WPO_PRNo_QDetails1View.PRNo.DefaultValue)
                        		
                End If
                 
            ' If the PRNo is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PRNo.Text Is Nothing _
                OrElse Me.PRNo.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PRNo.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPRD_Created()

                  
            
        
            ' Set the WPRD_Created Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails record retrieved from the database.
            ' Me.WPRD_Created is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPRD_Created()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPRD_CreatedSpecified Then
                				
                ' If the WPRD_Created is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_PRNo_QDetails1View.WPRD_Created, "d")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPRD_Created.Text = formattedValue
                
            Else 
            
                ' WPRD_Created is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPRD_Created.Text = WPO_PRNo_QDetails1View.WPRD_Created.Format(WPO_PRNo_QDetails1View.WPRD_Created.DefaultValue, "d")
                        		
                End If
                 
            ' If the WPRD_Created is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPRD_Created.Text Is Nothing _
                OrElse Me.WPRD_Created.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPRD_Created.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPRD_ID()

                  
            
        
            ' Set the WPRD_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails record retrieved from the database.
            ' Me.WPRD_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPRD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPRD_IDSpecified Then
                				
                ' If the WPRD_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_PRNo_QDetails1View.WPRD_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPRD_ID.Text = formattedValue
                
            Else 
            
                ' WPRD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPRD_ID.Text = WPO_PRNo_QDetails1View.WPRD_ID.Format(WPO_PRNo_QDetails1View.WPRD_ID.DefaultValue)
                        		
                End If
                 
            ' If the WPRD_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPRD_ID.Text Is Nothing _
                OrElse Me.WPRD_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPRD_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPRD_Title()

                  
            
        
            ' Set the WPRD_Title Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails record retrieved from the database.
            ' Me.WPRD_Title is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPRD_Title()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPRD_TitleSpecified Then
                				
                ' If the WPRD_Title is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_PRNo_QDetails1View.WPRD_Title)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPRD_Title.Text = formattedValue
                
            Else 
            
                ' WPRD_Title is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPRD_Title.Text = WPO_PRNo_QDetails1View.WPRD_Title.Format(WPO_PRNo_QDetails1View.WPRD_Title.DefaultValue)
                        		
                End If
                 
            ' If the WPRD_Title is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPRD_Title.Text Is Nothing _
                OrElse Me.WPRD_Title.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPRD_Title.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPRD_Total()

                  
            
        
            ' Set the WPRD_Total Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_PRNo_QDetails record retrieved from the database.
            ' Me.WPRD_Total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPRD_Total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPRD_TotalSpecified Then
                				
                ' If the WPRD_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_PRNo_QDetails1View.WPRD_Total, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPRD_Total.Text = formattedValue
                
            Else 
            
                ' WPRD_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPRD_Total.Text = WPO_PRNo_QDetails1View.WPRD_Total.Format(WPO_PRNo_QDetails1View.WPRD_Total.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the WPRD_Total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPRD_Total.Text Is Nothing _
                OrElse Me.WPRD_Total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPRD_Total.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetCommentLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.CommentLabel.Text = "Some value"
                    
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

      
        
        ' To customize, override this method in WPO_PRNo_QDetailsTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WPO_PRNo_QDetailsTableControl"), WPO_PRNo_QDetailsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WPO_PRNo_QDetailsTableControl"), WPO_PRNo_QDetailsTableControl).ResetData = True
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

        ' To customize, override this method in WPO_PRNo_QDetailsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetComment()
            GetPRNo()
            GetWPRD_Created()
            GetWPRD_ID()
            GetWPRD_Title()
            GetWPRD_Total()
        End Sub
        
        
        Public Overridable Sub GetComment()
            
        End Sub
                
        Public Overridable Sub GetPRNo()
            
        End Sub
                
        Public Overridable Sub GetWPRD_Created()
            
        End Sub
                
        Public Overridable Sub GetWPRD_ID()
            
        End Sub
                
        Public Overridable Sub GetWPRD_Title()
            
        End Sub
                
        Public Overridable Sub GetWPRD_Total()
            
        End Sub
                
      
        ' To customize, override this method in WPO_PRNo_QDetailsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WPO_PRNo_QDetailsTableControlRow.
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
          WPO_PRNo_QDetails1View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WPO_PRNo_QDetailsTableControl"), WPO_PRNo_QDetailsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WPO_PRNo_QDetailsTableControl"), WPO_PRNo_QDetailsTableControl).ResetData = True
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
        
        Public Overridable Sub SetImageButton()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub ImageButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WPR_Doc/Show-WPR-Doc.aspx?WPR_Doc={WPO_PRNo_QDetailsTableControlRow:FV:WPRD_ID}"
                  
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
                Return CType(Me.ViewState("BaseWPO_PRNo_QDetailsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWPO_PRNo_QDetailsTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WPO_PRNo_QDetails1Record
            Get
                Return DirectCast(MyBase._DataSource, WPO_PRNo_QDetails1Record)
            End Get
            Set(ByVal value As WPO_PRNo_QDetails1Record)
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
        
        Public ReadOnly Property Comment() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Comment"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CommentLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CommentLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ImageButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImageButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PRNo() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PRNo"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPRD_Created() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRD_Created"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPRD_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRD_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPRD_Title() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRD_Title"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPRD_Total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRD_Total"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WPO_PRNo_QDetails1Record = Nothing
             
        
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
            
            Dim rec As WPO_PRNo_QDetails1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WPO_PRNo_QDetails1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WPO_PRNo_QDetails1View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WPO_PRNo_QDetailsTableControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPO_PRNo_QDetailsTableControl.
Public Class BaseWPO_PRNo_QDetailsTableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WPO_PRNo_QDetails1Record)), WPO_PRNo_QDetails1Record())
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
                    For Each rc As WPO_PRNo_QDetailsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WPO_PRNo_QDetails1Record)), WPO_PRNo_QDetails1Record())
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
            ByVal pageSize As Integer) As WPO_PRNo_QDetails1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WPO_PRNo_QDetails1View.Column1, True)         
            ' selCols.Add(WPO_PRNo_QDetails1View.Column2, True)          
            ' selCols.Add(WPO_PRNo_QDetails1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WPO_PRNo_QDetails1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WPO_PRNo_QDetails1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WPO_PRNo_QDetails1Record)), WPO_PRNo_QDetails1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WPO_PRNo_QDetails1View.Column1, True)         
            ' selCols.Add(WPO_PRNo_QDetails1View.Column2, True)          
            ' selCols.Add(WPO_PRNo_QDetails1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WPO_PRNo_QDetails1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WPO_PRNo_QDetails1View
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_PRNo_QDetailsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WPO_PRNo_QDetailsTableControlRow = DirectCast(repItem.FindControl("WPO_PRNo_QDetailsTableControlRow"), WPO_PRNo_QDetailsTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetPRNoLabel()
                SetWPRD_CreatedLabel()
                SetWPRD_TitleLabel()
                SetWPRD_TotalLabel()
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
        

            ' Bind the buttons for WPO_PRNo_QDetailsTableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WPO_PRNo_QDetailsTableControlRow
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
            WPO_PRNo_QDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WPO_PRNo_QDetails1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
        
          Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
        
          Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
        
          Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
        
          Dim hasFiltersWPOP10100RecordControl As Boolean = False
        
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_PRNo_QDetailsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WPO_PRNo_QDetailsTableControlRow = DirectCast(repItem.FindControl("WPO_PRNo_QDetailsTableControlRow"), WPO_PRNo_QDetailsTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WPO_PRNo_QDetails1Record = New WPO_PRNo_QDetails1Record()
        
                        If recControl.Comment.Text <> "" Then
                            rec.Parse(recControl.Comment.Text, WPO_PRNo_QDetails1View.Comment)
                        End If
                        If recControl.PRNo.Text <> "" Then
                            rec.Parse(recControl.PRNo.Text, WPO_PRNo_QDetails1View.PRNo)
                        End If
                        If recControl.WPRD_Created.Text <> "" Then
                            rec.Parse(recControl.WPRD_Created.Text, WPO_PRNo_QDetails1View.WPRD_Created)
                        End If
                        If recControl.WPRD_ID.Text <> "" Then
                            rec.Parse(recControl.WPRD_ID.Text, WPO_PRNo_QDetails1View.WPRD_ID)
                        End If
                        If recControl.WPRD_Title.Text <> "" Then
                            rec.Parse(recControl.WPRD_Title.Text, WPO_PRNo_QDetails1View.WPRD_Title)
                        End If
                        If recControl.WPRD_Total.Text <> "" Then
                            rec.Parse(recControl.WPRD_Total.Text, WPO_PRNo_QDetails1View.WPRD_Total)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WPO_PRNo_QDetails1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WPO_PRNo_QDetails1Record)), WPO_PRNo_QDetails1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WPO_PRNo_QDetailsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WPO_PRNo_QDetailsTableControlRow) As Boolean
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
        
        Public Overridable Sub SetPRNoLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.PRNoLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPRD_CreatedLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPRD_CreatedLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPRD_TitleLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPRD_TitleLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPRD_TotalLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPRD_TotalLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WPO_PRNo_QDetailsTableControl_OrderBy"), String)
          
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
                Me.ViewState("WPO_PRNo_QDetailsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WPO_PRNo_QDetails1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WPO_PRNo_QDetails1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WPO_PRNo_QDetails1Record())
            End Get
            Set(ByVal value() As WPO_PRNo_QDetails1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property PRNoLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PRNoLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPRD_CreatedLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRD_CreatedLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPRD_TitleLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRD_TitleLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPRD_TotalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRD_TotalLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WPO_PRNo_QDetailsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WPO_PRNo_QDetails1Record = Nothing     
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
                Dim recCtl As WPO_PRNo_QDetailsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WPO_PRNo_QDetails1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WPO_PRNo_QDetailsTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WPO_PRNo_QDetailsTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WPO_PRNo_QDetailsTableControlRow)), WPO_PRNo_QDetailsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WPO_PRNo_QDetailsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WPO_PRNo_QDetailsTableControlRow
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

        Public Overridable Function GetRecordControls() As WPO_PRNo_QDetailsTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WPO_PRNo_QDetailsTableControlRow")
            Dim list As New List(Of WPO_PRNo_QDetailsTableControlRow)
            For Each recCtrl As WPO_PRNo_QDetailsTableControlRow In recCtrls
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

  
' Base class for the WPO_WFHistory_Details_newTableControlRow control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPO_WFHistory_Details_newTableControlRow.
Public Class BaseWPO_WFHistory_Details_newTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WPO_WFHistory_Details_newTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WPO_WFHistory_Details_newTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WPO_WFHistory_Details_new1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWPO_WFHistory_Details_newTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WPO_WFHistory_Details_new1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WPO_WFHistory_Details_newTableControlRow.
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
        
                SetWPO_Date_Action()
                SetWPO_Date_Assign()
                SetWPO_Remark()
                SetWPO_Status()
                SetWPO_W_U_ID()
                SetWPO_WS_ID()
      
      
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
        
        
        Public Overridable Sub SetWPO_Date_Action()

                  
            
        
            ' Set the WPO_Date_Action Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new record retrieved from the database.
            ' Me.WPO_Date_Action is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_Date_ActionSpecified Then
                				
                ' If the WPO_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_WFHistory_Details_new1View.WPO_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_Date_Action.Text = formattedValue
                
            Else 
            
                ' WPO_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_Date_Action.Text = WPO_WFHistory_Details_new1View.WPO_Date_Action.Format(WPO_WFHistory_Details_new1View.WPO_Date_Action.DefaultValue, "g")
                        		
                End If
                 
            ' If the WPO_Date_Action is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_Date_Action.Text Is Nothing _
                OrElse Me.WPO_Date_Action.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_Date_Action.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_Date_Assign()

                  
            
        
            ' Set the WPO_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new record retrieved from the database.
            ' Me.WPO_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_Date_AssignSpecified Then
                				
                ' If the WPO_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_WFHistory_Details_new1View.WPO_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_Date_Assign.Text = formattedValue
                
            Else 
            
                ' WPO_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_Date_Assign.Text = WPO_WFHistory_Details_new1View.WPO_Date_Assign.Format(WPO_WFHistory_Details_new1View.WPO_Date_Assign.DefaultValue, "g")
                        		
                End If
                 
            ' If the WPO_Date_Assign is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_Date_Assign.Text Is Nothing _
                OrElse Me.WPO_Date_Assign.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_Date_Assign.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_Remark()

                  
            
        
            ' Set the WPO_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new record retrieved from the database.
            ' Me.WPO_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_RemarkSpecified Then
                				
                ' If the WPO_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPO_WFHistory_Details_new1View.WPO_Remark)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(WPO_WFHistory_Details_new1View.WPO_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WPO_WFHistory_Details_new1View, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WPO_Remark\"", \""WPO_Remark\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
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
                
                Me.WPO_Remark.Text = formattedValue
                
            Else 
            
                ' WPO_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_Remark.Text = WPO_WFHistory_Details_new1View.WPO_Remark.Format(WPO_WFHistory_Details_new1View.WPO_Remark.DefaultValue)
                        		
                End If
                 
            ' If the WPO_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_Remark.Text Is Nothing _
                OrElse Me.WPO_Remark.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_Remark.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_Status()

                  
            
        
            ' Set the WPO_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new record retrieved from the database.
            ' Me.WPO_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_StatusSpecified Then
                				
                ' If the WPO_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WPO_WFHistory_Details_new1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPO_WFHistory_Details_new1View.WPO_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WPO_WFHistory_Details_new1View.WPO_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WPO_WFHistory_Details_new1View.GetDFKA(Me.DataSource.WPO_Status.ToString(),WPO_WFHistory_Details_new1View.WPO_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WPO_WFHistory_Details_new1View.WPO_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WPO_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_Status.Text = formattedValue
                
            Else 
            
                ' WPO_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_Status.Text = WPO_WFHistory_Details_new1View.WPO_Status.Format(WPO_WFHistory_Details_new1View.WPO_Status.DefaultValue)
                        		
                End If
                 
            ' If the WPO_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_Status.Text Is Nothing _
                OrElse Me.WPO_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_W_U_ID()

                  
            
        
            ' Set the WPO_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new record retrieved from the database.
            ' Me.WPO_W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_W_U_IDSpecified Then
                				
                ' If the WPO_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WPO_WFHistory_Details_new1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPO_WFHistory_Details_new1View.WPO_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WPO_WFHistory_Details_new1View.WPO_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WPO_WFHistory_Details_new1View.GetDFKA(Me.DataSource.WPO_W_U_ID.ToString(),WPO_WFHistory_Details_new1View.WPO_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WPO_WFHistory_Details_new1View.WPO_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WPO_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_W_U_ID.Text = formattedValue
                
            Else 
            
                ' WPO_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_W_U_ID.Text = WPO_WFHistory_Details_new1View.WPO_W_U_ID.Format(WPO_WFHistory_Details_new1View.WPO_W_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the WPO_W_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_W_U_ID.Text Is Nothing _
                OrElse Me.WPO_W_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_W_U_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_WS_ID()

                  
            
        
            ' Set the WPO_WS_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPO_WFHistory_Details_new record retrieved from the database.
            ' Me.WPO_WS_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_WS_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_WS_IDSpecified Then
                				
                ' If the WPO_WS_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WPO_WFHistory_Details_new1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPO_WFHistory_Details_new1View.WPO_WS_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WPO_WFHistory_Details_new1View.WPO_WS_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WPO_WFHistory_Details_new1View.GetDFKA(Me.DataSource.WPO_WS_ID.ToString(),WPO_WFHistory_Details_new1View.WPO_WS_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WPO_WFHistory_Details_new1View.WPO_WS_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WPO_WS_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_WS_ID.Text = formattedValue
                
            Else 
            
                ' WPO_WS_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_WS_ID.Text = WPO_WFHistory_Details_new1View.WPO_WS_ID.Format(WPO_WFHistory_Details_new1View.WPO_WS_ID.DefaultValue)
                        		
                End If
                 
            ' If the WPO_WS_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_WS_ID.Text Is Nothing _
                OrElse Me.WPO_WS_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_WS_ID.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in WPO_WFHistory_Details_newTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WPO_WFHistory_Details_newTableControl"), WPO_WFHistory_Details_newTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WPO_WFHistory_Details_newTableControl"), WPO_WFHistory_Details_newTableControl).ResetData = True
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

        ' To customize, override this method in WPO_WFHistory_Details_newTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWPO_Date_Action()
            GetWPO_Date_Assign()
            GetWPO_Remark()
            GetWPO_Status()
            GetWPO_W_U_ID()
            GetWPO_WS_ID()
        End Sub
        
        
        Public Overridable Sub GetWPO_Date_Action()
            
        End Sub
                
        Public Overridable Sub GetWPO_Date_Assign()
            
        End Sub
                
        Public Overridable Sub GetWPO_Remark()
            
        End Sub
                
        Public Overridable Sub GetWPO_Status()
            
        End Sub
                
        Public Overridable Sub GetWPO_W_U_ID()
            
        End Sub
                
        Public Overridable Sub GetWPO_WS_ID()
            
        End Sub
                
      
        ' To customize, override this method in WPO_WFHistory_Details_newTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WPO_WFHistory_Details_newTableControlRow.
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
          WPO_WFHistory_Details_new1View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WPO_WFHistory_Details_newTableControl"), WPO_WFHistory_Details_newTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WPO_WFHistory_Details_newTableControl"), WPO_WFHistory_Details_newTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWPO_WFHistory_Details_newTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWPO_WFHistory_Details_newTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WPO_WFHistory_Details_new1Record
            Get
                Return DirectCast(MyBase._DataSource, WPO_WFHistory_Details_new1Record)
            End Get
            Set(ByVal value As WPO_WFHistory_Details_new1Record)
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
        
        Public ReadOnly Property WPO_Date_Action() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Date_Action"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_Date_Assign() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Date_Assign"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Remark"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_W_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_W_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_WS_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WS_ID"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WPO_WFHistory_Details_new1Record = Nothing
             
        
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
            
            Dim rec As WPO_WFHistory_Details_new1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WPO_WFHistory_Details_new1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WPO_WFHistory_Details_new1View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WPO_WFHistory_Details_newTableControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPO_WFHistory_Details_newTableControl.
Public Class BaseWPO_WFHistory_Details_newTableControl
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WPO_WFHistory_Details_new1Record)), WPO_WFHistory_Details_new1Record())
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
                    For Each rc As WPO_WFHistory_Details_newTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WPO_WFHistory_Details_new1Record)), WPO_WFHistory_Details_new1Record())
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
            ByVal pageSize As Integer) As WPO_WFHistory_Details_new1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WPO_WFHistory_Details_new1View.Column1, True)         
            ' selCols.Add(WPO_WFHistory_Details_new1View.Column2, True)          
            ' selCols.Add(WPO_WFHistory_Details_new1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WPO_WFHistory_Details_new1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WPO_WFHistory_Details_new1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WPO_WFHistory_Details_new1Record)), WPO_WFHistory_Details_new1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WPO_WFHistory_Details_new1View.Column1, True)         
            ' selCols.Add(WPO_WFHistory_Details_new1View.Column2, True)          
            ' selCols.Add(WPO_WFHistory_Details_new1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WPO_WFHistory_Details_new1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WPO_WFHistory_Details_new1View
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WFHistory_Details_newTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WPO_WFHistory_Details_newTableControlRow = DirectCast(repItem.FindControl("WPO_WFHistory_Details_newTableControlRow"), WPO_WFHistory_Details_newTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetWPO_Date_ActionLabel()
                SetWPO_Date_AssignLabel()
                SetWPO_RemarkLabel()
                SetWPO_StatusLabel()
                SetWPO_W_U_IDLabel()
                SetWPO_WS_IDLabel()
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
          
            Me.Page.PregetDfkaRecords(WPO_WFHistory_Details_new1View.WPO_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WPO_WFHistory_Details_new1View.WPO_W_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WPO_WFHistory_Details_new1View.WPO_WS_ID, Me.DataSource)
          
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
        

            ' Bind the buttons for WPO_WFHistory_Details_newTableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WPO_WFHistory_Details_newTableControlRow
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
            WPO_WFHistory_Details_new1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WPO_WFHistory_Details_new1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
        
          Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
        
          Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
        
          Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
        
          Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
        
          Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
        
          Dim hasFiltersWPOP10100RecordControl As Boolean = False
        
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WFHistory_Details_newTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WPO_WFHistory_Details_newTableControlRow = DirectCast(repItem.FindControl("WPO_WFHistory_Details_newTableControlRow"), WPO_WFHistory_Details_newTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WPO_WFHistory_Details_new1Record = New WPO_WFHistory_Details_new1Record()
        
                        If recControl.WPO_Date_Action.Text <> "" Then
                            rec.Parse(recControl.WPO_Date_Action.Text, WPO_WFHistory_Details_new1View.WPO_Date_Action)
                        End If
                        If recControl.WPO_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.WPO_Date_Assign.Text, WPO_WFHistory_Details_new1View.WPO_Date_Assign)
                        End If
                        If recControl.WPO_Remark.Text <> "" Then
                            rec.Parse(recControl.WPO_Remark.Text, WPO_WFHistory_Details_new1View.WPO_Remark)
                        End If
                        If recControl.WPO_Status.Text <> "" Then
                            rec.Parse(recControl.WPO_Status.Text, WPO_WFHistory_Details_new1View.WPO_Status)
                        End If
                        If recControl.WPO_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.WPO_W_U_ID.Text, WPO_WFHistory_Details_new1View.WPO_W_U_ID)
                        End If
                        If recControl.WPO_WS_ID.Text <> "" Then
                            rec.Parse(recControl.WPO_WS_ID.Text, WPO_WFHistory_Details_new1View.WPO_WS_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WPO_WFHistory_Details_new1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WPO_WFHistory_Details_new1Record)), WPO_WFHistory_Details_new1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WPO_WFHistory_Details_newTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WPO_WFHistory_Details_newTableControlRow) As Boolean
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
        
        Public Overridable Sub SetWPO_Date_ActionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_Date_ActionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_Date_AssignLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_Date_AssignLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_RemarkLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_W_U_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_W_U_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_WS_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_WS_IDLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WPO_WFHistory_Details_newTableControl_OrderBy"), String)
          
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
                Me.ViewState("WPO_WFHistory_Details_newTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                    _TotalRecords = WPO_WFHistory_Details_new1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WPO_WFHistory_Details_new1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WPO_WFHistory_Details_new1Record())
            End Get
            Set(ByVal value() As WPO_WFHistory_Details_new1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property WPO_Date_ActionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Date_ActionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_Date_AssignLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Date_AssignLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_W_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_WS_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WS_IDLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WPO_WFHistory_Details_newTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WPO_WFHistory_Details_new1Record = Nothing     
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
                Dim recCtl As WPO_WFHistory_Details_newTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WPO_WFHistory_Details_new1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WPO_WFHistory_Details_newTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WPO_WFHistory_Details_newTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WPO_WFHistory_Details_newTableControlRow)), WPO_WFHistory_Details_newTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WPO_WFHistory_Details_newTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WPO_WFHistory_Details_newTableControlRow
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

        Public Overridable Function GetRecordControls() As WPO_WFHistory_Details_newTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WPO_WFHistory_Details_newTableControlRow")
            Dim list As New List(Of WPO_WFHistory_Details_newTableControlRow)
            For Each recCtrl As WPO_WFHistory_Details_newTableControlRow In recCtrls
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

  
' Base class for the Sel_WPO_WFTaskActivity_RemarksRecordControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in Sel_WPO_WFTaskActivity_RemarksRecordControl.
Public Class BaseSel_WPO_WFTaskActivity_RemarksRecordControl
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_WPO_WFTaskActivity_RemarksRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

      
            ' Setup the filter and search events.
            
        End Sub

        '  To customize, override this method in Sel_WPO_WFTaskActivity_RemarksRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.WPO_Remark1.TextChanged, AddressOf WPO_Remark1_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.sel_WPO_WFTaskActivity_Remarks record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Sel_WPO_WFTaskActivity_RemarksView.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskActivity_RemarksRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New Sel_WPO_WFTaskActivity_RemarksRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As Sel_WPO_WFTaskActivity_RemarksRecord = Sel_WPO_WFTaskActivity_RemarksView.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = Sel_WPO_WFTaskActivity_RemarksView.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_WPO_WFTaskActivity_RemarksRecordControl.
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
        
                SetWPO_Remark1()
                SetWPO_RemarkLabel1()
      
      
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
        
        
        Public Overridable Sub SetWPO_Remark1()

                  
            
        
            ' Set the WPO_Remark TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTaskActivity_Remarks database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTaskActivity_Remarks record retrieved from the database.
            ' Me.WPO_Remark1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_Remark1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_RemarkSpecified Then
                				
                ' If the WPO_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTaskActivity_RemarksView.WPO_Remark)
                              
                Me.WPO_Remark1.Text = formattedValue
                
            Else 
            
                ' WPO_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_Remark1.Text = Sel_WPO_WFTaskActivity_RemarksView.WPO_Remark.Format(Sel_WPO_WFTaskActivity_RemarksView.WPO_Remark.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WPO_Remark1.TextChanged, AddressOf WPO_Remark1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWPO_RemarkLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_RemarkLabel1.Text = "Some value"
                    
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

      
        
        ' To customize, override this method in Sel_WPO_WFTaskActivity_RemarksRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskActivity_RemarksRecordControlPanel"), System.Web.UI.WebControls.Panel)

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
          
        End Sub

        ' To customize, override this method in Sel_WPO_WFTaskActivity_RemarksRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWPO_Remark1()
        End Sub
        
        
        Public Overridable Sub GetWPO_Remark1()
            
        End Sub
                
      
        ' To customize, override this method in Sel_WPO_WFTaskActivity_RemarksRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Dim wc As WhereClause
            Sel_WPO_WFTaskActivity_RemarksView.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
                  Dim recId As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString.Item("Sel_WPO_WFTaskActivity_Remarks"))
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "ePortalWFApproval").Replace("{URL}", "Sel_WPO_WFTaskActivity_Remarks"))
            End If
            HttpContext.Current.Session("QueryString in WPO-WFTaskN") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(Sel_WPO_WFTaskActivity_RemarksView.WPOP_PONMBR, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Sel_WPO_WFTaskActivity_RemarksView.WPOP_PONMBR))
        
                wc.iAND(Sel_WPO_WFTaskActivity_RemarksView.WPOP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(Sel_WPO_WFTaskActivity_RemarksView.WPOP_C_ID))
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(Sel_WPO_WFTaskActivity_RemarksView.WPOP_PONMBR, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
                wc.iAND(Sel_WPO_WFTaskActivity_RemarksView.WPOP_C_ID, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            Sel_WPO_WFTaskActivity_RemarksView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
              
                Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
              
                Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
              
                Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
              
                Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
              
                Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
              
                Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
              
                Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
              
                Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
              
                Dim hasFiltersWPOP10100RecordControl As Boolean = False
              
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
        
    

        ' To customize, override this method in Sel_WPO_WFTaskActivity_RemarksRecordControl.
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
          Sel_WPO_WFTaskActivity_RemarksView.DeleteRecord(pkValue)
          
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
        
        Protected Overridable Sub WPO_Remark1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseSel_WPO_WFTaskActivity_RemarksRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSel_WPO_WFTaskActivity_RemarksRecordControl_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As Sel_WPO_WFTaskActivity_RemarksRecord
            Get
                Return DirectCast(MyBase._DataSource, Sel_WPO_WFTaskActivity_RemarksRecord)
            End Get
            Set(ByVal value As Sel_WPO_WFTaskActivity_RemarksRecord)
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
        
        Public ReadOnly Property WPO_Remark1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Remark1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WPO_RemarkLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_RemarkLabel1"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As Sel_WPO_WFTaskActivity_RemarksRecord = Nothing
             
        
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
            
            Dim rec As Sel_WPO_WFTaskActivity_RemarksRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Sel_WPO_WFTaskActivity_RemarksRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Sel_WPO_WFTaskActivity_RemarksView.GetRecord(Me.RecordUniqueId, True)
                
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

  
' Base class for the Sel_WPO_WFTaskRecordControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in Sel_WPO_WFTaskRecordControl.
Public Class BaseSel_WPO_WFTaskRecordControl
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_WPO_WFTaskRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

      
            ' Setup the filter and search events.
            
        End Sub

        '  To customize, override this method in Sel_WPO_WFTaskRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.Button.Button.Click, AddressOf Button_Click
                        
              AddHandler Me.CompanyID2.TextChanged, AddressOf CompanyID2_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Sel_WPO_WFTask1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New Sel_WPO_WFTask1Record()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As Sel_WPO_WFTask1Record = Sel_WPO_WFTask1View.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = Sel_WPO_WFTask1View.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_WPO_WFTaskRecordControl.
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
        
                
                
                SetBUYERID()
                SetBUYERIDLabel()
                SetBUYERIDLabel1()
                
                
                SetCompanyID()
                SetCompanyID2()
                SetCompanyIDLabel()
                SetDOCDATE()
                SetDOCDATELabel()
                SetFRTAMNT1()
                SetFRTAMNTLabel()
                SetLabel()
                SetLiteral1()
                SetLiteral2()
                SetLiteral3()
                SetLiteral4()
                SetLiteral5()
                SetLiteral7()
                SetLiteral8()
                SetlitPaymentTerms()
                SetlitSpace()
                SetMSCCHAMT()
                SetMSCCHAMTLabel()
                SetPODetailsContainer()
                
                SetPONUMBER()
                SetPONUMBERLabel()
                
                
                
                
                SetSUBTOTAL1()
                SetSUBTOTALLabel()
                SetTAXAMNT()
                SetTAXAMNTLabel()
                SetTOTAL()
                SetTOTALLabel()
                SetTRDISAMT()
                SetTRDISAMTLabel()
                SetVENDNAME()
                SetVENDNAMELabel()
                
                
                
                
                
                
                
                SetButton()
              
      
      
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
            
        SetSel_WPO_InquireDetailsTableControl()
        
        SetSel_WPO_WFTaskActivity_RemarksRecordControl()
        
        SetView_WCPO_Canvass1TableControl()
        
        SetWPO_CARNo_QDetailsTableControl()
        
        SetWPO_Doc_AttachTableControl()
        
        SetWPO_PRNo_QDetailsTableControl()
        
        SetWPO_WFHistory_Details_newTableControl()
        
        SetWPOP10100RecordControl()
        
        End Sub
        
        
        Public Overridable Sub SetBUYERID()

                  
            
        
            ' Set the BUYERID Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.BUYERID is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetBUYERID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.BUYERIDSpecified Then
                				
                ' If the BUYERID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.BUYERID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.BUYERID.Text = formattedValue
                
            Else 
            
                ' BUYERID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.BUYERID.Text = Sel_WPO_WFTask1View.BUYERID.Format(Sel_WPO_WFTask1View.BUYERID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetCompanyID()

                  
            
        
            ' Set the CompanyID Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.CompanyID is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCompanyID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CompanyIDSpecified Then
                				
                ' If the CompanyID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WPO_WFTask1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WPO_WFTask1View.CompanyID)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WPO_WFTask1View.CompanyID.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WPO_WFTask1View.GetDFKA(Me.DataSource.CompanyID.ToString(),Sel_WPO_WFTask1View.CompanyID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WPO_WFTask1View.CompanyID)
                       End If
                Else
                       formattedValue = Me.DataSource.CompanyID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.CompanyID.Text = formattedValue
                
            Else 
            
                ' CompanyID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.CompanyID.Text = Sel_WPO_WFTask1View.CompanyID.Format(Sel_WPO_WFTask1View.CompanyID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetCompanyID2()

                  
            
        
            ' Set the CompanyID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.CompanyID2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCompanyID2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.CompanyIDSpecified Then
                				
                ' If the CompanyID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.CompanyID.ToString()
                                
                            
                Me.CompanyID2.Text = formattedValue
                
            Else 
            
                ' CompanyID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.CompanyID2.Text = Sel_WPO_WFTask1View.CompanyID.DefaultValue		
                End If
                 
              AddHandler Me.CompanyID2.TextChanged, AddressOf CompanyID2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetDOCDATE()

                  
            
        
            ' Set the DOCDATE Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.DOCDATE is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDOCDATE()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DOCDATESpecified Then
                				
                ' If the DOCDATE is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.DOCDATE, "d")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DOCDATE.Text = formattedValue
                
            Else 
            
                ' DOCDATE is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.DOCDATE.Text = Sel_WPO_WFTask1View.DOCDATE.Format(Sel_WPO_WFTask1View.DOCDATE.DefaultValue, "d")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetFRTAMNT1()

                  
            
        
            ' Set the FRTAMNT Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.FRTAMNT1 is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFRTAMNT1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FRTAMNTSpecified Then
                				
                ' If the FRTAMNT is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.FRTAMNT, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FRTAMNT1.Text = formattedValue
                
            Else 
            
                ' FRTAMNT is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FRTAMNT1.Text = Sel_WPO_WFTask1View.FRTAMNT.Format(Sel_WPO_WFTask1View.FRTAMNT.DefaultValue, "#,#.00")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetMSCCHAMT()

                  
            
        
            ' Set the MSCCHAMT Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.MSCCHAMT is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetMSCCHAMT()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.MSCCHAMTSpecified Then
                				
                ' If the MSCCHAMT is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.MSCCHAMT, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.MSCCHAMT.Text = formattedValue
                
            Else 
            
                ' MSCCHAMT is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.MSCCHAMT.Text = Sel_WPO_WFTask1View.MSCCHAMT.Format(Sel_WPO_WFTask1View.MSCCHAMT.DefaultValue, "#,#.00")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetPONUMBER()

                  
            
        
            ' Set the PONUMBER Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.PONUMBER is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPONUMBER()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PONUMBERSpecified Then
                				
                ' If the PONUMBER is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.PONUMBER)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PONUMBER.Text = formattedValue
                
            Else 
            
                ' PONUMBER is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.PONUMBER.Text = Sel_WPO_WFTask1View.PONUMBER.Format(Sel_WPO_WFTask1View.PONUMBER.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetSUBTOTAL1()

                  
            
        
            ' Set the SUBTOTAL Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.SUBTOTAL1 is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSUBTOTAL1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SUBTOTALSpecified Then
                				
                ' If the SUBTOTAL is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.SUBTOTAL, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SUBTOTAL1.Text = formattedValue
                
            Else 
            
                ' SUBTOTAL is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.SUBTOTAL1.Text = Sel_WPO_WFTask1View.SUBTOTAL.Format(Sel_WPO_WFTask1View.SUBTOTAL.DefaultValue, "#,#.00")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetTAXAMNT()

                  
            
        
            ' Set the TAXAMNT Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.TAXAMNT is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTAXAMNT()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TAXAMNTSpecified Then
                				
                ' If the TAXAMNT is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.TAXAMNT, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TAXAMNT.Text = formattedValue
                
            Else 
            
                ' TAXAMNT is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.TAXAMNT.Text = Sel_WPO_WFTask1View.TAXAMNT.Format(Sel_WPO_WFTask1View.TAXAMNT.DefaultValue, "#,#.00")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetTOTAL()

                  
            
        
            ' Set the TOTAL Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.TOTAL is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTOTAL()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TOTALSpecified Then
                				
                ' If the TOTAL is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.TOTAL, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TOTAL.Text = formattedValue
                
            Else 
            
                ' TOTAL is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.TOTAL.Text = Sel_WPO_WFTask1View.TOTAL.Format(Sel_WPO_WFTask1View.TOTAL.DefaultValue, "#,#.00")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetTRDISAMT()

                  
            
        
            ' Set the TRDISAMT Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.TRDISAMT is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTRDISAMT()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TRDISAMTSpecified Then
                				
                ' If the TRDISAMT is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.TRDISAMT, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TRDISAMT.Text = formattedValue
                
            Else 
            
                ' TRDISAMT is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.TRDISAMT.Text = Sel_WPO_WFTask1View.TRDISAMT.Format(Sel_WPO_WFTask1View.TRDISAMT.DefaultValue, "#,#.00")
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetVENDNAME()

                  
            
        
            ' Set the VENDNAME Label on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WPO_WFTask database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record retrieved from the database.
            ' Me.VENDNAME is the ASP:Label on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetVENDNAME()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.VENDNAMESpecified Then
                				
                ' If the VENDNAME is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WPO_WFTask1View.VENDNAME)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.VENDNAME.Text = formattedValue
                
            Else 
            
                ' VENDNAME is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.VENDNAME.Text = Sel_WPO_WFTask1View.VENDNAME.Format(Sel_WPO_WFTask1View.VENDNAME.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetBUYERIDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.BUYERIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetBUYERIDLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.BUYERIDLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetCompanyIDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetDOCDATELabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.DOCDATELabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFRTAMNTLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FRTAMNTLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Label.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral2()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral3()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral4()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral5()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral7()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral8()

                  
                  
                  End Sub
                
        Public Overridable Sub SetlitPaymentTerms()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litPaymentTerms.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitSpace()

                  
                  
                  End Sub
                
        Public Overridable Sub SetMSCCHAMTLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.MSCCHAMTLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetPONUMBERLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSUBTOTALLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SUBTOTALLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetTAXAMNTLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.TAXAMNTLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetTOTALLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetTRDISAMTLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.TRDISAMTLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetVENDNAMELabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.VENDNAMELabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetPODetailsContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "PODetailsContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "PODetailsContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetSel_WPO_InquireDetailsTableControl()           
        
        
            If Sel_WPO_InquireDetailsTableControl.Visible Then
                Sel_WPO_InquireDetailsTableControl.LoadData()
                Sel_WPO_InquireDetailsTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetSel_WPO_WFTaskActivity_RemarksRecordControl()           
        
        
            If Sel_WPO_WFTaskActivity_RemarksRecordControl.Visible Then
                Sel_WPO_WFTaskActivity_RemarksRecordControl.LoadData()
                Sel_WPO_WFTaskActivity_RemarksRecordControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetView_WCPO_Canvass1TableControl()           
        
        
            If View_WCPO_Canvass1TableControl.Visible Then
                View_WCPO_Canvass1TableControl.LoadData()
                View_WCPO_Canvass1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWPO_CARNo_QDetailsTableControl()           
        
        
            If WPO_CARNo_QDetailsTableControl.Visible Then
                WPO_CARNo_QDetailsTableControl.LoadData()
                WPO_CARNo_QDetailsTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWPO_Doc_AttachTableControl()           
        
        
            If WPO_Doc_AttachTableControl.Visible Then
                WPO_Doc_AttachTableControl.LoadData()
                WPO_Doc_AttachTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWPO_PRNo_QDetailsTableControl()           
        
        
            If WPO_PRNo_QDetailsTableControl.Visible Then
                WPO_PRNo_QDetailsTableControl.LoadData()
                WPO_PRNo_QDetailsTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWPO_WFHistory_Details_newTableControl()           
        
        
            If WPO_WFHistory_Details_newTableControl.Visible Then
                WPO_WFHistory_Details_newTableControl.LoadData()
                WPO_WFHistory_Details_newTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWPOP10100RecordControl()           
        
        
            If WPOP10100RecordControl.Visible Then
                WPOP10100RecordControl.LoadData()
                WPOP10100RecordControl.DataBind()
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

      
        
        ' To customize, override this method in Sel_WPO_WFTaskRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskRecordControlPanel"), System.Web.UI.WebControls.Panel)

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
          
        Dim recSel_WPO_InquireDetailsTableControl as Sel_WPO_InquireDetailsTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetailsTableControl"), Sel_WPO_InquireDetailsTableControl)
        recSel_WPO_InquireDetailsTableControl.SaveData()
          
        Dim recSel_WPO_WFTaskActivity_RemarksRecordControl as Sel_WPO_WFTaskActivity_RemarksRecordControl= DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskActivity_RemarksRecordControl"), Sel_WPO_WFTaskActivity_RemarksRecordControl)
        recSel_WPO_WFTaskActivity_RemarksRecordControl.SaveData()
          
        Dim recView_WCPO_Canvass1TableControl as View_WCPO_Canvass1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "View_WCPO_Canvass1TableControl"), View_WCPO_Canvass1TableControl)
        recView_WCPO_Canvass1TableControl.SaveData()
          
        Dim recWPO_CARNo_QDetailsTableControl as WPO_CARNo_QDetailsTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WPO_CARNo_QDetailsTableControl"), WPO_CARNo_QDetailsTableControl)
        recWPO_CARNo_QDetailsTableControl.SaveData()
          
        Dim recWPO_Doc_AttachTableControl as WPO_Doc_AttachTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WPO_Doc_AttachTableControl"), WPO_Doc_AttachTableControl)
        recWPO_Doc_AttachTableControl.SaveData()
          
        Dim recWPO_PRNo_QDetailsTableControl as WPO_PRNo_QDetailsTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WPO_PRNo_QDetailsTableControl"), WPO_PRNo_QDetailsTableControl)
        recWPO_PRNo_QDetailsTableControl.SaveData()
          
        Dim recWPO_WFHistory_Details_newTableControl as WPO_WFHistory_Details_newTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WPO_WFHistory_Details_newTableControl"), WPO_WFHistory_Details_newTableControl)
        recWPO_WFHistory_Details_newTableControl.SaveData()
          
        Dim recWPOP10100RecordControl as WPOP10100RecordControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), WPOP10100RecordControl)
        recWPOP10100RecordControl.SaveData()
          
        End Sub

        ' To customize, override this method in Sel_WPO_WFTaskRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetBUYERID()
            GetCompanyID()
            GetCompanyID2()
            GetDOCDATE()
            GetFRTAMNT1()
            GetMSCCHAMT()
            GetPONUMBER()
            GetSUBTOTAL1()
            GetTAXAMNT()
            GetTOTAL()
            GetTRDISAMT()
            GetVENDNAME()
        End Sub
        
        
        Public Overridable Sub GetBUYERID()
            
        End Sub
                
        Public Overridable Sub GetCompanyID()
            
        End Sub
                
        Public Overridable Sub GetCompanyID2()
            
            ' Retrieve the value entered by the user on the CompanyID ASP:TextBox, and
            ' save it into the CompanyID field in DataSource DatabaseANFLO-WFN%dbo.sel_WPO_WFTask record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.CompanyID2.Text, Sel_WPO_WFTask1View.CompanyID)			

                      
        End Sub
                
        Public Overridable Sub GetDOCDATE()
            
        End Sub
                
        Public Overridable Sub GetFRTAMNT1()
            
        End Sub
                
        Public Overridable Sub GetMSCCHAMT()
            
        End Sub
                
        Public Overridable Sub GetPONUMBER()
            
        End Sub
                
        Public Overridable Sub GetSUBTOTAL1()
            
        End Sub
                
        Public Overridable Sub GetTAXAMNT()
            
        End Sub
                
        Public Overridable Sub GetTOTAL()
            
        End Sub
                
        Public Overridable Sub GetTRDISAMT()
            
        End Sub
                
        Public Overridable Sub GetVENDNAME()
            
        End Sub
                
      
        ' To customize, override this method in Sel_WPO_WFTaskRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Dim wc As WhereClause
            Sel_WPO_WFTask1View.Instance.InnerFilter = Nothing
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
            
            If EvaluateFormula("URL(""POP10100_PO"")", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("ePortalWFApproval.Business.Sel_WPO_WFTask1View, App_Code").TableDefinition.ColumnList.GetByUniqueName("sel_WPO_WFTask_.PONUMBER"), EvaluateFormula("URL(""POP10100_PO"")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
            If EvaluateFormula("URL(""POP10100_Co"")", false) <> "" Then filter.AddFilter(New BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance("ePortalWFApproval.Business.Sel_WPO_WFTask1View, App_Code").TableDefinition.ColumnList.GetByUniqueName("sel_WPO_WFTask_.CompanyID"), EvaluateFormula("URL(""POP10100_Co"")", false), BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
         If (EvaluateFormula("URL(""POP10100_PO"")", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("URL(""POP10100_PO"")", false) = "--ANY--") Then whereClause.RunQuery = False
         If (EvaluateFormula("URL(""POP10100_Co"")", false) = "--PLEASE_SELECT--" OrElse EvaluateFormula("URL(""POP10100_Co"")", false) = "--ANY--") Then whereClause.RunQuery = False

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator)
    
            Return whereClause
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            Sel_WPO_WFTask1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
              
                Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
              
                Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
              
                Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
              
                Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
              
                Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
              
                Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
              
                Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
              
                Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
              
                Dim hasFiltersWPOP10100RecordControl As Boolean = False
              
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
        
    

        ' To customize, override this method in Sel_WPO_WFTaskRecordControl.
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
          Sel_WPO_WFTask1View.DeleteRecord(pkValue)
          
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
        
        Public Overridable Sub SetButton()                
              
   
        End Sub
            
        ' event handler for Button
        Public Overridable Sub Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        
        Protected Overridable Sub CompanyID2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseSel_WPO_WFTaskRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSel_WPO_WFTaskRecordControl_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As Sel_WPO_WFTask1Record
            Get
                Return DirectCast(MyBase._DataSource, Sel_WPO_WFTask1Record)
            End Get
            Set(ByVal value As Sel_WPO_WFTask1Record)
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
        
        Public ReadOnly Property Button() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Button"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property BUYERID() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "BUYERID"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property BUYERIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "BUYERIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property BUYERIDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "BUYERIDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CompanyID() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CompanyID"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property CompanyID2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CompanyID2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property CompanyIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CompanyIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DOCDATE() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DOCDATE"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property DOCDATELabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DOCDATELabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FRTAMNT1() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FRTAMNT1"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property FRTAMNTLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FRTAMNTLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Label() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Label"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property Literal1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal2"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property Literal5() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal5"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal7() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal7"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal8() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal8"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litPaymentTerms() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litPaymentTerms"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litSpace() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litSpace"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property MSCCHAMT() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "MSCCHAMT"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property MSCCHAMTLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "MSCCHAMTLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property PODetailsContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PODetailsContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property PONUMBER() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PONUMBER"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property PONUMBERLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PONUMBERLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Sel_WPO_InquireDetailsTableControl() As Sel_WPO_InquireDetailsTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WPO_InquireDetailsTableControl"), Sel_WPO_InquireDetailsTableControl)
            End Get
        End Property
        
        Public ReadOnly Property Sel_WPO_WFTaskActivity_RemarksRecordControl() As Sel_WPO_WFTaskActivity_RemarksRecordControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskActivity_RemarksRecordControl"), Sel_WPO_WFTaskActivity_RemarksRecordControl)
            End Get
        End Property
        
        Public ReadOnly Property Sel_WPO_WFTaskTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WPO_WFTaskTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SUBTOTAL1() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SUBTOTAL1"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property SUBTOTALLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SUBTOTALLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TAXAMNT() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TAXAMNT"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property TAXAMNTLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TAXAMNTLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TOTAL() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TOTAL"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property TOTALLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TOTALLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TRDISAMT() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TRDISAMT"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property TRDISAMTLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TRDISAMTLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property VENDNAME() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "VENDNAME"), System.Web.UI.WebControls.Label)
            End Get
        End Property
            
        Public ReadOnly Property VENDNAMELabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "VENDNAMELabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property View_WCPO_Canvass1TableControl() As View_WCPO_Canvass1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "View_WCPO_Canvass1TableControl"), View_WCPO_Canvass1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WPO_CARNo_QDetailsTableControl() As WPO_CARNo_QDetailsTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_CARNo_QDetailsTableControl"), WPO_CARNo_QDetailsTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WPO_Doc_AttachTableControl() As WPO_Doc_AttachTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Doc_AttachTableControl"), WPO_Doc_AttachTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WPO_PRNo_QDetailsTableControl() As WPO_PRNo_QDetailsTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_PRNo_QDetailsTableControl"), WPO_PRNo_QDetailsTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WPO_WFHistory_Details_newTableControl() As WPO_WFHistory_Details_newTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WFHistory_Details_newTableControl"), WPO_WFHistory_Details_newTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WPOP10100RecordControl() As WPOP10100RecordControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControl"), WPOP10100RecordControl)
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
            
            Dim rec As Sel_WPO_WFTask1Record = Nothing
             
        
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
            
            Dim rec As Sel_WPO_WFTask1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Sel_WPO_WFTask1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Sel_WPO_WFTask1View.GetRecord(Me.RecordUniqueId, True)
                
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

  
' Base class for the WPOP10100RecordControl control on the WPO_WFTaskN page.
' Do not modify this class. Instead override any method in WPOP10100RecordControl.
Public Class BaseWPOP10100RecordControl
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WPOP10100RecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

      
            ' Setup the filter and search events.
            
        End Sub

        '  To customize, override this method in WPOP10100RecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.btnApprove.Click, AddressOf btnApprove_Click
                        
              AddHandler Me.btnReject.Click, AddressOf btnReject_Click
                        
              AddHandler Me.btnReturn.Click, AddressOf btnReturn_Click
                        
              AddHandler Me.WPOP_DT_ID1.SelectedIndexChanged, AddressOf WPOP_DT_ID1_SelectedIndexChanged
            
              AddHandler Me.WPOP_U_ID.SelectedIndexChanged, AddressOf WPOP_U_ID_SelectedIndexChanged
            
              AddHandler Me.WPOP_Remark.TextChanged, AddressOf WPOP_Remark_TextChanged
            
              AddHandler Me.ddlMoveTo.SelectedIndexChanged, AddressOf ddlMoveTo_SelectedIndexChanged
                
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WPOP10100 record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WPOP101001Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New WPOP101001Record()
            
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As WPOP101001Record = WPOP101001Table.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = CType(WPOP101001Record.Copy(recList(0), False), WPOP101001Record)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WPOP10100RecordControl.
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
                SetLiteral6()
                SetlitSpace1()
                SetlitSpace2()
                SetWPOP_DT_ID()
                SetWPOP_DT_ID1()
                SetWPOP_DT_IDLabel()
                SetWPOP_Remark()
                SetWPOP_RemarkLabel()
                SetWPOP_Status()
                SetWPOP_StatusLabel()
                SetWPOP_U_ID()
                SetWPOP10100RecordControlIcon()
                SetWPOP10100RecordControlPanelExtender()
                
                SetbtnApprove()
              
                SetbtnReject()
              
                SetbtnReturn()
              
      
      
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
        
        
        Public Overridable Sub SetWPOP_DT_ID()

                  
            
        
            ' Set the WPOP_DT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPOP10100 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPOP10100 record retrieved from the database.
            ' Me.WPOP_DT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPOP_DT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPOP_DT_IDSpecified Then
                				
                ' If the WPOP_DT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WPOP101001Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPOP101001Table.WPOP_DT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WPOP101001Table.WPOP_DT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WPOP101001Table.GetDFKA(Me.DataSource.WPOP_DT_ID.ToString(),WPOP101001Table.WPOP_DT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WPOP101001Table.WPOP_DT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WPOP_DT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPOP_DT_ID.Text = formattedValue
                
            Else 
            
                ' WPOP_DT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPOP_DT_ID.Text = WPOP101001Table.WPOP_DT_ID.Format(WPOP101001Table.WPOP_DT_ID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWPOP_DT_ID1()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WPOP_DT_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPOP10100 database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPOP10100 record retrieved from the database.
            ' Me.WPOP_DT_ID1 is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPOP_DT_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPOP_DT_IDSpecified Then
                            
                ' If the WPOP_DT_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WPOP_DT_ID.ToString()
            Else
                
                ' WPOP_DT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WPOP101001Table.WPOP_DT_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWPOP_DT_ID1DropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetWPOP_Remark()

                  
            
        
            ' Set the WPOP_Remark TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPOP10100 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPOP10100 record retrieved from the database.
            ' Me.WPOP_Remark is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPOP_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPOP_RemarkSpecified Then
                				
                ' If the WPOP_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WPOP101001Table.WPOP_Remark)
                              
                Me.WPOP_Remark.Text = formattedValue
                
            Else 
            
                ' WPOP_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPOP_Remark.Text = WPOP101001Table.WPOP_Remark.Format(WPOP101001Table.WPOP_Remark.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WPOP_Remark.TextChanged, AddressOf WPOP_Remark_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWPOP_Status()

                  
            
        
            ' Set the WPOP_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPOP10100 database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPOP10100 record retrieved from the database.
            ' Me.WPOP_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPOP_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPOP_StatusSpecified Then
                				
                ' If the WPOP_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WPOP101001Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPOP101001Table.WPOP_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WPOP101001Table.WPOP_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WPOP101001Table.GetDFKA(Me.DataSource.WPOP_Status.ToString(),WPOP101001Table.WPOP_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WPOP101001Table.WPOP_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WPOP_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPOP_Status.Text = formattedValue
                
            Else 
            
                ' WPOP_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPOP_Status.Text = WPOP101001Table.WPOP_Status.Format(WPOP101001Table.WPOP_Status.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWPOP_U_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WPOP_U_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WPOP10100 database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WPOP10100 record retrieved from the database.
            ' Me.WPOP_U_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPOP_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPOP_U_IDSpecified Then
                            
                ' If the WPOP_U_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WPOP_U_ID.ToString()
            Else
                
                ' WPOP_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WPOP101001Table.WPOP_U_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWPOP_U_IDDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                


        Public Overridable Sub SetddlMoveTo()

                  
            
            Me.PopulateddlMoveToDropDownList(Nothing, 100)
                
        End Sub
                
        Public Overridable Sub SetLiteral6()

                  
                  
                  End Sub
                
        Public Overridable Sub SetlitSpace1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litSpace1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitSpace2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litSpace2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPOP_DT_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPOP_DT_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPOP_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPOP_RemarkLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPOP_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPOP_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPOP10100RecordControlIcon()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWPOP10100RecordControlPanelExtender()

                  
                  
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

      
        
        ' To customize, override this method in WPOP10100RecordControl.
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

        ' To customize, override this method in WPOP10100RecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWPOP_DT_ID()
            GetWPOP_DT_ID1()
            GetWPOP_Remark()
            GetWPOP_Status()
            GetWPOP_U_ID()
        End Sub
        
        
        Public Overridable Sub GetWPOP_DT_ID()
            
        End Sub
                
        Public Overridable Sub GetWPOP_DT_ID1()
         
            ' Retrieve the value entered by the user on the WPOP_DT_ID ASP:DropDownList, and
            ' save it into the WPOP_DT_ID field in DataSource DatabaseANFLO-WFN%dbo.WPOP10100 record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WPOP_DT_ID1), WPOP101001Table.WPOP_DT_ID)				
            
        End Sub
                
        Public Overridable Sub GetWPOP_Remark()
            
            ' Retrieve the value entered by the user on the WPOP_Remark ASP:TextBox, and
            ' save it into the WPOP_Remark field in DataSource DatabaseANFLO-WFN%dbo.WPOP10100 record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WPOP_Remark.Text, WPOP101001Table.WPOP_Remark)			

                      
        End Sub
                
        Public Overridable Sub GetWPOP_Status()
            
        End Sub
                
        Public Overridable Sub GetWPOP_U_ID()
         
            ' Retrieve the value entered by the user on the WPOP_U_ID ASP:DropDownList, and
            ' save it into the WPOP_U_ID field in DataSource DatabaseANFLO-WFN%dbo.WPOP10100 record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WPOP_U_ID), WPOP101001Table.WPOP_U_ID)				
            
        End Sub
                
      
        ' To customize, override this method in WPOP10100RecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
      
        Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
      
        Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
      
        Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
      
        Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
      
        Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
      
        Dim hasFiltersWPOP10100RecordControl As Boolean = False
      
            Dim wc As WhereClause
            WPOP101001Table.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
            
            ' Retrieve the record id from the URL parameter.
            Dim recId As String = Me.Page.Request.QueryString.Item("WPOP101001")
            If recId Is Nothing OrElse recId.Trim = "" Then
                
                Return Nothing
                
            End If
              
                  recId = DirectCast(Me.Page, BaseApplicationPage).Decrypt(recId)
                  If recId Is Nothing OrElse recId.Trim = "" Then
                  
                      Return Nothing
                  
                  End If
                
            HttpContext.Current.Session("QueryString in WPO-WFTaskN") = recId
                
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                 
                wc.iAND(WPOP101001Table.WPOP_ID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(WPOP101001Table.WPOP_ID))
        
                    Else
                    ' The URL parameter contains the actual value, not an XML structure.
                    
                wc.iAND(WPOP101001Table.WPOP_ID, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
                
            Return wc
            
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            WPOP101001Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersSel_WPO_InquireDetails1TableControl1 As Boolean = False
              
                Dim hasFiltersSel_WPO_InquireDetailsTableControl As Boolean = False
              
                Dim hasFiltersSel_WPO_WFTaskActivity_RemarksRecordControl As Boolean = False
              
                Dim hasFiltersSel_WPO_WFTaskRecordControl As Boolean = False
              
                Dim hasFiltersView_WCPO_Canvass1TableControl As Boolean = False
              
                Dim hasFiltersWPO_CARNo_QDetailsTableControl As Boolean = False
              
                Dim hasFiltersWPO_Doc_AttachTableControl As Boolean = False
              
                Dim hasFiltersWPO_PRNo_QDetailsTableControl As Boolean = False
              
                Dim hasFiltersWPO_WFHistory_Details_newTableControl As Boolean = False
              
                Dim hasFiltersWPOP10100RecordControl As Boolean = False
              
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
        
    

        ' To customize, override this method in WPOP10100RecordControl.
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
          WPOP101001Table.DeleteRecord(pkValue)
          
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
        
        Public Overridable Sub SetbtnApprove()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnReject()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnReturn()                
              
   
        End Sub
            
                        
        Public Overridable Function CreateWhereClause_WPOP_DT_ID1DropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.WPO_Doc_Type table.
            ' Examples:
            ' wc.iAND(WPO_Doc_Type1Table.WPO_DT_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(WPO_Doc_Type1Table.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
                        
        Public Overridable Function CreateWhereClause_WPOP_U_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.sel_WASP_User table.
            ' Examples:
            ' wc.iAND(Sel_WASP_User1View.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(Sel_WASP_User1View.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
        ' Fill the WPOP_DT_ID1 list.
        Protected Overridable Sub PopulateWPOP_DT_ID1DropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WPOP_DT_ID1.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WPOP_DT_ID1.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WPOP_DT_ID1DropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WPOP_DT_ID1DropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WPO_Doc_Type1Table.WPO_DT_Name, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As WPO_Doc_Type1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = WPO_Doc_Type1Table.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As WPO_Doc_Type1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WPO_DT_IDSpecified Then
                            cvalue = itemValue.WPO_DT_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.WPOP_DT_ID1.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WPOP101001Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPOP101001Table.WPOP_DT_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WPOP101001Table.WPOP_DT_ID.IsApplyDisplayAs Then
                                fvalue = WPOP101001Table.GetDFKA(itemValue, WPOP101001Table.WPOP_DT_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(WPO_Doc_Type1Table.WPO_DT_ID)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WPOP_DT_ID1.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WPOP_DT_ID1.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WPOP_DT_ID1, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WPOP_DT_ID1, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WPO_Doc_Type.WPO_DT_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WPO_Doc_Type1Table.WPO_DT_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WPO_Doc_Type1Record = WPO_Doc_Type1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WPO_Doc_Type1Record = DirectCast(rc(0), WPO_Doc_Type1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WPO_DT_IDSpecified Then
                            cvalue = itemValue.WPO_DT_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WPOP101001Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPOP101001Table.WPOP_DT_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WPOP101001Table.WPOP_DT_ID.IsApplyDisplayAs Then
                          fvalue = WPOP101001Table.GetDFKA(itemValue, WPOP101001Table.WPOP_DT_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WPO_Doc_Type1Table.WPO_DT_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WPOP_DT_ID1, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        ' Fill the WPOP_U_ID list.
        Protected Overridable Sub PopulateWPOP_U_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WPOP_U_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WPOP_U_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WPOP_U_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WPOP_U_IDDropDownList()
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
                            
                            If counter < maxItems AndAlso Me.WPOP_U_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WPOP101001Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPOP101001Table.WPOP_U_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WPOP101001Table.WPOP_U_ID.IsApplyDisplayAs Then
                                fvalue = WPOP101001Table.GetDFKA(itemValue, WPOP101001Table.WPOP_U_ID)
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

                                Dim dupItem As ListItem = Me.WPOP_U_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WPOP_U_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WPOP_U_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WPOP_U_ID, selectedValue)Then

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
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WPOP101001Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WPOP101001Table.WPOP_U_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WPOP101001Table.WPOP_U_ID.IsApplyDisplayAs Then
                          fvalue = WPOP101001Table.GetDFKA(itemValue, WPOP101001Table.WPOP_U_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(Sel_WASP_User1View.W_U_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WPOP_U_ID, New ListItem(fvalue, cvalue))
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
        Public Overridable Sub btnApprove_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for PushButton
        Public Overridable Sub btnReject_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for PushButton
        Public Overridable Sub btnReturn_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        Protected Overridable Sub WPOP_DT_ID1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WPOP_DT_ID1.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WPOP_DT_ID1.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WPOP_DT_ID1.Items.Add(New ListItem(displayText, val))
                Me.WPOP_DT_ID1.SelectedIndex = Me.WPOP_DT_ID1.Items.Count - 1
                Me.Page.Session.Remove(WPOP_DT_ID1.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WPOP_DT_ID1.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WPOP_U_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WPOP_U_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WPOP_U_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WPOP_U_ID.Items.Add(New ListItem(displayText, val))
                Me.WPOP_U_ID.SelectedIndex = Me.WPOP_U_ID.Items.Count - 1
                Me.Page.Session.Remove(WPOP_U_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WPOP_U_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WPOP_Remark_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub ddlMoveTo_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

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
                Return CType(Me.ViewState("BaseWPOP10100RecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWPOP10100RecordControl_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WPOP101001Record
            Get
                Return DirectCast(MyBase._DataSource, WPOP101001Record)
            End Get
            Set(ByVal value As WPOP101001Record)
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
        
        Public ReadOnly Property btnApprove() As System.Web.UI.WebControls.Button
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnApprove"), System.Web.UI.WebControls.Button)
            End Get
        End Property
        
        Public ReadOnly Property btnReject() As System.Web.UI.WebControls.Button
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnReject"), System.Web.UI.WebControls.Button)
            End Get
        End Property
        
        Public ReadOnly Property btnReturn() As System.Web.UI.WebControls.Button
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnReturn"), System.Web.UI.WebControls.Button)
            End Get
        End Property
        
        Public ReadOnly Property ddlMoveTo() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlMoveTo"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property Literal6() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal6"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litSpace1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litSpace1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litSpace2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litSpace2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPOP_DT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP_DT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPOP_DT_ID1() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP_DT_ID1"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WPOP_DT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP_DT_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPOP_Remark() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP_Remark"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WPOP_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPOP_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPOP_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPOP_U_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP_U_ID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WPOP10100RecordControlIcon() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControlIcon"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property WPOP10100RecordControlPanelExtender() As AjaxControlToolkit.CollapsiblePanelExtender
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP10100RecordControlPanelExtender"), AjaxControlToolkit.CollapsiblePanelExtender)
            End Get
        End Property
        
        Public ReadOnly Property WPOP10100Title() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPOP10100Title"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WPOP101001Record = Nothing
             
        
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
            
            Dim rec As WPOP101001Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WPOP101001Record
            If Not Me.DataSource Is Nothing Then
              Return Me.DataSource
            End If
            
            
            Return New WPOP101001Record()
            
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

  