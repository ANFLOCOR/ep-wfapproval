<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.FSWF_Inquiry1" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="FSWF-Inquiry1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.FSWF_Inquiry1" %>
<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

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
                        <ePortalWFApproval:WFinRep_Head1TableControl runat="server" id="WFinRep_Head1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="WFinRep_HeadTitle" Text="FS Report Inquiry (North)">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="WFinRep_HeadTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td style="text-align:right; font-weight:bold;"><asp:Literal runat="server" id="HFIN_C_IDLabel1" Text="Company">	</asp:Literal></td><td><asp:DropDownList runat="server" id="HFIN_C_IDFilter1" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="200px">	</asp:DropDownList> </td><td><ePortalWFApproval:ThemeButton runat="server" id="WFinRep_HeadFilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td></tr><tr><td style="text-align:right; font-weight:bold;"><asp:Literal runat="server" id="HFIN_YearLabel1" Text="Year">	</asp:Literal></td><td><asp:DropDownList runat="server" id="HFIN_YearFromFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="200px">	</asp:DropDownList> <span class="rft"></span> </td><td></td></tr><tr><td style="text-align:right; font-weight:bold;"><asp:Literal runat="server" id="HFIN_MonthLabel1" Text="Month">	</asp:Literal></td><td><asp:DropDownList runat="server" id="HFIN_MonthFromFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="200px">	</asp:DropDownList> </td><td></td></tr><tr><td style="text-align:right; font-weight:bold;"><asp:Literal runat="server" id="HFIN_StatusLabel1" Text="Status">	</asp:Literal></td><td><asp:DropDownList runat="server" id="HFIN_StatusFilter2" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="200px">	</asp:DropDownList> </td><td></td></tr></table>
</td></tr><tr><td class="tre"> 
<table><tr><td class="pra"><ePortalWFApproval:Pagination runat="server" id="WFinRep_HeadPagination"></ePortalWFApproval:Pagination>
            <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. --></td></tr></table>
</td></tr><tr><td class="tre"><table id="WFinRep_Head1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc"><asp:Literal runat="server" id="HFIN_DescriptionLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_C_IDLabel" Text="Company">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_MonthLabel" Text="Month">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_YearLabel" Text="Year">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_RptCountLabel" Text="Report Count">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="HFIN_FileLabel" Text="Action">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_Head1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_Head1TableControlRow runat="server" id="WFinRep_Head1TableControlRow">
<tr><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="WFinRep_HeadRowExpandCollapseRowButton1" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="WFinRep_HeadRowViewButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon-view.png" onmouseout="this.src=&#39;../Images/icon-view.png&#39;" onmouseover="this.src=&#39;../Images/icon-view-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" scope="row"><asp:ImageButton runat="server" id="WFinRep_HeadRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><asp:Literal runat="server" id="HFIN_Description"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="HFIN_Description1" Columns="40" MaxLength="50" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" style="display:none"></asp:TextBox>&nbsp;
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
 
</td><td class="ttc"><ePortalWFApproval:ThemeButton runat="server" id="btnPreview" button-causesvalidation="False" button-commandname="Redirect" button-text="View as PDF" button-tooltip="View Report as PDF"></ePortalWFApproval:ThemeButton> 
<asp:LinkButton runat="server" id="HFIN_File" CommandName="Redirect" font-bold="True" font-size="10pt" font-underline="True" visible="True" style="display:none"></asp:LinkButton></td></tr><tr id="WFinRep_Head1TableControlAltRow" runat="server"><td class="ticnb" scope="row" colspan="10"><BaseClasses:TabContainer runat="server" id="DetailTabContainer" enableviewstate="True" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="DocAttachTabPanel" HeaderText="Reports Included">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_DocAttach1TableControl runat="server" id="WFinRep_DocAttach1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WFinRep_DocAttachTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_DocAttach1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="FIN_TypeLabel" tooltip="Sort by Type" Text="Type" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:Literal runat="server" id="FIn_DescriptionLabel" Text="Report Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIN_RWRemLabel" Text="Remark(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_DocAttach1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_DocAttach1TableControlRow runat="server" id="WFinRep_DocAttach1TableControlRow">
<tr><td class="ttc" scope="row"><asp:Literal runat="server" id="FIN_Type"></asp:Literal> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_Month" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_MonthTextBoxMaxLengthValidator" ControlToValidate="FIN_Month" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Month&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_Status" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_StatusTextBoxMaxLengthValidator" ControlToValidate="FIN_Status" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row"><asp:Literal runat="server" id="FIn_Description"></asp:Literal> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_Company" Columns="7" MaxLength="7" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_CompanyTextBoxMaxLengthValidator" ControlToValidate="FIN_Company" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Company&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="FIN_Post" visible="False"></asp:Literal></td><td class="ttc" scope="row"><asp:Literal runat="server" id="FIN_RWRem"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FIN_Type1" Columns="10" MaxLength="10" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_Type1TextBoxMaxLengthValidator" ControlToValidate="FIN_Type1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Type&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_HFIN_ID" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_HFIN_IDTextBoxMaxLengthValidator" ControlToValidate="FIN_HFIN_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Fin Hfin&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FIN_File" Columns="25" MaxLength="25" cssclass="field_input" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_FileTextBoxMaxLengthValidator" ControlToValidate="FIN_File" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN File&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="FIN_Year" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FIN_YearTextBoxMaxLengthValidator" ControlToValidate="FIN_Year" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;FIN Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
</td></tr></ePortalWFApproval:WFinRep_DocAttach1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WFinRep_DocAttach1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_DocAttach1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="vwFS_ReportAttachPanel" HeaderText="Attachment(s)">	<ContentTemplate> 
  <ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportType1TableControl runat="server" id="Vw_FS_WFinRep_Attachment_PerReportType1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="Vw_FS_WFinRep_Attachment_PerReportTypeTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Vw_FS_WFinRep_Attachment_PerReportType1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WFRA_DescLabel" Text="Attachment(s) For">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRT_DescriptionLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WFRA_DocLabel" Text="File Download">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Vw_FS_WFinRep_Attachment_PerReportType1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow runat="server" id="Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="WFRT_Description"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="WFRA_Desc"></asp:Literal> </td><td class="ttc"><asp:LinkButton runat="server" id="WFRA_Doc_X" CommandName="Redirect" class="imageDropshadow" style="max-width:120px;margin:5px;"></asp:LinkButton></td></tr></ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Vw_FS_WFinRep_Attachment_PerReportType1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Vw_FS_WFinRep_Attachment_PerReportType1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="FSActivityTabPanel" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_Activity1TableControl runat="server" id="WFinRep_Activity1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WFinRep_ActivityTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_Activity1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="AFIN_W_U_IDLabel" Text="User (Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_RemarkLabel" Text="Approver Remark(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_Activity1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_Activity1TableControlRow runat="server" id="WFinRep_Activity1TableControlRow">
<tr><td class="ticnb" scope="row"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_W_U_ID"></asp:Literal></span>
</td><td class="ticnb" scope="row"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Status"></asp:Literal></span>
</td><td class="ticnb" scope="row"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Assign"></asp:Literal></span>
</td><td class="ticwb"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Action"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="AFIN_Remark"></asp:Literal></td></tr></ePortalWFApproval:WFinRep_Activity1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WFinRep_Activity1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_Activity1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr><tr><td class="tableRowDivider"></td><td class="tableRowDivider"></td><td class="tableRowDivider" colspan="7"></td><td class="tableRowDivider"></td></tr></ePortalWFApproval:WFinRep_Head1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr></table>
	<asp:hiddenfield id="WFinRep_Head1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_Head1TableControl>

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
                