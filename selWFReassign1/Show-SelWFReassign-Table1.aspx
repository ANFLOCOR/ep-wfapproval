<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_SelWFReassign_Table1" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-SelWFReassign-Table1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_SelWFReassign_Table1" %>
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
                        <ePortalWFApproval:SelWFReassignTableControl runat="server" id="SelWFReassignTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="SelWFReassignTableControlPanelExtender" runat="server" TargetControlid="CollapsibleRegion" ExpandControlID="Icon" CollapseControlID="Icon" ImageControlID="Icon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="SelWFReassignTableControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="SelWFReassignTitle" Text="PO WORKFLOW REASSIGN TASK (North)">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td>
                  <asp:panel id="SelWFReassignTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td><asp:literal id="Literal" runat="server" text="&nbsp;" /></td><td></td><td class="filbc"></td></tr><tr><td><asp:Literal runat="server" id="WPO_W_U_IDLabel1" Text="WPO W U">	</asp:Literal></td><td><asp:DropDownList runat="server" id="WPO_W_U_IDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single">	</asp:DropDownList> </td><td></td></tr><tr><td><asp:Literal runat="server" id="TOTALLabel1" Text="Total">	</asp:Literal></td><td><asp:TextBox runat="server" id="TOTALFromFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox> <span class="rft"><%# GetResourceValue("Txt:To", "ePortalWFApproval") %></span> <asp:TextBox runat="server" id="TOTALToFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox> </td><td style="text-align:left;"><ePortalWFApproval:ThemeButton runat="server" id="SelWFReassignFilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td></tr><tr><td colspan="3"><asp:literal id="Literal1" runat="server" text="&nbsp;" /></td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="Literal2" Text="Assign To">	</asp:Literal></td><td style="padding-left:6px;text-align:left;" class="fls"><asp:dropdownlist id="ddlAssignTo" runat="server" width="223px" class="fls">
	<asp:listitem>User 1</asp:listitem>
	<asp:listitem>User 2</asp:listitem>
	<asp:listitem>User 3</asp:listitem>
</asp:dropdownlist></td><td style="text-align:left;"><asp:Button CommandName="Redirect" runat="server" id="btnAssignTo" causesvalidation="false" text="&lt;%# GetResourceValue(&quot;Assign&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Assign&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:Button></td></tr></table>
</td></tr><tr><td class="tre"> 
<table><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ePortalWFApproval:Pagination runat="server" id="SelWFReassignPagination"></ePortalWFApproval:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table id="SelWFReassignTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:CheckBox runat="server" id="SelWFReassignToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc"><asp:Literal runat="server" id="WPO_WDT_IDLabel" Text="Workflow">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_WS_IDLabel" Text="Step Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_W_U_IDLabel" Text="User(Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_PONumLabel" Text="PO No">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_RemarkLabel" Text="Remark(s)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="TOTALLabel" Text="Total">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="coIDLabel" Text="Company">	</asp:Literal></th></tr><asp:Repeater runat="server" id="SelWFReassignTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:SelWFReassignTableControlRow runat="server" id="SelWFReassignTableControlRow">
<tr><td class="ttc" style="text-align:left;"><asp:ImageButton runat="server" id="SelWFReassignRowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" style="text-align:left;"><asp:CheckBox runat="server" id="SelWFReassignRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WDT_ID"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WS_ID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_ID"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_W_U_ID"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="WPO_PONum"></asp:Literal> </td><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Status"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Assign"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="WPO_Remark"></asp:Literal></td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="TOTAL"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="coID"></asp:Literal></span>
</td></tr><tr id="SelWFReassignTableControlAltRow" runat="server"><td class="ttc" style="text-align:left;"></td><td class="ttc" style="text-align:left;" colspan="9"></td><td class="ttc" style="text-align:left;"></td></tr></ePortalWFApproval:SelWFReassignTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
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
                