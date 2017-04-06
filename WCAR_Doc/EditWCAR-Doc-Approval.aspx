<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="EditWCAR-Doc-Approval.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.EditWCAR_Doc_Approval" %>
<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.EditWCAR_Doc_Approval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">              
      <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style="position:absolute; padding:30px;" class="updatingContainer">
					<img src="../Images/updating.gif" alt="Updating" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<ePortalWFApproval:WCAR_DocRecordControl runat="server" id="WCAR_DocRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="Capital Appropriation Request Approval (South)">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right">
            
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="WCD_WDT_IDLabel1" Text="WCD WDT ID">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<BaseClasses:QuickSelector runat="server" id="WCD_WDT_IDFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"><ePortalWFApproval:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><table><tr><td><ePortalWFApproval:ThemeButton runat="server" id="CancelButton" button-causesvalidation="false" button-commandname="Redirect" button-text="Back to Dashboard" button-tooltip="Back to Dashboard"></ePortalWFApproval:ThemeButton></td></tr></table>
<br />
<hr></td></tr><tr><td><table><tr><td style="fls" class="fls"></td><td class="fls"><asp:Literal runat="server" id="Literal30">	</asp:Literal></td><td style="white-space:nowrap;text-align:left;" class="fls"></td><td style="white-space:nowrap;text-align:left;" class="fls"></td></tr><tr><td style="fls" class="fls"></td><td class="fls"></td><td style="white-space:nowrap;text-align:left;" class="fls"></td><td style="white-space:nowrap;text-align:left;" class="fls"></td></tr><tr><td style="fls" class="fls"></td><td style="text-align:left;vertical-align:middle;" class="fls"><b><asp:Literal runat="server" id="WCD_C_IDLabel" Text="Company:">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCD_C_ID" autopostback="True" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" width="279px"></asp:DropDownList></span>
</td><td style="white-space:nowrap;text-align:left;" rowspan="7" class="fls"> 
<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PanelExtender" runat="server" TargetControlid="CollapsibleRegion3" ExpandControlID="Icon" CollapseControlID="Icon" ImageControlID="Icon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Icon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><b>Workflow</b></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:Literal runat="server" id="Literal6" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td style="text-align:left;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_StatusLabel" Text="Status:">	</asp:Literal></b></td><td style="text-align:left;"><asp:Literal runat="server" id="Literal9" Text="&amp;nbsp;">	</asp:Literal></td><td style="text-align:left;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_Status" Columns="40" MaxLength="50" cssclass="field_input" enabled="False" width="337px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_StatusTextBoxMaxLengthValidator" ControlToValidate="WCD_Status" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="Literal1" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCD_WDT_ID" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" visible="False" width="337px"></asp:DropDownList></span>
</td></tr><tr><td style="text-align:left;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_WDT_IDLabel" Text="Workflow:">	</asp:Literal></b></td><td style="text-align:left;"><asp:Literal runat="server" id="Literal11" Text="&amp;nbsp;">	</asp:Literal></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_WDT_ID1" Columns="14" MaxLength="14" cssclass="field_input" readonly="True" width="337px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_WDT_ID1TextBoxMaxLengthValidator" ControlToValidate="WCD_WDT_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD WDT ID&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="Literal8" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td class="fls" style="text-align:left;vertical-align:middle;"><b><asp:literal id="Literal" runat="server" text="Action:" /></b></td><td style="text-align:left;"><asp:Literal runat="server" id="Literal12" Text="&amp;nbsp;">	</asp:Literal></td><td class="dfv" style="text-align:left;"><asp:dropdownlist id="ddlAction" runat="server" class="fls" width="337px" Name="ddlAction">
	<asp:listitem>Approve</asp:listitem>
	<asp:listitem>Reject</asp:listitem>
	<asp:listitem>Void</asp:listitem>
	<asp:listitem>Return</asp:listitem>
</asp:dropdownlist> 
<asp:literal id="Literal10" runat="server" text="&nbsp;" /></td></tr><tr><td class="fls" style="text-align:left;vertical-align:middle;"><b><asp:literal id="Literal7" runat="server" text="Return To:" /><br /></b></td><td></td><td class="dfv" style="text-align:left;"><asp:dropdownlist id="ddlMoveto" runat="server" class="fls" width="337px" enabled="false" Name="ddlMoveTo">
	
</asp:dropdownlist></td></tr><tr><td class="fls" style="text-align:left;vertical-align:middle;"><b><asp:literal id="Literal27" runat="server" text="Remark:" /></b></td><td></td><td class="dfv" style="text-align:left;"><asp:textbox id="txtRemark" runat="server" TextMode="MultiLine" Rows="2" Enabled="True" Width="325px" class="dfv" MaxLength="250" ForeColor="Black" /></td></tr><tr><td style="text-align:left;vertical-align:middle;"><b><asp:literal id="Literal19" runat="server" text="Approver(s)" /></b></td><td></td><td class="dfv" style="text-align:left;" rowspan="3"><asp:TextBox runat="server" id="TextBox" readonly="True" rows="4" textmode="MultiLine" width="330px">	</asp:TextBox></td></tr><tr><td style="text-align:left;"><b><asp:literal id="Literal3" runat="server" text="Previous" /></b></td><td></td></tr><tr><td style="text-align:left;"><b><asp:literal id="Literal18" runat="server" text="Remarks:" /></b></td><td></td></tr><tr><td><asp:literal id="Literal31" runat="server" text="&nbsp;" /></td><td></td><td style="text-align:right;"></td></tr><tr><td><ePortalWFApproval:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-redirectargument="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" postback="True" visible="False"></ePortalWFApproval:ThemeButton></td><td></td><td style="text-align:right;font-size:9pt;font-family:Tahoma;padding-right:10px;" class="fls"><asp:Button runat="server" id="btnSubmitAction" causesvalidation="False" commandname="Redirect" consumers="page" onclientclick="javascript:return confirm(&quot;Continue submission of this document with selected Action settings? Press OK to confirm document submission or press Cancel to abort operation.&quot;);" postback="False" redirectargument="UpdateData" text="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:Button></td></tr><tr><td><asp:literal id="Literal32" runat="server" text="&nbsp;" /></td><td></td><td></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td style="fls" class="fls"></td><td style="text-align:left;vertical-align:middle;" class="fls"><b><asp:Literal runat="server" id="WCD_NoLabel" Text="CAR No.:">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_No" Columns="40" MaxLength="50" cssclass="field_input" enabled="True" readonly="True" width="279px"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="WCD_NoRequiredFieldValidator" ControlToValidate="WCD_No" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_NoTextBoxMaxLengthValidator" ControlToValidate="WCD_No" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td style="fls" class="fls"></td><td style="text-align:left;vertical-align:middle;" class="fls"><b><asp:Literal runat="server" id="WCD_Request_DateLabel" Text="Creation Date:">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Request_Date" Columns="20" MaxLength="30" cssclass="field_input" dataformat="d" enabled="True" readonly="True" width="279px"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="WCD_Request_DateCalendarExtender" TargetControlID="WCD_Request_Date" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Request_DateTextBoxMaxLengthValidator" ControlToValidate="WCD_Request_Date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Request Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td style="fls" class="fls"></td><td style="text-align:left;vertical-align:top;" class="fls"><b><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Description:">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><asp:TextBox runat="server" id="WCD_Project_Title" MaxLength="2147483647" columns="120" cssclass="field_input" enabled="True" readonly="True" rows="8" textmode="MultiLine" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Project_TitleTextBoxMaxLengthValidator" ControlToValidate="WCD_Project_Title" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Project Title&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td style="fls" class="fls"><asp:Literal runat="server" id="Literal13" Text="&amp;nbsp;">	</asp:Literal></td><td style="text-align:left;vertical-align:middle;" class="fls"><b><asp:Literal runat="server" id="WCD_Unit_LocationLabel" Text="Unit &amp; Location:">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_Unit_Location" Columns="40" MaxLength="50" cssclass="field_input" enabled="True" readonly="True" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Unit_LocationTextBoxMaxLengthValidator" ControlToValidate="WCD_Unit_Location" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Unit Location&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td style="fls" class="fls"></td><td style="text-align:left;vertical-align:middle;" class="fls"><b><asp:Literal runat="server" id="WCD_Project_NoLabel" Text="Project No.:">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_Project_No" Columns="40" MaxLength="50" cssclass="field_input" enabled="True" readonly="True" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Project_NoTextBoxMaxLengthValidator" ControlToValidate="WCD_Project_No" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Project Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="fls"></td><td style="text-align:left;vertical-align:middle;" class="fls"><b><asp:Literal runat="server" id="WCD_Proj_Inc_ACBLabel" Text="Project Included :">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_Proj_Inc_ACB" Columns="5" MaxLength="5" checkedvalue="Yes" cssclass="field_input" enabled="True" readonly="True" uncheckedvalue="No"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Proj_Inc_ACBTextBoxMaxLengthValidator" ControlToValidate="WCD_Proj_Inc_ACB" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Proj Increment ACB&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:literal id="Literal5" runat="server" text="in Approved Capital Budget" /></td></tr><tr><td class="fls"></td><td style="text-align:left;vertical-align:top;" class="fls"><b><asp:Literal runat="server" id="WCD_RemarkLabel" Text="Remark:">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><b><asp:TextBox runat="server" id="WCD_Remark" MaxLength="2147483647" columns="0" cssclass="field_input" height="120px" readonly="True" rows="9" textmode="MultiLine" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_RemarkTextBoxMaxLengthValidator" ControlToValidate="WCD_Remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></b></td><td style="white-space:nowrap;text-align:left;" class="fls" rowspan="2"><BaseClasses:TabContainer runat="server" id="WCAR_DocRecordControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="WCAR_DocTabPanel1" HeaderText="Total Expenditure - This Request">	<ContentTemplate> 
  <table><tr><td><asp:literal id="Literal14" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_WCur_IDLabel" Text="Currency:">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCD_WCur_ID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="271px"></asp:DropDownList></span>
</td></tr><tr><td><asp:literal id="Literal25" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Cur_YrLabel" Text="This Year:">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Cur_Yr" Columns="20" MaxLength="26" autopostback="True" cssclass="field_input txtAlign-right" readonly="True" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Cur_YrTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Cur_Yr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration CUR Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td><asp:literal id="Literal24" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Nxt_YrLabel" Text="Next Year:">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Nxt_Yr" Columns="20" MaxLength="26" autopostback="True" cssclass="field_input txtAlign-right" readonly="True" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Nxt_YrTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Nxt_Yr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Next Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td><asp:literal id="Literal23" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Sub_YrLabel" Text="Subsequent Years:">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Sub_Yr" Columns="20" MaxLength="26" autopostback="True" cssclass="field_input txtAlign-right" readonly="True" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Sub_YrTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Sub_Yr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Sub Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td><asp:literal id="Literal26" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="Literal16" Text="Total">	</asp:Literal></b></td><td style="text-align:right;"><asp:label id="lblTotal1" runat="server" text="Your text for label goes here" width="268px" cssclass="txt-padding-right-lblTotal"></asp:label></td></tr></table>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WCAR_DocTabPanel" HeaderText="Total Expenditure">	<ContentTemplate> 
  <table><tr><td style="text-align:left;"><asp:literal id="Literal15" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="This Request:">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Total" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" readonly="True" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_TotalTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Total" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td style="text-align:left;"><asp:literal id="Literal17" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Prev_TotalLabel" Text="Previously Approved CAR:">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Prev_Total" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" readonly="True" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Prev_TotalTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Prev_Total" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Previous Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td style="text-align:left;"><asp:literal id="Literal20" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_BudgetLabel" Text="Budgeted Amount:">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Budget" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" readonly="True" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_BudgetTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Budget" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Budget&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td style="text-align:left;"><asp:literal id="Literal21" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Under_Over_BudgetLabel" Text="Under (Over) Budget:">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Under_Over_Budget" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" readonly="True" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Under_Over_BudgetTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Under_Over_Budget" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Under Over Budget&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td style="text-align:left;"><asp:literal id="Literal22" runat="server" text="&nbsp;" /></td><td></td></tr></table>
 
 </ContentTemplate></BaseClasses:TabPanel> 
  
</BaseClasses:TabContainer></td></tr><tr><td class="fls"></td><td style="text-align:left;vertical-align:top;" class="fls"><b><asp:Literal runat="server" id="Literal2" Text="Supplementary Of">	</asp:Literal></b></td><td style="white-space:nowrap;text-align:left;" class="fls"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Supplementary_WCD_ID" Columns="14" MaxLength="14" cssclass="field_input" enabled="True" readonly="True" width="279px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Supplementary_WCD_IDTextBoxMaxLengthValidator" ControlToValidate="WCD_Supplementary_WCD_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Supplementary WCD&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>

<asp:ImageButton CommandName="Redirect" runat="server" id="imbRelated" causesvalidation="false" imageurl="../Images/Book_openHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Related CARs&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton> <br />
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_Supplementary_Manual" Columns="40" MaxLength="50" cssclass="field_input" enabled="True" readonly="True" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Supplementary_ManualTextBoxMaxLengthValidator" ControlToValidate="WCD_Supplementary_Manual" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Supplementary Manual&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td class="fls"></td><td style="text-align:left;vertical-align:middle;" class="fls"></td><td style="white-space:nowrap;text-align:left;" class="fls"></td><td style="white-space:nowrap;text-align:left;" class="fls"></td></tr><tr><td class="fls"></td><td style="white-space:nowrap;text-align:left;" colspan="3" class="fls"><asp:Literal runat="server" id="Literal4" Text="&amp;nbsp;">	</asp:Literal></td></tr><tr><td class="fls"></td><td style="white-space:nowrap;text-align:left;" class="fls"><asp:Literal runat="server" id="Literal28" Text="&amp;nbsp;">	</asp:Literal></td><td style="white-space:nowrap;text-align:left;" class="fls"></td><td style="white-space:nowrap;text-align:left;" class="fls"></td></tr><tr><td class="fls"></td><td style="white-space:nowrap;text-align:left;" colspan="3" class="fls"><BaseClasses:TabContainer runat="server" id="WCAR_DocTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="WCAR_Doc_AttachTabPanel" HeaderText="Supporting Documents">	<ContentTemplate>
  <ePortalWFApproval:WCAR_Doc_AttachTableControl runat="server" id="WCAR_Doc_AttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Doc_AttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDA_FileLabel" Text="File Download">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDA_DescLabel" Text="Description">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDA_WAT_IDLabel" Text="Attach Type">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_Doc_AttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Doc_AttachTableControlRow runat="server" id="WCAR_Doc_AttachTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:LinkButton runat="server" id="WCDA_File" CommandName="Redirect"></asp:LinkButton></td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCDA_Desc"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCDA_WAT_ID"></asp:Literal></td></tr></ePortalWFApproval:WCAR_Doc_AttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_Doc_AttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Doc_AttachTableControl>

 </ContentTemplate></BaseClasses:TabPanel> 
<BaseClasses:TabPanel runat="server" id="WCAR_ActivityTabPanel" HeaderText="Approval History">	<ContentTemplate>
  <ePortalWFApproval:WCAR_ActivityTableControl runat="server" id="WCAR_ActivityTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_ActivityTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_W_U_IDLabel" Text="User(Assigned)">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_StatusLabel" Text="Status">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_Date_AssignLabel" Text="Date Assign">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_Date_ActionLabel" Text="Date Action">	</asp:Literal></b></th><th class="thcwb" style="padding:0px;vertical-align:middle;text-align:left;"><b><asp:Literal runat="server" id="WCA_RemarkLabel" Text="Remark">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_ActivityTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_ActivityTableControlRow runat="server" id="WCAR_ActivityTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCA_Status"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Assign"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Action"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:left;vertical-align:middle;"><asp:Literal runat="server" id="WCA_Remark"></asp:Literal></td></tr></ePortalWFApproval:WCAR_ActivityTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_ActivityTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_ActivityTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
 
 <BaseClasses:TabPanel runat="server" id="WCAR_Doc_CheckerTabPanel" HeaderText="Co-Requester">	<ContentTemplate>
  <ePortalWFApproval:WCAR_Doc_CheckerTableControl runat="server" id="WCAR_Doc_CheckerTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Doc_CheckerTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDC_U_IDLabel" Text="Full Name">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDC_StatusLabel" Text="Status">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDC_RemLabel" Text="Remarks">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_Doc_CheckerTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Doc_CheckerTableControlRow runat="server" id="WCAR_Doc_CheckerTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCDC_U_ID"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCDC_Status"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:left;vertical-align:middle;"><asp:Literal runat="server" id="WCDC_Rem"></asp:Literal></td></tr></ePortalWFApproval:WCAR_Doc_CheckerTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_Doc_CheckerTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Doc_CheckerTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer></td></tr><tr><td class="fls"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCD_ID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td><td class="fls"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_U_ID" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_U_IDTextBoxMaxLengthValidator" ControlToValidate="WCD_U_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD U&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td style="white-space:nowrap;text-align:left;" class="fls"></td><td style="white-space:nowrap;text-align:left;" class="fls"></td></tr></table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_DocRecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_DocRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                