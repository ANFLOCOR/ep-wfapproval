<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationMedium" Src="../Shared/PaginationMedium.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.WFIN_Approver_Table1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="WFIN-Approver-Table1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.WFIN_Approver_Table1" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><ePortalWFApproval:Sel_WFIN_ApproverPageTableControl runat="server" id="Sel_WFIN_ApproverPageTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Sel_WFIN_ApproverPageTitle" Text="Financial Statement Workflow Tasks (North)">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td>
                  <asp:panel id="Sel_WFIN_ApproverPageTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td style="text-align:left;"><asp:Literal runat="server" id="HFIN_C_IDLabel1" Text="Company">	</asp:Literal></td><td style="text-align:left;"><asp:DropDownList runat="server" id="HFIN_C_IDFilter1" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="250px">	</asp:DropDownList></td><td></td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="AFIN_StatusLabel1" Text="Status">	</asp:Literal></td><td style="text-align:left;"><asp:DropDownList runat="server" id="AFIN_StatusFilter1" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="250px">	</asp:DropDownList> </td><td><ePortalWFApproval:ThemeButton runat="server" id="Sel_WFIN_ApproverPageSearchButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td class="tre"><table><tr><td class="pra"><ePortalWFApproval:PaginationMedium runat="server" id="Sel_WFIN_ApproverPagePagination"></ePortalWFApproval:PaginationMedium>
<!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                      </td></tr></table>
</td></tr><tr><td class="tre"><table id="Sel_WFIN_ApproverPageTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="1"></th><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="AFIN_WDT_IDLabel" Text="Workflow">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIn_DescriptionLabel" Text="Report Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIN_MonthLabel" Text="Month">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIN_YearLabel" Text="Year">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_StatusLabel" Text="Status">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WFIN_ApproverPageTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WFIN_ApproverPageTableControlRow runat="server" id="Sel_WFIN_ApproverPageTableControlRow">
<tr><td class="ttc" style="text-align:left;font-size:12pt;"><asp:ImageButton runat="server" id="Sel_WFIN_ApproverPageRowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" style="text-align:left;font-size:12pt;"><asp:ImageButton runat="server" id="imbWFEdit" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;">		
	</asp:ImageButton></td><td class="ttc" style="text-align:left;font-family:Tahoma;color:Black;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_WDT_ID"></asp:Literal></span>
 </td><td class="ttc" style="text-align:left;font-family:Tahoma;color:Black;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Assign"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;font-family:Tahoma;color:Black;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Action"></asp:Literal></span>
 
</td><td class="ttc" style="text-align:left;font-family:Tahoma;color:Black;"><asp:Literal runat="server" id="FIn_Description"></asp:Literal></td><td class="ttc" style="text-align:left;font-family:Tahoma;color:Black;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FIN_Month"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;font-family:Tahoma;color:Black;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FIN_Year"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="HFIN_ID" visible="False"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;font-family:Tahoma;color:Black;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Status"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_FinID" visible="False"></asp:Literal></span>
</td></tr><tr id="Sel_WFIN_ApproverPageTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="ticnb" scope="row" colspan="8"><BaseClasses:TabContainer runat="server" id="AppHistContain" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="AppHistPanel" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_Activity1TableControl runat="server" id="WFinRep_Activity1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WFinRep_ActivityTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_Activity1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="AFIN_W_U_IDLabel" Text="User(Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_WSD_IDLabel" Text="Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_StatusLabel2" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_AssignLabel1" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_ActionLabel1" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_RemarkLabel" Text="Remark(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_Activity1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_Activity1TableControlRow runat="server" id="WFinRep_Activity1TableControlRow">
<tr><td class="ttc" style="font-family:Tahoma;color:Black"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_W_U_ID"></asp:Literal></span>
</td><td class="ttc" style="font-family:Tahoma;color:Black"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_WS_ID"></asp:Literal></span>
</td><td class="ttc" style="font-family:Tahoma;color:Black"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Status1"></asp:Literal></span>
</td><td class="ttc" style="font-family:Tahoma;color:Black"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Assign1"></asp:Literal></span>
</td><td class="ttc" style="font-family:Tahoma;color:Black"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Action1"></asp:Literal></span>
</td><td class="ttc" style="font-family:Tahoma;color:Black"><asp:Literal runat="server" id="AFIN_Remark"></asp:Literal></td></tr></ePortalWFApproval:WFinRep_Activity1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WFinRep_Activity1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WFinRep_Activity1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr></ePortalWFApproval:Sel_WFIN_ApproverPageTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Sel_WFIN_ApproverPageTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WFIN_ApproverPageTableControl>
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
                