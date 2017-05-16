
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' WFIN_Approver_Table1.aspx page.  The Row or RecordControl classes are the 
' ideal place to add code customizations. For example, you can override the LoadData, 
' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#Region "Imports statements"

Option Strict On
Imports Microsoft.VisualBasic
Imports BaseClasses.Web.UI.WebControls
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Web.Script.Serialization
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Utils
Imports ReportTools.ReportCreator
Imports ReportTools.Shared

  
        
Imports ePortalWFApproval.Business
Imports ePortalWFApproval.Data
Imports ePortalWFApproval.UI
        

#End Region

  
Namespace ePortalWFApproval.UI.Controls.WFIN_Approver_Table1

#Region "Section 1: Place your customizations here."





    Public Class WFinRep_Activity1TableControl
        Inherits BaseWFinRep_Activity1TableControl

        ' The BaseWFinRep_Activity1TableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WFinRep_Activity1TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    End Class
    Public Class WFinRep_Activity1TableControlRow
        Inherits BaseWFinRep_Activity1TableControlRow
        ' The BaseWFinRep_Activity1TableControlRow implements code for a ROW within the
        ' the WFinRep_Activity1TableControl table.  The BaseWFinRep_Activity1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_Activity1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.


    End Class
    Public Class Sel_WFIN_ApproverPageTableControl
        Inherits BaseSel_WFIN_ApproverPageTableControl

        ' The BaseSel_WFIN_ApproverPageTableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The Sel_WFIN_ApproverPageTableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            Sel_WFIN_ApproverPage1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.


            If IsValueSelected(Me.AFIN_StatusFilter1) Then

                wc.iAND(Sel_WFIN_ApproverPage1View.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.AFIN_StatusFilter1, Me.GetFromSession(Me.AFIN_StatusFilter1)), False, False)

            End If

            If IsValueSelected(Me.HFIN_C_IDFilter1) Then

                wc.iAND(Sel_WFIN_ApproverPage1View.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_C_IDFilter1, Me.GetFromSession(Me.HFIN_C_IDFilter1)), False, False)

            End If

            wc.iAND("HFIN_ID in (SELECT AFIN_HFIN_ID FROM dbo.WFinRep_Activity WHERE (AFIN_Status = 4) AND (AFIN_W_U_ID = " & System.Web.HttpContext.Current.Session("UserIDNorth").ToString() & "))")

            Dim bAnyFiltersChanged As Boolean = False

            If IsValueSelected(Me.AFIN_StatusFilter1) OrElse Me.InSession(Me.AFIN_StatusFilter1) Then
                bAnyFiltersChanged = True
            End If

            If IsValueSelected(Me.HFIN_C_IDFilter1) OrElse Me.InSession(Me.HFIN_C_IDFilter1) Then
                bAnyFiltersChanged = True
            End If

            If Not (bAnyFiltersChanged) Then
                wc.RunQuery = False
            End If

            Return wc
        End Function

        Protected Overrides Sub PopulateHFIN_C_IDFilter1(ByVal selectedValue As String, ByVal maxItems As Integer)

            Dim wc As WhereClause = New WhereClause
            wc.iAND(Sel_W_User_DYNAMICS_Company1View.W_U_User_Name, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString())


            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(Sel_W_User_DYNAMICS_Company1View.Company_ID, BaseClasses.Data.OrderByItem.OrderDir.Asc)

            Me.HFIN_C_IDFilter1.Items.Clear()
            Dim itemValue As Sel_W_User_DYNAMICS_Company1Record
            For Each itemValue In Sel_W_User_DYNAMICS_Company1View.GetRecords(wc, orderBy, 0, maxItems)

                ' Create the item and add to the list.
                Dim cvalue As String = itemValue.Company_ID.ToString()
                Dim fvalue As String = itemValue.Format(Sel_W_User_DYNAMICS_Company1View.Company_Short_Name)
                Dim item As ListItem = New ListItem(fvalue, cvalue)
                Me.HFIN_C_IDFilter1.Items.Add(item)
            Next

            ' Set up the selected item.
            If Not selectedValue Is Nothing AndAlso _
            selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.HFIN_C_IDFilter1, selectedValue) Then
                Dim fvalue As String = WFinRep_DocAttach1Table.FIN_Company.Format(selectedValue)
                Dim item As ListItem = New ListItem(fvalue, selectedValue)
                item.Selected = True
                Me.HFIN_C_IDFilter1.Items.Insert(0, item)
            End If


        End Sub

        Protected Overrides Sub PopulateAFIN_StatusFilter1( _
                              ByVal selectedValue As String, _
                              ByVal maxItems As Integer)

            Dim wc As WhereClause = New WhereClause
            wc.iAND(WPO_ApprovalStatus1Table.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "4")
            wc.iOR(WPO_ApprovalStatus1Table.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "6")
            wc.iOR(WPO_ApprovalStatus1Table.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "7")


            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(WPO_ApprovalStatusTable.WPO_STAT_CD, BaseClasses.Data.OrderByItem.OrderDir.Asc)

            Me.AFIN_StatusFilter1.Items.Clear()
            Dim itemValue As WPO_ApprovalStatus1Record

            For Each itemValue In WPO_ApprovalStatus1Table.GetRecords(wc, orderBy, 0, maxItems)
                Dim cvalue As String = itemValue.WPO_STAT_CD.ToString()
                Dim fvalue As String = itemValue.Format(WPO_ApprovalStatus1Table.WPO_STAT_DESC)
                Dim item As ListItem = New ListItem(fvalue, cvalue)
                Me.AFIN_StatusFilter1.Items.Add(item)
            Next

            If Not selectedValue Is Nothing AndAlso _
            selectedValue.Trim <> "" AndAlso _
             Not SetSelectedValue(Me.AFIN_StatusFilter1, selectedValue) Then
                Dim fvalue As String = WPO_ApprovalStatus1Table.WPO_STAT_CD.Format(selectedValue)
                Dim item As ListItem = New ListItem(fvalue, selectedValue)
                item.Selected = True
                Me.AFIN_StatusFilter1.Items.Insert(0, item)
            End If

            ''Me.AFIN_StatusFilter1.SelectedValue = "4"

        End Sub
    End Class
    Public Class Sel_WFIN_ApproverPageTableControlRow
        Inherits BaseSel_WFIN_ApproverPageTableControlRow
        ' The BaseSel_WFIN_ApproverPageTableControlRow implements code for a ROW within the
        ' the Sel_WFIN_ApproverPageTableControl table.  The BaseSel_WFIN_ApproverPageTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Sel_WFIN_ApproverPageTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.




        Public Overrides Sub SetFIN_Month()


            ' Set the FIN_Month Literal on the webpage with value from the
            ' sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.FIN_Month is the ASP:Literal on the webpage.

            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Month()
            ' and add your own code before or after the call to the MyBase function.



            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_MonthSpecified Then

                ' If the FIN_Month is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month)

                formattedValue = HttpUtility.HtmlEncode(formattedValue)


                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "1" Then formattedValue = "January"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "2" Then formattedValue = "February"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "3" Then formattedValue = "March"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "4" Then formattedValue = "April"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "5" Then formattedValue = "May"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "6" Then formattedValue = "June"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "7" Then formattedValue = "July"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "8" Then formattedValue = "August"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "9" Then formattedValue = "September"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "10" Then formattedValue = "October"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "11" Then formattedValue = "November"
                If Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month).tostring = "12" Then formattedValue = "December"
                Me.FIN_Month.Text = formattedValue

            Else

                ' FIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.

                Me.FIN_Month.Text = Sel_WFIN_ApproverPage1View.FIN_Month.Format(Sel_WFIN_ApproverPage1View.FIN_Month.DefaultValue)

            End If

            ' If the FIN_Month is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Month.Text Is Nothing _
                OrElse Me.FIN_Month.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Month.Text = "&nbsp;"
            End If

        End Sub

        Public Overrides Sub imbWFEdit_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
            'JESSY
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.


            Dim url As String = "../WFinRep_Head1/WFin-ApproverPage1.aspx?WFinRep_Head=" & Me.HFIN_ID.Text '{Sel_WFIN_ApproverPageTableControlRow:PK}"

            If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")

            Dim shouldRedirect As Boolean = True
            Dim target As String = ""

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                url = Me.ModifyRedirectUrl(url, "", True)
                url = Me.Page.ModifyRedirectUrl(url, "", True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)

            End If
        End Sub
    End Class
#End Region



#Region "Section 2: Do not modify this section."
    
    
' Base class for the Sel_WFIN_ApproverPageTableControlRow control on the WFIN_Approver_Table1 page.
' Do not modify this class. Instead override any method in Sel_WFIN_ApproverPageTableControlRow.
Public Class BaseSel_WFIN_ApproverPageTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_WFIN_ApproverPageTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in Sel_WFIN_ApproverPageTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.imbWFEdit.Click, AddressOf imbWFEdit_Click
                        
              AddHandler Me.Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Click, AddressOf Sel_WFIN_ApproverPageRowExpandCollapseRowButton_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Sel_WFIN_ApproverPage1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSel_WFIN_ApproverPageTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Sel_WFIN_ApproverPage1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_WFIN_ApproverPageTableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()
            Me.ClearControlsFromSession()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
              
                Return
            End If
             
   
            'LoadData for DataSource for chart and report if they exist
          
            ' Store the checksum. The checksum is used to
            ' ensure the record was not changed by another user.
            If Not Me.DataSource.GetCheckSumValue() Is Nothing
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If
            
      
      
            ' Call the Set methods for each controls on the panel
        
                SetAFIN_Date_Action()
                SetAFIN_Date_Assign()
                SetAFIN_FinID()
                SetAFIN_Status()
                SetAFIN_WDT_ID()
                SetAppHistContain()
                SetFIn_Description()
                SetFIN_Month()
                SetFIN_Year()
                SetHFIN_ID()
                
                
                
                SetimbWFEdit()
              
                SetSel_WFIN_ApproverPageRowExpandCollapseRowButton()
              
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                If Me.DataSource.GetID IsNot Nothing Then
                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If
                
            End If
            
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                      
        SetWFinRep_Activity1TableControl()
        
        End Sub
        
        
        Public Overridable Sub SetAFIN_Date_Action()

                  
            
        
            ' Set the AFIN_Date_Action Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.AFIN_Date_Action is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_ActionSpecified Then
                				
                ' If the AFIN_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.AFIN_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Action.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Action.Text = Sel_WFIN_ApproverPage1View.AFIN_Date_Action.Format(Sel_WFIN_ApproverPage1View.AFIN_Date_Action.DefaultValue, "g")
                        		
                End If
                 
            ' If the AFIN_Date_Action is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Date_Action.Text Is Nothing _
                OrElse Me.AFIN_Date_Action.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Date_Action.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Date_Assign()

                  
            
        
            ' Set the AFIN_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.AFIN_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_AssignSpecified Then
                				
                ' If the AFIN_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.AFIN_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Assign.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Assign.Text = Sel_WFIN_ApproverPage1View.AFIN_Date_Assign.Format(Sel_WFIN_ApproverPage1View.AFIN_Date_Assign.DefaultValue, "g")
                        		
                End If
                 
            ' If the AFIN_Date_Assign is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Date_Assign.Text Is Nothing _
                OrElse Me.AFIN_Date_Assign.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Date_Assign.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_FinID()

                  
            
        
            ' Set the AFIN_FinID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.AFIN_FinID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_FinID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_FinIDSpecified Then
                				
                ' If the AFIN_FinID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.AFIN_FinID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_FinID.Text = formattedValue
                
            Else 
            
                ' AFIN_FinID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_FinID.Text = Sel_WFIN_ApproverPage1View.AFIN_FinID.Format(Sel_WFIN_ApproverPage1View.AFIN_FinID.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_FinID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_FinID.Text Is Nothing _
                OrElse Me.AFIN_FinID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_FinID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Status()

                  
            
        
            ' Set the AFIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.AFIN_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_StatusSpecified Then
                				
                ' If the AFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WFIN_ApproverPage1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WFIN_ApproverPage1View.AFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WFIN_ApproverPage1View.AFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WFIN_ApproverPage1View.GetDFKA(Me.DataSource.AFIN_Status.ToString(),Sel_WFIN_ApproverPage1View.AFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.AFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Status.Text = formattedValue
                
            Else 
            
                ' AFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Status.Text = Sel_WFIN_ApproverPage1View.AFIN_Status.Format(Sel_WFIN_ApproverPage1View.AFIN_Status.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Status.Text Is Nothing _
                OrElse Me.AFIN_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_WDT_ID()

                  
            
        
            ' Set the AFIN_WDT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.AFIN_WDT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_WDT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_WDT_IDSpecified Then
                				
                ' If the AFIN_WDT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WFIN_ApproverPage1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WFIN_ApproverPage1View.AFIN_WDT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WFIN_ApproverPage1View.AFIN_WDT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WFIN_ApproverPage1View.GetDFKA(Me.DataSource.AFIN_WDT_ID.ToString(),Sel_WFIN_ApproverPage1View.AFIN_WDT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.AFIN_WDT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_WDT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_WDT_ID.Text = formattedValue
                
            Else 
            
                ' AFIN_WDT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_WDT_ID.Text = Sel_WFIN_ApproverPage1View.AFIN_WDT_ID.Format(Sel_WFIN_ApproverPage1View.AFIN_WDT_ID.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_WDT_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_WDT_ID.Text Is Nothing _
                OrElse Me.AFIN_WDT_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_WDT_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIn_Description()

                  
            
        
            ' Set the FIn_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.FIn_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIn_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIn_DescriptionSpecified Then
                				
                ' If the FIn_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIn_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIn_Description.Text = formattedValue
                
            Else 
            
                ' FIn_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIn_Description.Text = Sel_WFIN_ApproverPage1View.FIn_Description.Format(Sel_WFIN_ApproverPage1View.FIn_Description.DefaultValue)
                        		
                End If
                 
            ' If the FIn_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIn_Description.Text Is Nothing _
                OrElse Me.FIn_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIn_Description.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Month()

                  
            
        
            ' Set the FIN_Month Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.FIN_Month is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_MonthSpecified Then
                				
                ' If the FIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WFIN_ApproverPage1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WFIN_ApproverPage1View.FIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WFIN_ApproverPage1View.FIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WFIN_ApproverPage1View.GetDFKA(Me.DataSource.FIN_Month.ToString(),Sel_WFIN_ApproverPage1View.FIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Month.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Month.Text = formattedValue
                
            Else 
            
                ' FIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Month.Text = Sel_WFIN_ApproverPage1View.FIN_Month.Format(Sel_WFIN_ApproverPage1View.FIN_Month.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Month is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Month.Text Is Nothing _
                OrElse Me.FIN_Month.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Month.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Year()

                  
            
        
            ' Set the FIN_Year Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.FIN_Year is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_YearSpecified Then
                				
                ' If the FIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.FIN_Year)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Year.Text = formattedValue
                
            Else 
            
                ' FIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Year.Text = Sel_WFIN_ApproverPage1View.FIN_Year.Format(Sel_WFIN_ApproverPage1View.FIN_Year.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Year is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Year.Text Is Nothing _
                OrElse Me.FIN_Year.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Year.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_ID()

                  
            
        
            ' Set the HFIN_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WFIN_ApproverPage record retrieved from the database.
            ' Me.HFIN_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_IDSpecified Then
                				
                ' If the HFIN_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WFIN_ApproverPage1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WFIN_ApproverPage1View.HFIN_ID)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WFIN_ApproverPage1View.HFIN_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WFIN_ApproverPage1View.GetDFKA(Me.DataSource.HFIN_ID.ToString(),Sel_WFIN_ApproverPage1View.HFIN_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WFIN_ApproverPage1View.HFIN_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_ID.Text = Sel_WFIN_ApproverPage1View.HFIN_ID.Format(Sel_WFIN_ApproverPage1View.HFIN_ID.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_ID.Text Is Nothing _
                OrElse Me.HFIN_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAppHistContain()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "AppHistContain").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "AppHistContain").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetWFinRep_Activity1TableControl()           
        
        
            If WFinRep_Activity1TableControl.Visible Then
                WFinRep_Activity1TableControl.LoadData()
                WFinRep_Activity1TableControl.DataBind()
            End If
        End Sub        
      

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e As FormulaEvaluator) As String
            If e Is Nothing Then
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()

            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End IF
            
            
            ' Other variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then

                e.DataSource = Me.DataSource

            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

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
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()       
        
        
        End Sub

      
        
        ' To customize, override this method in Sel_WFIN_ApproverPageTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "ePortalWFApproval"))
                End If
            End If
        
              
            ' 2. Perform any custom validation.
            Me.Validate()

            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "Sel_WFIN_ApproverPageTableControl"), Sel_WFIN_ApproverPageTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Sel_WFIN_ApproverPageTableControl"), Sel_WFIN_ApproverPageTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recWFinRep_Activity1TableControl as WFinRep_Activity1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl)
        recWFinRep_Activity1TableControl.SaveData()
          
        End Sub

        ' To customize, override this method in Sel_WFIN_ApproverPageTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetAFIN_Date_Action()
            GetAFIN_Date_Assign()
            GetAFIN_FinID()
            GetAFIN_Status()
            GetAFIN_WDT_ID()
            GetFIn_Description()
            GetFIN_Month()
            GetFIN_Year()
            GetHFIN_ID()
        End Sub
        
        
        Public Overridable Sub GetAFIN_Date_Action()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Date_Assign()
            
        End Sub
                
        Public Overridable Sub GetAFIN_FinID()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Status()
            
        End Sub
                
        Public Overridable Sub GetAFIN_WDT_ID()
            
        End Sub
                
        Public Overridable Sub GetFIn_Description()
            
        End Sub
                
        Public Overridable Sub GetFIN_Month()
            
        End Sub
                
        Public Overridable Sub GetFIN_Year()
            
        End Sub
                
        Public Overridable Sub GetHFIN_ID()
            
        End Sub
                
      
        ' To customize, override this method in Sel_WFIN_ApproverPageTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WFIN_ApproverPageTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in Sel_WFIN_ApproverPageTableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          Sel_WFIN_ApproverPage1View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Sel_WFIN_ApproverPageTableControl"), Sel_WFIN_ApproverPageTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Sel_WFIN_ApproverPageTableControl"), Sel_WFIN_ApproverPageTableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                                
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
            
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()
        
    
            'Save pagination state to session.
          
        End Sub
        
        
    
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

        

            ' Clear pagination state from session.
        
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
    
            ' Load view state for pagination control.
                 
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
    
            ' Load view state for pagination control.
                  
            Return MyBase.SaveViewState()
        End Function
        
        
    
        ' Generate set method for buttons
        
        Public Overridable Sub SetimbWFEdit()                
              
   
        End Sub
            
        Public Overridable Sub SetSel_WFIN_ApproverPageRowExpandCollapseRowButton()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub imbWFEdit_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WFinRep_Head1/WFin-ApproverPage1.aspx?WFinRep_Head={Sel_WFIN_ApproverPageTableControlRow:PK}"
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "&RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
        Dim shouldRedirect As Boolean = True
        Dim target As String = ""
      
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",True)
            url = Me.Page.ModifyRedirectUrl(url, "",True)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
      Me.Page.Response.Redirect(url)
        
            End If
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Sel_WFIN_ApproverPageRowExpandCollapseRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
          Dim panelControl as Sel_WFIN_ApproverPageTableControl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WFIN_ApproverPageTableControl"), Sel_WFIN_ApproverPageTableControl)

          Dim repeatedRows() as Sel_WFIN_ApproverPageTableControlRow = panelControl.GetRecordControls()
          For Each repeatedRow as Sel_WFIN_ApproverPageTableControlRow in repeatedRows
              Dim altRow as System.Web.UI.Control= DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "Sel_WFIN_ApproverPageTableControlAltRow"), System.Web.UI.Control)
              If (altRow IsNot Nothing) Then
                  If (sender Is repeatedRow.Sel_WFIN_ApproverPageRowExpandCollapseRowButton) Then
                      altRow.Visible = Not altRow.Visible
                  
                  End If                      
                  If (altRow.Visible) Then        
                   
                     repeatedRow.Sel_WFIN_ApproverPageRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                     repeatedRow.Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Attributes.Add("onmouseover", "")
                     repeatedRow.Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Attributes.Add("onmouseout", "")
                                     
                  Else
                   
                     repeatedRow.Sel_WFIN_ApproverPageRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                     repeatedRow.Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Attributes.Add("onmouseover", "")
                     repeatedRow.Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Attributes.Add("onmouseout", "")
                   
                  End If
              Else
                  Me.Page.Response.Redirect("../Shared/ConfigureCollapseExpandRowBtn.aspx")
              End If
          Next
          
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   

        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseSel_WFIN_ApproverPageTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSel_WFIN_ApproverPageTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As Sel_WFIN_ApproverPage1Record
            Get
                Return DirectCast(MyBase._DataSource, Sel_WFIN_ApproverPage1Record)
            End Get
            Set(ByVal value As Sel_WFIN_ApproverPage1Record)
                Me._DataSource = value
            End Set
        End Property

        
        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property AFIN_Date_Action() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_Action"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Date_Assign() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_Assign"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_FinID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_FinID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_WDT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WDT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AppHistContain() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AppHistContain"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property FIn_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIn_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_Month() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Month"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_Year() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Year"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property imbWFEdit() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbWFEdit"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Sel_WFIN_ApproverPageRowExpandCollapseRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WFIN_ApproverPageRowExpandCollapseRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_Activity1TableControl() As WFinRep_Activity1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
        
        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Sel_WFIN_ApproverPage1Record = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean,ByVal includeSession as Boolean) As String
            
            Dim rec As Sel_WFIN_ApproverPage1Record = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            If includeSession  Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt,False)  
            End If
        End Function

         
        Public Overridable Function GetRecord() As Sel_WFIN_ApproverPage1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Sel_WFIN_ApproverPage1View.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Throw New Exception(Page.GetResourceValue("Err:RetrieveRec", "ePortalWFApproval"))
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the Sel_WFIN_ApproverPageTableControl control on the WFIN_Approver_Table1 page.
' Do not modify this class. Instead override any method in Sel_WFIN_ApproverPageTableControl.
Public Class BaseSel_WFIN_ApproverPageTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.AFIN_StatusFilter1) 				
                    initialVal = Me.GetFromSession(Me.AFIN_StatusFilter1)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""AFIN_Status"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.AFIN_StatusFilter1.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.AFIN_StatusFilter1.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HFIN_C_IDFilter1) 				
                    initialVal = Me.GetFromSession(Me.HFIN_C_IDFilter1)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""HFIN_C_ID"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.HFIN_C_IDFilter1.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.HFIN_C_IDFilter1.SelectedValue = initialVal
                            
                    End If
                
            End If

      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
         
            Else
                   
                Me.CurrentSortOrder = New OrderBy(True, False)
            
        End If

    

    ' Setup default pagination settings.
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
        
            
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.Sel_WFIN_ApproverPagePagination.FirstPage.Click, AddressOf Sel_WFIN_ApproverPagePagination_FirstPage_Click
                        
              AddHandler Me.Sel_WFIN_ApproverPagePagination.LastPage.Click, AddressOf Sel_WFIN_ApproverPagePagination_LastPage_Click
                        
              AddHandler Me.Sel_WFIN_ApproverPagePagination.NextPage.Click, AddressOf Sel_WFIN_ApproverPagePagination_NextPage_Click
                        
              AddHandler Me.Sel_WFIN_ApproverPagePagination.PageSizeButton.Click, AddressOf Sel_WFIN_ApproverPagePagination_PageSizeButton_Click
                        
              AddHandler Me.Sel_WFIN_ApproverPagePagination.PreviousPage.Click, AddressOf Sel_WFIN_ApproverPagePagination_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.Sel_WFIN_ApproverPageSearchButton.Button.Click, AddressOf Sel_WFIN_ApproverPageSearchButton_Click
                        
              AddHandler Me.AFIN_StatusFilter1.SelectedIndexChanged, AddressOf AFIN_StatusFilter1_SelectedIndexChanged
            
              AddHandler Me.HFIN_C_IDFilter1.SelectedIndexChanged, AddressOf HFIN_C_IDFilter1_SelectedIndexChanged
                    
        
          ' Setup events for others
                
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_WFIN_ApproverPage1Record)), Sel_WFIN_ApproverPage1Record())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As Sel_WFIN_ApproverPageTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_WFIN_ApproverPage1Record)), Sel_WFIN_ApproverPage1Record())
                Else  ' Get the records from the database	
                      
                        Me.DataSource = GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                       

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        Public Overridable Function GetRecords( _
            ByVal join As BaseFilter, _
            ByVal where As WhereClause, _
            ByVal orderBy As OrderBy, _
            ByVal pageIndex As Integer, _
            ByVal pageSize As Integer) As Sel_WFIN_ApproverPage1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WFIN_ApproverPage1View.Column1, True)         
            ' selCols.Add(Sel_WFIN_ApproverPage1View.Column2, True)          
            ' selCols.Add(Sel_WFIN_ApproverPage1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return Sel_WFIN_ApproverPage1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New Sel_WFIN_ApproverPage1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Sel_WFIN_ApproverPage1Record)), Sel_WFIN_ApproverPage1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WFIN_ApproverPage1View.Column1, True)         
            ' selCols.Add(Sel_WFIN_ApproverPage1View.Column2, True)          
            ' selCols.Add(Sel_WFIN_ApproverPage1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return Sel_WFIN_ApproverPage1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Sel_WFIN_ApproverPage1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)           
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
                
                Return CInt(databaseTable.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
            End If

        End Function        
        
      
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            
              MyBase.DataBind()
            
    
            Me.ClearControlsFromSession()    

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      

    
        
          ' Bind the repeater with the list of records to expand the UI.
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WFIN_ApproverPageTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As Sel_WFIN_ApproverPageTableControlRow = DirectCast(repItem.FindControl("Sel_WFIN_ApproverPageTableControlRow"), Sel_WFIN_ApproverPageTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetAFIN_Date_ActionLabel()
                SetAFIN_Date_AssignLabel()
                SetAFIN_StatusFilter1()
                SetAFIN_StatusLabel()
                SetAFIN_StatusLabel1()
                SetAFIN_WDT_IDLabel()
                
                SetFIn_DescriptionLabel()
                SetFIN_MonthLabel()
                SetFIN_YearLabel()
                SetHFIN_C_IDFilter1()
                SetHFIN_C_IDLabel1()
                
                
                
                SetSel_WFIN_ApproverPageSearchButton()
              
            ' setting the state of expand or collapse alternative rows
      
            Dim expandFirstRow As Boolean= False   
        
            Dim recControls() As Sel_WFIN_ApproverPageTableControlRow = Me.GetRecordControls()
            For i As Integer = 0 to recControls.Length - 1
                Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(recControls(i), "Sel_WFIN_ApproverPageTableControlAltRow"), System.Web.UI.Control)
                If (altRow IsNot Nothing) Then
                    If (expandFirstRow AndAlso i = 0) Then                
                        altRow.Visible = True
                   
                         recControls(i).Sel_WFIN_ApproverPageRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                         recControls(i).Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Attributes.Add("onmouseover", "")
                         recControls(i).Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Attributes.Add("onmouseout", "")
                   
                    Else                
                        altRow.Visible = False
                   
                         recControls(i).Sel_WFIN_ApproverPageRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                         recControls(i).Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Attributes.Add("onmouseover", "")
                         recControls(i).Sel_WFIN_ApproverPageRowExpandCollapseRowButton.Attributes.Add("onmouseout", "")
                   
                    End If
                End If
            Next
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
                    
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(Sel_WFIN_ApproverPage1View.AFIN_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WFIN_ApproverPage1View.AFIN_WDT_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WFIN_ApproverPage1View.FIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WFIN_ApproverPage1View.HFIN_ID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()
            
            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If
            
            If includeDS
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

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

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function




        Public Overridable Sub ResetControl()

            
            Me.AFIN_StatusFilter1.ClearSelection()
            
            Me.HFIN_C_IDFilter1.ClearSelection()
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Public Overridable Sub ResetPageControl()
            Me.PageIndex = 0
        End Sub
        
        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Sel_WFIN_ApproverPagePagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Sel_WFIN_ApproverPagePagination.CurrentPage.Text = "0"
            End If
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Sel_WFIN_ApproverPagePagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Sel_WFIN_ApproverPagePagination.CurrentPage.Text = "0"
            End If
            Me.Sel_WFIN_ApproverPagePagination.PageSize.Text = Me.PageSize.ToString()
            Me.Sel_WFIN_ApproverPagePagination.PageSize.Text = Me.PageSize.ToString()
            Me.Sel_WFIN_ApproverPagePagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Sel_WFIN_ApproverPagePagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Sel_WFIN_ApproverPagePagination.TotalPages.Text = Me.TotalPages.ToString()
            Me.Sel_WFIN_ApproverPagePagination.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for Sel_WFIN_ApproverPageTableControl pagination.
        
            Me.Sel_WFIN_ApproverPagePagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Sel_WFIN_ApproverPagePagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Sel_WFIN_ApproverPagePagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Sel_WFIN_ApproverPagePagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Sel_WFIN_ApproverPagePagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Sel_WFIN_ApproverPagePagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Sel_WFIN_ApproverPagePagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Sel_WFIN_ApproverPagePagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Sel_WFIN_ApproverPageTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            
          
    
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
         
            Return jFilter
        End Function

      
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            Sel_WFIN_ApproverPage1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WFIN_ApproverPageTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.AFIN_StatusFilter1) Then
    
              hasFiltersSel_WFIN_ApproverPageTableControl = True            
    
                wc.iAND(Sel_WFIN_ApproverPage1View.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.AFIN_StatusFilter1, Me.GetFromSession(Me.AFIN_StatusFilter1)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.HFIN_C_IDFilter1) Then
    
              hasFiltersSel_WFIN_ApproverPageTableControl = True            
    
                wc.iAND(Sel_WFIN_ApproverPage1View.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_C_IDFilter1, Me.GetFromSession(Me.HFIN_C_IDFilter1)), False, False)
            
            End If
                  
                
                         
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Sel_WFIN_ApproverPage1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WFIN_ApproverPageTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim AFIN_StatusFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "AFIN_StatusFilter1_Ajax"), String)
            If IsValueSelected(AFIN_StatusFilter1SelectedValue) Then
    
              hasFiltersSel_WFIN_ApproverPageTableControl = True            
    
                 wc.iAND(Sel_WFIN_ApproverPage1View.AFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, AFIN_StatusFilter1SelectedValue, false, False)
             
             End If
                      
            Dim HFIN_C_IDFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_C_IDFilter1_Ajax"), String)
            If IsValueSelected(HFIN_C_IDFilter1SelectedValue) Then
    
              hasFiltersSel_WFIN_ApproverPageTableControl = True            
    
                 wc.iAND(Sel_WFIN_ApproverPage1View.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, HFIN_C_IDFilter1SelectedValue, false, False)
             
             End If
                      
      
      
            Return wc
        End Function

      

         Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                         ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                         ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                         ByVal resultList As ArrayList) As Boolean
              Return FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText, _
                                       autoTypeAheadSearch, AutoTypeAheadWordSeparators, _
                                       resultList, False)
         End Function

        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                               ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                               ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                               ByVal resultList As ArrayList, ByVal stripHTML As Boolean) As Boolean
            If stripHTML Then
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText)
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem)
            End If
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If Not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                End If
            End If

            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") Then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then
                            itemToAdd = resultItem
                        Else                            
                            itemToAdd = resultItem.Substring(index)
                        End If
                    Else                       
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward)
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength / 2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) >= Len(resultItem) - 1 OrElse _
                        Len(resultItem) - index < subStringBeginIndex Then                           
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, Len(resultItem) - 1 - columnLength, Len(resultItem) - 1, StringUtils.Direction.backward)
                        ElseIf index <= subStringBeginIndex Then
                            ' Sanity check at beginning of the string                          
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward)
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText                         
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both)
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                    ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If index <= columnLength Then
                        itemToAdd = resultItem.Substring(0, index)
                    Else
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward)
                    End If
                End If

                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                If prefixTextIndex < 0 Then Return False
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                End If

                If Not String.IsNullOrEmpty(itemToAdd) AndAlso Not resultList.Contains(itemToAdd) Then
                   
                    resultList.Add(itemToAdd)
          				
                    isAdded = True
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Sel_WFIN_ApproverPagePagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Sel_WFIN_ApproverPagePagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
            If Me.Sel_WFIN_ApproverPagePagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Sel_WFIN_ApproverPagePagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
          
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WFIN_ApproverPageTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As Sel_WFIN_ApproverPageTableControlRow = DirectCast(repItem.FindControl("Sel_WFIN_ApproverPageTableControlRow"), Sel_WFIN_ApproverPageTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_WFIN_ApproverPage1Record = New Sel_WFIN_ApproverPage1Record()
        
                        If recControl.AFIN_Date_Action.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Action.Text, Sel_WFIN_ApproverPage1View.AFIN_Date_Action)
                        End If
                        If recControl.AFIN_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Assign.Text, Sel_WFIN_ApproverPage1View.AFIN_Date_Assign)
                        End If
                        If recControl.AFIN_FinID.Text <> "" Then
                            rec.Parse(recControl.AFIN_FinID.Text, Sel_WFIN_ApproverPage1View.AFIN_FinID)
                        End If
                        If recControl.AFIN_Status.Text <> "" Then
                            rec.Parse(recControl.AFIN_Status.Text, Sel_WFIN_ApproverPage1View.AFIN_Status)
                        End If
                        If recControl.AFIN_WDT_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_WDT_ID.Text, Sel_WFIN_ApproverPage1View.AFIN_WDT_ID)
                        End If
                        If recControl.FIn_Description.Text <> "" Then
                            rec.Parse(recControl.FIn_Description.Text, Sel_WFIN_ApproverPage1View.FIn_Description)
                        End If
                        If recControl.FIN_Month.Text <> "" Then
                            rec.Parse(recControl.FIN_Month.Text, Sel_WFIN_ApproverPage1View.FIN_Month)
                        End If
                        If recControl.FIN_Year.Text <> "" Then
                            rec.Parse(recControl.FIN_Year.Text, Sel_WFIN_ApproverPage1View.FIN_Year)
                        End If
                        If recControl.HFIN_ID.Text <> "" Then
                            rec.Parse(recControl.HFIN_ID.Text, Sel_WFIN_ApproverPage1View.HFIN_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New Sel_WFIN_ApproverPage1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Sel_WFIN_ApproverPage1Record)), Sel_WFIN_ApproverPage1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Sel_WFIN_ApproverPageTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Sel_WFIN_ApproverPageTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetAFIN_Date_ActionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_Date_ActionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_Date_AssignLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_Date_AssignLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_StatusLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_StatusLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_WDT_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_WDT_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFIn_DescriptionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FIn_DescriptionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFIN_MonthLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FIN_MonthLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetFIN_YearLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.FIN_YearLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_C_IDLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_C_IDLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_StatusFilter1()

              
            
                Me.PopulateAFIN_StatusFilter1(GetSelectedValue(Me.AFIN_StatusFilter1,  GetFromSession(Me.AFIN_StatusFilter1)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetHFIN_C_IDFilter1()

              
            
                Me.PopulateHFIN_C_IDFilter1(GetSelectedValue(Me.HFIN_C_IDFilter1,  GetFromSession(Me.HFIN_C_IDFilter1)), 500)					
                                     
              End Sub	
            
        ' Get the filters' data for AFIN_StatusFilter1
        Protected Overridable Sub PopulateAFIN_StatusFilter1(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.AFIN_StatusFilter1.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_AFIN_StatusFilter1()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_AFIN_StatusFilter1 function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the All item.
            Me.AFIN_StatusFilter1.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
                              

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WFin_ApprovalStatus1Table.WPO_STAT_DESC, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")
            

            Dim itemValues() As WFin_ApprovalStatus1Record = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = WFin_ApprovalStatus1Table.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As WFin_ApprovalStatus1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WPO_STAT_CDSpecified Then
                            cvalue = itemValue.WPO_STAT_CD.ToString()

                            If counter < maxItems AndAlso Me.AFIN_StatusFilter1.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WFIN_ApproverPage1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WFIN_ApproverPage1View.AFIN_Status)
                                If _isExpandableNonCompositeForeignKey AndAlso Sel_WFIN_ApproverPage1View.AFIN_Status.IsApplyDisplayAs Then
                                    fvalue = Sel_WFIN_ApproverPage1View.GetDFKA(itemValue, Sel_WFIN_ApproverPage1View.AFIN_Status)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(WFin_ApprovalStatus1Table.WPO_STAT_CD)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.AFIN_StatusFilter1.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.AFIN_StatusFilter1.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue) AndAlso Not String.IsNullOrEmpty(cvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                                End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If			
            


                               

            Try    
                
                ' Set the selected value.
                SetSelectedValue(Me.AFIN_StatusFilter1, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.AFIN_StatusFilter1.SelectedValue IsNot Nothing AndAlso Me.AFIN_StatusFilter1.Items.FindByValue(Me.AFIN_StatusFilter1.SelectedValue) Is Nothing
                Me.AFIN_StatusFilter1.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for HFIN_C_IDFilter1
        Protected Overridable Sub PopulateHFIN_C_IDFilter1(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_C_IDFilter1.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_C_IDFilter1()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_C_IDFilter1 function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the All item.
            Me.HFIN_C_IDFilter1.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
                              

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Sel_WF_DYNAMICS_Company1View.Company_Short_Name, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")
            

            Dim itemValues() As Sel_WF_DYNAMICS_Company1Record = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = Sel_WF_DYNAMICS_Company1View.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As Sel_WF_DYNAMICS_Company1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.Company_IDSpecified Then
                            cvalue = itemValue.Company_ID.ToString()

                            If counter < maxItems AndAlso Me.HFIN_C_IDFilter1.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WFIN_ApproverPage1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WFIN_ApproverPage1View.HFIN_C_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso Sel_WFIN_ApproverPage1View.HFIN_C_ID.IsApplyDisplayAs Then
                                    fvalue = Sel_WFIN_ApproverPage1View.GetDFKA(itemValue, Sel_WFIN_ApproverPage1View.HFIN_C_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(Sel_WF_DYNAMICS_Company1View.Company_ID)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.HFIN_C_IDFilter1.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_C_IDFilter1.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue) AndAlso Not String.IsNullOrEmpty(cvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                                End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If			
            


                               

            Try    
                
                ' Set the selected value.
                SetSelectedValue(Me.HFIN_C_IDFilter1, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.HFIN_C_IDFilter1.SelectedValue IsNot Nothing AndAlso Me.HFIN_C_IDFilter1.Items.FindByValue(Me.HFIN_C_IDFilter1.SelectedValue) Is Nothing
                Me.HFIN_C_IDFilter1.SelectedValue = Nothing
            End If            
                          
        End Sub
            
              

        Public Overridable Function CreateWhereClause_AFIN_StatusFilter1() As WhereClause
          
              Dim hasFiltersSel_WFIN_ApproverPageTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
            
            ' Create a where clause for the filter AFIN_StatusFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the AFIN_StatusFilter1DropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_HFIN_C_IDFilter1() As WhereClause
          
              Dim hasFiltersSel_WFIN_ApproverPageTableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_C_IDFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_C_IDFilter1DropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    Me.LoadData()
                    Me.DataBind()
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            Me.SaveToSession(Me.AFIN_StatusFilter1, Me.AFIN_StatusFilter1.SelectedValue)
                  
            Me.SaveToSession(Me.HFIN_C_IDFilter1, Me.HFIN_C_IDFilter1.SelectedValue)
                  
        
            'Save pagination state to session.
         
            
            ' Save table control properties to the session.
            
 If Not Me.CurrentSortOrder Is Nothing Then
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then
                    Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
                End If
            End If            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
      Me.SaveToSession("AFIN_StatusFilter1_Ajax", Me.AFIN_StatusFilter1.SelectedValue)
              
      Me.SaveToSession("HFIN_C_IDFilter1_Ajax", Me.HFIN_C_IDFilter1.SelectedValue)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.AFIN_StatusFilter1)
            Me.RemoveFromSession(Me.HFIN_C_IDFilter1)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Sel_WFIN_ApproverPageTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Sel_WFIN_ApproverPagePagination")
             Dim PaginationType As String = ""
             If Not (Pagination Is Nothing) Then
                Dim Summary As Control = Pagination.FindControl("_Summary")
                If Not (Summary Is Nothing) Then
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination")) Then
                        PaginationType = "Infinite Pagination"
                    End If
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination Mobile")) Then
                        PaginationType = "Infinite Pagination Mobile"
                End If
             End If
             End If

            If Not (PaginationType.Equals("Infinite Pagination")) Then 
              If Not Me.Page.ClientQueryString.Contains("InfiIframe") AndAlso PaginationType.Equals("Infinite Pagination Mobile") Then
                    Me.ViewState("Page_Index") = 0
                End If
              Dim pageIndex As String = CType(ViewState("Page_Index"), String)
              If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
              End If
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
              Me.PageSize = CInt(pageSize)
            End If

            
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("Sel_WFIN_ApproverPageTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetSel_WFIN_ApproverPageSearchButton()                
              
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Sel_WFIN_ApproverPagePagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Sel_WFIN_ApproverPagePagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Sel_WFIN_ApproverPagePagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Sel_WFIN_ApproverPagePagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Sel_WFIN_ApproverPagePagination.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Sel_WFIN_ApproverPagePagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Sel_WFIN_ApproverPagePagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
        ' event handler for Button
        Public Overridable Sub Sel_WFIN_ApproverPageSearchButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
          Me.DataChanged = True
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
        ' event handler for FieldFilter
        Protected Overridable Sub AFIN_StatusFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub HFIN_C_IDFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = Sel_WFIN_ApproverPage1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property


          
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Public Property DataSource() As Sel_WFIN_ApproverPage1Record ()
            Get
                Return DirectCast(MyBase._DataSource, Sel_WFIN_ApproverPage1Record())
            End Get
            Set(ByVal value() As Sel_WFIN_ApproverPage1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property AFIN_Date_ActionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_ActionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_Date_AssignLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_AssignLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_StatusFilter1() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_StatusFilter1"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_StatusLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_StatusLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_WDT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WDT_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIn_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIn_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_MonthLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_MonthLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_YearLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_YearLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_C_IDFilter1() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDFilter1"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_C_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Sel_WFIN_ApproverPagePagination() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WFIN_ApproverPagePagination"), ePortalWFApproval.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property Sel_WFIN_ApproverPageSearchButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WFIN_ApproverPageSearchButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property Sel_WFIN_ApproverPageTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WFIN_ApproverPageTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As Sel_WFIN_ApproverPageTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Sel_WFIN_ApproverPage1Record = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As Sel_WFIN_ApproverPageTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Sel_WFIN_ApproverPage1Record = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                If includeSession then
                    Return EvaluateExpressions(url, arg, rec, bEncrypt)
                Else
                    Return EvaluateExpressions(url, arg, rec, bEncrypt,False)
                End If
            End If
            Return url
        End Function
        
          
        Public Overridable Function GetSelectedRecordControl() As Sel_WFIN_ApproverPageTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Sel_WFIN_ApproverPageTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Sel_WFIN_ApproverPageTableControlRow)), Sel_WFIN_ApproverPageTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Sel_WFIN_ApproverPageTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As Sel_WFIN_ApproverPageTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As Sel_WFIN_ApproverPageTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Sel_WFIN_ApproverPageTableControlRow")
            Dim list As New List(Of Sel_WFIN_ApproverPageTableControlRow)
            For Each recCtrl As Sel_WFIN_ApproverPageTableControlRow In recCtrls
                list.Add(recCtrl)
            Next
            Return list.ToArray()
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property
                


#End Region



End Class

  
' Base class for the WFinRep_Activity1TableControlRow control on the WFIN_Approver_Table1 page.
' Do not modify this class. Instead override any method in WFinRep_Activity1TableControlRow.
Public Class BaseWFinRep_Activity1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_Activity1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_Activity1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRep_Activity record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_Activity1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_Activity1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_Activity1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_Activity1TableControlRow.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()
            Me.ClearControlsFromSession()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
              
                Return
            End If
             
   
            'LoadData for DataSource for chart and report if they exist
          
            ' Store the checksum. The checksum is used to
            ' ensure the record was not changed by another user.
            If Not Me.DataSource.GetCheckSumValue() Is Nothing
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If
            
      
      
            ' Call the Set methods for each controls on the panel
        
                SetAFIN_Date_Action1()
                SetAFIN_Date_Assign1()
                SetAFIN_Remark()
                SetAFIN_Status1()
                SetAFIN_W_U_ID()
                SetAFIN_WS_ID()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                If Me.DataSource.GetID IsNot Nothing Then
                    Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
                End If
                
            End If
            
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        End Sub
        
        
        Public Overridable Sub SetAFIN_Date_Action1()

                  
            
        
            ' Set the AFIN_Date_Action Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Date_Action1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Action1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_ActionSpecified Then
                				
                ' If the AFIN_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Action1.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Action1.Text = WFinRep_Activity1Table.AFIN_Date_Action.Format(WFinRep_Activity1Table.AFIN_Date_Action.DefaultValue, "g")
                        		
                End If
                 
            ' If the AFIN_Date_Action is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Date_Action1.Text Is Nothing _
                OrElse Me.AFIN_Date_Action1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Date_Action1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Date_Assign1()

                  
            
        
            ' Set the AFIN_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Date_Assign1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Assign1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_AssignSpecified Then
                				
                ' If the AFIN_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Assign1.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Assign1.Text = WFinRep_Activity1Table.AFIN_Date_Assign.Format(WFinRep_Activity1Table.AFIN_Date_Assign.DefaultValue, "g")
                        		
                End If
                 
            ' If the AFIN_Date_Assign is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Date_Assign1.Text Is Nothing _
                OrElse Me.AFIN_Date_Assign1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Date_Assign1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Remark()

                  
            
        
            ' Set the AFIN_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_RemarkSpecified Then
                				
                ' If the AFIN_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Remark)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    Dim originalLength As Integer = maxLength
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                                      
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If originalLength >= popupThreshold Then
                      
                        Dim name As String = HttpUtility.HtmlEncode(WFinRep_Activity1Table.AFIN_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WFinRep_Activity1Table, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""AFIN_Remark\"", \""AFIN_Remark\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, Len(formattedValue))))
                      
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        End If
                    End If
                End If  
                
                Me.AFIN_Remark.Text = formattedValue
                
            Else 
            
                ' AFIN_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Remark.Text = WFinRep_Activity1Table.AFIN_Remark.Format(WFinRep_Activity1Table.AFIN_Remark.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Remark.Text Is Nothing _
                OrElse Me.AFIN_Remark.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Remark.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Status1()

                  
            
        
            ' Set the AFIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Status1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Status1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_StatusSpecified Then
                				
                ' If the AFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Activity1Table.AFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Activity1Table.AFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Activity1Table.GetDFKA(Me.DataSource.AFIN_Status.ToString(),WFinRep_Activity1Table.AFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Status1.Text = formattedValue
                
            Else 
            
                ' AFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Status1.Text = WFinRep_Activity1Table.AFIN_Status.Format(WFinRep_Activity1Table.AFIN_Status.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Status1.Text Is Nothing _
                OrElse Me.AFIN_Status1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Status1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_W_U_ID()

                  
            
        
            ' Set the AFIN_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_W_U_IDSpecified Then
                				
                ' If the AFIN_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Activity1Table.AFIN_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Activity1Table.AFIN_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Activity1Table.GetDFKA(Me.DataSource.AFIN_W_U_ID.ToString(),WFinRep_Activity1Table.AFIN_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_W_U_ID.Text = formattedValue
                
            Else 
            
                ' AFIN_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_W_U_ID.Text = WFinRep_Activity1Table.AFIN_W_U_ID.Format(WFinRep_Activity1Table.AFIN_W_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_W_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_W_U_ID.Text Is Nothing _
                OrElse Me.AFIN_W_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_W_U_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_WS_ID()

                  
            
        
            ' Set the AFIN_WS_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_WS_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_WS_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_WS_IDSpecified Then
                				
                ' If the AFIN_WS_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Activity1Table.AFIN_WS_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Activity1Table.AFIN_WS_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Activity1Table.GetDFKA(Me.DataSource.AFIN_WS_ID.ToString(),WFinRep_Activity1Table.AFIN_WS_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_WS_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_WS_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_WS_ID.Text = formattedValue
                
            Else 
            
                ' AFIN_WS_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_WS_ID.Text = WFinRep_Activity1Table.AFIN_WS_ID.Format(WFinRep_Activity1Table.AFIN_WS_ID.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_WS_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_WS_ID.Text Is Nothing _
                OrElse Me.AFIN_WS_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_WS_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e As FormulaEvaluator) As String
            If e Is Nothing Then
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()

            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If

            If includeDS
                
            End IF
            
            
            ' Other variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then

                e.DataSource = Me.DataSource

            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

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
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()       
        
        
        End Sub

      
        
        ' To customize, override this method in WFinRep_Activity1TableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
            ' The checksum is used to ensure the record was not changed by another user.
            If (Not Me.DataSource Is Nothing) AndAlso (Not Me.DataSource.GetCheckSumValue Is Nothing) Then
                If Not Me.CheckSum Is Nothing AndAlso Me.CheckSum <> Me.DataSource.GetCheckSumValue.Value Then
                    Throw New Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "ePortalWFApproval"))
                End If
            End If
        
        Dim parentCtrl As Sel_WFIN_ApproverPageTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WFIN_ApproverPageTableControlRow"), Sel_WFIN_ApproverPageTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.AFIN_HFIN_ID = parentCtrl.DataSource.HFIN_ID
              
            ' 2. Perform any custom validation.
            Me.Validate()

            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
                DirectCast(GetParentControlObject(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in WFinRep_Activity1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetAFIN_Date_Action1()
            GetAFIN_Date_Assign1()
            GetAFIN_Remark()
            GetAFIN_Status1()
            GetAFIN_W_U_ID()
            GetAFIN_WS_ID()
        End Sub
        
        
        Public Overridable Sub GetAFIN_Date_Action1()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Date_Assign1()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Remark()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Status1()
            
        End Sub
                
        Public Overridable Sub GetAFIN_W_U_ID()
            
        End Sub
                
        Public Overridable Sub GetAFIN_WS_ID()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_Activity1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WFIN_ApproverPageTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRep_Activity1TableControlRow.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          WFinRep_Activity1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl).ResetData = True
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                                
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
            
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()
        
    
            'Save pagination state to session.
          
        End Sub
        
        
    
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

        

            ' Clear pagination state from session.
        
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
    
            ' Load view state for pagination control.
                 
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
    
            ' Load view state for pagination control.
                  
            Return MyBase.SaveViewState()
        End Function
        
        
    
        ' Generate set method for buttons
        
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   

        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseWFinRep_Activity1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRep_Activity1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRep_Activity1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Activity1Record)
            End Get
            Set(ByVal value As WFinRep_Activity1Record)
                Me._DataSource = value
            End Set
        End Property

        
        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property AFIN_Date_Action1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_Action1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Date_Assign1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_Assign1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Remark"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Status1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Status1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_W_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_W_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_WS_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WS_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
        
        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As WFinRep_Activity1Record = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean,ByVal includeSession as Boolean) As String
            
            Dim rec As WFinRep_Activity1Record = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))
                    
            End If
            If includeSession  Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt,False)  
            End If
        End Function

         
        Public Overridable Function GetRecord() As WFinRep_Activity1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_Activity1Table.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the WFinRep_Activity1TableControl control on the WFIN_Approver_Table1 page.
' Do not modify this class. Instead override any method in WFinRep_Activity1TableControl.
Public Class BaseWFinRep_Activity1TableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        

      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
         
            Else
                   
                Me.CurrentSortOrder = New OrderBy(True, False)
            
        End If

    

    ' Setup default pagination settings.
    
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
        
            
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
                        
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
                  
        
          ' Setup events for others
                
        End Sub
        
        
        Public Overridable Sub LoadData()        
        
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                Dim joinFilter As CompoundFilter = CreateCompoundJoinFilter()
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_Activity1Record)), WFinRep_Activity1Record())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Me._TotalRecords = 0
                    Me._TotalPages = 0
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                               
                If Me.DisplayLastPage Then
                    Dim totalRecords As Integer = If(Me._TotalRecords < 0, GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()), Me._TotalRecords)
                     
                      Dim totalPages As Integer = CInt(Math.Ceiling(totalRecords / Me.PageSize))
                    
                    Me.PageIndex = totalPages - 1
                End If                               
                
                ' Make sure PageIndex (current page) and PageSize are within bounds.
                If Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                End If
                If Me.PageSize < 1 Then
                    Me.PageSize = 1
                End If
                
                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                    Dim postdata As New ArrayList
                    For Each rc As WFinRep_Activity1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_Activity1Record)), WFinRep_Activity1Record())
                Else  ' Get the records from the database	
                      
                        Me.DataSource = GetRecords(joinFilter, wc, orderBy, Me.PageIndex, Me.PageSize)
                      
                End If
                
                ' if the datasource contains no records contained in database, then load the last page.
                If (DbUtils.GetCreatedRecords(Me.DataSource).Length = 0 AndAlso Not Me.DisplayLastPage) Then
                      Me.DisplayLastPage = True
                      LoadData()
                Else
                
                    ' Add any new rows desired by the user.
                    Me.AddNewRecords()
                       

                    ' Initialize the page and grand totals. now
                
                End If
    
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        Public Overridable Function GetRecords( _
            ByVal join As BaseFilter, _
            ByVal where As WhereClause, _
            ByVal orderBy As OrderBy, _
            ByVal pageIndex As Integer, _
            ByVal pageSize As Integer) As WFinRep_Activity1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_Activity1Table.Column1, True)         
            ' selCols.Add(WFinRep_Activity1Table.Column2, True)          
            ' selCols.Add(WFinRep_Activity1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_Activity1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_Activity1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_Activity1Record)), WFinRep_Activity1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_Activity1Table.Column1, True)         
            ' selCols.Add(WFinRep_Activity1Table.Column2, True)          
            ' selCols.Add(WFinRep_Activity1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_Activity1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_Activity1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)           
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
                
                Return CInt(databaseTable.GetRecordListCount(join, where.GetFilter(), Nothing, Nothing))
            End If

        End Function        
        
      
    
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            
              MyBase.DataBind()
            
    
            Me.ClearControlsFromSession()    

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
            
            'LoadData for DataSource for chart and report if they exist
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

      

    
        
          ' Bind the repeater with the list of records to expand the UI.
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRep_Activity1TableControlRow = DirectCast(repItem.FindControl("WFinRep_Activity1TableControlRow"), WFinRep_Activity1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetAFIN_Date_ActionLabel1()
                SetAFIN_Date_AssignLabel1()
                SetAFIN_RemarkLabel()
                SetAFIN_StatusLabel2()
                SetAFIN_W_U_IDLabel()
                SetAFIN_WSD_IDLabel()
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
                    
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_W_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_WS_ID, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
        End Sub

        Public EvaluateFormulaDelegate As BaseClasses.Data.DataSource.EvaluateFormulaDelegate = New BaseClasses.Data.DataSource.EvaluateFormulaDelegate(AddressOf Me.EvaluateFormula)

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean, ByVal e as FormulaEvaluator) As String
            If e Is Nothing
                e = New FormulaEvaluator()
            End If
            
            e.Variables.Clear()
            
            
            ' add variables for formula evaluation
            If variables IsNot Nothing Then
                Dim enumerator As System.Collections.Generic.IEnumerator(Of System.Collections.Generic.KeyValuePair(Of String, Object)) = variables.GetEnumerator()
                While enumerator.MoveNext()
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value)
                End While
            End If
            
            If includeDS
                
            End If
            
            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

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

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord, ByVal format as String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format,variables ,includeDS, Nothing)        
        End Function        

        
        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables ,True, Nothing)        
        End Function        

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e as FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS as Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function




        Public Overridable Sub ResetControl()

            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            
            Else
                Me.CurrentSortOrder = New OrderBy(True, False)
                
            End If
                
            Me.PageIndex = 0
        End Sub

        Public Overridable Sub ResetPageControl()
            Me.PageIndex = 0
        End Sub
        
        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the pagination labels.
        

            ' Bind the buttons for WFinRep_Activity1TableControl pagination.
        


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRep_Activity1TableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            
          
    
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        Public Overridable Function CreateCompoundJoinFilter() As CompoundFilter
            Dim jFilter As CompoundFilter = New CompoundFilter()
         
            Return jFilter
        End Function

      
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRep_Activity1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WFIN_ApproverPageTableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim sel_WFIN_ApproverPage1RecordObj as KeyValue
        sel_WFIN_ApproverPage1RecordObj = Nothing
      
              Dim sel_WFIN_ApproverPageTableControlObjRow As Sel_WFIN_ApproverPageTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "Sel_WFIN_ApproverPageTableControlRow") ,Sel_WFIN_ApproverPageTableControlRow)
            
                If (Not IsNothing(sel_WFIN_ApproverPageTableControlObjRow) AndAlso Not IsNothing(sel_WFIN_ApproverPageTableControlObjRow.GetRecord()) AndAlso Not IsNothing(sel_WFIN_ApproverPageTableControlObjRow.GetRecord().HFIN_ID))
                    wc.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, sel_WFIN_ApproverPageTableControlObjRow.GetRecord().HFIN_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WFinRep_Activity1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRep_Activity1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WFIN_ApproverPageTableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInSel_WFIN_ApproverPageTableControl as String = DirectCast(HttpContext.Current.Session("WFinRep_Activity1TableControlWhereClause"), String)
            
            If Not selectedRecordInSel_WFIN_ApproverPageTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInSel_WFIN_ApproverPageTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInSel_WFIN_ApproverPageTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WFinRep_Activity1Table.AFIN_HFIN_ID) Then
            wc.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WFinRep_Activity1Table.AFIN_HFIN_ID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
      
      
            Return wc
        End Function

      

         Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                         ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                         ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                         ByVal resultList As ArrayList) As Boolean
              Return FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText, _
                                       autoTypeAheadSearch, AutoTypeAheadWordSeparators, _
                                       resultList, False)
         End Function

        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                               ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                               ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                               ByVal resultList As ArrayList, ByVal stripHTML As Boolean) As Boolean
            If stripHTML Then
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText)
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem)
            End If
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If Not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                End If
            End If

            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") Then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then
                            itemToAdd = resultItem
                        Else                            
                            itemToAdd = resultItem.Substring(index)
                        End If
                    Else                       
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward)
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength / 2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) >= Len(resultItem) - 1 OrElse _
                        Len(resultItem) - index < subStringBeginIndex Then                           
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, Len(resultItem) - 1 - columnLength, Len(resultItem) - 1, StringUtils.Direction.backward)
                        ElseIf index <= subStringBeginIndex Then
                            ' Sanity check at beginning of the string                          
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward)
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText                         
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both)
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                    ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If index <= columnLength Then
                        itemToAdd = resultItem.Substring(0, index)
                    Else
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward)
                    End If
                End If

                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                If prefixTextIndex < 0 Then Return False
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                End If

                If Not String.IsNullOrEmpty(itemToAdd) AndAlso Not resultList.Contains(itemToAdd) Then
                   
                    resultList.Add(itemToAdd)
          				
                    isAdded = True
                End If
            End If
            Return isAdded
        End Function
        
    
        Protected Overridable Sub GetPageSize()
        
        End Sub

        Protected Overridable Sub AddNewRecords()
          
            Dim newRecordList As ArrayList = New ArrayList()
          
    Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()

    ' Loop though all the record controls and if the record control
    ' does not have a unique record id set, then create a record
    ' and add to the list.
    If Not Me.ResetData Then
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_Activity1TableControlRow = DirectCast(repItem.FindControl("WFinRep_Activity1TableControlRow"), WFinRep_Activity1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_Activity1Record = New WFinRep_Activity1Record()
        
                        If recControl.AFIN_Date_Action1.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Action1.Text, WFinRep_Activity1Table.AFIN_Date_Action)
                        End If
                        If recControl.AFIN_Date_Assign1.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Assign1.Text, WFinRep_Activity1Table.AFIN_Date_Assign)
                        End If
                        If recControl.AFIN_Remark.Text <> "" Then
                            rec.Parse(recControl.AFIN_Remark.Text, WFinRep_Activity1Table.AFIN_Remark)
                        End If
                        If recControl.AFIN_Status1.Text <> "" Then
                            rec.Parse(recControl.AFIN_Status1.Text, WFinRep_Activity1Table.AFIN_Status)
                        End If
                        If recControl.AFIN_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_W_U_ID.Text, WFinRep_Activity1Table.AFIN_W_U_ID)
                        End If
                        If recControl.AFIN_WS_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_WS_ID.Text, WFinRep_Activity1Table.AFIN_WS_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_Activity1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_Activity1Record)), WFinRep_Activity1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRep_Activity1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRep_Activity1TableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetAFIN_Date_ActionLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_Date_ActionLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_Date_AssignLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_Date_AssignLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_RemarkLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_StatusLabel2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_StatusLabel2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_W_U_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_W_U_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetAFIN_WSD_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.AFIN_WSD_IDLabel.Text = "Some value"
                    
                  End Sub
                

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    Me.LoadData()
                    Me.DataBind()
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
        
            'Save pagination state to session.
         
            
            ' Save table control properties to the session.
            
 If Not Me.CurrentSortOrder Is Nothing Then
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then
                    Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
                End If
            End If            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WFinRep_Activity1TableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("")
             Dim PaginationType As String = ""
             If Not (Pagination Is Nothing) Then
                Dim Summary As Control = Pagination.FindControl("_Summary")
                If Not (Summary Is Nothing) Then
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination")) Then
                        PaginationType = "Infinite Pagination"
                    End If
                    If (DirectCast(Summary, System.Web.UI.WebControls.TextBox).Text.Equals("Infinite Pagination Mobile")) Then
                        PaginationType = "Infinite Pagination Mobile"
                End If
             End If
             End If

            If Not (PaginationType.Equals("Infinite Pagination")) Then 
              If Not Me.Page.ClientQueryString.Contains("InfiIframe") AndAlso PaginationType.Equals("Infinite Pagination Mobile") Then
                    Me.ViewState("Page_Index") = 0
                End If
              Dim pageIndex As String = CType(ViewState("Page_Index"), String)
              If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
              End If
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
              Me.PageSize = CInt(pageSize)
            End If

            
    
            ' Load view state for pagination control.
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("WFinRep_Activity1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
                

        ' Generate the event handling functions for pagination events.
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WFinRep_Activity1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
                End If
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                  
                End If
                Me._TotalRecords = value
            End Set
        End Property

        
    
        Protected _TotalPages As Integer = -1
        Public Property TotalPages() As Integer
            Get
                If _TotalPages < 0 Then
                
                    Me.TotalPages = CInt(Math.Ceiling(TotalRecords / Me.PageSize))
                  
                End If                
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property

        Protected _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property


          
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Public Property DataSource() As WFinRep_Activity1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Activity1Record())
            End Get
            Set(ByVal value() As WFinRep_Activity1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property AFIN_Date_ActionLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_ActionLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_Date_AssignLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_AssignLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_StatusLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_StatusLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_W_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_WSD_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WSD_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRep_Activity1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_Activity1Record = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WFinRep_Activity1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_Activity1Record = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                If includeSession then
                    Return EvaluateExpressions(url, arg, rec, bEncrypt)
                Else
                    Return EvaluateExpressions(url, arg, rec, bEncrypt,False)
                End If
            End If
            Return url
        End Function
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRep_Activity1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRep_Activity1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRep_Activity1TableControlRow)), WFinRep_Activity1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRep_Activity1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRep_Activity1TableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As WFinRep_Activity1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRep_Activity1TableControlRow")
            Dim list As New List(Of WFinRep_Activity1TableControlRow)
            For Each recCtrl As WFinRep_Activity1TableControlRow In recCtrls
                list.Add(recCtrl)
            Next
            Return list.ToArray()
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property
                


#End Region



End Class

  

#End Region
    
  
End Namespace

  