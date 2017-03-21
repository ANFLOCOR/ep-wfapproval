<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Culture="en-US" Inherits="ePortalWFApproval.UI.BaseApplicationPage" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="asp" TagName="IncludeComponent" Src="../Shared/IncludeComponent.ascx" %>

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


			    Public Sub LoadData()
			        ' LoadData reads database data and assigns it to UI controls.
			        ' Customize by adding code before or after the call to LoadData_Base()
			        ' or replace the call to LoadData_Base().
			        LoadData_Base()
			    End Sub



			    <System.Web.Services.WebMethod()> _
			    Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
			        ByVal recordID As String, _
			        ByVal columnName As String, _
			        ByVal title As String, _
			        ByVal persist As Boolean, _
			        ByVal popupWindowHeight As Integer, _
			        ByVal popupWindowWidth As Integer, _
			        ByVal popupWindowScrollBar As Boolean _
			        ) As Object()
			        ' GetRecordFieldValue gets the pop up window content from the column specified by
			        ' columnName in the record specified by the recordID in data base table specified by tableName.
			        ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
			        ' or replace the call to  GetRecordFieldValue_Base().
			        Return GetRecordFieldValue_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
			    End Function

			    <System.Web.Services.WebMethod()> _
			    Public Shared Function GetImage(ByVal tableName As String, _
			            ByVal recordID As String, _
			            ByVal columnName As String, _
			            ByVal title As String, _
			            ByVal persist As Boolean, _
			            ByVal popupWindowHeight As Integer, _
			            ByVal popupWindowWidth As Integer, _
			            ByVal popupWindowScrollBar As Boolean _
			            ) As Object()
			        ' GetImage gets the Image url for the image in the column "columnName" and
			        ' in the record specified by recordID in data base table specified by tableName.
			        ' Customize by adding code before or after the call to  GetImage_Base()
			        ' or replace the call to  GetImage_Base().
			        Return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
			    End Function


			    Protected Overridable Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
			        ' Handles MyBase.Init. Registers event handler for any button, sort or links.
			        ' You can add additional Init handlers in Section 1.

			    End Sub

			    Protected Overridable Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			        Static previousURL As String = ""
			        Dim URLString As String = Page.Request.RawUrl
			        Dim pageType As String = Page.Request.QueryString("PageType")
			        Dim pageURL As String = Page.Request.QueryString("URL")
			        Dim parameterRequired As String = Page.Request.QueryString("IsParamRequired")
			        Dim tableName As String = Page.Request.QueryString("TableName")
			        Dim isEncrypted As String = Page.Request.QueryString("Encrypted")
			            
			        If Not IsNothing(pageType) AndAlso pageType.Equals("aspx", System.StringComparison.InvariantCultureIgnoreCase) Then
			            'If it is an aspx page the check for the other conditions.
			            If IsNothing(parameterRequired) OrElse parameterRequired.Equals("true", System.StringComparison.InvariantCultureIgnoreCase) Then
			                Try
			                    
			                Catch ex As Exception
			                    Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
			                    Return
			                End Try
			            End If
						
			            If pageURL.Contains(".aspx") Then
			                previousURL = URLString
			            End If
			            Response.Redirect(pageURL)
			        End If
			    End Sub




			    Public Shared Function GetRecordFieldValue_Base(ByVal tableName As String, _
			    ByVal recordID As String, _
			    ByVal columnName As String, _
			    ByVal title As String, _
			    ByVal persist As Boolean, _
			    ByVal popupWindowHeight As Integer, _
			    ByVal popupWindowWidth As Integer, _
			    ByVal popupWindowScrollBar As Boolean _
			    ) As Object()
			        If Not IsNothing(recordID) Then
			            recordID = System.Web.HttpUtility.UrlDecode(recordID)
			        End If
			        Dim content As String = NetUtils.EncodeStringForHtmlDisplay(BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName))
			        'content=(formattedValue)
			        'returnValue is an array of string values.
			        'returnValue(0) represents title of the pop up window
			        'returnValue(1) represents content of the pop up window
			        ' retrunValue(2) represents whether pop up window should be made persistant
			        ' or it should closes as soon as mouse moved out.
			        ' returnValue(5) represents whether pop up window should contain scroll bar.
			        ' returnValue(3), (4) represents pop up window height and width respectivly
			        ' (0),(2),(3),(4) and (5)  is initially set as pass through attribute.
			        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
			        Dim returnValue(6) As Object
			        returnValue(0) = title
			        returnValue(1) = content
			        returnValue(2) = persist
			        returnValue(3) = popupWindowWidth
			        returnValue(4) = popupWindowHeight
			        returnValue(5) = popupWindowScrollBar
			        Return returnValue
			    End Function

			    Public Shared Function GetImage_Base(ByVal tableName As String, _
			    ByVal recordID As String, _
			    ByVal columnName As String, _
			    ByVal title As String, _
			    ByVal persist As Boolean, _
			    ByVal popupWindowHeight As Integer, _
			    ByVal popupWindowWidth As Integer, _
			    ByVal popupWindowScrollBar As Boolean _
			    ) As Object()
			        Dim content As String = "<IMG alt =""" & title & """ src =" & """../Shared/ExportFieldValue.aspx?Table=" & tableName & "&Field=" & columnName & "&Record=" & recordID & """/>"
			        'returnValue is an array of string values.
			        'returnValue(0) represents title of the pop up window.
			        'returnValue(1) represents content ie, image url.
			        ' retrunValue(2) represents whether pop up window should be made persistant
			        ' or it should closes as soon as mouse moved out.
			        ' returnValue(3), (4) represents pop up window height and width respectivly
			        ' returnValue(5) represents whether pop up window should contain scroll bar.
			        ' (0),(2),(3),(4) and (5) is initially set as pass through attribute.
			        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
			        Dim returnValue(6) As Object
			        returnValue(0) = title
			        returnValue(1) = content
			        returnValue(2) = persist
			        returnValue(3) = popupWindowWidth
			        returnValue(4) = popupWindowHeight
			        returnValue(5) = popupWindowScrollBar
			        Return returnValue
			    End Function


			    ' Load data from database into UI controls.
			    ' Modify LoadData in Section 1 above to customize.  Or override DataBind() in
			    ' the individual table and record controls to customize.
			    Public Sub LoadData_Base()
			        Try
			            ' Load data only when displaying the page for the first time
			            If (Not Me.IsPostBack) Then

			                ' Must start a transaction before performing database operations
			                DbUtils.StartTransaction()

			                ' Load data for each record and table UI control.
			                ' Ordering is important because child controls get
			                ' their parent ids from their parent UI controls.


			                Me.DataBind()


			            End If

			        Catch ex As Exception
			            ' An error has occured so display an error message.
			            Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
			        Finally
			            If Not Me.IsPostBack Then
			                ' End database transaction
			                DbUtils.EndTransaction()
			            End If
			        End Try
			    End Sub

			    Protected Overrides Sub UpdateSessionNavigationHistory()
			        'Do nothing
			    End Sub

					</script>


    </head>
	

    <body id="Body1" runat="server" style="margin:0px;  " >

		<form id="Form1" method="post" runat="server"><BaseClasses:ScrollCoordinates id="ScrollCoordinates" runat="server"></BaseClasses:ScrollCoordinates>
			<BaseClasses:BasePageSettings id="PageSettings" runat="server"></BaseClasses:BasePageSettings>
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
					
                    <asp:IncludeComponent runat="server" id="Include"></asp:IncludeComponent>

				</ContentTemplate>
			</asp:UpdatePanel>
			
			<div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
			<asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
		</form>
    </body>
</html>
	
