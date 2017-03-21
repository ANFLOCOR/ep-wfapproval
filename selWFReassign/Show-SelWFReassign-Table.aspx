<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-SelWFReassign-Table.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_SelWFReassign_Table" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_SelWFReassign_Table" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><ePortalWFApproval:SelWFReassignTableControl runat="server" id="SelWFReassignTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="SelWFReassignTitle" Text="PO Workflow Reassign Task">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
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

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="SelWFReassignTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td><asp:literal id="Literal" runat="server" text="&nbsp;" /></td><td></td><td></td><td></td><td></td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="WPO_W_U_IDLabel1" Text="User(Assigned)">	</asp:Literal></td><td style="text-align:left;">&nbsp;</td><td style="text-align:left;" colspan="2"><BaseClasses:QuickSelector runat="server" id="WPO_W_U_IDFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector></td><td></td></tr><tr><td style="text-align:left;"><asp:literal id="Literal3" runat="server" text="&nbsp;" /></td><td style="text-align:left;"></td><td style="text-align:left;"></td><td style="text-align:left;"></td><td style="text-align:left;"></td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="TOTALLabel1" Text="Amount">	</asp:Literal></td><td style="text-align:left;"></td><td style="text-align:left;" colspan="2"><asp:TextBox runat="server" id="TOTALFromFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox> <span class="rft"><%# GetResourceValue("Txt:To", "ePortalWFApproval") %></span> <asp:TextBox runat="server" id="TOTALToFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox></td><td style="text-align:left;"><ePortalWFApproval:ThemeButton runat="server" id="SelWFReassignFilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td></tr><tr><td colspan="4"><asp:literal id="Literal1" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="Literal2" Text="Assign To">	</asp:Literal></td><td style="padding-left:6px;text-align:left;"></td><td style="padding-left:6px;text-align:left;" colspan="2"><asp:dropdownlist id="ddlAssignTo" runat="server" width="223px" class="fls">
	<asp:listitem>User 1</asp:listitem>
	<asp:listitem>User 2</asp:listitem>
	<asp:listitem>User 3</asp:listitem>
</asp:dropdownlist></td><td style="text-align:left;"><asp:Button CommandName="Redirect" runat="server" id="btnAssignTo" causesvalidation="false" text="&lt;%# GetResourceValue(&quot;Assign&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Assign&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:Button></td></tr></table>
</td></tr><tr><td class="tre"> 
<table><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"></td><td class="pra"><ePortalWFApproval:Pagination runat="server" id="SelWFReassignPagination"></ePortalWFApproval:Pagination></td><td></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table id="SelWFReassignTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="fls"></th><th class="fls"><asp:CheckBox runat="server" id="SelWFReassignToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc"><asp:LinkButton runat="server" id="WPO_WDT_IDLabel" tooltip="Sort by WPO_WDT_ID" Text="Workflow" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="WPO_WS_IDLabel" tooltip="Sort by WPO_WS_ID" Text="Step Description" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="WPO_W_U_IDLabel" tooltip="Sort by WPO_W_U_ID" Text="User(Assigned)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="WPO_PONumLabel" tooltip="Sort by WPO_PONum" Text="PO No" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="WPO_StatusLabel" tooltip="Sort by WPO_Status" Text="Status" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="WPO_Date_AssignLabel" tooltip="Sort by WPO_Date_Assign" Text="Date Assign" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="WPO_RemarkLabel" tooltip="Sort by WPO_Remark" Text="Remark(s)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="TOTALLabel" tooltip="Sort by TOTAL" Text="Total" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="coIDLabel" tooltip="Sort by coID" Text="Company" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="SelWFReassignTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:SelWFReassignTableControlRow runat="server" id="SelWFReassignTableControlRow">
<tr><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="SelWFReassignRowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellLabel" style="text-align:left;"><asp:CheckBox runat="server" id="SelWFReassignRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="tableCellValue" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WDT_ID"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WS_ID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_ID" visible="False"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_W_U_ID"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:left;"><asp:Literal runat="server" id="WPO_PONum"></asp:Literal></td><td class="tableCellValue" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Status"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Assign"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:left;"><asp:Literal runat="server" id="WPO_Remark"></asp:Literal></td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TOTAL"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="coID"></asp:Literal></span>
</td></tr><tr id="SelWFReassignTableControlAltRow" runat="server"><td class="tableCellLabel"></td><td class="tableCellLabel" colspan="9"><BaseClasses:TabContainer runat="server" id="WFReassignContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="WFReassignPanel" HeaderText="PO Details">	<ContentTemplate> 
  <ePortalWFApproval:Sel_WPO_InquireDetailsTableControl runat="server" id="Sel_WPO_InquireDetailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="Sel_WPO_InquireDetailsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td class="pra"><ePortalWFApproval:Pagination runat="server" id="Sel_WPO_InquireDetailsPagination"></ePortalWFApproval:Pagination></td><td></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table id="Sel_WPO_InquireDetailsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="LineNumberLabel" Text="Line No">	</asp:Literal> 
</th><th class="thc"><asp:Literal runat="server" id="ITEMNMBRLabel" Text="Item No">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="ITEMDESCLabel" Text="Item Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="UOFMLabel" Text="Uofm">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="QTYORDERLabel" Text="Qty Order">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="QTYORDERLabel1" Text="Unit Cost">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="EXTDCOSTLabel" Text="Total">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WPO_InquireDetailsTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WPO_InquireDetailsTableControlRow runat="server" id="Sel_WPO_InquireDetailsTableControlRow">
<tr><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LineNumber"></asp:Literal></span>
<asp:ImageButton runat="server" id="iComm" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconClear.gif" tooltip="&lt;%# GetResourceValue(&quot;Line Item Comment&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="tableCellValue"><asp:Literal runat="server" id="ITEMNMBR"></asp:Literal> 
<asp:Literal runat="server" id="PONUMBER" visible="True"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ITEMDESC"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="CompanyID" visible="False"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="UOFM"></asp:Literal>  
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="ORD" visible="False"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="QTYORDER"></asp:Literal></span>
  
</td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UNITCOST"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EXTDCOST"></asp:Literal></span>
</td></tr></ePortalWFApproval:Sel_WPO_InquireDetailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td></td><td></td></tr></table>
	<asp:hiddenfield id="Sel_WPO_InquireDetailsTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_InquireDetailsTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPO_PathPanel" HeaderText="Workflow Path">	<ContentTemplate> 
  <ePortalWFApproval:WPO_Step_WPO_StepDetailTableControl runat="server" id="WPO_Step_WPO_StepDetailTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="WPO_Step_WPO_StepDetailTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td class="pra"><ePortalWFApproval:Pagination runat="server" id="WPO_Step_WPO_StepDetailPagination"></ePortalWFApproval:Pagination></td><td></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table id="WPO_Step_WPO_StepDetailTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="WPO_SD_W_U_IDLabel" tooltip="Sort by WPO_SD_W_U_ID" Text="User(Assigned)" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="WPO_S_Step_TypeLabel" tooltip="Sort by WPO_S_Step_Type" Text="Step Path" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="WPO_S_IDLabel" tooltip="Sort by WPO_S_ID" Text="Step Description" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="WPO_Step_WPO_StepDetailTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_Step_WPO_StepDetailTableControlRow runat="server" id="WPO_Step_WPO_StepDetailTableControlRow">
<tr><td class="ticnb" scope="row"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_SD_W_U_ID"></asp:Literal></span>
</td><td class="ticnb" scope="row"><asp:Literal runat="server" id="WPO_S_Step_Type"></asp:Literal></td><td class="ticnb" scope="row"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_S_ID"></asp:Literal></span>
</td></tr></ePortalWFApproval:WPO_Step_WPO_StepDetailTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
	<asp:hiddenfield id="WPO_Step_WPO_StepDetailTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_Step_WPO_StepDetailTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td><td class="tableCellValue"></td></tr></ePortalWFApproval:SelWFReassignTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="SelWFReassignTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:SelWFReassignTableControl>
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
                