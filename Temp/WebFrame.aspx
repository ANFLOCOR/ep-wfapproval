<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Culture="en-US" Inherits="ePortalWFApproval.UI.BaseApplicationPage" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%@ Import Namespace="System" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Collections" %>
<%@ Import Namespace="System.ComponentModel" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Web" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="BaseClasses.Data" %>
<%@ Import Namespace="BaseClasses" %>
<%@ Import Namespace="BaseClasses.Utils" %>
<%@ Import Namespace="BaseClasses.Web" %>

<%@ Import Namespace="ePortalWFApproval.Business" %>
<%@ Import Namespace="ePortalWFApproval.Data" %>

	
	<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

	<html xmlns="http://www.w3.org/1999/xhtml">
		<head id="Head1" runat="server">
			<title></title>
			<meta http-equiv="X-UA-Compatible" content="IE=7,8,9"/>
			<script runat="server">



			    Protected Overridable Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
			        ' Handles MyBase.Init. Registers event handler for any button, sort or links.
			        ' You can add additional Init handlers in Section 1.

			    End Sub

			    Protected Overridable Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			        Dim pageURL As String
			        Dim URLString As String = Page.Request.RawUrl
			        Dim pageType As String = Page.Request.QueryString("PageType")
			        Dim parameterRequired As String = Page.Request.QueryString("IsParamRequired")
			        Dim tableName As String = Page.Request.QueryString("TableName")
			        Dim isEncrypted As String = Page.Request.QueryString("Encrypted")
			        Dim tempURL As String = Page.Request.QueryString("tempURL")
			        


			            
			        pageURL = Page.Request.QueryString("tempURL")

			        If IsNothing(parameterRequired) OrElse parameterRequired.Equals("true", System.StringComparison.InvariantCultureIgnoreCase) Then
			            Try
			                
			            Catch ex As Exception
			                Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
			                Return
			            End Try
			                
			        End If
			            

			        Response.Redirect(pageURL)
			        
			        
			    End Sub





			    Protected Overrides Sub UpdateSessionNavigationHistory()
			        'Do nothing
			    End Sub


					</script>


    </head>
	

    <body id="Body1" runat="server" style="margin:0px;  " >

		<form id="Form1" method="post" runat="server">
			<script language="JavaScript" type="text/javascript"></script>
			<asp:ToolkitScriptManager ID="scriptManager1" runat="server" EnablePartialRendering="True" EnablePageMethods="True" EnableScriptGlobalization="True" EnableScriptLocalization="True" />
			<asp:UpdateProgress runat="server" id="UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
				<ProgressTemplate>
					<div class="ajaxUpdatePanel"></div>
					<div style=" position:absolute; padding:30px;">
						<img src="../Images/updating.gif" alt="Updating"/>
					</div>
				</ProgressTemplate>
			</asp:UpdateProgress>
			<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
				<ContentTemplate>
					

				</ContentTemplate>
			</asp:UpdatePanel>
			
			<div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
			<asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
		</form>
    </body>
</html>
	
