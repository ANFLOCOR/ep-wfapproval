<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.WFinRepNGP_Inquiry" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="WFinRepNGP-Inquiry.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.WFinRepNGP_Inquiry" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        
            <ePortalWFApproval:WFinRepNGP_HeadTableControl runat="server" id="WFinRepNGP_HeadTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;FS Report Inquiry (Non GP)&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table><tr><td><asp:Literal runat="server" id="WFRCHNGP_C_IDLabel1" Text="Company">	</asp:Literal></td><td><asp:DropDownList runat="server" id="WFRCHNGP_C_IDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="150px">	</asp:DropDownList> </td><td></td></tr><tr><td><asp:Literal runat="server" id="WFRCHNGP_MonthLabel1" Text="Month">	</asp:Literal></td><td><asp:DropDownList runat="server" id="WFRCHNGP_MonthFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="150px">	</asp:DropDownList> </td><td></td></tr><tr><td><asp:Literal runat="server" id="WFRCHNGP_YearLabel1" Text="Year">	</asp:Literal></td><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("GoButton"))%>
<asp:DropDownList runat="server" id="WFRCHNGP_YearFromFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="150px">	</asp:DropDownList> <span class="rft"></span> <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("GoButton"))%>
</td><td></td></tr><tr><td><asp:Literal runat="server" id="WFRCHNGP_StatusLabel1" Text="Status">	</asp:Literal></td><td><asp:DropDownList runat="server" id="WFRCHNGP_StatusFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="150px">	</asp:DropDownList> </td><td><ePortalWFApproval:ThemeButton runat="server" id="GoButton" button-causesvalidation="false" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td class="tre"><table id="WFinRepNGP_HeadTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_DescriptionLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_C_IDLabel" Text="Company">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_MonthLabel" Text="Month">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCHNGP_YearLabel" Text="Year">	</asp:Literal></th><th class="thc" style="text-align:right;"><asp:Literal runat="server" id="WFRCHNGP_RptCountLabel" Text="Report Count">	</asp:Literal></th><th class="thc" colspan="3"><asp:Literal runat="server" id="WFRCHNGP_StatusLabel" Text="Status">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRepNGP_HeadTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRepNGP_HeadTableControlRow runat="server" id="WFinRepNGP_HeadTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"><table>
	<tr>
		<td><asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnPreview1" button-causesvalidation="False" button-commandname="Redirect" button-text="Preview" button-tooltip="Preview"></ePortalWFApproval:ThemeButton></td>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnPreview2" button-causesvalidation="False" button-commandname="Redirect" button-text="View As PDF" button-tooltip="View As PDF"></ePortalWFApproval:ThemeButton></td>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnEdit" button-causesvalidation="False" button-commandname="Redirect" button-text="Return" button-tooltip="MyButton"></ePortalWFApproval:ThemeButton></td>
		<td><asp:ImageButton runat="server" id="imbView" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" visible="False">		
	</asp:ImageButton></td>
		<td><asp:ImageButton runat="server" id="imbEdit" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton></td>
	</tr>
</table>
 </td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCHNGP_Description"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_C_ID"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_Month"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_Year"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_RptCount"></asp:Literal></span>
</td><td class="tableCellValue" colspan="3" style="text-align:left;"><table>
	<tr>
		<td><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRCHNGP_Status"></asp:Literal></span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_C_ID1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_C_ID1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_C_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_Month1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_Month1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Month1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_Year1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_Year1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Year1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_ID" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_IDTextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP ID&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_U_ID" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_U_IDTextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_U_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;U&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCHNGP_Status1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_Status1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Status1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WFRCHNGP_Description1" Columns="40" MaxLength="250" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCHNGP_Description1TextBoxMaxLengthValidator" ControlToValidate="WFRCHNGP_Description1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td>
		<td><asp:LinkButton runat="server" id="WFRCHNGP_File" CommandName="Redirect" visible="False" style="display:none"></asp:LinkButton></td>
	</tr>
</table>
 </td></tr><tr id="WFinRepNGP_HeadTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="8"><BaseClasses:TabContainer runat="server" id="WFinRepNGP_HeadTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="WFinRepNGP_DocAttachTabPanel" HeaderText="Reports Included">	<ContentTemplate>
  <ePortalWFApproval:WFinRepNGP_DocAttachTableControl runat="server" id="WFinRepNGP_DocAttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td>
                          <div id="Filters3Div" runat="server" class="popupWrapper">
                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRepNGP_DocAttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3"><asp:Literal runat="server" id="WFRCDNGP_TypeLabel" Text="Report Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRCDNGP_RWRemLabel" Text="Remarks">	</asp:Literal></th><th class="thc" colspan="3" style="text-align:center;">Actions</th></tr><asp:Repeater runat="server" id="WFinRepNGP_DocAttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRepNGP_DocAttachTableControlRow runat="server" id="WFinRepNGP_DocAttachTableControlRow">
<tr><td class="tableCellValue" colspan="3" style="text-align:left;"><table>
	<tr>
		<td><asp:Literal runat="server" id="WFRCDNGP_Type"></asp:Literal></td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCDNGP_Year" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCDNGP_YearTextBoxMaxLengthValidator" ControlToValidate="WFRCDNGP_Year" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCDNGP Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCDNGP_WFRCHNGP_ID" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCDNGP_WFRCHNGP_IDTextBoxMaxLengthValidator" ControlToValidate="WFRCDNGP_WFRCHNGP_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCHNGP&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WFRCDNGP_Type1" Columns="10" MaxLength="10" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCDNGP_Type1TextBoxMaxLengthValidator" ControlToValidate="WFRCDNGP_Type1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCDNGP Type&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCDNGP_Month" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCDNGP_MonthTextBoxMaxLengthValidator" ControlToValidate="WFRCDNGP_Month" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCDNGP Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WFRCDNGP_File1" Columns="40" MaxLength="100" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCDNGP_File1TextBoxMaxLengthValidator" ControlToValidate="WFRCDNGP_File1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCDNGP File 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td>
	</tr>
</table>
 </td><td class="tableCellValue"><asp:Literal runat="server" id="WFRCDNGP_RWRem"></asp:Literal></td><td class="tableCellLabel" colspan="3"><table>
	<tr>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnPreview" button-causesvalidation="False" button-commandname="Redirect" button-text="Preview" button-tooltip="MyButton"></ePortalWFApproval:ThemeButton></td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCDNGP_Company" Columns="7" MaxLength="7" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCDNGP_CompanyTextBoxMaxLengthValidator" ControlToValidate="WFRCDNGP_Company" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCDNGP Company&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
		<td><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WFRCDNGP_Status" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WFRCDNGP_StatusTextBoxMaxLengthValidator" ControlToValidate="WFRCDNGP_Status" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WFRCDNGP Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td>
	</tr>
</table>
 </td></tr></ePortalWFApproval:WFinRepNGP_DocAttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_DocAttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_DocAttachTableControl>

 </ContentTemplate></BaseClasses:TabPanel> 
<BaseClasses:TabPanel runat="server" id="WFinRepNGP_AttachmentTabPanel" HeaderText="Attachments">	<ContentTemplate>
  <ePortalWFApproval:WFinRepNGP_AttachmentTableControl runat="server" id="WFinRepNGP_AttachmentTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRepNGP_AttachmentTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WFRNGPAt_DescLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPAt_DocLabel" Text="File Download">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRepNGP_AttachmentTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRepNGP_AttachmentTableControlRow runat="server" id="WFinRepNGP_AttachmentTableControlRow">
<tr><td class="tableCellValue">      <asp:Literal runat="server" id="WFRNGPAt_Desc"></asp:Literal></td><td class="tableCellValue"><asp:LinkButton runat="server" id="WFRNGPAt_Doc" CommandName="Redirect" class="imageDropshadow" style="max-width:120px;margin:5px;"></asp:LinkButton></td></tr></ePortalWFApproval:WFinRepNGP_AttachmentTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:Pagination runat="server" id="Pagination2"></ePortalWFApproval:Pagination>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_AttachmentTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_AttachmentTableControl>

 </ContentTemplate></BaseClasses:TabPanel> 
<BaseClasses:TabPanel runat="server" id="WFinRepNGP_ActivityTabPanel" HeaderText="Approval History">	<ContentTemplate>
  <ePortalWFApproval:WFinRepNGP_ActivityTableControl runat="server" id="WFinRepNGP_ActivityTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRepNGP_ActivityTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WFRNGPA_W_U_IDLabel" Text="User Assigned">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPA_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPA_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPA_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRNGPA_RemarkLabel" Text="Remarks">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRepNGP_ActivityTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRepNGP_ActivityTableControlRow runat="server" id="WFinRepNGP_ActivityTableControlRow">
<tr><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRNGPA_W_U_ID"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRNGPA_Status"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRNGPA_Date_Assign"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WFRNGPA_Date_Action"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="WFRNGPA_Remark"></asp:Literal></td></tr></ePortalWFApproval:WFinRepNGP_ActivityTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:Pagination runat="server" id="Pagination1"></ePortalWFApproval:Pagination>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_ActivityTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_ActivityTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
 
 
</BaseClasses:TabContainer></td></tr></ePortalWFApproval:WFinRepNGP_HeadTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <ePortalWFApproval:Pagination runat="server" id="Pagination"></ePortalWFApproval:Pagination>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WFinRepNGP_HeadTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRepNGP_HeadTableControl>
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
                