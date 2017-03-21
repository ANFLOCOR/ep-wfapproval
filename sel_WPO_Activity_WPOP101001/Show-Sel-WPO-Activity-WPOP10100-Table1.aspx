<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_Sel_WPO_Activity_WPOP10100_Table1" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Sel-WPO-Activity-WPOP10100-Table1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_Sel_WPO_Activity_WPOP10100_Table1" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                        <ePortalWFApproval:Sel_WPO_Activity_WPOP101001TableControl runat="server" id="Sel_WPO_Activity_WPOP101001TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Sel_WPO_Activity_WPOP10100Title" Text="PO Workflow Tasks (North)">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td><asp:literal id="Literal2" runat="server" text="&nbsp" /></td><td>
                  <asp:panel id="Sel_WPO_Activity_WPOP10100TableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:literal id="Literal3" runat="server" text="&nbsp" /></td><td> 
<table><tr><td style="text-align:left;" colspan="3"><asp:literal id="Literal" runat="server" text="&nbsp" /></td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="WPOP_C_IDLabel1" Text="Company">	</asp:Literal></td><td style="text-align:left;"><asp:DropDownList runat="server" id="WPOP_C_IDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td></td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="WPO_StatusLabel3" Text="Status">	</asp:Literal></td><td style="text-align:left;"><asp:DropDownList runat="server" id="WPO_StatusFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="225px">	</asp:DropDownList> </td><td style="text-align:left;"><ePortalWFApproval:ThemeButton runat="server" id="Sel_WPO_Activity_WPOP10100SearchButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td></tr><tr><td style="text-align:left;" colspan="3"><asp:literal id="Literal1" runat="server" text="&nbsp" /></td></tr></table>
</td></tr><tr><td class="tre"></td><td class="tre"> 
<table><tr><td class="prbbc"><asp:ImageButton runat="server" id="Sel_WPO_Activity_WPOP10100RefreshButton" causesvalidation="false" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src=&#39;../Images/ButtonBarRefresh.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarRefreshOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Sel_WPO_Activity_WPOP10100ResetButton" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc">&nbsp;</td><td class="prbbc">&nbsp;</td><td class="pra"><ePortalWFApproval:Pagination runat="server" id="Sel_WPO_Activity_WPOP10100Pagination"></ePortalWFApproval:Pagination></td><td>&nbsp;</td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"></td><td class="tre"><table id="Sel_WPO_Activity_WPOP101001TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb"></th><th class="thcnb"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" scope="col"></th><th class="thc"><asp:Literal runat="server" id="WPO_WDT_IDLabel" Text="Workflow">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_PONumLabel" Text="PO Number">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="TOTALLabel" Text="Total">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_StatusLabel" Text="Status">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WPO_Activity_WPOP101001TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WPO_Activity_WPOP101001TableControlRow runat="server" id="Sel_WPO_Activity_WPOP101001TableControlRow">
<tr><td class="ttc" scope="row"><asp:ImageButton runat="server" id="Sel_WPO_Activity_WPOP101001RowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" scope="row"><asp:ImageButton runat="server" id="ImageButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Workflow Task Approval&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><asp:ImageButton runat="server" id="ImageButton3" causesvalidation="False" commandname="Redirect" imageurl="../Images/Book_openHS.png" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WDT_ID"></asp:Literal></span>
 
<asp:Literal runat="server" id="WPO_Is_Done" visible="False"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="LitWPO_PONum" Text="MyLiteral">	</asp:Literal> 
<asp:Literal runat="server" id="WPO_PONum"></asp:Literal>  
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WPOP_C_ID" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPOP_C_IDTextBoxMaxLengthValidator" ControlToValidate="WPOP_C_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Wpop C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TOTAL"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Assign"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Status"></asp:Literal></span>
 </td></tr><tr id="Sel_WPO_Activity_WPOP101001TableControlAltRow" runat="server"><td class="ttc" scope="row"></td><td class="ttc" scope="row" colspan="7" style="text-align:left;"><BaseClasses:TabContainer runat="server" id="POActivityTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="WPO_Activity_Flow" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WPO_Activity1TableControl runat="server" id="WPO_Activity1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WPO_ActivityTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPO_Activity1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WPO_W_U_IDLabel" Text="User (Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_WS_IDLabel" Text="Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_StatusLabel1" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_Date_AssignLabel1" Text="Date Assigned">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_RemarkLabel" Text="Remark">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_Activity1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_Activity1TableControlRow runat="server" id="WPO_Activity1TableControlRow">
<tr><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_W_U_ID"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPO_WS_ID"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Status1"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Assign1"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Action"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPO_Remark"></asp:Literal></td></tr></ePortalWFApproval:WPO_Activity1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_Activity1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_Activity1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPO_Activity_Path" HeaderText="Workflow Path">	<ContentTemplate> 
  <ePortalWFApproval:WPO_Step_WPO_StepDetail1TableControl runat="server" id="WPO_Step_WPO_StepDetail1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WPO_Step_WPO_StepDetailTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPO_Step_WPO_StepDetail1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WPO_SD_W_U_IDLabel" Text="User (Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_S_Step_TypeLabel" Text="Step Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_S_IDLabel" Text="Step Description">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_Step_WPO_StepDetail1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_Step_WPO_StepDetail1TableControlRow runat="server" id="WPO_Step_WPO_StepDetail1TableControlRow">
<tr><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_SD_W_U_ID"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPO_S_Step_Type"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_S_ID"></asp:Literal></span>
</td></tr></ePortalWFApproval:WPO_Step_WPO_StepDetail1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_Step_WPO_StepDetail1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_Step_WPO_StepDetail1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPO_PR_InquiryPanel" HeaderText="PR Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_PRNo_QWF1TableControl runat="server" id="WPO_PRNo_QWF1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WPO_PRNo_QWFTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPO_PRNo_QWF1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="PRNoLabel" Text="PR No">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRD_TitleLabel" Text="Title">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRD_CreatedLabel" Text="Date Created">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRD_TotalLabel" Text="Total">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="CommentLabel" Text="Comment(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_PRNo_QWF1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_PRNo_QWF1TableControlRow runat="server" id="WPO_PRNo_QWF1TableControlRow">
<tr><td class="ttc"><asp:ImageButton runat="server" id="ImageButton1" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><asp:Literal runat="server" id="PRNo"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_ID" visible="False"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPRD_Title"></asp:Literal> 
<asp:Literal runat="server" id="PONo" visible="False"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_Created"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_Total"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="Comment"></asp:Literal></td></tr></ePortalWFApproval:WPO_PRNo_QWF1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_PRNo_QWF1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_PRNo_QWF1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPO_CAR_InquiryPanel" HeaderText="CAR Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_CARNo_QWF1TableControl runat="server" id="WPO_CARNo_QWF1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WPO_CARNo_QWFTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPO_CARNo_QWF1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="WCD_NoLabel" Text="CAR No">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Title">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="Total">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="CommentLabel1" Text="Comment">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="PRNumLabel" Text="Reference PR">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_CARNo_QWF1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_CARNo_QWF1TableControlRow runat="server" id="WPO_CARNo_QWF1TableControlRow">
<tr><td class="ttc"><asp:ImageButton runat="server" id="ImageButton2" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><asp:Literal runat="server" id="WCD_No"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="CARID" visible="False"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal></td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="Comment1"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="PRNum"></asp:Literal></td></tr></ePortalWFApproval:WPO_CARNo_QWF1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_CARNo_QWF1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_CARNo_QWF1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPO_CanvassPanel" HeaderText="Canvass Sheet">	<ContentTemplate> 
  <ePortalWFApproval:View_WCPO_Canvass11TableControl runat="server" id="View_WCPO_Canvass11TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="View_WCPO_Canvass1TableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="View_WCPO_Canvass11TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="PRIDLabel" Text="PR No">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="CanvassDateLabel" Text="Canvass Date">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCI_SubmitLabel" Text="Submit">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCI_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="BuyerLabel" Text="Buyer">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="ClassificationLabel" Text="Classification">	</asp:Literal></th></tr><asp:Repeater runat="server" id="View_WCPO_Canvass11TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:View_WCPO_Canvass11TableControlRow runat="server" id="View_WCPO_Canvass11TableControlRow">
<tr><td class="ttc"><asp:ImageButton runat="server" id="View_WCPO_Canvass1RowViewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon_view.gif">		
	</asp:ImageButton></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PRID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCI_ID" visible="False"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CanvassDate"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WCI_Submit"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="WCI_Status"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Buyer"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Classification"></asp:Literal></span>
</td></tr></ePortalWFApproval:View_WCPO_Canvass11TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="View_WCPO_Canvass11TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:View_WCPO_Canvass11TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr></ePortalWFApproval:Sel_WPO_Activity_WPOP101001TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Sel_WPO_Activity_WPOP101001TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_Activity_WPOP101001TableControl>

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
                