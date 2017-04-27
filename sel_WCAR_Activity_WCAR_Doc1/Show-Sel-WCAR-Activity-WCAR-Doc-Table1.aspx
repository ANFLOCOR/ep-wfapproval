<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-Sel-WCAR-Activity-WCAR-Doc-Table1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_Sel_WCAR_Activity_WCAR_Doc_Table1" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_Sel_WCAR_Activity_WCAR_Doc_Table1" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                        <ePortalWFApproval:Sel_WCAR_Activity_WCAR_Doc1TableControl runat="server" id="Sel_WCAR_Activity_WCAR_Doc1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><b><span style="font-size:14pt"><asp:Literal runat="server" id="Title0" Text="Approved CAR Documents (North)">	</asp:Literal></span></b></td></tr></table>
</td><td class="dhb"></td><td class="dher"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="1300px"><tr><td class="tre">&nbsp;</td></tr><tr><td class="tre">
                    <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /> 
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">Filters</td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:literal id="Literal" runat="server" text="&nbsp;" /></td><td></td><td></td></tr><tr><td colspan="2"><asp:Literal runat="server" id="WCD_C_IDLabel1" Text="Company">	</asp:Literal> 
<asp:DropDownList runat="server" id="WCD_C_IDFromFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList></td><td><span class="rft"></span> </td></tr><tr><td><asp:literal id="Literal1" runat="server" text="&nbsp;" /></td><td></td><td></td></tr><tr><td></td><td><span class="rft"></span> </td><td></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><ePortalWFApproval:PaginationModern runat="server" id="Pagination"></ePortalWFApproval:PaginationModern></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="tre"><table id="Sel_WCAR_Activity_WCAR_Doc1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb"></th><th class="thcnb" style="border-left:none;"></th><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCA_WDT_IDLabel" Text="Workflow ">	</asp:Literal></th><th class="thcnb" style="text-align:center;width:90px;"><asp:Literal runat="server" id="WCA_WCD_IDLabel" Text="CAR No ">	</asp:Literal></th><th class="thcwb" style="padding:0px;vertical-align:middle;text-align:center;"><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Description">	</asp:Literal></th><th class="thc" scope="col" style="text-align:center;"><asp:Literal runat="server" id="WCD_WCur_IDLabel" Text="Currency">	</asp:Literal></th><th class="thc" scope="col" style="text-align:center;"><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="Total Amount">	</asp:Literal></th><th class="thc" scope="col" style="text-align:center;width:90px;"><asp:Literal runat="server" id="WCA_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc" scope="col" style="text-align:center;"><asp:Literal runat="server" id="WCA_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc" scope="col" style="text-align:center;"><asp:Literal runat="server" id="WCA_W_U_IDLabel" Text="Creator">	</asp:Literal></th><th class="thc" scope="col" style="width:90px;text-align:center;"><asp:Literal runat="server" id="WCD_Request_DateLabel" Text="Request Date">	</asp:Literal></th><th class="thc" scope="col" style="width:115px;text-align:center;"><asp:Literal runat="server" id="litSupplementaryLabel" Text="Supplementary Of">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WCAR_Activity_WCAR_Doc1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WCAR_Activity_WCAR_Doc1TableControlRow runat="server" id="Sel_WCAR_Activity_WCAR_Doc1TableControlRow">
<tr><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;"><asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton> 
</td><td class="tableRowButtonsCellVertical" scope="row" style="font-size: 5px;border-left:none;"><asp:ImageButton runat="server" id="ImageButton1" alternatetext="OPEN" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ePortalWFApproval&quot;) %>" visible="True">		
	</asp:ImageButton></td><td class="ticnb" scope="row" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_WDT_ID"></asp:Literal></span>
</td><td class="ticwb" style="text-align:center;"><asp:Literal runat="server" id="WCD_No"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_WCD_ID" visible="False"></asp:Literal></span>
 
</td><td class="ttc" style="text-align:center;"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal></td><td class="ttc" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_WCur_ID"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total"></asp:Literal></span>
</td><td class="ttc" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Assign"></asp:Literal></span>
</td><td class="ttc" style="text-align:center;"><asp:Literal runat="server" id="WCA_Status"></asp:Literal></td><td class="ttc" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID"></asp:Literal></span>
</td><td class="ttc" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Request_Date"></asp:Literal></span>
</td><td class="ttc" style="text-align:center;"><asp:Literal runat="server" id="litSupplementary" Text="NONE">	</asp:Literal></td></tr><tr id="Sel_WCAR_Activity_WCAR_Doc1TableControlAltRow" runat="server"><td class="tableRowDivider"></td><td class="tableRowDivider" colspan="11"><asp:tabcontainer id="WCAR_DocTabContainer" runat="server">
    <asp:tabpanel id="WCAR_Doc_AttachTabPanel" runat="server">
        <headertemplate>Supporting Documents</headertemplate>
        <contenttemplate><ePortalWFApproval:Sel_WAttach_Type_WCAR_Doc_Attach1TableControl runat="server" id="Sel_WAttach_Type_WCAR_Doc_Attach1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="Supporting Documents">	</asp:Literal>
                      </td></tr></table>
</td></tr></table>

                </td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination1"></ePortalWFApproval:PaginationModern></td></tr><tr><td class="tre"><table id="Sel_WAttach_Type_WCAR_Doc_Attach1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCDA_FileLabel" Text="File Download">	</asp:Literal></th><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCDA_DescLabel1" Text="Description">	</asp:Literal></th><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WAT_NameLabel" Text="Attach Type">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WAttach_Type_WCAR_Doc_Attach1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WAttach_Type_WCAR_Doc_Attach1TableControlRow runat="server" id="Sel_WAttach_Type_WCAR_Doc_Attach1TableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;"><asp:LinkButton runat="server" id="WCDA_File" CommandName="Redirect"></asp:LinkButton></td><td class="ticnb" scope="row" style="text-align:center;"><asp:Literal runat="server" id="WCDA_Desc"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;"><asp:Literal runat="server" id="WAT_Name"></asp:Literal></td></tr></ePortalWFApproval:Sel_WAttach_Type_WCAR_Doc_Attach1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="Sel_WAttach_Type_WCAR_Doc_Attach1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WAttach_Type_WCAR_Doc_Attach1TableControl>
</contenttemplate>
    </asp:tabpanel>
	  

<asp:tabpanel id="WCAR_ActivityTabPanel_Real" runat="server">
        <headertemplate>Approval History</headertemplate>
        <contenttemplate><ePortalWFApproval:WCAR_Activity1TableControl runat="server" id="WCAR_Activity1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title2" Text="Approval History">	</asp:Literal>
                      </td></tr></table>
</td></tr></table>

                </td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination2"></ePortalWFApproval:PaginationModern></td></tr><tr><td class="tre"><table id="WCAR_Activity1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCA_W_U_IDLabel1" Text="User (Assigned)">	</asp:Literal></th><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCA_WSD_IDLabel" Text="Type">	</asp:Literal></th><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCA_StatusLabel2" Text="Status ">	</asp:Literal></th><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCA_Date_AssignLabel1" Text="Date Assigned ">	</asp:Literal></th><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCA_Date_ActionLabel" Text="Date Action ">	</asp:Literal></th><th class="thcnb" style="text-align:center;"><asp:Literal runat="server" id="WCA_RemarkLabel" Text="Remark ">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WCAR_Activity1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Activity1TableControlRow runat="server" id="WCAR_Activity1TableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID1"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;"><asp:Literal runat="server" id="WCA_WS_ID"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;"><asp:Literal runat="server" id="WCA_Status1"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Assign1"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Action"></asp:Literal></span>
</td><td class="ticnb" scope="row"><asp:Literal runat="server" id="WCA_Remark"></asp:Literal></td></tr></ePortalWFApproval:WCAR_Activity1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="WCAR_Activity1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Activity1TableControl>
</ContentTemplate>
    </asp:tabpanel>
	<asp:tabpanel id="WCAR_Activity_RemarkTabPanel" runat="server">
        <headertemplate>Remarks</headertemplate>
        <contenttemplate></ContentTemplate>
    </asp:tabpanel>
	<asp:tabpanel id="WCAR_ActivityTabPanel" runat="server">
        <headertemplate>Workflow Path</headertemplate>
        <contenttemplate><ePortalWFApproval:Sel_WStep_WStep_Detail1TableControl runat="server" id="Sel_WStep_WStep_Detail1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title3" Text="Workflow Path">	</asp:Literal>
                      </td></tr></table>
</td></tr></table>

                </td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination3"></ePortalWFApproval:PaginationModern></td></tr><tr><td class="tre"><table id="Sel_WStep_WStep_Detail1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WSD_W_U_IDLabel" Text="User (Assigned) ">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WS_Step_TypeLabel" Text="Step Type ">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WS_IDLabel" Text="Step Description">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WStep_WStep_Detail1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WStep_WStep_Detail1TableControlRow runat="server" id="Sel_WStep_WStep_Detail1TableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WSD_W_U_ID"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;"><asp:Literal runat="server" id="WS_Step_Type"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WS_ID"></asp:Literal></span>
</td></tr></ePortalWFApproval:Sel_WStep_WStep_Detail1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="Sel_WStep_WStep_Detail1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WStep_WStep_Detail1TableControl>
</ContentTemplate>
    </asp:tabpanel>
</asp:tabcontainer> 
</td></tr></ePortalWFApproval:Sel_WCAR_Activity_WCAR_Doc1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Sel_WCAR_Activity_WCAR_Doc1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WCAR_Activity_WCAR_Doc1TableControl>

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
                