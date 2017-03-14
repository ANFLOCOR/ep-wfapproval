<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.test" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="test.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.test" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<ePortalWFApproval:WCAR_DocRecordControl1 runat="server" id="WCAR_DocRecordControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><span style="font-size:14pt"><b><asp:Literal runat="server" id="Title0" Text="Capital Appropriation Request (View)">	</asp:Literal></b></span></td><td class="dhir"></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td style="border-width:0px 0px 0px 0px;border-style:solid"> 
<table><tr><td></td><td></td><td></td></tr><tr><td><asp:Literal runat="server" id="Literal23" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td><ePortalWFApproval:ThemeButton runat="server" id="btnPrint" button-causesvalidation="False" button-commandname="Redirect" button-text="Print" button-tooltip="Print" visible="True"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="OKButton" button-causesvalidation="true" button-commandname="UpdateData" button-text="Done" button-tooltip="Done" postback="True"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="btnVoid" button-causesvalidation="False" button-commandname="Redirect" button-text="Void" button-tooltip="Void"></ePortalWFApproval:ThemeButton></td></tr><tr><td><asp:Literal runat="server" id="Literal22" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr></table>
</td></tr><tr><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="fls"></td><td class="fls"><asp:Literal runat="server" id="Literal2" Text="&amp;nbsp;">	</asp:Literal></td><td class="fls"></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls"></td><td class="fls"></td><td class="fls"></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_C_IDLabel" Text="Company">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCD_C_ID" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" width="279px"></asp:DropDownList></span>
</td><td rowspan="8" class="fls"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PanelExtender" runat="server" TargetControlid="BlankPanelWithHeaderCollapsibleRegion" ExpandControlID="Icon" CollapseControlID="Icon" ImageControlID="Icon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Icon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><b>Workflow</b></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td><asp:panel id="BlankPanelWithHeaderCollapsibleRegion" runat="server">
	<table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td style="width:75px"><asp:Literal runat="server" id="Literal28" Text="&amp;nbsp;">	</asp:Literal></td><td><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCD_WDT_ID" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" visible="False" width="337px"></asp:DropDownList></span>
</td></tr><tr><td style="text-align:left;width:75px;"><b><asp:Literal runat="server" id="WCD_StatusLabel" Text="Status">	</asp:Literal></b></td><td style="text-align:left;"><asp:Literal runat="server" id="WCD_Status"></asp:Literal></td></tr><tr><td style="text-align:left;width:75px;"><asp:Literal runat="server" id="Literal30" Text="&amp;nbsp;">	</asp:Literal></td><td></td></tr><tr><td style="text-align:left;width:75px;"><b><asp:Literal runat="server" id="WCD_WDT_IDLabel" Text="Workflow">	</asp:Literal></b></td><td style="text-align:left;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCD_WDT_ID1" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" width="337px"></asp:DropDownList></span>
</td></tr><tr><td style="text-align:left;"><asp:Literal runat="server" id="Literal35" Text="&amp;nbsp;">	</asp:Literal></td><td></td></tr><tr><td class="fls" style="text-align:left;width:75px;"><asp:literal id="Literal34" runat="server" text="Action" /> 
</td><td><asp:dropdownlist id="ddlAction" runat="server" class="fls" width="330px" style="margin-left:5px;" Name="ddlAction">
	<asp:listitem>Approve</asp:listitem>
	<asp:listitem>Reject</asp:listitem>
	<asp:listitem>Void</asp:listitem>
	<asp:listitem>Return</asp:listitem>
</asp:dropdownlist> 
<asp:literal id="Literal36" runat="server" text="&nbsp;" /></td></tr><tr><td class="fls" style="text-align:left;width:75px;"><asp:literal id="Literal37" runat="server" text="Return To" /><br /> 
</td><td class="dfv"><asp:dropdownlist id="ddlMoveto" runat="server" class="fls" width="330px" enabled="false" Name="ddlMoveTo">
	
</asp:dropdownlist></td></tr><tr><td class="fls" style="text-align:left;width:75px;"><asp:literal id="Literal38" runat="server" text="Remark" /></td><td class="dfv" style="text-align:left;"><asp:textbox id="txtRemark" runat="server" TextMode="MultiLine" Rows="2" Enabled="True" Width="320px" class="dfv" MaxLength="250" ForeColor="Black" /></td></tr><tr><td class="fls" style="text-align:left;width:75px;  word-wrap: break-word;"><asp:literal id="Literal39" runat="server" text="Approver(s)" />

</td><td rowspan="3"><asp:TextBox runat="server" id="TextBox" readonly="True" rows="4" textmode="MultiLine" width="324px">	</asp:TextBox></td></tr><tr><td class="fls" style="text-align:left;width:75px;  word-wrap: break-word;"><asp:literal id="Literal29" runat="server" text="Previous" /></td></tr><tr><td class="fls" style="text-align:left;width:75px;  word-wrap: break-word;"><asp:literal id="Literal31" runat="server" text="Remarks" /></td></tr><tr><td><asp:literal id="Literal40" runat="server" text="&nbsp;" /></td><td></td></tr><tr><td><ePortalWFApproval:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-redirectargument="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" postback="True" visible="False"></ePortalWFApproval:ThemeButton></td><td><asp:Button runat="server" id="btnSubmitAction" causesvalidation="False" commandname="Redirect" consumers="page" onclientclick="javascript:return confirm(&quot;Continue submission of this document with selected Action settings? Press OK to confirm document submission or press Cancel to abort operation.&quot;);" postback="False" redirectargument="UpdateData" text="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Submit Action&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:Button></td></tr><tr><td><asp:literal id="Literal41" runat="server" text="&nbsp;" /></td><td></td></tr></table>

                  </td></tr></table>

 </asp:panel>
               </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
 
</td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_NoLabel" Text="CAR No.">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_No" Columns="40" MaxLength="50" cssclass="field_input" enabled="False" htmlencodevalue="Default" textformat="{0}" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_NoTextBoxMaxLengthValidator" ControlToValidate="WCD_No" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Unit_LocationLabel" Text="Unit &amp; Location">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_Unit_Location" Columns="40" MaxLength="50" cssclass="field_input" enabled="False" htmlencodevalue="Default" textformat="{0}" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Unit_LocationTextBoxMaxLengthValidator" ControlToValidate="WCD_Unit_Location" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Unit Location&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="fls"><asp:Literal runat="server" id="Literal4" Text="&amp;nbsp;">	</asp:Literal></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Project_TitleLabel" Text="Project Description">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><asp:TextBox runat="server" id="WCD_Project_Title" Columns="40" MaxLength="2147483647" cssclass="field_input" enabled="False" htmlencodevalue="Default" rows="8" textformat="{0}" textmode="MultiLine" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Project_TitleTextBoxMaxLengthValidator" ControlToValidate="WCD_Project_Title" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Project Title&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="Literal18" Text="&amp;nbsp;">	</asp:Literal></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Project_NoLabel" Text="Project No.">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_Project_No" Columns="40" MaxLength="50" cssclass="field_input" enabled="False" htmlencodevalue="Default" textformat="{0}" width="279px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Project_NoTextBoxMaxLengthValidator" ControlToValidate="WCD_Project_No" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Project Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="fls" rowspan="9"><BaseClasses:TabContainer runat="server" id="WCAR_DocRecordControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Total Expenditure - This Request">	<ContentTemplate> 
 <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td></td><td><asp:Literal runat="server" id="Literal13" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr><tr><td></td><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_WCur_IDLabel" Text="Currency">	</asp:Literal></b></td><td><asp:Literal runat="server" id="Literal26" Text="&amp;nbsp;">	</asp:Literal></td><td><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCD_WCur_ID2" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" width="271px"></asp:DropDownList></span>
</td><td></td></tr><tr><td></td><td><asp:Literal runat="server" id="Literal27" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td><td></td></tr><tr><td></td><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Cur_YrLabel" Text="This Year">	</asp:Literal> 
<asp:Literal runat="server" id="WCD_WCur_ID1" visible="False"></asp:Literal></b></td><td><asp:Literal runat="server" id="Literal21" Text="&amp;nbsp;">	</asp:Literal></td><td style="text-align:right;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Cur_Yr" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" enabled="False" htmlencodevalue="Default" textformat="{0}" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Cur_YrTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Cur_Yr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration CUR Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td></td></tr><tr><td></td><td><asp:Literal runat="server" id="Literal15" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td><td></td></tr><tr><td><asp:Literal runat="server" id="Literal11" Text="&amp;nbsp;">	</asp:Literal></td><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Nxt_YrLabel" Text="Next Year">	</asp:Literal></b></td><td><asp:Literal runat="server" id="Literal17" Text="&amp;nbsp;">	</asp:Literal></td><td style="text-align:right;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Nxt_Yr" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" enabled="False" htmlencodevalue="Default" textformat="{0}" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Nxt_YrTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Nxt_Yr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Next Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td><asp:Literal runat="server" id="Literal14" Text="&amp;nbsp;">	</asp:Literal></td></tr><tr><td></td><td><asp:Literal runat="server" id="Literal16" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td><td></td></tr><tr><td></td><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Sub_YrLabel" Text="Subsequent Years">	</asp:Literal></b></td><td><asp:Literal runat="server" id="Literal20" Text="&amp;nbsp;">	</asp:Literal></td><td style="text-align:right;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Sub_Yr" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" enabled="False" htmlencodevalue="Default" textformat="{0}" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Sub_YrTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Sub_Yr" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Sub Year&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td></td></tr><tr><td></td><td><asp:Literal runat="server" id="Literal12" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td><td></td></tr><tr><td></td><td style="text-align:left;"><b><asp:Literal runat="server" id="Literal24" Text="Total">	</asp:Literal></b></td><td><asp:Literal runat="server" id="Literal25" Text="&amp;nbsp;">	</asp:Literal></td><td style="text-align:right;"><asp:Label runat="server" id="lblTotal1" Text="0" cssclass="txt-padding-right-lblTotal" width="268px">	</asp:Label></td><td></td></tr></table>

                  </td></tr></table>

 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Total Expenditure">	<ContentTemplate> 
  <table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td></td><td><asp:Literal runat="server" id="Literal3" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td></td><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_TotalLabel" Text="This Request">	</asp:Literal> 
<asp:Literal runat="server" id="WCD_WCur_ID" visible="False"></asp:Literal></b></td><td></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Total" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" enabled="False" htmlencodevalue="Default" textformat="{0}" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_TotalTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Total" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td></td><td><asp:Literal runat="server" id="Literal7" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td></td><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Prev_TotalLabel" Text="Previously Approved CAR">	</asp:Literal></b></td><td></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Prev_Total" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" enabled="False" htmlencodevalue="Default" textformat="{0}" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Prev_TotalTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Prev_Total" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Previous Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td><asp:Literal runat="server" id="Literal8" Text="&amp;nbsp;">	</asp:Literal></td><td><asp:Literal runat="server" id="Literal6" Text="&amp;nbsp;">	</asp:Literal></td><td><asp:Literal runat="server" id="Literal10" Text="&amp;nbsp;">	</asp:Literal></td><td></td></tr><tr><td></td><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_BudgetLabel" Text="Budgeted Amount">	</asp:Literal></b></td><td></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Budget" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" enabled="False" htmlencodevalue="Default" textformat="{0}" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_BudgetTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Budget" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Budget&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td></td><td><asp:Literal runat="server" id="Literal5" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr><tr><td></td><td style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Exp_Under_Over_BudgetLabel" Text="Over Budget">	</asp:Literal></b></td><td></td><td style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Exp_Under_Over_Budget" Columns="20" MaxLength="26" cssclass="field_input txtAlign-right" enabled="False" htmlencodevalue="Default" textformat="{0}" width="268px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Exp_Under_Over_BudgetTextBoxMaxLengthValidator" ControlToValidate="WCD_Exp_Under_Over_Budget" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Expiration Under Over Budget&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr><tr><td></td><td><asp:Literal runat="server" id="Literal9" Text="&amp;nbsp;">	</asp:Literal></td><td></td><td></td></tr></table>

                  </td></tr></table>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Request_DateLabel" Text="Request Date">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Request_Date" Columns="20" MaxLength="30" cssclass="field_input" enabled="False" htmlencodevalue="Default" textformat="{0}" width="279px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Request_DateTextBoxMaxLengthValidator" ControlToValidate="WCD_Request_Date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Request Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_Proj_Inc_ACBLabel" Text="Project Included">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCD_Proj_Inc_ACB" Columns="5" MaxLength="5" cssclass="field_input" enabled="False" htmlencodevalue="Default" textformat="{0}" width="40px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Proj_Inc_ACBTextBoxMaxLengthValidator" ControlToValidate="WCD_Proj_Inc_ACB" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Proj Increment ACB&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:literal id="Literal19" runat="server" text="in Approved Capital Budget" /></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_RemarkLabel" Text="Remark">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><asp:TextBox runat="server" id="WCD_Remark" Columns="40" MaxLength="2147483647" cssclass="field_input" enabled="False" htmlencodevalue="Default" rows="8" textformat="{0}" textmode="MultiLine" width="279px" wrap="False"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_RemarkTextBoxMaxLengthValidator" ControlToValidate="WCD_Remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"></td><td class="fls"></td></tr><tr><td class="fls" style="text-align:left;"></td><td class="fls" style="text-align:left;"><b><asp:Literal runat="server" id="WCD_SupplementaryLabel" Text="Supplementary Of">	</asp:Literal></b></td><td class="fls" style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCD_Supplementary_WCD_ID" Columns="14" MaxLength="14" cssclass="field_input" enabled="False" htmlencodevalue="Default" textformat="{0}" width="279px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCD_Supplementary_WCD_IDTextBoxMaxLengthValidator" ControlToValidate="WCD_Supplementary_WCD_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCD Supplementary WCD&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCD_Supplementary_Manual"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbRelated" causesvalidation="false" imageurl="../Images/Book_openHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Related CARs&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="fls"></td></tr><tr><td class="fls"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_U_ID" visible="False"></asp:Literal></span>
</td><td class="fls"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCD_ID" visible="False"></asp:Literal></span>
</td><td class="fls"><asp:Literal runat="server" id="Literal" Text="&amp;nbsp;">	</asp:Literal></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls"></td><td class="fls"><asp:Literal runat="server" id="Literal1" Text="&amp;nbsp;">	</asp:Literal></td><td class="fls"></td><td class="fls"></td><td class="fls"></td></tr></table>

                  </td></tr><tr><td><BaseClasses:TabContainer runat="server" id="WCAR_DocTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="WCAR_Doc_AttachTabPanel" HeaderText="Supporting Documents">	<ContentTemplate>
  <ePortalWFApproval:WCAR_Doc_AttachTableControl runat="server" id="WCAR_Doc_AttachTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Doc_AttachTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDA_FileLabel" Text="File Download">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDA_DescLabel" Text="Description">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDA_WAT_IDLabel" Text="Attach Type">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_Doc_AttachTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Doc_AttachTableControlRow runat="server" id="WCAR_Doc_AttachTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:LinkButton runat="server" id="WCDA_File" CommandName="Redirect"></asp:LinkButton></td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCDA_Desc"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCDA_WAT_ID"></asp:Literal></td></tr></ePortalWFApproval:WCAR_Doc_AttachTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC"></td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_Doc_AttachTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Doc_AttachTableControl>

 </ContentTemplate></BaseClasses:TabPanel> 
<BaseClasses:TabPanel runat="server" id="WCAR_ActivityTabPanel" HeaderText="Approval History">	<ContentTemplate>
  <ePortalWFApproval:WCAR_ActivityTableControl runat="server" id="WCAR_ActivityTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_ActivityTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_W_U_IDLabel" Text="User(Assigned)">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_StatusLabel" Text="Status">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_Date_AssignLabel" Text="Date Assign">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCA_Date_ActionLabel" Text="Date Action">	</asp:Literal></b></th><th class="thcwb" style="padding:0px;vertical-align:middle;text-align:left;"><b><asp:Literal runat="server" id="WCA_RemarkLabel" Text="Remark">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_ActivityTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_ActivityTableControlRow runat="server" id="WCAR_ActivityTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_W_U_ID"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCA_Status"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Assign"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCA_Date_Action"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:left;vertical-align:middle;"><asp:Literal runat="server" id="WCA_Remark"></asp:Literal></td></tr></ePortalWFApproval:WCAR_ActivityTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_ActivityTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_ActivityTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
 
 <BaseClasses:TabPanel runat="server" id="WCAR_Doc_CheckerTabPanel" HeaderText="Co-Requester">	<ContentTemplate>
  <ePortalWFApproval:WCAR_Doc_CheckerTableControl runat="server" id="WCAR_Doc_CheckerTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"></td><td class="dhb"></td><td></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Doc_CheckerTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDC_U_IDLabel" Text="Full Name">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDC_StatusLabel" Text="Status">	</asp:Literal></b></th><th class="thcnb" style="text-align:center;vertical-align:middle;"><b><asp:Literal runat="server" id="WCDC_RemLabel" Text="Remarks">	</asp:Literal></b></th></tr><asp:Repeater runat="server" id="WCAR_Doc_CheckerTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Doc_CheckerTableControlRow runat="server" id="WCAR_Doc_CheckerTableControlRow">
<tr><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCDC_U_ID"></asp:Literal></span>
</td><td class="ticnb" scope="row" style="text-align:center;vertical-align:middle;"><asp:Literal runat="server" id="WCDC_Status"></asp:Literal></td><td class="ticnb" scope="row" style="text-align:left;vertical-align:middle;"><asp:Literal runat="server" id="WCDC_Rem"></asp:Literal></td></tr></ePortalWFApproval:WCAR_Doc_CheckerTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_Doc_CheckerTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Doc_CheckerTableControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer></td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCAR_DocRecordControl1_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_DocRecordControl1>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
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
                