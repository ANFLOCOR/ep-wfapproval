<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="WPO-WFTaskN.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.WPO_WFTaskN" %>
<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.WPO_WFTaskN" %>

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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<ePortalWFApproval:Sel_WPO_WFTaskRecordControl runat="server" id="Sel_WPO_WFTaskRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Sel_WPO_WFTaskRecordControlPanelExtender" runat="server" TargetControlid="Sel_WPO_WFTaskRecordControlCollapsibleRegion" ExpandControlID="Sel_WPO_WFTaskRecordControlIcon" CollapseControlID="Sel_WPO_WFTaskRecordControlIcon" ImageControlID="Sel_WPO_WFTaskRecordControlIcon" ExpandedImage="~/images/icon_panelcollapse.gif" CollapsedImage="~/images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Sel_WPO_WFTaskRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="~/images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dhtr" valign="middle"><asp:Literal runat="server" id="Sel_WPO_WFTaskTitle" Text="PO Workflow Task (North)">	</asp:Literal></td></tr></table>
</td><td class="dhb" style="display:none;"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc" style="text-align:right">
            
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher" style="display:none;"><img src="../Images/space.gif" alt="" /></td><td style="display:none;">
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="POSTATUSLabel1" Text="PO Status">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<asp:TextBox runat="server" id="POSTATUSFromFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox>
                        <span class="rft"><%# GetResourceValue("Txt:To", "ePortalWFApproval") %></span>
                        <asp:TextBox runat="server" id="POSTATUSToFilter" columns="15" cssclass="Filter_Input">	</asp:TextBox>
                    <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"><ePortalWFApproval:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher" style="display:none;"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td class="panelL"></td><td class="dh"><asp:literal id="Literal3" runat="server" text="&nbsp" /></td></tr><tr><td class="dh" style="text-align:right;"><asp:literal id="Literal5" runat="server" text="&nbsp" /></td><td class="dh" style="text-align:left;"><ePortalWFApproval:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Back to Tasks&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Back to Tasks&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td></tr><tr><td class="panelL"></td><td class="dh" style="text-align:right;"><asp:literal id="Literal4" runat="server" text="&nbsp" /></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="Sel_WPO_WFTaskNRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Sel_WPO_WFTaskRecordControlPanel" runat="server"><table><tr><td class="fls"></td><td class="fls" style="text-align:left;" colspan="5"><asp:literal id="Literal8" runat="server" text="&nbsp" /></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="CompanyIDLabel" Text="Company">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><BaseClasses:QuickSelector runat="server" id="CompanyID" redirecturl=""></BaseClasses:QuickSelector> 
<BaseClasses:QuickSelector runat="server" id="CompanyID1" redirecturl=""></BaseClasses:QuickSelector></td><td class="dfv" style="white-space:nowrap;"><asp:literal id="Literal1" runat="server" text="&nbsp" /></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="DOCDATELabel" Text="Document Date">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="DOCDATE" Columns="20" MaxLength="30" cssclass="field_input"></asp:TextBox></td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="DOCDATECalendarExtender" TargetControlID="DOCDATE" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<asp:RequiredFieldValidator runat="server" id="DOCDATERequiredFieldValidator" ControlToValidate="DOCDATE" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Date&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="DOCDATETextBoxMaxLengthValidator" ControlToValidate="DOCDATE" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Document Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls" style="text-align:left;"><asp:literal id="Literal2" runat="server" text="&nbsp" /></td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="PONUMBERLabel" Text="PO Number">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="PONUMBER" Columns="17" MaxLength="17" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="PONUMBERRequiredFieldValidator" ControlToValidate="PONUMBER" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;PO Number&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="PONUMBERTextBoxMaxLengthValidator" ControlToValidate="PONUMBER" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;PO Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="VENDNAMELabel" Text="Vend Name">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="VENDNAME" Columns="40" MaxLength="65" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="VENDNAMERequiredFieldValidator" ControlToValidate="VENDNAME" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Vend Name&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="VENDNAMETextBoxMaxLengthValidator" ControlToValidate="VENDNAME" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Vend Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="BUYERIDLabel" Text="Buyer">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="BUYERID" Columns="15" MaxLength="15" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="BUYERIDRequiredFieldValidator" ControlToValidate="BUYERID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Buyer&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BUYERIDTextBoxMaxLengthValidator" ControlToValidate="BUYERID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Buyer&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="Literal13" Text="Payment Terms">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:Literal runat="server" id="litPaymentTerms" Text="&amp;nbsp;">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;">&nbsp;</td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Sel_WPO_WFTaskRecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_WFTaskRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
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
                