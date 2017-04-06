<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-WCAR-Activity-Table.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_WCAR_Activity_Table" %>
<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_WCAR_Activity_Table" %>

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
                        <ePortalWFApproval:WCAR_ActivityTableControl runat="server" id="WCAR_ActivityTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0" style="width:1100px;"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="CAR Workflow Reassign Tasks  (South)">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table><tr><td><asp:literal id="Literal" runat="server" text="&nbsp;" /></td><td></td><td></td></tr><tr><td style="text-align:left;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_W_U_IDLabel1" Text="User (Assigned):">	</asp:Literal></b></td><td style="text-align:left;vertical-align:middle;"><asp:DropDownList runat="server" id="WCA_W_U_IDFilter" autopostback="True" cssclass="Filter_Input" font-size="9pt" height="20px" onkeypress="dropDownListTypeAhead(this,false)" selectionmode="Single" width="223px">	</asp:DropDownList> </td><td><ePortalWFApproval:ThemeButton runat="server" id="WCAR_ActivitySearchButton" button-causesvalidation="false" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td></tr><tr><td class="fila"><asp:literal id="Literal1" runat="server" text="&nbsp;" /></td><td></td><td class="filbc"></td></tr><tr><td class="fls" style="text-align:left;vertical-align:middle;"><b><asp:Literal runat="server" id="litAssignTo" Text="Assign To:">	</asp:Literal></b></td><td style="padding-left:6px;text-align:left;vertical-align:middle;" class="fls"><asp:dropdownlist id="ddlAssignTo" runat="server" width="223px" class="fls" height="20px" font-size="9pt" cssclass="Filter_Input">
	<asp:listitem>User 1</asp:listitem>
	<asp:listitem>User 2</asp:listitem>
	<asp:listitem>User 3</asp:listitem>
</asp:dropdownlist></td><td class="fls" style="text-align:left;font-family:Tahoma;font-size:9pt;vertical-align:middle;"><asp:Button CommandName="Redirect" runat="server" id="btnAssignTo" causesvalidation="false" onclientclick="javascript:ShowConfirm(event,&#39;Confirm Re-Assign&#39;,&#39;Are you sure you want to re-assign this activity?&#39;,&#39;You can re-assign this activity in case you made a mistake.&#39;);" text="&lt;%# GetResourceValue(&quot;Assign&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Assign&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:Button> 
<ePortalWFApproval:ThemeButton runat="server" id="btnAssignTo1" button-causesvalidation="false" button-text="&lt;%# GetResourceValue(&quot;x&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;x&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false"></ePortalWFApproval:ThemeButton></td></tr><tr><td class="dfv"><asp:literal id="Literal2" runat="server" text="&nbsp;" /></td><td style="padding-left:6px;" class="fls"></td><td class="filbc"></td></tr></table>
</td></tr><tr><td class="tre"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="tre"><ePortalWFApproval:PaginationModern runat="server" id="Pagination"></ePortalWFApproval:PaginationModern></td><td class="dhb"></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="tre"><table id="WCAR_ActivityTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb"></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><asp:CheckBox runat="server" id="WCAR_ActivityToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:Literal runat="server" id="WCA_WDT_IDLabel" Text="Workflow">	</asp:Literal></b></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:Literal runat="server" id="WCA_WS_IDLabel" Text="Step Description">	</asp:Literal></b></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:Literal runat="server" id="WCA_W_U_IDLabel" Text="User (Assigned)">	</asp:Literal></b></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:Literal runat="server" id="WCA_WCD_IDLabel" Text="CAR No.">	</asp:Literal></b></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:Literal runat="server" id="WCA_StatusLabel" Text="Status">	</asp:Literal></b></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:Literal runat="server" id="WCA_Date_AssignLabel" Text="Date Assign">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_RemarkLabel" Text="Remark">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_ActivityTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_ActivityTableControlRow runat="server" id="WCAR_ActivityTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:ImageButton runat="server" id="WCAR_ActivityRowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton> 
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:CheckBox runat="server" id="WCAR_ActivityRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCA_WDT_ID"></asp:Literal></td><td class="ticwb" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCA_WS_ID"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_ID" visible="False"></asp:Literal></span>
</td><td class="ticwb" style="vertical-align:middle;text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID1" visible="False"></asp:Literal></span>
</td><td class="ticwb" style="vertical-align:middle;text-align:center;"><asp:Literal runat="server" id="WCA_WCD_ID"></asp:Literal></td><td class="ticwb" style="vertical-align:middle;text-align:center;"><asp:Literal runat="server" id="WCA_Status"></asp:Literal></td><td class="ticwb" style="vertical-align:middle;text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Assign"></asp:Literal></span>
</td><td class="ticwb" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCA_Remark"></asp:Literal></td></tr><tr id="WCAR_ActivityTableControlAltRow" runat="server"><td class="ticnb" scope="row"></td><td class="ticnb" scope="row" colspan="8"><asp:tabcontainer id="WCAR_ActivityTabContainer" runat="server">
    <asp:tabpanel id="WCAR_DocTabPanel" runat="server">
        <headertemplate>CAR Information</headertemplate>
        <contenttemplate><ePortalWFApproval:WCAR_DocTableControl runat="server" id="WCAR_DocTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="CAR Document">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td></td><td>
                  <asp:panel id="WCAR_DocTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_DocTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Title">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:LinkButton runat="server" id="WCD_Request_DateLabel" tooltip="Sort by WCD_Request_Date" Text="Request Date" CausesValidation="False">	</asp:LinkButton></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:LinkButton runat="server" id="WCD_WCur_IDLabel" tooltip="Sort by WCD_WCur_ID" Text="Currency" CausesValidation="False">	</asp:LinkButton></b></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:LinkButton runat="server" id="WCD_Exp_Cur_YrLabel" tooltip="Sort by WCD_Exp_Cur_Yr" Text="This Request (Ttl)" CausesValidation="False">	</asp:LinkButton></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCD_RemarkLabel" Text="Remarks">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WCAR_DocTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_DocTableControlRow runat="server" id="WCAR_DocTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Request_Date"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCD_WCur_ID"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:right;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Cur_Yr"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCD_Remark"></asp:Literal></td></tr></ePortalWFApproval:WCAR_DocTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="WCAR_DocTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_DocTableControl>
</ContentTemplate>
    </asp:tabpanel>
	 <asp:tabpanel id="WCAR_Doc_AttachTabPanel" runat="server">
		 <headertemplate>Supporting Documents</headertemplate>
        <contenttemplate><ePortalWFApproval:Sel_WAttach_Type_WCAR_Doc_AttachTableControl runat="server" id="Sel_WAttach_Type_WCAR_Doc_AttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title2" Text="CAR Supporting Documents">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td></td><td>
                  <asp:panel id="Sel_WAttach_Type_WCAR_Doc_AttachTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Sel_WAttach_Type_WCAR_Doc_AttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDA_FileLabel" Text="File Download">	</asp:Literal></b></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><asp:LinkButton runat="server" id="WCDA_DescLabel" tooltip="Sort by WCDA_Desc" Text="Description" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><asp:LinkButton runat="server" id="WAT_NameLabel" tooltip="Sort by WAT_Name" Text="Attach Type" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="Sel_WAttach_Type_WCAR_Doc_AttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WAttach_Type_WCAR_Doc_AttachTableControlRow runat="server" id="Sel_WAttach_Type_WCAR_Doc_AttachTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:LinkButton runat="server" id="WCDA_File" CommandName="Redirect"></asp:LinkButton></td><td class="ticnb" scope="row" style="vertical-align:middle;text-align:center;"><asp:Literal runat="server" id="WCDA_Desc"></asp:Literal></td><td class="ticnb" scope="row" style="vertical-align:middle;text-align:center;"><asp:Literal runat="server" id="WAT_Name"></asp:Literal></td></tr></ePortalWFApproval:Sel_WAttach_Type_WCAR_Doc_AttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="Sel_WAttach_Type_WCAR_Doc_AttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WAttach_Type_WCAR_Doc_AttachTableControl>
</contenttemplate>
    </asp:tabpanel>
	
	<asp:tabpanel id="WCAR_ActivityTabPanel" runat="server">
		 <headertemplate>Workflow Path</headertemplate>
        <contenttemplate><ePortalWFApproval:Sel_WStep_WStep_DetailTableControl runat="server" id="Sel_WStep_WStep_DetailTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title3" Text="CAR Workflow Path">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"></td><td class="dher"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td></td><td>
                  <asp:panel id="Sel_WStep_WStep_DetailTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Sel_WStep_WStep_DetailTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:LinkButton runat="server" id="WSD_W_U_IDLabel" tooltip="Sort by WSD_W_U_ID" Text="User (Assigned)" CausesValidation="False">	</asp:LinkButton></b></th><th class="thcnb" style="vertical-align:middle;text-align:center;"><b><asp:LinkButton runat="server" id="WS_Step_TypeLabel" tooltip="Sort by WS_Step_Type" Text="Step Type" CausesValidation="False">	</asp:LinkButton></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:LinkButton runat="server" id="WSD_IDLabel" tooltip="Sort by WSD_ID" Text="Step Type" CausesValidation="False">	</asp:LinkButton></b></th></tr><asp:Repeater runat="server" id="Sel_WStep_WStep_DetailTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WStep_WStep_DetailTableControlRow runat="server" id="Sel_WStep_WStep_DetailTableControlRow">
<tr><td class="ticnb" scope="row" style="vertical-align:middle;text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WSD_W_U_ID"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="vertical-align:middle;text-align:center;"><asp:Literal runat="server" id="WS_Step_Type"></asp:Literal></td><td class="ticnb" scope="row" style="vertical-align:middle;text-align:center;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WS_ID"></asp:Literal></span>
</td></tr></ePortalWFApproval:Sel_WStep_WStep_DetailTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="Sel_WStep_WStep_DetailTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WStep_WStep_DetailTableControl>
</contenttemplate>
    </asp:tabpanel>
</asp:tabcontainer></td></tr></ePortalWFApproval:WCAR_ActivityTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_ActivityTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_ActivityTableControl>

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
                