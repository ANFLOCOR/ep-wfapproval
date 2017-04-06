<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-WCAR-Doc-Table.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_WCAR_Doc_Table" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_WCAR_Doc_Table" %>

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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>
                        <ePortalWFApproval:WCAR_DocTableControl runat="server" id="WCAR_DocTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;WCAR Document&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="NewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" redirectstyle="Popup" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><ePortalWFApproval:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <ePortalWFApproval:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="WCD_WDT_IDLabel1" Text="WCD WDT ID">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<BaseClasses:QuickSelector runat="server" id="WCD_WDT_IDFilter" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"><ePortalWFApproval:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_DocTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3" style="display:none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="WCAR_DocTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_DocTableControlRow runat="server" id="WCAR_DocTableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;" rowspan="10" colspan="3">
                                  <asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>                                 
                                
                                  <asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                                  
                                    <br /><br />
                                  </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_WDT_IDLabel" Text="WCD WDT ID">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_WDT_ID"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_NoLabel" Text="WCD Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_No"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_CreatedLabel" Text="WCD Created">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Created"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Exp_BudgetLabel" Text="WCD Expiration Budget">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Budget"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_U_IDLabel" Text="WCD U">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_U_ID"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Project_NoLabel" Text="WCD Project Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_Project_No"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Request_DateLabel" Text="WCD Request Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Request_Date"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Exp_Cur_YrLabel" Text="WCD Expiration CUR Year">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Cur_Yr"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_C_IDLabel" Text="WCD C">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_C_ID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_StatusLabel" Text="WCD Status">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_Status"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Exp_Nxt_YrLabel" Text="WCD Expiration Next Year">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Nxt_Yr"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Exp_Prev_TotalLabel" Text="WCD Expiration Previous Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Prev_Total"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_WCur_IDLabel" Text="WCD WCur">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_WCur_ID"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Supplementary_ManualLabel" Text="WCD Supplementary Manual">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_Supplementary_Manual"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Exp_Sub_YrLabel" Text="WCD Expiration Sub Year">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Sub_Yr"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="WCD Expiration Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Proj_Inc_ACBLabel" Text="WCD Proj Increment ACB">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_Proj_Inc_ACB"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Unit_LocationLabel" Text="WCD Unit Location">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_Unit_Location"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Exp_Under_Over_BudgetLabel" Text="WCD Expiration Under Over Budget">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Under_Over_Budget"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Supplementary_WCD_IDLabel" Text="WCD Supplementary WCD">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Supplementary_WCD_ID"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_SubmitLabel" Text="WCD Submit">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_Submit"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_SupplementaryLabel" Text="WCD Supplementary">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_Supplementary"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="WCD Project Title">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_RemarkLabel" Text="WCD Remark">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="WCD_Remark"></asp:Literal> </td></tr><tr id="WCAR_DocTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="6"><BaseClasses:TabContainer runat="server" id="WCAR_DocTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="WCAR_ActivityTabPanel" HeaderText="WCAR Activity">	<ContentTemplate>
  <ePortalWFApproval:WCAR_ActivityTableControl runat="server" id="WCAR_ActivityTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right">
            <ePortalWFApproval:ThemeButtonWithArrow runat="server" id="Filters2Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters2Div&#39;,&#39;Filters2Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td>
                          <div id="Filters2Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel2" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl2" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_ActivityTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="WCAR_ActivityTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_ActivityTableControlRow runat="server" id="WCAR_ActivityTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_WS_IDLabel1" Text="WCA WS">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCA_WS_ID1"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_StatusLabel2" Text="WCA Status">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCA_Status2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_Date_ActionLabel1" Text="WCA Date Action">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Action2"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_Is_DoneLabel1" Text="WCA Is Done">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCA_Is_Done2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_W_U_ID_DelegateLabel" Text="WCA W U Delegate">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID_Delegate"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_Date_AssignLabel1" Text="WCA Date Assign">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Assign2"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_W_U_IDLabel1" Text="WCA W U">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID2"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_WDT_IDLabel1" Text="WCA WDT">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCA_WDT_ID2"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_WSD_IDLabel1" Text="WCA WSD">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCA_WSD_ID1"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_RemarkLabel1" Text="WCA Remark">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="WCA_Remark1"></asp:Literal> </td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></ePortalWFApproval:WCAR_ActivityTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination2"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="WCAR_ActivityTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_ActivityTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
 <BaseClasses:TabPanel runat="server" id="Sel_WCAR_Activity_WCAR_DocTabPanel" HeaderText="WCAR Activity WCAR Document">	<ContentTemplate>
  <ePortalWFApproval:Sel_WCAR_Activity_WCAR_DocTableControl runat="server" id="Sel_WCAR_Activity_WCAR_DocTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right">
            <ePortalWFApproval:ThemeButtonWithArrow runat="server" id="Filters1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters1Div&#39;,&#39;Filters1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td>
                          <div id="Filters1Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel1" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl1" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Sel_WCAR_Activity_WCAR_DocTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="Sel_WCAR_Activity_WCAR_DocTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WCAR_Activity_WCAR_DocTableControlRow runat="server" id="Sel_WCAR_Activity_WCAR_DocTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_WDT_IDLabel" Text="WCA WDT">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_WDT_ID"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_StatusLabel" Text="WCA Status">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCA_Status"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_Date_ActionLabel" Text="WCA Date Action">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Action"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="SSC_CompanyIDLabel" Text="SSC Company">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="SSC_CompanyID"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_W_U_IDLabel" Text="WCA W U">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_NoLabel1" Text="WCD Number">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCD_No2"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_Date_AssignLabel" Text="WCA Date Assign">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Assign"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_IDLabel" Text="WCA">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_ID"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_U_IDLabel1" Text="WCD U">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_U_ID2"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_Is_DoneLabel" Text="WCA Is Done">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCA_Is_Done"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Request_DateLabel1" Text="WCD Request Date">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Request_Date2"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_WSD_IDLabel" Text="WCA WSD">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_WSD_ID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_WCur_IDLabel1" Text="WCD WCur">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_WCur_ID1"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_WS_IDLabel" Text="WCA WS">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_WS_ID"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_C_IDLabel1" Text="WCD C">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_C_ID2"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Exp_TotalLabel1" Text="WCD Expiration Total">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total1"></asp:Literal></span>
 </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCA_RemarkLabel" Text="WCA Remark">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="WCA_Remark"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_Project_TitleLabel1" Text="WCD Project Title">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="WCD_Project_Title1"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCD_RemarkLabel1" Text="WCD Remark">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="WCD_Remark1"></asp:Literal> </td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></ePortalWFApproval:Sel_WCAR_Activity_WCAR_DocTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination1"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="Sel_WCAR_Activity_WCAR_DocTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WCAR_Activity_WCAR_DocTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
 <BaseClasses:TabPanel runat="server" id="WCAR_Doc_AttachTabPanel" HeaderText="WCAR Document Attach">	<ContentTemplate>
  <ePortalWFApproval:WCAR_Doc_AttachTableControl runat="server" id="WCAR_Doc_AttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right">
            <ePortalWFApproval:ThemeButtonWithArrow runat="server" id="Filters3Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters3Div&#39;,&#39;Filters3Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td>
                          <div id="Filters3Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel3" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl3" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Doc_AttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="WCAR_Doc_AttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Doc_AttachTableControlRow runat="server" id="WCAR_Doc_AttachTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCDA_DescLabel" Text="WCDA Description">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCDA_Desc"></asp:Literal> </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCDA_WAT_IDLabel" Text="Wcda WAT">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCDA_WAT_ID"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCDA_FileLabel" Text="WCDA File">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:LinkButton runat="server" id="WCDA_File" CommandName="Redirect"></asp:LinkButton> </td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></ePortalWFApproval:WCAR_Doc_AttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination3"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="WCAR_Doc_AttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Doc_AttachTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
 <BaseClasses:TabPanel runat="server" id="WCAR_Doc_CheckerTabPanel" HeaderText="WCAR Document Checker">	<ContentTemplate>
  <ePortalWFApproval:WCAR_Doc_CheckerTableControl runat="server" id="WCAR_Doc_CheckerTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right">
            <ePortalWFApproval:ThemeButtonWithArrow runat="server" id="Filters4Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters4Div&#39;,&#39;Filters4Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td>
                          <div id="Filters4Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel4" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl4" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Doc_CheckerTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="WCAR_Doc_CheckerTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Doc_CheckerTableControlRow runat="server" id="WCAR_Doc_CheckerTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCDC_U_IDLabel" Text="WCDC U">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCDC_U_ID"></asp:Literal></span>
 </td><td class="tableCellLabel"><asp:Literal runat="server" id="WCDC_StatusLabel" Text="WCDC Status">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCDC_Status"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCDC_RemLabel" Text="WCDC REM">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="WCDC_Rem"></asp:Literal> </td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></ePortalWFApproval:WCAR_Doc_CheckerTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination4"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="WCAR_Doc_CheckerTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Doc_CheckerTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer></td></tr><tr><td class="tableRowDivider" colspan="9"></td></tr></ePortalWFApproval:WCAR_DocTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_DocTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_DocTableControl>

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
                