<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.WFin_ApproverPage1" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationMedium" Src="../Shared/PaginationMedium.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="WFin-ApproverPage1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.WFin_ApproverPage1" %>
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
<ePortalWFApproval:WFinRep_HeadRecordControl runat="server" id="WFinRep_HeadRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="WFinRep_HeadTitle" Text="FS Workflow Approval (North)">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td class="recordPanelButtonsAlignment" style="text-align: right"> 
<table><tr><td><ePortalWFApproval:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="Back to Tasks" button-tooltip="Back to Tasks"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td>
                  <asp:panel id="WFinRep_HeadRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="WFinRep_HeadRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td></td><td></td><td></td><td></td></tr><tr><td></td><td><asp:Literal runat="server" id="Description" Text="Report Description">	</asp:Literal></td><td colspan="2" style="font-weight:bold;"><asp:Literal runat="server" id="Description_MY" Text="Report Description" visible="False">	</asp:Literal> 
<asp:Literal runat="server" id="HFIN_Description1" visible="True"></asp:Literal></td></tr><tr><td></td><td colspan="3">&nbsp;</td></tr><tr><td></td><td><asp:Literal runat="server" id="HFIN_StatusLabel" Text="Status">	</asp:Literal></td><td style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_Status"></asp:Literal></span>
 </td><td></td></tr><tr><td></td><td colspan="3">&nbsp;</td></tr><tr><td></td><td><asp:Literal runat="server" id="HFIN_DT_IDLabel" Text="Workflow Name">	</asp:Literal></td><td style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_DT_ID"></asp:Literal></span>
</td><td style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="HFIN_DT_ID1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td></tr><tr><td></td><td colspan="3">&nbsp;</td></tr><tr><td></td><td style="vertical-align:middle;"><asp:Literal runat="server" id="HFIN_RemarkLabel" Text="Remark(s)">	</asp:Literal></td><td style="font-weight:bold;"><asp:TextBox runat="server" id="txtRemarks" columns="30" rows="6" textmode="MultiLine">	</asp:TextBox></td><td style="font-weight:bold;"><asp:TextBox runat="server" id="HFIN_Remark" MaxLength="1073741823" columns="120" cssclass="field_input" height="350" rows="6" textmode="MultiLine" visible="False" width="640"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_RemarkTextBoxMaxLengthValidator" ControlToValidate="HFIN_Remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_ID" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_IDTextBoxMaxLengthValidator" ControlToValidate="HFIN_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Hfin&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td colspan="3">&nbsp;</td></tr><tr><td></td><td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_C_ID1" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_C_ID1TextBoxMaxLengthValidator" ControlToValidate="HFIN_C_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Hfin C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_C_ID" visible="False"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Month2" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_Month2TextBoxMaxLengthValidator" ControlToValidate="HFIN_Month2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td style="text-align:left;"><asp:Button runat="server" id="pApproved" causesvalidation="False" commandname="Redirect" consumers="page" font-name="Verdana" forecolor="Black" onclientclick="return confirm(&quot;Continue submission of this document? Press OK to confirm document submission or press Cancel to abort operation. Concerned approver or requester will be notified through email.&quot;);" text="Approve" width="100px">		
	</asp:Button> 
<asp:Button runat="server" id="pReject" causesvalidation="False" commandname="Redirect" consumers="page" font-name="Verdana" forecolor="Black" onclientclick="return confirm(&quot;Continue submission of this document with Reject action? Press OK to confirm document submission or press Cancel to abort operation. Concerned approver or requester will be notified through email.&quot;);" text="Reject" width="100px">		
	</asp:Button> 
<asp:Button runat="server" id="pReturned" causesvalidation="False" commandname="Redirect" consumers="page" font-name="Verdana" forecolor="Black" onclientclick="return confirm(&quot;Continue submission of this document with Return action? Press OK to confirm document submission or press Cancel to abort operation. Concerned approver or requester will be notified through email.&quot;);" text="Return for Revision" width="150px">		
	</asp:Button></td><td style="text-align:left;"><asp:dropdownlist cssclass="Filter_Input" id="ddlMoveTo" runat="server" width="238px" /></td></tr><tr><td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Year" Columns="14" MaxLength="14" cssclass="field_input" style="display:none;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_YearTextBoxMaxLengthValidator" ControlToValidate="HFIN_Year" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_U_ID" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_U_IDTextBoxMaxLengthValidator" ControlToValidate="HFIN_U_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Hfin U&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Status1" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_Status1TextBoxMaxLengthValidator" ControlToValidate="HFIN_Status1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_FinID" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_FinIDTextBoxMaxLengthValidator" ControlToValidate="HFIN_FinID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Hfin&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="HFIN_U_ID1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td></tr><tr><td></td><td colspan="3"><BaseClasses:TabContainer runat="server" id="TabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Report Details">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_HeadTableControl runat="server" id="WFinRep_HeadTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="WFinRep_HeadTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_HeadTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="HFIN_C_IDLabel" Text="Company">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_DescriptionLabel1" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_MonthLabel" Text="Month">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_YearLabel" Text="Year">	</asp:Literal></th><th class="thc" style="text-align:right;"><asp:Literal runat="server" id="HFIN_RptCountLabel" Text="Report Count">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_RemarkLabel1" Text="Remark">	</asp:Literal></th><th class="thc" style="text-align:center;" colspan="2"><asp:Literal runat="server" id="HFIN_RemarkLabel2" Text="Actions">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_HeadTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_HeadTableControlRow runat="server" id="WFinRep_HeadTableControlRow">
<tr><td class="tableCellValue" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_C_ID2"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_C_ID3" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_C_ID3TextBoxMaxLengthValidator" ControlToValidate="HFIN_C_ID3" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Hfin C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue" style="font-weight:bold;"><asp:Literal runat="server" id="HFIN_Description"></asp:Literal> 
</td><td class="tableCellValue" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_Month"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Month1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_Month1TextBoxMaxLengthValidator" ControlToValidate="HFIN_Month1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
</td><td class="tableCellValue" style="font-weight:bold;text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_Year1"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Year2" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_Year2TextBoxMaxLengthValidator" ControlToValidate="HFIN_Year2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue" style="font-weight:bold;text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_RptCount"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Status2" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_Status2TextBoxMaxLengthValidator" ControlToValidate="HFIN_Status2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue" style="font-weight:bold;"><asp:Literal runat="server" id="HFIN_Remark1"></asp:Literal> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_ID1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_ID1TextBoxMaxLengthValidator" ControlToValidate="HFIN_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Hfin&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><table>
	<tr>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnPreview" button-causesvalidation="False" button-commandname="Redirect" button-text="Preview" button-tooltip="Preview"></ePortalWFApproval:ThemeButton></td>
		<td></td>
		<td></td>
	</tr>	
</table>
 

</td><td class="tableCellValue"><ePortalWFApproval:ThemeButton runat="server" id="btnPreview1" button-causesvalidation="False" button-commandname="Redirect" button-text="View As PDF" button-tooltip="
          "></ePortalWFApproval:ThemeButton> 
<asp:LinkButton runat="server" id="HFIN_File" CommandName="Redirect" visible="False"></asp:LinkButton></td></tr><tr><td class="tableCellValue" colspan="8"><BaseClasses:TabContainer runat="server" id="Wfin_HeadTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="DocAttachTabPanel" HeaderText="Reports Included">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_DocAttachTableControl runat="server" id="WFinRep_DocAttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WFinRep_DocAttachTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_DocAttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="FIN_TypeLabel" Text="Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIn_DescriptionLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIN_RWRemLabel" Text="Report Remarks">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_DocAttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_DocAttachTableControlRow runat="server" id="WFinRep_DocAttachTableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="FIN_Type"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="FIn_Description"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="FIN_RWRem"></asp:Literal> </td></tr></ePortalWFApproval:WFinRep_DocAttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WFinRep_DocAttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_DocAttachTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr></ePortalWFApproval:WFinRep_HeadTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr></table>
	<asp:hiddenfield id="WFinRep_HeadTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_HeadTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Attachments">	<ContentTemplate> 
  <ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportTypeTableControl runat="server" id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"></td><td class="prspace">&nbsp;</td><td class="pra"><ePortalWFApproval:PaginationMedium runat="server" id="Vw_FS_WFinRep_Attachment_PerReportTypePagination"></ePortalWFApproval:PaginationMedium>
            <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. --></td></tr></table>
</td></tr><tr><td class="tre"><table id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WFRT_DescriptionLabel" Text="Attachments(s) For">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRA_DescLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRA_DocLabel" Text="File Download">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow runat="server" id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow">
<tr><td class="tableCellValue" style="font-weight:bold;"><asp:Literal runat="server" id="WFRT_Description"></asp:Literal></td><td class="tableCellValue" style="font-weight:bold;"><asp:Literal runat="server" id="WFRA_Desc"></asp:Literal> </td><td class="tableCellValue" style="font-weight:bold;"><asp:LinkButton runat="server" id="WFRA_Doc" CommandName="Redirect" class="imageDropshadow" style="max-width:120px;margin:5px;"></asp:LinkButton></td></tr></ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr></table>
	<asp:hiddenfield id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportTypeTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel2" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_Activity1TableControl runat="server" id="WFinRep_Activity1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WFinRep_ActivityTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_Activity1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc">&nbsp; 
<asp:Literal runat="server" id="AFIN_W_U_IDLabel" Text="User(Assigned)">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="AFIN_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="AFIN_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc">&nbsp; 
<asp:Literal runat="server" id="AFIN_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_RemarkLabel" Text="Remark(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_Activity1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_Activity1TableControlRow runat="server" id="WFinRep_Activity1TableControlRow">
<tr><td class="tableCellValue" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_W_U_ID"></asp:Literal></span>
</td><td class="tableCellValue" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Status"></asp:Literal></span>
</td><td class="tableCellValue" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Assign"></asp:Literal></span>
</td><td class="tableCellValue" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Action"></asp:Literal></span>
</td><td class="tableCellValue" style="font-weight:bold;"><asp:Literal runat="server" id="AFIN_Remark"></asp:Literal></td></tr></ePortalWFApproval:WFinRep_Activity1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WFinRep_Activity1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_Activity1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WFinRep_HeadRecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_HeadRecordControl>
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
                