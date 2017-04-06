<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="FSWF-Inquiry.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.FSWF_Inquiry" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.FSWF_Inquiry" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <ePortalWFApproval:WFinRep_HeadTableControl runat="server" id="WFinRep_HeadTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;FS Report Inquiry&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table><tr><td><asp:Literal runat="server" id="HFIN_C_IDLabel1" Text="Company">	</asp:Literal></td><td><asp:DropDownList runat="server" id="HFIN_C_IDFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td></td></tr><tr><td><asp:Literal runat="server" id="HFIN_MonthLabel1" Text="Month">	</asp:Literal></td><td><asp:DropDownList runat="server" id="HFIN_MonthFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="200px">	</asp:DropDownList> </td><td></td></tr><tr><td><asp:Literal runat="server" id="HFIN_YearLabel1" Text="Year">	</asp:Literal></td><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("GoButton"))%>
<asp:DropDownList runat="server" id="HFIN_YearFromFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="200px">	</asp:DropDownList> <span class="rft"></span> <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("GoButton"))%>
</td><td></td></tr><tr><td><asp:Literal runat="server" id="HFIN_StatusLabel1" Text="Status">	</asp:Literal></td><td><asp:DropDownList runat="server" id="HFIN_StatusFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="200px">	</asp:DropDownList> </td><td><ePortalWFApproval:ThemeButton runat="server" id="GoButton" button-causesvalidation="false" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td class="tre" style="text-align:right;"><ePortalWFApproval:Pagination runat="server" id="Pagination"></ePortalWFApproval:Pagination></td></tr><tr><td class="tre">
                    <table id="WFinRep_HeadTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="HFIN_DescriptionLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_C_IDLabel" Text="Company">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_MonthLabel" Text="Month">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_YearLabel" Text="Year">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_RptCountLabel" Text="Report Count">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_StatusLabel" Text="Status">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_HeadTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_HeadTableControlRow runat="server" id="WFinRep_HeadTableControlRow">
<tr><td class="ttc" scope="row" style="font-size: 5px;"><table>
	<tr>
		<td><asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnPreview1" button-causesvalidation="False" button-commandname="Redirect" button-text="Preview" button-tooltip="Preview"></ePortalWFApproval:ThemeButton></td>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnPreview2" button-causesvalidation="False" button-commandname="Redirect" button-text="View As PDF" button-tooltip="View As PDF"></ePortalWFApproval:ThemeButton></td>
		<td><ePortalWFApproval:ThemeButton runat="server" id="btnEdit" button-causesvalidation="False" button-commandname="Redirect" button-text="Return" button-tooltip="Return"></ePortalWFApproval:ThemeButton></td>
		<td></td>
		<td><asp:ImageButton runat="server" id="ViewRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton></td>
		<td><asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton></td>
	</tr>
</table>
  
</td><td class="ttc"><asp:Literal runat="server" id="HFIN_Description"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="HFIN_Description1" Columns="40" MaxLength="250" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_Description1TextBoxMaxLengthValidator" ControlToValidate="HFIN_Description1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_C_ID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Status" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_StatusTextBoxMaxLengthValidator" ControlToValidate="HFIN_Status" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_C_ID1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_C_ID1TextBoxMaxLengthValidator" ControlToValidate="HFIN_C_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Hfin C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_Month"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Month1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_Month1TextBoxMaxLengthValidator" ControlToValidate="HFIN_Month1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_Year"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_Year1" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_Year1TextBoxMaxLengthValidator" ControlToValidate="HFIN_Year1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;HFIN Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_RptCount"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="HFIN_ID" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="HFIN_IDTextBoxMaxLengthValidator" ControlToValidate="HFIN_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Hfin&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_Status1"></asp:Literal></span>
 
<asp:LinkButton runat="server" id="HFIN_File" CommandName="Redirect" visible="False" style="display:none"></asp:LinkButton></td></tr><tr id="WFinRep_HeadTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row" colspan="6"><BaseClasses:TabContainer runat="server" id="WFinRep_HeadTableControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Reports Included">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_DocAttachTableControl runat="server" id="WFinRep_DocAttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td>
                          <div id="Filters2Div" runat="server" class="popupWrapper">
                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_DocAttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="FIN_TypeLabel" Text="Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIN_RWRemLabel" Text="Remarks">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="Literal" Text="Actions">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_DocAttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_DocAttachTableControlRow runat="server" id="WFinRep_DocAttachTableControlRow">
<tr><td class="tableCellValue" style="text-align:left"><asp:Literal runat="server" id="FIN_Type"></asp:Literal> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_Year" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_YearTextBoxMaxLengthValidator" ControlToValidate="FIN_Year" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_Status" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_StatusTextBoxMaxLengthValidator" ControlToValidate="FIN_Status" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_HFIN_ID" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_HFIN_IDTextBoxMaxLengthValidator" ControlToValidate="FIN_HFIN_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fin Hfin&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
</td><td class="tableCellValue"><asp:Literal runat="server" id="FIN_RWRem"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FIN_File1" Columns="40" MaxLength="100" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_File1TextBoxMaxLengthValidator" ControlToValidate="FIN_File1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN File 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_Month" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_MonthTextBoxMaxLengthValidator" ControlToValidate="FIN_Month" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"><ePortalWFApproval:ThemeButton runat="server" id="btnPreview" button-causesvalidation="False" button-commandname="Redirect" button-text="Preview" button-tooltip="Preview"></ePortalWFApproval:ThemeButton> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_Company" Columns="7" MaxLength="7" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_CompanyTextBoxMaxLengthValidator" ControlToValidate="FIN_Company" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Company&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FIN_Type1" Columns="10" MaxLength="10" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_Type1TextBoxMaxLengthValidator" ControlToValidate="FIN_Type1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Type&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr></ePortalWFApproval:WFinRep_DocAttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:Pagination runat="server" id="Pagination2"></ePortalWFApproval:Pagination>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="WFinRep_DocAttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_DocAttachTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
<BaseClasses:TabPanel runat="server" id="TabPanel2" HeaderText="Attachment(s)">	<ContentTemplate> 
  <ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportTypeTableControl runat="server" id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WFRT_DescriptionLabel" Text="Attachment(s) For">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRA_DescLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRA_DocLabel" Text="File Download">	</asp:Literal></th><th class="thc"></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow runat="server" id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow">
<tr><td class="tableCellValue" style="text-align:left;"><asp:Literal runat="server" id="WFRT_Description"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="WFRA_Desc"></asp:Literal> </td><td class="tableCellValue" style="text-align:left;"><asp:LinkButton runat="server" id="WFRA_Doc" CommandName="Redirect" class="imageDropshadow" style="max-width:120px;margin:5px;"></asp:LinkButton></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"></td><td class="tableCellValue" colspan="5"></td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportTypeTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:Pagination runat="server" id="Pagination3"></ePortalWFApproval:Pagination>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportTypeTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
<BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_ActivityTableControl runat="server" id="WFinRep_ActivityTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td>
                          <div id="Filters1Div" runat="server" class="popupWrapper">
                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_ActivityTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="AFIN_W_U_IDLabel" Text="User (Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_RemarkLabel" Text="Remark(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_ActivityTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_ActivityTableControlRow runat="server" id="WFinRep_ActivityTableControlRow">
<tr><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_W_U_ID"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Assign"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Action"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Status"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="AFIN_Remark"></asp:Literal></td></tr></ePortalWFApproval:WFinRep_ActivityTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:Pagination runat="server" id="Pagination1"></ePortalWFApproval:Pagination>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="WFinRep_ActivityTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_ActivityTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr><tr><td scope="row" colspan="7"></td></tr></ePortalWFApproval:WFinRep_HeadTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WFinRep_HeadTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_HeadTableControl>

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
                