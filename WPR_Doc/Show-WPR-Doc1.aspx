<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-WPR-Doc1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_WPR_Doc1" %>
<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_WPR_Doc1" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<ePortalWFApproval:WPR_DocRecordControl runat="server" id="WPR_DocRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelT"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dhtr" valign="middle"><asp:Literal runat="server" id="WPR_DocTitle" Text="PR Document (View)">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td class="recordPanelButtonsAlignment" style="text-align:right;"><table cellpadding="0" cellspacing="0" border="0"><tr><td></td><td><ePortalWFApproval:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Back&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Back&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="WPR_DocRecordControlPanel" runat="server"><table><tr><td class="fls" rowspan="9"><asp:literal id="Literal1" runat="server" text="&nbsp;" /></td><td class="dfv" colspan="4"><asp:literal id="Literal" runat="server" text="&nbsp;" /></td><td class="tableCellValue"></td></tr><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPRD_C_IDLabel" Text="Company">	</asp:Literal></td><td class="dfv" style="text-align:left;">&nbsp;</td><td class="dfv" style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_C_ID"></asp:Literal></span>
</td><td class="tableCellLabel" rowspan="6"><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">Workflow</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td>
                  <asp:panel id="BlankPanelWithHeaderCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><table><tr><td><asp:literal id="Literal8" runat="server" text="&nbsp;" /></td><td></td><td></td></tr><tr><td style="text-align:right;"><asp:Literal runat="server" id="WPRD_WPRDS_IDLabel" Text="Status">	</asp:Literal></td><td style="text-align:left;">&nbsp;</td><td style="text-align:left;color:Black"><asp:Literal runat="server" id="WPRD_WPRDS_ID"></asp:Literal></td></tr><tr><td style="text-align:right;"><asp:Literal runat="server" id="WPRD_WDT_IDLabel" Text="Workflow">	</asp:Literal></td><td style="text-align:left;"></td><td style="text-align:left;color:Black"><asp:Literal runat="server" id="WPRD_WDT_ID"></asp:Literal></td></tr><tr><td style="text-align:right;"><asp:Literal runat="server" id="WPRD_SubmitLabel" Text="Submitted">	</asp:Literal></td><td style="text-align:left;"></td><td style="text-align:left;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WPRD_Submit" Columns="5" MaxLength="5" borderstyle="None" cssclass="field_input" htmlencodevalue="Default" readonly="True" textformat="{0}" width="369px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPRD_SubmitTextBoxMaxLengthValidator" ControlToValidate="WPRD_Submit" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPRD Submit&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr><tr><td><asp:literal id="Literal9" runat="server" text="&nbsp;" /></td><td></td><td></td></tr><tr><td class="fls"><asp:Literal runat="server" id="litLabel" Text="Requester">	</asp:Literal></td><td></td><td style="text-align:left;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRD_U_ID"></asp:Literal></span>
</td></tr><tr><td><asp:literal id="Literal11" runat="server" text="&nbsp;" /></td><td></td><td></td></tr></table>
</td></tr></table>
</asp:panel>
                </td></tr></table>
</td><td class="dfv"><asp:literal id="Literal3" runat="server" text="&nbsp;" /></td></tr><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPRD_NoLabel" Text="Purchase Request No">	</asp:Literal></td><td class="dfv" style="text-align:left;"></td><td class="dfv" style="text-align:left;"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WPRD_No" Columns="40" MaxLength="50" borderstyle="None" cssclass="field_input" htmlencodevalue="Default" readonly="True" textformat="{0}"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPRD_NoTextBoxMaxLengthValidator" ControlToValidate="WPRD_No" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPRD Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellValue"></td></tr><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPRD_WCur_IDLabel" Text="Currency">	</asp:Literal></td><td class="dfv" style="text-align:left;"></td><td class="dfv" style="text-align:left;"><asp:Literal runat="server" id="WPRD_WCur_ID"></asp:Literal> </td><td class="tableCellValue"></td></tr><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPRD_TotalLabel" Text="Request Total">	</asp:Literal></td><td class="dfv" style="text-align:left;"></td><td class="dfv" style="text-align:left;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WPRD_Total" Columns="20" MaxLength="26" borderstyle="None" cssclass="field_input" dataformat="#,#.00" htmlencodevalue="Default" readonly="True" textformat="{0}"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPRD_TotalTextBoxMaxLengthValidator" ControlToValidate="WPRD_Total" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPRD Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 </td><td class="tableCellValue"></td></tr><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPRD_WCD_IDLabel" Text="Reference CAR">	</asp:Literal></td><td class="dfv" style="text-align:left;"></td><td class="dfv" style="text-align:left;"><asp:Literal runat="server" id="WPRD_WCD_ID"></asp:Literal> </td><td class="tableCellValue"></td></tr><tr><td class="fls" style="text-align:right;"><asp:Literal runat="server" id="WPRD_CommentLabel" Text="Additional Comment">	</asp:Literal></td><td class="dfv" style="text-align:left;"></td><td class="dfv" style="text-align:left;"><asp:TextBox runat="server" id="WPRD_Comment" MaxLength="500" borderstyle="None" columns="60" cssclass="field_input" height="80px" htmlencodevalue="Default" readonly="True" rows="5" textformat="{0}" textmode="MultiLine" width="369px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPRD_CommentTextBoxMaxLengthValidator" ControlToValidate="WPRD_Comment" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPRD Comment&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="tableCellValue"></td></tr><tr><td class="fls"><asp:literal id="Literal2" runat="server" text="&nbsp;" /></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" colspan="4"><BaseClasses:TabContainer runat="server" id="WPR_DocTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="WPR_LineTabPanel" HeaderText="PR Details">	<ContentTemplate> 
  <ePortalWFApproval:WPR_Line1TableControl runat="server" id="WPR_Line1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPR_Line1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WPRL_Line_Seq_NoLabel" Text="Line No">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_IV00101_Item_NoLabel" Text="Item Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_IV40700_Locn_CodeLabel" Text="Site">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_AccountLabel" Text="Account">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_IV00101_Prchs_UOMLabel" Text="UoM">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_Required_DateLabel" Text="Required Date">	</asp:Literal></th></tr><tr class="tch"><th class="thc" colspan="2"><asp:Literal runat="server" id="WPRL_Item_Non_InvLabel" Text="Non Inventory">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_Item_Non_Inv_UOMLabel" Text="Non Inv UoM">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_Unit_PriceLabel" Text="Unit Price">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_QtyLabel" Text="Qty">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRL_Ext_PriceLabel" Text="Total Price">	</asp:Literal></th></tr><tr class="tch"><th class="thc" colspan="3"><asp:Literal runat="server" id="WPRL_Item_CommentLabel" Text="Item Comment / Non-Inv Description">	</asp:Literal></th><th class="thc" colspan="3"><asp:Literal runat="server" id="WPRL_Item_TextLabel" Text="Item Text">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPR_Line1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPR_Line1TableControlRow runat="server" id="WPR_Line1TableControlRow">
<tr><td class="ttc"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WPRL_Line_Seq_No" Columns="14" MaxLength="14" borderstyle="None" cssclass="field_input" htmlencodevalue="Default" textformat="{0}" width="23px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPRL_Line_Seq_NoTextBoxMaxLengthValidator" ControlToValidate="WPRL_Line_Seq_No" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPRL PO Line SEQ Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc"><asp:Literal runat="server" id="WPRL_IV00101_Item_No"></asp:Literal> 
<asp:Literal runat="server" id="WPRL_Item_Desc"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="WPRL_IV40700_Locn_Code"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="WPRL_Account"></asp:Literal></td><td class="ttc"><asp:Literal runat="server" id="WPRL_IV00101_Prchs_UOM"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRL_Required_Date"></asp:Literal></span>
</td></tr><tr><td class="ttc" colspan="2" style="white-space:nowrap;background-color:#fff8c1;"><asp:Literal runat="server" id="WPRL_Item_Non_Inv"></asp:Literal></td><td class="ttc" style="white-space:nowrap;background-color:#fff8c1;"><asp:Literal runat="server" id="WPRL_Item_Non_Inv_UOM"></asp:Literal></td><td class="ttc" style="white-space:nowrap;text-align:right;background-color:#fff8c1;color:#000000;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRL_Unit_Price"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;white-space:nowrap;background-color:#fff8c1;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRL_Qty"></asp:Literal></span>
</td><td class="ttc" style="text-align:right;white-space:nowrap;background-color:#fff8c1;color:#000000;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRL_Ext_Price"></asp:Literal></span>
</td></tr><tr><td class="ttc" colspan="3"><asp:Literal runat="server" id="WPRL_Item_Comment"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRL_GL00101_Acct_Indx" visible="False"></asp:Literal></span>
</td><td class="ttc" colspan="3"><asp:Literal runat="server" id="WPRL_Item_Text"></asp:Literal></td></tr></ePortalWFApproval:WPR_Line1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPR_Line1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPR_Line1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPR_Doc_AttachTabPanel" HeaderText="Supporting Documents">	<ContentTemplate> 
  <ePortalWFApproval:WPR_Doc_Attach1TableControl runat="server" id="WPR_Doc_Attach1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPR_Doc_Attach1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPRDA_FileLabel" Text="Download">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPRDA_DescLabel" Text="Description">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WPRDA_WAT_IDLabel" Text="Attach Type">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPR_Doc_Attach1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPR_Doc_Attach1TableControlRow runat="server" id="WPR_Doc_Attach1TableControlRow">
<tr><td class="ttc"><asp:LinkButton runat="server" id="WPRDA_File" CommandName="Redirect"></asp:LinkButton></td><td class="ttc"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WPRDA_Desc" MaxLength="50" borderstyle="None" columns="110" cssclass="field_input" htmlencodevalue="Default" textformat="{0}"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WPRDA_DescTextBoxMaxLengthValidator" ControlToValidate="WPRDA_Desc" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WPRDA Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WPRDA_WAT_ID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="128px"></asp:DropDownList></span>
</td></tr></ePortalWFApproval:WPR_Doc_Attach1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPR_Doc_Attach1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPR_Doc_Attach1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPR_ActivityTabPanel" HeaderText="Approval History">	<ContentTemplate> 
  <ePortalWFApproval:WPR_Activity1TableControl runat="server" id="WPR_Activity1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="CollapsibleRegion3" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WPR_Activity1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WPRA_W_U_IDLabel" Text="User (Assigned)">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRA_StatusLabel" Text="Status">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRA_Date_AssignLabel" Text="Date Assign">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRA_Date_ActionLabel" Text="Date Action">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WPRA_RemarkLabel" Text="Remark">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WPR_Activity1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WPR_Activity1TableControlRow runat="server" id="WPR_Activity1TableControlRow">
<tr><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRA_W_U_ID"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPRA_Status"></asp:Literal></td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRA_Date_Assign"></asp:Literal></span>
</td><td class="ttc"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRA_Date_Action"></asp:Literal></span>
</td><td class="ttc"><asp:Literal runat="server" id="WPRA_Remark"></asp:Literal></td></tr></ePortalWFApproval:WPR_Activity1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPR_Activity1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPR_Activity1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WPR_Ref_CARTabPanel" HeaderText="CAR Supporting Docs">	<ContentTemplate> 
  <ePortalWFApproval:WCAR_Doc_Attach1TableControl runat="server" id="WCAR_Doc_Attach1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td>
                  <asp:panel id="CollapsibleRegion4" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCAR_Doc_Attach1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="WCDA_FileLabel" Text="Download">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCDA_DescLabel" Text="Description">	</asp:Literal></th><th class="thc"><asp:Literal runat="server" id="WCDA_WAT_IDLabel" Text="Attach Type">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WCAR_Doc_Attach1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCAR_Doc_Attach1TableControlRow runat="server" id="WCAR_Doc_Attach1TableControlRow">
<tr><td class="tableCellLabel" style="text-align:center;"><asp:LinkButton runat="server" id="WCDA_File" CommandName="Redirect"></asp:LinkButton></td><td class="tableCellValue" style="text-align:left;"><asp:Literal runat="server" id="WCDA_Desc"></asp:Literal></td><td class="tableCellLabel" style="text-align:center;"><asp:Literal runat="server" id="WCDA_WAT_ID"></asp:Literal></td></tr></ePortalWFApproval:WCAR_Doc_Attach1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WCAR_Doc_Attach1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCAR_Doc_Attach1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td><td class="dfv" style="white-space:nowrap;"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WPR_DocRecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WPR_DocRecordControl>
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
                