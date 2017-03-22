<%@ Register Tagprefix="ePortalWFApproval" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Register Tagprefix="ePortalWFApproval" Namespace="ePortalWFApproval.UI.Controls.Show_WCanvass_Internal1" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ePortalWFApproval" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="Show-WCanvass-Internal1.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.Show_WCanvass_Internal1" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dhtr" valign="middle"><asp:Literal runat="server" id="WCanvass_InternalTitle" Text="Canvass (View)">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td></tr><tr><td class="recordPanelButtonsAlignment" style="text-align:left;"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ePortalWFApproval:ThemeButton runat="server" id="btnBack" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Back to Previous Page&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Back to Previous Page&quot;, &quot;ePortalWFApproval&quot;) %>" visible="False"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="EditButton" button-causesvalidation="false" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false"></ePortalWFApproval:ThemeButton></td><td><ePortalWFApproval:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="Done" visible="True"></ePortalWFApproval:ThemeButton></td></tr></table>
</td></tr><tr><td>
                  <asp:panel id="WCanvass_InternalRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td>
                    <asp:panel id="WCanvass_InternalRecordControlPanel" runat="server"><table><tr><td class="fls" rowspan="9"><asp:literal id="Literal" runat="server" text="&nbsp;" /></td><td class="fls" colspan="10"><asp:literal id="Literal1" runat="server" text="&nbsp;" /></td><td class="fls"><asp:literal id="Literal2" runat="server" text="&nbsp;" /></td></tr><tr><td class="tableCellValue" colspan="2" style="text-align:left;"><asp:Literal runat="server" id="WCI_C_IDLabel" Text="Select Company">	</asp:Literal></td><td class="tableCellValue" colspan="5"><span style="white-space:nowrap;">
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
 
 
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellValue" colspan="10"><BaseClasses:TabContainer runat="server" id="WCanvass_InternalTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="WCanvass_Detail_InternalTabPanel" HeaderText="Canvass Details">	<ContentTemplate> 
  <ePortalWFApproval:Sel_WCanvass_Detail_Internal_WPR_Line1TableControl runat="server" id="Sel_WCanvass_Detail_Internal_WPR_Line1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title0" Text="&lt;%#String.Concat(&quot;WCanvass Detail Internal WPR Line&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ActionsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="PDFButton" causesvalidation="false" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton" causesvalidation="false" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton" causesvalidation="false" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><ePortalWFApproval:ThemeButtonWithArrow runat="server" id="ActionsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ActionsDiv&#39;,&#39;ActionsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <ePortalWFApproval:ThemeButtonWithArrow runat="server" id="FiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;FiltersDiv&#39;,&#39;FiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton1"))%>

                <asp:TextBox runat="server" id="Sel_WCanvass_Detail_Internal_WPR_Line1SearchText" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="Sel_WCanvass_Detail_Internal_WPR_Line1SearchTextAutoCompleteExtender" runat="server" TargetControlID="Sel_WCanvass_Detail_Internal_WPR_Line1SearchText" ServiceMethod="GetAutoCompletionList_Sel_WCanvass_Detail_Internal_WPR_Line1SearchText" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SearchButton1"))%>
</td><td>
                <asp:ImageButton runat="server" id="SearchButton1" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="FiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="WCDI_StatusLabel2" Text="WCDI Status">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton"))%>
<BaseClasses:QuickSelector runat="server" id="WCDI_StatusFilter1" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton"))%>
</td><td class="popupTableCellValue"><ePortalWFApproval:ThemeButton runat="server" id="FilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="Sel_WCanvass_Detail_Internal_WPR_Line1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="ItemLabel" tooltip="Sort by Item" Text="Item" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="ItemDescriptionLabel" tooltip="Sort by ItemDescription" Text="Item Description" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 1" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label1" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 2" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label2" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 3" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label3" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 4" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label4" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 5" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label5" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 6" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label6" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 7" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label7" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 8" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label8" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 9" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_PM00200_Vendor_ID1Label9" tooltip="Sort by WCDI_PM00200_Vendor_ID1" Text="Vendor 10" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" rowspan="3" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_CommentLabel" tooltip="Sort by WCDI_Comment" Text="Comment" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" rowspan="3" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Audit_CommentLabel" tooltip="Sort by WCDI_Audit_Comment" Text="Audit Comment" CausesValidation="False">	</asp:LinkButton></th></tr><tr class="tch"><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="UnitOfMeasureLabel" tooltip="Sort by UnitOfMeasure" Text="UoM" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="UnitPriceLabel" tooltip="Sort by UnitPrice" Text="Unit Price" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label1" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label2" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label3" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label4" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label5" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label6" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label7" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label8" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th><th class="thcnb" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Bid1Label9" tooltip="Sort by WCDI_Bid1" Text="Quote" CausesValidation="False">	</asp:LinkButton></th></tr><tr class="tch"><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WPRL_QtyLabel" tooltip="Sort by WPRL_Qty" Text="Qty" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WPRL_Ext_PriceLabel" tooltip="Sort by WPRL_Ext_Price" Text="Total Price" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label1" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label2" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label3" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label4" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label5" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label6" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label7" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label8" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th><th class="thc" style="text-align:center;"><asp:LinkButton runat="server" id="WCDI_Award1Label9" tooltip="Sort by WCDI_Award1" Text="Quantity" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow runat="server" id="Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow">
<tr><td class="ttc" scope="row" style="text-align:left;"> 
 
 
</td><td class="ttc" scope="row"> 
<asp:Literal runat="server" id="litOrig" Text="NONE" visible="False">	</asp:Literal></td><td class="ttc" scope="row" style="white-space: nowrap;"><asp:textbox id="WCDI_PM00200_Vendor_ID" runat="server" text="Type text" cssclass="field_input" width="233px" readonly="True"></asp:textbox> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak19" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor1" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak1" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist1" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak17" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor2" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak3" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist2" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak15" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor3" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak5" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist3" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak13" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor4" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak7" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist4" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak11" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor5" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak9" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist5" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak10" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor6" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak12" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist6" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak8" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor7" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak14" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist7" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak6" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor8" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak16" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist8" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak4" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row"><asp:ImageButton CommandName="Redirect" runat="server" id="imbVendor9" causesvalidation="false" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Find Vendor&quot;, &quot;ePortalWFApproval&quot;) %>" visible="false">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak18" Text="&lt;br>" visible="True">	</asp:Literal> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbHist9" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" onmouseout="this.src=&#39;../Images/ExpirationHS.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History&quot;, &quot;ePortalWFApproval&quot;) %>" visible="true">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak2" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" rowspan="3"></td><td class="ttc" scope="row" rowspan="3"></td></tr><tr><td class="ttc" scope="row" style="text-align:center;"></td><td class="ttc" scope="row" style="text-align:right;"> 
<asp:Literal runat="server" id="litPO" Text="PO:" visible="False">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak20" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid1" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt1" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak21" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid2" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt2" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak22" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid3" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt3" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak23" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid4" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt4" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak24" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid5" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt5" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak25" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid6" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt6" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak26" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid7" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt7" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak27" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid8" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt8" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak28" Text="&lt;br>" visible="True">	</asp:Literal> 
</td><td class="ttc" scope="row" style="white-space: nowrap;"> 
 
<asp:ImageButton CommandName="Redirect" runat="server" id="imbBid9" causesvalidation="false" imageurl="../Images/ExpirationHS.gif" tooltip="&lt;%# GetResourceValue(&quot;View Vendor-Item History for this Item&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton><asp:ImageButton CommandName="Redirect" runat="server" id="imbAtt9" causesvalidation="false" imageurl="../Images/AttachmentHS.png" tooltip="&lt;%# GetResourceValue(&quot;View Attached Quotation&quot;, &quot;ePortalWFApproval&quot;) %>" style="Margin-Left:15px;Padding-Top:3px;">		
	</asp:ImageButton> 
<asp:Literal runat="server" id="litBreak29" Text="&lt;br>" visible="True">	</asp:Literal> 
</td></tr><tr><td class="ttc" scope="row" style="text-align:right;"></td><td class="ttc" scope="row" style="text-align:right;"></td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td><td class="ttc" scope="row" style="text-align:right;"> 
</td></tr></ePortalWFApproval:Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="Sel_WCanvass_Detail_Internal_WPR_Line1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:Sel_WCanvass_Detail_Internal_WPR_Line1TableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="WCanvass_Quotation_InternalTabPanel" HeaderText="Supporting Documents">	<ContentTemplate> 
  <ePortalWFApproval:WCanvass_Quotation_Internal1TableControl runat="server" id="WCanvass_Quotation_Internal1TableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">
                        <asp:Literal runat="server" id="Title1" Text="&lt;%#String.Concat(&quot;WCanvass Quotation Internal&quot;) %>">	</asp:Literal>
                      </td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="Actions1Div" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="PDFButton1" causesvalidation="false" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="WordButton1" causesvalidation="false" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ExcelButton1" causesvalidation="false" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><ePortalWFApproval:ThemeButtonWithArrow runat="server" id="Actions1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Actions1Div&#39;,&#39;Actions1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <ePortalWFApproval:ThemeButtonWithArrow runat="server" id="Filters1Button" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;Filters1Div&#39;,&#39;Filters1Button&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;ePortalWFApproval&quot;) %>"></ePortalWFApproval:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SearchButton3"))%>

                <asp:TextBox runat="server" id="WCanvass_Quotation_Internal1SearchText" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="WCanvass_Quotation_Internal1SearchTextAutoCompleteExtender" runat="server" TargetControlID="WCanvass_Quotation_Internal1SearchText" ServiceMethod="GetAutoCompletionList_WCanvass_Quotation_Internal1SearchText" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SearchButton3"))%>
</td><td>
                <asp:ImageButton runat="server" id="SearchButton3" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td class="prspaceEnd">&nbsp;</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="Filters1Div" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" onmouseover="this.src='../Images/closeButtonOver.gif'" onmouseout="this.src='../Images/closeButton.gif'" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="WCQI_PM00200_Vendor_IDLabel2" Text="WCQI PM 00200 Vendor">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("FilterButton1"))%>
<BaseClasses:QuickSelector runat="server" id="WCQI_PM00200_Vendor_IDFilter1" onkeypress="dropDownListTypeAhead(this,false)" redirecturl="" selectionmode="Single">	</BaseClasses:QuickSelector><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("FilterButton1"))%>
</td><td class="popupTableCellValue"><ePortalWFApproval:ThemeButton runat="server" id="FilterButton1" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ePortalWFApproval&quot;) %>" postback="False"></ePortalWFApproval:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ResetButton1" causesvalidation="false" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src=&#39;../Images/ButtonBarReset.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarResetOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ePortalWFApproval&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Label runat="server" id="SortByLabel1" Text="&lt;%# GetResourceValue(&quot;Txt:SortBy&quot;, &quot;ePortalWFApproval&quot;) %>">	</asp:Label></td><td class="popupTableCellValue"><asp:DropDownList runat="server" id="SortControl1" autopostback="True" cssclass="Filter_Input" priorityno="1">	</asp:DropDownList></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="WCanvass_Quotation_Internal1TableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th><th class="thc" style="display: none"></th></tr><asp:Repeater runat="server" id="WCanvass_Quotation_Internal1TableControlRepeater">		<ITEMTEMPLATE>		<ePortalWFApproval:WCanvass_Quotation_Internal1TableControlRow runat="server" id="WCanvass_Quotation_Internal1TableControlRow">
<tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCQI_PM00200_Vendor_IDLabel" Text="WCQI PM 00200 Vendor">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="WCQI_PM00200_Vendor_ID"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCQI_DescLabel" Text="WCQI Description">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:Literal runat="server" id="WCQI_Desc"></asp:Literal> </td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="WCQI_FileLabel" Text="WCQI File">	</asp:Literal> 
</td><td class="tableCellValue" colspan="5"><asp:LinkButton runat="server" id="WCQI_File" CommandName="Redirect"></asp:LinkButton> </td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></ePortalWFApproval:WCanvass_Quotation_Internal1TableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <ePortalWFApproval:PaginationModern runat="server" id="Pagination1"></ePortalWFApproval:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="WCanvass_Quotation_Internal1TableControl_PostbackTracker" runat="server" />
</ePortalWFApproval:WCanvass_Quotation_Internal1TableControl>
 
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
                