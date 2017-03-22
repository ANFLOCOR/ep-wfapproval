<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="WPO-ItemHistory.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/Blank.master" Inherits="ePortalWFApproval.UI.WPO_ItemHistory" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="BlankFramePanelExtender" runat="server" TargetControlid="BlankFrameCollapsibleRegion" ExpandControlID="BlankFrameIcon" CollapseControlID="BlankFrameIcon" ImageControlID="BlankFrameIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="BlankFrameIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">Item History</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="BlankFrameCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>&nbsp;&nbsp;</td></tr><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls" style="text-align:left;"><asp:literal id="ItemNoLabel" runat="server" text="Item:"></asp:literal></td><td class="dfv" style="text-align:left;font-weight:bold;color:Red;text-decoration:underline;"><asp:literal id="ItemDesc" runat="server" text=""></asp:literal></td></tr><tr><td colspan="2">&nbsp;</td></tr><tr><td colspan="2"><asp:GridView ID="ItemGrid" runat="server" OnPageIndexChanging="gridView_PageIndexChanging" OnRowDataBound="gridView_RowDataBound" bordercolor="Silver" borderstyle="Solid" borderwidth="1px" cellpadding="5" cellspacing="1" cssclass="ttc" forecolor="Silver" horizontalalign="Left" allowpaging="True" pageindex="1" pageSize="20">
	<PagerSettings LastPageImageUrl="~/Images/arrow_end.gif" PreviousPageImageUrl="~/Images/arrow_left.gif" FirstPageImageUrl="~/Images/arrow_beg.gif" Position="Top" NextPageImageUrl="~/Images/arrow_right.gif" Mode="NextPreviousFirstLast"></PagerSettings>
	<RowStyle CssClass="ttc"></RowStyle>
	<SelectedRowStyle CssClass="ttcs"></SelectedRowStyle>
	<PagerStyle CssClass="ttc"></PagerStyle>
	<HeaderStyle CssClass="thc"></HeaderStyle>
</asp:GridView></td></tr></table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr></table>
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
                