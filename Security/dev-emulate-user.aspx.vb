﻿
' This file implements the code-behind class for dev_emulate_user.aspx.
' App_Code\dev_emulate_user.Controls.vb contains the Table, Row and Record control classes
' for the page.  Best practices calls for overriding methods in the Row or Record control classes.

#Region "Imports statements"

Option Strict On
Imports System
Imports System.Data
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Utils
Imports BaseClasses.Utils.StringUtils
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports BaseClasses.Data.OrderByItem.OrderDir
Imports BaseClasses.Data.BaseFilter
Imports BaseClasses.Data.BaseFilter.ComparisonOperator
Imports BaseClasses.Web.UI.WebControls
        
Imports ePortalWFApproval.Business
Imports ePortalWFApproval.Data
        

#End Region

  
Namespace ePortalWFApproval.UI
  
Partial Public Class dev_emulate_user
        Inherits BaseApplicationPage
' Code-behind class for the dev_emulate_user page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."
    
      Public Sub SetPageFocus()
            'load scripts to all controls on page so that they will retain focus on PostBack
            Me.LoadFocusScripts(Me.Page)
          'To set focus on page load to a specific control pass this control to the SetStartupFocus method. To get a hold of  a control
          'use FindControlRecursively method. For example:
          'Dim controlToFocus As System.Web.UI.WebControls.TextBox = DirectCast(Me.FindControlRecursively("ProductsSearch"), System.Web.UI.WebControls.TextBox)
          'Me.SetFocusOnLoad(controlToFocus)
          'If no control is passed or control does not exist this method will set focus on the first focusable control on the page.
          Me.SetFocusOnLoad()  
      End Sub
       
      Public Sub LoadData()
          ' LoadData reads database data and assigns it to UI controls.
          ' Customize by adding code before or after the call to LoadData_Base()
          ' or replace the call to LoadData_Base().
          LoadData_Base()
		
            If (Not Me.IsPostBack) Then
                PopulateAssignUser()
                PopulateAssignUserN()
            End If
            litUser.Text = GetUser(System.Web.HttpContext.Current.Session("UserID").ToString())
      End Sub

Protected Sub PopulateAssignUser()
            Dim control As DropDownList = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlUser"), System.Web.UI.WebControls.DropDownList)

            Dim wc As WhereClause = New WhereClause
            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(sel_WASP_UserView.W_U_User_Name, OrderByItem.OrderDir.Asc)

            control.Items.Clear()
            Dim itemValue As sel_WASP_UserRecord
            For Each itemValue In sel_WASP_UserView.GetRecords(wc, orderBy, 0, 2000)
                Dim cvalue As String = Nothing
                Dim fvalue As String = Nothing
                If itemValue.W_U_IDSpecified Then
                    cvalue = itemValue.W_U_ID.ToString()
                    fvalue = itemValue.Format(sel_WASP_UserView.W_U_Full_Name)
                End If

                Dim item As ListItem = New ListItem(fvalue, cvalue)
                control.Items.Add(item)
            Next
        End Sub

        Protected Sub PopulateAssignUserN()
            Dim control1 As DropDownList = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlUser1"), System.Web.UI.WebControls.DropDownList)

            Dim wc As WhereClause = New WhereClause
            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(Sel_WASP_User1View.W_U_User_Name, OrderByItem.OrderDir.Asc)

            control1.Items.Clear()
            Dim itemValue As Sel_WASP_User1Record
            For Each itemValue In Sel_WASP_User1View.GetRecords(wc, orderBy, 0, 2000)
                Dim cvalue As String = Nothing
                Dim fvalue As String = Nothing
                If itemValue.W_U_IDSpecified Then
                    cvalue = itemValue.W_U_ID.ToString()
                    fvalue = itemValue.Format(Sel_WASP_User1View.W_U_Full_Name)
                End If

                Dim item As ListItem = New ListItem(fvalue, cvalue)
                control1.Items.Add(item)
            Next
        End Sub

        Protected Function GetUser(ByVal User_ID As String) As String
            Dim wc As WhereClause = New WhereClause
            wc.iAND(sel_WASP_UserView.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)
            Dim itemValue As sel_WASP_UserRecord
            For Each itemValue In sel_WASP_UserView.GetRecords(wc, Nothing, 0, 3)
                If itemValue.W_U_IDSpecified Then
                    Return itemValue.W_U_Full_Name
                End If
            Next
        End Function
	
		Protected Function GetUserName(ByVal User_ID As String) As String
            Dim wc As WhereClause = New WhereClause
            wc.iAND(sel_WASP_UserView.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)
            Dim itemValue As sel_WASP_UserRecord
            For Each itemValue In sel_WASP_UserView.GetRecords(wc, Nothing, 0, 3)
                If itemValue.W_U_IDSpecified Then
                    Return itemValue.W_U_User_Name
                End If
            Next
        End Function

        Protected Function GetUserN(ByVal User_ID As String) As String
            Dim wc As WhereClause = New WhereClause
            wc.iAND(Sel_WASP_User1View.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)
            Dim itemValue As Sel_WASP_User1Record
            For Each itemValue In Sel_WASP_User1View.GetRecords(wc, Nothing, 0, 3)
                If itemValue.W_U_IDSpecified Then
                    Return itemValue.W_U_Full_Name
                End If
            Next
        End Function

        Protected Function GetUserNameN(ByVal User_ID As String) As String
            Dim wc As WhereClause = New WhereClause
            wc.iAND(Sel_WASP_User1View.W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, User_ID)
            Dim itemValue As Sel_WASP_User1Record
            For Each itemValue In Sel_WASP_User1View.GetRecords(wc, Nothing, 0, 3)
                If itemValue.W_U_IDSpecified Then
                    Return itemValue.W_U_User_Name
                End If
            Next
        End Function
      
      Public Overrides Sub SaveData()
          Me.SaveData_Base()
      End Sub
               Public Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
            'Override call to PreInit_Base() here to change top level master page used by this page, for example uncomment
            'next line to use Microsoft SharePoint default master page
            'If Not Me.Master Is Nothing Then Me.Master.MasterPageFile = Microsoft.SharePoint.SPContext.Current.Web.MasterUrl	
            'You may change here assignment of application theme
            Try
                Me.PreInit_Base()
            Catch ex As Exception
                Try
                    'when running application in Live preview or outside of Microsoft SharePoint environment use proforma top level master.
                    Me.Master.MasterPageFile = "../Master Pages/SharePointMaster.master"
                Catch ex1 As Exception
                End Try
            End Try
        End Sub
	
      
      
#Region "Ajax Functions"

        <System.Web.Services.WebMethod()> _
        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
                                                  ByVal recordID As String, _
                                                  ByVal columnName As String, _
                                                  ByVal fieldName As String, _
                                                  ByVal title As String, _
                                                  ByVal closeBtnText As String, _
                                                  ByVal persist As Boolean, _
                                                  ByVal popupWindowHeight As Integer, _
                                                  ByVal popupWindowWidth As Integer, _
                                                  ByVal popupWindowScrollBar As Boolean _
                                                  ) As Object()
            ' GetRecordFieldValue gets the pop up window content from the column specified by
            ' columnName in the record specified by the recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            ' or replace the call to  GetRecordFieldValue_Base().
            Return GetRecordFieldValue_Base(tableName, recordID, columnName, fieldName, title, closeBtnText, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function

        <System.Web.Services.WebMethod()> _
        Public Shared Function GetImage(ByVal tableName As String, _
                                        ByVal recordID As String, _
                                        ByVal columnName As String, _
                                        ByVal title As String, _
                                        ByVal closeBtnText As String, _
                                        ByVal persist As Boolean, _
                                        ByVal popupWindowHeight As Integer, _
                                        ByVal popupWindowWidth As Integer, _
                                        ByVal popupWindowScrollBar As Boolean _
                                        ) As Object()
            ' GetImage gets the Image url for the image in the column "columnName" and
            ' in the record specified by recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetImage_Base()
            ' or replace the call to  GetImage_Base().
            Return GetImage_Base(tableName, recordID, columnName, title, closeBtnText, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function
    
      Protected Overloads Overrides Sub BasePage_PreRender(ByVal sender As Object, ByVal e As EventArgs)
          MyBase.BasePage_PreRender(sender, e)
          Base_RegisterPostback()
      End Sub
      
    
      


#End Region


	  Public Sub btnEmulate_Click(ByVal sender As Object, ByVal args As EventArgs)
            System.Web.HttpContext.Current.Session("UserID") = ddlUser.SelectedItem.Value.ToString()
            System.Web.HttpContext.Current.Session("UserIDNorth") = ddlUser1.SelectedItem.Value.ToString()

            System.Web.HttpContext.Current.Session("UserName") = GetUserName(System.Web.HttpContext.Current.Session("UserID").ToString())

            litUser.Text = GetUser(System.Web.HttpContext.Current.Session("UserID").ToString())



            btnEmulate_Click_Base(sender, args)
        End Sub
	

    ' Page Event Handlers - buttons, sort, links
    
      Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS as Boolean) As String
          Return EvaluateFormula_Base(formula, dataSourceForEvaluate, format, variables, includeDS)
      End Function

      Public Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. 
            ' Register the Event handler for any Events.
           Me.Page_InitializeEventHandlers_Base(sender,e)
      End Sub
      
        Protected Overrides Sub SaveControlsToSession()
            SaveControlsToSession_Base()
        End Sub


        Protected Overrides Sub ClearControlsFromSession()
            ClearControlsFromSession_Base()
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            LoadViewState_Base(savedState)
        End Sub


        Protected Overrides Function SaveViewState() As Object
            Return SaveViewState_Base()
        End Function
      
      Public Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
          Me.Page_PreRender_Base(sender,e)
      End Sub


      
               

      Public Overrides Sub SetControl(ByVal control As String)
          Me.SetControl_Base(control)
      End Sub    
      
            

        ' Write out the Set methods
        
        Public Sub SetbtnEmulate()
            SetbtnEmulate_Base() 
        End Sub              
                         
        
        ' Write out the methods for DataSource
        
   

#End Region

#Region "Section 2: Do not modify this section."

        Protected Sub Page_InitializeEventHandlers_Base(ByVal sender As Object, ByVal e As System.EventArgs)            		
           
            ' This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
            'include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
            If Not String.IsNullOrEmpty(Me.Enctype) Then Me.Page.Form.Enctype = Me.Enctype
          
            ' Register the Event handler for any Events.
      

          ' Setup the pagination events.
        
              AddHandler Me.btnEmulate.Button.Click, AddressOf btnEmulate_Click
                        
          Me.ClearControlsFromSession()
    
          System.Web.HttpContext.Current.Session("isd_geo_location") = "<location><error>LOCATION_ERROR_DISABLED</error></location>"
    
          Dim Include As System.Web.UI.HtmlControls.HtmlGenericControl = New System.Web.UI.HtmlControls.HtmlGenericControl("script")
          Include.Attributes.Add("type", "text/javascript")
          Include.InnerHtml = "var IsInfinitePage = true; var sessvar = ""is_loaded"";if (window.frameElement != null) {sessvar = ""is_loaded"" +window.frameElement.id;}var iframeName = """";var bolea = ""False"";if(window.frameElement != null){iframeName =window.frameElement.id;}if(iframeName.indexOf(""Infiniteframe"") == -1){bolea = ""True"";}if (bolea == ""True"") {if(!sessionStorage.getItem(sessvar) || sessionStorage.getItem(sessvar) == ""False"") {sessionStorage.setItem(sessvar, ""True"");}else {var htmlurl = window.location.href; if(htmlurl.indexOf(""?InfiIframe"") != -1){htmlurl = htmlurl.replace(""?InfiIframe"","""");}else{if(htmlurl.indexOf(""&InfiIframe"") != -1){htmlurl = htmlurl.replace(""&InfiIframe"", """");}} window.location.href =htmlurl;if (navigator.appName == 'Microsoft Internet Explorer'){window.location.href = htmlurl;}sessionStorage.setItem(sessvar, ""False"");}}else{if (bolea == ""False"") {window.alert = function() {};}}"
          Include.ID = "InfiScript"
          Me.Page.Header.Controls.Add(Include)
    
        End Sub

        Private Sub Base_RegisterPostback()
        
              Me.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"btnEmulate"))
                        
        End Sub

    

       ' Handles MyBase.Load.  Read database data and put into the UI controls.
       ' If you need to, you can add additional Load handlers in Section 1.
       Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
           If Me.FindControlRecursively("Infiniteframe") Is Nothing Then
                Dim RmvControl As Control = Me.FindControlRecursively("InfiScript")
                Me.Page.Header.Controls.Remove(RmvControl)
           End If
           
           Me.SetPageFocus()
           
            ' Check if user has access to this page.  Redirects to either sign-in page
            ' or 'no access' page if not. Does not do anything if role-based security
            ' is not turned on, but you can override to add your own security.
            Me.Authorize("")
    
            If (Not Me.IsPostBack) Then
            
                ' Setup the header text for the validation summary control.
                Me.ValidationSummary1.HeaderText = GetResourceValue("ValidationSummaryHeaderText", "ePortalWFApproval")
              
            End If
           
            ' Load data only when displaying the page for the first time or if postback from child window
            If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack" OrElse ( Me.Request("__EVENTTARGET") = "isd_geo_location")) Then
                ' Read the data for all controls on the page.
                ' To change the behavior, override the DataBind method for the individual
                ' record or table UI controls.
                Me.LoadData()
            End If
        
        
            Page.Title = "Admin: Emulate User"
        If Not IsPostBack Then
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "PopupScript", "openPopupPage('QPageSize');", True)
        End If
    

    End Sub

    Public Shared Function GetRecordFieldValue_Base(ByVal tableName As String, _
                ByVal recordID As String, _
                ByVal columnName As String, _
                ByVal fieldName As String, _
                ByVal title As String, _
                ByVal closeBtnText As String, _
                ByVal persist As Boolean, _
                ByVal popupWindowHeight As Integer, _
                ByVal popupWindowWidth As Integer, _
                ByVal popupWindowScrollBar As Boolean _
                ) As Object()
        If Not IsNothing(recordID) Then
            recordID = System.Web.HttpUtility.UrlDecode(recordID)
        End If
        Dim content as String = BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName)
    
        content = NetUtils.EncodeStringForHtmlDisplay(content)

        ' returnValue is an array of string values.
        ' returnValue(0) represents title of the pop up window.
        ' returnValue(1) represents the tooltip of the close button.
        ' returnValue(2) represents content of the text.
        ' returnValue(3) represents whether pop up window should be made persistant
        ' or it should close as soon as mouse moves out.
        ' returnValue(4), (5) represents pop up window height and width respectivly
        ' returnValue(6) represents whether pop up window should contain scroll bar.
        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        Dim returnValue(6) As Object
        returnValue(0) = title
        returnValue(1) = closeBtnText
        returnValue(2) = content
        returnValue(3) = persist
        returnValue(4) = popupWindowWidth
        returnValue(5) = popupWindowHeight
        returnValue(6) = popupWindowScrollBar
        Return returnValue
    End Function


    Public Shared Function GetImage_Base(ByVal tableName As String, _
                                    ByVal recordID As String, _
                                    ByVal columnName As String, _
                                    ByVal title As String, _
                                    ByVal closeBtnText As String, _
                                    ByVal persist As Boolean, _
                                    ByVal popupWindowHeight As Integer, _
                                    ByVal popupWindowWidth As Integer, _
                                    ByVal popupWindowScrollBar As Boolean _
                                    ) As Object()
        Dim content As String = "<IMG alt =""" & title & """ src =" & """../Shared/ExportFieldValue.aspx?Table=" & tableName & "&Field=" & columnName & "&Record=" & recordID & """/>"
        ' returnValue is an array of string values.
        ' returnValue(0) represents title of the pop up window.
        ' returnValue(1) represents the tooltip of the close button.
        ' returnValue(2) represents content ie, image url.
        ' returnValue(3) represents whether pop up window should be made persistant
        ' or it should close as soon as mouse moves out.
        ' returnValue(4), (5) represents pop up window height and width respectivly
        ' returnValue(6) represents whether pop up window should contain scroll bar.
        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        Dim returnValue(7) As Object
        returnValue(0) = title
        returnValue(1) = closeBtnText
        returnValue(2) = content
        returnValue(3) = persist
        returnValue(4) = popupWindowWidth
        returnValue(5) = popupWindowHeight
        returnValue(6) = popupWindowScrollBar
        Return returnValue
    End Function
        
      Public Sub SetControl_Base(ByVal control As String)
          ' Load data for each record and table UI control.
        
      End Sub          


    
      
      Public Sub SaveData_Base()
      
      End Sub
      
      

    
    
        Protected Sub SaveControlsToSession_Base()
            MyBase.SaveControlsToSession()
        
        End Sub


        Protected Sub ClearControlsFromSession_Base()
            MyBase.ClearControlsFromSession()
        
        End Sub

        Protected Sub LoadViewState_Base(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
        
        End Sub


        Protected Function SaveViewState_Base() As Object
            
            Return MyBase.SaveViewState()
        End Function


      Public Sub PreInit_Base()
      'If it is SharePoint application this function performs dynamic Master Page assignment.
      
            ' if url parameter specified a master apge, load it here

            
            If DirectCast(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle")  = "Popup" Then
                Dim masterPage As String = "../Master Pages/Popup.master"      
                Me.Page.MasterPageFile = masterPage
            End If            
            
            If DirectCast(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle")  = "NewWindow" Then
                Dim masterPage As String = "../Master Pages/Blank.master"      
                Me.Page.MasterPageFile = masterPage
            End If                        
            
            If Me.Page.Request("MasterPage") <> "" Then
                Dim masterPage As String = DirectCast(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("MasterPage")          
                Me.Page.MasterPageFile = masterPage
            End If         
                  
    
      End Sub
      
      Public Sub Page_PreRender_Base(ByVal sender As Object, ByVal e As System.EventArgs)
     
          If DirectCast(Me.Page, BaseApplicationPage).GetDecryptedURLParameter("RedirectStyle")  = "Popup" Then
              AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "QPopupCreateHeader", "QPopupCreateHeader();", True)
          End If
          
    
            ' Load data for each record and table UI control.
                  
            ' Data bind for each chart UI control.
              
      End Sub  
      
        
        ' Load data from database into UI controls.
        ' Modify LoadData in Section 1 above to customize.  Or override DataBind() in
        ' the individual table and record controls to customize.
        Public Sub LoadData_Base()
            Try
              
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack" OrElse ( Me.Request("__EVENTTARGET") = "isd_geo_location"))  Then
                    ' Must start a transaction before performing database operations
                    DbUtils.StartTransaction()
                End If


     
                Me.DataBind()
                
                    
    
                ' Load and bind data for each record and table UI control.
                
    
                ' Load data for chart.
                
            
                ' initialize aspx controls
                
                SetbtnEmulate()
              
                

            Catch ex As Exception
                ' An error has occured so display an error message.
                Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
            Finally
                If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack" OrElse ( Me.Request("__EVENTTARGET") = "isd_geo_location"))  Then
                    ' End database transaction
                      DbUtils.EndTransaction()
                End If
            End Try
        End Sub
        
        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)
        
        Public Overridable Function EvaluateFormula_Base(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End If

            
            e.CallingControl = Me

            e.DataSource = dataSourceForEvaluate


            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If

            If Not String.IsNullOrEmpty(format) AndAlso (String.IsNullOrEmpty(formula) OrElse formula.IndexOf("Format(") < 0) Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function      
        
        Public Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
          Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True)
        End Function


        Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
          Return EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True)
        End Function

        Public Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
          Return EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS)
        End Function

        Public Function EvaluateFormula(ByVal formula As String) As String
          Return EvaluateFormula(formula, Nothing, Nothing, Nothing, True)
        End Function
 
        

        ' Write out the Set methods
        
        Public Sub SetbtnEmulate_Base()                
              
   
        End Sub
                

        ' Write out the DataSource properties and methods
                

        ' Write out event methods for the page events
        
        ' event handler for Button
        Public Sub btnEmulate_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
            
    
#End Region

  
End Class
  
End Namespace
  