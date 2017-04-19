<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="WFinRepNGP-Approver1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.WFinRepNGP_Approver1" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.WFinRepNGP_Approver1" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                        <ePortalWFApproval:WFinRepNGP_Head1RecordControl runat="server" id="WFinRepNGP_Head1RecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="Workflow Approver Page (North Non GP)">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td style="float:right">
                    <table><tr><td></td></tr></table>
</td></tr><tr><td><table><tr><td><ePortalWFApproval:ThemeButton runat="server" id="CancelButton" button-causesvalidation="false" button-commandname="Redirect" button-text="Back" button-tooltip="Back"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td><asp:panel id="WFinRepNGP_Head1RecordControlPanel" runat="server"><table><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCHNGP_DescriptionLabel" Text="Description">	</asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCHNGP_Description"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_Month" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_MonthTextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Month" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WFRCHNGP_U_ID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_ID" visible="False"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCHNGP_StatusLabel" Text="Status">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_Status"></asp:Literal></span>
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="WFRCHNGP_Submit" visible="False"></asp:CheckBox></td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_C_ID" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_C_IDTextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_C_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_C_ID1" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_C_ID1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_C_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCHNGP_DT_IDLabel" Text="Workflow">	</asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_DT_ID"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_Year" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_YearTextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Year" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_DT_ID1" visible="False"></asp:Literal></span>
</td></tr><tr><td class="tableCellLabel"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_U_ID1" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_U_ID1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_U_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;U&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCHNGP_RemarkLabel" Text="Remarks">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:TextBox runat="server" id="txtRemarks" columns="60" rows="6" textmode="MultiLine">	</asp:TextBox></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellValue" colspan="2"><asp:Button runat="server" id="pApproved" causesvalidation="False" commandname="Redirect" consumers="page" text="Approve">		
	</asp:Button> 
<asp:Button runat="server" id="pReject" causesvalidation="False" commandname="Redirect" consumers="page" text="Reject">		
	</asp:Button> 
<asp:Button runat="server" id="pReturned" causesvalidation="False" commandname="Redirect" consumers="page" text="Return">		
	</asp:Button></td><td class="tableCellValue"><asp:TextBox runat="server" id="WFRCHNGP_Remark" MaxLength="1073741823" columns="5" cssclass="field_input" height="350" rows="2" textmode="MultiLine" visible="False" width="640"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_RemarkTextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue" colspan="4">&nbsp;</td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue" colspan="4"><asp:tabcontainer id="WFinRepNGP_Head1TabContainer" runat="server">
  <asp:tabpanel id="TabPanel" runat="server">
        <headertemplate>Document</headertemplate>
        <contenttemplate><ePortalWFApproval:WFinRepNGP_Head1TableControl runat="server" id="WFinRepNGP_Head1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRepNGP_Head1TableControlGrid"><tr class="tch"><th class="thcnb"><asp:Literal runat="server" id="WFRCHNGP_C_IDLabel" Text="Company">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_DescriptionLabel1" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_MonthLabel" Text="Month">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_YearLabel" Text="Year">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_RptCountLabel" Text="Report Count">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_RemarkLabel1" Text="Remarks">	</asp:Literal></th><th class="thc"></th></tr><asp:Repeater runat="server" id="WFinRepNGP_Head1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRepNGP_Head1TableControlRow runat="server" id="WFinRepNGP_Head1TableControlRow">
<tr><td class="tableRowButtonsCellVertical"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_C_ID2"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_C_ID3" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_C_ID3TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_C_ID3" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCHNGP_Description2"></asp:Literal> 
<asp:TextBox runat="server" id="WFRCHNGP_Description1" MaxLength="250" columns="60" cssclass="field_input" rows="5" textmode="MultiLine" style="display:none"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_Description1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Description1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_Month1"></asp:Literal></span>
  
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_Month2" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_Month2TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Month2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_Year1"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_Year2" Columns="14" MaxLength="14" cssclass="field_input" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_Year2TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Year2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_RptCount"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_ID1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_ID1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP ID&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCHNGP_Remark1"></asp:Literal> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_Status1" Columns="14" MaxLength="14" cssclass="field_input" minlistitems="Default" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_Status1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Status1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><table>
	<tr>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnPreview" button-causesvalidation="False" button-commandname="Redirect" button-text="Preview" button-tooltip="Preview"></ePortalWFApproval:ThemeButton></td>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnPreview1" button-causesvalidation="False" button-commandname="Redirect" button-text="View As PDF" button-tooltip="View As PDF"></ePortalWFApproval:ThemeButton></td>
		<td><asp:LinkButton runat="server" id="WFRCHNGP_File" CommandName="Redirect" size="60" visible="False" style="display:none"></asp:LinkButton></td>
	</tr>
</table>
 </td></tr><tr><td class="ticnb" scope="row" colspan="7"><asp:tabcontainer id="WFinRepNGP_HeadTableControlTabContainer" runat="server">
    <asp:tabpanel id="TabPanel3" runat="server">
        <headertemplate>Reports Included</headertemplate>
        <contenttemplate><ePortalWFApproval:WFinRepNGP_DocAttach1TableControl runat="server" id="WFinRepNGP_DocAttach1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1">	</asp:Literal>
                      </td></tr></table>
</td></tr></table>

                </td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRepNGP_DocAttach1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WFRCDNGP_TypeLabel" Text="Report Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCDNGP_DescriptionLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCDNGP_RWRemLabel" Text="Remarks">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRepNGP_DocAttach1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRepNGP_DocAttach1TableControlRow runat="server" id="WFinRepNGP_DocAttach1TableControlRow">
<tr><td class="tableCellValue"><asp:Literal runat="server" id="WFRCDNGP_Type"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCDNGP_Description"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCDNGP_RWRem"></asp:Literal></td></tr></ePortalWFApproval:WFinRepNGP_DocAttach1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_DocAttach1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_DocAttach1TableControl>
</contenttemplate>
    </asp:tabpanel>
</asp:tabcontainer> 
</td></tr></ePortalWFApproval:WFinRepNGP_Head1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_Head1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_Head1TableControl>
</contenttemplate>
    </asp:tabpanel>
    <asp:tabpanel id="TabPanel2" runat="server">
        <headertemplate>Attachments</headertemplate>
        <contenttemplate><ePortalWFApproval:WFinRepNGP_Attachment1TableControl runat="server" id="WFinRepNGP_Attachment1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRepNGP_Attachment1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WFRNGPAt_DescLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPAt_DocLabel" Text="File Download">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRepNGP_Attachment1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRepNGP_Attachment1TableControlRow runat="server" id="WFinRepNGP_Attachment1TableControlRow">
<tr><td class="tableCellValue"><asp:Literal runat="server" id="WFRNGPAt_Desc"></asp:Literal></td><td class="tableCellValue"><asp:LinkButton runat="server" id="WFRNGPAt_Doc" CommandName="Redirect" size="60"></asp:LinkButton></td></tr></ePortalWFApproval:WFinRepNGP_Attachment1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination1"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_Attachment1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_Attachment1TableControl>
</contenttemplate>
    </asp:tabpanel>
	 <asp:tabpanel id="TabPanel1" runat="server">
        <headertemplate>Approval History</headertemplate>
        <contenttemplate><ePortalWFApproval:WFinRepNGP_Activity1TableControl runat="server" id="WFinRepNGP_Activity1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRepNGP_Activity1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WFRNGPA_W_U_IDLabel" Text="User Assigned">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPA_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPA_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPA_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPA_RemarkLabel" Text="Remarks">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRepNGP_Activity1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRepNGP_Activity1TableControlRow runat="server" id="WFinRepNGP_Activity1TableControlRow">
<tr><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRNGPA_W_U_ID"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRNGPA_Status"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRNGPA_Date_Assign"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRNGPA_Date_Action"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="WFRNGPA_Remark"></asp:Literal></td></tr></ePortalWFApproval:WFinRepNGP_Activity1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_Activity1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_Activity1TableControl>
</ContentTemplate>
    </asp:tabpanel>
</asp:tabcontainer> 
</td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_Head1RecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_Head1RecordControl>

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
                