<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Inquiry_POP30300_POP30310_Vendor1" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Inquiry-POP30300-POP30310-Vendor1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="ePortalWFApproval.UI.Inquiry_POP30300_POP30310_Vendor1" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><ePortalWFApproval:Sel_POP30300_POP30310TableControl runat="server" id="Sel_POP30300_POP30310TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:literal id="Literal" runat="server" text="&nbsp;" /></td></tr><tr><td class="dfv"><asp:Literal runat="server" id="litVendor" Text="NONE">	</asp:Literal></td></tr><tr><td><asp:literal id="Literal1" runat="server" text="&nbsp;" /></td></tr><tr><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"><asp:ImageButton runat="server" id="Sel_POP30300_POP30310RefreshButton" causesvalidation="false" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src=&#39;../Images/ButtonBarRefresh.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarRefreshOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"></td><td class="prbbc"></td><td class="pra"><ePortalWFApproval:Pagination runat="server" id="Sel_POP30300_POP30310Pagination"></ePortalWFApproval:Pagination></td></tr></table>
</td></tr><tr><td class="tre"><table id="Sel_POP30300_POP30310TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="ITEMNMBRLabel" Text="Item No">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="ITEMDESCLabel" Text="Description">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="UOFMLabel" Text="UoM">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="UNITCOSTLabel" Text="Unit Cost">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="QtyLabel" Text="Quantity">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="EXTDCOSTLabel" Text="Total">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="receiptdateLabel" Text="Receipt Date">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_POP30300_POP30310TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_POP30300_POP30310TableControlRow runat="server" id="Sel_POP30300_POP30310TableControlRow">
<tr><td class="tableCellValue"><asp:Literal runat="server" id="ITEMNMBR"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="ITEMDESC"></asp:Literal></td><td class="tableCellValue" style="text-align:center;"><asp:Literal runat="server" id="UOFM"></asp:Literal></td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UNITCOST"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Qty"></asp:Literal></span>
</td><td class="tableCellValue" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EXTDCOST"></asp:Literal></span>
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="receiptdate"></asp:Literal></span>
</td></tr></ePortalWFApproval:Sel_POP30300_POP30310TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Sel_POP30300_POP30310TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_POP30300_POP30310TableControl>
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
                