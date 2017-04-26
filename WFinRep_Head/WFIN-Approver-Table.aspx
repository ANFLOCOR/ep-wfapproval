<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.WFIN_Approver_Table" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="WFIN-Approver-Table.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.WFIN_Approver_Table" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                        <ePortalWFApproval:Sel_WFIN_ApproverPageTableControl runat="server" id="Sel_WFIN_ApproverPageTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;Financial Statement Workflow Tasks (South)&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table><tr><td><asp:Literal runat="server" id="HFIN_C_IDLabel" Text="Company">	</asp:Literal></td><td><asp:DropDownList runat="server" id="HFIN_C_IDFromFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="200px">	</asp:DropDownList> <span class="rft"></span> </td><td></td></tr><tr><td><asp:Literal runat="server" id="AFIN_StatusLabel1" Text="Status">	</asp:Literal></td><td><asp:DropDownList runat="server" id="AFIN_StatusFromFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)" width="200px">	</asp:DropDownList> <span class="rft"></span> </td><td><ePortalWFApproval:ThemeButton runat="server" id="GoButton" button-causesvalidation="false" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td class="tre"><table id="Sel_WFIN_ApproverPageTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="1"></th><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="AFIN_WDT_IDLabel" Text="Workflow">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIn_DescriptionLabel" Text="Report Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIN_MonthLabel" Text="Month">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="FIN_YearLabel" Text="Year">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_StatusLabel" Text="Status">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WFIN_ApproverPageTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WFIN_ApproverPageTableControlRow runat="server" id="Sel_WFIN_ApproverPageTableControlRow">
<tr><td class="ttc" scope="row" style="font-size: 5px;">
                                  <asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                                  
                                    <br /><br />
                                  </td><td class="ttc"><asp:ImageButton runat="server" id="imbWFEdit" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;">		
	</asp:ImageButton></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_WDT_ID"></asp:Literal></span>
 </td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Assign"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Action"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="FIn_Description"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FIN_Month"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="FIN_Year"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_HFIN_ID" visible="False"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Status"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_FinID" visible="False"></asp:Literal></span>
</td></tr><tr id="Sel_WFIN_ApproverPageTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="8"><BaseClasses:TabContainer runat="server" id="Sel_WFIN_ApproverPageTableControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WFinRep_ActivityTableControl runat="server" id="WFinRep_ActivityTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="Filters1Div" runat="server" class="popupWrapper">
                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WFinRep_ActivityTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="AFIN_W_U_IDLabel" Text="User(Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_WSD_IDLabel" Text="Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_StatusLabel2" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_AssignLabel1" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_Date_ActionLabel1" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="AFIN_RemarkLabel" Text="Remark(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WFinRep_ActivityTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WFinRep_ActivityTableControlRow runat="server" id="WFinRep_ActivityTableControlRow">
<tr><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_W_U_ID"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_WS_ID"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Status1"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Assign1"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="AFIN_Date_Action1"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="AFIN_Remark"></asp:Literal></td></tr></ePortalWFApproval:WFinRep_ActivityTableControlRow>
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
</BaseClasses:TabContainer></td></tr><tr><td class="tableRowDivider" colspan="8"></td><td class="tableRowDivider"></td></tr></ePortalWFApproval:Sel_WFIN_ApproverPageTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <ePortalWFApproval:Pagination runat="server" id="Pagination"></ePortalWFApproval:Pagination>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
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
                