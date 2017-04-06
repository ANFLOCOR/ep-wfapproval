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
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dhtr" valign="middle" style="font-weight:bold;font-size:12pt;font-family:Tahoma;color:#016106"><asp:Literal runat="server" id="Sel_WPO_WFTaskTitle" Text="Purchase Order Approval (North)">	</asp:Literal></td></tr></table>
</td><td class="dher" style="display:none;"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="dh"></td><td class="dh"></td><td class="dh"></td><td class="dh"></td><td class="dh"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td><asp:literal id="Literal3" runat="server" text="&nbsp" /></td><td></td><td class="dh"></td><td class="dh"></td><td class="dh"></td><td class="dh"></td><td class="dh"></td></tr><tr><td class="dh" style="text-align:right;"><asp:literal id="Literal5" runat="server" text="&nbsp" /></td><td style="text-align:left;"><ePortalWFApproval:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Back to Tasks&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Back to Tasks&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td><td style="text-align:left;"></td><td class="dh" style="text-align:left;"></td><td class="dh" style="text-align:left;"></td><td class="dh" style="text-align:left;"></td><td class="dh" style="text-align:left;"></td><td class="dh" style="text-align:left;"></td></tr><tr><td class="panelL"></td><td style="text-align:right;"><asp:literal id="Literal4" runat="server" text="&nbsp" /></td><td class="dh" style="text-align:right;"></td><td class="dh" style="text-align:right;"></td><td class="dh" style="text-align:right;"></td><td class="dh" style="text-align:right;"></td><td class="dh" style="text-align:right;"></td><td class="dh" style="text-align:right;"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="Sel_WPO_WFTaskRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Sel_WPO_WFTaskRecordControlPanel" runat="server"><table><tr><td class="fls"></td><td class="fls" style="text-align:left;" colspan="5"><asp:literal id="Literal8" runat="server" text="&nbsp" /></td><td class="fls" style="text-align:left;"></td></tr><tr><td class="fls"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="CompanyIDLabel" Text="Company">	</asp:Literal></td><td style="color:Black;font-family:Tahoma;text-align:left;"><span style="white-space:nowrap;">
<asp:Label runat="server" id="CompanyID"></asp:Label></span>
 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CompanyID2" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<asp:RequiredFieldValidator runat="server" id="CompanyID2RequiredFieldValidator" ControlToValidate="CompanyID2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Company&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CompanyID2TextBoxMaxLengthValidator" ControlToValidate="CompanyID2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Company&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="dfv" style="white-space:nowrap;"><asp:literal id="Literal1" runat="server" text="&nbsp" /></td><td class="dfv" style="white-space:nowrap;text-align:right;" rowspan="6" colspan="2"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<ePortalWFApproval:WPOP10100RecordControl runat="server" id="WPOP10100RecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="WPOP10100RecordControlPanelExtender" runat="server" TargetControlid="WPOP10100RecordControlCollapsibleRegion" ExpandControlID="WPOP10100RecordControlIcon" CollapseControlID="WPOP10100RecordControlIcon" ImageControlID="WPOP10100RecordControlIcon" ExpandedImage="~/images/icon_panelcollapse.gif" CollapsedImage="~/images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="WPOP10100RecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="~/images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dhtr" valign="middle"><asp:Literal runat="server" id="WPOP10100Title" Text="WORKFLOW TASK">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td>
                  <asp:panel id="WPOP10100RecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="WPOP10100RecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="fls"></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="WPOP_StatusLabel" Text="Status">	</asp:Literal></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOP_Status"></asp:Literal></span>
</td><td class="fls"></td><td class="fls"></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"><asp:literal id="Literal6" runat="server" text="&nbsp" /></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="WPOP_DT_IDLabel" Text="Workflow">	</asp:Literal></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOP_DT_ID"></asp:Literal></span>
</td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WPOP_DT_ID1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td><td class="fls"></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="WPOP_RemarkLabel" Text="Remark(s)">	</asp:Literal></td><td class="fls" style="white-space:nowrap;text-align:left;font-family:Tahoma;" colspan="2"><asp:TextBox runat="server" id="WPOP_Remark" MaxLength="1073741823" columns="0" cssclass="field_input" height="50px" rows="3" textmode="MultiLine" width="360px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPOP_RemarkTextBoxMaxLengthValidator" ControlToValidate="WPOP_Remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPOP Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;" colspan="6">&nbsp;</td></tr><tr><td class="fls"></td><td class="fls" style="text-align:center;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WPOP_U_ID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
<asp:Button runat="server" id="btnApprove" causesvalidation="True" commandname="Redirect" consumers="page" text="&lt;%# GetResourceValue(&quot;Approve&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Approve&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:Button></td><td class="dfv" style="white-space:nowrap;text-align:center;"><asp:Button runat="server" id="btnReturn" causesvalidation="False" commandname="Redirect" consumers="page" text="Return">		
	</asp:Button></td><td class="dfv" style="white-space:nowrap;text-align:center;"><asp:Button CommandName="Redirect" runat="server" id="btnReject" causesvalidation="false" text="&lt;%# GetResourceValue(&quot;Reject&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Reject&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:Button></td><td class="dfv" style="white-space:nowrap;text-align:left;"><asp:dropdownlist id="ddlMoveTo" runat="server" class="fls" width="238px" Name="ddlMoveTo">
	
</asp:dropdownlist></td><td class="fls"></td><td class="fls"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPOP10100RecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPOP10100RecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td><td class="dfv" style="white-space:nowrap;text-align:right;"><asp:literal id="Literal7" runat="server" text="&nbsp" /></td></tr><tr><td class="fls"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="DOCDATELabel" Text="Doc. Date">	</asp:Literal></td><td style="white-space:nowrap;text-align:left;"><span style="white-space:nowrap;">
<asp:Label runat="server" id="DOCDATE"></asp:Label></span>
</td><td style="color:Black;font-family:Tahoma;text-align:left;"></td><td class="dfv" style="white-space:nowrap;text-align:right;"></td></tr><tr><td class="fls" style="text-align:left;"><asp:literal id="Literal2" runat="server" text="&nbsp" /></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="PONUMBERLabel" Text="PO Number">	</asp:Literal></td><td style="white-space:nowrap;text-align:left;"><asp:Label runat="server" id="PONUMBER"></asp:Label></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="VENDNAMELabel" Text="Vendor">	</asp:Literal></td><td style="white-space:nowrap;text-align:left;"><asp:Label runat="server" id="VENDNAME"></asp:Label></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="BUYERIDLabel" Text="Buyer">	</asp:Literal></td><td style="white-space:nowrap;text-align:left;"><asp:Label runat="server" id="BUYERID"></asp:Label></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="Literal13" Text="Payment Terms">	</asp:Literal></td><td style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="litPaymentTerms" Text="&amp;nbsp;">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;">&nbsp;</td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td><td class="fls" style="color:Black;font-family:Tahoma;text-align:left;text-decoration:underline;"><asp:Label runat="server" id="Label" Text="TOTALS" font-bold="True" font-underline="True">	</asp:Label></td><td class="dfv" style="white-space:nowrap;"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;border-width:0px 0px 0px 0px;border-style:solid;" rowspan="6" colspan="2"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<ePortalWFApproval:Sel_WPO_WFTaskActivity_RemarksRecordControl runat="server" id="Sel_WPO_WFTaskActivity_RemarksRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="Sel_WPO_WFTaskActivity_RemarksRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Sel_WPO_WFTaskActivity_RemarksRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="WPO_RemarkLabel1" Text="Comment(s)">	</asp:Literal></td></tr><tr><td class="fls" style="text-align:left;white-space: normal;"><asp:TextBox runat="server" id="WPO_Remark1" MaxLength="1073741823" borderstyle="None" columns="60" cssclass="field_input" readonly="False" rows="5" textmode="MultiLine" wrap="True" style="white-space: inherit;"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPO_Remark1TextBoxMaxLengthValidator" ControlToValidate="WPO_Remark1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPO Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Sel_WPO_WFTaskActivity_RemarksRecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_WFTaskActivity_RemarksRecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td><td class="dfv" style="white-space:nowrap;"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="SUBTOTALLabel" Text="Sub Total">	</asp:Literal></td><td style="white-space:nowrap;text-align:right;"><span style="white-space:nowrap;">
<asp:Label runat="server" id="SUBTOTAL1"></asp:Label></span>
</td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="TRDISAMTLabel" Text="Trade Disc.">	</asp:Literal></td><td style="white-space:nowrap;text-align:right;"><span style="white-space:nowrap;">
<asp:Label runat="server" id="TRDISAMT"></asp:Label></span>
</td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="FRTAMNTLabel" Text="Freight">	</asp:Literal></td><td style="white-space:nowrap;text-align:right;"><span style="white-space:nowrap;">
<asp:Label runat="server" id="FRTAMNT1"></asp:Label></span>
</td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="TAXAMNTLabel" Text="Tax">	</asp:Literal></td><td style="white-space:nowrap;text-align:right;"><span style="white-space:nowrap;">
<asp:Label runat="server" id="TAXAMNT"></asp:Label></span>
</td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="MSCCHAMTLabel" Text="Misc">	</asp:Literal></td><td style="white-space:nowrap;text-align:right;"><span style="white-space:nowrap;">
<asp:Label runat="server" id="MSCCHAMT"></asp:Label></span>
</td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td><td class="fls" style="white-space:nowrap;text-align:left;"><asp:Literal runat="server" id="TOTALLabel" Text="Total">	</asp:Literal></td><td style="white-space:nowrap;text-align:right;"><span style="white-space:nowrap;">
<asp:Label runat="server" id="TOTAL"></asp:Label></span>
</td><td class="dfv" style="white-space:nowrap;"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td class="panelL"></td><td colspan="7">&nbsp;</td></tr><tr><td class="panelL"></td><td class="fls" colspan="7" style="text-align:left;"><BaseClasses:TabContainer runat="server" id="PODetailsContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="PODetailsPanel" HeaderText="PO Details">	<ContentTemplate> 
  <ePortalWFApproval:Sel_WPO_InquireDetailsTableControl runat="server" id="Sel_WPO_InquireDetailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="Sel_WPO_InquireDetailsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"></td></tr><tr><td class="tre">
                    <table id="Sel_WPO_InquireDetailsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="LineNumberLabel" Text="Line No">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="ITEMNMBRLabel" Text="Item No">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="ITEMDESCLabel" Text="Item Description">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="UOFMLabel" Text="UOM">	</asp:Literal></th><th class="thc" style="text-align:right;"><asp:Literal runat="server" id="QTYORDERLabel" Text="Qty Order">	</asp:Literal></th><th class="thc" style="text-align:right;"><asp:Literal runat="server" id="UNITCOSTLabel" Text="Unit Cost">	</asp:Literal></th><th class="thc" style="text-align:right;"><asp:Literal runat="server" id="EXTDCOSTLabel" Text="Total">	</asp:Literal></th><th class="thc" style="text-align:left;" scope="col" id="selInqDet2Header" runat="server"><asp:Literal runat="server" id="UNITCOSTLabel2" Text="Cost History">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="REQSTDBYLabel" Text="Currency Remarks">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="COMMENTSLabel" Text="Comment">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WCur_ShortLabel" Text="Currency">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPOFR_RateLabel" Text="Forex Rate">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="ExtCostForexLabel" Text="Cost In Forex">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WPO_InquireDetailsTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WPO_InquireDetailsTableControlRow runat="server" id="Sel_WPO_InquireDetailsTableControlRow">
<tr><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LineNumber"></asp:Literal></span>
<asp:ImageButton runat="server" id="iComment" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconClear.gif" tooltip="&lt;%# GetResourceValue(&quot;Line Item Comment&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="ITEMNMBR"></asp:Literal> 
<asp:Literal runat="server" id="PONUMBER1" visible="False"></asp:Literal></td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="ITEMDESC"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="CompanyID1" visible="False"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="UOFM"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="ORD" visible="False"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="QTYORDER"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UNITCOST"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EXTDCOST"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;width:170px;" id="selInqDet2Cell" runat="server"><ePortalWFApproval:Sel_WPO_InquireDetails1TableControl1 runat="server" id="Sel_WPO_InquireDetails1TableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="Sel_WPO_InquireDetailsTableControl1CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Sel_WPO_InquireDetails1TableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="Sel_WPO_InquireDetails1TableControl1Repeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WPO_InquireDetails1TableControl1Row runat="server" id="Sel_WPO_InquireDetails1TableControl1Row">
<tr><td class="ttc"><asp:Literal runat="server" id="Literal9" Text="Unit Cost">	</asp:Literal></td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UNITCOST1"></asp:Literal></span>
</td></tr><tr><td class="ttc"><asp:Literal runat="server" id="Literal10" Text="Vendor">	</asp:Literal></td><td class="ttc" style="text-align:right;"><asp:Literal runat="server" id="VENDNAME1"></asp:Literal></td></tr><tr><td class="ttc"><asp:Literal runat="server" id="Literal11" Text="PO No">	</asp:Literal></td><td class="ttc" style="text-align:right;"><asp:Literal runat="server" id="PONUMBER2"></asp:Literal></td></tr></ePortalWFApproval:Sel_WPO_InquireDetails1TableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Sel_WPO_InquireDetails1TableControl1_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_InquireDetails1TableControl1>
</td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="REQSTDBY"></asp:Literal> </td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="COMMENTS"></asp:Literal></td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="WCur_Short"></asp:Literal></td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOFR_Rate"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ExtCostForex"></asp:Literal></span>
</td></tr><tr><td style="font-family:Tahoma;text-align:left;color:#7D7DFF;font-weight:bold;" class="ttc" colspan="2"><asp:Literal runat="server" id="Literal" Text="Addt&#39;l Comment">	</asp:Literal></td><td class="ttc" colspan="11" style="text-align:left;"><asp:Literal runat="server" id="COMMENT_4"></asp:Literal></td></tr></ePortalWFApproval:Sel_WPO_InquireDetailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
<tr summary="Footer"><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td class="ttc">Sub Total</td><td class="ttc" style="text-align:right;"><asp:Label runat="server" id="EXTDCOSTPageTotal">	</asp:Label></td><td style="border-width:0px 0px 1px 0px;border-style:solid" colspan="6" class="ttc">&nbsp; 
&nbsp; 
<asp:Literal runat="server" id="Literal12" Text="&amp;nbsp;">	</asp:Literal></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="Sel_WPO_InquireDetailsTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_InquireDetailsTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="ApprovalHistory" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WPO_WFHistory_Details_newTableControl runat="server" id="WPO_WFHistory_Details_newTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WPO_WFHistory_Details_newTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"></td></tr><tr><td class="tre"><table id="WPO_WFHistory_Details_newTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WPO_W_U_IDLabel" Text="User(Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_WS_IDLabel" Text="Type">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_Date_AssignLabel" Text="Date Assigned">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPO_RemarkLabel" Text="Remark(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_WFHistory_Details_newTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_WFHistory_Details_newTableControlRow runat="server" id="WPO_WFHistory_Details_newTableControlRow">
<tr><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_W_U_ID"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WS_ID"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Status"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Assign"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Action"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPO_Remark"></asp:Literal></td></tr></ePortalWFApproval:WPO_WFHistory_Details_newTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_WFHistory_Details_newTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_WFHistory_Details_newTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="PRDocPanel" HeaderText="PR Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_PRNo_QDetailsTableControl runat="server" id="WPO_PRNo_QDetailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WPO_PRNo_QDetailsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"></td></tr><tr><td class="tre"><table id="WPO_PRNo_QDetailsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="PRNoLabel" Text="PR No">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPRD_CreatedLabel" Text="Date Created">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPRD_TitleLabel" Text="Title">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPRD_TotalLabel" Text="Total">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="CommentLabel" Text="Comment(s)">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_PRNo_QDetailsTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_PRNo_QDetailsTableControlRow runat="server" id="WPO_PRNo_QDetailsTableControlRow">
<tr><td class="ttc" style="text-align:left;"><asp:ImageButton runat="server" id="ImageButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-view.png" onmouseout="this.src=&#39;../Images/icon-view.png&#39;" onmouseover="this.src=&#39;../Images/icon-view-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="PRNo"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_ID" visible="False"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_Created"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="WPRD_Title"></asp:Literal></td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_Total"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;"><asp:Literal runat="server" id="Comment"></asp:Literal></td></tr></ePortalWFApproval:WPO_PRNo_QDetailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_PRNo_QDetailsTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_PRNo_QDetailsTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="CARDocPanel" HeaderText="CAR Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_CARNo_QDetailsTableControl runat="server" id="WPO_CARNo_QDetailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WPO_CARNo_QDetailsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"></td></tr><tr><td class="tre"><table id="WPO_CARNo_QDetailsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="WCD_NoLabel" Text="CAR No">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Title">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="Total">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCD_RemarkLabel" Text="Remark(s)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="PRNumLabel" Text="Reference PR">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_CARNo_QDetailsTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_CARNo_QDetailsTableControlRow runat="server" id="WPO_CARNo_QDetailsTableControlRow">
<tr><td class="ttc"><asp:ImageButton runat="server" id="ImageButton1" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><asp:Literal runat="server" id="WCD_No"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="CARID"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal></td><td class="ttc" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WCD_Remark"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="PRNum"></asp:Literal></td></tr></ePortalWFApproval:WPO_CARNo_QDetailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_CARNo_QDetailsTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_CARNo_QDetailsTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="CanvassPanel" HeaderText="Canvass Documents">	<ContentTemplate> 
  <ePortalWFApproval:View_WCPO_Canvass1TableControl runat="server" id="View_WCPO_Canvass1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="View_WCPO_Canvass1TableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"></td></tr><tr><td class="tre">
                    <table id="View_WCPO_Canvass1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc"><asp:Literal runat="server" id="PRIDLabel" Text="PR No">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="CanvassDateLabel" Text="Canvass Date">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCI_SubmitLabel" Text="Submit">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCI_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="BuyerLabel" Text="Buyer">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="ClassificationLabel" Text="Classification">	</asp:Literal></th></tr><asp:Repeater runat="server" id="View_WCPO_Canvass1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:View_WCPO_Canvass1TableControlRow runat="server" id="View_WCPO_Canvass1TableControlRow">
<tr><td class="ttc"><asp:ImageButton runat="server" id="ImageButton2" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-view.png" onmouseout="this.src=&#39;../Images/icon-view.png&#39;" onmouseover="this.src=&#39;../Images/icon-view-over.png&#39;">		
	</asp:ImageButton></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PRID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCI_ID" visible="False"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CanvassDate"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WCI_Submit"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="WCI_Status"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Buyer"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Classification"></asp:Literal></span>
</td></tr></ePortalWFApproval:View_WCPO_Canvass1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="View_WCPO_Canvass1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:View_WCPO_Canvass1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPO_DocAttachPanel" HeaderText="PO Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_Doc_AttachTableControl runat="server" id="WPO_Doc_AttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="WPO_Doc_AttachTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"></td></tr><tr><td class="tre"><table id="WPO_Doc_AttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WPODA_DescLabel" Text="File Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPODA_FileLabel" Text="File Open">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_Doc_AttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_Doc_AttachTableControlRow runat="server" id="WPO_Doc_AttachTableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="WPODA_Desc"></asp:Literal></td><td class="tableCellValue"><asp:LinkButton runat="server" id="WPODA_File" CommandName="Redirect"></asp:LinkButton></td></tr></ePortalWFApproval:WPO_Doc_AttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPO_Doc_AttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_Doc_AttachTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr></table>
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
                