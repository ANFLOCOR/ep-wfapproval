﻿<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="rpt-PO-Pipeline1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.rpt_PO_Pipeline1" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td class="dfv"><ePortalWFApproval:ThemeButton runat="server" id="btnBack" button-causesvalidation="False" button-commandname="Redirect" button-text="Back to Dashboard" button-tooltip="Back to Dashboard"></ePortalWFApproval:ThemeButton></td></tr><tr><td class="dfv"><b><span style="font-size:14pt"><asp:literal id="Literal1" runat="server" text="PO Approver Pipeline (North)"></asp:literal></span></b></td></tr><tr><td style="white-space:nowrap; width: 100%" class="thcnb"><iframe id="frm" runat="server" width="1000" height="500" frameborder="0" vspace="0" hspace="0" marginwidth="0" marginheight="0" scrolling="auto" noresize=""></iframe></td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                