<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_Sel_WCAR_Doc_Creator_Approver_Table1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Sel-WCAR-Doc-Creator-Approver-Table1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_Sel_WCAR_Doc_Creator_Approver_Table1" %>
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
                        <ePortalWFApproval:Sel_WCAR_Doc_Creator_Approver1TableControl runat="server" id="Sel_WCAR_Doc_Creator_Approver1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="Capital Appropriation Request (North)">	</asp:Literal></td></tr></table>
</td><td class="dhb"></td><td class="dher"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="Sel_WCAR_Doc_Creator_Approver1CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table><tr><td style="text-align:left;"><b>Filters</b></td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td><asp:Literal runat="server" id="Literal1" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td style="vertical-align:middle;"><asp:Literal runat="server" id="WCD_C_IDLabel" Text="Company:">	</asp:Literal></td><td style="vertical-align:middle;"><asp:DropDownList runat="server" id="WCD_C_IDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="342px">	</asp:DropDownList></td><td></td></tr><tr><td style="vertical-align:middle;"><asp:Literal runat="server" id="WCD_StatusLabel1" Text="Status:">	</asp:Literal></td><td style="vertical-align:middle;"><asp:DropDownList runat="server" id="WCD_StatusFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="342px">	</asp:DropDownList></td><td></td></tr><tr><td style="vertical-align:middle;"><asp:Literal runat="server" id="WCD_SubmitLabel1" Text="Submit:">	</asp:Literal></td><td style="vertical-align:middle;"><asp:DropDownList runat="server" id="WCD_SubmitFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="342px">	</asp:DropDownList> </td><td></td></tr><tr><td style="vertical-align:middle;"><asp:Literal runat="server" id="WCD_NoLabel1" Text="CAR No. :">	</asp:Literal></td><td style="vertical-align:middle;"><asp:TextBox runat="server" id="WCD_NoFilter" columns="20" cssclass="Filter_Input" selectionmode="Single" width="340px">	</asp:TextBox> </td><td><ePortalWFApproval:ThemeButton runat="server" id="Sel_WCAR_Doc_Creator_ApproverSearchButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td></tr><tr><td><asp:Literal runat="server" id="Literal" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr></table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="tre"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle" style="text-align:left;vertical-align:middle;"><asp:ImageButton runat="server" id="btnNew_CAR" causesvalidation="false" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="dheci" valign="middle" style="text-align:left;vertical-align:middle;"><asp:ImageButton runat="server" id="Sel_WCAR_Doc_Creator_ApproverRefreshButton" causesvalidation="false" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src=&#39;../Images/ButtonBarRefresh.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarRefreshOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="dheci" valign="middle" style="text-align:left;vertical-align:middle;"><asp:ImageButton runat="server" id="Sel_WCAR_Doc_Creator_ApproverResetButton" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="dheci" valign="middle" style="text-align:left;vertical-align:middle;"><ePortalWFApproval:Pagination runat="server" id="Sel_WCAR_Doc_Creator_ApproverPagination"></ePortalWFApproval:Pagination></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"></asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="tre"> 
<table></table>
</td></tr><tr><td class="tre"><table id="Sel_WCAR_Doc_Creator_Approver1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="4"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thcwb" style="padding:0px;vertical-align:middle;text-align:center;width:172px;"><b><asp:Literal runat="server" id="WCD_WDT_IDLabel" Text="Workflow">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;width:53px;"><b><asp:Literal runat="server" id="WCD_NoLabel" Text="CAR No.">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;width:65px;"><b><asp:Literal runat="server" id="WCD_SubmitLabel" Text="Submitted">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;width:60px;"><b><asp:Literal runat="server" id="WCD_StatusLabel" Text="Status">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;width:95px;"><b><asp:Literal runat="server" id="WCD_Unit_LocationLabel" Text="Unit &amp; Location">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;width:123px;"><b><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Description">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;width:51px;"><b><asp:Literal runat="server" id="WCD_Project_NoLabel" Text="Project No.">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_Request_DateLabel" Text="Request Date">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_WCur_IDLabel" Text="Currency">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;width:90px;"><b><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="Total Amount">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_U_IDLabel" Text="Requester">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_Supplementary_WCD_IDLabel" Text="Supplementary of">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="Sel_WCAR_Doc_Creator_Approver1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WCAR_Doc_Creator_Approver1TableControlRow runat="server" id="Sel_WCAR_Doc_Creator_Approver1TableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="text-align:left;vertical-align:middle;"><asp:ImageButton runat="server" id="Sel_WCAR_Doc_Creator_ApproverRowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="tableRowButtonsCellVertical" scope="row" style="text-align:left;vertical-align:middle;"><asp:ImageButton runat="server" id="btnView" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton> 
<asp:ImageButton runat="server" id="btnOpen" alternatetext="Open" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;" tooltip="Open">		
	</asp:ImageButton></td><td class="tableRowButtonsCellVertical" scope="row" style="text-align:left;vertical-align:middle;"><asp:ImageButton runat="server" id="btnEdit" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:ImageButton></td><td class="tableRowButtonsCellVertical" style="text-align:left;vertical-align:middle;"><asp:ImageButton runat="server" id="btnVoid" alternatetext="Void" causesvalidation="False" commandname="Redirect" visible="False">		
	</asp:ImageButton></td><td class="tableCellValue" style="text-align:left;vertical-align:middle;border-left:none;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_WDT_ID"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCD_No"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_ID" visible="False"></asp:Literal></span>
</td><td class="tableCellValue" style="vertical-align:middle;text-align:center;"><asp:Literal runat="server" id="WCD_Submit"></asp:Literal></td><td class="tableCellValue" style="vertical-align:middle;text-align:center;"><asp:Literal runat="server" id="WCD_Status"></asp:Literal></td><td class="tableCellValue" style="text-align:left;vertical-align:middle;"><asp:Literal runat="server" id="WCD_Unit_Location"></asp:Literal> 
</td><td class="tableCellValue" style="text-align:left;vertical-align:top;"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal></td><td class="tableCellValue" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCD_Project_No"></asp:Literal></td><td class="tableCellValue" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Request_Date"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_WCur_ID"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:right;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:left;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_U_ID"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:left;vertical-align:top;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Supplementary_WCD_ID"></asp:Literal></span>
</td></tr><tr id="Sel_WCAR_Doc_Creator_Approver1TableControlAltRow" runat="server"><td class="ticnb" scope="row">&nbsp;</td><td class="ticnb" scope="row" colspan="14"><BaseClasses:TabContainer runat="server" id="Sel_WCAR_Doc_Creator_ApproverTableControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="WCAR_ActivityTabPanel" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WCAR_Activity1TableControl runat="server" id="WCAR_Activity1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="WCAR_Activity1CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Activity1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;"><b><asp:Literal runat="server" id="WCA_W_U_IDLabel" Text="User (Assigned)">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;"><b><asp:Literal runat="server" id="WCA_StatusLabel" Text="Status">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;"><b><asp:Literal runat="server" id="WCA_Date_AssignLabel" Text="Date Assign">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;"><b><asp:Literal runat="server" id="WCA_Date_ActionLabel" Text="Date Action">	</asp:Literal></b></th><th class="thcwb" style="padding:0px;vertical-align:middle;text-align:center;"><b><asp:Literal runat="server" id="WCA_RemarkLabel" Text="Remark">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_Activity1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Activity1TableControlRow runat="server" id="WCAR_Activity1TableControlRow">
<tr><td class="tableCellValue" scope="row" style="vertical-align:middle;text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID"></asp:Literal></span>
</td><td class="tableCellValue" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCA_Status"></asp:Literal></td><td class="tableCellValue" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Assign"></asp:Literal></span>
</td><td class="tableCellValue" scope="row" style="vertical-align:middle;text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Action"></asp:Literal></span>
</td><td class="tableCellValue" scope="row" style="text-align:left;vertical-align:middle;"><asp:Literal runat="server" id="WCA_Remark"></asp:Literal></td></tr></ePortalWFApproval:WCAR_Activity1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td></td><td></td></tr></table>
	<asp:hiddenfield id="WCAR_Activity1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Activity1TableControl>

 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WCAR_Doc_CheckerTabPanel" HeaderText="Co-Requester">	<ContentTemplate> 
  <ePortalWFApproval:WCAR_Doc_Checker1TableControl runat="server" id="WCAR_Doc_Checker1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="WCAR_Doc_Checker1CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Doc_Checker1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;"><b><asp:Literal runat="server" id="WCDC_U_IDLabel" Text="Co-Requester">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;"><b><asp:Literal runat="server" id="WCDC_StatusLabel" Text="Status">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;"><b><asp:Literal runat="server" id="WCDC_RemLabel" Text="Remark">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_Doc_Checker1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Doc_Checker1TableControlRow runat="server" id="WCAR_Doc_Checker1TableControlRow">
<tr><td class="tableCellValue" scope="row" style="text-align:left;vertical-align:middle;"></td><td class="tableCellValue" scope="row" style="text-align:center;vertical-align:middle;"></td><td class="tableCellValue" scope="row" style="text-align:left;vertical-align:middle;"></td></tr></ePortalWFApproval:WCAR_Doc_Checker1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td></td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="WCAR_Doc_Checker1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Doc_Checker1TableControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer></td><td class="ttc"></td></tr><tr><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td><td class="ticnb" scope="row"></td></tr></ePortalWFApproval:Sel_WCAR_Doc_Creator_Approver1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Sel_WCAR_Doc_Creator_Approver1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WCAR_Doc_Creator_Approver1TableControl>

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
                