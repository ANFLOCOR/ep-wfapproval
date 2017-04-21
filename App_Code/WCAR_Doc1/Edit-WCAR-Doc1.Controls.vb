
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Edit_WCAR_Doc1.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.Edit_WCAR_Doc1

#Region "Section 1: Place your customizations here."

    
Public Class WCAR_Doc_Attach1TableControlRow
        Inherits BaseWCAR_Doc_Attach1TableControlRow
        ' The BaseWCAR_Doc_Attach1TableControlRow implements code for a ROW within the
        ' the WCAR_Doc_Attach1TableControl table.  The BaseWCAR_Doc_Attach1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WCAR_Doc_Attach1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.



        Public Overrides Function CreateWhereClause_WCDA_WAT_IDDropDownList() As WhereClause
            Dim wc As WhereClause = New WhereClause()
            wc.iAND(WAttach_Type1Table.WAT_Operation, BaseFilter.ComparisonOperator.EqualsTo, "CAR")
            Return wc
        End Function


End Class

  

Public Class WCAR_Doc_Attach1TableControl
        Inherits BaseWCAR_Doc_Attach1TableControl

    ' The BaseWCAR_Doc_Attach1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WCAR_Doc_Attach1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WCAR_Doc_Checker1TableControlRow
        Inherits BaseWCAR_Doc_Checker1TableControlRow
        ' The BaseWCAR_Doc_Checker1TableControlRow implements code for a ROW within the
        ' the WCAR_Doc_Checker1TableControl table.  The BaseWCAR_Doc_Checker1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WCAR_Doc_Checker1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


        Protected Overrides Sub PopulateWCDC_U_IDDropDownList( _
           ByVal selectedValue As String, _
           ByVal maxItems As Integer)

            Dim wc As WhereClause = New WhereClause 'CreateWhereClause_WCDC_U_IDDropDownList()
            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(Sel_WASP_WF_Creator1View.W_U_Full_Name, OrderByItem.OrderDir.Asc)
            'orderBy.Add(Sel_WASS_WF_CreatorView.SSU_FullName, OrderByItem.OrderDir.Asc)
            Me.WCDC_U_ID.Items.Clear()
            Dim itemValue As Sel_WASP_WF_Creator1Record
            'Dim itemValue As Sel_WASS_WF_CreatorRecord
            For Each itemValue In Sel_WASP_WF_Creator1View.GetRecords(wc, orderBy, 0, maxItems)
                'For Each itemValue In Sel_WASS_WF_CreatorView.GetRecords(wc, orderBy, 0, maxItems)
                ' Create the item and add to the list.
                Dim cvalue As String = Nothing
                Dim fvalue As String = Nothing
                If itemValue.W_U_IDSpecified Then
                    cvalue = itemValue.W_U_ID.ToString()
                    fvalue = itemValue.W_U_Full_Name.ToString()
                End If
                'If itemValue.SSU_RowIDSpecified Then
                '    cvalue = itemValue.SSU_RowID.ToString()
                '    fvalue = itemValue.SSU_FullName.ToString()
                'End If
                Dim item As ListItem = New ListItem(fvalue, cvalue)
                If cvalue <> System.Web.HttpContext.Current.Session("UserIDNorth").ToString() Then
                    Me.WCDC_U_ID.Items.Add(item)
                End If
            Next

            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCDC_U_ID, selectedValue) AndAlso _
                Not MiscUtils.SetSelectedValue(Me.WCDC_U_ID, WCAR_Doc_Checker1Table.WCDC_U_ID.Format(selectedValue)) Then
                Dim fvalue As String = WCAR_Doc_Checker1Table.WCDC_U_ID.Format(selectedValue)
                Dim item As ListItem = New ListItem(fvalue, selectedValue)
                item.Selected = True
                Me.WCDC_U_ID.Items.Insert(0, item)
            End If

            Me.WCDC_U_ID.Items.Insert(0, New ListItem(Page.GetResourceValue("** PLEASE SELECT **", "EPORTAL CAR"), "--PLEASE_SELECT--"))
        End Sub

        Public Overrides Sub SaveData()

            Me.LoadData()

            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "EPORTAL"))
                End If
            End If

            Dim wCAR_DocRecordControlObj As WCAR_Doc1RecordControl


            wCAR_DocRecordControlObj = DirectCast(Me.Page.FindControlRecursively("WCAR_Doc1RecordControl"), WCAR_Doc1RecordControl)
            If (Not IsNothing(wCAR_DocRecordControlObj) AndAlso IsNothing(wCAR_DocRecordControlObj.DataSource)) Then
                ' Load the record if it is not loaded yet.
                wCAR_DocRecordControlObj.LoadData()
            End If
            If (IsNothing(wCAR_DocRecordControlObj) OrElse IsNothing(wCAR_DocRecordControlObj.DataSource)) Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "EPORTAL"))
            End If

            Me.DataSource.WCDC_WCD_ID = wCAR_DocRecordControlObj.DataSource.WCD_ID

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
                'note: send email to added co-requester(s)			

                Send_Email_Notification(Me.WCDC_U_ID.SelectedValue.ToString(), _
                "CAR Concurrence Needed (CAR# " & wCAR_DocRecordControlObj.WCD_No.Text & ")", wCAR_DocRecordControlObj.sEmailContentForm)

                DirectCast(GetParentControlObject(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl).ResetData = True
            End If
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True

            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)

        End Sub

        Private Sub Send_Email_Notification(ByVal SendTo_User_ID As String, ByVal Subject As String, ByVal Content As String)
            Dim sEmail As String = ""

            Try

                'Dim wc2 As WhereClause = New WhereClause
                'Dim itemValue2 As Sel_SysSetupUsers_EmailRecord
                'wc2.iAND(Sel_SysSetupUsers_EmailView.SSU_RowID, BaseFilter.ComparisonOperator.EqualsTo, SendTo_User_ID)

                'If Sel_SysSetupUsers_EmailView.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                '    For Each itemValue2 In Sel_SysSetupUsers_EmailView.GetRecords(wc2, Nothing, 0, 100)
                '        If itemValue2.SSU_RowIDSpecified Then
                '            sEmail = itemValue2.SSUE_Email.ToString()
                '        End If
                '    Next
                'End If

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
                email.SetIsHtmlContent(False)
                email.SendMessage()
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "Send Email Error", ex.Message)
            End Try
        End Sub

        Public Overrides Sub DataBind()
            MyBase.DataBind()

            If Me.DataSource Is Nothing Then
                Return
            End If

            If Not Me.DataSource.GetCheckSumValue() Is Nothing Then
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If

            SetWCDC_Rem()
            SetWCDC_Status()
            SetWCDC_U_ID()

            Me.IsNewRecord = True

            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False

                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If

            Dim shouldResetControl As Boolean = False
            Dim oHead As WCAR_Doc1RecordControl
            oHead = DirectCast(Me.Page.FindControlRecursively("WCAR_Doc1RecordControl"), WCAR_Doc1RecordControl)
            oHead.LoadData()
            If System.Web.HttpContext.Current.Session("UserIDNorth").ToString() <> oHead.DataSource.WCD_U_ID.ToString() Then
                Me.WCDC_U_ID.Enabled = False
                Me.WCAR_Doc_CheckerRowDeleteButton.Visible = False
            End If
        End Sub

        Public Overrides Sub SetWCDC_U_ID()

            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDC_U_ID.ID) Then
                If Me.PreviousUIData(Me.WCDC_U_ID.ID) Is Nothing Then
                    Me.PopulateWCDC_U_IDDropDownList(Nothing, 200)
                Else
                    Me.PopulateWCDC_U_IDDropDownList(Me.PreviousUIData(Me.WCDC_U_ID.ID).ToString(), 200)
                End If
                Return
            End If


            ' Set the WCDC_U_ID DropDownList on the webpage with value from the
            ' WCAR_Doc_Checker database record.

            ' Me.DataSource is the WCAR_Doc_Checker record retrieved from the database.
            ' Me.WCDC_U_ID is the ASP:DropDownList on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDC_U_ID()
            ' and add your own code before or after the call to the MyBase function.


            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDC_U_IDSpecified Then

                ' If the WCDC_U_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.PopulateWCDC_U_IDDropDownList(Me.DataSource.WCDC_U_ID.ToString(), 200)

            Else

                ' WCDC_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.PopulateWCDC_U_IDDropDownList(Nothing, 200)
                Else
                    Me.PopulateWCDC_U_IDDropDownList(WCAR_Doc_CheckerTable.WCDC_U_ID.DefaultValue, 200)
                End If

            End If

        End Sub


        

End Class

  

Public Class WCAR_Doc_Checker1TableControl
        Inherits BaseWCAR_Doc_Checker1TableControl

    ' The BaseWCAR_Doc_Checker1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WCAR_Doc_Checker1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WCAR_Doc1RecordControl
        Inherits BaseWCAR_Doc1RecordControl
        ' The BaseWCAR_Doc1RecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.


        Public sEmailContentForm As String = ""

        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.btnChecked.Button.Attributes.Add("onClick", "javascript:return confirm(""Are you sure you want to concur to this document?"");")
            AddHandler Me.btnChecked.Button.Click, AddressOf btnChecked_Click
            AddHandler Me.btnRemoveCheck.Button.Click, AddressOf btnRemoveCheck_Click
            AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
            AddHandler Me.CancelButton1.Button.Click, AddressOf CancelButton1_Click
            AddHandler Me.btnVoid.Button.Click, AddressOf btnVoid_Click
            AddHandler Me.SaveButton.Button.Click, AddressOf SaveButton_Click
            Me.SaveButton.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, """ & Me.Page.GetResourceValue("Txt:SaveRecord", "EPORTAL") & """);")
            AddHandler Me.WCD_C_ID.SelectedIndexChanged, AddressOf WCD_C_ID_SelectedIndexChanged
            AddHandler Me.WCD_WCur_ID.SelectedIndexChanged, AddressOf WCD_WCur_ID_SelectedIndexChanged
            AddHandler Me.WCD_WDT_ID.SelectedIndexChanged, AddressOf WCD_WDT_ID_SelectedIndexChanged

            'Dim sCur As String = CStr(IIf(Not IsNumeric(WCD_Exp_Cur_Yr.Text), "0", WCD_Exp_Cur_Yr.Text))
            'Dim sNxt As String = CStr(IIf(Not IsNumeric(WCD_Exp_Nxt_Yr.Text), "0", WCD_Exp_Nxt_Yr.Text))
            'Dim sSub As String = CStr(IIf(Not IsNumeric(WCD_Exp_Sub_Yr.Text), "0", WCD_Exp_Sub_Yr.Text))
            Dim sCur As String = Convert.ToDecimal(IIf(Not IsNumeric(WCD_Exp_Cur_Yr.Text), "0", WCD_Exp_Cur_Yr.Text)).ToString("#,#.00")
            Dim sNxt As String = Convert.ToDecimal(IIf(Not IsNumeric(WCD_Exp_Nxt_Yr.Text), "0", WCD_Exp_Nxt_Yr.Text)).ToString("#,#.00")
            Dim sSub As String = Convert.ToDecimal(IIf(Not IsNumeric(WCD_Exp_Sub_Yr.Text), "0", WCD_Exp_Sub_Yr.Text)).ToString("#,#.00")
            Dim sngTotal As Single = CSng(sCur) + CSng(sNxt) + CSng(sSub)
            Me.lblTotal1.Text = sngTotal.ToString("#,#.00")
            Me.WCD_Exp_Total.Text = sCur
            If Page.IsPostBack Then
                Me.WCD_Exp_Total.Text = sCur
            End If

            AddHandler Me.imbFind.Click, AddressOf imbFind_Click
            Me.WCD_Supplementary.Attributes.Add("onclick", "Supplementary('" & Me.WCD_Supplementary.ClientID & "','" & _
            Me.WCD_Supplementary_WCD_ID.ClientID & "','" & Me.imbFind.ClientID & "','" & Me.WCD_Supplementary_Manual.ClientID & "')")
            'Me.WCD_Supplementary_WCD_ID.Enabled = False
            Me.WCD_Supplementary_Manual.Enabled = False
            'Me.imbFind.Enabled = False
            Me.imbFind.Attributes.Add("onClick", "OpenCARSelector('" & Me.WCD_Supplementary_WCD_ID.ClientID & "');return false;")
            Me.imbRelated.Attributes.Add("onClick", "OpenRelatedCARNorth('" & Me.WCD_Supplementary_WCD_ID.ClientID & "','" & Me.WCD_C_ID.ClientID & "');return false;")

            If Me.WCD_Status.Text = "Return" Then
                Me.WCD_C_ID.Enabled = False
                Me.WCD_No.Enabled = False
                Me.WCD_Request_Date.Enabled = False
                Me.WCD_Project_Title.Enabled = False
                Me.WCD_Unit_Location.Enabled = False
                Me.WCD_Project_No.Enabled = False
                Me.WCD_Proj_Inc_ACB.Enabled = False
                'Me.WCD_Remark.Enabled = False
                Me.WCD_Supplementary.Enabled = False
                Me.WCD_Supplementary_WCD_ID.Enabled = True 'False (changed to True to avoid error in submitting when status is Return)
                Me.WCD_Supplementary_Manual.Enabled = False
                Me.WCD_WDT_ID.Enabled = False
                Me.WCD_WCur_ID.Enabled = False
                Me.WCD_Exp_Cur_Yr.Enabled = False
                Me.WCD_Exp_Nxt_Yr.Enabled = False
                Me.WCD_Exp_Sub_Yr.Enabled = False
                Me.WCD_Exp_Total.Enabled = False
                Me.WCD_Exp_Prev_Total.Enabled = False
                Me.WCD_Exp_Budget.Enabled = False
                Me.WCD_Exp_Under_Over_Budget.Enabled = False
                Me.imbFind.Enabled = False
                Me.imbRelated.Enabled = False

                Dim oTab1 As WCAR_Doc_Checker1TableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl)
                'Dim oTab3 As WCAR_Doc_CheckerTableControlRow = DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_CheckerTableControlRow"), WCAR_Doc_CheckerTableControlRow)			

                oTab1.WCAR_Doc_CheckerAddButton.Enabled = False
                ''oTab2.WCDoc_ProjClass_ID.Enabled = False
                'oTab3.WCDC_U_ID.Enabled = False
            End If

            If Not Me.WCD_Exp_Prev_Total.Text.Trim Is Nothing And Not Me.WCD_Exp_Prev_Total.Text.Trim = "" Then
                Me.WCD_Exp_Prev_Total.Text = Convert.ToDecimal(Me.WCD_Exp_Prev_Total.Text).ToString("#,#.00")
                Me.WCD_Exp_Prev_Total.Style.Add("text-align", "right")
            End If
            If Not Me.WCD_Exp_Budget.Text.Trim Is Nothing And Not Me.WCD_Exp_Budget.Text.Trim = "" Then
                Me.WCD_Exp_Budget.Text = Convert.ToDecimal(Me.WCD_Exp_Budget.Text).ToString("#,#.00")
                Me.WCD_Exp_Budget.Style.Add("text-align", "right")
            End If
            If Not Me.WCD_Exp_Under_Over_Budget.Text.Trim Is Nothing And Not Me.WCD_Exp_Under_Over_Budget.Text.Trim = "" Then
                Me.WCD_Exp_Under_Over_Budget.Text = Convert.ToDecimal(Me.WCD_Exp_Under_Over_Budget.Text).ToString("#,#.00")
                Me.WCD_Exp_Under_Over_Budget.Style.Add("text-align", "right")
            End If

        End Sub

        Private Sub MyPreRender( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles MyBase.PreRender

            Dim script As String = "<script language=""javascript"">" & vbCrLf & _
            "function addCommas(nStr) {" & vbCrLf & _
            "  nStr += '';" & vbCrLf & _
            "  x = nStr.split('.');" & vbCrLf & _
            "  x1 = x[0];" & vbCrLf & _
            "  x2 = x.length > 1 ? '.' + x[1] : '';" & vbCrLf & _
            "  var rgx = /(\d+)(\d{3})/;" & vbCrLf & _
            "  while (rgx.test(x1)) {" & vbCrLf & _
            "    x1 = x1.replace(rgx, '$1' + ',' + '$2');" & vbCrLf & _
            "  }" & vbCrLf & _
            "  return x1 + x2; }" & vbCrLf & _
            "function Supplementary(Checker,Texter,Finder,Manual) {" & vbCrLf & _
            "  if (document.getElementById(Checker).checked) {" & vbCrLf & _
            "    document.getElementById(Texter).disabled=false;" & vbCrLf & _
            "    document.getElementById(Finder).disabled=false;" & vbCrLf & _
            "    document.getElementById(Manual).disabled=false;}" & vbCrLf & _
            "  else {" & vbCrLf & _
            "    document.getElementById(Texter).disabled=true;" & vbCrLf & _
            "    document.getElementById(Finder).disabled=true;" & vbCrLf & _
            "    document.getElementById(Manual).disabled=true;" & vbCrLf & _
            "    document.getElementById(Manual).value='';" & vbCrLf & _
            "    document.getElementById(Texter).value='';}}" & vbCrLf & _
            "function RefreshThisRequestSum() {" & vbCrLf & _
            "  var sum = 0;" & vbCrLf & _
            "  var numValue1 = document.getElementById('" & Me.WCD_Exp_Cur_Yr.ClientID & "').value;" & vbCrLf & _
            "  numValue1 = numValue1.replace("","","""");" & vbCrLf & _
            "  var numValue2 = document.getElementById('" & Me.WCD_Exp_Nxt_Yr.ClientID & "').value;" & vbCrLf & _
            "  numValue2 = numValue2.replace("","","""");" & vbCrLf & _
            "  var numValue3 = document.getElementById('" & Me.WCD_Exp_Sub_Yr.ClientID & "').value;" & vbCrLf & _
            "  numValue3 = numValue3.replace("","","""");" & vbCrLf & _
            "  if (!isNaN(numValue1)) { " & vbCrLf & _
            "    if (numValue1.length > 0) { " & vbCrLf & _
            "      sum += parseFloat(numValue1); } }" & vbCrLf & _
            "  if (!isNaN(numValue2)) { " & vbCrLf & _
            "    if (numValue2.length > 0) { " & vbCrLf & _
            "      sum += parseFloat(numValue2); } }" & vbCrLf & _
            "  if (!isNaN(numValue3)) { " & vbCrLf & _
            "    if (numValue3.length > 0) { " & vbCrLf & _
            "      sum += parseFloat(numValue3); } }" & vbCrLf & _
            "  document.getElementById('" & Me.lblTotal1.ClientID & "').innerHTML = addCommas(sum.toFixed(2));" & vbCrLf & _
            "  document.getElementById('" & Me.WCD_Exp_Total.ClientID & "').value = addCommas(numValue1.toFixed(2));" & vbCrLf & _
            "}" & vbCrLf & _
            "" & vbCrLf & _
            "RefreshThisRequestSum();" & vbCrLf & _
            "</script>"
            Me.Page.ClientScript.RegisterStartupScript(GetType(Page), "RefreshThisRequestSum", script)
        End Sub

        Protected Overrides Sub PopulateWCD_C_IDDropDownList(ByVal selectedValue As String, ByVal maxItems As Integer)

            'Dim wc As WhereClause = New WhereClause
            'wc.iAND(Sel_WASS_User_Dynamics_CompanyView.SSUC_SSU_UserName, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString())

            'Dim orderBy As OrderBy = New OrderBy(False, True)
            ''orderBy.Add(Sel_WASS_User_Dynamics_CompanyView.SSC_CompanyName, BaseClasses.Data.OrderByItem.OrderDir.Asc)
            'orderBy.Add(Sel_WASS_User_Dynamics_CompanyView.SSUC_isDefault, BaseClasses.Data.OrderByItem.OrderDir.Desc)
            'Me.WCD_C_ID.Items.Clear()
            'Dim itemValue As Sel_WASS_User_Dynamics_CompanyRecord

            'For Each itemValue In Sel_WASS_User_Dynamics_CompanyView.GetRecords(wc, orderBy, 0, maxItems)
            '    Dim cvalue As String = itemValue.CMPANYID.ToString()
            '    Dim fvalue As String = itemValue.SSC_Description 'itemValue.Format(Sel_W_User_DYNAMICS_CompanyView.Company_Short_Name)
            '    If fvalue Is Nothing Then
            '        fvalue = itemValue.SSC_CompanyName
            '    End If
            '    Dim item As ListItem = New ListItem(fvalue, cvalue)
            '    Me.WCD_C_ID.Items.Add(item)
            'Next

            'If Not selectedValue Is Nothing AndAlso _
            'selectedValue.Trim <> "" AndAlso _
            '    Not SetSelectedValue(Me.WCD_C_ID, selectedValue) Then
            '    Dim sWhere As String = Sel_WASS_User_Dynamics_CompanyView.CMPANYID.UniqueName & " = " & selectedValue
            '    Dim sCompany As String = ""
            '    For Each itemValue1 As Sel_WASS_User_Dynamics_CompanyRecord In Sel_WASS_User_Dynamics_CompanyView.GetRecords(sWhere, Nothing, 0, 5)
            '        sCompany = itemValue1.Company_Short_Name
            '    Next
            '    Dim fvalue As String = Sel_WASS_User_Dynamics_CompanyView.CMPANYID.Format(selectedValue)
            '    Dim item As ListItem = New ListItem(sCompany, selectedValue)
            '    item.Selected = True
            '    'Me.WCD_C_ID.Items.Insert(0, item)
            'End If

            ''Me.WCD_C_ID.Items.Insert(0, New ListItem(Page.GetResourceValue("** PLEASE_SELECT **", "CAR"), "--PLEASE_SELECT--"))


            Dim wc As WhereClause = New WhereClause
            wc.iAND(Sel_W_User_DYNAMICS_Company1View.W_U_User_Name, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString())

            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(Sel_W_User_DYNAMICS_Company1View.Company_Short_Name, BaseClasses.Data.OrderByItem.OrderDir.Asc)

            Me.WCD_C_ID.Items.Clear()
            Dim itemValue As Sel_W_User_DYNAMICS_Company1Record

            For Each itemValue In Sel_W_User_DYNAMICS_Company1View.GetRecords(wc, orderBy, 0, maxItems)
                Dim cvalue As String = itemValue.Company_ID.ToString()
                Dim fvalue As String = itemValue.Company_Short_Name 'itemValue.Format(Sel_W_User_DYNAMICS_CompanyView.Company_Short_Name)
                Dim item As ListItem = New ListItem(fvalue, cvalue)
                Me.WCD_C_ID.Items.Add(item)
            Next

            If Not selectedValue Is Nothing AndAlso _
            selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCD_C_ID, selectedValue) Then
                Dim sWhere As String = Sel_W_User_DYNAMICS_Company1View.Company_ID.UniqueName & " = " & selectedValue
                Dim sCompany As String = ""
                For Each itemValue1 As Sel_W_User_DYNAMICS_Company1Record In Sel_W_User_DYNAMICS_Company1View.GetRecords(sWhere, Nothing, 0, 5)
                    sCompany = itemValue1.Company_Short_Name
                Next
                Dim fvalue As String = Sel_W_User_DYNAMICS_Company1View.Company_ID.Format(selectedValue)
                Dim item As ListItem = New ListItem(sCompany, selectedValue)
                item.Selected = True
                Me.WCD_C_ID.Items.Insert(0, item)
            End If

            Me.WCD_C_ID.Items.Insert(0, New ListItem(Page.GetResourceValue("Txt:PleaseSelect", "EPORTAL"), "--PLEASE_SELECT--"))
        End Sub

        Public Overrides Function CreateWhereClause_WCD_WDT_IDDropDownList() As WhereClause
            Dim wc As WhereClause = New WhereClause()

            wc.iAND(WDoc_Type1Table.WDT_C_ID, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_C_ID.SelectedValue.ToString())
            Return wc
        End Function

        Protected Sub MultipleDropdown_myInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

            WCD_C_ID.AutoPostBack = True
            'WCD_WDT_ID.AutoPostBack = True

            AddHandler WCD_C_ID.SelectedIndexChanged, AddressOf WCD_C_ID_SelectedIndexChanged
            'AddHandler WCD_WCur_ID.SelectedIndexChanged, AddressOf WCD_WCur_ID_SelectedIndexChanged
            'WCD_WDT_ID.Enabled = False	
        End Sub

        Protected Overrides Sub WCD_C_ID_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            WCD_WDT_ID.Dispose()
            'WCD_WDT_ID.Enabled = True		
            Me.PopulateWCD_WDT_IDDropDown(100)
            System.Web.HttpContext.Current.Session("CAR_C_ID") = Me.WCD_C_ID.SelectedValue.ToString()
        End Sub

        Protected Sub PopulateWCD_WDT_IDDropDown(ByVal maxItems As Integer)

            Dim wc As WhereClause = New WhereClause
            Dim selectedValue As String = WCD_C_ID.SelectedValue
            Dim selectedText As String = WCD_C_ID.SelectedItem.Text
            wc.iAND(WDoc_Type1Table.WDT_C_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedValue)
            wc.iAND(WDoc_Type1Table.WDT_Type, BaseFilter.ComparisonOperator.EqualsTo, "CAR")
            wc.iAND(WDoc_Type1Table.WDT_Limit, BaseFilter.ComparisonOperator.Greater_Than, "0")

            Me.WCD_WDT_ID.Items.Clear()

            Me.WCD_WDT_ID.Items.Insert(0, New ListItem(Page.GetResourceValue("** PLEASE SELECT **", "CAR"), "--PLEASE_SELECT--"))

            If (BaseClasses.Utils.StringUtils.InvariantUCase(selectedText).Equals(BaseClasses.Utils.StringUtils.InvariantUCase(Page.GetResourceValue("** PLEASE SELECT **", "EPORTAL CAR")))) Then
                ' if "Please Select" string is selected for first dropdown list,
                ' then do not continue populating the second dropdown list.
                Return
            End If

            Dim itemValue As WDoc_Type1Record
            For Each itemValue In WDoc_Type1Table.GetRecords(wc, Nothing, 0, maxItems)

                If (itemValue.WDT_C_IDSpecified) Then
                    Dim cvalue As String = itemValue.WDT_ID.ToString()
                    Dim fvalue As String = itemValue.Format(WDoc_Type1Table.WDT_Name)
                    Dim item As ListItem = New ListItem(fvalue, cvalue)
                    If (Not Me.WCD_WDT_ID.Items.Contains(item)) Then
                        Me.WCD_WDT_ID.Items.Add(item)
                    End If
                End If
            Next

            'Me.WCD_WDT_ID.SelectedIndex = 0		
        End Sub

        Private Function FindDelegate(AssignedApprover As String, Optional ByRef Info As String = "") As String
            Dim sApprover As String = AssignedApprover
            Dim sCheck As String = AssignedApprover
            Dim bNoMoreDelegate As Boolean = False
            Dim sWhereDelegate As String = ""
            Dim iCircular As Integer = 0
            Do While Not bNoMoreDelegate
                sWhereDelegate = WTask_Delegation1Table.WTD_W_U_ID.UniqueName & " = '" & sApprover & _
                "' And " & WTask_Delegation1Table.WTD_WDT_Type.UniqueName & " = 'CAR' And " & _
                WTask_Delegation1Table.WTD_From.UniqueName & " <= '" & Now.ToShortDateString() & _
                "' And " & WTask_Delegation1Table.WTD_To.UniqueName & " >= '" & Now.ToShortDateString() & "'" & _
                " And " & WTask_Delegation1Table.WTD_C_ID.UniqueName & " = " & Me.WCD_C_ID.SelectedValue.ToString()

                sCheck = ""
                For Each oDelegate As WTask_Delegation1Record In WTask_Delegation1Table.GetRecords(sWhereDelegate, Nothing, 0, 5)
                    sApprover = oDelegate.WTD_W_U_ID_Delegate.ToString()
                    sCheck = oDelegate.WTD_W_U_ID_Delegate.ToString()
                Next

                If sCheck = "" Then
                    bNoMoreDelegate = True
                    Info = " #Delegated Task#"
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

        Private Function Content_Formatter(User_ID As String, Title As String, Company As String, Details As String, _
        DocDate As String, Remarks As String, Total As String, Requester_ID As String, Color_Hex As String, _
        Page As String, Document As String, ApproverRem As String, Status As String, WF_Type As String, Optional Default_Type As String = "") As String
            Dim wc2 As WhereClause = New WhereClause
            Dim itemValue2 As W_Email1Record
            'Dim itemValue2 As SysSetupWASSEmailRecord
            Dim sDirectory As String
            Dim sSite As String
            Dim sTemplate As String

            If Default_Type = "" Then
                wc2.iAND(W_Email1Table.WE_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)
                wc2.iAND(W_Email1Table.WE_Directory, BaseFilter.ComparisonOperator.EqualsTo, "eportal")
                'wc2.iAND(SysSetupWASSEmailTable.WE_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)

                If W_Email1Table.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    'If SysSetupWASSEmailTable.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue2 In W_Email1Table.GetRecords(wc2, Nothing, 0, 100)
                        'For Each itemValue2 In SysSetupWASSEmailTable.GetRecords(wc2, Nothing, 0, 100)
                        If itemValue2.WE_U_IDSpecified Then
                            sDirectory = itemValue2.WE_Directory.ToString()
                            sSite = itemValue2.WE_Site.ToString()
                            sTemplate = itemValue2.WE_Template.ToString()
                        End If
                    Next
                End If
            Else
                wc2.iAND(W_Email_Default1Table.WED_Type, BaseFilter.ComparisonOperator.EqualsTo, Default_Type)
                'wc2.iAND(SysSetupEmailDefaultTable.WED_Type, BaseFilter.ComparisonOperator.EqualsTo, Default_Type)

                If W_Email_Default1Table.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    'If SysSetupEmailDefaultTable.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                    For Each itemValue21 As W_Email_Default1Record In W_Email_Default1Table.GetRecords(wc2, Nothing, 0, 100)
                        'For Each itemValue21 As SysSetupEmailDefaultRecord In SysSetupEmailDefaultTable.GetRecords(wc2, Nothing, 0, 100)
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

            'Dim wc3 As WhereClause = New WhereClause
            'Dim itemValue3 As W_UserRecord
            'Dim sFullName As String 'creator
            'Dim sUserEmail As String 'creator
            'wc3.iAND(W_UserTable.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, SendTo_User_ID)

            'If W_UserTable.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
            '    For Each itemValue3 In W_UserTable.GetRecords(wc2, Nothing, 0, 100)
            '        If itemValue3.W_U_IDSpecified Then
            '            sFullName = itemValue3.W_U_Full_Name.ToString()
            '            sUserEmail = itemValue3.W_U_Email.ToString()
            '        End If
            '    Next
            'End If

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


        Public Overrides Sub SaveData()

            Me.LoadData()

            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "EPORTAL"))
                End If
            End If

            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WCAR_DocRecordControlPanel"), System.Web.UI.WebControls.Panel)

            If ((Not IsNothing(Panel)) AndAlso (Not Panel.Visible)) OrElse IsNothing(Me.DataSource) Then
                Return
            End If

            Me.Validate()

            Dim sStatusReturn As String = ""
            sStatusReturn = Me.WCD_Status.Text
            'Me.WCD_U_ID.Text = System.Web.HttpContext.Current.Session("UserID").ToString()
            If Me.WCD_Status.Text = "For Review" And Me.WCD_Submit.Checked Then
                Me.WCD_Status.Text = "Pending" 'if the status becomes 'For Review' (in cases of 1st step rejection/return to Creator)
            End If
            'ensure that the document is 'Pending' once it returns to the WF
            If Me.WCD_Status.Text = "Return" And Me.WCD_Submit.Checked Then
                Me.WCD_Status.Text = "Pending" 'if the status becomes 'For Review' (in cases of 1st step rejection/return to Creator)
            End If
            'GET CAR ID From CAR No
            Dim bOverrideMinCheck As Boolean = False

            If Me.WCD_Supplementary.Checked And Me.WCD_Supplementary_WCD_ID.Text <> "" Then
                Dim sWhereCAR As String = WCAR_Doc1Table.WCD_No.UniqueName & "='" & Me.WCD_Supplementary_WCD_ID.Text & "'" & _
                " And " & WCAR_Doc1Table.WCD_C_ID.UniqueName & " = " & Me.WCD_C_ID.SelectedValue.ToString()
                Dim sTempCAR As String = ""
                Dim sOrigCAR As String = Me.WCD_Supplementary_WCD_ID.Text
                For Each oSC As WCAR_Doc1Record In WCAR_Doc1Table.GetRecords(sWhereCAR, Nothing, 0, 5)
                    sTempCAR = oSC.WCD_ID.ToString()
                Next
                Me.WCD_Supplementary_WCD_ID.Text = sTempCAR
                'Me.WCD_Supplementary_WCD_ID1.Text = sTempCAR
                bOverrideMinCheck = True
            ElseIf Me.WCD_Supplementary.Checked And Me.WCD_Supplementary_WCD_ID.Text = "" Then
                If Me.WCD_Supplementary_Manual.Text = "" Then
                    Throw New Exception("You must supply a valid CAR No. Uncheck the supplementary option if you do not intend this document to be a supplementary CAR.")
                Else
                    bOverrideMinCheck = True
                End If
            ElseIf Not Me.WCD_Supplementary.Checked And Me.WCD_Supplementary_WCD_ID.Text <> "" Then
                Throw New Exception("You do not have to supply any CAR if this document is not a supplementary CAR.")
            Else
                Me.WCD_Supplementary_WCD_ID.Text = ""
            End If

            Me.GetUIData()
            'note: check if selected workflow path is Proper for the amount
            Dim sWhereAmount As String = WDoc_Type1Table.WDT_ID.UniqueName & " = " & Me.WCD_WDT_ID.SelectedValue.ToString()
            For Each oLimit As WDoc_Type1Record In WDoc_Type1Table.GetRecords(sWhereAmount, Nothing, 0, 100)
                If CSng(oLimit.WDT_Limit) < CSng(Me.WCD_Exp_Cur_Yr.Text) Then 'amount in doc is greater than the assigned path
                    Throw New Exception("Selected WORKFLOW path is invalid since the amount exceeds the required value for this approver list.")
                End If
            Next
            'note: check the encoded amount against the CAR limit per company
            Dim iCAR_Min As Single
            iCAR_Min = 0
            If Not bOverrideMinCheck Then 'override if supplementary
                Dim sWhereMin As String = WCAR_Minimum1Table.WCM_C_ID.UniqueName & " = " & Me.WCD_C_ID.SelectedValue.ToString() & _
                " And " & WCAR_Minimum1Table.WCM_WCur_ID.UniqueName & " = " & Me.WCD_WCur_ID.SelectedValue.ToString()
                For Each oRec As WCAR_Minimum1Record In WCAR_Minimum1Table.GetRecords(sWhereMin, Nothing, 0, 100)
                    iCAR_Min = oRec.WCM_Min
                Next

                If iCAR_Min > 0 Then
                    If iCAR_Min > CInt(Me.WCD_Exp_Total.Text) Then
                        Throw New Exception("CAR Total Amount (Total Expenditure This Request) is less than the required minimum amount." & vbCrLf & vbCrLf & _
                        "For " & Me.WCD_C_ID.SelectedItem.Text & " the minimum amount is " & iCAR_Min.ToString() & _
                        " (" & Me.WCD_WCur_ID.SelectedItem.Text & ").")
                    End If
                Else
                    Throw New Exception("CAR minimum amount for this currency(" & Me.WCD_WCur_ID.SelectedItem.Text & ") has no setup value.")
                End If
            End If
            '------- format email
            'Dim sWhere1 As String = Sel_SysSetupUsers_EmailView.SSU_RowID.UniqueName & " = " & Me.WCD_U_ID.Text
            Dim sWhere1 As String = W_User1Table.W_U_ID.UniqueName & " = " & Me.WCD_U_ID.Text

            Dim sUser As String = ""
            'For Each oRec As Sel_SysSetupUsers_EmailRecord In Sel_SysSetupUsers_EmailView.GetRecords(sWhere1, Nothing, 0, 100)
            For Each oRec As W_User1Record In W_User1Table.GetRecords(sWhere1, Nothing, 0, 100)
                'For Each oRec As Sel_SysSetupUsers_EmailRecord In Sel_SysSetupUsers_EmailView.GetRecords(sWhere1, Nothing, 0, 100)
                'sUser = oRec.SSU_FullName.ToString()
                sUser = oRec.W_U_Full_Name.ToString()
            Next

            Dim sEmailContent As String = "Company: @C" & vbCrLf & vbCrLf & "Details:" & vbCrLf & "@D" & vbCrLf & _
            vbCrLf & "Request Date: @RD" & _
            vbCrLf & "Remarks: @Rem" & vbCrLf & "Total: @T"

            sEmailContent = Replace(sEmailContent, "@C", Me.WCD_C_ID.SelectedItem.ToString())
            sEmailContent = Replace(sEmailContent, "@D", Me.WCD_Project_Title.Text)
            sEmailContent = Replace(sEmailContent, "@RD", Me.WCD_Request_Date.Text)
            sEmailContent = Replace(sEmailContent, "@Rem", Me.WCD_Remark.Text)
            sEmailContent = Replace(sEmailContent, "@T", Me.WCD_Exp_Cur_Yr.Text)
            sEmailContent &= vbCrLf & "Creator: " & sUser
            sEmailContent &= vbCrLf & vbCrLf & "http://eportal.anflocor.com"

            Me.sEmailContentForm = sEmailContent
            '------- format email
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                If Me.WCD_Submit.Checked.ToString().ToUpper() = "TRUE" Then
                    'note: check if doc has co-requesters -> count co-requesters and count 'Concurred' status = must be equal
                    Dim sWhere As String = ""
                    Dim iRequester As Integer = 0
                    Dim iConcurred As Integer = 0

                    sWhere = WCAR_Doc_Checker1Table.WCDC_WCD_ID.UniqueName & " = " & Me.WCD_ID.Text
                    For Each oRec As WCAR_Doc_Checker1Record In WCAR_Doc_Checker1Table.GetRecords(sWhere, Nothing, 0, 100)
                        If oRec.WCDC_Status = "Concurred" Then
                            iConcurred += 1
                        End If
                        iRequester += 1
                    Next

                    If iRequester <> iConcurred Then
                        'RegisterAlert("Submit CAR Error", "Insufficient co-requester concurrency.", True)
                        'Utils.MiscUtils.RegisterJScriptAlert(Me, "Warning", "Insufficient co-requester concurrency.")
                        Throw New Exception("Insufficient co-requester concurrency." & vbCrLf & vbCrLf & _
                        "Do not submit this document if there are incomplete co-requester approvals.")
                        Exit Sub
                    End If

                    Dim oRec1 As WCAR_Doc_Checker1TableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl)

                    If oRec1.GetRecordControls.Length <> iConcurred Then '> 0
                        'note: if user has added co-requesters -> do not allow submission
                        Throw New Exception("Insufficient co-requester concurrency." & vbCrLf & vbCrLf & _
                        "Do not submit this document if there are incomplete co-requester approvals.")
                    End If
                End If

                If System.Web.HttpContext.Current.Session("CAR_No").ToString() <> Me.WCD_No.Text Then
                    Dim whereStr As String = WCAR_Doc1Table.WCD_No.UniqueName & " = '" & Me.WCD_No.Text & "'"

                    Dim rec As WCAR_Doc1Record = WCAR_Doc1Table.GetRecord(whereStr)
                    If (Not IsNothing(rec)) Then
                        Throw New Exception("The CAR No: " & Me.WCD_No.Text & " already exists." & vbCrLf & _
                        vbCrLf & "Enter a new CAR No and try to save this document again.")
                    Else
                        Me.DataSource.Save()
                    End If
                Else
                    Me.DataSource.Save()
                End If
                'Me.DataSource.Save()
                'User checks the Submit control -> Finds the 1st step using the Doc Type ID
                If Me.WCD_Submit.Checked.ToString().ToUpper() = "TRUE" Then
                    If sStatusReturn <> "Return" Then
                        Dim wc1 As WhereClause = New WhereClause
                        wc1.iAND(WStep1Table.WS_WDT_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_WDT_ID.SelectedValue)
                        wc1.iAND(WStep1Table.WS_Step_Type, BaseFilter.ComparisonOperator.EqualsTo, "Start")

                        Dim itemValue1 As WStep1Record
                        For Each itemValue1 In WStep1Table.GetRecords(wc1, Nothing, 0, 100)
                            If (itemValue1.WS_IDSpecified) Then
                                'UpdateRecord_Prev_Rej_Invisible
                                'note: if just in case this doc is resubmitted -> do not show Rejected doc to user task (IsDone=True)
                                Dim sWhereRej As String = WCAR_Activity1Table.WCA_WCD_ID.UniqueName & " = " & Me.DataSource.WCD_ID.ToString() & _
                                " AND " & WCAR_Activity1Table.WCA_Status.UniqueName & " = 'Rejected'"
                                For Each oRej As WCAR_Activity1Record In WCAR_Activity1Table.GetRecords(sWhereRej, Nothing, 0, 100)
                                    WCAR_Activity1Record.UpdateRecord_Prev_Rej_Invisible(oRej.WCA_ID.ToString())
                                Next

                                'Query the details table to find assigned users
                                Dim wc2 As WhereClause = New WhereClause
                                wc2.iAND(WStep_Detail1Table.WSD_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, itemValue1.WS_ID.ToString())

                                Dim itemValue2 As WStep_Detail1Record
                                For Each itemValue2 In WStep_Detail1Table.GetRecords(wc2, Nothing, 0, 100)
                                    If (itemValue2.WSD_WS_IDSpecified) Then
                                        'insert to WCAR_Activity table
                                        WCAR_Activity1Record.AddRecord(itemValue1.WS_ID.ToString(), itemValue2.WSD_ID.ToString(), _
                                        Me.WCD_WDT_ID.SelectedValue.ToString(), _
                                        FindDelegate(itemValue2.WSD_W_U_ID.ToString()), "0", _
                                        Me.DataSource.WCD_ID.ToString())
                                        'note: do not insert(update) delegate until task expires
                                        'delegate:itemValue2.WSD_W_U_ID_Delegate.ToString() -> 0
                                        Dim sInfo As String = ""
                                        'Dim sInfo As String = ""
                                        'Dim sRemark As String = txtRemark.Text
                                        Dim sDelegate As String = FindDelegate(itemValue2.WSD_W_U_ID.ToString(), sInfo)
                                        'Dim sUserRej As String = System.Web.HttpContext.Current.Session("FullName").ToString()

                                        sEmailContent = Content_Formatter(sDelegate, _
                                        "CAR Information Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                        Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                        System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#4682b4", "wf_car/ShowSel_WCAR_Activity_WCAR_Doc1Table.aspx", Me.WCD_No.Text, _
                                        "", "", "CAR")

                                        Send_Email_Notification(sDelegate, "CAR Approval Needed (CAR# " & _
                                        Me.WCD_No.Text & ")" & sInfo, sEmailContent)
                                        'Dim sInfo As String = ""
                                        'Send_Email_Notification(FindDelegate(itemValue2.WSD_W_U_ID.ToString(), sInfo), _
                                        '"CAR Approval Needed (CAR# " & Me.WCD_No.Text & ")" & sInfo, sEmailContent)
                                    End If
                                Next
                            End If
                        Next
                    Else
                        ''added Return status handling **pepanes 09.20.2013
                        '### handle 'Return' here ###
                        Dim wc5 As WhereClause = New WhereClause
                        Dim ob5 As OrderBy = New OrderBy(False, True)
                        wc5.iAND(WCAR_Activity1Table.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                        'wc5.iAND(WCAR_ActivityTable.WCA_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, "")
                        wc5.iAND(WCAR_Activity1Table.WCA_Status, BaseFilter.ComparisonOperator.EqualsTo, "Return")
                        'wc5.iAND(WCAR_ActivityTable.WCA_WS_ID, BaseFilter.ComparisonOperator.EqualsTo, sCurStep)
                        ''04.02.2014 - pepanes * added filter for "Return" status for Creator
                        wc5.iAND(WCAR_Activity1Table.WCA_Is_Done, BaseFilter.ComparisonOperator.EqualsTo, "0")
                        ''04.02.2014 - pepanes * added order by to filter last record with "Return" status
                        ob5.Add(WCAR_Activity1Table.WCA_Date_Assign, OrderByItem.OrderDir.Desc)
                        If WCAR_Activity1Table.GetRecords(wc5, Nothing, 0, 100).Length > 0 Then
                            For Each itemValue5 As WCAR_Activity1Record In WCAR_Activity1Table.GetRecords(wc5, Nothing, 0, 100)
                                'note: update Activity table (current user) -> 'Approved'

                                Dim sInfo As String = ""
                                Dim sDelegate As String = FindDelegate(itemValue5.WCA_W_U_ID.ToString(), sInfo)

                                sEmailContent = Content_Formatter(sDelegate, _
                                "CAR Information Needed (CAR# " & Me.WCD_No.Text & ")", Me.WCD_C_ID.SelectedItem.ToString(), _
                                Me.WCD_Project_Title.Text, Me.WCD_Request_Date.Text, Me.WCD_Remark.Text, Me.WCD_Exp_Cur_Yr.Text, _
                                System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "#4682b4", "wf_car/ShowSel_WCAR_Activity_WCAR_Doc1Table.aspx", Me.WCD_No.Text, _
                                "", "", "CAR")

                                Send_Email_Notification(sDelegate, "CAR Approval Needed (CAR# " & _
                                Me.WCD_No.Text & ")" & sInfo, sEmailContent)

                                WCAR_Activity1Record.UpdateRecord(itemValue5.WCA_ID.ToString(), "Pending")
                            Next
                        End If
                    End If

                End If
            End If

            Me.DataChanged = True
            Me.ResetData = True

            Me.CheckSum = ""
            Dim recWCAR_Doc_Attach1TableControl As WCAR_Doc_Attach1TableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Attach1TableControl"), WCAR_Doc_Attach1TableControl)
            recWCAR_Doc_Attach1TableControl.SaveData()

            Dim recWCAR_Doc_Checker1TableControl As WCAR_Doc_Checker1TableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl)
            recWCAR_Doc_Checker1TableControl.SaveData()
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

                'Dim wc2 As WhereClause = New WhereClause
                'Dim itemValue2 As Sel_SysSetupUsers_EmailRecord
                'wc2.iAND(Sel_SysSetupUsers_EmailView.SSU_RowID, BaseFilter.ComparisonOperator.EqualsTo, SendTo_User_ID)

                'If Sel_SysSetupUsers_EmailView.GetRecords(wc2, Nothing, 0, 100).Length > 0 Then
                '    For Each itemValue2 In Sel_SysSetupUsers_EmailView.GetRecords(wc2, Nothing, 0, 100)
                '        If itemValue2.SSU_RowIDSpecified Then
                '            sEmail = itemValue2.SSUE_Email.ToString()
                '        End If
                '    Next
                'End If

                Dim email As New BaseClasses.Utils.MailSender

                email.AddFrom("noreply@anflocor.com")
                email.AddTo(sEmail)
                email.SetSubject(Subject)
                email.SetContent(Content)
                email.SetIsHtmlContent(True)
                email.SendMessage()
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "Send Email Error", ex.Message)
            End Try
        End Sub



        Public Overrides Sub DataBind()
            MyBase.DataBind()

            If Me.DataSource Is Nothing Then
                Return
            End If

            If Not Me.DataSource.GetCheckSumValue() Is Nothing AndAlso _
                (Me.CheckSum Is Nothing OrElse Me.CheckSum.Trim = "") Then
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If

            SetWCD_C_ID()
            SetWCD_Exp_Budget()
            SetWCD_Exp_Cur_Yr()
            SetWCD_Exp_Nxt_Yr()
            SetWCD_Exp_Prev_Total()
            SetWCD_Exp_Sub_Yr()
            SetWCD_Exp_Total()
            SetWCD_Exp_Under_Over_Budget()
            SetWCD_No()
            SetWCD_Proj_Inc_ACB()
            SetWCD_Project_No()
            SetWCD_Project_Title()
            SetWCD_Remark()
            SetWCD_Request_Date()
            SetWCD_Status()
            SetWCD_Submit()
            SetWCD_U_ID()
            SetWCD_Unit_Location()
            SetWCD_WCur_ID()
            SetWCD_WDT_ID()

            Me.IsNewRecord = True
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False

                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If

            Dim shouldResetControl As Boolean = False

            'if current log in user is not the creator -> disable submit button
            'only the creator can submit the document
            Me.WCD_Exp_Cur_Yr.Style("text-align") = "right"
            Me.WCD_Exp_Nxt_Yr.Style("text-align") = "right"
            Me.WCD_Exp_Sub_Yr.Style("text-align") = "right"
            Me.WCD_Exp_Total.Style("text-align") = "right"
            Me.WCD_Exp_Prev_Total.Style("text-align") = "right"
            Me.WCD_Exp_Budget.Style("text-align") = "right"
            Me.WCD_Exp_Under_Over_Budget.Style("text-align") = "right"
            If System.Web.HttpContext.Current.Session("UserID").ToString() <> Me.DataSource.WCD_U_ID.ToString() Then
                Me.WCD_Submit.Enabled = False
                Me.WCD_WDT_ID.Enabled = False
                Me.btnChecked.Visible = True
                Me.btnRemoveCheck.Visible = True
                Me.SaveButton.Visible = False
                '#################################
                Me.WCD_No.BorderStyle = BorderStyle.Solid
                Me.WCD_No.ReadOnly = True
                Me.WCD_Request_Date.BorderStyle = BorderStyle.Solid
                Me.WCD_Request_Date.ReadOnly = True
                Me.WCD_Project_Title.BorderStyle = BorderStyle.Solid
                Me.WCD_Project_Title.ReadOnly = True
                Me.WCD_Unit_Location.BorderStyle = BorderStyle.Solid
                Me.WCD_Unit_Location.ReadOnly = True
                Me.WCD_Project_No.BorderStyle = BorderStyle.Solid
                Me.WCD_Project_No.ReadOnly = True
                Me.WCD_Remark.BorderStyle = BorderStyle.Solid
                Me.WCD_Remark.ReadOnly = True
                Me.WCD_Supplementary_Manual.BorderStyle = BorderStyle.Solid
                Me.WCD_Supplementary_Manual.ReadOnly = True
                Me.WCD_Status.BorderStyle = BorderStyle.Solid
                Me.WCD_Status.ReadOnly = True
                Me.WCD_Exp_Cur_Yr.BorderStyle = BorderStyle.Solid
                Me.WCD_Exp_Cur_Yr.ReadOnly = True
                Me.WCD_Exp_Nxt_Yr.BorderStyle = BorderStyle.Solid
                Me.WCD_Exp_Nxt_Yr.ReadOnly = True
                Me.WCD_Exp_Sub_Yr.BorderStyle = BorderStyle.Solid
                Me.WCD_Exp_Sub_Yr.ReadOnly = True
                Me.WCD_Exp_Total.BorderStyle = BorderStyle.Solid
                Me.WCD_Exp_Total.ReadOnly = True
                Me.WCD_Exp_Prev_Total.BorderStyle = BorderStyle.Solid
                Me.WCD_Exp_Prev_Total.ReadOnly = True
                Me.WCD_Exp_Budget.BorderStyle = BorderStyle.Solid
                Me.WCD_Exp_Budget.ReadOnly = True
                Me.WCD_Exp_Under_Over_Budget.BorderStyle = BorderStyle.Solid
                Me.WCD_Exp_Under_Over_Budget.ReadOnly = True

                Me.WCD_C_ID.Enabled = False
                Me.WCD_Proj_Inc_ACB.Enabled = False
                Me.WCD_Supplementary.Enabled = False
                Me.WCD_Supplementary_WCD_ID.Enabled = False
                Me.WCD_WDT_ID.Enabled = False
                Me.WCD_Submit.Enabled = False
                Me.WCD_WCur_ID.Enabled = False
            Else 'creator
                Me.WCD_Submit.Enabled = True
                Me.WCD_WDT_ID.Enabled = True
                Me.btnChecked.Visible = False
                Me.btnRemoveCheck.Visible = False
                Me.SaveButton.Visible = True


                '#################################
                'Me.WCD_C_ID.BorderStyle = BorderStyle.NotSet
                'Me.WCD_C_ID.Enabled = True
            End If

            'since it is loaded -> find the minimum
            System.Web.HttpContext.Current.Session("CAR_Min") = "0"
            Dim sWhere As String = WCAR_Minimum1Table.WCM_C_ID.UniqueName & " = " & Me.WCD_C_ID.SelectedValue.ToString() & _
            " And " & WCAR_Minimum1Table.WCM_WCur_ID.UniqueName & " = " & Me.WCD_WCur_ID.SelectedValue.ToString()
            For Each oRec As WCAR_Minimum1Record In WCAR_Minimum1Table.GetRecords(sWhere, Nothing, 0, 100)
                System.Web.HttpContext.Current.Session("CAR_Min") = oRec.WCM_Min.ToString()
            Next

            'added 9/6/2013: OVG request (return status) pepanes **09.26.2013
            If Me.WCD_Status.Text = "Return" Then
                Me.WCD_C_ID.Enabled = False
                Me.WCD_No.Enabled = False
                Me.WCD_Request_Date.Enabled = False
                Me.WCD_Project_Title.Enabled = False
                Me.WCD_Unit_Location.Enabled = False
                Me.WCD_Project_No.Enabled = False
                Me.WCD_Proj_Inc_ACB.Enabled = False
                'Me.WCD_Remark.Enabled = False
                Me.WCD_Supplementary.Enabled = False
                Me.WCD_Supplementary_WCD_ID.Enabled = False
                Me.WCD_Supplementary_Manual.Enabled = False
                Me.WCD_WDT_ID.Enabled = False
                Me.WCD_WCur_ID.Enabled = False
                Me.WCD_Exp_Cur_Yr.Enabled = False
                Me.WCD_Exp_Nxt_Yr.Enabled = False
                Me.WCD_Exp_Sub_Yr.Enabled = False
                Me.WCD_Exp_Total.Enabled = False
                Me.WCD_Exp_Prev_Total.Enabled = False
                Me.WCD_Exp_Budget.Enabled = False
                Me.WCD_Exp_Under_Over_Budget.Enabled = False
                Me.imbFind.Enabled = False
                Me.imbRelated.Enabled = False

                Dim oTab1 As WCAR_Doc_Checker1TableControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl)
                ''Dim oTab2 As WCAR_Doc_ProjClassRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_ProjClassRecordControl"), WCAR_Doc_ProjClassRecordControl)
                Dim oTab3 As WCAR_Doc_Checker1TableControlRow = DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControlRow"), WCAR_Doc_Checker1TableControlRow)

                oTab1.WCAR_Doc_CheckerAddButton.Enabled = False
                ''oTab2.WCDoc_ProjClass_ID.Enabled = False
                If Not IsNothing(oTab3) Then
                    oTab3.WCDC_U_ID.Enabled = False
                End If

            End If

            '04-19-2016 ryan start'

            Dim wc1 As WhereClause = New WhereClause
            Dim bCanBeVoided As Boolean = True

            wc1.iAND(WCAR_Activity1Table.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCD_ID.ToString())
            For Each itemValue1 As WCAR_Activity1Record In WCAR_Activity1Table.GetRecords(wc1, Nothing, 0, 100)
                If itemValue1.WCA_Status.ToString() = "Approved" Or itemValue1.WCA_Status.ToString() = "Rejected" Or _
                itemValue1.WCA_Status.ToString() = "Voided" Or itemValue1.WCA_Status.ToString() = "Completed" Or _
                Mid(itemValue1.WCA_Status.ToString(), 1, 6) = "System" Then
                    bCanBeVoided = False
                End If
            Next

            If Not bCanBeVoided Or Me.DataSource.WCD_U_ID.ToString() <> System.Web.HttpContext.Current.Session("UserIDNorth").ToString() Or _
            Me.WCD_Status.Text = "Voided" Then
                Me.btnVoid.Visible = False

            ElseIf Not bCanBeVoided And Me.DataSource.WCD_U_ID.ToString() = System.Web.HttpContext.Current.Session("UserIDNorth").ToString() And _
            Me.WCD_Status.Text = "For Review" Then

                Me.btnVoid.Visible = True
            End If

            If Me.DataSource.WCD_U_ID.ToString() <> System.Web.HttpContext.Current.Session("UserIDNorth").ToString() Then
                If Not bCanBeVoided Or Me.WCD_Status.Text = "Voided" Then
                    Me.btnVoid.Visible = False
                End If
            ElseIf Me.DataSource.WCD_U_ID.ToString() = System.Web.HttpContext.Current.Session("UserIDNorth").ToString() Then
                'note: even if there is already an Action done with this document but is Rejected back to the Creator -> 'For Review'
                'enable the Voiding button
                If Not bCanBeVoided And Me.WCD_Status.Text = "For Review" Then
                    Me.btnVoid.Visible = True
                ElseIf bCanBeVoided And Me.WCD_Status.Text = "Pending" Then
                    Me.btnVoid.Visible = True
                    'ElseIf Not bCanBeVoided And Me.WCD_Status.Text = "Pending" Then

                Else
                    Me.btnVoid.Visible = False
                End If
            End If

            'end'


        End Sub

        Private Function Email_Message() As String
            '------- format email
            Dim sWhere1 As String = W_User1Table.W_U_ID.UniqueName & " = " & Me.WCD_U_ID.Text
            Dim sUser As String = ""
            For Each oRec As W_User1Record In W_User1Table.GetRecords(sWhere1, Nothing, 0, 100)
                sUser = oRec.W_U_Full_Name.ToString()
            Next
            'Dim sWhere1 As String = Sel_SysSetupUsers_EmailView.SSU_RowID.UniqueName & " = " & Me.WCD_U_ID.Text
            'Dim sUser As String = ""
            'For Each oRec As Sel_SysSetupUsers_EmailRecord In Sel_SysSetupUsers_EmailView.GetRecords(sWhere1, Nothing, 0, 100)
            '    sUser = oRec.SSU_FullName.ToString()
            'Next

            Dim sEmailContent As String = "Company: @C" & vbcrlf & vbcrlf & "Details:" & vbcrlf & "@D" & vbcrlf & _
            vbcrlf & "Request Date: @RD" & _
            vbcrlf & "Remarks: @Rem" & vbcrlf & "Total: @T"

            sEmailContent = Replace(sEmailContent, "@C", Me.WCD_C_ID.SelectedItem.ToString())
            sEmailContent = Replace(sEmailContent, "@D", Me.WCD_Project_Title.Text)
            sEmailContent = Replace(sEmailContent, "@RD", Me.WCD_Request_Date.Text)
            sEmailContent = Replace(sEmailContent, "@Rem", Me.WCD_Remark.Text)
            sEmailContent = Replace(sEmailContent, "@T", Me.WCD_Exp_Cur_Yr.Text)
            sEmailContent &= vbcrlf & "Creator: " & sUser
            sEmailContent &= vbCrLf & vbCrLf & "http://eportal.anflocor.com"

            Return sEmailContent
            '------- format email		
        End Function



        Public Overrides Sub btnChecked_Click(ByVal sender As Object, ByVal args As EventArgs)
            Dim url As String = "../sel_WCAR_Doc_Creator_Approver1/Show-Sel-WCAR-Doc-Creator-Approver1-Table.aspx"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing

            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                If (Not Me.Page.IsPageRefresh) Then
                    'WCAR_Doc_CheckerRecord.AddRecord(Me.WCD_ID.Text, System.Web.HttpContext.Current.Session("UserID").ToString())
                    Dim oRem As TextBox = DirectCast(Me.Page.FindControlRecursively("txtCoRequestRem"), TextBox)
                    WCAR_Doc_Checker1Record.UpdateRecord(Me.WCD_ID.Text, System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "Concurred", oRem.Text)
                    'send email to creator
                    Send_Email_Notification(Me.WCD_U_ID.Text, _
                    "CAR Co-Requester Concurred (CAR# " & Me.WCD_No.Text & ")", Email_Message())
                End If
                'WCAR_Doc_CheckerRecord.AddRecord(Me.WCD_ID.ToString(), System.Web.HttpContext.Current.Session("UserID").ToString())

                url = Me.ModifyRedirectUrl(url, "", False)
                url = Me.Page.ModifyRedirectUrl(url, "", False)
                Me.Page.CommitTransaction(sender)

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

        Public Overrides Sub btnRemoveCheck_Click(ByVal sender As Object, ByVal args As EventArgs)

            Dim url As String = "../sel_WCAR_Doc_Creator_Approver/Show-Sel-WCAR-Doc-Creator-Approver-Table.aspx"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                If (Not Me.Page.IsPageRefresh) Then
                    Dim oRem As TextBox = DirectCast(Me.Page.FindControlRecursively("txtCoRequestRem"), TextBox)
                    'WCAR_Doc_CheckerRecord.AddRecord(Me.WCD_ID.Text, System.Web.HttpContext.Current.Session("UserID").ToString())
                    WCAR_Doc_Checker1Record.UpdateRecord(Me.WCD_ID.Text, System.Web.HttpContext.Current.Session("UserIDNorth").ToString(), "", oRem.Text)
                End If

                url = Me.ModifyRedirectUrl(url, "", False)
                url = Me.Page.ModifyRedirectUrl(url, "", False)
                Me.Page.CommitTransaction(sender)

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




        Public Overrides Sub SaveButton_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../sel_WCAR_Doc_Creator_Approver1/Show-Sel-WCAR-Doc-Creator-Approver1-Table.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()


                If (Not Me.Page.IsPageRefresh) Then
                    Me.Page.SaveData()
                End If


                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)
                Me.Page.CommitTransaction(sender)
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

		Public Overrides Sub CancelButton_Click(ByVal sender As Object, ByVal args As EventArgs)

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


		Public Overrides Sub CancelButton1_Click(ByVal sender As Object, ByVal args As EventArgs)

            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            'cezar'

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



        Public Overrides Sub btnVoid_Click(ByVal sender As Object, ByVal args As EventArgs)


            Dim url As String = "../sel_WCAR_Doc_Creator_Approver1/Show-Sel-WCAR-Doc-Creator-Approver1-Table.aspx"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Try
                'note: search Activity table for same DOC ID -> use enumeration to update Status -> 'Voided'
                'note: update WCAR_Doc record Status -> 'Voided'

                Dim wc4 As WhereClause = New WhereClause
                Dim bExist As Boolean = False

                If Me.WCD_Submit.Text = "Yes" And Me.WCD_Status.Text = "Pending" Then

                    wc4.iAND(WCAR_Activity1Table.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)

                    For Each itemValue4 As WCAR_Activity1Record In WCAR_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                        'note: update Activity table (other user(s) if multiple approvers) -> 'System Voided'
                        If itemValue4.WCA_Status.ToString() <> "Pending" Then
                            'approver acted -> abort voiding
                            bExist = True
                            Throw New Exception("This item cannot be voided. Refresh this page to view the document status.")
                        End If
                        'WCAR_ActivityRecord.UpdateRecord(itemValue4.WCA_ID.ToString(), "System Voided")
                    Next

                    For Each itemValue4 As WCAR_Activity1Record In WCAR_Activity1Table.GetRecords(wc4, Nothing, 0, 100)
                        WCAR_Activity1Record.UpdateRecord(itemValue4.WCA_ID.ToString(), "System Voided")
                    Next

                    url = Me.ModifyRedirectUrl(url, "", True)
                    url = Me.Page.ModifyRedirectUrl(url, "", True)

                End If

                If bExist Then Exit Sub

                'note: void CAR
                Dim wc6 As WhereClause = New WhereClause
                wc6.iAND(WCAR_Doc1Table.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.WCD_ID.Text)
                For Each itemValue6 As WCAR_Doc1Record In WCAR_Doc1Table.GetRecords(wc6, Nothing, 0, 100)
                    WCAR_Doc1Record.UpdateRecord(itemValue6.WCD_ID.ToString(), "Voided")
                Next

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

                Dim WCAR_DocTableControlObj As WCAR_Doc1RecordControl = DirectCast(Me.Page.FindControlRecursively("WCAR_Doc1RecordControl"), WCAR_Doc1RecordControl)
                WCAR_DocTableControlObj.ResetData = True
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
                shouldRedirect = False
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally

            End Try

            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If

        End Sub

        Public Overrides Sub SetWCD_Request_Date()




            ' Set the WCD_Request_Date TextBox on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Request_Date is the ASP:TextBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Request_Date()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Request_DateSpecified Then

                ' If the WCD_Request_Date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Request_Date, "g")

                Me.WCD_Request_Date.Text = formattedValue
                Me.WCD_Request_Date.Text = DateTime.Parse(Me.WCD_Request_Date.Text).ToShortDateString.ToString()
            Else

                ' WCD_Request_Date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.WCD_Request_Date.Text = WCAR_Doc1Table.WCD_Request_Date.Format(WCAR_Doc1Table.WCD_Request_Date.DefaultValue, "g")

            End If

            AddHandler Me.WCD_Request_Date.TextChanged, AddressOf WCD_Request_Date_TextChanged

        End Sub




End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the WCAR_Doc_Attach1TableControlRow control on the Edit_WCAR_Doc1 page.
' Do not modify this class. Instead override any method in WCAR_Doc_Attach1TableControlRow.
Public Class BaseWCAR_Doc_Attach1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCAR_Doc_Attach1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WCAR_Doc_Attach1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Show confirmation message on Click
              Me.WCAR_Doc_AttachRowDeleteButton.Attributes.Add("onClick", "return (confirm(""" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ePortalWFApproval") & """));")
                  
        
              ' Register the event handlers.
          
              AddHandler Me.WCAR_Doc_AttachRowDeleteButton.Click, AddressOf WCAR_Doc_AttachRowDeleteButton_Click
                        
              AddHandler Me.WCDA_WAT_ID.SelectedIndexChanged, AddressOf WCDA_WAT_ID_SelectedIndexChanged
            
              AddHandler Me.WCDA_Desc.TextChanged, AddressOf WCDA_Desc_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc_Attach record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCAR_Doc_Attach1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWCAR_Doc_Attach1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WCAR_Doc_Attach1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCAR_Doc_Attach1TableControlRow.
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
        
                
                SetWCDA_Desc()
                
                SetWCDA_FileImage()
                SetWCDA_WAT_ID()
                SetWCAR_Doc_AttachRowDeleteButton()
              
      
      
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
        
        
        Public Overridable Sub SetWCDA_Desc()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDA_Desc.ID) Then
            
                Me.WCDA_Desc.Text = Me.PreviousUIData(Me.WCDA_Desc.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDA_Desc TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc_Attach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc_Attach record retrieved from the database.
            ' Me.WCDA_Desc is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDA_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDA_DescSpecified Then
                				
                ' If the WCDA_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc_Attach1Table.WCDA_Desc)
                              
                Me.WCDA_Desc.Text = formattedValue
                
            Else 
            
                ' WCDA_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDA_Desc.Text = WCAR_Doc_Attach1Table.WCDA_Desc.Format(WCAR_Doc_Attach1Table.WCDA_Desc.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDA_Desc.TextChanged, AddressOf WCDA_Desc_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDA_FileImage()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDA_FileSpecified Then
                
                Me.WCDA_FileImage.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WCDA_FileImage.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WCAR_Doc_Attach1") & _
                            "&Field=" & Me.Page.Encrypt("WCDA_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.WCDA_FileImage.Visible = True
            Else
                Me.WCDA_FileImage.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetWCDA_WAT_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDA_WAT_ID.ID) Then
                If Me.PreviousUIData(Me.WCDA_WAT_ID.ID) Is Nothing
                    selectedValue = Nothing
                Else
                    selectedValue = Me.PreviousUIData(Me.WCDA_WAT_ID.ID).ToString()
                End If
            End If
            
        
            ' Set the WCDA_WAT_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc_Attach database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc_Attach record retrieved from the database.
            ' Me.WCDA_WAT_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDA_WAT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDA_WAT_IDSpecified Then
                            
                ' If the WCDA_WAT_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCDA_WAT_ID.ToString()
            Else
                
                ' WCDA_WAT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Doc_Attach1Table.WCDA_WAT_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCDA_WAT_IDDropDownList(selectedValue, 100)              
                
                  
           
             
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

      
        
        ' To customize, override this method in WCAR_Doc_Attach1TableControlRow.
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
        
        Dim parentCtrl As WCAR_Doc1RecordControl
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_Doc1RecordControl"), WCAR_Doc1RecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WCDA_WCD_ID = parentCtrl.DataSource.WCD_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_Attach1TableControl"), WCAR_Doc_Attach1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_Attach1TableControl"), WCAR_Doc_Attach1TableControl).ResetData = True
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

        ' To customize, override this method in WCAR_Doc_Attach1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCDA_Desc()
            GetWCDA_File()
            GetWCDA_WAT_ID()
        End Sub
        
        
        Public Overridable Sub GetWCDA_Desc()
            
            ' Retrieve the value entered by the user on the WCDA_Desc ASP:TextBox, and
            ' save it into the WCDA_Desc field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc_Attach record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCDA_Desc.Text, WCAR_Doc_Attach1Table.WCDA_Desc)			

                      
        End Sub
                
        Public Overridable Sub GetWCDA_File()
            ' Retrieve the value entered by the user on the WCDA_File ASP:FileUpload, and
            ' save it into the WCDA_File field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc_Attach record.
            ' Custom validation should be performed in Validate, not here.
                  
            If Not Me.WCDA_File.PostedFile is Nothing then  
                If Me.WCDA_File.PostedFile.FileName.Length > 0 AndAlso Me.WCDA_File.PostedFile.ContentLength > 0 Then
                      ' Retrieve the file contents and store them in WCDA_File field.
					  Me.DataSource.Parse(MiscUtils.GetFileContent(Me.WCDA_File.PostedFile), WCAR_Doc_Attach1Table.WCDA_File)
                  
                End If
            End If
        End Sub
                
        Public Overridable Sub GetWCDA_WAT_ID()
         
            ' Retrieve the value entered by the user on the WCDA_WAT_ID ASP:DropDownList, and
            ' save it into the WCDA_WAT_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc_Attach record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCDA_WAT_ID), WCAR_Doc_Attach1Table.WCDA_WAT_ID)				
            
        End Sub
                
      
        ' To customize, override this method in WCAR_Doc_Attach1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWCAR_Doc_Attach1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_Checker1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc1RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WCAR_Doc_Attach1TableControlRow.
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
          WCAR_Doc_Attach1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WCAR_Doc_Attach1TableControl"), WCAR_Doc_Attach1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WCAR_Doc_Attach1TableControl"), WCAR_Doc_Attach1TableControl).ResetData = True
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
        
        Public Overridable Sub SetWCAR_Doc_AttachRowDeleteButton()                
              
   
        End Sub
            
                        
        Public Overridable Function CreateWhereClause_WCDA_WAT_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.WAttach_Type table.
            ' Examples:
            ' wc.iAND(WAttach_Type1Table.WAT_Name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(WAttach_Type1Table.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
        ' Fill the WCDA_WAT_ID list.
        Protected Overridable Sub PopulateWCDA_WAT_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCDA_WAT_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WCDA_WAT_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCDA_WAT_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WCDA_WAT_IDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WAttach_Type1Table.WAT_Name, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As WAttach_Type1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = WAttach_Type1Table.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As WAttach_Type1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WAT_IDSpecified Then
                            cvalue = itemValue.WAT_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.WCDA_WAT_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc_Attach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc_Attach1Table.WCDA_WAT_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc_Attach1Table.WCDA_WAT_ID.IsApplyDisplayAs Then
                                fvalue = WCAR_Doc_Attach1Table.GetDFKA(itemValue, WCAR_Doc_Attach1Table.WCDA_WAT_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(WAttach_Type1Table.WAT_Name)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WCDA_WAT_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCDA_WAT_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WCDA_WAT_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCDA_WAT_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WAttach_Type.WAT_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WAttach_Type1Table.WAT_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WAttach_Type1Record = WAttach_Type1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WAttach_Type1Record = DirectCast(rc(0), WAttach_Type1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WAT_IDSpecified Then
                            cvalue = itemValue.WAT_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc_Attach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc_Attach1Table.WCDA_WAT_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc_Attach1Table.WCDA_WAT_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Doc_Attach1Table.GetDFKA(itemValue, WCAR_Doc_Attach1Table.WCDA_WAT_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WAttach_Type1Table.WAT_Name)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCDA_WAT_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        ' event handler for ImageButton
        Public Overridable Sub WCAR_Doc_AttachRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As WCAR_Doc_Attach1TableControl = DirectCast(GetParentControlObject(Me, "WCAR_Doc_Attach1TableControl"), WCAR_Doc_Attach1TableControl)
                If Not (IsNothing(tc)) Then
                    If Not Me.IsNewRecord Then
                        tc.AddToDeletedRecordIds(DirectCast(Me, WCAR_Doc_Attach1TableControlRow))
                    End If
                    Me.Visible = False
                    tc.SetFormulaControls()
                End If
              
            End If
      
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        Protected Overridable Sub WCDA_WAT_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCDA_WAT_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCDA_WAT_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCDA_WAT_ID.Items.Add(New ListItem(displayText, val))
                Me.WCDA_WAT_ID.SelectedIndex = Me.WCDA_WAT_ID.Items.Count - 1
                Me.Page.Session.Remove(WCDA_WAT_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCDA_WAT_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WCDA_Desc_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseWCAR_Doc_Attach1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCAR_Doc_Attach1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCAR_Doc_Attach1Record
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc_Attach1Record)
            End Get
            Set(ByVal value As WCAR_Doc_Attach1Record)
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
        
        Public ReadOnly Property WCAR_Doc_AttachRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_AttachRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property WCDA_Desc() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_Desc"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCDA_File() As System.Web.UI.WebControls.FileUpload
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_File"), System.Web.UI.WebControls.FileUpload)
            End Get
        End Property
            
        Public ReadOnly Property WCDA_FileImage() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_FileImage"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property WCDA_WAT_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_WAT_ID"), System.Web.UI.WebControls.DropDownList)
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
            
            Dim rec As WCAR_Doc_Attach1Record = Nothing
             
        
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
            
            Dim rec As WCAR_Doc_Attach1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCAR_Doc_Attach1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCAR_Doc_Attach1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WCAR_Doc_Attach1TableControl control on the Edit_WCAR_Doc1 page.
' Do not modify this class. Instead override any method in WCAR_Doc_Attach1TableControl.
Public Class BaseWCAR_Doc_Attach1TableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SortControl1) 				
                    initialVal = Me.GetFromSession(Me.SortControl1)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.SortControl1.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.SortControl1.SelectedValue = initialVal
                            
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
        
              ' Show confirmation message on Click
              Me.DeleteButton.Attributes.Add("onClick", "return (confirm(""" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ePortalWFApproval") & """));")
      
            ' Setup the pagination events.
                        
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.AddButton.Click, AddressOf AddButton_Click
                        
              AddHandler Me.DeleteButton.Click, AddressOf DeleteButton_Click
                        
              AddHandler Me.Actions1Button.Button.Click, AddressOf Actions1Button_Click
                        
              AddHandler Me.Filters1Button.Button.Click, AddressOf Filters1Button_Click
                        
            AddHandler Me.SortControl1.SelectedIndexChanged, AddressOf SortControl1_SelectedIndexChanged        
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WCAR_Doc_Attach1Record)), WCAR_Doc_Attach1Record())
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
                    For Each rc As WCAR_Doc_Attach1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WCAR_Doc_Attach1Record)), WCAR_Doc_Attach1Record())
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
            ByVal pageSize As Integer) As WCAR_Doc_Attach1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Doc_Attach1Table.Column1, True)         
            ' selCols.Add(WCAR_Doc_Attach1Table.Column2, True)          
            ' selCols.Add(WCAR_Doc_Attach1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WCAR_Doc_Attach1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WCAR_Doc_Attach1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WCAR_Doc_Attach1Record)), WCAR_Doc_Attach1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Doc_Attach1Table.Column1, True)         
            ' selCols.Add(WCAR_Doc_Attach1Table.Column2, True)          
            ' selCols.Add(WCAR_Doc_Attach1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WCAR_Doc_Attach1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WCAR_Doc_Attach1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Attach1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WCAR_Doc_Attach1TableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_Attach1TableControlRow"), WCAR_Doc_Attach1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                
                
                SetLiteral31()
                SetSortByLabel1()
                SetSortControl1()
                SetWCDA_DescLabel()
                SetWCDA_FileLabel()
                SetWCDA_WAT_IDLabel()
                SetAddButton()
              
                SetDeleteButton()
              
                SetActions1Button()
              
                SetFilters1Button()
              
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
             
              SetFilters1Button()
                     
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WCAR_Doc_Attach1Table.WCDA_WAT_ID, Me.DataSource)
          
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

            
            Me.SortControl1.ClearSelection()
            
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
        

            ' Bind the buttons for WCAR_Doc_Attach1TableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WCAR_Doc_Attach1TableControlRow
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
            WCAR_Doc_Attach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWCAR_Doc_Attach1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_Checker1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc1RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim wCAR_Doc1RecordControlObj as WCAR_Doc1RecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_Doc1RecordControl") ,WCAR_Doc1RecordControl)
                              
                If (Not IsNothing(wCAR_Doc1RecordControlObj) AndAlso Not IsNothing(wCAR_Doc1RecordControlObj.GetRecord()) AndAlso wCAR_Doc1RecordControlObj.GetRecord().IsCreated AndAlso Not IsNothing(wCAR_Doc1RecordControlObj.GetRecord().WCD_ID))
                    wc.iAND(WCAR_Doc_Attach1Table.WCDA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, wCAR_Doc1RecordControlObj.GetRecord().WCD_ID.ToString())
                    selectedRecordKeyValue.AddElement(WCAR_Doc_Attach1Table.WCDA_WCD_ID.InternalName, wCAR_Doc1RecordControlObj.GetRecord().WCD_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If          
              
      HttpContext.Current.Session("WCAR_Doc_Attach1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WCAR_Doc_Attach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWCAR_Doc_Attach1TableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_Checker1TableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc1RecordControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWCAR_Doc1RecordControl as String = DirectCast(HttpContext.Current.Session("WCAR_Doc_Attach1TableControlWhereClause"), String)
            
            If Not selectedRecordInWCAR_Doc1RecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWCAR_Doc1RecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWCAR_Doc1RecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WCAR_Doc_Attach1Table.WCDA_WCD_ID) Then
            wc.iAND(WCAR_Doc_Attach1Table.WCDA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WCAR_Doc_Attach1Table.WCDA_WCD_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Attach1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WCAR_Doc_Attach1TableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_Attach1TableControlRow"), WCAR_Doc_Attach1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WCAR_Doc_Attach1Record = New WCAR_Doc_Attach1Record()
        
                        If recControl.WCDA_Desc.Text <> "" Then
                            rec.Parse(recControl.WCDA_Desc.Text, WCAR_Doc_Attach1Table.WCDA_Desc)
                        End If
                        If recControl.WCDA_FileImage.Text <> "" Then
                            rec.Parse(recControl.WCDA_FileImage.Text, WCAR_Doc_Attach1Table.WCDA_File)
                        End If
                        If MiscUtils.IsValueSelected(recControl.WCDA_WAT_ID) Then
                            rec.Parse(recControl.WCDA_WAT_ID.SelectedItem.Value, WCAR_Doc_Attach1Table.WCDA_WAT_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WCAR_Doc_Attach1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WCAR_Doc_Attach1Record)), WCAR_Doc_Attach1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WCAR_Doc_Attach1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WCAR_Doc_Attach1TableControlRow) As Boolean
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
        
        Public Overridable Sub SetLiteral31()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal31.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortByLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCDA_DescLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCDA_DescLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCDA_FileLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCDA_FileLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCDA_WAT_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCDA_WAT_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl1()

              
            
                Me.PopulateSortControl1(GetSelectedValue(Me.SortControl1,  GetFromSession(Me.SortControl1)), 500)					
                    
        End Sub
            
        ' Get the filters' data for SortControl1
        Protected Overridable Sub PopulateSortControl1(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl1.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDA Description {Txt:Ascending}"), "WCDA_Desc Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDA Description {Txt:Descending}"), "WCDA_Desc Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wcda WAT {Txt:Ascending}"), "WCDA_WAT_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wcda WAT {Txt:Descending}"), "WCDA_WAT_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl1, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl1.SelectedValue IsNot Nothing AndAlso Me.SortControl1.Items.FindByValue(Me.SortControl1.SelectedValue) Is Nothing
                Me.SortControl1.SelectedValue = Nothing
            End If

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
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("WCAR_Doc_Attach1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
                Dim recControl As WCAR_Doc_Attach1TableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_Attach1TableControlRow"), WCAR_Doc_Attach1TableControlRow)
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
        
            Me.SaveToSession(Me.SortControl1, Me.SortControl1.SelectedValue)
                  
        
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
          
            Me.SaveToSession(Me.SortControl1, Me.SortControl1.SelectedValue)
                  
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl1)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WCAR_Doc_Attach1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WCAR_Doc_Attach1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetAddButton()                
              
   
        End Sub
            
        Public Overridable Sub SetDeleteButton()                
              
   
        End Sub
            
        Public Overridable Sub SetActions1Button()                
              
   
        End Sub
            
        Public Overridable Sub SetFilters1Button()                
                      
         Dim themeButtonFilters1Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters1Button"), IThemeButtonWithArrow)
         themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub AddButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Me.AddNewRecord = 1
            Me.DataChanged = True
      
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub DeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Me.DeleteSelectedRecords(True)
                Me.SetFormulaControls()
                
          
            End If
      
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub Actions1Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub Filters1Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
        ' event handler for OrderSort
        Protected Overridable Sub SortControl1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
                Dim SelVal1 As String = Me.SortControl1.SelectedValue.ToUpper()
                Dim words1() As String = Split(SelVal1)
                If SelVal1 <> "" Then
                SelVal1 = SelVal1.Replace(words1(words1.Length() - 1), "").TrimEnd()
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WCAR_Doc_Attach1Table.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WCAR_Doc_Attach1Table.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WCAR_Doc_Attach1Table.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not WCAR_Doc_Attach1Table.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WCAR_Doc_Attach1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WCAR_Doc_Attach1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WCAR_Doc_Attach1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WCAR_Doc_Attach1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc_Attach1Record())
            End Get
            Set(ByVal value() As WCAR_Doc_Attach1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Actions1Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Actions1Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property AddButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property DeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Filters1Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Filters1Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property Literal31() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal31"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SortByLabel1() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortByLabel1"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
          Public ReadOnly Property SortControl1() As System.Web.UI.WebControls.DropDownList
          Get
          Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortControl1"), System.Web.UI.WebControls.DropDownList)
          End Get
          End Property
        
        Public ReadOnly Property WCDA_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDA_FileLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_FileLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDA_WAT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_WAT_IDLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WCAR_Doc_Attach1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Doc_Attach1Record = Nothing     
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
                Dim recCtl As WCAR_Doc_Attach1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Doc_Attach1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WCAR_Doc_Attach1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WCAR_Doc_Attach1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WCAR_Doc_Attach1TableControlRow)), WCAR_Doc_Attach1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WCAR_Doc_Attach1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WCAR_Doc_Attach1TableControlRow
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

        Public Overridable Function GetRecordControls() As WCAR_Doc_Attach1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WCAR_Doc_Attach1TableControlRow")
            Dim list As New List(Of WCAR_Doc_Attach1TableControlRow)
            For Each recCtrl As WCAR_Doc_Attach1TableControlRow In recCtrls
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

  
' Base class for the WCAR_Doc_Checker1TableControlRow control on the Edit_WCAR_Doc1 page.
' Do not modify this class. Instead override any method in WCAR_Doc_Checker1TableControlRow.
Public Class BaseWCAR_Doc_Checker1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCAR_Doc_Checker1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WCAR_Doc_Checker1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Show confirmation message on Click
              Me.WCAR_Doc_CheckerRowDeleteButton.Attributes.Add("onClick", "return (confirm(""" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ePortalWFApproval") & """));")
                  
        
              ' Register the event handlers.
          
              AddHandler Me.WCAR_Doc_CheckerRowDeleteButton.Click, AddressOf WCAR_Doc_CheckerRowDeleteButton_Click
                        
              AddHandler Me.WCDC_U_ID.SelectedIndexChanged, AddressOf WCDC_U_ID_SelectedIndexChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc_Checker record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCAR_Doc_Checker1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWCAR_Doc_Checker1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WCAR_Doc_Checker1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCAR_Doc_Checker1TableControlRow.
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
        
                
                SetWCDC_Rem()
                SetWCDC_Status()
                SetWCDC_U_ID()
                SetWCAR_Doc_CheckerRowDeleteButton()
              
      
      
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
        
        
        Public Overridable Sub SetWCDC_Rem()

                  
            
        
            ' Set the WCDC_Rem Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc_Checker database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc_Checker record retrieved from the database.
            ' Me.WCDC_Rem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDC_Rem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDC_RemSpecified Then
                				
                ' If the WCDC_Rem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc_Checker1Table.WCDC_Rem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCDC_Rem.Text = formattedValue
                
            Else 
            
                ' WCDC_Rem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDC_Rem.Text = WCAR_Doc_Checker1Table.WCDC_Rem.Format(WCAR_Doc_Checker1Table.WCDC_Rem.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWCDC_Status()

                  
            
        
            ' Set the WCDC_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc_Checker database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc_Checker record retrieved from the database.
            ' Me.WCDC_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDC_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDC_StatusSpecified Then
                				
                ' If the WCDC_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc_Checker1Table.WCDC_Status)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCDC_Status.Text = formattedValue
                
            Else 
            
                ' WCDC_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDC_Status.Text = WCAR_Doc_Checker1Table.WCDC_Status.Format(WCAR_Doc_Checker1Table.WCDC_Status.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWCDC_U_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDC_U_ID.ID) Then
                If Me.PreviousUIData(Me.WCDC_U_ID.ID) Is Nothing
                    selectedValue = Nothing
                Else
                    selectedValue = Me.PreviousUIData(Me.WCDC_U_ID.ID).ToString()
                End If
            End If
            
        
            ' Set the WCDC_U_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc_Checker database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc_Checker record retrieved from the database.
            ' Me.WCDC_U_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDC_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDC_U_IDSpecified Then
                            
                ' If the WCDC_U_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCDC_U_ID.ToString()
            Else
                
                ' WCDC_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Doc_Checker1Table.WCDC_U_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCDC_U_IDDropDownList(selectedValue, 100)              
                
                  
           
             
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

      
        
        ' To customize, override this method in WCAR_Doc_Checker1TableControlRow.
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
        
        Dim parentCtrl As WCAR_Doc1RecordControl
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_Doc1RecordControl"), WCAR_Doc1RecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WCDC_WCD_ID = parentCtrl.DataSource.WCD_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl).ResetData = True
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

        ' To customize, override this method in WCAR_Doc_Checker1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCDC_Rem()
            GetWCDC_Status()
            GetWCDC_U_ID()
        End Sub
        
        
        Public Overridable Sub GetWCDC_Rem()
            
        End Sub
                
        Public Overridable Sub GetWCDC_Status()
            
        End Sub
                
        Public Overridable Sub GetWCDC_U_ID()
         
            ' Retrieve the value entered by the user on the WCDC_U_ID ASP:DropDownList, and
            ' save it into the WCDC_U_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc_Checker record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCDC_U_ID), WCAR_Doc_Checker1Table.WCDC_U_ID)				
            
        End Sub
                
      
        ' To customize, override this method in WCAR_Doc_Checker1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWCAR_Doc_Attach1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_Checker1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc1RecordControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WCAR_Doc_Checker1TableControlRow.
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
          WCAR_Doc_Checker1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl).ResetData = True
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
        
        Public Overridable Sub SetWCAR_Doc_CheckerRowDeleteButton()                
              
   
        End Sub
            
                        
        Public Overridable Function CreateWhereClause_WCDC_U_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.sel_WASP_User table.
            ' Examples:
            ' wc.iAND(Sel_WASP_User1View.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(Sel_WASP_User1View.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
        ' Fill the WCDC_U_ID list.
        Protected Overridable Sub PopulateWCDC_U_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCDC_U_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WCDC_U_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCDC_U_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WCDC_U_IDDropDownList()
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
                            
                            If counter < maxItems AndAlso Me.WCDC_U_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc_Checker1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc_Checker1Table.WCDC_U_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc_Checker1Table.WCDC_U_ID.IsApplyDisplayAs Then
                                fvalue = WCAR_Doc_Checker1Table.GetDFKA(itemValue, WCAR_Doc_Checker1Table.WCDC_U_ID)
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

                                Dim dupItem As ListItem = Me.WCDC_U_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCDC_U_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WCDC_U_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCDC_U_ID, selectedValue)Then

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
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc_Checker1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc_Checker1Table.WCDC_U_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc_Checker1Table.WCDC_U_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Doc_Checker1Table.GetDFKA(itemValue, WCAR_Doc_Checker1Table.WCDC_U_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(Sel_WASP_User1View.W_U_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCDC_U_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        ' event handler for ImageButton
        Public Overridable Sub WCAR_Doc_CheckerRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As WCAR_Doc_Checker1TableControl = DirectCast(GetParentControlObject(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl)
                If Not (IsNothing(tc)) Then
                    If Not Me.IsNewRecord Then
                        tc.AddToDeletedRecordIds(DirectCast(Me, WCAR_Doc_Checker1TableControlRow))
                    End If
                    Me.Visible = False
                    tc.SetFormulaControls()
                End If
              
            End If
      
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        Protected Overridable Sub WCDC_U_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCDC_U_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCDC_U_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCDC_U_ID.Items.Add(New ListItem(displayText, val))
                Me.WCDC_U_ID.SelectedIndex = Me.WCDC_U_ID.Items.Count - 1
                Me.Page.Session.Remove(WCDC_U_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCDC_U_ID.ClientID & "_SelectedDisplayText")
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
                Return CType(Me.ViewState("BaseWCAR_Doc_Checker1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCAR_Doc_Checker1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCAR_Doc_Checker1Record
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc_Checker1Record)
            End Get
            Set(ByVal value As WCAR_Doc_Checker1Record)
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
        
        Public ReadOnly Property WCAR_Doc_CheckerRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_CheckerRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property WCDC_Rem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_Rem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCDC_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCDC_U_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_U_ID"), System.Web.UI.WebControls.DropDownList)
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
            
            Dim rec As WCAR_Doc_Checker1Record = Nothing
             
        
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
            
            Dim rec As WCAR_Doc_Checker1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCAR_Doc_Checker1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCAR_Doc_Checker1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WCAR_Doc_Checker1TableControl control on the Edit_WCAR_Doc1 page.
' Do not modify this class. Instead override any method in WCAR_Doc_Checker1TableControl.
Public Class BaseWCAR_Doc_Checker1TableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SortControl2) 				
                    initialVal = Me.GetFromSession(Me.SortControl2)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.SortControl2.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.SortControl2.SelectedValue = initialVal
                            
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
        
              ' Show confirmation message on Click
              Me.DeleteButton1.Attributes.Add("onClick", "return (confirm(""" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ePortalWFApproval") & """));")
      
            ' Setup the pagination events.
                        
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.AddButton1.Click, AddressOf AddButton1_Click
                        
              AddHandler Me.DeleteButton1.Click, AddressOf DeleteButton1_Click
                        
              AddHandler Me.WCAR_Doc_CheckerAddButton.Click, AddressOf WCAR_Doc_CheckerAddButton_Click
                        
              AddHandler Me.Actions2Button.Button.Click, AddressOf Actions2Button_Click
                        
              AddHandler Me.Filters2Button.Button.Click, AddressOf Filters2Button_Click
                        
            AddHandler Me.SortControl2.SelectedIndexChanged, AddressOf SortControl2_SelectedIndexChanged        
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WCAR_Doc_Checker1Record)), WCAR_Doc_Checker1Record())
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
                    For Each rc As WCAR_Doc_Checker1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WCAR_Doc_Checker1Record)), WCAR_Doc_Checker1Record())
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
            ByVal pageSize As Integer) As WCAR_Doc_Checker1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Doc_Checker1Table.Column1, True)         
            ' selCols.Add(WCAR_Doc_Checker1Table.Column2, True)          
            ' selCols.Add(WCAR_Doc_Checker1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WCAR_Doc_Checker1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WCAR_Doc_Checker1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WCAR_Doc_Checker1Record)), WCAR_Doc_Checker1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Doc_Checker1Table.Column1, True)         
            ' selCols.Add(WCAR_Doc_Checker1Table.Column2, True)          
            ' selCols.Add(WCAR_Doc_Checker1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WCAR_Doc_Checker1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WCAR_Doc_Checker1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WCAR_Doc_Checker1TableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_Checker1TableControlRow"), WCAR_Doc_Checker1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                
                
                SetSortByLabel2()
                SetSortControl2()
                
                SetWCDC_RemLabel()
                SetWCDC_StatusLabel()
                SetWCDC_U_IDLabel1()
                SetAddButton1()
              
                SetDeleteButton1()
              
                SetWCAR_Doc_CheckerAddButton()
              
                SetActions2Button()
              
                SetFilters2Button()
              
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
             
              SetFilters2Button()
                     
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WCAR_Doc_Checker1Table.WCDC_U_ID, Me.DataSource)
          
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

            
            Me.SortControl2.ClearSelection()
            
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
        

            ' Bind the buttons for WCAR_Doc_Checker1TableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WCAR_Doc_Checker1TableControlRow
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
            WCAR_Doc_Checker1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWCAR_Doc_Attach1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_Checker1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc1RecordControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim wCAR_Doc1RecordControlObj as WCAR_Doc1RecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_Doc1RecordControl") ,WCAR_Doc1RecordControl)
                              
                If (Not IsNothing(wCAR_Doc1RecordControlObj) AndAlso Not IsNothing(wCAR_Doc1RecordControlObj.GetRecord()) AndAlso wCAR_Doc1RecordControlObj.GetRecord().IsCreated AndAlso Not IsNothing(wCAR_Doc1RecordControlObj.GetRecord().WCD_ID))
                    wc.iAND(WCAR_Doc_Checker1Table.WCDC_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, wCAR_Doc1RecordControlObj.GetRecord().WCD_ID.ToString())
                    selectedRecordKeyValue.AddElement(WCAR_Doc_Checker1Table.WCDC_WCD_ID.InternalName, wCAR_Doc1RecordControlObj.GetRecord().WCD_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If          
              
      HttpContext.Current.Session("WCAR_Doc_Checker1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WCAR_Doc_Checker1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWCAR_Doc_Attach1TableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_Checker1TableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc1RecordControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWCAR_Doc1RecordControl as String = DirectCast(HttpContext.Current.Session("WCAR_Doc_Checker1TableControlWhereClause"), String)
            
            If Not selectedRecordInWCAR_Doc1RecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWCAR_Doc1RecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWCAR_Doc1RecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WCAR_Doc_Checker1Table.WCDC_WCD_ID) Then
            wc.iAND(WCAR_Doc_Checker1Table.WCDC_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WCAR_Doc_Checker1Table.WCDC_WCD_ID).ToString())
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WCAR_Doc_Checker1TableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_Checker1TableControlRow"), WCAR_Doc_Checker1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WCAR_Doc_Checker1Record = New WCAR_Doc_Checker1Record()
        
                        If recControl.WCDC_Rem.Text <> "" Then
                            rec.Parse(recControl.WCDC_Rem.Text, WCAR_Doc_Checker1Table.WCDC_Rem)
                        End If
                        If recControl.WCDC_Status.Text <> "" Then
                            rec.Parse(recControl.WCDC_Status.Text, WCAR_Doc_Checker1Table.WCDC_Status)
                        End If
                        If MiscUtils.IsValueSelected(recControl.WCDC_U_ID) Then
                            rec.Parse(recControl.WCDC_U_ID.SelectedItem.Value, WCAR_Doc_Checker1Table.WCDC_U_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WCAR_Doc_Checker1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WCAR_Doc_Checker1Record)), WCAR_Doc_Checker1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WCAR_Doc_Checker1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WCAR_Doc_Checker1TableControlRow) As Boolean
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
        
        Public Overridable Sub SetSortByLabel2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCDC_RemLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCDC_RemLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCDC_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCDC_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCDC_U_IDLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCDC_U_IDLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl2()

              
            
                Me.PopulateSortControl2(GetSelectedValue(Me.SortControl2,  GetFromSession(Me.SortControl2)), 500)					
                    
        End Sub
            
        ' Get the filters' data for SortControl2
        Protected Overridable Sub PopulateSortControl2(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl2.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC REM {Txt:Ascending}"), "WCDC_Rem Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC REM {Txt:Descending}"), "WCDC_Rem Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC Status {Txt:Ascending}"), "WCDC_Status Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC Status {Txt:Descending}"), "WCDC_Status Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC U {Txt:Ascending}"), "WCDC_U_ID Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC U {Txt:Descending}"), "WCDC_U_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl2, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl2.SelectedValue IsNot Nothing AndAlso Me.SortControl2.Items.FindByValue(Me.SortControl2.SelectedValue) Is Nothing
                Me.SortControl2.SelectedValue = Nothing
            End If

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
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("WCAR_Doc_Checker1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
                Dim recControl As WCAR_Doc_Checker1TableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_Checker1TableControlRow"), WCAR_Doc_Checker1TableControlRow)
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
        
            Me.SaveToSession(Me.SortControl2, Me.SortControl2.SelectedValue)
                  
        
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
          
            Me.SaveToSession(Me.SortControl2, Me.SortControl2.SelectedValue)
                  
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl2)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WCAR_Doc_Checker1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WCAR_Doc_Checker1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetAddButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetDeleteButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetWCAR_Doc_CheckerAddButton()                
              
   
        End Sub
            
        Public Overridable Sub SetActions2Button()                
              
   
        End Sub
            
        Public Overridable Sub SetFilters2Button()                
                      
         Dim themeButtonFilters2Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters2Button"), IThemeButtonWithArrow)
         themeButtonFilters2Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub AddButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Me.AddNewRecord = 1
            Me.DataChanged = True
      
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub DeleteButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Me.DeleteSelectedRecords(True)
                Me.SetFormulaControls()
                
          
            End If
      
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub WCAR_Doc_CheckerAddButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Me.AddNewRecord = 1
            Me.DataChanged = True
      
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub Actions2Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub Filters2Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
        ' event handler for OrderSort
        Protected Overridable Sub SortControl2_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
                Dim SelVal2 As String = Me.SortControl2.SelectedValue.ToUpper()
                Dim words2() As String = Split(SelVal2)
                If SelVal2 <> "" Then
                SelVal2 = SelVal2.Replace(words2(words2.Length() - 1), "").TrimEnd()
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WCAR_Doc_Checker1Table.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal2 Then
                SelVal2 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WCAR_Doc_Checker1Table.GetColumnByName(SelVal2))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WCAR_Doc_Checker1Table.GetColumnByName(SelVal2) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal2 <> "--PLEASE_SELECT--" AndAlso Not WCAR_Doc_Checker1Table.GetColumnByName(SelVal2) Is Nothing Then
                  If  words2(words2.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WCAR_Doc_Checker1Table.GetColumnByName(SelVal2),OrderByItem.OrderDir.Asc)
                  Elseif words2(words2.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WCAR_Doc_Checker1Table.GetColumnByName(SelVal2),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WCAR_Doc_Checker1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WCAR_Doc_Checker1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc_Checker1Record())
            End Get
            Set(ByVal value() As WCAR_Doc_Checker1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Actions2Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Actions2Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property AddButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AddButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property DeleteButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DeleteButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Filters2Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Filters2Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property SortByLabel2() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortByLabel2"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
          Public ReadOnly Property SortControl2() As System.Web.UI.WebControls.DropDownList
          Get
          Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortControl2"), System.Web.UI.WebControls.DropDownList)
          End Get
          End Property
        
        Public ReadOnly Property WCAR_Doc_CheckerAddButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_CheckerAddButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property WCDC_RemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_RemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDC_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDC_U_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_U_IDLabel1"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WCAR_Doc_Checker1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Doc_Checker1Record = Nothing     
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
                Dim recCtl As WCAR_Doc_Checker1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Doc_Checker1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WCAR_Doc_Checker1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WCAR_Doc_Checker1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WCAR_Doc_Checker1TableControlRow)), WCAR_Doc_Checker1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WCAR_Doc_Checker1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WCAR_Doc_Checker1TableControlRow
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

        Public Overridable Function GetRecordControls() As WCAR_Doc_Checker1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WCAR_Doc_Checker1TableControlRow")
            Dim list As New List(Of WCAR_Doc_Checker1TableControlRow)
            For Each recCtrl As WCAR_Doc_Checker1TableControlRow In recCtrls
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

  
' Base class for the WCAR_Doc1RecordControl control on the Edit_WCAR_Doc1 page.
' Do not modify this class. Instead override any method in WCAR_Doc1RecordControl.
Public Class BaseWCAR_Doc1RecordControl
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCAR_Doc1RecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

      
            ' Setup the filter and search events.
            
        End Sub

        '  To customize, override this method in WCAR_Doc1RecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.imbFind.Click, AddressOf imbFind_Click
                        
              AddHandler Me.imbRelated.Click, AddressOf imbRelated_Click
                        
              AddHandler Me.btnChecked.Button.Click, AddressOf btnChecked_Click
                        
              AddHandler Me.btnRemoveCheck.Button.Click, AddressOf btnRemoveCheck_Click
                        
              AddHandler Me.btnVoid.Button.Click, AddressOf btnVoid_Click
                        
              AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
                        
              AddHandler Me.CancelButton1.Button.Click, AddressOf CancelButton1_Click
                        
              AddHandler Me.SaveButton.Button.Click, AddressOf SaveButton_Click
                        
              AddHandler Me.WCD_C_ID.SelectedIndexChanged, AddressOf WCD_C_ID_SelectedIndexChanged
            
              AddHandler Me.WCD_WCur_ID.SelectedIndexChanged, AddressOf WCD_WCur_ID_SelectedIndexChanged
            
              AddHandler Me.WCD_WDT_ID.SelectedIndexChanged, AddressOf WCD_WDT_ID_SelectedIndexChanged
            
              AddHandler Me.WCD_Proj_Inc_ACB.CheckedChanged, AddressOf WCD_Proj_Inc_ACB_CheckedChanged
            
              AddHandler Me.WCD_Submit.CheckedChanged, AddressOf WCD_Submit_CheckedChanged
            
              AddHandler Me.WCD_Supplementary.CheckedChanged, AddressOf WCD_Supplementary_CheckedChanged
            
              AddHandler Me.WCD_Exp_Budget.TextChanged, AddressOf WCD_Exp_Budget_TextChanged
            
              AddHandler Me.WCD_Exp_Cur_Yr.TextChanged, AddressOf WCD_Exp_Cur_Yr_TextChanged
            
              AddHandler Me.WCD_Exp_Nxt_Yr.TextChanged, AddressOf WCD_Exp_Nxt_Yr_TextChanged
            
              AddHandler Me.WCD_Exp_Prev_Total.TextChanged, AddressOf WCD_Exp_Prev_Total_TextChanged
            
              AddHandler Me.WCD_Exp_Sub_Yr.TextChanged, AddressOf WCD_Exp_Sub_Yr_TextChanged
            
              AddHandler Me.WCD_Exp_Total.TextChanged, AddressOf WCD_Exp_Total_TextChanged
            
              AddHandler Me.WCD_Exp_Under_Over_Budget.TextChanged, AddressOf WCD_Exp_Under_Over_Budget_TextChanged
            
              AddHandler Me.WCD_No.TextChanged, AddressOf WCD_No_TextChanged
            
              AddHandler Me.WCD_Project_No.TextChanged, AddressOf WCD_Project_No_TextChanged
            
              AddHandler Me.WCD_Project_Title.TextChanged, AddressOf WCD_Project_Title_TextChanged
            
              AddHandler Me.WCD_Remark.TextChanged, AddressOf WCD_Remark_TextChanged
            
              AddHandler Me.WCD_Request_Date.TextChanged, AddressOf WCD_Request_Date_TextChanged
            
              AddHandler Me.WCD_Status.TextChanged, AddressOf WCD_Status_TextChanged
            
              AddHandler Me.WCD_Supplementary_Manual.TextChanged, AddressOf WCD_Supplementary_Manual_TextChanged
            
              AddHandler Me.WCD_Supplementary_WCD_ID.TextChanged, AddressOf WCD_Supplementary_WCD_ID_TextChanged
            
              AddHandler Me.WCD_U_ID.TextChanged, AddressOf WCD_U_ID_TextChanged
            
              AddHandler Me.WCD_Unit_Location.TextChanged, AddressOf WCD_Unit_Location_TextChanged
            					
              AddHandler Me.txtCoRequestRem.TextChanged, AddressOf txtCoRequestRem_TextChanged
                    
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCAR_Doc1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WCAR_Doc1RecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New WCAR_Doc1Record()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As WCAR_Doc1Record = WCAR_Doc1Table.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = WCAR_Doc1Table.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCAR_Doc1RecordControl.
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
        
                
                
                
                
                
                
                
                SetlblTotal1()
                SetLiteral()
                SetLiteral1()
                SetLiteral10()
                SetLiteral11()
                SetLiteral12()
                SetLiteral13()
                SetLiteral14()
                SetLiteral15()
                SetLiteral16()
                SetLiteral17()
                SetLiteral18()
                SetLiteral19()
                SetLiteral2()
                SetLiteral20()
                SetLiteral21()
                SetLiteral22()
                SetLiteral23()
                SetLiteral24()
                SetLiteral25()
                SetLiteral26()
                SetLiteral27()
                SetLiteral28()
                SetLiteral29()
                SetLiteral3()
                SetLiteral30()
                SetLiteral32()
                SetLiteral4()
                SetLiteral5()
                SetLiteral6()
                SetLiteral7()
                SetLiteral8()
                SetLiteral9()
                
                
                SettxtCoRequestRem()
                
                
                
                
                SetWCAR_Doc1TabContainer()
                SetWCAR_DocRecordControlTabContainer()
                
                
                SetWCD_C_ID()
                SetWCD_C_IDLabel()
                SetWCD_Exp_Budget()
                SetWCD_Exp_BudgetLabel()
                SetWCD_Exp_Cur_Yr()
                SetWCD_Exp_Cur_YrLabel()
                SetWCD_Exp_Nxt_Yr()
                SetWCD_Exp_Nxt_YrLabel()
                SetWCD_Exp_Prev_Total()
                SetWCD_Exp_Prev_TotalLabel()
                SetWCD_Exp_Sub_Yr()
                SetWCD_Exp_Sub_YrLabel()
                SetWCD_Exp_Total()
                SetWCD_Exp_TotalLabel()
                SetWCD_Exp_Under_Over_Budget()
                SetWCD_Exp_Under_Over_BudgetLabel()
                SetWCD_ID()
                SetWCD_No()
                SetWCD_NoLabel()
                SetWCD_Proj_Inc_ACB()
                SetWCD_Proj_Inc_ACBLabel()
                SetWCD_Project_No()
                SetWCD_Project_NoLabel()
                SetWCD_Project_Title()
                SetWCD_Project_TitleLabel()
                SetWCD_Remark()
                SetWCD_RemarkLabel()
                SetWCD_Request_Date()
                SetWCD_Request_DateLabel()
                SetWCD_Status()
                SetWCD_StatusLabel()
                SetWCD_Submit()
                SetWCD_SubmitLabel()
                SetWCD_Supplementary()
                SetWCD_Supplementary_Manual()
                SetWCD_Supplementary_WCD_ID()
                SetWCD_U_ID()
                SetWCD_Unit_Location()
                SetWCD_Unit_LocationLabel()
                SetWCD_WCur_ID()
                SetWCD_WCur_IDLabel()
                SetWCD_WDT_ID()
                SetWCD_WDT_IDLabel()
                SetimbFind()
              
                SetimbRelated()
              
                SetbtnChecked()
              
                SetbtnRemoveCheck()
              
                SetbtnVoid()
              
                SetCancelButton()
              
                SetCancelButton1()
              
                SetSaveButton()
              
      
      
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
              WCAR_Doc_Attach1TableControl.ResetControl()
            End IF
                    
        SetWCAR_Doc_Attach1TableControl()
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              WCAR_Doc_Checker1TableControl.ResetControl()
            End IF
                    
        SetWCAR_Doc_Checker1TableControl()
        
        End Sub
        
        
        Public Overridable Sub SetWCD_C_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WCD_C_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_C_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_C_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_C_IDSpecified Then
                            
                ' If the WCD_C_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCD_C_ID.ToString()
            Else
                
                ' WCD_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Doc1Table.WCD_C_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCD_C_IDDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Budget()

                  
            
        
            ' Set the WCD_Exp_Budget TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Budget is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Budget()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_BudgetSpecified Then
                				
                ' If the WCD_Exp_Budget is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Exp_Budget)
                              
                Me.WCD_Exp_Budget.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Budget is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Budget.Text = WCAR_Doc1Table.WCD_Exp_Budget.Format(WCAR_Doc1Table.WCD_Exp_Budget.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Exp_Budget.TextChanged, AddressOf WCD_Exp_Budget_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Cur_Yr()

                  
            
        
            ' Set the WCD_Exp_Cur_Yr TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Cur_Yr is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Cur_Yr()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Cur_YrSpecified Then
                				
                ' If the WCD_Exp_Cur_Yr is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Exp_Cur_Yr)
                              
                Me.WCD_Exp_Cur_Yr.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Cur_Yr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Cur_Yr.Text = WCAR_Doc1Table.WCD_Exp_Cur_Yr.Format(WCAR_Doc1Table.WCD_Exp_Cur_Yr.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Exp_Cur_Yr.TextChanged, AddressOf WCD_Exp_Cur_Yr_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Nxt_Yr()

                  
            
        
            ' Set the WCD_Exp_Nxt_Yr TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Nxt_Yr is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Nxt_Yr()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Nxt_YrSpecified Then
                				
                ' If the WCD_Exp_Nxt_Yr is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Exp_Nxt_Yr)
                              
                Me.WCD_Exp_Nxt_Yr.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Nxt_Yr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Nxt_Yr.Text = WCAR_Doc1Table.WCD_Exp_Nxt_Yr.Format(WCAR_Doc1Table.WCD_Exp_Nxt_Yr.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Exp_Nxt_Yr.TextChanged, AddressOf WCD_Exp_Nxt_Yr_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Prev_Total()

                  
            
        
            ' Set the WCD_Exp_Prev_Total TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Prev_Total is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Prev_Total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Prev_TotalSpecified Then
                				
                ' If the WCD_Exp_Prev_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Exp_Prev_Total)
                              
                Me.WCD_Exp_Prev_Total.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Prev_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Prev_Total.Text = WCAR_Doc1Table.WCD_Exp_Prev_Total.Format(WCAR_Doc1Table.WCD_Exp_Prev_Total.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Exp_Prev_Total.TextChanged, AddressOf WCD_Exp_Prev_Total_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Sub_Yr()

                  
            
        
            ' Set the WCD_Exp_Sub_Yr TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Sub_Yr is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Sub_Yr()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Sub_YrSpecified Then
                				
                ' If the WCD_Exp_Sub_Yr is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Exp_Sub_Yr)
                              
                Me.WCD_Exp_Sub_Yr.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Sub_Yr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Sub_Yr.Text = WCAR_Doc1Table.WCD_Exp_Sub_Yr.Format(WCAR_Doc1Table.WCD_Exp_Sub_Yr.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Exp_Sub_Yr.TextChanged, AddressOf WCD_Exp_Sub_Yr_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Total()

                  
            
        
            ' Set the WCD_Exp_Total TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Total is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_TotalSpecified Then
                				
                ' If the WCD_Exp_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Exp_Total)
                              
                Me.WCD_Exp_Total.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Total.Text = WCAR_Doc1Table.WCD_Exp_Total.Format(WCAR_Doc1Table.WCD_Exp_Total.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Exp_Total.TextChanged, AddressOf WCD_Exp_Total_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Under_Over_Budget()

                  
            
        
            ' Set the WCD_Exp_Under_Over_Budget TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Under_Over_Budget is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Under_Over_Budget()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Under_Over_BudgetSpecified Then
                				
                ' If the WCD_Exp_Under_Over_Budget is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Exp_Under_Over_Budget)
                              
                Me.WCD_Exp_Under_Over_Budget.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Under_Over_Budget is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Under_Over_Budget.Text = WCAR_Doc1Table.WCD_Exp_Under_Over_Budget.Format(WCAR_Doc1Table.WCD_Exp_Under_Over_Budget.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Exp_Under_Over_Budget.TextChanged, AddressOf WCD_Exp_Under_Over_Budget_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_ID()

                  
            
        
            ' Set the WCD_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_IDSpecified Then
                				
                ' If the WCD_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_ID.Text = formattedValue
                
            Else 
            
                ' WCD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_ID.Text = WCAR_Doc1Table.WCD_ID.Format(WCAR_Doc1Table.WCD_ID.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetWCD_No()

                  
            
        
            ' Set the WCD_No TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_No is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_No()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_NoSpecified Then
                				
                ' If the WCD_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_No)
                              
                Me.WCD_No.Text = formattedValue
                
            Else 
            
                ' WCD_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_No.Text = WCAR_Doc1Table.WCD_No.Format(WCAR_Doc1Table.WCD_No.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_No.TextChanged, AddressOf WCD_No_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Proj_Inc_ACB()

                      
            
        
            ' Set the WCD_Proj_Inc_ACB CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Proj_Inc_ACB is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCD_Proj_Inc_ACB()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Proj_Inc_ACBSpecified Then
                									
                ' If the WCD_Proj_Inc_ACB is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.WCD_Proj_Inc_ACB.Checked = Me.DataSource.WCD_Proj_Inc_ACB
            Else
            
                ' WCD_Proj_Inc_ACB is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCD_Proj_Inc_ACB.Checked = WCAR_Doc1Table.WCD_Proj_Inc_ACB.ParseValue(WCAR_Doc1Table.WCD_Proj_Inc_ACB.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCD_Project_No()

                  
            
        
            ' Set the WCD_Project_No TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Project_No is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Project_No()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Project_NoSpecified Then
                				
                ' If the WCD_Project_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Project_No)
                              
                Me.WCD_Project_No.Text = formattedValue
                
            Else 
            
                ' WCD_Project_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Project_No.Text = WCAR_Doc1Table.WCD_Project_No.Format(WCAR_Doc1Table.WCD_Project_No.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Project_No.TextChanged, AddressOf WCD_Project_No_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Project_Title()

                  
            
        
            ' Set the WCD_Project_Title TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Project_Title is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Project_Title()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Project_TitleSpecified Then
                				
                ' If the WCD_Project_Title is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Project_Title)
                              
                Me.WCD_Project_Title.Text = formattedValue
                
            Else 
            
                ' WCD_Project_Title is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Project_Title.Text = WCAR_Doc1Table.WCD_Project_Title.Format(WCAR_Doc1Table.WCD_Project_Title.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Project_Title.TextChanged, AddressOf WCD_Project_Title_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Remark()

                  
            
        
            ' Set the WCD_Remark TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Remark is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_RemarkSpecified Then
                				
                ' If the WCD_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Remark)
                              
                Me.WCD_Remark.Text = formattedValue
                
            Else 
            
                ' WCD_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Remark.Text = WCAR_Doc1Table.WCD_Remark.Format(WCAR_Doc1Table.WCD_Remark.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Remark.TextChanged, AddressOf WCD_Remark_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Request_Date()

                  
            
        
            ' Set the WCD_Request_Date TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Request_Date is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Request_Date()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Request_DateSpecified Then
                				
                ' If the WCD_Request_Date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Request_Date, "g")
                              
                Me.WCD_Request_Date.Text = formattedValue
                
            Else 
            
                ' WCD_Request_Date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Request_Date.Text = WCAR_Doc1Table.WCD_Request_Date.Format(WCAR_Doc1Table.WCD_Request_Date.DefaultValue, "g")
                        		
                End If
                 
              AddHandler Me.WCD_Request_Date.TextChanged, AddressOf WCD_Request_Date_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Status()

                  
            
        
            ' Set the WCD_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Status is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_StatusSpecified Then
                				
                ' If the WCD_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Status)
                              
                Me.WCD_Status.Text = formattedValue
                
            Else 
            
                ' WCD_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Status.Text = WCAR_Doc1Table.WCD_Status.Format(WCAR_Doc1Table.WCD_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Status.TextChanged, AddressOf WCD_Status_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Submit()

                      
            
        
            ' Set the WCD_Submit CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Submit is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCD_Submit()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_SubmitSpecified Then
                									
                ' If the WCD_Submit is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.WCD_Submit.Checked = Me.DataSource.WCD_Submit
            Else
            
                ' WCD_Submit is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCD_Submit.Checked = WCAR_Doc1Table.WCD_Submit.ParseValue(WCAR_Doc1Table.WCD_Submit.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCD_Supplementary()

                      
            
        
            ' Set the WCD_Supplementary CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Supplementary is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCD_Supplementary()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_SupplementarySpecified Then
                									
                ' If the WCD_Supplementary is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.WCD_Supplementary.Checked = Me.DataSource.WCD_Supplementary
            Else
            
                ' WCD_Supplementary is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCD_Supplementary.Checked = WCAR_Doc1Table.WCD_Supplementary.ParseValue(WCAR_Doc1Table.WCD_Supplementary.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCD_Supplementary_Manual()

                  
            
        
            ' Set the WCD_Supplementary_Manual TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Supplementary_Manual is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Supplementary_Manual()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Supplementary_ManualSpecified Then
                				
                ' If the WCD_Supplementary_Manual is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Supplementary_Manual)
                              
                Me.WCD_Supplementary_Manual.Text = formattedValue
                
            Else 
            
                ' WCD_Supplementary_Manual is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Supplementary_Manual.Text = WCAR_Doc1Table.WCD_Supplementary_Manual.Format(WCAR_Doc1Table.WCD_Supplementary_Manual.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Supplementary_Manual.TextChanged, AddressOf WCD_Supplementary_Manual_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Supplementary_WCD_ID()

                  
            
        
            ' Set the WCD_Supplementary_WCD_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Supplementary_WCD_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Supplementary_WCD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Supplementary_WCD_IDSpecified Then
                				
                ' If the WCD_Supplementary_WCD_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Supplementary_WCD_ID)
                              
                Me.WCD_Supplementary_WCD_ID.Text = formattedValue
                
            Else 
            
                ' WCD_Supplementary_WCD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Supplementary_WCD_ID.Text = WCAR_Doc1Table.WCD_Supplementary_WCD_ID.Format(WCAR_Doc1Table.WCD_Supplementary_WCD_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Supplementary_WCD_ID.TextChanged, AddressOf WCD_Supplementary_WCD_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_U_ID()

                  
            
        
            ' Set the WCD_U_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_U_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_U_IDSpecified Then
                				
                ' If the WCD_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = Me.DataSource.WCD_U_ID.ToString()
                                
                            
                Me.WCD_U_ID.Text = formattedValue
                
            Else 
            
                ' WCD_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_U_ID.Text = WCAR_Doc1Table.WCD_U_ID.DefaultValue		
                End If
                 
              AddHandler Me.WCD_U_ID.TextChanged, AddressOf WCD_U_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_Unit_Location()

                  
            
        
            ' Set the WCD_Unit_Location TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Unit_Location is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Unit_Location()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Unit_LocationSpecified Then
                				
                ' If the WCD_Unit_Location is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc1Table.WCD_Unit_Location)
                              
                Me.WCD_Unit_Location.Text = formattedValue
                
            Else 
            
                ' WCD_Unit_Location is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Unit_Location.Text = WCAR_Doc1Table.WCD_Unit_Location.Format(WCAR_Doc1Table.WCD_Unit_Location.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCD_Unit_Location.TextChanged, AddressOf WCD_Unit_Location_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCD_WCur_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WCD_WCur_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_WCur_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_WCur_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_WCur_IDSpecified Then
                            
                ' If the WCD_WCur_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCD_WCur_ID.ToString()
            Else
                
                ' WCD_WCur_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Doc1Table.WCD_WCur_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCD_WCur_IDDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCD_WDT_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WCD_WDT_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Doc database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_WDT_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_WDT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_WDT_IDSpecified Then
                            
                ' If the WCD_WDT_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCD_WDT_ID.ToString()
            Else
                
                ' WCD_WDT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Doc1Table.WCD_WDT_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCD_WDT_IDDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetlblTotal1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral10()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral11()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal11.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral12()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal12.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral13()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal13.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral14()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral15()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral16()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal16.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral17()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral18()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral19()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral20()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral21()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral22()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral23()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral24()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral25()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral26()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral27()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal27.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral28()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal28.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral29()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral3()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal3.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral30()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral32()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal32.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral4()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal4.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral5()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral6()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal6.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral7()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal7.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral8()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal8.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral9()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal9.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SettxtCoRequestRem()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_C_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_C_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_BudgetLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Exp_BudgetLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Cur_YrLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Exp_Cur_YrLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Nxt_YrLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Exp_Nxt_YrLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Prev_TotalLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Exp_Prev_TotalLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Sub_YrLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Exp_Sub_YrLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_TotalLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Exp_TotalLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Under_Over_BudgetLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Exp_Under_Over_BudgetLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_NoLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_NoLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Proj_Inc_ACBLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Proj_Inc_ACBLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Project_NoLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Project_NoLabel.Text = "Some value"
                    
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
                
        Public Overridable Sub SetWCD_Request_DateLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Request_DateLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_SubmitLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_SubmitLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_Unit_LocationLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_Unit_LocationLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_WCur_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_WCur_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_WDT_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCD_WDT_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCAR_Doc1TabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "WCAR_Doc1TabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "WCAR_Doc1TabContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetWCAR_DocRecordControlTabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "WCAR_DocRecordControlTabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "WCAR_DocRecordControlTabContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetWCAR_Doc_Attach1TableControl()           
        
        
            If WCAR_Doc_Attach1TableControl.Visible Then
                WCAR_Doc_Attach1TableControl.LoadData()
                WCAR_Doc_Attach1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWCAR_Doc_Checker1TableControl()           
        
        
            If WCAR_Doc_Checker1TableControl.Visible Then
                WCAR_Doc_Checker1TableControl.LoadData()
                WCAR_Doc_Checker1TableControl.DataBind()
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
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"SaveButton"))
                        
        
        End Sub

      
        
        ' To customize, override this method in WCAR_Doc1RecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WCAR_Doc1RecordControlPanel"), System.Web.UI.WebControls.Panel)

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
          
        Dim recWCAR_Doc_Attach1TableControl as WCAR_Doc_Attach1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Attach1TableControl"), WCAR_Doc_Attach1TableControl)
        recWCAR_Doc_Attach1TableControl.SaveData()
          
        Dim recWCAR_Doc_Checker1TableControl as WCAR_Doc_Checker1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl)
        recWCAR_Doc_Checker1TableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WCAR_Doc1RecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCD_C_ID()
            GetWCD_Exp_Budget()
            GetWCD_Exp_Cur_Yr()
            GetWCD_Exp_Nxt_Yr()
            GetWCD_Exp_Prev_Total()
            GetWCD_Exp_Sub_Yr()
            GetWCD_Exp_Total()
            GetWCD_Exp_Under_Over_Budget()
            GetWCD_ID()
            GetWCD_No()
            GetWCD_Proj_Inc_ACB()
            GetWCD_Project_No()
            GetWCD_Project_Title()
            GetWCD_Remark()
            GetWCD_Request_Date()
            GetWCD_Status()
            GetWCD_Submit()
            GetWCD_Supplementary()
            GetWCD_Supplementary_Manual()
            GetWCD_Supplementary_WCD_ID()
            GetWCD_U_ID()
            GetWCD_Unit_Location()
            GetWCD_WCur_ID()
            GetWCD_WDT_ID()
        End Sub
        
        
        Public Overridable Sub GetWCD_C_ID()
         
            ' Retrieve the value entered by the user on the WCD_C_ID ASP:DropDownList, and
            ' save it into the WCD_C_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCD_C_ID), WCAR_Doc1Table.WCD_C_ID)				
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Budget()
            
            ' Retrieve the value entered by the user on the WCD_Exp_Budget ASP:TextBox, and
            ' save it into the WCD_Exp_Budget field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Exp_Budget.Text, WCAR_Doc1Table.WCD_Exp_Budget)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Cur_Yr()
            
            ' Retrieve the value entered by the user on the WCD_Exp_Cur_Yr ASP:TextBox, and
            ' save it into the WCD_Exp_Cur_Yr field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Exp_Cur_Yr.Text, WCAR_Doc1Table.WCD_Exp_Cur_Yr)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Nxt_Yr()
            
            ' Retrieve the value entered by the user on the WCD_Exp_Nxt_Yr ASP:TextBox, and
            ' save it into the WCD_Exp_Nxt_Yr field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Exp_Nxt_Yr.Text, WCAR_Doc1Table.WCD_Exp_Nxt_Yr)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Prev_Total()
            
            ' Retrieve the value entered by the user on the WCD_Exp_Prev_Total ASP:TextBox, and
            ' save it into the WCD_Exp_Prev_Total field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Exp_Prev_Total.Text, WCAR_Doc1Table.WCD_Exp_Prev_Total)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Sub_Yr()
            
            ' Retrieve the value entered by the user on the WCD_Exp_Sub_Yr ASP:TextBox, and
            ' save it into the WCD_Exp_Sub_Yr field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Exp_Sub_Yr.Text, WCAR_Doc1Table.WCD_Exp_Sub_Yr)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Total()
            
            ' Retrieve the value entered by the user on the WCD_Exp_Total ASP:TextBox, and
            ' save it into the WCD_Exp_Total field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Exp_Total.Text, WCAR_Doc1Table.WCD_Exp_Total)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Under_Over_Budget()
            
            ' Retrieve the value entered by the user on the WCD_Exp_Under_Over_Budget ASP:TextBox, and
            ' save it into the WCD_Exp_Under_Over_Budget field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Exp_Under_Over_Budget.Text, WCAR_Doc1Table.WCD_Exp_Under_Over_Budget)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_ID()
            
        End Sub
                
        Public Overridable Sub GetWCD_No()
            
            ' Retrieve the value entered by the user on the WCD_No ASP:TextBox, and
            ' save it into the WCD_No field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_No.Text, WCAR_Doc1Table.WCD_No)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Proj_Inc_ACB()
        
        
            ' Retrieve the value entered by the user on the WCD_Proj_Inc_ACB ASP:CheckBox, and
            ' save it into the WCD_Proj_Inc_ACB field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.WCD_Proj_Inc_ACB = Me.WCD_Proj_Inc_ACB.Checked
                    
        End Sub
                
        Public Overridable Sub GetWCD_Project_No()
            
            ' Retrieve the value entered by the user on the WCD_Project_No ASP:TextBox, and
            ' save it into the WCD_Project_No field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Project_No.Text, WCAR_Doc1Table.WCD_Project_No)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Project_Title()
            
            ' Retrieve the value entered by the user on the WCD_Project_Title ASP:TextBox, and
            ' save it into the WCD_Project_Title field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Project_Title.Text, WCAR_Doc1Table.WCD_Project_Title)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Remark()
            
            ' Retrieve the value entered by the user on the WCD_Remark ASP:TextBox, and
            ' save it into the WCD_Remark field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Remark.Text, WCAR_Doc1Table.WCD_Remark)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Request_Date()
            
            ' Retrieve the value entered by the user on the WCD_Request_Date ASP:TextBox, and
            ' save it into the WCD_Request_Date field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Request_Date.Text, WCAR_Doc1Table.WCD_Request_Date)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Status()
            
            ' Retrieve the value entered by the user on the WCD_Status ASP:TextBox, and
            ' save it into the WCD_Status field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Status.Text, WCAR_Doc1Table.WCD_Status)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Submit()
        
        
            ' Retrieve the value entered by the user on the WCD_Submit ASP:CheckBox, and
            ' save it into the WCD_Submit field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.WCD_Submit = Me.WCD_Submit.Checked
                    
        End Sub
                
        Public Overridable Sub GetWCD_Supplementary()
        
        
            ' Retrieve the value entered by the user on the WCD_Supplementary ASP:CheckBox, and
            ' save it into the WCD_Supplementary field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.WCD_Supplementary = Me.WCD_Supplementary.Checked
                    
        End Sub
                
        Public Overridable Sub GetWCD_Supplementary_Manual()
            
            ' Retrieve the value entered by the user on the WCD_Supplementary_Manual ASP:TextBox, and
            ' save it into the WCD_Supplementary_Manual field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Supplementary_Manual.Text, WCAR_Doc1Table.WCD_Supplementary_Manual)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Supplementary_WCD_ID()
            
            ' Retrieve the value entered by the user on the WCD_Supplementary_WCD_ID ASP:TextBox, and
            ' save it into the WCD_Supplementary_WCD_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Supplementary_WCD_ID.Text, WCAR_Doc1Table.WCD_Supplementary_WCD_ID)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_U_ID()
            
            ' Retrieve the value entered by the user on the WCD_U_ID ASP:TextBox, and
            ' save it into the WCD_U_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_U_ID.Text, WCAR_Doc1Table.WCD_U_ID)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_Unit_Location()
            
            ' Retrieve the value entered by the user on the WCD_Unit_Location ASP:TextBox, and
            ' save it into the WCD_Unit_Location field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCD_Unit_Location.Text, WCAR_Doc1Table.WCD_Unit_Location)			

                      
        End Sub
                
        Public Overridable Sub GetWCD_WCur_ID()
         
            ' Retrieve the value entered by the user on the WCD_WCur_ID ASP:DropDownList, and
            ' save it into the WCD_WCur_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCD_WCur_ID), WCAR_Doc1Table.WCD_WCur_ID)				
            
        End Sub
                
        Public Overridable Sub GetWCD_WDT_ID()
         
            ' Retrieve the value entered by the user on the WCD_WDT_ID ASP:DropDownList, and
            ' save it into the WCD_WDT_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Doc record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCD_WDT_ID), WCAR_Doc1Table.WCD_WDT_ID)				
            
        End Sub
                
      
        ' To customize, override this method in WCAR_Doc1RecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWCAR_Doc_Attach1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_Checker1TableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc1RecordControl As Boolean = False
      
            Dim wc As WhereClause
            WCAR_Doc1Table.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
                  Dim recId As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString.Item("WCAR_Doc1"))
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "ePortalWFApproval").Replace("{URL}", "WCAR_Doc1"))
            End If
            HttpContext.Current.Session("QueryString in Edit-WCAR-Doc1") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(WCAR_Doc1Table.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(WCAR_Doc1Table.WCD_ID))
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(WCAR_Doc1Table.WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            WCAR_Doc1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersWCAR_Doc_Attach1TableControl As Boolean = False
              
                Dim hasFiltersWCAR_Doc_Checker1TableControl As Boolean = False
              
                Dim hasFiltersWCAR_Doc1RecordControl As Boolean = False
              
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
        
    

        ' To customize, override this method in WCAR_Doc1RecordControl.
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
          WCAR_Doc1Table.DeleteRecord(pkValue)
          
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
        
        Public Overridable Sub SetimbFind()                
              
   
        End Sub
            
        Public Overridable Sub SetimbRelated()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnChecked()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnRemoveCheck()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnVoid()                
              
   
        End Sub
            
        Public Overridable Sub SetCancelButton()                
              
   
        End Sub
            
        Public Overridable Sub SetCancelButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetSaveButton()                
              
              Me.SaveButton.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, """ & Me.Page.GetResourceValue("Txt:SaveRecord", "ePortalWFApproval") & """);")
            
   
        End Sub
            
                        
        Public Overridable Function CreateWhereClause_WCD_C_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.sel_WF_DYNAMICS_Company table.
            ' Examples:
            ' wc.iAND(Sel_WF_DYNAMICS_Company1View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(Sel_WF_DYNAMICS_Company1View.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
                        
        Public Overridable Function CreateWhereClause_WCD_WCur_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.WCurrency table.
            ' Examples:
            ' wc.iAND(WCurrency1Table.WCur_Desc, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(WCurrency1Table.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
                        
        Public Overridable Function CreateWhereClause_WCD_WDT_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.WDoc_Type table.
            ' Examples:
            ' wc.iAND(WDoc_Type1Table.WDT_Name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(WDoc_Type1Table.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
        ' Fill the WCD_C_ID list.
        Protected Overridable Sub PopulateWCD_C_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCD_C_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WCD_C_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCD_C_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WCD_C_IDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Sel_WF_DYNAMICS_Company1View.Company_Short_Name, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As Sel_WF_DYNAMICS_Company1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = Sel_WF_DYNAMICS_Company1View.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As Sel_WF_DYNAMICS_Company1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.Company_IDSpecified Then
                            cvalue = itemValue.Company_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.WCD_C_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc1Table.WCD_C_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc1Table.WCD_C_ID.IsApplyDisplayAs Then
                                fvalue = WCAR_Doc1Table.GetDFKA(itemValue, WCAR_Doc1Table.WCD_C_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(Sel_WF_DYNAMICS_Company1View.Company_ID)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WCD_C_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCD_C_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WCD_C_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCD_C_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.sel_WF_DYNAMICS_Company.Company_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Sel_WF_DYNAMICS_Company1View.Company_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Sel_WF_DYNAMICS_Company1Record = Sel_WF_DYNAMICS_Company1View.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As Sel_WF_DYNAMICS_Company1Record = DirectCast(rc(0), Sel_WF_DYNAMICS_Company1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.Company_IDSpecified Then
                            cvalue = itemValue.Company_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc1Table.WCD_C_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc1Table.WCD_C_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Doc1Table.GetDFKA(itemValue, WCAR_Doc1Table.WCD_C_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(Sel_WF_DYNAMICS_Company1View.Company_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCD_C_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        ' Fill the WCD_WCur_ID list.
        Protected Overridable Sub PopulateWCD_WCur_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCD_WCur_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WCD_WCur_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCD_WCur_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WCD_WCur_IDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WCurrency1Table.WCur_Desc, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As WCurrency1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = WCurrency1Table.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As WCurrency1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WCur_IDSpecified Then
                            cvalue = itemValue.WCur_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.WCD_WCur_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc1Table.WCD_WCur_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc1Table.WCD_WCur_ID.IsApplyDisplayAs Then
                                fvalue = WCAR_Doc1Table.GetDFKA(itemValue, WCAR_Doc1Table.WCD_WCur_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(WCurrency1Table.WCur_Desc)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WCD_WCur_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCD_WCur_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WCD_WCur_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCD_WCur_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WCurrency.WCur_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WCurrency1Table.WCur_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WCurrency1Record = WCurrency1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WCurrency1Record = DirectCast(rc(0), WCurrency1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WCur_IDSpecified Then
                            cvalue = itemValue.WCur_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc1Table.WCD_WCur_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc1Table.WCD_WCur_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Doc1Table.GetDFKA(itemValue, WCAR_Doc1Table.WCD_WCur_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WCurrency1Table.WCur_Desc)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCD_WCur_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        ' Fill the WCD_WDT_ID list.
        Protected Overridable Sub PopulateWCD_WDT_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCD_WDT_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WCD_WDT_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCD_WDT_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WCD_WDT_IDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WDoc_Type1Table.WDT_Name, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As WDoc_Type1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = WDoc_Type1Table.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As WDoc_Type1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WDT_IDSpecified Then
                            cvalue = itemValue.WDT_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.WCD_WDT_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc1Table.WCD_WDT_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc1Table.WCD_WDT_ID.IsApplyDisplayAs Then
                                fvalue = WCAR_Doc1Table.GetDFKA(itemValue, WCAR_Doc1Table.WCD_WDT_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(WDoc_Type1Table.WDT_Name)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WCD_WDT_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCD_WDT_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WCD_WDT_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCD_WDT_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WDoc_Type.WDT_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WDoc_Type1Table.WDT_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WDoc_Type1Record = WDoc_Type1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WDoc_Type1Record = DirectCast(rc(0), WDoc_Type1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WDT_IDSpecified Then
                            cvalue = itemValue.WDT_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc1Table.WCD_WDT_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc1Table.WCD_WDT_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Doc1Table.GetDFKA(itemValue, WCAR_Doc1Table.WCD_WDT_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WDoc_Type1Table.WDT_Name)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCD_WDT_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        ' event handler for ImageButton
        Public Overridable Sub imbFind_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub imbRelated_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnChecked_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnRemoveCheck_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnVoid_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        
        ' event handler for Button
        Public Overridable Sub CancelButton1_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        
        ' event handler for Button
        Public Overridable Sub SaveButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
        
              If (Not Me.Page.IsPageRefresh) Then         
                  Me.Page.SaveData()
              End If        
        
            Me.Page.CommitTransaction(sender)
           Dim field As String = ""
           Dim formula As String = ""
           Dim displayFieldName As String = ""
           Dim value As String = ""
           Dim id As String = ""


            ' retrieve necessary URL parameters
            If Not String.IsNullOrEmpty(Page.Request("Target")) Then
                target = CType(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("Target")
            End If
            If Not String.IsNullOrEmpty(Page.Request("IndexField")) Then
                field = CType(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("IndexField")
            End If
            If Not String.IsNullOrEmpty(Page.Request("Formula")) Then
                formula = CType(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("Formula")
            End If
            If Not String.IsNullOrEmpty(Page.Request("DFKA")) Then
                displayFieldName = CType(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("DFKA")
            End If
            
            If target <> "" AndAlso field <> "" Then
          
                  If Not Me Is Nothing AndAlso Not Me.DataSource Is Nothing Then
                        id = Me.DataSource.GetValue(Me.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(field)).ToString
                        If formula <> "" Then
                            Dim variables as System.Collections.Generic.IDictionary(Of String, Object) = new System.Collections.Generic.Dictionary(Of String, Object)()
                            variables.Add(Me.DataSource.TableAccess.TableDefinition.TableCodeName, Me.DataSource)
                            value = EvaluateFormula(formula, Me.DataSource, Nothing,variables)
                        ElseIf displayFieldName = "" Then
                            value = id
                        Else
                            value = Me.DataSource.GetValue(Me.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(displayFieldName)).ToString
                        End If
                  End If
                  If value is Nothing Then
                      value = id
                  End If
                BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(Me, target, id, value)
                shouldRedirect = False
                
           ElseIf target <> "" Then
                BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(Me, target, Nothing, Nothing)           
                shouldRedirect = False          
           End If
         
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
      Me.Page.RedirectBack()
        
            End If
        End Sub
        
        Protected Overridable Sub WCD_C_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCD_C_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCD_C_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCD_C_ID.Items.Add(New ListItem(displayText, val))
                Me.WCD_C_ID.SelectedIndex = Me.WCD_C_ID.Items.Count - 1
                Me.Page.Session.Remove(WCD_C_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCD_C_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WCD_WCur_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCD_WCur_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCD_WCur_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCD_WCur_ID.Items.Add(New ListItem(displayText, val))
                Me.WCD_WCur_ID.SelectedIndex = Me.WCD_WCur_ID.Items.Count - 1
                Me.Page.Session.Remove(WCD_WCur_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCD_WCur_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WCD_WDT_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCD_WDT_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCD_WDT_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCD_WDT_ID.Items.Add(New ListItem(displayText, val))
                Me.WCD_WDT_ID.SelectedIndex = Me.WCD_WDT_ID.Items.Count - 1
                Me.Page.Session.Remove(WCD_WDT_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCD_WDT_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WCD_Proj_Inc_ACB_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCD_Submit_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCD_Supplementary_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCD_Exp_Budget_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Exp_Cur_Yr_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Exp_Nxt_Yr_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Exp_Prev_Total_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Exp_Sub_Yr_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Exp_Total_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Exp_Under_Over_Budget_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_No_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Project_No_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Project_Title_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Remark_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Request_Date_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Status_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Supplementary_Manual_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Supplementary_WCD_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_U_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCD_Unit_Location_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            		
        Protected Overridable Sub txtCoRequestRem_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
             
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
                Return CType(Me.ViewState("BaseWCAR_Doc1RecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCAR_Doc1RecordControl_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCAR_Doc1Record
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc1Record)
            End Get
            Set(ByVal value As WCAR_Doc1Record)
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
        
        Public ReadOnly Property btnChecked() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnChecked"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property btnRemoveCheck() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnRemoveCheck"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property btnVoid() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnVoid"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property CancelButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CancelButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property CancelButton1() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CancelButton1"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property imbFind() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbFind"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property imbRelated() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbRelated"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property lblTotal1() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lblTotal1"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
        Public ReadOnly Property Literal() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
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
        
        Public ReadOnly Property Literal12() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal12"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal13() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal13"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal14() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal14"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal15() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal15"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal16() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal16"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal17() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal17"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal18() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal18"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal19() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal19"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal20() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal20"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal21() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal21"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal22() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal22"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal23() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal23"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal24() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal24"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal25() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal25"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal26() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal26"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal27() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal27"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal28() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal28"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal29() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal29"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal30() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal30"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal32() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal32"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property Literal6() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal6"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property Literal9() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal9"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SaveButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SaveButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property Title0() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title0"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property txtCoRequestRem() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "txtCoRequestRem"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property WCAR_Doc_Attach1TableControl() As WCAR_Doc_Attach1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Attach1TableControl"), WCAR_Doc_Attach1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WCAR_Doc_Checker1TableControl() As WCAR_Doc_Checker1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_Checker1TableControl"), WCAR_Doc_Checker1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WCAR_Doc1TabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc1TabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property WCAR_DocRecordControlTabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_DocRecordControlTabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property WCD_C_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_C_ID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WCD_C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Budget() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Budget"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_BudgetLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_BudgetLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Cur_Yr() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Cur_Yr"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Cur_YrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Cur_YrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Nxt_Yr() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Nxt_Yr"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Nxt_YrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Nxt_YrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Prev_Total() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Prev_Total"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Prev_TotalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Prev_TotalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Sub_Yr() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Sub_Yr"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Sub_YrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Sub_YrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Total() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Total"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_TotalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_TotalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Under_Over_Budget() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Under_Over_Budget"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Under_Over_BudgetLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Under_Over_BudgetLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_No() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_No"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_NoLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_NoLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Proj_Inc_ACB() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Proj_Inc_ACB"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Proj_Inc_ACBLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Proj_Inc_ACBLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Project_No() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_No"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Project_NoLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_NoLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Project_Title() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_Title"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Project_TitleLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_TitleLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Remark() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Remark"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Request_Date() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Request_Date"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Request_DateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Request_DateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Status() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Status"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Submit() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Submit"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_SubmitLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_SubmitLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Supplementary() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Supplementary"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Supplementary_Manual() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Supplementary_Manual"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Supplementary_WCD_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Supplementary_WCD_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_U_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_U_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Unit_Location() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Unit_Location"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Unit_LocationLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Unit_LocationLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_WCur_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WCur_ID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WCD_WCur_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WCur_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_WDT_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WDT_ID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WCD_WDT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WDT_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WCAR_Doc1Record = Nothing
             
        
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
            
            Dim rec As WCAR_Doc1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCAR_Doc1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCAR_Doc1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  