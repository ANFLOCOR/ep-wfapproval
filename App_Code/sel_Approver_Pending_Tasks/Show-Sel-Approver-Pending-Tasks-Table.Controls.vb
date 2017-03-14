
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Show_Sel_Approver_Pending_Tasks_Table.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.Show_Sel_Approver_Pending_Tasks_Table

#Region "Section 1: Place your customizations here."

    
Public Class Sel_Approver_Pending_TasksTableControlRow
        Inherits BaseSel_Approver_Pending_TasksTableControlRow
        ' The BaseSel_Approver_Pending_TasksTableControlRow implements code for a ROW within the
        ' the Sel_Approver_Pending_TasksTableControl table.  The BaseSel_Approver_Pending_TasksTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Sel_Approver_Pending_TasksTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class Sel_Approver_Pending_TasksTableControl
        Inherits BaseSel_Approver_Pending_TasksTableControl

    ' The BaseSel_Approver_Pending_TasksTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Sel_Approver_Pending_TasksTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Sel_Approver_Pending_TasksTableControlRow control on the Show_Sel_Approver_Pending_Tasks_Table page.
' Do not modify this class. Instead override any method in Sel_Approver_Pending_TasksTableControlRow.
Public Class BaseSel_Approver_Pending_TasksTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSel_Approver_Pending_TasksTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Sel_Approver_Pending_TasksRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
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
          
      
      
            ' Call the Set methods for each controls on the panel
        
                SetC_ID()
                SetC_IDLabel()
                SetCompany_Desc()
                SetCompany_DescLabel()
                SetDate_Assigned()
                SetDate_AssignedLabel()
                SetDoc_No()
                SetDoc_NoLabel()
                SetDoc_Title()
                SetDoc_TitleLabel()
                SetDoc_Total()
                SetDoc_TotalLabel()
                SetDoc_Type()
                SetDoc_TypeLabel()
                SetPK_ID()
                SetPK_IDLabel()
                SetSortOrder()
                SetSortOrderLabel()
                SetSSC_CompanyID()
                SetSSC_CompanyIDLabel()
                SetW_U_ID()
                SetW_U_IDLabel()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
            End If
            
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        End Sub
        
        
        Public Overridable Sub SetC_ID()

                  
            
        
            ' Set the C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.C_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetC_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.C_IDSpecified Then
                				
                ' If the C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.C_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.C_ID.Text = formattedValue
                
            Else 
            
                ' C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.C_ID.Text = Sel_Approver_Pending_TasksView.C_ID.Format(Sel_Approver_Pending_TasksView.C_ID.DefaultValue)
                        		
                End If
                 
            ' If the C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.C_ID.Text Is Nothing _
                OrElse Me.C_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.C_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetCompany_Desc()

                  
            
        
            ' Set the Company_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Company_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetCompany_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Company_DescSpecified Then
                				
                ' If the Company_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Company_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Company_Desc.Text = formattedValue
                
            Else 
            
                ' Company_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Company_Desc.Text = Sel_Approver_Pending_TasksView.Company_Desc.Format(Sel_Approver_Pending_TasksView.Company_Desc.DefaultValue)
                        		
                End If
                 
            ' If the Company_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Company_Desc.Text Is Nothing _
                OrElse Me.Company_Desc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Company_Desc.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetDate_Assigned()

                  
            
        
            ' Set the Date_Assigned Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Date_Assigned is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDate_Assigned()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Date_AssignedSpecified Then
                				
                ' If the Date_Assigned is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Date_Assigned, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Date_Assigned.Text = formattedValue
                
            Else 
            
                ' Date_Assigned is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Date_Assigned.Text = Sel_Approver_Pending_TasksView.Date_Assigned.Format(Sel_Approver_Pending_TasksView.Date_Assigned.DefaultValue, "g")
                        		
                End If
                 
            ' If the Date_Assigned is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Date_Assigned.Text Is Nothing _
                OrElse Me.Date_Assigned.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Date_Assigned.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetDoc_No()

                  
            
        
            ' Set the Doc_No Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_No is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_No()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_NoSpecified Then
                				
                ' If the Doc_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_No)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_No.Text = formattedValue
                
            Else 
            
                ' Doc_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Doc_No.Text = Sel_Approver_Pending_TasksView.Doc_No.Format(Sel_Approver_Pending_TasksView.Doc_No.DefaultValue)
                        		
                End If
                 
            ' If the Doc_No is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_No.Text Is Nothing _
                OrElse Me.Doc_No.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_No.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetDoc_Title()

                  
            
        
            ' Set the Doc_Title Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Title is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Title()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TitleSpecified Then
                				
                ' If the Doc_Title is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_Title)
                              
                If Not formattedValue is Nothing Then
                              
                    Dim maxLength as Integer = Len(formattedValue)                   
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                        
                        formattedValue = HttpUtility.HtmlEncode(formattedValue)
                          
                    End If                    
                    If maxLength = CType(300, Integer) Then
                        formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,Math.Min(maxLength, Len(formattedValue))))
                        formattedValue = formattedValue & "..."
                            
                    Else
                        
                        formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                    End If
                End If  
                
                Me.Doc_Title.Text = formattedValue
                
            Else 
            
                ' Doc_Title is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Doc_Title.Text = Sel_Approver_Pending_TasksView.Doc_Title.Format(Sel_Approver_Pending_TasksView.Doc_Title.DefaultValue)
                        		
                End If
                 
            ' If the Doc_Title is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Title.Text Is Nothing _
                OrElse Me.Doc_Title.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Title.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetDoc_Total()

                  
            
        
            ' Set the Doc_Total Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TotalSpecified Then
                				
                ' If the Doc_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_Total)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_Total.Text = formattedValue
                
            Else 
            
                ' Doc_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Doc_Total.Text = Sel_Approver_Pending_TasksView.Doc_Total.Format(Sel_Approver_Pending_TasksView.Doc_Total.DefaultValue)
                        		
                End If
                 
            ' If the Doc_Total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Total.Text Is Nothing _
                OrElse Me.Doc_Total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Total.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetDoc_Type()

                  
            
        
            ' Set the Doc_Type Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.Doc_Type is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDoc_Type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Doc_TypeSpecified Then
                				
                ' If the Doc_Type is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.Doc_Type)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Doc_Type.Text = formattedValue
                
            Else 
            
                ' Doc_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Doc_Type.Text = Sel_Approver_Pending_TasksView.Doc_Type.Format(Sel_Approver_Pending_TasksView.Doc_Type.DefaultValue)
                        		
                End If
                 
            ' If the Doc_Type is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Doc_Type.Text Is Nothing _
                OrElse Me.Doc_Type.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Doc_Type.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetPK_ID()

                  
            
        
            ' Set the PK_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.PK_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPK_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PK_IDSpecified Then
                				
                ' If the PK_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.PK_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PK_ID.Text = formattedValue
                
            Else 
            
                ' PK_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.PK_ID.Text = Sel_Approver_Pending_TasksView.PK_ID.Format(Sel_Approver_Pending_TasksView.PK_ID.DefaultValue)
                        		
                End If
                 
            ' If the PK_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PK_ID.Text Is Nothing _
                OrElse Me.PK_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PK_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetSortOrder()

                  
            
        
            ' Set the SortOrder Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.SortOrder is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSortOrder()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SortOrderSpecified Then
                				
                ' If the SortOrder is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.SortOrder)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SortOrder.Text = formattedValue
                
            Else 
            
                ' SortOrder is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.SortOrder.Text = Sel_Approver_Pending_TasksView.SortOrder.Format(Sel_Approver_Pending_TasksView.SortOrder.DefaultValue)
                        		
                End If
                 
            ' If the SortOrder is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SortOrder.Text Is Nothing _
                OrElse Me.SortOrder.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SortOrder.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetSSC_CompanyID()

                  
            
        
            ' Set the SSC_CompanyID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.SSC_CompanyID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSSC_CompanyID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SSC_CompanyIDSpecified Then
                				
                ' If the SSC_CompanyID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.SSC_CompanyID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SSC_CompanyID.Text = formattedValue
                
            Else 
            
                ' SSC_CompanyID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.SSC_CompanyID.Text = Sel_Approver_Pending_TasksView.SSC_CompanyID.Format(Sel_Approver_Pending_TasksView.SSC_CompanyID.DefaultValue)
                        		
                End If
                 
            ' If the SSC_CompanyID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SSC_CompanyID.Text Is Nothing _
                OrElse Me.SSC_CompanyID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SSC_CompanyID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetW_U_ID()

                  
            
        
            ' Set the W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_Approver_Pending_Tasks record retrieved from the database.
            ' Me.W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetW_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.W_U_IDSpecified Then
                				
                ' If the W_U_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_Approver_Pending_TasksView.W_U_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.W_U_ID.Text = formattedValue
                
            Else 
            
                ' W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.W_U_ID.Text = Sel_Approver_Pending_TasksView.W_U_ID.Format(Sel_Approver_Pending_TasksView.W_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the W_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.W_U_ID.Text Is Nothing _
                OrElse Me.W_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.W_U_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetC_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetCompany_DescLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetDate_AssignedLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetDoc_NoLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetDoc_TitleLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetDoc_TotalLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetDoc_TypeLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetPK_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortOrderLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSSC_CompanyIDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetW_U_IDLabel()

                  
                  
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

      
        
        ' To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
              
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
              
                DirectCast(GetParentControlObject(Me, "Sel_Approver_Pending_TasksTableControl"), Sel_Approver_Pending_TasksTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Sel_Approver_Pending_TasksTableControl"), Sel_Approver_Pending_TasksTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetC_ID()
            GetCompany_Desc()
            GetDate_Assigned()
            GetDoc_No()
            GetDoc_Title()
            GetDoc_Total()
            GetDoc_Type()
            GetPK_ID()
            GetSortOrder()
            GetSSC_CompanyID()
            GetW_U_ID()
        End Sub
        
        
        Public Overridable Sub GetC_ID()
            
        End Sub
                
        Public Overridable Sub GetCompany_Desc()
            
        End Sub
                
        Public Overridable Sub GetDate_Assigned()
            
        End Sub
                
        Public Overridable Sub GetDoc_No()
            
        End Sub
                
        Public Overridable Sub GetDoc_Title()
            
        End Sub
                
        Public Overridable Sub GetDoc_Total()
            
        End Sub
                
        Public Overridable Sub GetDoc_Type()
            
        End Sub
                
        Public Overridable Sub GetPK_ID()
            
        End Sub
                
        Public Overridable Sub GetSortOrder()
            
        End Sub
                
        Public Overridable Sub GetSSC_CompanyID()
            
        End Sub
                
        Public Overridable Sub GetW_U_ID()
            
        End Sub
                
      
        ' To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in Sel_Approver_Pending_TasksTableControlRow.
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

            
        Public Property DataSource() As Sel_Approver_Pending_TasksRecord
            Get
                Return DirectCast(MyBase._DataSource, Sel_Approver_Pending_TasksRecord)
            End Get
            Set(ByVal value As Sel_Approver_Pending_TasksRecord)
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
        
        Public ReadOnly Property C_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "C_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Company_Desc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Company_Desc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Company_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Company_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Date_Assigned() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Date_Assigned"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Date_AssignedLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Date_AssignedLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Doc_No() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_No"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Doc_NoLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_NoLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Doc_Title() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Title"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Doc_TitleLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TitleLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Doc_Total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Doc_TotalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TotalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Doc_Type() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_Type"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Doc_TypeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TypeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property PK_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PK_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property PK_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PK_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SortOrder() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortOrder"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SortOrderLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortOrderLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SSC_CompanyID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SSC_CompanyID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SSC_CompanyIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SSC_CompanyIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property W_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "W_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "W_U_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As Sel_Approver_Pending_TasksRecord = Nothing
             
        
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
            
            Dim rec As Sel_Approver_Pending_TasksRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Sel_Approver_Pending_TasksRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
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

  

' Base class for the Sel_Approver_Pending_TasksTableControl control on the Show_Sel_Approver_Pending_Tasks_Table page.
' Do not modify this class. Instead override any method in Sel_Approver_Pending_TasksTableControl.
Public Class BaseSel_Approver_Pending_TasksTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SortControl) 				
                    initialVal = Me.GetFromSession(Me.SortControl)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.SortControl.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.SortControl.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.Doc_TypeFilter) 				
                    initialVal = Me.GetFromSession(Me.Doc_TypeFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""Doc_Type"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Dim Doc_TypeFilteritemListFromSession() As String = initialVal.Split(","c)
                        Dim index As Integer = 0
                        For Each item As String In Doc_TypeFilteritemListFromSession
                            If index = 0 AndAlso _
                               item.ToString.Equals("") Then
                            Else
                                Me.Doc_TypeFilter.Items.Add(item)
                                Me.Doc_TypeFilter.Items.Item(index).Selected = True
                                index += 1
                            End If
                        Next
                        Dim listItem As ListItem
                        For Each listItem In Me.Doc_TypeFilter.Items
                            listItem.Selected = True
                        Next
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SearchText) 				
                    initialVal = Me.GetFromSession(Me.SearchText)
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.SearchText.Text = initialVal
                            
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
            
              AddHandler Me.Pagination.FirstPage.Click, AddressOf Pagination_FirstPage_Click
                        
              AddHandler Me.Pagination.LastPage.Click, AddressOf Pagination_LastPage_Click
                        
              AddHandler Me.Pagination.NextPage.Click, AddressOf Pagination_NextPage_Click
                        
              AddHandler Me.Pagination.PageSizeButton.Click, AddressOf Pagination_PageSizeButton_Click
                        
              AddHandler Me.Pagination.PreviousPage.Click, AddressOf Pagination_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.ExcelButton.Click, AddressOf ExcelButton_Click
                        
              AddHandler Me.PDFButton.Click, AddressOf PDFButton_Click
                        
              AddHandler Me.ResetButton.Click, AddressOf ResetButton_Click
                        
              AddHandler Me.SearchButton.Click, AddressOf SearchButton_Click
                        
              AddHandler Me.WordButton.Click, AddressOf WordButton_Click
                        
              AddHandler Me.ActionsButton.Button.Click, AddressOf ActionsButton_Click
                        
              AddHandler Me.FilterButton.Button.Click, AddressOf FilterButton_Click
                        
              AddHandler Me.FiltersButton.Button.Click, AddressOf FiltersButton_Click
                        
            AddHandler Me.SortControl.SelectedIndexChanged, AddressOf SortControl_SelectedIndexChanged
              AddHandler Me.Doc_TypeFilter.SelectedIndexChanged, AddressOf Doc_TypeFilter_SelectedIndexChanged                  
                        
        
          ' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "SearchTextSearchBoxText", "setSearchBoxText(""" & BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) & """, """ & SearchText.ClientID & """);", True)                  
            
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
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
                    For Each rc As Sel_Approver_Pending_TasksTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
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
            ByVal pageSize As Integer) As Sel_Approver_Pending_TasksRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column1, True)         
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column2, True)          
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return Sel_Approver_Pending_TasksView.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New Sel_Approver_Pending_TasksView
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column1, True)         
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column2, True)          
            ' selCols.Add(Sel_Approver_Pending_TasksView.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return Sel_Approver_Pending_TasksView.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Sel_Approver_Pending_TasksView
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
               
            ' Setup the pagination controls.
            BindPaginationControls()

      

    
        
          ' Bind the repeater with the list of records to expand the UI.
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_TasksTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As Sel_Approver_Pending_TasksTableControlRow = DirectCast(repItem.FindControl("Sel_Approver_Pending_TasksTableControlRow"), Sel_Approver_Pending_TasksTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                SetDoc_TypeFilter()
                SetDoc_TypeLabel1()
                
                
                
                
                
                
                
                SetSearchText()
                SetSortByLabel()
                SetSortControl()
                
                
                SetExcelButton()
              
                SetPDFButton()
              
                SetResetButton()
              
                SetSearchButton()
              
                SetWordButton()
              
                SetActionsButton()
              
                SetFilterButton()
              
                SetFiltersButton()
              
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
             
              SetFiltersButton()
                     
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"ExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"PDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"WordButton"))
                        
        
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

            
            Me.Doc_TypeFilter.ClearSelection()
            
            Me.SortControl.ClearSelection()
            
            Me.SearchText.Text = ""
            
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
                    
                Me.Pagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination.CurrentPage.Text = "0"
            End If
            Me.Pagination.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for Sel_Approver_Pending_TasksTableControl pagination.
        
            Me.Pagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Sel_Approver_Pending_TasksTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If recCtl.Visible Then
                    recCtl.SaveData()
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
            Sel_Approver_Pending_TasksView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              

                  Dim totalSelectedItemCount as Integer = 0
                  
            If IsValueSelected(Me.Doc_TypeFilter) Then
    
              hasFiltersSel_Approver_Pending_TasksTableControl = True            
    
                Dim item As ListItem
                Dim selectedItemCount As Integer = 0
                For Each item In Me.Doc_TypeFilter.Items
                    If item.Selected Then
                        selectedItemCount += 1
                        
                          totalSelectedItemCount += 1
                        
                    End If
                Next
                
                Dim filter As WhereClause = New WhereClause
                For Each item In Me.Doc_TypeFilter.Items
                    If item.Selected AndAlso (item.Value = "--ANY--" OrElse item.Value = "--PLEASE_SELECT--") AndAlso selectedItemCount > 1 Then
                        item.Selected = False
                    End If
                    If item.Selected Then
                        filter.iOR(Sel_Approver_Pending_TasksView.Doc_Type, BaseFilter.ComparisonOperator.EqualsTo, item.Value, False, False)
                    End If
                Next
                wc.iAND(filter)
                
            End If
                  
                
                       
            If IsValueSelected(Me.SearchText) Then
              If Me.SearchText.Text = BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) Then
                 Me.SearchText.Text = ""
              Else
              ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
              
                If Me.SearchText.Text.StartsWith(BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing)) Then
                Me.SearchText.Text = ""
                Else
              
                    If Me.SearchText.Text.StartsWith("...") Then
                        Me.SearchText.Text = Me.SearchText.Text.SubString(3,Me.SearchText.Text.Length-3)
                    End If
                    If Me.SearchText.Text.EndsWith("...") then
                        Me.SearchText.Text = Me.SearchText.Text.SubString(0,Me.SearchText.Text.Length-3)
                        ' Strip the last word as well as it is likely only a partial word
                        Dim endindex As Integer = SearchText.Text.Length - 1
                        While (Not Char.IsWhiteSpace(SearchText.Text(endindex)) AndAlso endindex > 0)
                            endindex -= 1
                        End While
                        If endindex > 0 Then
                            SearchText.Text = SearchText.Text.Substring(0, endindex)
                        End If
              End If
            End If
            
              End If
            
              Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.SearchText, Me.GetFromSession(Me.SearchText))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.SearchText) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    Dim search As WhereClause = New WhereClause()
                    
      Dim cols As New ColumnList    
        
      cols.Add(Sel_Approver_Pending_TasksView.Company_Desc, True)
      
      For Each col As BaseColumn in cols
      
                    search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.SearchText, Me.GetFromSession(Me.SearchText)), True, False)
        
      Next
    
                    wc.iAND(search)
                End If
            End If
                  
      If (totalSelectedItemCount > 50) Then
          Throw new Exception(Page.GetResourceValue("Err:SelectedItemOverLimit", "ePortalWFApproval").Replace("{Limit}", "50").Replace("{SelectedCount}", totalSelectedItemCount.ToString()))
      End If
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Sel_Approver_Pending_TasksView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim Doc_TypeFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "Doc_TypeFilter_Ajax"), String)
            If IsValueSelected(Doc_TypeFilterSelectedValue) Then
    
              hasFiltersSel_Approver_Pending_TasksTableControl = True            
    
            If Not isNothing(Doc_TypeFilterSelectedValue) Then
                Dim Doc_TypeFilteritemListFromSession() As String = Doc_TypeFilterSelectedValue.Split(","c)
                Dim index As Integer = 0
                  
                Dim filter As WhereClause = New WhereClause
                For Each item As String In Doc_TypeFilteritemListFromSession
                    If index = 0 AndAlso item.ToString.Equals("") Then
                    Else
                        filter.iOR(Sel_Approver_Pending_TasksView.Doc_Type, BaseFilter.ComparisonOperator.EqualsTo, item, False, False)
                        index += 1
                    End If
                Next
                wc.iAND(filter)
                
             End If
                
             End If
                      
            If IsValueSelected(searchText) and fromSearchControl = "SearchText" Then
                Dim formatedSearchText as String = searchText
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If searchText.StartsWith("...") Then
                    formatedSearchText = searchText.SubString(3,searchText.Length-3)
                End If
                If searchText.EndsWith("...") Then
                    formatedSearchText = searchText.SubString(0,searchText.Length-3)
                    ' Strip the last word as well as it is likely only a partial word
                    Dim endindex As Integer = searchText.Length - 1
                    While (Not Char.IsWhiteSpace(searchText(endindex)) AndAlso endindex > 0)
                        endindex -= 1
                    End While
                    If endindex > 0 Then
                        searchText = searchText.Substring(0, endindex)
                    End If
                End If
                'After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim()
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(formatedSearchText) Then
                      ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    Dim search As WhereClause = New WhereClause()
                    
                    If InvariantLCase(AutoTypeAheadSearch).equals("wordsstartingwithsearchstring") Then
                
      Dim cols As New ColumnList    
        
      cols.Add(Sel_Approver_Pending_TasksView.Company_Desc, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
      Next
    
                    Else
                        
      Dim cols As New ColumnList    
        
      cols.Add(Sel_Approver_Pending_TasksView.Company_Desc, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
      Next
    
                    End If
                    wc.iAND(search)
                End If
            End If
                  
      
      
            Return wc
        End Function

      
        Public Overridable Function GetAutoCompletionList_SearchText(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            
            Dim filterJoin As CompoundFilter = CreateCompoundJoinFilter()
            If count = 0 Then count = 10
            Dim wc As WhereClause = CreateWhereClause(prefixText,"SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            Dim recordList () As ePortalWFApproval.Business.Sel_Approver_Pending_TasksRecord = Sel_Approver_Pending_TasksView.GetRecords(filterJoin, wc, Nothing, 0, count,count)
            Dim rec As Sel_Approver_Pending_TasksRecord = Nothing
            Dim resultItem As String = ""
            For Each rec In recordList 
                ' Exit the loop if recordList count has reached AutoTypeAheadListSize.
                If resultList.Count >= count then
                    Exit For
                End If
                ' If the field is configured to Display as Foreign key, Format() method returns the 
                ' Display as Forien Key value instead of original field value.
                ' Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                ' We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(Sel_Approver_Pending_TasksView.Company_Desc)
                If resultItem IsNot Nothing Then
                    Dim prText As String = prefixText
                    If Sel_Approver_Pending_TasksView.Company_Desc.IsFullTextSearchable Then
                         Dim ft As FullTextExpression = New FullTextExpression()
                         prText = ft.GetFirstNonExcludedTerm(prText)
                    End If
                    If Not String.IsNullOrEmpty(prText) AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
  
                        Dim isAdded As Boolean = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Sel_Approver_Pending_TasksView.Company_Desc.IsFullTextSearchable)
                        If isAdded Then
                            Continue For
                        End If
                    End If
                End If
      
            Next                
             
            resultList.Sort()
            Dim result() As String = New String(resultList.Count - 1) {}
            Array.Copy(resultList.ToArray, result, resultList.Count)
            Return result
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
        
            If Me.Pagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination.PageSize.Text)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_Approver_Pending_TasksTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As Sel_Approver_Pending_TasksTableControlRow = DirectCast(repItem.FindControl("Sel_Approver_Pending_TasksTableControlRow"), Sel_Approver_Pending_TasksTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_Approver_Pending_TasksRecord = New Sel_Approver_Pending_TasksRecord()
        
                        If recControl.C_ID.Text <> "" Then
                            rec.Parse(recControl.C_ID.Text, Sel_Approver_Pending_TasksView.C_ID)
                        End If
                        If recControl.Company_Desc.Text <> "" Then
                            rec.Parse(recControl.Company_Desc.Text, Sel_Approver_Pending_TasksView.Company_Desc)
                        End If
                        If recControl.Date_Assigned.Text <> "" Then
                            rec.Parse(recControl.Date_Assigned.Text, Sel_Approver_Pending_TasksView.Date_Assigned)
                        End If
                        If recControl.Doc_No.Text <> "" Then
                            rec.Parse(recControl.Doc_No.Text, Sel_Approver_Pending_TasksView.Doc_No)
                        End If
                        If recControl.Doc_Title.Text <> "" Then
                            rec.Parse(recControl.Doc_Title.Text, Sel_Approver_Pending_TasksView.Doc_Title)
                        End If
                        If recControl.Doc_Total.Text <> "" Then
                            rec.Parse(recControl.Doc_Total.Text, Sel_Approver_Pending_TasksView.Doc_Total)
                        End If
                        If recControl.Doc_Type.Text <> "" Then
                            rec.Parse(recControl.Doc_Type.Text, Sel_Approver_Pending_TasksView.Doc_Type)
                        End If
                        If recControl.PK_ID.Text <> "" Then
                            rec.Parse(recControl.PK_ID.Text, Sel_Approver_Pending_TasksView.PK_ID)
                        End If
                        If recControl.SortOrder.Text <> "" Then
                            rec.Parse(recControl.SortOrder.Text, Sel_Approver_Pending_TasksView.SortOrder)
                        End If
                        If recControl.SSC_CompanyID.Text <> "" Then
                            rec.Parse(recControl.SSC_CompanyID.Text, Sel_Approver_Pending_TasksView.SSC_CompanyID)
                        End If
                        If recControl.W_U_ID.Text <> "" Then
                            rec.Parse(recControl.W_U_ID.Text, Sel_Approver_Pending_TasksView.W_U_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New Sel_Approver_Pending_TasksRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Sel_Approver_Pending_TasksRecord)), Sel_Approver_Pending_TasksRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetDoc_TypeLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortByLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl()

              
            
                Me.PopulateSortControl(GetSelectedValue(Me.SortControl,  GetFromSession(Me.SortControl)), 500)					
                    
        End Sub
            
        Public Overridable Sub SetDoc_TypeFilter()

              
            
            Dim Doc_TypeFilterselectedFilterItemList As New ArrayList()
            Dim Doc_TypeFilteritemsString As String = Nothing
            If (Me.InSession(Me.Doc_TypeFilter)) Then
                Doc_TypeFilteritemsString = Me.GetFromSession(Me.Doc_TypeFilter)
            End If
            
            If (Doc_TypeFilteritemsString IsNot Nothing) Then
                Dim Doc_TypeFilteritemListFromSession() As String = Doc_TypeFilteritemsString.Split(","c)
                For Each item as String In Doc_TypeFilteritemListFromSession
                    Doc_TypeFilterselectedFilterItemList.Add(item)
                Next
            End If
              
            		
            Me.PopulateDoc_TypeFilter(GetSelectedValueList(Me.Doc_TypeFilter, Doc_TypeFilterselectedFilterItemList), 500)
                    
              Dim url as String = Me.ModifyRedirectUrl("../sel_Approver_Pending_Tasks/Sel-Approver-Pending-Tasks-QuickSelector.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.Doc_TypeFilter.ClientID & "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("Doc_Type")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--ANY--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:All")) & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.Doc_TypeFilter.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(Doc_TypeFilter.AutoPostBack).ToLower() & ", event); return false;"        
                  
                                 
              End Sub	
            
        Public Overridable Sub SetSearchText()

              
                                            
          Me.SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "') {this.value='';this.className='Search_Input';}")
          Me.SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "';this.className='Search_InputHint';}")
                                   
              End Sub	
            
        ' Get the filters' data for SortControl
        Protected Overridable Sub PopulateSortControl(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("C {Txt:Ascending}"), "C_ID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("C {Txt:Descending}"), "C_ID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Company Description {Txt:Ascending}"), "Company_Desc Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Company Description {Txt:Descending}"), "Company_Desc Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Date Assigned {Txt:Ascending}"), "Date_Assigned Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Date Assigned {Txt:Descending}"), "Date_Assigned Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Document Number {Txt:Ascending}"), "Doc_No Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Document Number {Txt:Descending}"), "Doc_No Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Document Total {Txt:Ascending}"), "Doc_Total Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Document Total {Txt:Descending}"), "Doc_Total Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Document Type {Txt:Ascending}"), "Doc_Type Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Document Type {Txt:Descending}"), "Doc_Type Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("PK {Txt:Ascending}"), "PK_ID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("PK {Txt:Descending}"), "PK_ID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Sort Order {Txt:Ascending}"), "SortOrder Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Sort Order {Txt:Descending}"), "SortOrder Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("SSC Company {Txt:Ascending}"), "SSC_CompanyID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("SSC Company {Txt:Descending}"), "SSC_CompanyID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("W U {Txt:Ascending}"), "W_U_ID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("W U {Txt:Descending}"), "W_U_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl.SelectedValue IsNot Nothing AndAlso Me.SortControl.Items.FindByValue(Me.SortControl.SelectedValue) Is Nothing
                Me.SortControl.SelectedValue = Nothing
            End If

              End Sub
            
        ' Get the filters' data for Doc_TypeFilter
        Protected Overridable Sub PopulateDoc_TypeFilter(ByVal selectedValue As ArrayList, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Dim wc As WhereClause = Me.CreateWhereClause_Doc_TypeFilter()
            Me.Doc_TypeFilter.Items.Clear()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_Doc_TypeFilter function.
            ' It is better to customize the where clause there.
            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(Sel_Approver_Pending_TasksView.Doc_Type, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = Sel_Approver_Pending_TasksView.GetValues(Sel_Approver_Pending_TasksView.Doc_Type, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( Sel_Approver_Pending_TasksView.Doc_Type.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = Sel_Approver_Pending_TasksView.Doc_Type.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.Doc_TypeFilter.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.Doc_TypeFilter.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
            Catch
            End Try
            
            
            Me.Doc_TypeFilter.SetFieldMaxLength(50)
                                 
                  
            ' Add the selected value.
            If Me.Doc_TypeFilter.Items.Count = 0 Then
                Me.Doc_TypeFilter.Items.Add(New ListItem(Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
            End If
            
            ' Mark all items to be selected.
            For Each item As ListItem in Me.Doc_TypeFilter.Items
                item.Selected = True
            Next
                              
        End Sub
            
              

        Public Overridable Function CreateWhereClause_Doc_TypeFilter() As WhereClause
          
              Dim hasFiltersSel_Approver_Pending_TasksTableControl As Boolean = False
            
            ' Create a where clause for the filter Doc_TypeFilter.
            ' This function is called by the Populate method to load the items 
            ' in the Doc_TypeFilterQuickSelector
            
            Dim Doc_TypeFilterselectedFilterItemList As New ArrayList()
            Dim Doc_TypeFilteritemsString As String = Nothing
            If (Me.InSession(Me.Doc_TypeFilter)) Then
                Doc_TypeFilteritemsString = Me.GetFromSession(Me.Doc_TypeFilter)
            End If
            
            If (Doc_TypeFilteritemsString IsNot Nothing) Then
                Dim Doc_TypeFilteritemListFromSession() As String = Doc_TypeFilteritemsString.Split(","c)
                For Each item as String In Doc_TypeFilteritemListFromSession
                    Doc_TypeFilterselectedFilterItemList.Add(item)
                Next
            End If
              
            Doc_TypeFilterselectedFilterItemList = GetSelectedValueList(Me.Doc_TypeFilter, Doc_TypeFilterselectedFilterItemList) 
            Dim wc As New WhereClause
            If Doc_TypeFilterselectedFilterItemList Is Nothing OrElse Doc_TypeFilterselectedFilterItemList.Count = 0 Then
                wc.RunQuery = False
            Else            
                For Each item As String In Doc_TypeFilterselectedFilterItemList
              
            
      
   
                    wc.iOR(Sel_Approver_Pending_TasksView.Doc_Type, BaseFilter.ComparisonOperator.EqualsTo, item)

                                
                Next
            End If
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
        
            Me.SaveToSession(Me.SortControl, Me.SortControl.SelectedValue)
                  
            Dim Doc_TypeFilterselectedFilterItemList As ArrayList = GetSelectedValueList(Me.Doc_TypeFilter, Nothing)
            Dim Doc_TypeFilterSessionString As String = ""
            If Not Doc_TypeFilterselectedFilterItemList is Nothing Then
            For Each item As String In Doc_TypeFilterselectedFilterItemList
                Doc_TypeFilterSessionstring = Doc_TypeFilterSessionstring & "," & item
            Next
            End If
            Me.SaveToSession(Me.Doc_TypeFilter, Doc_TypeFilterSessionstring)
                  
            Me.SaveToSession(Me.SearchText, Me.SearchText.Text)
                  
        
            'Save pagination state to session.
         
            
            ' Save table control properties to the session.
            
 If Not Me.CurrentSortOrder Is Nothing Then
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then
                    Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
                End If
            End If            
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            Me.SaveToSession(Me.SortControl, Me.SortControl.SelectedValue)
                  
            Dim Doc_TypeFilterselectedFilterItemList As ArrayList = GetSelectedValueList(Me.Doc_TypeFilter, Nothing)
            Dim Doc_TypeFilterSessionString As String = ""
            If Not Doc_TypeFilterselectedFilterItemList is Nothing Then
            For Each item As String In Doc_TypeFilterselectedFilterItemList
                Doc_TypeFilterSessionstring = Doc_TypeFilterSessionstring & "," & item
            Next
            End If
            Me.SaveToSession("Doc_TypeFilter_Ajax", Doc_TypeFilterSessionString)
          
      Me.SaveToSession("SearchText_Ajax", Me.SearchText.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl)
            Me.RemoveFromSession(Me.Doc_TypeFilter)
            Me.RemoveFromSession(Me.SearchText)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Sel_Approver_Pending_TasksTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination")
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
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("Sel_Approver_Pending_TasksTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetExcelButton()                
              
   
        End Sub
            
        Public Overridable Sub SetPDFButton()                
              
   
        End Sub
            
        Public Overridable Sub SetResetButton()                
              
   
        End Sub
            
        Public Overridable Sub SetSearchButton()                
              
   
        End Sub
            
        Public Overridable Sub SetWordButton()                
              
   
        End Sub
            
        Public Overridable Sub SetActionsButton()                
              
   
        End Sub
            
        Public Overridable Sub SetFilterButton()                
              
   
        End Sub
            
        Public Overridable Sub SetFiltersButton()                
                      
         Dim themeButtonFiltersButton As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "FiltersButton"), IThemeButtonWithArrow)
         themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
            If (IsValueSelected(Doc_TypeFilter)) Then
                themeButtonFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png"
            End If
        
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        
        ' event handler for ImageButton
        Public Overridable Sub ExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            ' To customize the columns or the format, override this function in Section 1 of the page 
            ' and modify it to your liking.
            ' Build the where clause based on the current filter and search criteria
            ' Create the Order By clause based on the user's current sorting preference.
          
              Dim wc As WhereClause = CreateWhereClause
              Dim orderBy As OrderBy = Nothing
              
              orderBy = CreateOrderBy
              
              Dim done As Boolean = False
              Dim val As Object = ""
              ' Read pageSize records at a time and write out the Excel file.
              Dim totalRowsReturned As Integer = 0
          
              Dim join As CompoundFilter = CreateCompoundJoinFilter()
              Me.TotalRecords = Sel_Approver_Pending_TasksView.GetRecordCount(join, wc)
              If Me.TotalRecords > 10000 Then
          
              ' Add each of the columns in order of export.
              Dim columns() as BaseColumn = New BaseColumn() { _
                         Sel_Approver_Pending_TasksView.Doc_Type, _ 
             Sel_Approver_Pending_TasksView.Company_Desc, _ 
             Sel_Approver_Pending_TasksView.Doc_No, _ 
             Sel_Approver_Pending_TasksView.Date_Assigned, _ 
             Sel_Approver_Pending_TasksView.W_U_ID, _ 
             Sel_Approver_Pending_TasksView.PK_ID, _ 
             Sel_Approver_Pending_TasksView.C_ID, _ 
             Sel_Approver_Pending_TasksView.Doc_Title, _ 
             Sel_Approver_Pending_TasksView.Doc_Total, _ 
             Sel_Approver_Pending_TasksView.SSC_CompanyID, _ 
             Sel_Approver_Pending_TasksView.SortOrder, _ 
             Nothing}
              Dim  exportData as ExportDataToCSV = New ExportDataToCSV(Sel_Approver_Pending_TasksView.Instance, wc, orderBy, columns)
              exportData.StartExport(Me.Page.Response, True)

              Dim dataForCSV As DataForExport = New DataForExport(Sel_Approver_Pending_TasksView.Instance, wc, orderBy, columns, join)

              '  Read pageSize records at a time and write out the CSV file.
              While (Not done)
                  Dim recList As ArrayList = dataForCSV.GetRows(exportData.pageSize)
                  If recList Is Nothing Then
                      Exit While 'no more records we are done
                  End If

                  totalRowsReturned = recList.Count
                  For Each rec As BaseRecord In recList
                      For Each col As BaseColumn In dataForCSV.ColumnList
                          If col Is Nothing Then
                              Continue For
                          End If

                          If Not dataForCSV.IncludeInExport(col) Then
                              Continue For
                          End If

                          val = rec.GetValue(col).ToString()
                          exportData.WriteColumnData(val, dataForCSV.IsString(col))

                      Next col
                      exportData.WriteNewRow()
                  Next rec

                  '  If we already are below the pageSize, then we are done.
                  If totalRowsReturned < exportData.pageSize Then
                      done = True
                  End If
              End While
              exportData.FinishExport(Me.Page.Response)
          Else
          
              ' Create an instance of the Excel report class with the table class, where clause and order by.
              Dim excelReport As ExportDataToExcel = New ExportDataToExcel(Sel_Approver_Pending_TasksView.Instance, wc, orderBy)
              ' Add each of the columns in order of export.
              ' To customize the data type, change the second parameter of the new ExcelColumn to be
              ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              If Me.Page.Response Is Nothing Then
                Return
              End If

              excelReport.CreateExcelBook()

              Dim width As Integer = 0
              Dim columnCounter As Integer = 0
              Dim data As DataForExport = New DataForExport(Sel_Approver_Pending_TasksView.Instance, wc, orderBy, Nothing, join)
                       data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.Doc_Type, "Default"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.Company_Desc, "Default"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.Doc_No, "Default"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.Date_Assigned, "Short Date"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.W_U_ID, "0"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.PK_ID, "0"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.C_ID, "0"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.Doc_Title, "Default"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.Doc_Total, "Standard"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.SSC_CompanyID, "0"))
             data.ColumnList.Add(New ExcelColumn(Sel_Approver_Pending_TasksView.SortOrder, "0"))


              For Each col As ExcelColumn In data.ColumnList
                  width = excelReport.GetExcelCellWidth(col)
                  If data.IncludeInExport(col) Then
                      excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col))
                      columnCounter = columnCounter + 1
                  End If
              Next col
              
              While (Not done)
                  Dim recList As ArrayList = data.GetRows(excelReport.pageSize)

                  If recList Is Nothing Then
                      Exit While 'no more records we are done
                  End If

                  totalRowsReturned = recList.Count

                  For Each rec As BaseRecord In recList
                      excelReport.AddRowToExcelBook()
                      columnCounter = 0

                      For Each col As ExcelColumn In data.ColumnList
                          If Not data.IncludeInExport(col) Then
                              Continue For
                          End If

                          Dim _isExpandableNonCompositeForeignKey As Boolean = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn)
                          If _isExpandableNonCompositeForeignKey AndAlso col.DisplayColumn.IsApplyDisplayAs Then
                              val = Sel_Approver_Pending_TasksView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
                              If val Is Nothing Then
                                  val = rec.Format(col.DisplayColumn)
                              End If
                          Else
                              val = excelReport.GetValueForExcelExport(col, rec)
                          End If
                          excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat)

                          columnCounter = columnCounter + 1
                      Next col
                  Next rec

                  ' If we already are below the pageSize, then we are done.
                  If totalRowsReturned < excelReport.pageSize Then
                      done = True
                  End If
              End While

              excelReport.SaveExcelBook(Me.Page.Response)
          End If
        
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub PDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("Show-Sel-Approver-Pending-Tasks-Table.PDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "sel_Approver_Pending_Tasks"
                ' If Show-Sel-Approver-Pending-Tasks-Table.PDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(Sel_Approver_Pending_TasksView.Doc_Type.Name, ReportEnum.Align.Left, "${Doc_Type}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Company_Desc.Name, ReportEnum.Align.Left, "${Company_Desc}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Doc_No.Name, ReportEnum.Align.Left, "${Doc_No}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Date_Assigned.Name, ReportEnum.Align.Left, "${Date_Assigned}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Sel_Approver_Pending_TasksView.W_U_ID.Name, ReportEnum.Align.Right, "${W_U_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Sel_Approver_Pending_TasksView.PK_ID.Name, ReportEnum.Align.Right, "${PK_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Sel_Approver_Pending_TasksView.C_ID.Name, ReportEnum.Align.Right, "${C_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Doc_Title.Name, ReportEnum.Align.Left, "${Doc_Title}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Doc_Total.Name, ReportEnum.Align.Right, "${Doc_Total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(Sel_Approver_Pending_TasksView.SSC_CompanyID.Name, ReportEnum.Align.Right, "${SSC_CompanyID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Sel_Approver_Pending_TasksView.SortOrder.Name, ReportEnum.Align.Right, "${SortOrder}", ReportEnum.Align.Right, 15)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
                
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = Sel_Approver_Pending_TasksView.GetRecordCount(joinFilter,whereClause)
                Dim columns As ColumnList = Sel_Approver_Pending_TasksView.GetColumnList()
                Dim records As Sel_Approver_Pending_TasksRecord() = Nothing
            
                Do 
                    
                    records = Sel_Approver_Pending_TasksView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As Sel_Approver_Pending_TasksRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${Doc_Type}", record.Format(Sel_Approver_Pending_TasksView.Doc_Type), ReportEnum.Align.Left, 300)
                             report.AddData("${Company_Desc}", record.Format(Sel_Approver_Pending_TasksView.Company_Desc), ReportEnum.Align.Left, 300)
                             report.AddData("${Doc_No}", record.Format(Sel_Approver_Pending_TasksView.Doc_No), ReportEnum.Align.Left, 300)
                             report.AddData("${Date_Assigned}", record.Format(Sel_Approver_Pending_TasksView.Date_Assigned), ReportEnum.Align.Left, 300)
                             report.AddData("${W_U_ID}", record.Format(Sel_Approver_Pending_TasksView.W_U_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${PK_ID}", record.Format(Sel_Approver_Pending_TasksView.PK_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${C_ID}", record.Format(Sel_Approver_Pending_TasksView.C_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${Doc_Title}", record.Format(Sel_Approver_Pending_TasksView.Doc_Title), ReportEnum.Align.Left, 300)
                             report.AddData("${Doc_Total}", record.Format(Sel_Approver_Pending_TasksView.Doc_Total), ReportEnum.Align.Right, 300)
                             report.AddData("${SSC_CompanyID}", record.Format(Sel_Approver_Pending_TasksView.SSC_CompanyID), ReportEnum.Align.Right, 300)
                             report.AddData("${SortOrder}", record.Format(Sel_Approver_Pending_TasksView.SortOrder), ReportEnum.Align.Right, 300)

                            report.WriteRow 
                        Next 
                        pageNum = pageNum + 1
                        recordCount += records.Length 
                    End If 
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows  AndAlso whereClause.RunQuery 
                
                report.Close 
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub ResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
              Me.Doc_TypeFilter.ClearSelection()
            Me.SortControl.ClearSelection()
              Me.SearchText.Text = ""
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, False)
                  

              End If
              

        ' Setting the DataChanged to True results in the page being refreshed with
        ' the most recent data from the database.  This happens in PreRender event
        ' based on the current sort, search and filter criteria.
        Me.DataChanged = True
            
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub SearchButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
          Me.DataChanged = True
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub WordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("Show-Sel-Approver-Pending-Tasks-Table.WordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "sel_Approver_Pending_Tasks"
                ' If Show-Sel-Approver-Pending-Tasks-Table.WordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(Sel_Approver_Pending_TasksView.Doc_Type.Name, ReportEnum.Align.Left, "${Doc_Type}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Company_Desc.Name, ReportEnum.Align.Left, "${Company_Desc}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Doc_No.Name, ReportEnum.Align.Left, "${Doc_No}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Date_Assigned.Name, ReportEnum.Align.Left, "${Date_Assigned}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Sel_Approver_Pending_TasksView.W_U_ID.Name, ReportEnum.Align.Right, "${W_U_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Sel_Approver_Pending_TasksView.PK_ID.Name, ReportEnum.Align.Right, "${PK_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Sel_Approver_Pending_TasksView.C_ID.Name, ReportEnum.Align.Right, "${C_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Doc_Title.Name, ReportEnum.Align.Left, "${Doc_Title}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Sel_Approver_Pending_TasksView.Doc_Total.Name, ReportEnum.Align.Right, "${Doc_Total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(Sel_Approver_Pending_TasksView.SSC_CompanyID.Name, ReportEnum.Align.Right, "${SSC_CompanyID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Sel_Approver_Pending_TasksView.SortOrder.Name, ReportEnum.Align.Right, "${SortOrder}", ReportEnum.Align.Right, 15)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = Sel_Approver_Pending_TasksView.GetRecordCount(joinFilter,whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = Sel_Approver_Pending_TasksView.GetColumnList()
                Dim records As Sel_Approver_Pending_TasksRecord() = Nothing
                Do
                    records = Sel_Approver_Pending_TasksView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As Sel_Approver_Pending_TasksRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${Doc_Type}", record.Format(Sel_Approver_Pending_TasksView.Doc_Type), ReportEnum.Align.Left, 300)
                             report.AddData("${Company_Desc}", record.Format(Sel_Approver_Pending_TasksView.Company_Desc), ReportEnum.Align.Left, 300)
                             report.AddData("${Doc_No}", record.Format(Sel_Approver_Pending_TasksView.Doc_No), ReportEnum.Align.Left, 300)
                             report.AddData("${Date_Assigned}", record.Format(Sel_Approver_Pending_TasksView.Date_Assigned), ReportEnum.Align.Left, 300)
                             report.AddData("${W_U_ID}", record.Format(Sel_Approver_Pending_TasksView.W_U_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${PK_ID}", record.Format(Sel_Approver_Pending_TasksView.PK_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${C_ID}", record.Format(Sel_Approver_Pending_TasksView.C_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${Doc_Title}", record.Format(Sel_Approver_Pending_TasksView.Doc_Title), ReportEnum.Align.Left, 300)
                             report.AddData("${Doc_Total}", record.Format(Sel_Approver_Pending_TasksView.Doc_Total), ReportEnum.Align.Right, 300)
                             report.AddData("${SSC_CompanyID}", record.Format(Sel_Approver_Pending_TasksView.SSC_CompanyID), ReportEnum.Align.Right, 300)
                             report.AddData("${SortOrder}", record.Format(Sel_Approver_Pending_TasksView.SortOrder), ReportEnum.Align.Right, 300)

                            report.WriteRow
                        Next
                        pageNum = pageNum + 1
                        recordCount += records.Length
                    End If
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows AndAlso whereClause.RunQuery 
                report.save
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true)
          
            Catch ex As Exception
            
       ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub ActionsButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub FilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
          Me.DataChanged = True
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub FiltersButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            'This method is initially empty to implement custom click handler.
      
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
      

        ' Generate the event handling functions for filter and search events.
        
        ' event handler for OrderSort
        Protected Overridable Sub SortControl_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
                Dim SelVal1 As String = Me.SortControl.SelectedValue.ToUpper()
                Dim words1() As String = Split(SelVal1)
                If SelVal1 <> "" Then
                SelVal1 = SelVal1.Replace(words1(words1.Length() - 1), "").TrimEnd()
                For Each ColumnNam As BaseClasses.Data.BaseColumn In Sel_Approver_Pending_TasksView.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(Sel_Approver_Pending_TasksView.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not Sel_Approver_Pending_TasksView.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not Sel_Approver_Pending_TasksView.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(Sel_Approver_Pending_TasksView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(Sel_Approver_Pending_TasksView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub Doc_TypeFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = Sel_Approver_Pending_TasksView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As Sel_Approver_Pending_TasksRecord ()
            Get
                Return DirectCast(MyBase._DataSource, Sel_Approver_Pending_TasksRecord())
            End Get
            Set(ByVal value() As Sel_Approver_Pending_TasksRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property ActionsButton() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ActionsButton"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property Doc_TypeFilter() As BaseClasses.Web.UI.WebControls.QuickSelector
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TypeFilter"), BaseClasses.Web.UI.WebControls.QuickSelector)
            End Get
        End Property
        
        Public ReadOnly Property Doc_TypeLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Doc_TypeLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property FilterButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FilterButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property FiltersButton() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FiltersButton"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property Pagination() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination"), ePortalWFApproval.UI.IPaginationModern)
          End Get
          End Property
        
        Public ReadOnly Property PDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property ResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SearchButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SearchButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SearchText() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SearchText"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property SortByLabel() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortByLabel"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
          Public ReadOnly Property SortControl() As System.Web.UI.WebControls.DropDownList
          Get
          Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortControl"), System.Web.UI.WebControls.DropDownList)
          End Get
          End Property
        
        Public ReadOnly Property Title0() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title0"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WordButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, Nothing, bEncrypt)
        End Function
    
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return EvaluateExpressions(url, arg, Nothing, bEncrypt,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, Nothing, bEncrypt)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean,ByVal includeSession As Boolean) As String
            Return EvaluateExpressions(url, arg, Nothing, bEncrypt, includeSession)
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As Sel_Approver_Pending_TasksTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Sel_Approver_Pending_TasksTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Sel_Approver_Pending_TasksTableControlRow)), Sel_Approver_Pending_TasksTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Sel_Approver_Pending_TasksTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As Sel_Approver_Pending_TasksTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        ' Localization.
                        Throw New Exception(Page.GetResourceValue("Err:CannotDelRecs", "ePortalWFApproval"))
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:CannotDelRecs", "ePortalWFApproval"))
                  
                End If
            Next
        End Sub

        Public Overridable Function GetRecordControls() As Sel_Approver_Pending_TasksTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Sel_Approver_Pending_TasksTableControlRow")
            Dim list As New List(Of Sel_Approver_Pending_TasksTableControlRow)
            For Each recCtrl As Sel_Approver_Pending_TasksTableControlRow In recCtrls
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

  