﻿<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="SignIn.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.SignIn" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<asp:Content id="Content" ContentPlaceHolderID="PageContent" runat="server">
     <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">
          <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"></table>
</td><td class="panelHeaderR"></td></tr><tr><td class="dBody"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton")) %><asp:panel id="SignInCollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td rowspan="2"><div class="securityGraphicWrapper"><asp:Image runat="server" id="Image" alt="&lt;%# GetResourceValue(&quot;Txt:PageHeader&quot;, &quot;ePortalWFApproval&quot;) %>" imageurl="../Images/SignInPageGraphic.jpg" style="border-width:0px;">		
	</asp:Image></div>
        </td><td class="securityForm"><table cellpadding="1" cellspacing="1" border="0"><tr><td style="height: 5px;" colspan="2"></td></tr><tr><td colspan="2"><asp:Label runat="server" id="LoginMessage">	</asp:Label></td></tr><tr><td style="height: 5px;"></td><td style="height: 5px;"></td></tr><tr><td class="fl" colspan="2"><asp:Label runat="server" id="UserNameLabel" Text="&lt;%# GetResourceValue(&quot;Txt:UserName&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td></tr><tr><td colspan="2"><asp:TextBox runat="server" id="UserName" columns="36" commandname="TextBoxUserName_Command" cssclass="field_input">	</asp:TextBox>
	<asp:RequiredFieldValidator runat="server" id="UserNameRequiredFieldValidator" ControlToValidate="UserName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;UserName&quot;) %>" display="None" enabled="True">	</asp:RequiredFieldValidator></td></tr><tr><td class="fl" colspan="2"><asp:Label runat="server" id="PasswordLabel" Text="&lt;%# GetResourceValue(&quot;Txt:Password&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td></tr><tr><td colspan="2"><asp:TextBox runat="server" id="Password" columns="36" commandname="TextBoxPassword_Command" cssclass="field_input" textmode="Password">	</asp:TextBox>
	<asp:RequiredFieldValidator runat="server" id="PasswordRequiredFieldValidator" ControlToValidate="Password" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Password&quot;) %>" display="None" enabled="True">	</asp:RequiredFieldValidator></td></tr><tr><td class="tableCellSelectCheckbox"><asp:CheckBox runat="server" id="RememberUserName" commandname="CheckBoxUN_Command" postback="True">	</asp:CheckBox></td><td class="fl"><asp:Label runat="server" id="RememberUserNameLabel" Text="&lt;%# GetResourceValue(&quot;Txt:RememberUN&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td></tr><tr><td class="tableCellSelectCheckbox"></td><td class="fl"></td></tr><tr><td class="tableCellSelectCheckbox"></td><td class="fl"></td></tr><tr><td style="height: 5px;"></td><td style="text-align: center;"></td></tr><tr><td colspan="2" style="text-align: center;"><asp:LinkButton runat="server" id="EmailLinkButton" causesvalidation="False" commandname="ForgotUser" consumers="page" text="&lt;%# GetResourceValue(&quot;Txt:ForgotPassword&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:LinkButton></td></tr><tr><td colspan="2"><asp:Label runat="server" id="PasswordMessage">	</asp:Label></td></tr></table>
</td></tr><tr><td><table cellpadding="0" cellspacing="0" border="0" style="padding-top:10px; padding-bottom:5px;" align="center"><tr><td>&nbsp;</td><td>&nbsp;</td><td><ePortalWFApproval:ThemeButton runat="server" id="OKButton" button-causesvalidation="True" button-commandname="Login" button-height="20px" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;ePortalWFApproval&quot;) %>" button-width="40px"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr></table></asp:panel>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton")) %></td></tr></table></div><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <div class="QDialog" id="dialog" style="display:none;">
    <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
    </div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
    </asp:Content>
    