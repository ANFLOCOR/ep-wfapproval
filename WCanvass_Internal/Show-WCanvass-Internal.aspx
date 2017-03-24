<%@ Register Tagprefix="ePortalWFApproval" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_WCanvass_Internal" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-WCanvass-Internal.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_WCanvass_Internal" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                        <ePortalWFApproval:WCanvass_InternalRecordControl runat="server" id="WCanvass_InternalRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><b><span style="font-size:14pt"><asp:Literal runat="server" id="WCanvass_InternalTitle" Text="Canvass (View)">	</asp:Literal></span></b></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td class="panelHeaderL"> 
<table><tr><td style="display:none;"><ePortalWFApproval:ThemeButton runat="server" id="btnBack" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Back to Previous Page&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Back to Previous Page&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td><td style="display:none;"><ePortalWFApproval:ThemeButton runat="server" id="btnPrint" button-causesvalidation="False" button-text="&lt;%# GetResourceValue(&quot;Print Canvass&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Print Canvass&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButton></td><td style="display:none;"><ePortalWFApproval:ThemeButton runat="server" id="EditButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Custom" button-text="&lt;%# GetResourceValue(&quot;Back to Previous Page&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Back to Previous Page&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="WCanvass_InternalRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="fls" rowspan="9"><asp:literal id="Literal" runat="server" text="&nbsp;" /></td><td class="fls" colspan="10"><asp:literal id="Literal1" runat="server" text="&nbsp;" /></td><td class="fls"><asp:literal id="Literal2" runat="server" text="&nbsp;" /></td></tr><tr><td class="tableCellValue" colspan="2" style="text-align:left;"><asp:Literal runat="server" id="WCI_C_IDLabel" Text="Select Company">	</asp:Literal></td><td class="tableCellValue" colspan="5"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCI_C_ID" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" width="320px"></asp:DropDownList></span>
</td><td class="fls" style="white-space:nowrap;text-align:left;width:6000px;" rowspan="6" colspan="3"><asp:Literal runat="server" id="litAuditors" Text="Auditor(s)" visible="False">	</asp:Literal></td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue" colspan="2" style="text-align:left;"><asp:Literal runat="server" id="WCI_WPRD_IDLabel" Text="Canvass base on PR">	</asp:Literal></td><td class="tableCellValue" colspan="5"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCI_WPRD_ID" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" width="320px"></asp:DropDownList></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue" colspan="2" style="text-align:left;"><asp:Literal runat="server" id="WCI_DateLabel" Text="Canvass Date">	</asp:Literal></td><td class="tableCellValue" colspan="5"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCI_Date" Columns="20" MaxLength="30" cssclass="field_input" enabled="False" enabletheming="True" width="317px"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCI_DateTextBoxMaxLengthValidator" ControlToValidate="WCI_Date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCI Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue" colspan="2" style="text-align:left;"><asp:Literal runat="server" id="WCI_VendorsLabel" Text="Vendors">	</asp:Literal></td><td class="tableCellValue" colspan="5"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCI_Vendors" cssclass="field_input" enabled="False" onchange="jq_toggle_col_vis(&#39;tblVendor&#39;,this.value);" onkeypress="dropDownListTypeAhead(this,false)" width="320px"></asp:DropDownList></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue" colspan="2" style="text-align:left;"><asp:Literal runat="server" id="WCI_WClass_IDLabel" Text="Classification">	</asp:Literal></td><td class="tableCellValue" colspan="5"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="WCI_WClass_ID" cssclass="field_input" enabled="False" onkeypress="dropDownListTypeAhead(this,false)" width="320px"></asp:DropDownList></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue" colspan="2" style="text-align:left;"><asp:Literal runat="server" id="WCI_StatusLabel" Text="Status">	</asp:Literal></td><td class="tableCellValue" colspan="5"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCI_Status" Columns="20" MaxLength="20" cssclass="field_input" htmlencodevalue="Default" onfocus="this.blur();" readonly="True" width="317px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCI_StatusTextBoxMaxLengthValidator" ControlToValidate="WCI_Status" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCI Status&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue" colspan="10"><asp:literal id="Literal3" runat="server" text="&nbsp;" /> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCI_U_ID" Columns="14" MaxLength="14" cssclass="field_input" visible="False"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCI_U_IDTextBoxMaxLengthValidator" ControlToValidate="WCI_U_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCI U&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCI_ID" visible="False"></asp:Literal></span>
 
<asp:CheckBox runat="server" id="WCI_Submit" visible="False"></asp:CheckBox></td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue" colspan="10"><BaseClasses:TabContainer runat="server" id="WCanvass_InternalTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="WCanvass_Detail_InternalTabPanel" HeaderText="Canvass Details">	<ContentTemplate> 
  <ePortalWFApproval:Sel_WCanvass_Detail_Internal_WPR_LineTableControl runat="server" id="Sel_WCanvass_Detail_Internal_WPR_LineTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="Sel_WCanvass_Detail_Internal_WPR_LineTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Sel_WCanvass_Detail_Internal_WPR_LineTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)" id="tblVendor"><tr class="tch"><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="ItemLabel" tooltip="Sort by Item" Text="Item" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="ItemDescriptionLabel" tooltip="Sort by ItemDescription" Text="Item Description" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 1" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label1" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 2" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label2" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 3" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label3" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 4" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label4" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 5" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label5" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 6" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label6" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 7" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label7" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 8" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label8" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 9" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label9" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 10" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" rowspan="3" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_CommentLabel" tooltip="Sort by WCDI_Comment" Text="Comment" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" rowspan="3" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Audit_CommentLabel" tooltip="Sort by WCDI_Audit_Comment" Text="Audit Comment" CausesValidation="False">	</asp:LinkButton></th></tr><tr class="tch"><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="UnitOfMeasureLabel" tooltip="Sort by UnitOfMeasure" Text="UoM" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="UnitPriceLabel" tooltip="Sort by UnitPrice" Text="Unit Price" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label1" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label2" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label3" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label4" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label5" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label6" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label7" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label8" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label9" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th></tr><tr class="tch"><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WPRL_QtyLabel" tooltip="Sort by WPRL_Qty" Text="Qty" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WPRL_Ext_PriceLabel" tooltip="Sort by WPRL_Ext_Price" Text="Total Price" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label1" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label2" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label3" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label4" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label5" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label6" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label7" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label8" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label9" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="Sel_WCanvass_Detail_Internal_WPR_LineTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WCanvass_Detail_Internal_WPR_LineTableControlRow runat="server" id="Sel_WCanvass_Detail_Internal_WPR_LineTableControlRow">
<tr><td class="ttc" scope="row" style="text-align:left;"><asp:LinkButton runat="server" id="Item" causesvalidation="False" commandname="Redirect" forecolor="Black"></asp:LinkButton> 
<asp:LinkButton runat="server" id="Item1" causesvalidation="False" commandname="Redirect" forecolor="Blue" tooltip="View Item History"></asp:LinkButton> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCDI_ID" visible="False"></asp:Literal></span>
 
</td><td class="ttc" scope="row"><asp:Literal runat="server" id="ItemDescription"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRL_ID" visible="False"></asp:Literal></span>
<asp:Literal runat="server" id="litOrig" Text="NONE" visible="False">	</asp:Literal></td><td class="ttc" scope="row" style="white-space: nowrap;"><asp:textbox id="WCDI_PM00200_Vendor_ID" runat="server" text="Type text" cssclass="field_input" width="233px" readonly="True"></asp:textbox> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID1" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect11(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID1TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak19" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID2" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect2(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID2TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor1" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak1" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID3" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect22(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID3TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID3" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist1" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak17" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory1" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID4" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect3(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID4TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID4" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor2" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak3" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID5" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect33(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID5TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID5" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist2" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak15" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory2" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID6" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect4(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID6TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID6" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor3" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak5" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID7" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect44(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID7TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID7" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist3" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak13" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory3" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID8" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect5(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID8TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID8" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor4" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak7" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID9" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect55(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID9TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID9" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist4" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak11" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory4" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID10" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect6(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID10TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID10" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor5" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak9" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID11" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect66(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID11TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID11" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist5" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak10" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory5" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID12" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect7(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID12TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID12" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor6" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak12" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID13" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect77(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID13TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID13" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist6" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak8" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory6" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID14" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect8(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID14TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID14" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor7" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak14" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID15" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect88(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID15TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID15" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist7" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak6" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory7" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID16" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect9(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID16TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID16" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor8" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak16" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID17" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect99(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID17TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID17" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist8" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak4" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory8" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID18" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect10(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID18TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID18" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor9" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak18" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCDI_PM00200_Vendor_ID19" Columns="15" MaxLength="15" cssclass="field_input" htmlencodevalue="Default" onchange="AutoSelect1010(this.id);" onfocus="this.blur();" textformat="{0}" width="233px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_PM00200_Vendor_ID19TextBoxMaxLengthValidator" ControlToValidate="WCDI_PM00200_Vendor_ID19" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI PM 00200 Vendor 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist9" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="
          " onmouseover="
          " tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak2" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorHistory9" CommandName="Redirect" forecolor="Blue" tooltip="View Vendor History"></asp:LinkButton></td><td class="ttc" scope="row" rowspan="3"><asp:TextBox runat="server" id="WCDI_Comment" Columns="40" MaxLength="500" cssclass="field_input" htmlencodevalue="Default" rows="8" textformat="{0}" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_CommentTextBoxMaxLengthValidator" ControlToValidate="WCDI_Comment" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Comment&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="ttc" scope="row" rowspan="3"><asp:TextBox runat="server" id="WCDI_Audit_Comment" MaxLength="500" columns="60" cssclass="field_input" enabled="False" htmlencodevalue="Default" rows="8" textformat="{0}" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Audit_CommentTextBoxMaxLengthValidator" ControlToValidate="WCDI_Audit_Comment" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Audit Comment&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="ttc" scope="row" style="text-align:center;"><asp:Literal runat="server" id="UnitOfMeasure"></asp:Literal></td><td class="ttc" scope="row" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="UnitPrice"></asp:Literal></span>
 
<asp:Literal runat="server" id="WCDI_Aw" visible="False"></asp:Literal><asp:Literal runat="server" id="litPO" Text="PO:" visible="False">	</asp:Literal><asp:Literal runat="server" id="WCDI_Vat" visible="False"></asp:Literal><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCDI_Net" visible="False"></asp:Literal></span>
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="WCDI_WCur_ID" visible="False"></asp:Literal></span>
 
</td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_BidTextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw1"></asp:Literal><asp:ImageButton CommandName="Redirect" runat="server" id="imbBid" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak20" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid1" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid1TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw2"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid1" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt1" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak21" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory1" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid2" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid2TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw3"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid2" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt2" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak22" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory2" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid3" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid3TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid3" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw4"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid3" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt3" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak23" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory3" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid4" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid4TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid4" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw5"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid4" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt4" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak24" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory4" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid5" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid5TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid5" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw6"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid5" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt5" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak25" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory5" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid6" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid6TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid6" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw7"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid6" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt6" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak26" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory6" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid7" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid7TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid7" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw8"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid7" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt7" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak27" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory7" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid8" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid8TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid8" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw9"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid8" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt8" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak28" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory8" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td><td class="ttc" scope="row" style="white-space: nowrap;"><span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Bid9" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Bid9TextBoxMaxLengthValidator" ControlToValidate="WCDI_Bid9" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Bid 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
 
<asp:Literal runat="server" id="WCDI_Aw10"></asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid9" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt9" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak29" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:LinkButton runat="server" id="lbVendorItemHistory9" CommandName="Redirect" enabled="True" forecolor="Blue" tooltip="View Vendor-Item History"></asp:LinkButton></td></tr><tr><td class="ttc" scope="row" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRL_Qty"></asp:Literal></span>
</td><td class="ttc" scope="row" style="text-align:right;"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="WPRL_Ext_Price"></asp:Literal></span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_QtyTextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award1" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty1" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty1TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award2" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty2" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty2TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award3" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty3" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty3TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty3" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award4" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty4" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty4TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty4" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award5" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty5" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty5TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty5" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award6" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty6" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty6TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty6" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award7" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty7" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty7TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty7" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award8" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty8" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty8TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty8" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td><td class="ttc" scope="row" style="text-align:right;"><asp:CheckBox runat="server" id="WCDI_Award9" visible="False"></asp:CheckBox> 
<span style="white-space:nowrap;">
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="WCDI_Qty9" Columns="20" MaxLength="26" cssclass="field_input" dataformat="#,#.0000" htmlencodevalue="Default" readonly="True" textformat="{0}" width="253px" style="Text-Align:Right;"></asp:TextBox></td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCDI_Qty9TextBoxMaxLengthValidator" ControlToValidate="WCDI_Qty9" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCDI Quantity 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</span>
</td></tr></ePortalWFApproval:Sel_WCanvass_Detail_Internal_WPR_LineTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel></td><td class="panelT"></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="Sel_WCanvass_Detail_Internal_WPR_LineTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WCanvass_Detail_Internal_WPR_LineTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WCanvass_Quotation_InternalTabPanel" HeaderText="Supporting Documents">	<ContentTemplate> 
  <ePortalWFApproval:WCanvass_Quotation_InternalTableControl runat="server" id="WCanvass_Quotation_InternalTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><asp:panel id="WCanvass_Quotation_InternalTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"> 
<table><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"><asp:ImageButton runat="server" id="WCanvass_Quotation_InternalResetButton" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"></td><td class="prbbc"></td><td class="pra"><ePortalWFApproval:Pagination runat="server" id="WCanvass_Quotation_InternalPagination"></ePortalWFApproval:Pagination></td></tr></table>
</td></tr><tr><td class="tre"><table id="WCanvass_Quotation_InternalTableControlGrid" cellpadding="1" cellspacing="2" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="1"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCQI_FileLabel" Text="Download">	</asp:Literal></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCQI_DescLabel" Text="Description">	</asp:Literal></th><th></th><th></th><th></th><th></th><th></th><th></th><th></th><th></th><th></th><th class="thc" style="text-align:center;"><asp:Literal runat="server" id="WCQI_PM00200_Vendor_IDLabel" Text="Vendor ID">	</asp:Literal></th></tr><asp:Repeater runat="server" id="WCanvass_Quotation_InternalTableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCanvass_Quotation_InternalTableControlRow runat="server" id="WCanvass_Quotation_InternalTableControlRow">
<tr><td class="ticnb" scope="row"><asp:literal id="Literal4" runat="server" text="&nbsp;" /></td><td class="ttc"><asp:LinkButton runat="server" id="WCQI_File" CommandName="Redirect" size="60"></asp:LinkButton></td><td class="ttc"><asp:TextBox runat="server" id="WCQI_Desc" MaxLength="250" columns="70" cssclass="field_input" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCQI_DescTextBoxMaxLengthValidator" ControlToValidate="WCQI_Desc" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCQI Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td class="ttc"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCQI_PM00200_Vendor_ID" MaxLength="15" columns="40" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCQI_PM00200_Vendor_IDTextBoxMaxLengthValidator" ControlToValidate="WCQI_PM00200_Vendor_ID" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCQI PM 00200 Vendor&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 
<asp:Literal runat="server" id="litBreak30" Text="&lt;br>" visible="True">	</asp:Literal> 
<span style="white-space:nowrap;">
<asp:TextBox runat="server" id="WCQI_PM00200_Vendor_ID1" MaxLength="15" columns="40" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="WCQI_PM00200_Vendor_ID1TextBoxMaxLengthValidator" ControlToValidate="WCQI_PM00200_Vendor_ID1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ePortalWFApproval&quot;).Replace(&quot;{FieldName}&quot;, &quot;WCQI PM 00200 Vendor&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
</td></tr></ePortalWFApproval:WCanvass_Quotation_InternalTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td><td class="panelT"></td></tr><tr><td class="panelHeaderL"></td><td class="dh"></td></tr><tr><td class="panelL"></td><td></td></tr></table>
	<asp:hiddenfield id="WCanvass_Quotation_InternalTableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCanvass_Quotation_InternalTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
  
  
  
</BaseClasses:TabContainer></td><td class="tableCellValue"></td></tr></table></asp:panel>

                  </td></tr></table>
</asp:panel>
                </td></tr></table>
	<asp:hiddenfield id="WCanvass_InternalRecordControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCanvass_InternalRecordControl>

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
                