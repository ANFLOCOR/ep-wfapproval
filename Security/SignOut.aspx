<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="SignOut.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.SignOut" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<asp:Content id="Content" ContentPlaceHolderID="PageContent" runat="server">
     <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">
          <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"></table>
</td><td class="panelHeaderR"></td></tr><tr><td class="dBody"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ForgetSignInButton")) %><asp:panel id="SignOutCollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" style="width:100%;"><tr><td><div class="securityGraphicWrapper"><asp:Image runat="server" id="Image" alt="&lt;%# GetResourceValue(&quot;Txt:PageHeader&quot;, &quot;ePortalWFApproval&quot;) %>" imageurl="../Images/SignOutPageGraphic.jpg" style="border-width:0px;">		
	</asp:Image></div>
    </td><td class="securityForm"><table><tr><td><asp:Label runat="server" id="SignOutMessage" Text="&lt;%# GetResourceValue(&quot;Txt:SuccessfullySignOut&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label><br /><br /></td></tr><tr><td align="center">&nbsp;</td></tr><tr><td align="center"><b><span style="font-size:10pt"><ePortalWFApproval:ThemeButton runat="server" id="SignInButton" button-causesvalidation="False" button-commandname="Redirect" button-height="20px" button-text="Sign In" button-tooltip="Sign In" button-width="40px" style="font-size:10px;"></ePortalWFApproval:ThemeButton></span></b></td></tr><tr><td align="center">&nbsp;</td></tr></table>
</td></tr></table></asp:panel>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ForgetSignInButton")) %></td></tr><tr><td class="panelB"></td></tr></table></div><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
        <div class="QDialog" id="dialog" style="display:none;">
          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
        </div>  
          <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
          