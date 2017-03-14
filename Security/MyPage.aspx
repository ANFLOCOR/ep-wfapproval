<%@ Register Tagprefix="Selectors" Namespace="ePortalWFApproval" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" CodeFile="MyPage.aspx.vb" Culture="en-US" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ePortalWFApproval.UI.MyPage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td></td><td></td><td></td></tr><tr><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PanelExtender3" runat="server" TargetControlid="ApproverPipelineCollapsibleRegion" ExpandControlID="Icon3" CollapseControlID="Icon3" ImageControlID="Icon3" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" collapsed="True" />
<asp:ImageButton id="Icon3" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><span style="font-size:12pt"><b>Approver Pipeline</b></span></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="ApproverPipelineCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:tabcontainer id="ApproverPipelineTabContainer" runat="server">
    <asp:tabpanel id="North" runat="server" headertext="North">
        <headertemplate>North</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="APNCARImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAPNCAR" causesvalidation="False" commandname="Redirect" consumers="page" text="CAR (Reports)">		
	</asp:LinkButton>  
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="APNPOImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAPNPO" causesvalidation="False" commandname="Redirect" consumers="page" text="PO (Reports)">		
	</asp:LinkButton>  
				<li style="margin-left:-40px; padding-bottom:10px;">&nbsp
				<li style="margin-left:-40px; padding-bottom:10px;">&nbsp
			</ul>
		</contenttemplate>
    </asp:tabpanel>
	 <asp:tabpanel id="South" runat="server" headertext="South">
        <headertemplate>South</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="APSCARImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image><asp:LinkButton runat="server" id="lbAPSCAR" causesvalidation="False" commandname="Redirect" consumers="page" text="CAR (Reports)">		
	</asp:LinkButton>  
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="APSPOImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image><asp:LinkButton runat="server" id="lbAPSPO" causesvalidation="False" commandname="Redirect" consumers="page" text="PO (Reports)">		
	</asp:LinkButton> 
				<li style="margin-left:-40px; padding-bottom:10px;">&nbsp
				<li style="margin-left:-40px; padding-bottom:10px;">&nbsp
			</ul>
		</ContentTemplate>
    </asp:tabpanel>
</asp:tabcontainer></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PanelExtender4" runat="server" TargetControlid="ApproverHistoryCollapsibleRegion" ExpandControlID="Icon4" CollapseControlID="Icon4" ImageControlID="Icon4" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" collapsed="True" />
<asp:ImageButton id="Icon4" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><b><span style="font-size:12pt">Approval History</span></b></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="ApproverHistoryCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:tabcontainer id="ApproverHistoryTabContainer" runat="server">
    <asp:tabpanel id="ApproverHistoryNorth" runat="server" headertext="North">
        <headertemplate>North</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="AHNCARImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAHNCAR" causesvalidation="False" commandname="Redirect" consumers="page" text="CAR (Reports)">		
	</asp:LinkButton>  
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="AHNCARLImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAHNCARL" causesvalidation="False" commandname="Redirect" consumers="page" text="CAR (List)">		
	</asp:LinkButton>  
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="APNAHPOImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAHNPO" causesvalidation="False" commandname="Redirect" consumers="page" text="PO (Reports)">		
	</asp:LinkButton>
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="APNAHPOLImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAHNPOL" causesvalidation="False" commandname="Redirect" consumers="page" text="PO (List)">		
	</asp:LinkButton>
			</ul>
		</contenttemplate>
    </asp:tabpanel>
	 <asp:tabpanel id="ApproverHistorySouth" runat="server" headertext="South">
        <headertemplate>South</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;"><asp:Image runat="server" id="AHSCARImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAHSCAR" causesvalidation="False" commandname="Redirect" consumers="page" text="CAR (Reports)">		
	</asp:LinkButton>  
				<li style="margin-left:-30px; padding-bottom:10px;"><asp:Image runat="server" id="AHSCARLImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAHSCARL" causesvalidation="False" commandname="Redirect" consumers="page" text="CAR (List)">		
	</asp:LinkButton> 
				<li style="margin-left:-30px; padding-bottom:10px;"><asp:Image runat="server" id="AHSPOImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAHSPO" causesvalidation="False" commandname="Redirect" consumers="page" text="PO (Reports)">		
	</asp:LinkButton> 
				<li style="margin-left:-30px; padding-bottom:10px;"><asp:Image runat="server" id="APSAHPOLImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbAHSPOL" causesvalidation="False" commandname="Redirect" consumers="page" text="PO (List)">		
	</asp:LinkButton> 
			</ul>
		</ContentTemplate>
    </asp:tabpanel>
</asp:tabcontainer></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
</td><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PanelExtender5" runat="server" TargetControlid="FSReportsPanelCollapsibleRegion" ExpandControlID="Icon5" CollapseControlID="Icon5" ImageControlID="Icon5" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" collapsed="True" />
<asp:ImageButton id="Icon5" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle" style="text-align:left;"><b><span style="font-size:12pt">FS Reports (Inquiry)</span></b></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="FSReportsPanelCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:tabcontainer id="FSReportsTabContainer1" runat="server">
    <asp:tabpanel id="FSReportsNorth" runat="server" headertext="North">
        <headertemplate>North</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="FSNGPImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbFSNGP" causesvalidation="False" commandname="Redirect" consumers="page" text="GP Companies">		
	</asp:LinkButton>  
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="FSNNGPImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image> <asp:LinkButton runat="server" id="lbFSNNGP" causesvalidation="False" commandname="Redirect" consumers="page" text="Non-GP Companies">		
	</asp:LinkButton>  
				<li style="margin-left:-30px; padding-bottom:10px;">&nbsp
				<li style="margin-left:-30px; padding-bottom:10px;">&nbsp
			</ul>
		</contenttemplate>
    </asp:tabpanel>
	 <asp:tabpanel id="FSReportsSouth" runat="server" headertext="South">
        <headertemplate>South</headertemplate>
        <contenttemplate>
			<ul style="list-style: none;">
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="FSSGPImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image><asp:LinkButton runat="server" id="lbFSSGP" causesvalidation="False" commandname="Redirect" consumers="page" text="GP Companies">		
	</asp:LinkButton>  
				<li style="margin-left:-30px; padding-bottom:10px;"> <asp:Image runat="server" id="FSSNGPImage" imagealign="Middle" imageurl="../Images/btn-search-new-l.png">		
	</asp:Image><asp:LinkButton runat="server" id="lbFSSNGP" causesvalidation="False" commandname="Redirect" consumers="page" text="Non-GP Companies">		
	</asp:LinkButton> 
				<li style="margin-left:-30px; padding-bottom:10px;">&nbsp
				<li style="margin-left:-30px; padding-bottom:10px;">&nbsp
			</ul>
		</ContentTemplate>
    </asp:tabpanel>
</asp:tabcontainer></td></tr></table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
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
                