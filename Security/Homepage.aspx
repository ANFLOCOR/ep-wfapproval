<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Homepage.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Homepage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Homepage" %>
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

                <table><tr><td><table class="dv" cellpadding="0" cellspacing="0" border="0" style="width:800px;"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /> 
</td><td class="dheci" valign="middle"><table cellpadding="0" cellspacing="0" border="0" style="height:40px;"><tr><td class="dht" valign="middle" style="text-align:left;"><b><span style="font-size:16pt">Dashboard</span></b></td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">&nbsp;</td><td class="tre"></td><td class="tre"></td><td class="tre"></td><td class="tre"></td></tr><tr><td class="tre">&nbsp;</td><td class="tre"></td><td class="tre"></td><td class="tre"></td><td class="tre"></td></tr><tr><td class="tre"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PanelExtender3" runat="server" TargetControlid="ApproverPipelineCollapsibleRegion" ExpandControlID="Icon3" CollapseControlID="Icon3" ImageControlID="Icon3" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" collapsed="True" />
<asp:ImageButton id="Icon3" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><span style="font-size:12pt"><b>Approver Pipeline</b></span></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="ApproverPipelineCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:tabcontainer id="ApproverPipelineTabContainer" runat="server">
    <asp:tabpanel id="North" runat="server" headertext="North">
        <headertemplate>North</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;">    
				<li style="margin-left:-30px; padding-bottom:10px;">    
				<li style="margin-left:-40px; padding-bottom:10px;">&nbsp
				<li style="margin-left:-40px; padding-bottom:10px;">&nbsp
			</ul>
		</contenttemplate>
    </asp:tabpanel>
	 <asp:tabpanel id="South" runat="server" headertext="South">
        <headertemplate>South</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;">   
				<li style="margin-left:-30px; padding-bottom:10px;">  
				<li style="margin-left:-40px; padding-bottom:10px;">&nbsp
				<li style="margin-left:-40px; padding-bottom:10px;">&nbsp
			</ul>
		</ContentTemplate>
    </asp:tabpanel>
</asp:tabcontainer></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td><td>&nbsp;</td><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PanelExtender4" runat="server" TargetControlid="ApproverHistoryCollapsibleRegion" ExpandControlID="Icon4" CollapseControlID="Icon4" ImageControlID="Icon4" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" collapsed="True" />
<asp:ImageButton id="Icon4" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><b><span style="font-size:12pt">Approval History</span></b></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="ApproverHistoryCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:tabcontainer id="ApproverHistoryTabContainer" runat="server">
    <asp:tabpanel id="ApproverHistoryNorth" runat="server" headertext="North">
        <headertemplate>North</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;">    
				<li style="margin-left:-30px; padding-bottom:10px;">    
				<li style="margin-left:-30px; padding-bottom:10px;">  
				<li style="margin-left:-30px; padding-bottom:10px;">  
			</ul>
		</contenttemplate>
    </asp:tabpanel>
	 <asp:tabpanel id="ApproverHistorySouth" runat="server" headertext="South">
        <headertemplate>South</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;">   
				<li style="margin-left:-30px; padding-bottom:10px;">  
				<li style="margin-left:-30px; padding-bottom:10px;">  
				<li style="margin-left:-30px; padding-bottom:10px;">  
			</ul>
		</ContentTemplate>
    </asp:tabpanel>
</asp:tabcontainer></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td><td>&nbsp;</td><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PanelExtender5" runat="server" TargetControlid="FSReportsPanelCollapsibleRegion" ExpandControlID="Icon5" CollapseControlID="Icon5" ImageControlID="Icon5" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" collapsed="True" />
<asp:ImageButton id="Icon5" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><b><span style="font-size:12pt">FS Reports (Inquiry)</span></b></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="FSReportsPanelCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:tabcontainer id="FSReportsTabContainer1" runat="server">
    <asp:tabpanel id="FSReportsNorth" runat="server" headertext="North">
        <headertemplate>North</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;">    
				<li style="margin-left:-30px; padding-bottom:10px;">    
				<li style="margin-left:-30px; padding-bottom:10px;">&nbsp
				<li style="margin-left:-30px; padding-bottom:10px;">&nbsp
			</ul>
		</contenttemplate>
    </asp:tabpanel>
	 <asp:tabpanel id="FSReportsSouth" runat="server" headertext="South">
        <headertemplate>South</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;">   
				<li style="margin-left:-30px; padding-bottom:10px;">  
				<li style="margin-left:-30px; padding-bottom:10px;">&nbsp
				<li style="margin-left:-30px; padding-bottom:10px;">&nbsp
			</ul>
		</ContentTemplate>
    </asp:tabpanel>
</asp:tabcontainer></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="tre">&nbsp;</td><td class="tre"></td><td class="tre"></td><td class="tre"></td><td class="tre"></td></tr><tr><td class="tre" colspan="5"><ePortalWFApproval:Sel_Approver_Pending_Tasks2TableControl runat="server" id="Sel_Approver_Pending_Tasks2TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%" style="padding-left:5px;"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /> 
<asp:CollapsiblePanelExtender id="PanelExtender" runat="server" TargetControlid="Sel_Approver_Pending_Tasks2CollapsibleRegion" ExpandControlID="Icon" CollapseControlID="Icon" ImageControlID="Icon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" /> 
<asp:ImageButton id="Icon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="height:30px;"><tr><td class="dht" valign="middle" style="text-align:left;"><b><span style="font-size:12pt"><asp:Literal runat="server" id="Sel_Approver_Pending_TasksTitle1" Text="North Pending Documents">	</asp:Literal></span></b></td></tr></table>
</td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="Sel_Approver_Pending_Tasks2CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table><tr><td colspan="9"><asp:literal id="Literal" runat="server" text="&nbsp;"></asp:literal></td><td></td><td></td><td></td><td></td></tr><tr><td colspan="7" class="thc2" style="text-align:center;vertical-align:middle;">&nbsp; 
<asp:Image runat="server" id="Image1" imageurl="../Images/docs.png">		
	</asp:Image></td><td style="text-align:left;vertical-align:middle;color:Black;font-weight:normal;" class="thc3"><asp:Image runat="server" id="Image3" backcolor="Transparent" forecolor="Transparent" imageurl="../Images/loading.gif" visible="False">		
	</asp:Image>&nbsp;&nbsp;&nbsp;<asp:Label runat="server" id="litLoading1" Text="Please wait while the browser loads your requested document..." visible="False">	</asp:Label></td><td style="text-align:left;vertical-align:middle;color:Black;font-weight:normal;" class="thc2"><asp:Label runat="server" id="Literal1" Text="&amp;nbsp;">	</asp:Label>&nbsp;</td><td><ePortalWFApproval:ThemeButton runat="server" id="NorthRedirectorButtonCARDoc" button-causesvalidation="False" button-commandname="Redirect" button-text="CAR Documents" button-tooltip="CAR Documents"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="NorthRedirectorButtonReCAR" button-causesvalidation="False" button-commandname="Redirect" button-text="Reassign CAR" button-tooltip="Reassign CAR"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="SouthRedirectorButtonPODoc1" button-causesvalidation="False" button-commandname="Redirect" button-text="PO Documents" button-tooltip="PO Documents"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="NorthRedirectorButtonRePO" button-causesvalidation="False" button-commandname="Redirect" button-text="Reassign PO" button-tooltip="Reassign PO"></ePortalWFApproval:ThemeButton></td></tr><tr><td colspan="9"><asp:literal id="Literal5" runat="server" text="&nbsp;"></asp:literal></td><td></td><td></td><td></td><td></td></tr></table>
</td></tr><tr><td class="tre"><!--<gen:panel id="NorthRedirectorPanelWithHeader" /> --></td></tr><tr><td class="tre"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="prbbc"><asp:ImageButton runat="server" id="Sel_Approver_Pending_TasksRefreshButton1" causesvalidation="false" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src=&#39;../Images/ButtonBarRefresh.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarRefreshOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="panelPaginationC" style="background-color:transparent;"><ePortalWFApproval:Pagination runat="server" id="WCAR_DocPagination"></ePortalWFApproval:Pagination></td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"></asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="tre"><table id="Sel_Approver_Pending_Tasks2TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="2" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Doc_TypeLabel2" Text="Document Type">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Company_DescLabel2" Text="Company Description">	</asp:Literal></b></th><th class="thcnb" colspan="2" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Doc_NoLabel2" Text="Document Number">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Date_AssignedLabel2" Text="Date Assigned">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Doc_TitleLabel2" Text="Document Title">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Doc_TotalLabel2" Text="Document Total">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="Sel_Approver_Pending_Tasks2TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_Approver_Pending_Tasks2TableControlRow runat="server" id="Sel_Approver_Pending_Tasks2TableControlRow">
<tr><td scope="row" style="text-align:left;vertical-align:middle;border-right:none;" class="tableCellValue"><asp:ImageButton runat="server" id="imbList1" causesvalidation="False" commandname="Redirect" imageurl="../Images/Book_openHS.png" tooltip="Click the icon to view pending documents" visible="False">		
	</asp:ImageButton> 
<asp:ImageButton runat="server" id="imbDoc1" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="../Images/icon-open.png" onmouseover="../Images/icon-open-over.png" tooltip="Click the icon to act on this document.">		
	</asp:ImageButton></td><td scope="row" style="text-align:left;vertical-align:middle;width:150px;    border-left-color: transparent;" class="tableCellValue"><asp:Literal runat="server" id="Doc_Type1"></asp:Literal></td><td class="tableCellValue" scope="row" style="text-align:left;vertical-align:middle;width:138px;"><asp:Literal runat="server" id="Company_Desc1"></asp:Literal></td><td style="vertical-align:middle;text-align:left; border-right:none;" class="tableCellValue"></td><td style="vertical-align:middle;text-align:left;    border-left-color: transparent;" class="tableCellValue"><asp:Literal runat="server" id="Doc_No1"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="C_ID1" visible="False"></asp:Literal></span>
</td><td class="tableCellValue" style="vertical-align:middle;text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Date_Assigned1"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="PK_ID1" visible="False"></asp:Literal></span>
</td><td class="tableCellValue" style="vertical-align:middle;text-align:left;width:150px;"><asp:Literal runat="server" id="Doc_Title1"></asp:Literal></td><td class="tableCellValue" style="text-align:right;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Doc_Total1"></asp:Literal></span>
</td></tr><tr><td class="tableRowDivider" colspan="6"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></ePortalWFApproval:Sel_Approver_Pending_Tasks2TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Sel_Approver_Pending_Tasks2TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_Approver_Pending_Tasks2TableControl>
</td></tr><tr><td class="tre">&nbsp;</td><td class="tre"></td><td class="tre"></td><td class="tre"></td><td class="tre"></td></tr><tr><td class="tre" colspan="5"><ePortalWFApproval:Sel_Approver_Pending_TasksTableControl runat="server" id="Sel_Approver_Pending_TasksTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%" style="padding-left:5px;"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /> 
<asp:CollapsiblePanelExtender id="PanelExtender1" runat="server" TargetControlid="Sel_Approver_Pending_TasksTableControlCollapsibleRegion" ExpandControlID="Icon1" CollapseControlID="Icon1" ImageControlID="Icon1" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" /> 
<asp:ImageButton id="Icon1" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="height:30px;"><tr><td class="dht" valign="middle"><b><span style="font-size:12pt"><asp:Literal runat="server" id="Sel_Approver_Pending_TasksTitle" Text="South Pending Documents">	</asp:Literal></span></b></td></tr></table>
</td><td class="dheci" valign="middle"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="Sel_Approver_Pending_TasksTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table><tr><td colspan="9"><asp:literal id="Literal3" runat="server" text="&nbsp;"></asp:literal></td><td></td><td></td><td></td><td></td></tr><tr><td colspan="7" class="thc2" style="text-align:center;vertical-align:middle;">&nbsp; 
<asp:Image runat="server" id="Image2" imageurl="../Images/docs.png">		
	</asp:Image></td><td style="text-align:left;vertical-align:middle;color:Black;font-weight:normal;" class="thc3"><asp:Image runat="server" id="Image" backcolor="Transparent" forecolor="Transparent" imageurl="../Images/loading.gif" visible="False">		
	</asp:Image>&nbsp;&nbsp;&nbsp;<asp:Label runat="server" id="litLoading" Text="Please wait while the browser loads your requested document..." visible="False">	</asp:Label></td><td style="text-align:left;vertical-align:middle;color:Black;font-weight:normal;" class="thc2"><asp:Label runat="server" id="Literal2" Text="&amp;nbsp;">	</asp:Label>&nbsp;</td><td><ePortalWFApproval:ThemeButton runat="server" id="SouthRedirectorButtonCARDoc" button-causesvalidation="False" button-commandname="Redirect" button-text="CAR Documents" button-tooltip="CAR Documents"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="SouthRedirectorButtonReCAR" button-causesvalidation="False" button-commandname="Redirect" button-text="Reassign CAR" button-tooltip="Reassign CAR"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="SouthRedirectorButtonPODoc" button-causesvalidation="False" button-commandname="Redirect" button-text="PO Documents" button-tooltip="PO Documents"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="SouthRedirectorButtonRePO" button-causesvalidation="False" button-commandname="Redirect" button-text="Reassign PO" button-tooltip="Reassign PO"></ePortalWFApproval:ThemeButton></td></tr><tr><td colspan="9"><asp:literal id="Literal4" runat="server" text="&nbsp;"></asp:literal></td><td></td><td></td><td></td><td></td></tr></table>
</td></tr><tr><td class="tre"><!-- <gen:panel id="SouthRedirectorPanelWithHeader" /> --></td></tr><tr><td class="tre"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="prbbc"><asp:ImageButton runat="server" id="Sel_Approver_Pending_TasksRefreshButton" causesvalidation="false" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src=&#39;../Images/ButtonBarRefresh.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarRefreshOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="panelPaginationC" style="background-color:transparent;"><ePortalWFApproval:Pagination runat="server" id="WCAR_DocPagination1"></ePortalWFApproval:Pagination></td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"></asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="tre">
                    <table id="Sel_Approver_Pending_TasksTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="2" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Doc_TypeLabel" Text="Doc Type">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Company_DescLabel" Text="Company">	</asp:Literal></b></th><th class="thcnb" colspan="2" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Doc_NoLabel" Text="Doc No.">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Date_AssignedLabel" Text="Date Assigned">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Doc_TitleLabel" Text="Title/Remarks">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Doc_TotalLabel" Text="Total">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="Sel_Approver_Pending_TasksTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_Approver_Pending_TasksTableControlRow runat="server" id="Sel_Approver_Pending_TasksTableControlRow">
<tr><td scope="row" style="text-align:left;vertical-align:middle;border-right:none;" class="tableCellValue"><asp:ImageButton runat="server" id="imbList" causesvalidation="False" commandname="Redirect" imageurl="../Images/Book_openHS.png" tooltip="Click the icon to view pending documents" visible="False">		
	</asp:ImageButton> 
<asp:ImageButton runat="server" id="imbDoc" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="../Images/icon-open.png" onmouseover="../Images/icon-open-over.png" tooltip="Click the icon to act on this document.">		
	</asp:ImageButton></td><td scope="row" style="text-align:left;vertical-align:middle;width:150px;    border-left-color: transparent;" class="tableCellValue"><asp:Literal runat="server" id="Doc_Type"></asp:Literal></td><td class="tableCellValue" scope="row" style="text-align:left;vertical-align:middle;width:138px;"><asp:Literal runat="server" id="Company_Desc"></asp:Literal></td><td style="vertical-align:middle;text-align:left; border-right:none;" class="tableCellValue"></td><td style="vertical-align:middle;text-align:left;    border-left-color: transparent;" class="tableCellValue"><asp:Literal runat="server" id="Doc_No"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="C_ID" visible="False"></asp:Literal></span>
</td><td class="tableCellValue" style="vertical-align:middle;text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Date_Assigned"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="PK_ID" visible="False"></asp:Literal></span>
</td><td class="tableCellValue" style="vertical-align:middle;text-align:left;width:150px;"><asp:Literal runat="server" id="Doc_Title"></asp:Literal></td><td class="tableCellValue" style="text-align:right;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Doc_Total"></asp:Literal></span>
</td></tr><tr><td class="tableRowDivider" colspan="6"></td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></ePortalWFApproval:Sel_Approver_Pending_TasksTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Sel_Approver_Pending_TasksTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_Approver_Pending_TasksTableControl>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
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
                