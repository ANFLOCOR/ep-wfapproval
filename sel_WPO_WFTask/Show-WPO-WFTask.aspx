<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationMedium" Src="../Shared/PaginationMedium.ascx" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_WPO_WFTask" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-WPO-WFTask.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_WPO_WFTask" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dhtr" valign="middle" style="font-weight:bold;font-size:12pt;font-family:Tahoma;color:#016106">
                        <asp:Literal runat="server" id="Sel_WPO_WFTaskTitle" Text="PO Approval - View Page (South)">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td><td class="panelHeaderR"></td><td class="panelHeaderR"></td><td class="panelHeaderR"></td><td class="panelHeaderR"></td><td class="panelHeaderR"></td></tr><tr><td></td><td><asp:literal id="Literal3" runat="server" text="&nbsp" /></td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td style="text-align:right;"><asp:literal id="Literal5" runat="server" text="&nbsp" /></td><td style="text-align:left;"><ePortalWFApproval:ThemeButton runat="server" id="Button" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Back to Tasks&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Back to Tasks&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td></td><td style="text-align:right;"><asp:literal id="Literal4" runat="server" text="&nbsp" /></td><td></td><td></td><td></td><td></td><td></td><td></td></tr><tr><td class="panelBL"></td><td>
                  <asp:panel id="Sel_WPO_WFTaskRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="Sel_WPO_WFTaskRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="fls"></td><td class="fls"><asp:Literal runat="server" id="Literal30">	</asp:Literal></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px"></td><td class="fls" style="white-space:nowrap;text-align:right;"></td><td class="fls" style="white-space:nowrap;text-align:right;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px"></td><td class="fls" style="white-space:nowrap;text-align:right;"></td><td class="fls" style="white-space:nowrap;text-align:right;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="CompanyIDLabel" Text="Company">	</asp:Literal></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"><b><span style="font-family:Tahoma;font-size:10pt"><span style="white-space:nowrap;">
<asp:Label runat="server" id="CompanyID"></asp:Label></span>
 <span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="CompanyID2" Columns="14" MaxLength="14" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CompanyID2TextBoxMaxLengthValidator" ControlToValidate="CompanyID2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Company&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</span></b></td><td class="fls" rowspan="9" colspan="2" style="white-space:nowrap;text-align:right;"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<ePortalWFApproval:WPOP10100RecordControl runat="server" id="WPOP10100RecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"></td><td class="dhb"><asp:CollapsiblePanelExtender id="WPOP10100RecordControlPanelExtender" runat="server" TargetControlid="WPOP10100RecordControlCollapsibleRegion" ExpandControlID="WPOP10100RecordControlIcon" CollapseControlID="WPOP10100RecordControlIcon" ImageControlID="WPOP10100RecordControlIcon" ExpandedImage="~/images/icon_panelcollapse.gif" CollapsedImage="~/images/icon_panelexpand.gif" SuppressPostBack="true" /><asp:ImageButton id="WPOP10100RecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="~/images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="WPOP10100Title" Text="WORKFLOW TASK">	</asp:Literal></td></tr></table>
</td></tr></table>
</td><td class="panelT"></td></tr><tr><td class="panelHeaderL"><asp:panel id="WPOP10100RecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="WPOP10100RecordControlPanel" runat="server"><table cellpadding="1" cellspacing="1" border="0" width="100%"><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPOP_StatusLabel" Text="Status">	</asp:Literal></td><td class="fls" style="padding-left:3px;"></td><td class="fls" style="color:Black;font-family:Tahoma;text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOP_Status"></asp:Literal></span>
 </td><td class="fls"><asp:literal id="litStatus" runat="server" visible="False" /></td></tr><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPOP_DT_IDLabel" Text="Workflow">	</asp:Literal></td><td class="fls" style="padding-left:3px;"></td><td class="fls" style="color:Black;font-family:Tahoma;text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOP_DT_ID"></asp:Literal></span>
 </td><td class="fls"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WPOP_DT_ID1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" visible="False"></asp:DropDownList></span>
</td></tr><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPOP_RemarkLabel" Text="Remark(s)">	</asp:Literal></td><td class="fls"></td><td class="fls" style="color:Black;font-family:Tahoma;text-align:left;"><asp:TextBox runat="server" id="WPOP_Remark" MaxLength="500" borderstyle="NotSet" columns="60" cssclass="field_input" htmlencodevalue="Default" readonly="False" rows="4" textformat="{0}" textmode="MultiLine" width="337px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPOP_RemarkTextBoxMaxLengthValidator" ControlToValidate="WPOP_Remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPOP Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls" style="color:Black;font-family:Tahoma"></td></tr><tr><td class="fls" style="display:none;"><asp:literal id="Literal12" runat="server" text="Action" /> 
</td><td class="fls" style="display:none;"></td><td class="fls" style="display:none;"><asp:dropdownlist id="ddlAction" runat="server" class="fls" width="337px" Name="ddlAction">
	<asp:listitem>Approve</asp:listitem>
	<asp:listitem>Reject</asp:listitem>
	<asp:listitem>Void</asp:listitem>
	<asp:listitem>Return</asp:listitem>
</asp:dropdownlist> 
<asp:literal id="Literal13" runat="server" text="&nbsp;" /></td><td class="fls"></td></tr><tr><td class="fls" style="display:none;"><asp:literal id="litMoveTo" runat="server" text="Return To" /><br /> 
</td><td class="fls" style="display:none;"></td><td class="fls" style="display:none;"><asp:dropdownlist id="ddlMoveto1" runat="server" class="fls" width="337px" enabled="false" Name="ddlMoveTo">
	
</asp:dropdownlist></td><td class="fls"></td></tr><tr><td class="fls"><asp:dropdownlist id="ddlMoveTo" runat="server" class="fls" width="238px" Name="ddlMoveTo" visible="False">
	
</asp:dropdownlist> 
<span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WPOP_U_ID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" viewstatemode="Inherit" visible="False"></asp:DropDownList></span>
 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WPOP_PONMBR" Columns="17" MaxLength="17" cssclass="field_input" visible="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPOP_PONMBRTextBoxMaxLengthValidator" ControlToValidate="WPOP_PONMBR" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Wpop Ponmbr&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="fls" style="text-align:left;"><asp:literal id="Literal6" runat="server" text="&nbsp" /> 
</td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOP_ID" visible="False"></asp:Literal></span>
</td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WPOP_C_ID" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPOP_C_IDTextBoxMaxLengthValidator" ControlToValidate="WPOP_C_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Wpop C&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td class="fls" style="white-space:nowrap;text-align:right;display:none;" colspan="3"><asp:Button runat="server" id="btnApprove" causesvalidation="True" commandname="Redirect" consumers="page" onclientclick="return confirm(&quot;Continue submission of this document? Press OK to confirm document submission or press Cancel to abort operation. Concerned approver or requester will be notified through email.&quot;);" text="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Approve&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:Button> 
<asp:Button runat="server" id="btnReturn" causesvalidation="false" commandname="Redirect" onclientclick="return confirm(&quot;Click OK to return PO. Concerned approver or requester will be notified through email.&quot;);" text="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Return&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:Button> 
<asp:Button CommandName="Redirect" runat="server" id="btnReject" causesvalidation="false" onclientclick="return confirm(&quot;Click OK to reject PO. Concerned approver or requester will be notified through email.&quot;);" text="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Reject&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False">		
	</asp:Button></td><td class="fls" style="white-space:nowrap;text-align:center;"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="WPOP10100RecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPOP10100RecordControl>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="DOCDATELabel" Text="Doc. Date">	</asp:Literal></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"><b><span style="font-family:Tahoma;font-size:10pt"><span style="white-space:nowrap;">
<asp:Label runat="server" id="DOCDATE"></asp:Label></span>
</span></b></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;font-weight:bold;"></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"></td></tr><tr><td class="fls" style="text-align:left;"><asp:literal id="Literal2" runat="server" text="&nbsp" /></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="PONUMBERLabel" Text="PO Number">	</asp:Literal></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"><b><span style="font-family:Tahoma;font-size:10pt"><asp:Label runat="server" id="PONUMBER"></asp:Label></span></b></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="VENDNAMELabel" Text="Vendor">	</asp:Literal></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"><b><span style="font-family:Tahoma;font-size:10pt"><asp:Label runat="server" id="VENDNAME"></asp:Label></span></b></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="BUYERIDLabel" Text="Buyer">	</asp:Literal></td><td class="fls" style="width:500px"></td><td class="fls" style="width:500px;text-align:left;"><b><span style="font-family:Tahoma;font-size:10pt"><asp:Label runat="server" id="BUYERID"></asp:Label></span></b></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;" colspan="3"><asp:Label runat="server" id="Label1" Text="TOTALS" font-bold="True" font-underline="True">	</asp:Label></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"></td><td class="fls" style="text-align:right;width:500px;"></td><td class="fls" style="text-align:right;width:500px;"></td><td class="fls" style="text-align:left;border-width:0px 0px 0px 0px;border-style:solid;"></td><td class="fls" style="text-align:left;border-width:0px 0px 0px 0px;border-style:solid;"></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="SUBTOTALLabel" Text="Sub Total">	</asp:Literal></td><td class="fls" style="text-align:right;width:500px;"></td><td class="fls" style="text-align:right;padding-right:20px;"><b><span style="font-family:Tahoma;font-size:9pt"><span style="white-space:nowrap;">
<asp:Label runat="server" id="SUBTOTAL"></asp:Label></span>
</span></b></td><td class="fls" rowspan="6" colspan="2" style="text-align:left;border-width:0px 0px 0px 0px;border-style:solid;"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<ePortalWFApproval:WPOP10100RecordControl1 runat="server" id="WPOP10100RecordControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="dh"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td></td><td><asp:panel id="WPOP10100RecordControl1CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="WPOP10100RecordControl1Panel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="fls" style="text-align:left;" colspan="3"><asp:Literal runat="server" id="WPOP_RemarkLabel1" Text="Buyer Comment(s)">	</asp:Literal></td></tr><tr><td class="fls" style="text-align:left;" rowspan="3" colspan="3"><asp:TextBox runat="server" id="WPOP_Remark1" MaxLength="500" borderstyle="None" columns="60" cssclass="field_input" htmlencodevalue="Default" readonly="True" rows="5" textformat="{0}" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPOP_Remark1TextBoxMaxLengthValidator" ControlToValidate="WPOP_Remark1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPOP Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel></td><td></td></tr></table>
	<asp:hiddenfield id="WPOP10100RecordControl1_PostbackTracker" runat="server" />
</ePortalWFApproval:WPOP10100RecordControl1>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="TRDISAMTLabel" Text="Trade Disc.">	</asp:Literal></td><td class="fls" style="text-align:right;font-family:Tahoma;font-size:8pt;width:500px;font-weight:bold;"></td><td class="fls" style="text-align:right;padding-right:20px;"><b><span style="font-family:Tahoma;font-size:9pt"><span style="white-space:nowrap;">
<asp:Label runat="server" id="TRDISAMT"></asp:Label></span>
</span></b></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="FRTAMNTLabel" Text="Freight">	</asp:Literal></td><td class="fls" style="text-align:right;width:500px;"></td><td class="fls" style="text-align:right;padding-right:20px;"><b><span style="font-family:Tahoma;font-size:9pt"><span style="white-space:nowrap;">
<asp:Label runat="server" id="FRTAMNT"></asp:Label></span>
</span></b></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="TAXAMNTLabel" Text="Tax">	</asp:Literal></td><td class="fls" style="text-align:right;width:500px;"></td><td class="fls" style="text-align:right;padding-right:20px;"><b><span style="font-family:Tahoma;font-size:9pt"><span style="white-space:nowrap;">
<asp:Label runat="server" id="TAXAMNT"></asp:Label></span>
</span></b></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="MSCCHAMTLabel" Text="Misc">	</asp:Literal></td><td class="fls" style="text-align:right;width:500px;"></td><td class="fls" style="text-align:right;padding-right:20px;"><b><span style="font-family:Tahoma;font-size:9pt"><span style="white-space:nowrap;">
<asp:Label runat="server" id="MSCCHAMT"></asp:Label></span>
</span></b></td></tr><tr><td class="fls"></td><td class="fls" style="text-align:left;font-weight:bold;"><asp:Literal runat="server" id="TOTALLabel" Text="Total">	</asp:Literal></td><td class="fls" style="text-align:right;width:500px;"></td><td class="fls" style="text-align:right;padding-right:20px;"><b><span style="font-family:Tahoma;font-size:9pt"><span style="white-space:nowrap;">
<asp:Label runat="server" id="TOTAL"></asp:Label></span>
</span></b></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelBR"></td><td class="panelBR"></td><td class="panelBR"></td><td class="panelBR"></td><td class="panelBR"></td><td class="panelBR"></td></tr><tr><td class="panelBL"></td><td colspan="7">&nbsp;</td></tr><tr><td class="panelBL"></td><td class="panelB"><BaseClasses:TabContainer runat="server" id="PODetailsContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="PODetailsPanel" HeaderText="PO Details">	<ContentTemplate> 
  <ePortalWFApproval:Sel_WPO_InquireDetailsTableControl runat="server" id="Sel_WPO_InquireDetailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="Sel_WPO_InquireDetailsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td><ePortalWFApproval:Pagination runat="server" id="Sel_WPO_InquireDetailsPagination"></ePortalWFApproval:Pagination></td></tr></table>
</td></tr><tr><td class="tre"><table id="Sel_WPO_InquireDetailsTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="LineNumberLabel" Text="Line No">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="ITEMNMBRLabel" Text="Item No">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="ITEMDESCLabel" Text="Item Description">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="UOFMLabel" Text="UOM">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="QTYORDERLabel" Text="Qty Order">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="UNITCOSTLabel" Text="Unit Cost">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="EXTDCOSTLabel" Text="Total">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="REQSTDBYLabel" Text="Currency Remarks">	</asp:Literal> 
</th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="COMMENTSLabel1" Text="Comment">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WCur_ShortLabel" Text="Currency">	</asp:Literal> 
</th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPOFR_RateLabel" Text="ForEx Rate">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPOFR_Unit_CostLabel" Text="Cost in ForEx">	</asp:Literal> 
</th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="UNITCOSTLabel1" Text="Prev. Price Info">	</asp:Literal></th></tr><asp:Repeater runat="server" id="Sel_WPO_InquireDetailsTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WPO_InquireDetailsTableControlRow runat="server" id="Sel_WPO_InquireDetailsTableControlRow">
<tr><td class="ttc" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="LineNumber"></asp:Literal></span>
<asp:ImageButton runat="server" id="iComment" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconClear.gif" visible="False">		
	</asp:ImageButton><ePortalWFApproval:ThemeButton runat="server" id="iComment1" button-causesvalidation="False" button-commandname="Redirect" button-text="Comment" button-tooltip="Comment" visible="False"></ePortalWFApproval:ThemeButton><ePortalWFApproval:ThemeButton runat="server" id="imbItemHistory" button-causesvalidation="False" button-commandname="Redirect" button-text="Item History" button-tooltip="Item History" visible="False"></ePortalWFApproval:ThemeButton></td><td class="ttc" style="font-weight:bold;"><asp:LinkButton runat="server" id="ITEMNMBR" CommandName="Redirect" forecolor="Blue" tooltip="Click to View Item History" visible="False"></asp:LinkButton><asp:Literal runat="server" id="ITEMNMBR1"></asp:Literal> 
<asp:Literal runat="server" id="PONUMBER1" visible="False"></asp:Literal></td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="ITEMDESC"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="CompanyID1" visible="False"></asp:Literal></span>
 
</td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="UOFM"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="ORD" visible="False"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="QTYORDER"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UNITCOST"></asp:Literal></span>
 </td><td class="ttc" style="text-align:right;font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="EXTDCOST"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="REQSTDBY"></asp:Literal></td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="COMMENTS1"></asp:Literal></td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="WCur_Short"></asp:Literal></td><td class="ttc" style="text-align:right;font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOFR_Rate"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPOFR_Unit_Cost"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;width:170px;font-weight:bold;" runat="server" id="selInqDet2Cell"><ePortalWFApproval:Sel_WPO_InquireDetails_2TableControl runat="server" id="Sel_WPO_InquireDetails_2TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td><asp:panel id="Sel_WPO_InquireDetails_2TableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Sel_WPO_InquireDetails_2TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="Sel_WPO_InquireDetails_2TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WPO_InquireDetails_2TableControlRow runat="server" id="Sel_WPO_InquireDetails_2TableControlRow">
<tr><td class="ttc" style="text-align:right;font-size:8pt;border-width:0px 0px 0px 0px;border-style:solid;font-style:italic;"><asp:Literal runat="server" id="Literal9" Text="Price">	</asp:Literal><br />
<br />
</td><td class="tableCellValue" colspan="5" style="text-align:right;"><span style="font-size:8pt;color:#BE0307"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UNITCOST1"></asp:Literal></span>
</span></td></tr><tr><td class="ttc" style="text-align:right;font-size:8pt;border-width:0px 0px 0px 0px;border-style:solid;font-style:italic;"><asp:Literal runat="server" id="Literal10" Text="Vendor">	</asp:Literal></td><td class="tableCellValue" colspan="5" style="text-align:right;"><span style="font-size:8pt;color:#BE0307"><asp:Literal runat="server" id="VENDNAME1"></asp:Literal></span></td></tr><tr><td class="ttc" style="text-align:right;font-size:8pt;border-width:0px 0px 0px 0px;border-style:solid;font-style:italic;"><asp:Literal runat="server" id="Literal11" Text="PO #">	</asp:Literal></td><td class="tableRowDivider" colspan="5" style="text-align:right;"><span style="font-size:8pt;color:#BE0307"><asp:Literal runat="server" id="PONUMBER2"></asp:Literal></span></td></tr><tr><td class="ttc" style="text-align:right;font-size:8pt;border-width:0px 0px 0px 0px;border-style:solid;font-style:italic;" colspan="6"><asp:TextBox runat="server" id="TextBox" borderstyle="None" readonly="True" width="250px">	</asp:TextBox></td></tr></ePortalWFApproval:Sel_WPO_InquireDetails_2TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td></td><td></td></tr></table>
	<asp:hiddenfield id="Sel_WPO_InquireDetails_2TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_InquireDetails_2TableControl>
</td></tr><tr><td class="ttc" colspan="2" style="text-align:left;"><asp:Literal runat="server" id="Literal" Text="Addt&#39;l Comment">	</asp:Literal></td><td class="ttc" colspan="10" style="font-weight:bold;"><asp:Literal runat="server" id="COMMENT_4"></asp:Literal></td><td class="ttc"></td></tr></ePortalWFApproval:Sel_WPO_InquireDetailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
<tr summary="Footer"><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td style="border-width:0px 0px 1px 0px;border-style:solid" class="ttc">&nbsp;</td><td style="border-width:0px 0px 1px 0px;border-style:solid;text-align:right;font-weight:bold;" class="ttc" colspan="2">Sub Total:</td><td class="ttc" style="text-align:right;border-width:0px 0px 1px 1px;border-style:solid;font-weight:bold;"><asp:Label runat="server" id="EXTDCOSTPageTotal">	</asp:Label></td><td class="ttc" style="border-width:0px 0px 1px 0px;border-style:solid">&nbsp;</td><td class="ttc" style="border-width:0px 0px 1px 0px;border-style:solid">&nbsp;</td><td class="ttc" style="border-width:0px 0px 1px 0px;border-style:solid;text-align:right;font-weight:bold;" colspan="2">Sub Total:</td><td style="border-width:0px 0px 1px 0px;border-style:solid;text-align:right;font-weight:bold;" class="ttc"><asp:Label runat="server" id="WPOFR_Unit_CostPageTotal">	</asp:Label></td><td class="ttc" style="border-width:0px 0px 1px 0px;border-style:solid">&nbsp;</td></tr></table>
</td></tr></table>
</asp:panel></td><td class="panelT"></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="Sel_WPO_InquireDetailsTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WPO_InquireDetailsTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="ApprovalHistory" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WPO_WFHistory_Details_newTableControl runat="server" id="WPO_WFHistory_Details_newTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="WPO_WFHistory_Details_newTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td></td><td></td><td></td><td></td><td><ePortalWFApproval:PaginationMedium runat="server" id="WPO_WFHistory_Details_newPagination"></ePortalWFApproval:PaginationMedium></td></tr></table>
</td></tr><tr><td class="tre"><table id="WPO_WFHistory_Details_newTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_W_U_IDLabel" Text="User (Assigned)">	</asp:Literal> 
</th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_WS_IDLabel" Text="Step">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPO_RemarkLabel" Text="Remark">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_WFHistory_Details_newTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_WFHistory_Details_newTableControlRow runat="server" id="WPO_WFHistory_Details_newTableControlRow">
<tr><td class="ttc" style="text-align:left;font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_W_U_ID"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_WS_ID"></asp:Literal></span>
</td><td class="ttc" style="text-align:left;font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Status"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Assign"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPO_Date_Action"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="WPO_Remark"></asp:Literal></td></tr></ePortalWFApproval:WPO_WFHistory_Details_newTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td><td class="panelT"></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="WPO_WFHistory_Details_newTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_WFHistory_Details_newTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="PRDocPanel" HeaderText="PR Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_PRNo_QDetailsTableControl runat="server" id="WPO_PRNo_QDetailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="WPO_PRNo_QDetailsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td><ePortalWFApproval:Pagination runat="server" id="WPO_PRNo_QDetailsPagination"></ePortalWFApproval:Pagination></td></tr></table>
</td></tr><tr><td class="tre"><table id="WPO_PRNo_QDetailsTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="PRNoLabel" Text="PR No">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPRD_CreatedLabel" Text="Date Created">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPRD_TitleLabel" Text="Title">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPRD_TotalLabel" Text="Total">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="CommentLabel" Text="Comment(s)">	</asp:Literal> 
</th></tr><asp:Repeater runat="server" id="WPO_PRNo_QDetailsTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_PRNo_QDetailsTableControlRow runat="server" id="WPO_PRNo_QDetailsTableControlRow">
<tr><td class="tableCellLabel"><asp:ImageButton runat="server" id="ImageButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="PRNo"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_ID" visible="False"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_Created"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="WPRD_Title"></asp:Literal></td><td class="ttc" style="text-align:right;font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_Total"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Comment" Columns="40" MaxLength="500" borderstyle="None" cssclass="field_input" htmlencodevalue="Default" readonly="True" textformat="{0}" width="250px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="CommentTextBoxMaxLengthValidator" ControlToValidate="Comment" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;Comment&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr></ePortalWFApproval:WPO_PRNo_QDetailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td><td class="panelT"></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="WPO_PRNo_QDetailsTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_PRNo_QDetailsTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="CARDocPanel" HeaderText="CAR Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_CARNo_QDetailsTableControl runat="server" id="WPO_CARNo_QDetailsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="WPO_CARNo_QDetailsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td><ePortalWFApproval:Pagination runat="server" id="WPO_CARNo_QDetailsPagination"></ePortalWFApproval:Pagination></td></tr></table>
</td></tr><tr><td class="tre"><table id="WPO_CARNo_QDetailsTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WCD_NoLabel" Text="CAR No">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Title">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="Total">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WCD_RemarkLabel" Text="Remark(s)">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="PRNumLabel" Text="PR Number">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_CARNo_QDetailsTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_CARNo_QDetailsTableControlRow runat="server" id="WPO_CARNo_QDetailsTableControlRow">
<tr><td class="tableCellLabel"><asp:ImageButton runat="server" id="ImageButton1" causesvalidation="False" commandname="Redirect" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open_over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="WCD_No"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="CARID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_ID" visible="False"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="WCD_Project_Title"></asp:Literal></td><td class="ttc" style="text-align:right;font-weight:bold;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_Exp_Total"></asp:Literal></span>
</td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="WCD_Remark"></asp:Literal></td><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="PRNum"></asp:Literal></td></tr></ePortalWFApproval:WPO_CARNo_QDetailsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td><td class="panelT"></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="WPO_CARNo_QDetailsTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_CARNo_QDetailsTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="CanvassPanel" HeaderText="Canvass Documents">	<ContentTemplate> 
  <ePortalWFApproval:View_WCPO_CanvassTableControl runat="server" id="View_WCPO_CanvassTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL">
                  <asp:panel id="View_WCPO_CanvassTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td></td><td></td><td></td><td></td><td><ePortalWFApproval:PaginationMedium runat="server" id="View_WCPO_CanvassPagination"></ePortalWFApproval:PaginationMedium></td></tr></table>
</td></tr><tr><td class="tre"><table id="View_WCPO_CanvassTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="PRIDLabel" Text="PR No.">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="CanvassDateLabel" Text="Canvass Date">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="VendorsLabel" Text="Vendor">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WCI_SubmitLabel" Text="Submit">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WCI_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="BuyerLabel" Text="Buyer">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="ClassificationLabel" Text="Classification">	</asp:Literal></th></tr><asp:Repeater runat="server" id="View_WCPO_CanvassTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:View_WCPO_CanvassTableControlRow runat="server" id="View_WCPO_CanvassTableControlRow">
<tr><td class="tableCellLabel"><asp:ImageButton runat="server" id="ImageButton2" causesvalidation="False" commandname="Custom" imageurl="../Images/icon-open.png" onmouseout="this.src=&#39;../Images/icon-open.png&#39;" onmouseover="this.src=&#39;../Images/icon-open-over.png&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="PRID"></asp:Literal></span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCI_ID" visible="False"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CanvassDate"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Vendors"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WCI_Submit"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="WCI_Status"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Buyer"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="Classification"></asp:Literal></span>
</td></tr></ePortalWFApproval:View_WCPO_CanvassTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr><tr><td></td></tr></table>
	<asp:hiddenfield id="View_WCPO_CanvassTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:View_WCPO_CanvassTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPO_Doc_AttachPanel1" HeaderText="PO Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPO_Doc_AttachTableControl runat="server" id="WPO_Doc_AttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="WPO_Doc_AttachTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td></td><td></td><td></td><td></td><td><ePortalWFApproval:PaginationMedium runat="server" id="WPO_Doc_AttachPagination"></ePortalWFApproval:PaginationMedium></td></tr></table>
</td></tr><tr><td class="tre"><table id="WPO_Doc_AttachTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPODA_DescLabel" Text="Description">	</asp:Literal></th><th class="thc" style="text-align:left;"><asp:Literal runat="server" id="WPODA_FileLabel" Text="File Open">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPO_Doc_AttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPO_Doc_AttachTableControlRow runat="server" id="WPO_Doc_AttachTableControlRow">
<tr><td class="ttc" style="font-weight:bold;"><asp:Literal runat="server" id="WPODA_Desc"></asp:Literal> 
<asp:Literal runat="server" id="WPODA_PONo" visible="False"></asp:Literal></td><td class="ttc"><asp:LinkButton runat="server" id="WPODA_File" CommandName="Redirect"></asp:LinkButton> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPODA_CMPNY" visible="False"></asp:Literal></span>
</td></tr></ePortalWFApproval:WPO_Doc_AttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr><tr><td></td></tr></table>
	<asp:hiddenfield id="WPO_Doc_AttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPO_Doc_AttachTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td><td class="panelBR"></td><td class="panelBR"></td><td class="panelBR"></td><td class="panelBR"></td><td class="panelBR"></td><td class="panelBR"></td></tr></table>
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
                