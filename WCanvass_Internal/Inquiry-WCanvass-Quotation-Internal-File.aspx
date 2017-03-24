<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Inquiry_WCanvass_Quotation_Internal_File" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Inquiry-WCanvass-Quotation-Internal-File.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="ePortalWFApproval.UI.Inquiry_WCanvass_Quotation_Internal_File" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><ePortalWFApproval:WCanvass_Quotation_InternalTableControl runat="server" id="WCanvass_Quotation_InternalTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="WCanvass_Quotation_InternalTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"><asp:ImageButton runat="server" id="WCanvass_Quotation_InternalRefreshButton" causesvalidation="false" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src=&#39;../Images/ButtonBarRefresh.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarRefreshOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"></td><td class="prbbc"></td><td class="pra"><ePortalWFApproval:Pagination runat="server" id="WCanvass_Quotation_InternalPagination"></ePortalWFApproval:Pagination></td></tr></table>
</td></tr><tr><td class="tre"><table id="WCanvass_Quotation_InternalTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCQI_PM00200_Vendor_IDLabel" Text="Vendor ID">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCQI_DescLabel" Text="Attachment Description">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCQI_FileLabel" Text="Download">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WCanvass_Quotation_InternalTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCanvass_Quotation_InternalTableControlRow runat="server" id="WCanvass_Quotation_InternalTableControlRow">
<tr><td class="tableCellValue" style="text-align:left;"><asp:Literal runat="server" id="WCQI_PM00200_Vendor_ID"></asp:Literal></td><td class="tableCellValue" style="text-align:left;"><asp:Literal runat="server" id="WCQI_Desc"></asp:Literal></td><td class="tableCellValue" style="text-align:left;"><asp:LinkButton runat="server" id="WCQI_File" CommandName="Redirect"></asp:LinkButton></td></tr></ePortalWFApproval:WCanvass_Quotation_InternalTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td><td class="panelT"></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="WCanvass_Quotation_InternalTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCanvass_Quotation_InternalTableControl>
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
                