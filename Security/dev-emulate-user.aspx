<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="dev-emulate-user.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.dev_emulate_user" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><asp:Literal runat="server" id="Literal1" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td class="fila"><asp:literal id="Literal" runat="server" text="Emulate User"></asp:literal></td><td style="padding-left:6px;"><asp:dropdownlist id="ddlUser" runat="server" cssclass="Filter_Input" /><asp:dropdownlist id="ddlUser1" runat="server" cssclass="Filter_Input" /></td><td><ePortalWFApproval:ThemeButton runat="server" id="btnEmulate" button-causesvalidation="False" button-commandname="ResetData" button-text="Do It" postback="True"></ePortalWFApproval:ThemeButton></td></tr><tr><td><asp:Literal runat="server" id="Literal11" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td class="fila"><asp:Literal runat="server" id="Literal2" Text="Emulated User">	</asp:Literal></td><td style="padding-left:6px;" class="dfv"><asp:Literal runat="server" id="litUser" Text="NONE">	</asp:Literal></td><td></td></tr><tr><td><asp:Literal runat="server" id="Literal211" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                