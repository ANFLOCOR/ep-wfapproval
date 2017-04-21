<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_Sel_WPO_Activity_WPOP10100_Table" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationMedium" Src="../Shared/PaginationMedium.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Sel-WPO-Activity-WPOP10100-Table.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_Sel_WPO_Activity_WPOP10100_Table" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><ePortalWFApproval:Sel_WPO_Activity_WPOP10100TableControl runat="server" id="Sel_WPO_Activity_WPOP10100TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Sel_WPO_Activity_WPOP10100Title" Text="Purchase Order Workflow Tasks (South)">	</asp:Literal></td></tr></table>
</td><td class="dhb" style="display:none;"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="false" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="false" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="false" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><ePortalWFApproval:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow></td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td><asp:literal id="Literal3" runat="server" text="&nbsp" /></td><td>
                  <asp:panel id="Sel_WPO_Activity_WPOP10100TableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:literal id="Literal4" runat="server" text="&nbsp" /></td><td class="tre"> 
<table cellpadding="0" cellspacing="0" border="0"><tr><td style="text-align:left;" colspan="5"><asp:literal id="Literal" runat="server" text="&nbsp" /></td></tr><tr><td style="text-align:right;"><asp:Literal runat="server" id="WPOP_C_IDLabel1" Text="Company">	</asp:Literal></td><td><asp:literal id="Literal1" runat="server" text="&nbsp" /></td><td><asp:DropDownList runat="server" id="WPOP_C_IDFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="250px">	</asp:DropDownList></td><td></td><td></td></tr><tr><td style="text-align:right;"><asp:Literal runat="server" id="WPO_StatusLabel1" Text="Status">	</asp:Literal></td><td></td><td><asp:DropDownList runat="server" id="WPO_StatusFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="250px">	</asp:DropDownList></td><td><asp:literal id="Literal5" runat="server" text="&nbsp" /></td><td><ePortalWFApproval:ThemeButton runat="server" id="Sel_WPO_Activity_WPOP10100SearchButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td></tr><tr><td style="text-align:left;" colspan="5"><asp:literal id="Literal2" runat="server" text="&nbsp" /></td></tr></table>
</td></tr><tr><td class="tre"></td><td class="tre"><table><tr><td><asp:ImageButton runat="server" id="WCanvass_PO_MapRefreshButton" causesvalidation="False" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src=&#39;../Images/ButtonBarRefresh.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarRefreshOver.gif&#39;">		
	</asp:ImageButton></td><td><asp:ImageButton runat="server" id="WCanvass_PO_MapResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;">		
	</asp:ImageButton></td><td></td><td><ePortalWFApproval:Pagination runat="server" id="Sel_WPO_Activity_WPOP10100Pagination"></ePortalWFApproval:Pagination></td></tr></table>
</td></tr><tr><td class="tre"></td><td class="tre"><table id="Sel_WPO_Activity_WPOP10100TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:center;"></th><th class="fls" style="text-align:center;"></th><th class="fls" style="text-align:center;"></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPO_WDT_IDLabel1" Text="Workflow">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPO_PONumLabel1" Text="PO Number">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="TOTALLabel1" Text="Total">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPO_Date_AssignLabel1" Text="Date Assign">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPO_StatusLabel3" Text="Status">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WPO_Activity_WPOP10100TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WPO_Activity_WPOP10100TableControlRow runat="server" id="Sel_WPO_Activity_WPOP10100TableControlRow">
<tr><td class="ttc" style="text-align:center;"><asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" style="text-align:center;"><asp:ImageButton runat="server" id="ImageButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Workflow Task Approval&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" style="text-align:center;"><asp:ImageButton runat="server" id="ImageButton3" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-view.png" onmouseout="this.src=&#39;../Images/icon-view.png&#39;" onmouseover="this.src=&#39;../Images/icon-view-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton> 
</td><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WDT_ID"></asp:Literal></span>
<asp:Literal runat="server" id="WPO_Is_Done" visible="False"></asp:Literal></td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="WPO_PONum"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOP_C_ID" visible="False"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TOTAL"></asp:Literal></span>
</td><td class="ttc" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Assign"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Status"></asp:Literal></span>
</td></tr><tr id="Sel_WPO_Activity_WPOP10100TableControlAltRow" runat="server"><td class="tableCellLabel" style="text-align:center;"></td><td class="tableCellValue" colspan="7"><BaseClasses:TabContainer runat="server" id="Sel_WPO_Activity_WPOP10100TableControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WPO_WFHistory_Details_newTableControl runat="server" id="WPO_WFHistory_Details_newTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="WPO_WFHistory_Details_newTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td></td><td></td><td></td><td></td><td><ePortalWFApproval:PaginationMedium runat="server" id="WPO_WFHistory_Details_newPagination"></ePortalWFApproval:PaginationMedium></td></tr></table>
</td></tr><tr><td class="tre"><table id="WPO_WFHistory_Details_newTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_W_U_IDLabel1" Text="User (Assigned)">	</asp:Literal> 
</th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_WS_IDLabel1" Text="Step">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_Date_ActionLabel1" Text="Date Action">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_RemarkLabel1" Text="Remark">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_WFHistory_Details_newTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_WFHistory_Details_newTableControlRow runat="server" id="WPO_WFHistory_Details_newTableControlRow">
<tr><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_W_U_ID1"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WS_ID1"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Status1"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Assign1"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Action1"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPO_Remark1"></asp:Literal></td></tr></ePortalWFApproval:WPO_WFHistory_Details_newTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td><td class="panelT"></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="WPO_WFHistory_Details_newTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_WFHistory_Details_newTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Workflow Path">	<ContentTemplate> 
  <ePortalWFApproval:WPO_Step_WPO_StepDetail_WASPTableControl runat="server" id="WPO_Step_WPO_StepDetail_WASPTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPO_Step_WPO_StepDetail_WASPTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WPO_SD_W_U_IDLabel" Text="User(Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_S_Step_TypeLabel" Text="Step Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_S_IDLabel" Text="WPO S">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_Step_WPO_StepDetail_WASPTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_Step_WPO_StepDetail_WASPTableControlRow runat="server" id="WPO_Step_WPO_StepDetail_WASPTableControlRow">
<tr><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_SD_W_U_ID"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><asp:Literal runat="server" id="WPO_S_Step_Type"></asp:Literal> </td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_S_ID"></asp:Literal></span>
</td></tr></ePortalWFApproval:WPO_Step_WPO_StepDetail_WASPTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="WPO_Step_WPO_StepDetail_WASPTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_Step_WPO_StepDetail_WASPTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel2" HeaderText="PR Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_PRNo_QWFTableControl runat="server" id="WPO_PRNo_QWFTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPO_PRNo_QWFTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:center;"></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="PRNoLabel" Text="PR No">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPRD_TitleLabel" Text="Title">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPRD_CreatedLabel" Text="Date Created">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPRD_TotalLabel" Text="Total">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="CommentLabel" Text="Comment(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_PRNo_QWFTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_PRNo_QWFTableControlRow runat="server" id="WPO_PRNo_QWFTableControlRow">
<tr><td class="ttc" style="text-align:center;"><asp:ImageButton runat="server" id="ImageButton1" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-view.png" onmouseout="this.src=&#39;../Images/icon-view.png&#39;" onmouseover="this.src=&#39;../Images/icon-view-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><asp:Literal runat="server" id="PRNo"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_ID" visible="False"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPRD_Title"></asp:Literal> 
<asp:Literal runat="server" id="PONo" visible="False"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_Created"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_Total"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="Comment"></asp:Literal></td></tr></ePortalWFApproval:WPO_PRNo_QWFTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_PRNo_QWFTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_PRNo_QWFTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel3" HeaderText="CAR Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_CARNo_QWFTableControl runat="server" id="WPO_CARNo_QWFTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion6" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPO_CARNo_QWFTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:center;"></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCD_IDLabel" Text="CAR No">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Title">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCD_Exp_TotalLabel">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="CommentLabel1" Text="Comment">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="PRNumLabel">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_CARNo_QWFTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_CARNo_QWFTableControlRow runat="server" id="WPO_CARNo_QWFTableControlRow">
<tr><td class="ttc"><asp:ImageButton runat="server" id="ImageButton2" causesvalidation="True" commandname="Redirect" imageurl="../Images/icon-view.png" onmouseout="this.src=&#39;../Images/icon-view.png&#39;" onmouseover="this.src=&#39;../Images/icon-view-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_ID"></asp:Literal></span>
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="CARID" visible="False"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal></td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="Comment2"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="PRNum"></asp:Literal></td></tr></ePortalWFApproval:WPO_CARNo_QWFTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="WPO_CARNo_QWFTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_CARNo_QWFTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel4" HeaderText="Canvass Sheet">	<ContentTemplate> 
  <ePortalWFApproval:View_WCPO_Canvass1TableControl runat="server" id="View_WCPO_Canvass1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="View_WCPO_Canvass1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:center;"></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="PRIDLabel" Text="PR">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="CanvassDateLabel" Text="Canvass Date">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCI_SubmitLabel" Text="Submit">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCI_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="BuyerLabel" Text="Buyer">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="ClassificationLabel" Text="Classification">	</asp:Literal></th></tr><asp:Repeater runat="server" id="View_WCPO_Canvass1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:View_WCPO_Canvass1TableControlRow runat="server" id="View_WCPO_Canvass1TableControlRow">
<tr><td class="ttc" style="text-align:center;"><asp:ImageButton runat="server" id="ImageButton4" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-view.png" onmouseout="this.src=&#39;../Images/icon-view.png&#39;" onmouseover="this.src=&#39;../Images/icon-view-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PRID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCI_ID" visible="False"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CanvassDate"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WCI_Submit"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="WCI_Status"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Buyer"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Classification"></asp:Literal></span>
</td></tr></ePortalWFApproval:View_WCPO_Canvass1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="View_WCPO_Canvass1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:View_WCPO_Canvass1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel5" HeaderText="PO Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_Doc_AttachTableControl runat="server" id="WPO_Doc_AttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <asp:panel id="WPO_Doc_AttachTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"></td><td class="prspace"></td><td class="pra"><ePortalWFApproval:PaginationMedium runat="server" id="WPO_Doc_AttachPagination"></ePortalWFApproval:PaginationMedium>
            <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. --></td></tr></table>
</td></tr><tr><td class="tre"><table id="WPO_Doc_AttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WPODA_DescLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPODA_FileLabel" Text="File Upload">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_Doc_AttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_Doc_AttachTableControlRow runat="server" id="WPO_Doc_AttachTableControlRow">
<tr><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="WPODA_Desc"></asp:Literal></td><td class="ttc"><asp:LinkButton runat="server" id="WPODA_File" CommandName="Redirect"></asp:LinkButton></td></tr></ePortalWFApproval:WPO_Doc_AttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr><tr><td></td><td></td></tr></table>
	<asp:hiddenfield id="WPO_Doc_AttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_Doc_AttachTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr></ePortalWFApproval:Sel_WPO_Activity_WPOP10100TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Sel_WPO_Activity_WPOP10100TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_Activity_WPOP10100TableControl>
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
                