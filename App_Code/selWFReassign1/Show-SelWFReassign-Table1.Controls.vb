
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Show_SelWFReassign_Table1.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.Show_SelWFReassign_Table1

#Region "Section 1: Place your customizations here."

    
'Public Class SelWFReassign1TableControlRow
'        Inherits BaseSelWFReassign1TableControlRow
'        ' The BaseSelWFReassign1TableControlRow implements code for a ROW within the
'        ' the SelWFReassign1TableControl table.  The BaseSelWFReassign1TableControlRow implements the DataBind and SaveData methods.
'        ' The loading of data is actually performed by the LoadData method in the base class of SelWFReassign1TableControl.
'
'        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
'        ' SaveData, GetUIData, and Validate methods.
'        
'
'End Class
'

  

'Public Class SelWFReassign1TableControl
'        Inherits BaseSelWFReassign1TableControl
'
'    ' The BaseSelWFReassign1TableControl class implements the LoadData, DataBind, CreateWhereClause
'    ' and other methods to load and display the data in a table control.
'
'    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
'    ' The SelWFReassign1TableControlRow class offers another place where you can customize
'    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.
'
'End Class
'

  

Public Class SelWFReassignTableControl
        Inherits BaseSelWFReassignTableControl

    ' The BaseSelWFReassignTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The SelWFReassignTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


		Public Overrides Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            SelWFReassignView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()


            If IsValueSelected(Me.WPO_W_U_IDFilter) Then
                wc.iAND(SelWFReassignView.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WPO_W_U_IDFilter, Me.GetFromSession(Me.WPO_W_U_IDFilter)), False, False)
            End If

            If IsValueSelected(Me.TOTALFromFilter) Then
                wc.iAND(SelWFReassignView.TOTAL, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(Me.TOTALFromFilter, Me.GetFromSession(Me.TOTALFromFilter)), False, False)
            End If

            If IsValueSelected(Me.TOTALToFilter) Then
                wc.iAND(SelWFReassignView.TOTAL, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(Me.TOTALToFilter, Me.GetFromSession(Me.TOTALToFilter)), False, False)
            End If

            wc.iAND(SelWFReassignView.WPO_Status, BaseFilter.ComparisonOperator.EqualsTo, "4")

            Return wc
        End Function
End Class
Public Class SelWFReassignTableControlRow
        Inherits BaseSelWFReassignTableControlRow
        ' The BaseSelWFReassignTableControlRow implements code for a ROW within the
        ' the SelWFReassignTableControl table.  The BaseSelWFReassignTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of SelWFReassignTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class
#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the SelWFReassignTableControlRow control on the Show_SelWFReassign_Table1 page.
' Do not modify this class. Instead override any method in SelWFReassignTableControlRow.
Public Class BaseSelWFReassignTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in SelWFReassignTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in SelWFReassignTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.SelWFReassignRowExpandCollapseRowButton.Click, AddressOf SelWFReassignRowExpandCollapseRowButton_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.selWFReassign record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = SelWFReassign1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSelWFReassignTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New SelWFReassign1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in SelWFReassignTableControlRow.
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
        
                SetcoID()
                
                
                SetTOTAL()
                SetWPO_Date_Assign()
                SetWPO_ID()
                SetWPO_PONum()
                SetWPO_Remark()
                SetWPO_Status()
                SetWPO_W_U_ID()
                SetWPO_WDT_ID()
                SetWPO_WS_ID()
                SetSelWFReassignRowExpandCollapseRowButton()
              
      
      
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
        
        
        Public Overridable Sub SetcoID()

                  
            
        
            ' Set the coID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.coID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetcoID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.coIDSpecified Then
                				
                ' If the coID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = SelWFReassign1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SelWFReassign1View.coID)
                If _isExpandableNonCompositeForeignKey AndAlso SelWFReassign1View.coID.IsApplyDisplayAs Then
                                  
                       formattedValue = SelWFReassign1View.GetDFKA(Me.DataSource.coID.ToString(),SelWFReassign1View.coID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(SelWFReassign1View.coID)
                       End If
                Else
                       formattedValue = Me.DataSource.coID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.coID.Text = formattedValue
                
            Else 
            
                ' coID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.coID.Text = SelWFReassign1View.coID.Format(SelWFReassign1View.coID.DefaultValue)
                        		
                End If
                 
            ' If the coID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.coID.Text Is Nothing _
                OrElse Me.coID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.coID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetTOTAL()

                  
            
        
            ' Set the TOTAL Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.TOTAL is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetTOTAL()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.TOTALSpecified Then
                				
                ' If the TOTAL is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SelWFReassign1View.TOTAL)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.TOTAL.Text = formattedValue
                
            Else 
            
                ' TOTAL is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.TOTAL.Text = SelWFReassign1View.TOTAL.Format(SelWFReassign1View.TOTAL.DefaultValue)
                        		
                End If
                 
            ' If the TOTAL is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.TOTAL.Text Is Nothing _
                OrElse Me.TOTAL.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.TOTAL.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_Date_Assign()

                  
            
        
            ' Set the WPO_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.WPO_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_Date_AssignSpecified Then
                				
                ' If the WPO_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SelWFReassign1View.WPO_Date_Assign, "d")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_Date_Assign.Text = formattedValue
                
            Else 
            
                ' WPO_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_Date_Assign.Text = SelWFReassign1View.WPO_Date_Assign.Format(SelWFReassign1View.WPO_Date_Assign.DefaultValue, "d")
                        		
                End If
                 
            ' If the WPO_Date_Assign is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_Date_Assign.Text Is Nothing _
                OrElse Me.WPO_Date_Assign.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_Date_Assign.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_ID()

                  
            
        
            ' Set the WPO_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.WPO_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_IDSpecified Then
                				
                ' If the WPO_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SelWFReassign1View.WPO_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_ID.Text = formattedValue
                
            Else 
            
                ' WPO_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_ID.Text = SelWFReassign1View.WPO_ID.Format(SelWFReassign1View.WPO_ID.DefaultValue)
                        		
                End If
                 
            ' If the WPO_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_ID.Text Is Nothing _
                OrElse Me.WPO_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_PONum()

                  
            
        
            ' Set the WPO_PONum Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.WPO_PONum is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_PONum()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_PONumSpecified Then
                				
                ' If the WPO_PONum is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SelWFReassign1View.WPO_PONum)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_PONum.Text = formattedValue
                
            Else 
            
                ' WPO_PONum is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_PONum.Text = SelWFReassign1View.WPO_PONum.Format(SelWFReassign1View.WPO_PONum.DefaultValue)
                        		
                End If
                 
            ' If the WPO_PONum is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_PONum.Text Is Nothing _
                OrElse Me.WPO_PONum.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_PONum.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_Remark()

                  
            
        
            ' Set the WPO_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.WPO_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_RemarkSpecified Then
                				
                ' If the WPO_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SelWFReassign1View.WPO_Remark)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_Remark.Text = formattedValue
                
            Else 
            
                ' WPO_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_Remark.Text = SelWFReassign1View.WPO_Remark.Format(SelWFReassign1View.WPO_Remark.DefaultValue)
                        		
                End If
                 
            ' If the WPO_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_Remark.Text Is Nothing _
                OrElse Me.WPO_Remark.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_Remark.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_Status()

                  
            
        
            ' Set the WPO_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.WPO_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_StatusSpecified Then
                				
                ' If the WPO_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = SelWFReassign1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SelWFReassign1View.WPO_Status)
                If _isExpandableNonCompositeForeignKey AndAlso SelWFReassign1View.WPO_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = SelWFReassign1View.GetDFKA(Me.DataSource.WPO_Status.ToString(),SelWFReassign1View.WPO_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(SelWFReassign1View.WPO_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.WPO_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_Status.Text = formattedValue
                
            Else 
            
                ' WPO_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_Status.Text = SelWFReassign1View.WPO_Status.Format(SelWFReassign1View.WPO_Status.DefaultValue)
                        		
                End If
                 
            ' If the WPO_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_Status.Text Is Nothing _
                OrElse Me.WPO_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_W_U_ID()

                  
            
        
            ' Set the WPO_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.WPO_W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_W_U_IDSpecified Then
                				
                ' If the WPO_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = SelWFReassign1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SelWFReassign1View.WPO_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso SelWFReassign1View.WPO_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = SelWFReassign1View.GetDFKA(Me.DataSource.WPO_W_U_ID.ToString(),SelWFReassign1View.WPO_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(SelWFReassign1View.WPO_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WPO_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_W_U_ID.Text = formattedValue
                
            Else 
            
                ' WPO_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_W_U_ID.Text = SelWFReassign1View.WPO_W_U_ID.Format(SelWFReassign1View.WPO_W_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the WPO_W_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_W_U_ID.Text Is Nothing _
                OrElse Me.WPO_W_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_W_U_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_WDT_ID()

                  
            
        
            ' Set the WPO_WDT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.WPO_WDT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_WDT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_WDT_IDSpecified Then
                				
                ' If the WPO_WDT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = SelWFReassign1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SelWFReassign1View.WPO_WDT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso SelWFReassign1View.WPO_WDT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = SelWFReassign1View.GetDFKA(Me.DataSource.WPO_WDT_ID.ToString(),SelWFReassign1View.WPO_WDT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(SelWFReassign1View.WPO_WDT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WPO_WDT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_WDT_ID.Text = formattedValue
                
            Else 
            
                ' WPO_WDT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_WDT_ID.Text = SelWFReassign1View.WPO_WDT_ID.Format(SelWFReassign1View.WPO_WDT_ID.DefaultValue)
                        		
                End If
                 
            ' If the WPO_WDT_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_WDT_ID.Text Is Nothing _
                OrElse Me.WPO_WDT_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_WDT_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPO_WS_ID()

                  
            
        
            ' Set the WPO_WS_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.selWFReassign database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.selWFReassign record retrieved from the database.
            ' Me.WPO_WS_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPO_WS_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPO_WS_IDSpecified Then
                				
                ' If the WPO_WS_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = SelWFReassign1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SelWFReassign1View.WPO_WS_ID)
                If _isExpandableNonCompositeForeignKey AndAlso SelWFReassign1View.WPO_WS_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = SelWFReassign1View.GetDFKA(Me.DataSource.WPO_WS_ID.ToString(),SelWFReassign1View.WPO_WS_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(SelWFReassign1View.WPO_WS_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WPO_WS_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPO_WS_ID.Text = formattedValue
                
            Else 
            
                ' WPO_WS_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPO_WS_ID.Text = SelWFReassign1View.WPO_WS_ID.Format(SelWFReassign1View.WPO_WS_ID.DefaultValue)
                        		
                End If
                 
            ' If the WPO_WS_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPO_WS_ID.Text Is Nothing _
                OrElse Me.WPO_WS_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPO_WS_ID.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in SelWFReassignTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "SelWFReassignTableControl"), SelWFReassignTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "SelWFReassignTableControl"), SelWFReassignTableControl).ResetData = True
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

        ' To customize, override this method in SelWFReassignTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetcoID()
            GetTOTAL()
            GetWPO_Date_Assign()
            GetWPO_ID()
            GetWPO_PONum()
            GetWPO_Remark()
            GetWPO_Status()
            GetWPO_W_U_ID()
            GetWPO_WDT_ID()
            GetWPO_WS_ID()
        End Sub
        
        
        Public Overridable Sub GetcoID()
            
        End Sub
                
        Public Overridable Sub GetTOTAL()
            
        End Sub
                
        Public Overridable Sub GetWPO_Date_Assign()
            
        End Sub
                
        Public Overridable Sub GetWPO_ID()
            
        End Sub
                
        Public Overridable Sub GetWPO_PONum()
            
        End Sub
                
        Public Overridable Sub GetWPO_Remark()
            
        End Sub
                
        Public Overridable Sub GetWPO_Status()
            
        End Sub
                
        Public Overridable Sub GetWPO_W_U_ID()
            
        End Sub
                
        Public Overridable Sub GetWPO_WDT_ID()
            
        End Sub
                
        Public Overridable Sub GetWPO_WS_ID()
            
        End Sub
                
      
        ' To customize, override this method in SelWFReassignTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSelWFReassignTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in SelWFReassignTableControlRow.
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
          SelWFReassign1View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "SelWFReassignTableControl"), SelWFReassignTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "SelWFReassignTableControl"), SelWFReassignTableControl).ResetData = True
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
        
        Public Overridable Sub SetSelWFReassignRowExpandCollapseRowButton()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub SelWFReassignRowExpandCollapseRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
          Dim panelControl as SelWFReassignTableControl = DirectCast(MiscUtils.GetParentControlObject(Me, "SelWFReassignTableControl"), SelWFReassignTableControl)

          Dim repeatedRows() as SelWFReassignTableControlRow = panelControl.GetRecordControls()
          For Each repeatedRow as SelWFReassignTableControlRow in repeatedRows
              Dim altRow as System.Web.UI.Control= DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "SelWFReassignTableControlAltRow"), System.Web.UI.Control)
              If (altRow IsNot Nothing) Then
                  If (sender Is repeatedRow.SelWFReassignRowExpandCollapseRowButton) Then
                      altRow.Visible = Not altRow.Visible
                  
                  End If                      
                  If (altRow.Visible) Then        
                   
                     repeatedRow.SelWFReassignRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                     repeatedRow.SelWFReassignRowExpandCollapseRowButton.Attributes.Add("onmouseover", "")
                     repeatedRow.SelWFReassignRowExpandCollapseRowButton.Attributes.Add("onmouseout", "")
                                     
                  Else
                   
                     repeatedRow.SelWFReassignRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                     repeatedRow.SelWFReassignRowExpandCollapseRowButton.Attributes.Add("onmouseover", "")
                     repeatedRow.SelWFReassignRowExpandCollapseRowButton.Attributes.Add("onmouseout", "")
                   
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
                Return CType(Me.ViewState("BaseSelWFReassignTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSelWFReassignTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As SelWFReassign1Record
            Get
                Return DirectCast(MyBase._DataSource, SelWFReassign1Record)
            End Get
            Set(ByVal value As SelWFReassign1Record)
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
        
        Public ReadOnly Property coID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "coID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SelWFReassignRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelWFReassignRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property SelWFReassignRowExpandCollapseRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelWFReassignRowExpandCollapseRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property TOTAL() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TOTAL"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_Date_Assign() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Date_Assign"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_PONum() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_PONum"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Remark"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_W_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_W_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_WDT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WDT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WPO_WS_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WS_ID"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As SelWFReassign1Record = Nothing
             
        
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
            
            Dim rec As SelWFReassign1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As SelWFReassign1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return SelWFReassign1View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the SelWFReassignTableControl control on the Show_SelWFReassign_Table1 page.
' Do not modify this class. Instead override any method in SelWFReassignTableControl.
Public Class BaseSelWFReassignTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.ddlAssignTo) 				
                    initialVal = Me.GetFromSession(Me.ddlAssignTo)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.ddlAssignTo.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.ddlAssignTo.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.TOTALFromFilter) 				
                    initialVal = Me.GetFromSession(Me.TOTALFromFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""TOTALFrom"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.TOTALFromFilter.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.TOTALToFilter) 				
                    initialVal = Me.GetFromSession(Me.TOTALToFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""TOTALTo"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.TOTALToFilter.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WPO_W_U_IDFilter) 				
                    initialVal = Me.GetFromSession(Me.WPO_W_U_IDFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""WPO_W_U_ID"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.WPO_W_U_IDFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.WPO_W_U_IDFilter.SelectedValue = initialVal
                            
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
            
              AddHandler Me.SelWFReassignPagination.FirstPage.Click, AddressOf SelWFReassignPagination_FirstPage_Click
                        
              AddHandler Me.SelWFReassignPagination.LastPage.Click, AddressOf SelWFReassignPagination_LastPage_Click
                        
              AddHandler Me.SelWFReassignPagination.NextPage.Click, AddressOf SelWFReassignPagination_NextPage_Click
                        
              AddHandler Me.SelWFReassignPagination.PageSizeButton.Click, AddressOf SelWFReassignPagination_PageSizeButton_Click
                        
              AddHandler Me.SelWFReassignPagination.PreviousPage.Click, AddressOf SelWFReassignPagination_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.btnAssignTo.Click, AddressOf btnAssignTo_Click
                        
              AddHandler Me.SelWFReassignFilterButton.Button.Click, AddressOf SelWFReassignFilterButton_Click
                        
            AddHandler Me.ddlAssignTo.SelectedIndexChanged, AddressOf ddlAssignTo_SelectedIndexChanged
              AddHandler Me.WPO_W_U_IDFilter.SelectedIndexChanged, AddressOf WPO_W_U_IDFilter_SelectedIndexChanged
                    
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(SelWFReassign1Record)), SelWFReassign1Record())
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
                    For Each rc As SelWFReassignTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(SelWFReassign1Record)), SelWFReassign1Record())
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
            ByVal pageSize As Integer) As SelWFReassign1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(SelWFReassign1View.Column1, True)         
            ' selCols.Add(SelWFReassign1View.Column2, True)          
            ' selCols.Add(SelWFReassign1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return SelWFReassign1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New SelWFReassign1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(SelWFReassign1Record)), SelWFReassign1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(SelWFReassign1View.Column1, True)         
            ' selCols.Add(SelWFReassign1View.Column2, True)          
            ' selCols.Add(SelWFReassign1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return SelWFReassign1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New SelWFReassign1View
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelWFReassignTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As SelWFReassignTableControlRow = DirectCast(repItem.FindControl("SelWFReassignTableControlRow"), SelWFReassignTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                SetcoIDLabel()
                SetddlAssignTo()
                SetLiteral()
                SetLiteral1()
                SetLiteral2()
                
                
                
                
                
                SetTOTALLabel()
                SetTOTALLabel1()
                
                
                SetWPO_Date_AssignLabel()
                SetWPO_PONumLabel()
                SetWPO_RemarkLabel()
                SetWPO_StatusLabel()
                SetWPO_W_U_IDFilter()
                SetWPO_W_U_IDLabel()
                SetWPO_W_U_IDLabel1()
                SetWPO_WDT_IDLabel()
                SetWPO_WS_IDLabel()
                SetbtnAssignTo()
              
                SetSelWFReassignFilterButton()
              
            ' setting the state of expand or collapse alternative rows
      
            Dim expandFirstRow As Boolean= False   
        
            Dim recControls() As SelWFReassignTableControlRow = Me.GetRecordControls()
            For i As Integer = 0 to recControls.Length - 1
                Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(recControls(i), "SelWFReassignTableControlAltRow"), System.Web.UI.Control)
                If (altRow IsNot Nothing) Then
                    If (expandFirstRow AndAlso i = 0) Then                
                        altRow.Visible = True
                   
                         recControls(i).SelWFReassignRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                         recControls(i).SelWFReassignRowExpandCollapseRowButton.Attributes.Add("onmouseover", "")
                         recControls(i).SelWFReassignRowExpandCollapseRowButton.Attributes.Add("onmouseout", "")
                   
                    Else                
                        altRow.Visible = False
                   
                         recControls(i).SelWFReassignRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                         recControls(i).SelWFReassignRowExpandCollapseRowButton.Attributes.Add("onmouseover", "")
                         recControls(i).SelWFReassignRowExpandCollapseRowButton.Attributes.Add("onmouseout", "")
                   
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
          
            Me.Page.PregetDfkaRecords(SelWFReassign1View.coID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(SelWFReassign1View.WPO_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(SelWFReassign1View.WPO_W_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(SelWFReassign1View.WPO_WDT_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(SelWFReassign1View.WPO_WS_ID, Me.DataSource)
          
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

            
            Me.WPO_W_U_IDFilter.ClearSelection()
            
            Me.ddlAssignTo.ClearSelection()
            
            Me.TOTALFromFilter.Text = ""
            
            Me.TOTALToFilter.Text = ""
            
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
                    
                Me.SelWFReassignPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.SelWFReassignPagination.CurrentPage.Text = "0"
            End If
            Me.SelWFReassignPagination.PageSize.Text = Me.PageSize.ToString()
            Me.SelWFReassignPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.SelWFReassignPagination.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for SelWFReassignTableControl pagination.
        
            Me.SelWFReassignPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.SelWFReassignPagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.SelWFReassignPagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.SelWFReassignPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.SelWFReassignPagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.SelWFReassignPagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.SelWFReassignPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.SelWFReassignPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As SelWFReassignTableControlRow
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
            SelWFReassign1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSelWFReassignTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.TOTALFromFilter) Then
    
              hasFiltersSelWFReassignTableControl = True            
    
                wc.iAND(SelWFReassign1View.TOTAL, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(Me.TOTALFromFilter, Me.GetFromSession(Me.TOTALFromFilter)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.TOTALToFilter) Then
    
              hasFiltersSelWFReassignTableControl = True            
    
                wc.iAND(SelWFReassign1View.TOTAL, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, MiscUtils.GetSelectedValue(Me.TOTALToFilter, Me.GetFromSession(Me.TOTALToFilter)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.WPO_W_U_IDFilter) Then
    
              hasFiltersSelWFReassignTableControl = True            
    
                wc.iAND(SelWFReassign1View.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.WPO_W_U_IDFilter, Me.GetFromSession(Me.WPO_W_U_IDFilter)), False, False)
            
            End If
                  
                
                         
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            SelWFReassign1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSelWFReassignTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim TOTALFromFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "TOTALFromFilter_Ajax"), String)
            If IsValueSelected(TOTALFromFilterSelectedValue) Then
    
              hasFiltersSelWFReassignTableControl = True            
    
                 wc.iAND(SelWFReassign1View.TOTAL, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, TOTALFromFilterSelectedValue, false, False)
             
             End If
                      
            Dim TOTALToFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "TOTALToFilter_Ajax"), String)
            If IsValueSelected(TOTALToFilterSelectedValue) Then
    
              hasFiltersSelWFReassignTableControl = True            
    
                 wc.iAND(SelWFReassign1View.TOTAL, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, TOTALToFilterSelectedValue, false, False)
             
             End If
                      
            Dim WPO_W_U_IDFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WPO_W_U_IDFilter_Ajax"), String)
            If IsValueSelected(WPO_W_U_IDFilterSelectedValue) Then
    
              hasFiltersSelWFReassignTableControl = True            
    
                 wc.iAND(SelWFReassign1View.WPO_W_U_ID, BaseFilter.ComparisonOperator.EqualsTo, WPO_W_U_IDFilterSelectedValue, false, False)
             
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
        
            If Me.SelWFReassignPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.SelWFReassignPagination.PageSize.Text)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelWFReassignTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As SelWFReassignTableControlRow = DirectCast(repItem.FindControl("SelWFReassignTableControlRow"), SelWFReassignTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As SelWFReassign1Record = New SelWFReassign1Record()
        
                        If recControl.coID.Text <> "" Then
                            rec.Parse(recControl.coID.Text, SelWFReassign1View.coID)
                        End If
                        If recControl.TOTAL.Text <> "" Then
                            rec.Parse(recControl.TOTAL.Text, SelWFReassign1View.TOTAL)
                        End If
                        If recControl.WPO_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.WPO_Date_Assign.Text, SelWFReassign1View.WPO_Date_Assign)
                        End If
                        If recControl.WPO_ID.Text <> "" Then
                            rec.Parse(recControl.WPO_ID.Text, SelWFReassign1View.WPO_ID)
                        End If
                        If recControl.WPO_PONum.Text <> "" Then
                            rec.Parse(recControl.WPO_PONum.Text, SelWFReassign1View.WPO_PONum)
                        End If
                        If recControl.WPO_Remark.Text <> "" Then
                            rec.Parse(recControl.WPO_Remark.Text, SelWFReassign1View.WPO_Remark)
                        End If
                        If recControl.WPO_Status.Text <> "" Then
                            rec.Parse(recControl.WPO_Status.Text, SelWFReassign1View.WPO_Status)
                        End If
                        If recControl.WPO_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.WPO_W_U_ID.Text, SelWFReassign1View.WPO_W_U_ID)
                        End If
                        If recControl.WPO_WDT_ID.Text <> "" Then
                            rec.Parse(recControl.WPO_WDT_ID.Text, SelWFReassign1View.WPO_WDT_ID)
                        End If
                        If recControl.WPO_WS_ID.Text <> "" Then
                            rec.Parse(recControl.WPO_WS_ID.Text, SelWFReassign1View.WPO_WS_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New SelWFReassign1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(SelWFReassign1Record)), SelWFReassign1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As SelWFReassignTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As SelWFReassignTableControlRow) As Boolean
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
        
        Public Overridable Sub SetcoIDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.coIDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.Literal2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetTOTALLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.TOTALLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetTOTALLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWPO_Date_AssignLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_Date_AssignLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_PONumLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_PONumLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_RemarkLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_RemarkLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_W_U_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_W_U_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_W_U_IDLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWPO_WDT_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_WDT_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWPO_WS_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WPO_WS_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetddlAssignTo()

              
            
                Me.PopulateddlAssignTo(GetSelectedValue(Me.ddlAssignTo,  GetFromSession(Me.ddlAssignTo)), 500)					
                    
        End Sub
            
        Public Overridable Sub SetWPO_W_U_IDFilter()

              
            
                Me.PopulateWPO_W_U_IDFilter(GetSelectedValue(Me.WPO_W_U_IDFilter,  GetFromSession(Me.WPO_W_U_IDFilter)), 500)					
                                     
              End Sub	
            
        ' Get the filters' data for ddlAssignTo
        Protected Overridable Sub PopulateddlAssignTo(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            Me.ddlAssignTo.Items.Clear()
            
            ' 1. Setup the static list items        
            		  
            ' Skip step 2 and 3 because no need to load data from database and insert data
            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.ddlAssignTo, selectedValue)

                
            Catch
            End Try
            
            If Me.ddlAssignTo.SelectedValue IsNot Nothing AndAlso Me.ddlAssignTo.Items.FindByValue(Me.ddlAssignTo.SelectedValue) Is Nothing
                Me.ddlAssignTo.SelectedValue = Nothing
            End If

              End Sub
            
        ' Get the filters' data for WPO_W_U_IDFilter
        Protected Overridable Sub PopulateWPO_W_U_IDFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.WPO_W_U_IDFilter.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_WPO_W_U_IDFilter()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WPO_W_U_IDFilter function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the All item.
            Me.WPO_W_U_IDFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
                              

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Sel_WASP_User1View.W_U_Full_Name, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")
            

            Dim itemValues() As Sel_WASP_User1Record = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = Sel_WASP_User1View.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As Sel_WASP_User1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.W_U_IDSpecified Then
                            cvalue = itemValue.W_U_ID.ToString()

                            If counter < maxItems AndAlso Me.WPO_W_U_IDFilter.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = SelWFReassign1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SelWFReassign1View.WPO_W_U_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso SelWFReassign1View.WPO_W_U_ID.IsApplyDisplayAs Then
                                    fvalue = SelWFReassign1View.GetDFKA(itemValue, SelWFReassign1View.WPO_W_U_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(Sel_WASP_User1View.W_U_ID)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WPO_W_U_IDFilter.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WPO_W_U_IDFilter.Items.Add(newItem)

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
                SetSelectedValue(Me.WPO_W_U_IDFilter, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.WPO_W_U_IDFilter.SelectedValue IsNot Nothing AndAlso Me.WPO_W_U_IDFilter.Items.FindByValue(Me.WPO_W_U_IDFilter.SelectedValue) Is Nothing
                Me.WPO_W_U_IDFilter.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        Public Overridable Function CreateWhereClause_ddlAssignTo() As WhereClause
        
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in control.
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            	                

        End Function			
        
              

        Public Overridable Function CreateWhereClause_WPO_W_U_IDFilter() As WhereClause
          
              Dim hasFiltersSelWFReassignTableControl As Boolean = False
            
            ' Create a where clause for the filter WPO_W_U_IDFilter.
            ' This function is called by the Populate method to load the items 
            ' in the WPO_W_U_IDFilterDropDownList
            
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
        
            Me.SaveToSession(Me.ddlAssignTo, Me.ddlAssignTo.SelectedValue)
                  
            Me.SaveToSession(Me.TOTALFromFilter, Me.TOTALFromFilter.Text)
                  
            Me.SaveToSession(Me.TOTALToFilter, Me.TOTALToFilter.Text)
                  
            Me.SaveToSession(Me.WPO_W_U_IDFilter, Me.WPO_W_U_IDFilter.SelectedValue)
                  
        
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
          
            Me.SaveToSession(Me.ddlAssignTo, Me.ddlAssignTo.SelectedValue)
                  
      Me.SaveToSession("TOTALFromFilter_Ajax", Me.TOTALFromFilter.Text)
              
      Me.SaveToSession("TOTALToFilter_Ajax", Me.TOTALToFilter.Text)
              
      Me.SaveToSession("WPO_W_U_IDFilter_Ajax", Me.WPO_W_U_IDFilter.SelectedValue)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.ddlAssignTo)
            Me.RemoveFromSession(Me.TOTALFromFilter)
            Me.RemoveFromSession(Me.TOTALToFilter)
            Me.RemoveFromSession(Me.WPO_W_U_IDFilter)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("SelWFReassignTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("SelWFReassignPagination")
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
                Me.ViewState("SelWFReassignTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetbtnAssignTo()                
              
   
        End Sub
            
        Public Overridable Sub SetSelWFReassignFilterButton()                
              
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub SelWFReassignPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub SelWFReassignPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub SelWFReassignPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub SelWFReassignPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.SelWFReassignPagination.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.SelWFReassignPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub SelWFReassignPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        
        ' event handler for PushButton
        Public Overridable Sub btnAssignTo_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub SelWFReassignFilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        
        ' event handler for Aspx
        Protected Overridable Sub ddlAssignTo_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
              	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub WPO_W_U_IDFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = SelWFReassign1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As SelWFReassign1Record ()
            Get
                Return DirectCast(MyBase._DataSource, SelWFReassign1Record())
            End Get
            Set(ByVal value() As SelWFReassign1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property btnAssignTo() As System.Web.UI.WebControls.Button
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnAssignTo"), System.Web.UI.WebControls.Button)
            End Get
        End Property
        
        Public ReadOnly Property coIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "coIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ddlAssignTo() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ddlAssignTo"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property Literal() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Literal2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SelWFReassignFilterButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelWFReassignFilterButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property SelWFReassignPagination() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelWFReassignPagination"), ePortalWFApproval.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property SelWFReassignTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelWFReassignTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SelWFReassignToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelWFReassignToggleAll"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property TOTALFromFilter() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TOTALFromFilter"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property TOTALLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TOTALLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TOTALLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TOTALLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property TOTALToFilter() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "TOTALToFilter"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property WPO_Date_AssignLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_Date_AssignLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_PONumLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_PONumLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_W_U_IDFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_W_U_IDFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property WPO_W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_W_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_W_U_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_W_U_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_WDT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WDT_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPO_WS_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPO_WS_IDLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As SelWFReassignTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As SelWFReassign1Record = Nothing     
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
                Dim recCtl As SelWFReassignTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As SelWFReassign1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As SelWFReassignTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.SelWFReassignRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As SelWFReassignTableControlRow
            Dim selectedList() As SelWFReassignTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As SelWFReassignTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As SelWFReassignTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.SelWFReassignRecordRowSelection IsNot Nothing AndAlso recControl.SelWFReassignRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(SelWFReassignTableControlRow)), SelWFReassignTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As SelWFReassignTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As SelWFReassignTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.SelWFReassignRecordRowSelection.Checked = False
                
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

        Public Overridable Function GetRecordControls() As SelWFReassignTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "SelWFReassignTableControlRow")
            Dim list As New List(Of SelWFReassignTableControlRow)
            For Each recCtrl As SelWFReassignTableControlRow In recCtrls
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

  