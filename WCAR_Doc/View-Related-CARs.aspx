<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="View-Related-CARs.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="ePortalWFApproval.UI.View_Related_CARs" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.View_Related_CARs" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><ePortalWFApproval:Sel_WCAR_Doc_Related_SupplementalTableControl runat="server" id="Sel_WCAR_Doc_Related_SupplementalTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="panelPaginationC"></td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="prbbc" style="text-align:left;"><asp:ImageButton runat="server" id="Sel_WCAR_Doc_Related_SupplementalRefreshButton" causesvalidation="false" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src=&#39;../Images/ButtonBarRefresh.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarRefreshOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="panelPaginationC" style="text-align:left;">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  <ePortalWFApproval:Pagination runat="server" id="Sel_WCAR_Doc_Related_SupplementalPagination"></ePortalWFApproval:Pagination></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"></asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr><tr><td class="tre"><table id="Sel_WCAR_Doc_Related_SupplementalTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_NoLabel" Text="Source CAR #">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Source Project">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_Request_DateLabel" Text="Source Date">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="Source Total">	</asp:Literal></b></th><th class="thcwb" style="padding:0px;vertical-align:middle;text-align:center;"><b><asp:Literal runat="server" id="Rel_CARLabel" Text="Related CAR #">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Rel_ProjLabel" Text="Related Project">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Rel_Req_DateLabel" Text="Related Date">	</asp:Literal></b></th><th class="thc" scope="col" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="Rel_TotalLabel" Text="Related Total">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="Sel_WCAR_Doc_Related_SupplementalTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WCAR_Doc_Related_SupplementalTableControlRow runat="server" id="Sel_WCAR_Doc_Related_SupplementalTableControlRow">
<tr><td class="tableCellValue" scope="row"><span style="font-size:8pt"><asp:Literal runat="server" id="WCD_No"></asp:Literal></span></td><td class="tableCellValue" scope="row"><span style="font-size:8pt"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal></span></td><td class="tableCellValue" scope="row"><span style="font-size:8pt"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Request_Date"></asp:Literal></span>
</span></td><td class="tableCellValue"><span style="font-size:8pt"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total"></asp:Literal></span>
</span></td><td class="tableCellValue"><span style="font-size:8pt"><asp:Literal runat="server" id="Rel_CAR"></asp:Literal></span></td><td class="tableCellValue"><span style="font-size:8pt"><asp:Literal runat="server" id="Rel_Proj"></asp:Literal></span></td><td class="tableCellValue"><span style="font-size:8pt"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Rel_Req_Date"></asp:Literal></span>
</span></td><td class="tableCellValue"><span style="font-size:8pt"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Rel_Total"></asp:Literal></span>
</span></td></tr></ePortalWFApproval:Sel_WCAR_Doc_Related_SupplementalTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr><tr><td class="panelPaginationC"></td></tr><tr><td class="tre"></td></tr><tr><td class="tre"></td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Sel_WCAR_Doc_Related_SupplementalTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WCAR_Doc_Related_SupplementalTableControl>
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
                