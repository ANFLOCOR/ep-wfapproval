
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Show_WCAR_Doc_Table.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.Show_WCAR_Doc_Table

#Region "Section 1: Place your customizations here."

    
Public Class Sel_WCAR_Activity_WCAR_DocTableControlRow
        Inherits BaseSel_WCAR_Activity_WCAR_DocTableControlRow
        ' The BaseSel_WCAR_Activity_WCAR_DocTableControlRow implements code for a ROW within the
        ' the Sel_WCAR_Activity_WCAR_DocTableControl table.  The BaseSel_WCAR_Activity_WCAR_DocTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Sel_WCAR_Activity_WCAR_DocTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class Sel_WCAR_Activity_WCAR_DocTableControl
        Inherits BaseSel_WCAR_Activity_WCAR_DocTableControl

    ' The BaseSel_WCAR_Activity_WCAR_DocTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Sel_WCAR_Activity_WCAR_DocTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WCAR_ActivityTableControlRow
        Inherits BaseWCAR_ActivityTableControlRow
        ' The BaseWCAR_ActivityTableControlRow implements code for a ROW within the
        ' the WCAR_ActivityTableControl table.  The BaseWCAR_ActivityTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WCAR_ActivityTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WCAR_ActivityTableControl
        Inherits BaseWCAR_ActivityTableControl

    ' The BaseWCAR_ActivityTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WCAR_ActivityTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WCAR_Doc_AttachTableControlRow
        Inherits BaseWCAR_Doc_AttachTableControlRow
        ' The BaseWCAR_Doc_AttachTableControlRow implements code for a ROW within the
        ' the WCAR_Doc_AttachTableControl table.  The BaseWCAR_Doc_AttachTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WCAR_Doc_AttachTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WCAR_Doc_AttachTableControl
        Inherits BaseWCAR_Doc_AttachTableControl

    ' The BaseWCAR_Doc_AttachTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WCAR_Doc_AttachTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WCAR_Doc_CheckerTableControlRow
        Inherits BaseWCAR_Doc_CheckerTableControlRow
        ' The BaseWCAR_Doc_CheckerTableControlRow implements code for a ROW within the
        ' the WCAR_Doc_CheckerTableControl table.  The BaseWCAR_Doc_CheckerTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WCAR_Doc_CheckerTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WCAR_Doc_CheckerTableControl
        Inherits BaseWCAR_Doc_CheckerTableControl

    ' The BaseWCAR_Doc_CheckerTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WCAR_Doc_CheckerTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WCAR_DocTableControlRow
        Inherits BaseWCAR_DocTableControlRow
        ' The BaseWCAR_DocTableControlRow implements code for a ROW within the
        ' the WCAR_DocTableControl table.  The BaseWCAR_DocTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WCAR_DocTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WCAR_DocTableControl
        Inherits BaseWCAR_DocTableControl

    ' The BaseWCAR_DocTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WCAR_DocTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Sel_WCAR_Activity_WCAR_DocTableControlRow control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in Sel_WCAR_Activity_WCAR_DocTableControlRow.
Public Class BaseSel_WCAR_Activity_WCAR_DocTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_WCAR_Activity_WCAR_DocTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in Sel_WCAR_Activity_WCAR_DocTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Sel_WCAR_Activity_WCAR_DocView.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSel_WCAR_Activity_WCAR_DocTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Sel_WCAR_Activity_WCAR_DocRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_WCAR_Activity_WCAR_DocTableControlRow.
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
        
                SetSSC_CompanyID()
                SetSSC_CompanyIDLabel()
                SetWCA_Date_Action()
                SetWCA_Date_ActionLabel()
                SetWCA_Date_Assign()
                SetWCA_Date_AssignLabel()
                SetWCA_ID()
                SetWCA_IDLabel()
                SetWCA_Is_Done()
                SetWCA_Is_DoneLabel()
                SetWCA_Remark()
                SetWCA_RemarkLabel()
                SetWCA_Status()
                SetWCA_StatusLabel()
                SetWCA_W_U_ID()
                SetWCA_W_U_IDLabel()
                SetWCA_WDT_ID()
                SetWCA_WDT_IDLabel()
                SetWCA_WS_ID()
                SetWCA_WS_IDLabel()
                SetWCA_WSD_ID()
                SetWCA_WSD_IDLabel()
                SetWCD_C_ID2()
                SetWCD_C_IDLabel1()
                SetWCD_Exp_Total1()
                SetWCD_Exp_TotalLabel1()
                SetWCD_No2()
                SetWCD_NoLabel1()
                SetWCD_Project_Title1()
                SetWCD_Project_TitleLabel1()
                SetWCD_Remark1()
                SetWCD_RemarkLabel1()
                SetWCD_Request_Date2()
                SetWCD_Request_DateLabel1()
                SetWCD_U_ID2()
                SetWCD_U_IDLabel1()
                SetWCD_WCur_ID1()
                SetWCD_WCur_IDLabel1()
      
      
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
        
        
        Public Overridable Sub SetSSC_CompanyID()

                  
            
        
            ' Set the SSC_CompanyID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.SSC_CompanyID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSSC_CompanyID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SSC_CompanyIDSpecified Then
                				
                ' If the SSC_CompanyID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.SSC_CompanyID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SSC_CompanyID.Text = formattedValue
                
            Else 
            
                ' SSC_CompanyID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.SSC_CompanyID.Text = Sel_WCAR_Activity_WCAR_DocView.SSC_CompanyID.Format(Sel_WCAR_Activity_WCAR_DocView.SSC_CompanyID.DefaultValue)
                        		
                End If
                 
            ' If the SSC_CompanyID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SSC_CompanyID.Text Is Nothing _
                OrElse Me.SSC_CompanyID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SSC_CompanyID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Date_Action()

                  
            
        
            ' Set the WCA_Date_Action Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_Date_Action is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Date_ActionSpecified Then
                				
                ' If the WCA_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Date_Action.Text = formattedValue
                
            Else 
            
                ' WCA_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Date_Action.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_Date_Action.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Date_Action.DefaultValue, "g")
                        		
                End If
                 
            ' If the WCA_Date_Action is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Date_Action.Text Is Nothing _
                OrElse Me.WCA_Date_Action.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Date_Action.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Date_Assign()

                  
            
        
            ' Set the WCA_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Date_AssignSpecified Then
                				
                ' If the WCA_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Date_Assign.Text = formattedValue
                
            Else 
            
                ' WCA_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Date_Assign.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_Date_Assign.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Date_Assign.DefaultValue, "g")
                        		
                End If
                 
            ' If the WCA_Date_Assign is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Date_Assign.Text Is Nothing _
                OrElse Me.WCA_Date_Assign.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Date_Assign.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_ID()

                  
            
        
            ' Set the WCA_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_IDSpecified Then
                				
                ' If the WCA_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_ID.Text = formattedValue
                
            Else 
            
                ' WCA_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_ID.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_ID.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_ID.Text Is Nothing _
                OrElse Me.WCA_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Is_Done()

                  
            
        
            ' Set the WCA_Is_Done Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_Is_Done is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Is_Done()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Is_DoneSpecified Then
                				
                ' If the WCA_Is_Done is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Is_Done)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Is_Done.Text = formattedValue
                
            Else 
            
                ' WCA_Is_Done is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Is_Done.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_Is_Done.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Is_Done.DefaultValue)
                        		
                End If
                 
            ' If the WCA_Is_Done is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Is_Done.Text Is Nothing _
                OrElse Me.WCA_Is_Done.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Is_Done.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Remark()

                  
            
        
            ' Set the WCA_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_RemarkSpecified Then
                				
                ' If the WCA_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Remark)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Remark.Text = formattedValue
                
            Else 
            
                ' WCA_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Remark.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_Remark.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Remark.DefaultValue)
                        		
                End If
                 
            ' If the WCA_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Remark.Text Is Nothing _
                OrElse Me.WCA_Remark.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Remark.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Status()

                  
            
        
            ' Set the WCA_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_StatusSpecified Then
                				
                ' If the WCA_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Status)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Status.Text = formattedValue
                
            Else 
            
                ' WCA_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Status.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_Status.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_Status.DefaultValue)
                        		
                End If
                 
            ' If the WCA_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Status.Text Is Nothing _
                OrElse Me.WCA_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_W_U_ID()

                  
            
        
            ' Set the WCA_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_W_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_W_U_IDSpecified Then
                				
                ' If the WCA_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WCAR_Activity_WCAR_DocView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WCAR_Activity_WCAR_DocView.WCA_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WCAR_Activity_WCAR_DocView.WCA_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WCAR_Activity_WCAR_DocView.GetDFKA(Me.DataSource.WCA_W_U_ID.ToString(),Sel_WCAR_Activity_WCAR_DocView.WCA_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCA_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_W_U_ID.Text = formattedValue
                
            Else 
            
                ' WCA_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_W_U_ID.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_W_U_ID.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_W_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_W_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_W_U_ID.Text Is Nothing _
                OrElse Me.WCA_W_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_W_U_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_WDT_ID()

                  
            
        
            ' Set the WCA_WDT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_WDT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WDT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WDT_IDSpecified Then
                				
                ' If the WCA_WDT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WCAR_Activity_WCAR_DocView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WCAR_Activity_WCAR_DocView.WCA_WDT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WCAR_Activity_WCAR_DocView.WCA_WDT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WCAR_Activity_WCAR_DocView.GetDFKA(Me.DataSource.WCA_WDT_ID.ToString(),Sel_WCAR_Activity_WCAR_DocView.WCA_WDT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_WDT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCA_WDT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_WDT_ID.Text = formattedValue
                
            Else 
            
                ' WCA_WDT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_WDT_ID.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_WDT_ID.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_WDT_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_WDT_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_WDT_ID.Text Is Nothing _
                OrElse Me.WCA_WDT_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_WDT_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_WS_ID()

                  
            
        
            ' Set the WCA_WS_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_WS_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WS_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WS_IDSpecified Then
                				
                ' If the WCA_WS_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_WS_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_WS_ID.Text = formattedValue
                
            Else 
            
                ' WCA_WS_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_WS_ID.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_WS_ID.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_WS_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_WS_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_WS_ID.Text Is Nothing _
                OrElse Me.WCA_WS_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_WS_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_WSD_ID()

                  
            
        
            ' Set the WCA_WSD_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCA_WSD_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WSD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WSD_IDSpecified Then
                				
                ' If the WCA_WSD_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_WSD_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_WSD_ID.Text = formattedValue
                
            Else 
            
                ' WCA_WSD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_WSD_ID.Text = Sel_WCAR_Activity_WCAR_DocView.WCA_WSD_ID.Format(Sel_WCAR_Activity_WCAR_DocView.WCA_WSD_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_WSD_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_WSD_ID.Text Is Nothing _
                OrElse Me.WCA_WSD_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_WSD_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_C_ID2()

                  
            
        
            ' Set the WCD_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCD_C_ID2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_C_ID2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_C_IDSpecified Then
                				
                ' If the WCD_C_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_C_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_C_ID2.Text = formattedValue
                
            Else 
            
                ' WCD_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_C_ID2.Text = Sel_WCAR_Activity_WCAR_DocView.WCD_C_ID.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_C_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCD_C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_C_ID2.Text Is Nothing _
                OrElse Me.WCD_C_ID2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_C_ID2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Total1()

                  
            
        
            ' Set the WCD_Exp_Total Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Total1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Total1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_TotalSpecified Then
                				
                ' If the WCD_Exp_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_Exp_Total)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Total1.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Total1.Text = Sel_WCAR_Activity_WCAR_DocView.WCD_Exp_Total.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_Exp_Total.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Exp_Total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Total1.Text Is Nothing _
                OrElse Me.WCD_Exp_Total1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Total1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_No2()

                  
            
        
            ' Set the WCD_No Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCD_No2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_No2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_NoSpecified Then
                				
                ' If the WCD_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_No)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_No2.Text = formattedValue
                
            Else 
            
                ' WCD_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_No2.Text = Sel_WCAR_Activity_WCAR_DocView.WCD_No.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_No.DefaultValue)
                        		
                End If
                 
            ' If the WCD_No is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_No2.Text Is Nothing _
                OrElse Me.WCD_No2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_No2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Project_Title1()

                  
            
        
            ' Set the WCD_Project_Title Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCD_Project_Title1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Project_Title1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Project_TitleSpecified Then
                				
                ' If the WCD_Project_Title is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_Project_Title)
                              
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    Dim originalLength As Integer = maxLength
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                                      
                        formattedValue = HttpUtility.HtmlEncode(formattedValue)
                          
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If originalLength >= popupThreshold Then
                      
                        Dim name As String = HttpUtility.HtmlEncode(Sel_WCAR_Activity_WCAR_DocView.WCD_Project_Title.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.Sel_WCAR_Activity_WCAR_DocView, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WCD_Project_Title\"", \""WCD_Project_Title1\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, Len(formattedValue))))
                      
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        Else
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    End If
                End If  
                
                Me.WCD_Project_Title1.Text = formattedValue
                
            Else 
            
                ' WCD_Project_Title is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Project_Title1.Text = Sel_WCAR_Activity_WCAR_DocView.WCD_Project_Title.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_Project_Title.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Project_Title is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Project_Title1.Text Is Nothing _
                OrElse Me.WCD_Project_Title1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Project_Title1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Remark1()

                  
            
        
            ' Set the WCD_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCD_Remark1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Remark1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_RemarkSpecified Then
                				
                ' If the WCD_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_Remark)
                              
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    Dim originalLength As Integer = maxLength
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                                      
                        formattedValue = HttpUtility.HtmlEncode(formattedValue)
                          
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If originalLength >= popupThreshold Then
                      
                        Dim name As String = HttpUtility.HtmlEncode(Sel_WCAR_Activity_WCAR_DocView.WCD_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.Sel_WCAR_Activity_WCAR_DocView, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WCD_Remark\"", \""WCD_Remark1\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, Len(formattedValue))))
                      
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        Else
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    End If
                End If  
                
                Me.WCD_Remark1.Text = formattedValue
                
            Else 
            
                ' WCD_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Remark1.Text = Sel_WCAR_Activity_WCAR_DocView.WCD_Remark.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_Remark.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Remark1.Text Is Nothing _
                OrElse Me.WCD_Remark1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Remark1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Request_Date2()

                  
            
        
            ' Set the WCD_Request_Date Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCD_Request_Date2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Request_Date2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Request_DateSpecified Then
                				
                ' If the WCD_Request_Date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_Request_Date, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Request_Date2.Text = formattedValue
                
            Else 
            
                ' WCD_Request_Date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Request_Date2.Text = Sel_WCAR_Activity_WCAR_DocView.WCD_Request_Date.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_Request_Date.DefaultValue, "g")
                        		
                End If
                 
            ' If the WCD_Request_Date is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Request_Date2.Text Is Nothing _
                OrElse Me.WCD_Request_Date2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Request_Date2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_U_ID2()

                  
            
        
            ' Set the WCD_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCD_U_ID2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_U_ID2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_U_IDSpecified Then
                				
                ' If the WCD_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WCAR_Activity_WCAR_DocView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WCAR_Activity_WCAR_DocView.WCD_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WCAR_Activity_WCAR_DocView.WCD_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WCAR_Activity_WCAR_DocView.GetDFKA(Me.DataSource.WCD_U_ID.ToString(),Sel_WCAR_Activity_WCAR_DocView.WCD_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCD_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_U_ID2.Text = formattedValue
                
            Else 
            
                ' WCD_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_U_ID2.Text = Sel_WCAR_Activity_WCAR_DocView.WCD_U_ID.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCD_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_U_ID2.Text Is Nothing _
                OrElse Me.WCD_U_ID2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_U_ID2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_WCur_ID1()

                  
            
        
            ' Set the WCD_WCur_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.sel_WCAR_Activity_WCAR_Doc record retrieved from the database.
            ' Me.WCD_WCur_ID1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_WCur_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_WCur_IDSpecified Then
                				
                ' If the WCD_WCur_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WCAR_Activity_WCAR_DocView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WCAR_Activity_WCAR_DocView.WCD_WCur_ID)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WCAR_Activity_WCAR_DocView.WCD_WCur_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WCAR_Activity_WCAR_DocView.GetDFKA(Me.DataSource.WCD_WCur_ID.ToString(),Sel_WCAR_Activity_WCAR_DocView.WCD_WCur_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_WCur_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCD_WCur_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_WCur_ID1.Text = formattedValue
                
            Else 
            
                ' WCD_WCur_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_WCur_ID1.Text = Sel_WCAR_Activity_WCAR_DocView.WCD_WCur_ID.Format(Sel_WCAR_Activity_WCAR_DocView.WCD_WCur_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCD_WCur_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_WCur_ID1.Text Is Nothing _
                OrElse Me.WCD_WCur_ID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_WCur_ID1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetSSC_CompanyIDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_Date_ActionLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_Date_AssignLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_Is_DoneLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_RemarkLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_StatusLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_W_U_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WDT_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WS_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WSD_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_C_IDLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_TotalLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_NoLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Project_TitleLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_RemarkLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Request_DateLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_U_IDLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_WCur_IDLabel1()

                  
                  
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

      
        
        ' To customize, override this method in Sel_WCAR_Activity_WCAR_DocTableControlRow.
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
        
        Dim parentCtrl As WCAR_DocTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControlRow"), WCAR_DocTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WCA_WCD_ID = parentCtrl.DataSource.WCD_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "Sel_WCAR_Activity_WCAR_DocTableControl"), Sel_WCAR_Activity_WCAR_DocTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Sel_WCAR_Activity_WCAR_DocTableControl"), Sel_WCAR_Activity_WCAR_DocTableControl).ResetData = True
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

        ' To customize, override this method in Sel_WCAR_Activity_WCAR_DocTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetSSC_CompanyID()
            GetWCA_Date_Action()
            GetWCA_Date_Assign()
            GetWCA_ID()
            GetWCA_Is_Done()
            GetWCA_Remark()
            GetWCA_Status()
            GetWCA_W_U_ID()
            GetWCA_WDT_ID()
            GetWCA_WS_ID()
            GetWCA_WSD_ID()
            GetWCD_C_ID2()
            GetWCD_Exp_Total1()
            GetWCD_No2()
            GetWCD_Project_Title1()
            GetWCD_Remark1()
            GetWCD_Request_Date2()
            GetWCD_U_ID2()
            GetWCD_WCur_ID1()
        End Sub
        
        
        Public Overridable Sub GetSSC_CompanyID()
            
        End Sub
                
        Public Overridable Sub GetWCA_Date_Action()
            
        End Sub
                
        Public Overridable Sub GetWCA_Date_Assign()
            
        End Sub
                
        Public Overridable Sub GetWCA_ID()
            
        End Sub
                
        Public Overridable Sub GetWCA_Is_Done()
            
        End Sub
                
        Public Overridable Sub GetWCA_Remark()
            
        End Sub
                
        Public Overridable Sub GetWCA_Status()
            
        End Sub
                
        Public Overridable Sub GetWCA_W_U_ID()
            
        End Sub
                
        Public Overridable Sub GetWCA_WDT_ID()
            
        End Sub
                
        Public Overridable Sub GetWCA_WS_ID()
            
        End Sub
                
        Public Overridable Sub GetWCA_WSD_ID()
            
        End Sub
                
        Public Overridable Sub GetWCD_C_ID2()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Total1()
            
        End Sub
                
        Public Overridable Sub GetWCD_No2()
            
        End Sub
                
        Public Overridable Sub GetWCD_Project_Title1()
            
        End Sub
                
        Public Overridable Sub GetWCD_Remark1()
            
        End Sub
                
        Public Overridable Sub GetWCD_Request_Date2()
            
        End Sub
                
        Public Overridable Sub GetWCD_U_ID2()
            
        End Sub
                
        Public Overridable Sub GetWCD_WCur_ID1()
            
        End Sub
                
      
        ' To customize, override this method in Sel_WCAR_Activity_WCAR_DocTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in Sel_WCAR_Activity_WCAR_DocTableControlRow.
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
          Sel_WCAR_Activity_WCAR_DocView.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Sel_WCAR_Activity_WCAR_DocTableControl"), Sel_WCAR_Activity_WCAR_DocTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Sel_WCAR_Activity_WCAR_DocTableControl"), Sel_WCAR_Activity_WCAR_DocTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseSel_WCAR_Activity_WCAR_DocTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSel_WCAR_Activity_WCAR_DocTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As Sel_WCAR_Activity_WCAR_DocRecord
            Get
                Return DirectCast(MyBase._DataSource, Sel_WCAR_Activity_WCAR_DocRecord)
            End Get
            Set(ByVal value As Sel_WCAR_Activity_WCAR_DocRecord)
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
        
        Public ReadOnly Property WCA_Date_Action() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_Action"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Date_ActionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_ActionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Date_Assign() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_Assign"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Date_AssignLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_AssignLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Is_Done() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Is_Done"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Is_DoneLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Is_DoneLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Remark"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_W_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_WDT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WDT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_WDT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WDT_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_WS_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WS_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_WS_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WS_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_WSD_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WSD_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_WSD_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WSD_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_C_ID2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_C_ID2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_C_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_C_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Total1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Total1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_TotalLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_TotalLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_No2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_No2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_NoLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_NoLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Project_Title1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_Title1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Project_TitleLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_TitleLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Remark1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Remark1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_RemarkLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_RemarkLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Request_Date2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Request_Date2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Request_DateLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Request_DateLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_U_ID2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_U_ID2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_U_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_U_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_WCur_ID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WCur_ID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_WCur_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WCur_IDLabel1"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As Sel_WCAR_Activity_WCAR_DocRecord = Nothing
             
        
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
            
            Dim rec As Sel_WCAR_Activity_WCAR_DocRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Sel_WCAR_Activity_WCAR_DocRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Sel_WCAR_Activity_WCAR_DocView.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Sel_WCAR_Activity_WCAR_DocTableControl control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in Sel_WCAR_Activity_WCAR_DocTableControl.
Public Class BaseSel_WCAR_Activity_WCAR_DocTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SortControl1) 				
                    initialVal = Me.GetFromSession(Me.SortControl1)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.SortControl1.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.SortControl1.SelectedValue = initialVal
                            
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
            
              AddHandler Me.Pagination1.FirstPage.Click, AddressOf Pagination1_FirstPage_Click
                        
              AddHandler Me.Pagination1.LastPage.Click, AddressOf Pagination1_LastPage_Click
                        
              AddHandler Me.Pagination1.NextPage.Click, AddressOf Pagination1_NextPage_Click
                        
              AddHandler Me.Pagination1.PageSizeButton.Click, AddressOf Pagination1_PageSizeButton_Click
                        
              AddHandler Me.Pagination1.PreviousPage.Click, AddressOf Pagination1_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.Filters1Button.Button.Click, AddressOf Filters1Button_Click
                        
            AddHandler Me.SortControl1.SelectedIndexChanged, AddressOf SortControl1_SelectedIndexChanged        
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_WCAR_Activity_WCAR_DocRecord)), Sel_WCAR_Activity_WCAR_DocRecord())
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
                    For Each rc As Sel_WCAR_Activity_WCAR_DocTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_WCAR_Activity_WCAR_DocRecord)), Sel_WCAR_Activity_WCAR_DocRecord())
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
            ByVal pageSize As Integer) As Sel_WCAR_Activity_WCAR_DocRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WCAR_Activity_WCAR_DocView.Column1, True)         
            ' selCols.Add(Sel_WCAR_Activity_WCAR_DocView.Column2, True)          
            ' selCols.Add(Sel_WCAR_Activity_WCAR_DocView.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return Sel_WCAR_Activity_WCAR_DocView.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New Sel_WCAR_Activity_WCAR_DocView
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Sel_WCAR_Activity_WCAR_DocRecord)), Sel_WCAR_Activity_WCAR_DocRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WCAR_Activity_WCAR_DocView.Column1, True)         
            ' selCols.Add(Sel_WCAR_Activity_WCAR_DocView.Column2, True)          
            ' selCols.Add(Sel_WCAR_Activity_WCAR_DocView.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return Sel_WCAR_Activity_WCAR_DocView.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Sel_WCAR_Activity_WCAR_DocView
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WCAR_Activity_WCAR_DocTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As Sel_WCAR_Activity_WCAR_DocTableControlRow = DirectCast(repItem.FindControl("Sel_WCAR_Activity_WCAR_DocTableControlRow"), Sel_WCAR_Activity_WCAR_DocTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                SetSortByLabel1()
                SetSortControl1()
                SetFilters1Button()
              
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
             
              SetFilters1Button()
                     
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(Sel_WCAR_Activity_WCAR_DocView.WCA_W_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCAR_Activity_WCAR_DocView.WCA_WDT_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCAR_Activity_WCAR_DocView.WCD_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCAR_Activity_WCAR_DocView.WCD_WCur_ID, Me.DataSource)
          
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
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination1.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination1.CurrentPage.Text = "0"
            End If
            Me.Pagination1.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for Sel_WCAR_Activity_WCAR_DocTableControl pagination.
        
            Me.Pagination1.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination1.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination1.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination1.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination1.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination1.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination1.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination1.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Sel_WCAR_Activity_WCAR_DocTableControlRow
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
            Sel_WCAR_Activity_WCAR_DocView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wCAR_DocRecordObj as KeyValue
        wCAR_DocRecordObj = Nothing
      
              Dim wCAR_DocTableControlObjRow As WCAR_DocTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControlRow") ,WCAR_DocTableControlRow)
            
                If (Not IsNothing(wCAR_DocTableControlObjRow) AndAlso Not IsNothing(wCAR_DocTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wCAR_DocTableControlObjRow.GetRecord().WCD_ID))
                    wc.iAND(Sel_WCAR_Activity_WCAR_DocView.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, wCAR_DocTableControlObjRow.GetRecord().WCD_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("Sel_WCAR_Activity_WCAR_DocTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Sel_WCAR_Activity_WCAR_DocView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
        
          Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
        
          Dim hasFiltersWCAR_DocTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWCAR_DocTableControl as String = DirectCast(HttpContext.Current.Session("Sel_WCAR_Activity_WCAR_DocTableControlWhereClause"), String)
            
            If Not selectedRecordInWCAR_DocTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWCAR_DocTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWCAR_DocTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Sel_WCAR_Activity_WCAR_DocView.WCA_WCD_ID) Then
            wc.iAND(Sel_WCAR_Activity_WCAR_DocView.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Sel_WCAR_Activity_WCAR_DocView.WCA_WCD_ID).ToString())
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
        
            If Me.Pagination1.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination1.PageSize.Text)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WCAR_Activity_WCAR_DocTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As Sel_WCAR_Activity_WCAR_DocTableControlRow = DirectCast(repItem.FindControl("Sel_WCAR_Activity_WCAR_DocTableControlRow"), Sel_WCAR_Activity_WCAR_DocTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_WCAR_Activity_WCAR_DocRecord = New Sel_WCAR_Activity_WCAR_DocRecord()
        
                        If recControl.SSC_CompanyID.Text <> "" Then
                            rec.Parse(recControl.SSC_CompanyID.Text, Sel_WCAR_Activity_WCAR_DocView.SSC_CompanyID)
                        End If
                        If recControl.WCA_Date_Action.Text <> "" Then
                            rec.Parse(recControl.WCA_Date_Action.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_Date_Action)
                        End If
                        If recControl.WCA_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.WCA_Date_Assign.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_Date_Assign)
                        End If
                        If recControl.WCA_ID.Text <> "" Then
                            rec.Parse(recControl.WCA_ID.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_ID)
                        End If
                        If recControl.WCA_Is_Done.Text <> "" Then
                            rec.Parse(recControl.WCA_Is_Done.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_Is_Done)
                        End If
                        If recControl.WCA_Remark.Text <> "" Then
                            rec.Parse(recControl.WCA_Remark.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_Remark)
                        End If
                        If recControl.WCA_Status.Text <> "" Then
                            rec.Parse(recControl.WCA_Status.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_Status)
                        End If
                        If recControl.WCA_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.WCA_W_U_ID.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_W_U_ID)
                        End If
                        If recControl.WCA_WDT_ID.Text <> "" Then
                            rec.Parse(recControl.WCA_WDT_ID.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_WDT_ID)
                        End If
                        If recControl.WCA_WS_ID.Text <> "" Then
                            rec.Parse(recControl.WCA_WS_ID.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_WS_ID)
                        End If
                        If recControl.WCA_WSD_ID.Text <> "" Then
                            rec.Parse(recControl.WCA_WSD_ID.Text, Sel_WCAR_Activity_WCAR_DocView.WCA_WSD_ID)
                        End If
                        If recControl.WCD_C_ID2.Text <> "" Then
                            rec.Parse(recControl.WCD_C_ID2.Text, Sel_WCAR_Activity_WCAR_DocView.WCD_C_ID)
                        End If
                        If recControl.WCD_Exp_Total1.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Total1.Text, Sel_WCAR_Activity_WCAR_DocView.WCD_Exp_Total)
                        End If
                        If recControl.WCD_No2.Text <> "" Then
                            rec.Parse(recControl.WCD_No2.Text, Sel_WCAR_Activity_WCAR_DocView.WCD_No)
                        End If
                        If recControl.WCD_Project_Title1.Text <> "" Then
                            rec.Parse(recControl.WCD_Project_Title1.Text, Sel_WCAR_Activity_WCAR_DocView.WCD_Project_Title)
                        End If
                        If recControl.WCD_Remark1.Text <> "" Then
                            rec.Parse(recControl.WCD_Remark1.Text, Sel_WCAR_Activity_WCAR_DocView.WCD_Remark)
                        End If
                        If recControl.WCD_Request_Date2.Text <> "" Then
                            rec.Parse(recControl.WCD_Request_Date2.Text, Sel_WCAR_Activity_WCAR_DocView.WCD_Request_Date)
                        End If
                        If recControl.WCD_U_ID2.Text <> "" Then
                            rec.Parse(recControl.WCD_U_ID2.Text, Sel_WCAR_Activity_WCAR_DocView.WCD_U_ID)
                        End If
                        If recControl.WCD_WCur_ID1.Text <> "" Then
                            rec.Parse(recControl.WCD_WCur_ID1.Text, Sel_WCAR_Activity_WCAR_DocView.WCD_WCur_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New Sel_WCAR_Activity_WCAR_DocRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Sel_WCAR_Activity_WCAR_DocRecord)), Sel_WCAR_Activity_WCAR_DocRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Sel_WCAR_Activity_WCAR_DocTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Sel_WCAR_Activity_WCAR_DocTableControlRow) As Boolean
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
        
        Public Overridable Sub SetSortByLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl1()

              
            
                Me.PopulateSortControl1(GetSelectedValue(Me.SortControl1,  GetFromSession(Me.SortControl1)), 500)					
                    
        End Sub
            
        ' Get the filters' data for SortControl1
        Protected Overridable Sub PopulateSortControl1(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl1.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("SSC Company {Txt:Ascending}"), "SSC_CompanyID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("SSC Company {Txt:Descending}"), "SSC_CompanyID Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Date Action {Txt:Ascending}"), "WCA_Date_Action Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Date Action {Txt:Descending}"), "WCA_Date_Action Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Date Assign {Txt:Ascending}"), "WCA_Date_Assign Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Date Assign {Txt:Descending}"), "WCA_Date_Assign Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA {Txt:Ascending}"), "WCA_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA {Txt:Descending}"), "WCA_ID Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Is Done {Txt:Ascending}"), "WCA_Is_Done Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Is Done {Txt:Descending}"), "WCA_Is_Done Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Status {Txt:Ascending}"), "WCA_Status Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Status {Txt:Descending}"), "WCA_Status Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA W U {Txt:Ascending}"), "WCA_W_U_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA W U {Txt:Descending}"), "WCA_W_U_ID Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA WDT {Txt:Ascending}"), "WCA_WDT_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA WDT {Txt:Descending}"), "WCA_WDT_ID Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Number {Txt:Ascending}"), "WCD_No Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Number {Txt:Descending}"), "WCD_No Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD U {Txt:Ascending}"), "WCD_U_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD U {Txt:Descending}"), "WCD_U_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl1, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl1.SelectedValue IsNot Nothing AndAlso Me.SortControl1.Items.FindByValue(Me.SortControl1.SelectedValue) Is Nothing
                Me.SortControl1.SelectedValue = Nothing
            End If

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
        
            Me.SaveToSession(Me.SortControl1, Me.SortControl1.SelectedValue)
                  
        
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
          
            Me.SaveToSession(Me.SortControl1, Me.SortControl1.SelectedValue)
                  
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl1)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Sel_WCAR_Activity_WCAR_DocTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination1")
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
                Me.ViewState("Sel_WCAR_Activity_WCAR_DocTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetFilters1Button()                
                      
         Dim themeButtonFilters1Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters1Button"), IThemeButtonWithArrow)
         themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination1_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination1_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination1_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination1_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination1.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination1.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination1_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Filters1Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Protected Overridable Sub SortControl1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
                Dim SelVal1 As String = Me.SortControl1.SelectedValue.ToUpper()
                Dim words1() As String = Split(SelVal1)
                If SelVal1 <> "" Then
                SelVal1 = SelVal1.Replace(words1(words1.Length() - 1), "").TrimEnd()
                For Each ColumnNam As BaseClasses.Data.BaseColumn In Sel_WCAR_Activity_WCAR_DocView.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(Sel_WCAR_Activity_WCAR_DocView.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not Sel_WCAR_Activity_WCAR_DocView.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not Sel_WCAR_Activity_WCAR_DocView.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(Sel_WCAR_Activity_WCAR_DocView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(Sel_WCAR_Activity_WCAR_DocView.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = Sel_WCAR_Activity_WCAR_DocView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As Sel_WCAR_Activity_WCAR_DocRecord ()
            Get
                Return DirectCast(MyBase._DataSource, Sel_WCAR_Activity_WCAR_DocRecord())
            End Get
            Set(ByVal value() As Sel_WCAR_Activity_WCAR_DocRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Filters1Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Filters1Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property Pagination1() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination1"), ePortalWFApproval.UI.IPaginationModern)
          End Get
          End Property
        
        Public ReadOnly Property SortByLabel1() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortByLabel1"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
          Public ReadOnly Property SortControl1() As System.Web.UI.WebControls.DropDownList
          Get
          Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortControl1"), System.Web.UI.WebControls.DropDownList)
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
                Dim recCtl As Sel_WCAR_Activity_WCAR_DocTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Sel_WCAR_Activity_WCAR_DocRecord = Nothing     
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
                Dim recCtl As Sel_WCAR_Activity_WCAR_DocTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Sel_WCAR_Activity_WCAR_DocRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As Sel_WCAR_Activity_WCAR_DocTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Sel_WCAR_Activity_WCAR_DocTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Sel_WCAR_Activity_WCAR_DocTableControlRow)), Sel_WCAR_Activity_WCAR_DocTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Sel_WCAR_Activity_WCAR_DocTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As Sel_WCAR_Activity_WCAR_DocTableControlRow
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

        Public Overridable Function GetRecordControls() As Sel_WCAR_Activity_WCAR_DocTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Sel_WCAR_Activity_WCAR_DocTableControlRow")
            Dim list As New List(Of Sel_WCAR_Activity_WCAR_DocTableControlRow)
            For Each recCtrl As Sel_WCAR_Activity_WCAR_DocTableControlRow In recCtrls
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

  
' Base class for the WCAR_ActivityTableControlRow control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in WCAR_ActivityTableControlRow.
Public Class BaseWCAR_ActivityTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCAR_ActivityTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WCAR_ActivityTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WCAR_Activity record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCAR_ActivityTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWCAR_ActivityTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WCAR_ActivityRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCAR_ActivityTableControlRow.
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
        
                SetWCA_Date_Action2()
                SetWCA_Date_ActionLabel1()
                SetWCA_Date_Assign2()
                SetWCA_Date_AssignLabel1()
                SetWCA_Is_Done2()
                SetWCA_Is_DoneLabel1()
                SetWCA_Remark1()
                SetWCA_RemarkLabel1()
                SetWCA_Status2()
                SetWCA_StatusLabel2()
                SetWCA_W_U_ID_Delegate()
                SetWCA_W_U_ID_DelegateLabel()
                SetWCA_W_U_ID2()
                SetWCA_W_U_IDLabel1()
                SetWCA_WDT_ID2()
                SetWCA_WDT_IDLabel1()
                SetWCA_WS_ID1()
                SetWCA_WS_IDLabel1()
                SetWCA_WSD_ID1()
                SetWCA_WSD_IDLabel1()
      
      
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
        
        
        Public Overridable Sub SetWCA_Date_Action2()

                  
            
        
            ' Set the WCA_Date_Action Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Date_Action2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Date_Action2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Date_ActionSpecified Then
                				
                ' If the WCA_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_ActivityTable.WCA_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Date_Action2.Text = formattedValue
                
            Else 
            
                ' WCA_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Date_Action2.Text = WCAR_ActivityTable.WCA_Date_Action.Format(WCAR_ActivityTable.WCA_Date_Action.DefaultValue, "g")
                        		
                End If
                 
            ' If the WCA_Date_Action is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Date_Action2.Text Is Nothing _
                OrElse Me.WCA_Date_Action2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Date_Action2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Date_Assign2()

                  
            
        
            ' Set the WCA_Date_Assign Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Date_Assign2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Date_Assign2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Date_AssignSpecified Then
                				
                ' If the WCA_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_ActivityTable.WCA_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Date_Assign2.Text = formattedValue
                
            Else 
            
                ' WCA_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Date_Assign2.Text = WCAR_ActivityTable.WCA_Date_Assign.Format(WCAR_ActivityTable.WCA_Date_Assign.DefaultValue, "g")
                        		
                End If
                 
            ' If the WCA_Date_Assign is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Date_Assign2.Text Is Nothing _
                OrElse Me.WCA_Date_Assign2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Date_Assign2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Is_Done2()

                  
            
        
            ' Set the WCA_Is_Done Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Is_Done2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Is_Done2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Is_DoneSpecified Then
                				
                ' If the WCA_Is_Done is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_ActivityTable.WCA_Is_Done)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Is_Done2.Text = formattedValue
                
            Else 
            
                ' WCA_Is_Done is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Is_Done2.Text = WCAR_ActivityTable.WCA_Is_Done.Format(WCAR_ActivityTable.WCA_Is_Done.DefaultValue)
                        		
                End If
                 
            ' If the WCA_Is_Done is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Is_Done2.Text Is Nothing _
                OrElse Me.WCA_Is_Done2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Is_Done2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Remark1()

                  
            
        
            ' Set the WCA_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Remark1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Remark1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_RemarkSpecified Then
                				
                ' If the WCA_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_ActivityTable.WCA_Remark)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Remark1.Text = formattedValue
                
            Else 
            
                ' WCA_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Remark1.Text = WCAR_ActivityTable.WCA_Remark.Format(WCAR_ActivityTable.WCA_Remark.DefaultValue)
                        		
                End If
                 
            ' If the WCA_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Remark1.Text Is Nothing _
                OrElse Me.WCA_Remark1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Remark1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Status2()

                  
            
        
            ' Set the WCA_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Status2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Status2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_StatusSpecified Then
                				
                ' If the WCA_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_ActivityTable.WCA_Status)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_Status2.Text = formattedValue
                
            Else 
            
                ' WCA_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Status2.Text = WCAR_ActivityTable.WCA_Status.Format(WCAR_ActivityTable.WCA_Status.DefaultValue)
                        		
                End If
                 
            ' If the WCA_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_Status2.Text Is Nothing _
                OrElse Me.WCA_Status2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_Status2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_W_U_ID_Delegate()

                  
            
        
            ' Set the WCA_W_U_ID_Delegate Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_W_U_ID_Delegate is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_W_U_ID_Delegate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_W_U_ID_DelegateSpecified Then
                				
                ' If the WCA_W_U_ID_Delegate is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_ActivityTable.WCA_W_U_ID_Delegate)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_ActivityTable.WCA_W_U_ID_Delegate.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_ActivityTable.GetDFKA(Me.DataSource.WCA_W_U_ID_Delegate.ToString(),WCAR_ActivityTable.WCA_W_U_ID_Delegate, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_ActivityTable.WCA_W_U_ID_Delegate)
                       End If
                Else
                       formattedValue = Me.DataSource.WCA_W_U_ID_Delegate.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_W_U_ID_Delegate.Text = formattedValue
                
            Else 
            
                ' WCA_W_U_ID_Delegate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_W_U_ID_Delegate.Text = WCAR_ActivityTable.WCA_W_U_ID_Delegate.Format(WCAR_ActivityTable.WCA_W_U_ID_Delegate.DefaultValue)
                        		
                End If
                 
            ' If the WCA_W_U_ID_Delegate is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_W_U_ID_Delegate.Text Is Nothing _
                OrElse Me.WCA_W_U_ID_Delegate.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_W_U_ID_Delegate.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_W_U_ID2()

                  
            
        
            ' Set the WCA_W_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_W_U_ID2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_W_U_ID2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_W_U_IDSpecified Then
                				
                ' If the WCA_W_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_ActivityTable.WCA_W_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_ActivityTable.WCA_W_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_ActivityTable.GetDFKA(Me.DataSource.WCA_W_U_ID.ToString(),WCAR_ActivityTable.WCA_W_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_ActivityTable.WCA_W_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCA_W_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_W_U_ID2.Text = formattedValue
                
            Else 
            
                ' WCA_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_W_U_ID2.Text = WCAR_ActivityTable.WCA_W_U_ID.Format(WCAR_ActivityTable.WCA_W_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_W_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_W_U_ID2.Text Is Nothing _
                OrElse Me.WCA_W_U_ID2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_W_U_ID2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_WDT_ID2()

                  
            
        
            ' Set the WCA_WDT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_WDT_ID2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WDT_ID2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WDT_IDSpecified Then
                				
                ' If the WCA_WDT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_ActivityTable.WCA_WDT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_ActivityTable.WCA_WDT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_ActivityTable.GetDFKA(Me.DataSource.WCA_WDT_ID.ToString(),WCAR_ActivityTable.WCA_WDT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_ActivityTable.WCA_WDT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCA_WDT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_WDT_ID2.Text = formattedValue
                
            Else 
            
                ' WCA_WDT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_WDT_ID2.Text = WCAR_ActivityTable.WCA_WDT_ID.Format(WCAR_ActivityTable.WCA_WDT_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_WDT_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_WDT_ID2.Text Is Nothing _
                OrElse Me.WCA_WDT_ID2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_WDT_ID2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_WS_ID1()

                  
            
        
            ' Set the WCA_WS_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_WS_ID1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WS_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WS_IDSpecified Then
                				
                ' If the WCA_WS_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_ActivityTable.WCA_WS_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_ActivityTable.WCA_WS_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_ActivityTable.GetDFKA(Me.DataSource.WCA_WS_ID.ToString(),WCAR_ActivityTable.WCA_WS_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_ActivityTable.WCA_WS_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCA_WS_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_WS_ID1.Text = formattedValue
                
            Else 
            
                ' WCA_WS_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_WS_ID1.Text = WCAR_ActivityTable.WCA_WS_ID.Format(WCAR_ActivityTable.WCA_WS_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_WS_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_WS_ID1.Text Is Nothing _
                OrElse Me.WCA_WS_ID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_WS_ID1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_WSD_ID1()

                  
            
        
            ' Set the WCA_WSD_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_WSD_ID1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WSD_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WSD_IDSpecified Then
                				
                ' If the WCA_WSD_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_ActivityTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_ActivityTable.WCA_WSD_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_ActivityTable.WCA_WSD_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_ActivityTable.GetDFKA(Me.DataSource.WCA_WSD_ID.ToString(),WCAR_ActivityTable.WCA_WSD_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_ActivityTable.WCA_WSD_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCA_WSD_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCA_WSD_ID1.Text = formattedValue
                
            Else 
            
                ' WCA_WSD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_WSD_ID1.Text = WCAR_ActivityTable.WCA_WSD_ID.Format(WCAR_ActivityTable.WCA_WSD_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCA_WSD_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCA_WSD_ID1.Text Is Nothing _
                OrElse Me.WCA_WSD_ID1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCA_WSD_ID1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCA_Date_ActionLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_Date_AssignLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_Is_DoneLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_RemarkLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_StatusLabel2()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_W_U_ID_DelegateLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_W_U_IDLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WDT_IDLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WS_IDLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WSD_IDLabel1()

                  
                  
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

      
        
        ' To customize, override this method in WCAR_ActivityTableControlRow.
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
        
        Dim parentCtrl As WCAR_DocTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControlRow"), WCAR_DocTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WCA_WCD_ID = parentCtrl.DataSource.WCD_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "WCAR_ActivityTableControl"), WCAR_ActivityTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCAR_ActivityTableControl"), WCAR_ActivityTableControl).ResetData = True
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

        ' To customize, override this method in WCAR_ActivityTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCA_Date_Action2()
            GetWCA_Date_Assign2()
            GetWCA_Is_Done2()
            GetWCA_Remark1()
            GetWCA_Status2()
            GetWCA_W_U_ID_Delegate()
            GetWCA_W_U_ID2()
            GetWCA_WDT_ID2()
            GetWCA_WS_ID1()
            GetWCA_WSD_ID1()
        End Sub
        
        
        Public Overridable Sub GetWCA_Date_Action2()
            
        End Sub
                
        Public Overridable Sub GetWCA_Date_Assign2()
            
        End Sub
                
        Public Overridable Sub GetWCA_Is_Done2()
            
        End Sub
                
        Public Overridable Sub GetWCA_Remark1()
            
        End Sub
                
        Public Overridable Sub GetWCA_Status2()
            
        End Sub
                
        Public Overridable Sub GetWCA_W_U_ID_Delegate()
            
        End Sub
                
        Public Overridable Sub GetWCA_W_U_ID2()
            
        End Sub
                
        Public Overridable Sub GetWCA_WDT_ID2()
            
        End Sub
                
        Public Overridable Sub GetWCA_WS_ID1()
            
        End Sub
                
        Public Overridable Sub GetWCA_WSD_ID1()
            
        End Sub
                
      
        ' To customize, override this method in WCAR_ActivityTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WCAR_ActivityTableControlRow.
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
          WCAR_ActivityTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WCAR_ActivityTableControl"), WCAR_ActivityTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WCAR_ActivityTableControl"), WCAR_ActivityTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWCAR_ActivityTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCAR_ActivityTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCAR_ActivityRecord
            Get
                Return DirectCast(MyBase._DataSource, WCAR_ActivityRecord)
            End Get
            Set(ByVal value As WCAR_ActivityRecord)
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
        
        Public ReadOnly Property WCA_Date_Action2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_Action2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Date_ActionLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_ActionLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Date_Assign2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_Assign2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Date_AssignLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_AssignLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Is_Done2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Is_Done2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Is_DoneLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Is_DoneLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Remark1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Remark1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_RemarkLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_RemarkLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Status2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Status2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_StatusLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_StatusLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_W_U_ID_Delegate() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_ID_Delegate"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_W_U_ID_DelegateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_ID_DelegateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_W_U_ID2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_ID2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_W_U_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_WDT_ID2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WDT_ID2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_WDT_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WDT_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_WS_ID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WS_ID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_WS_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WS_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_WSD_ID1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WSD_ID1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCA_WSD_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WSD_IDLabel1"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WCAR_ActivityRecord = Nothing
             
        
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
            
            Dim rec As WCAR_ActivityRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCAR_ActivityRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCAR_ActivityTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WCAR_ActivityTableControl control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in WCAR_ActivityTableControl.
Public Class BaseWCAR_ActivityTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SortControl2) 				
                    initialVal = Me.GetFromSession(Me.SortControl2)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.SortControl2.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.SortControl2.SelectedValue = initialVal
                            
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
            
              AddHandler Me.Pagination2.FirstPage.Click, AddressOf Pagination2_FirstPage_Click
                        
              AddHandler Me.Pagination2.LastPage.Click, AddressOf Pagination2_LastPage_Click
                        
              AddHandler Me.Pagination2.NextPage.Click, AddressOf Pagination2_NextPage_Click
                        
              AddHandler Me.Pagination2.PageSizeButton.Click, AddressOf Pagination2_PageSizeButton_Click
                        
              AddHandler Me.Pagination2.PreviousPage.Click, AddressOf Pagination2_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.Filters2Button.Button.Click, AddressOf Filters2Button_Click
                        
            AddHandler Me.SortControl2.SelectedIndexChanged, AddressOf SortControl2_SelectedIndexChanged        
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WCAR_ActivityRecord)), WCAR_ActivityRecord())
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
                    For Each rc As WCAR_ActivityTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WCAR_ActivityRecord)), WCAR_ActivityRecord())
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
            ByVal pageSize As Integer) As WCAR_ActivityRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_ActivityTable.Column1, True)         
            ' selCols.Add(WCAR_ActivityTable.Column2, True)          
            ' selCols.Add(WCAR_ActivityTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WCAR_ActivityTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WCAR_ActivityTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WCAR_ActivityRecord)), WCAR_ActivityRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_ActivityTable.Column1, True)         
            ' selCols.Add(WCAR_ActivityTable.Column2, True)          
            ' selCols.Add(WCAR_ActivityTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WCAR_ActivityTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WCAR_ActivityTable
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_ActivityTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WCAR_ActivityTableControlRow = DirectCast(repItem.FindControl("WCAR_ActivityTableControlRow"), WCAR_ActivityTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                SetSortByLabel2()
                SetSortControl2()
                SetFilters2Button()
              
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
             
              SetFilters2Button()
                     
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WCAR_ActivityTable.WCA_W_U_ID_Delegate, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_ActivityTable.WCA_W_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_ActivityTable.WCA_WDT_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_ActivityTable.WCA_WS_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_ActivityTable.WCA_WSD_ID, Me.DataSource)
          
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
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination2.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination2.CurrentPage.Text = "0"
            End If
            Me.Pagination2.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for WCAR_ActivityTableControl pagination.
        
            Me.Pagination2.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination2.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination2.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination2.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination2.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination2.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination2.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination2.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WCAR_ActivityTableControlRow
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
            WCAR_ActivityTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wCAR_DocRecordObj as KeyValue
        wCAR_DocRecordObj = Nothing
      
              Dim wCAR_DocTableControlObjRow As WCAR_DocTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControlRow") ,WCAR_DocTableControlRow)
            
                If (Not IsNothing(wCAR_DocTableControlObjRow) AndAlso Not IsNothing(wCAR_DocTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wCAR_DocTableControlObjRow.GetRecord().WCD_ID))
                    wc.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, wCAR_DocTableControlObjRow.GetRecord().WCD_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WCAR_ActivityTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WCAR_ActivityTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
        
          Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
        
          Dim hasFiltersWCAR_DocTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWCAR_DocTableControl as String = DirectCast(HttpContext.Current.Session("WCAR_ActivityTableControlWhereClause"), String)
            
            If Not selectedRecordInWCAR_DocTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWCAR_DocTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWCAR_DocTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WCAR_ActivityTable.WCA_WCD_ID) Then
            wc.iAND(WCAR_ActivityTable.WCA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WCAR_ActivityTable.WCA_WCD_ID).ToString())
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
        
            If Me.Pagination2.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination2.PageSize.Text)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_ActivityTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WCAR_ActivityTableControlRow = DirectCast(repItem.FindControl("WCAR_ActivityTableControlRow"), WCAR_ActivityTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WCAR_ActivityRecord = New WCAR_ActivityRecord()
        
                        If recControl.WCA_Date_Action2.Text <> "" Then
                            rec.Parse(recControl.WCA_Date_Action2.Text, WCAR_ActivityTable.WCA_Date_Action)
                        End If
                        If recControl.WCA_Date_Assign2.Text <> "" Then
                            rec.Parse(recControl.WCA_Date_Assign2.Text, WCAR_ActivityTable.WCA_Date_Assign)
                        End If
                        If recControl.WCA_Is_Done2.Text <> "" Then
                            rec.Parse(recControl.WCA_Is_Done2.Text, WCAR_ActivityTable.WCA_Is_Done)
                        End If
                        If recControl.WCA_Remark1.Text <> "" Then
                            rec.Parse(recControl.WCA_Remark1.Text, WCAR_ActivityTable.WCA_Remark)
                        End If
                        If recControl.WCA_Status2.Text <> "" Then
                            rec.Parse(recControl.WCA_Status2.Text, WCAR_ActivityTable.WCA_Status)
                        End If
                        If recControl.WCA_W_U_ID_Delegate.Text <> "" Then
                            rec.Parse(recControl.WCA_W_U_ID_Delegate.Text, WCAR_ActivityTable.WCA_W_U_ID_Delegate)
                        End If
                        If recControl.WCA_W_U_ID2.Text <> "" Then
                            rec.Parse(recControl.WCA_W_U_ID2.Text, WCAR_ActivityTable.WCA_W_U_ID)
                        End If
                        If recControl.WCA_WDT_ID2.Text <> "" Then
                            rec.Parse(recControl.WCA_WDT_ID2.Text, WCAR_ActivityTable.WCA_WDT_ID)
                        End If
                        If recControl.WCA_WS_ID1.Text <> "" Then
                            rec.Parse(recControl.WCA_WS_ID1.Text, WCAR_ActivityTable.WCA_WS_ID)
                        End If
                        If recControl.WCA_WSD_ID1.Text <> "" Then
                            rec.Parse(recControl.WCA_WSD_ID1.Text, WCAR_ActivityTable.WCA_WSD_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WCAR_ActivityRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WCAR_ActivityRecord)), WCAR_ActivityRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WCAR_ActivityTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WCAR_ActivityTableControlRow) As Boolean
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
        
        Public Overridable Sub SetSortByLabel2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl2()

              
            
                Me.PopulateSortControl2(GetSelectedValue(Me.SortControl2,  GetFromSession(Me.SortControl2)), 500)					
                    
        End Sub
            
        ' Get the filters' data for SortControl2
        Protected Overridable Sub PopulateSortControl2(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl2.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Date Action {Txt:Ascending}"), "WCA_Date_Action Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Date Action {Txt:Descending}"), "WCA_Date_Action Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Date Assign {Txt:Ascending}"), "WCA_Date_Assign Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Date Assign {Txt:Descending}"), "WCA_Date_Assign Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Is Done {Txt:Ascending}"), "WCA_Is_Done Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Is Done {Txt:Descending}"), "WCA_Is_Done Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Remark {Txt:Ascending}"), "WCA_Remark Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Remark {Txt:Descending}"), "WCA_Remark Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Status {Txt:Ascending}"), "WCA_Status Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA Status {Txt:Descending}"), "WCA_Status Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA W U {Txt:Ascending}"), "WCA_W_U_ID Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA W U {Txt:Descending}"), "WCA_W_U_ID Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA W U Delegate {Txt:Ascending}"), "WCA_W_U_ID_Delegate Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA W U Delegate {Txt:Descending}"), "WCA_W_U_ID_Delegate Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA WDT {Txt:Ascending}"), "WCA_WDT_ID Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA WDT {Txt:Descending}"), "WCA_WDT_ID Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA WS {Txt:Ascending}"), "WCA_WS_ID Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA WS {Txt:Descending}"), "WCA_WS_ID Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA WSD {Txt:Ascending}"), "WCA_WSD_ID Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCA WSD {Txt:Descending}"), "WCA_WSD_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl2, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl2.SelectedValue IsNot Nothing AndAlso Me.SortControl2.Items.FindByValue(Me.SortControl2.SelectedValue) Is Nothing
                Me.SortControl2.SelectedValue = Nothing
            End If

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
        
            Me.SaveToSession(Me.SortControl2, Me.SortControl2.SelectedValue)
                  
        
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
          
            Me.SaveToSession(Me.SortControl2, Me.SortControl2.SelectedValue)
                  
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl2)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WCAR_ActivityTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination2")
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
                Me.ViewState("WCAR_ActivityTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetFilters2Button()                
                      
         Dim themeButtonFilters2Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters2Button"), IThemeButtonWithArrow)
         themeButtonFilters2Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination2_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination2_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination2_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination2_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination2.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination2.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination2_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Filters2Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Protected Overridable Sub SortControl2_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
                Dim SelVal1 As String = Me.SortControl2.SelectedValue.ToUpper()
                Dim words1() As String = Split(SelVal1)
                If SelVal1 <> "" Then
                SelVal1 = SelVal1.Replace(words1(words1.Length() - 1), "").TrimEnd()
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WCAR_ActivityTable.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WCAR_ActivityTable.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WCAR_ActivityTable.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not WCAR_ActivityTable.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WCAR_ActivityTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WCAR_ActivityTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WCAR_ActivityTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WCAR_ActivityRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WCAR_ActivityRecord())
            End Get
            Set(ByVal value() As WCAR_ActivityRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Filters2Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Filters2Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property Pagination2() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination2"), ePortalWFApproval.UI.IPaginationModern)
          End Get
          End Property
        
        Public ReadOnly Property SortByLabel2() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortByLabel2"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
          Public ReadOnly Property SortControl2() As System.Web.UI.WebControls.DropDownList
          Get
          Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortControl2"), System.Web.UI.WebControls.DropDownList)
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
                Dim recCtl As WCAR_ActivityTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_ActivityRecord = Nothing     
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
                Dim recCtl As WCAR_ActivityTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_ActivityRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WCAR_ActivityTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WCAR_ActivityTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WCAR_ActivityTableControlRow)), WCAR_ActivityTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WCAR_ActivityTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WCAR_ActivityTableControlRow
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

        Public Overridable Function GetRecordControls() As WCAR_ActivityTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WCAR_ActivityTableControlRow")
            Dim list As New List(Of WCAR_ActivityTableControlRow)
            For Each recCtrl As WCAR_ActivityTableControlRow In recCtrls
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

  
' Base class for the WCAR_Doc_AttachTableControlRow control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in WCAR_Doc_AttachTableControlRow.
Public Class BaseWCAR_Doc_AttachTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCAR_Doc_AttachTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WCAR_Doc_AttachTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WCAR_Doc_Attach record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCAR_Doc_AttachTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWCAR_Doc_AttachTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WCAR_Doc_AttachRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCAR_Doc_AttachTableControlRow.
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
        
                SetWCDA_Desc()
                SetWCDA_DescLabel()
                SetWCDA_File()
                SetWCDA_FileLabel()
                SetWCDA_WAT_ID()
                SetWCDA_WAT_IDLabel()
      
      
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
        
        
        Public Overridable Sub SetWCDA_Desc()

                  
            
        
            ' Set the WCDA_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc_Attach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc_Attach record retrieved from the database.
            ' Me.WCDA_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDA_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDA_DescSpecified Then
                				
                ' If the WCDA_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc_AttachTable.WCDA_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCDA_Desc.Text = formattedValue
                
            Else 
            
                ' WCDA_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDA_Desc.Text = WCAR_Doc_AttachTable.WCDA_Desc.Format(WCAR_Doc_AttachTable.WCDA_Desc.DefaultValue)
                        		
                End If
                 
            ' If the WCDA_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDA_Desc.Text Is Nothing _
                OrElse Me.WCDA_Desc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDA_Desc.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDA_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDA_FileSpecified Then
                
                Me.WCDA_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WCDA_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WCAR_Doc_Attach") & _
                            "&Field=" & Me.Page.Encrypt("WCDA_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.WCDA_File.Visible = True
            Else
                Me.WCDA_File.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetWCDA_WAT_ID()

                  
            
        
            ' Set the WCDA_WAT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc_Attach database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc_Attach record retrieved from the database.
            ' Me.WCDA_WAT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDA_WAT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDA_WAT_IDSpecified Then
                				
                ' If the WCDA_WAT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc_AttachTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc_AttachTable.WCDA_WAT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc_AttachTable.WCDA_WAT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_Doc_AttachTable.GetDFKA(Me.DataSource.WCDA_WAT_ID.ToString(),WCAR_Doc_AttachTable.WCDA_WAT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_Doc_AttachTable.WCDA_WAT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCDA_WAT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCDA_WAT_ID.Text = formattedValue
                
            Else 
            
                ' WCDA_WAT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDA_WAT_ID.Text = WCAR_Doc_AttachTable.WCDA_WAT_ID.Format(WCAR_Doc_AttachTable.WCDA_WAT_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCDA_WAT_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDA_WAT_ID.Text Is Nothing _
                OrElse Me.WCDA_WAT_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDA_WAT_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDA_DescLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCDA_FileLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCDA_WAT_IDLabel()

                  
                  
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

      
        
        ' To customize, override this method in WCAR_Doc_AttachTableControlRow.
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
        
        Dim parentCtrl As WCAR_DocTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControlRow"), WCAR_DocTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WCDA_WCD_ID = parentCtrl.DataSource.WCD_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_AttachTableControl"), WCAR_Doc_AttachTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_AttachTableControl"), WCAR_Doc_AttachTableControl).ResetData = True
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

        ' To customize, override this method in WCAR_Doc_AttachTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCDA_Desc()
            GetWCDA_WAT_ID()
        End Sub
        
        
        Public Overridable Sub GetWCDA_Desc()
            
        End Sub
                
        Public Overridable Sub GetWCDA_WAT_ID()
            
        End Sub
                
      
        ' To customize, override this method in WCAR_Doc_AttachTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WCAR_Doc_AttachTableControlRow.
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
          WCAR_Doc_AttachTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WCAR_Doc_AttachTableControl"), WCAR_Doc_AttachTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WCAR_Doc_AttachTableControl"), WCAR_Doc_AttachTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWCAR_Doc_AttachTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCAR_Doc_AttachTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCAR_Doc_AttachRecord
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc_AttachRecord)
            End Get
            Set(ByVal value As WCAR_Doc_AttachRecord)
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
        
        Public ReadOnly Property WCDA_Desc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_Desc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCDA_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDA_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property WCDA_FileLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_FileLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDA_WAT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_WAT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCDA_WAT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDA_WAT_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WCAR_Doc_AttachRecord = Nothing
             
        
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
            
            Dim rec As WCAR_Doc_AttachRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCAR_Doc_AttachRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCAR_Doc_AttachTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WCAR_Doc_AttachTableControl control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in WCAR_Doc_AttachTableControl.
Public Class BaseWCAR_Doc_AttachTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SortControl3) 				
                    initialVal = Me.GetFromSession(Me.SortControl3)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.SortControl3.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.SortControl3.SelectedValue = initialVal
                            
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
            
              AddHandler Me.Pagination3.FirstPage.Click, AddressOf Pagination3_FirstPage_Click
                        
              AddHandler Me.Pagination3.LastPage.Click, AddressOf Pagination3_LastPage_Click
                        
              AddHandler Me.Pagination3.NextPage.Click, AddressOf Pagination3_NextPage_Click
                        
              AddHandler Me.Pagination3.PageSizeButton.Click, AddressOf Pagination3_PageSizeButton_Click
                        
              AddHandler Me.Pagination3.PreviousPage.Click, AddressOf Pagination3_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.Filters3Button.Button.Click, AddressOf Filters3Button_Click
                        
            AddHandler Me.SortControl3.SelectedIndexChanged, AddressOf SortControl3_SelectedIndexChanged        
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WCAR_Doc_AttachRecord)), WCAR_Doc_AttachRecord())
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
                    For Each rc As WCAR_Doc_AttachTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WCAR_Doc_AttachRecord)), WCAR_Doc_AttachRecord())
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
            ByVal pageSize As Integer) As WCAR_Doc_AttachRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Doc_AttachTable.Column1, True)         
            ' selCols.Add(WCAR_Doc_AttachTable.Column2, True)          
            ' selCols.Add(WCAR_Doc_AttachTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WCAR_Doc_AttachTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WCAR_Doc_AttachTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WCAR_Doc_AttachRecord)), WCAR_Doc_AttachRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Doc_AttachTable.Column1, True)         
            ' selCols.Add(WCAR_Doc_AttachTable.Column2, True)          
            ' selCols.Add(WCAR_Doc_AttachTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WCAR_Doc_AttachTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WCAR_Doc_AttachTable
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_AttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WCAR_Doc_AttachTableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_AttachTableControlRow"), WCAR_Doc_AttachTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                SetSortByLabel3()
                SetSortControl3()
                SetFilters3Button()
              
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
             
              SetFilters3Button()
                     
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WCAR_Doc_AttachTable.WCDA_WAT_ID, Me.DataSource)
          
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
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination3.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination3.CurrentPage.Text = "0"
            End If
            Me.Pagination3.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for WCAR_Doc_AttachTableControl pagination.
        
            Me.Pagination3.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination3.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination3.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination3.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination3.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination3.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination3.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination3.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WCAR_Doc_AttachTableControlRow
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
            WCAR_Doc_AttachTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wCAR_DocRecordObj as KeyValue
        wCAR_DocRecordObj = Nothing
      
              Dim wCAR_DocTableControlObjRow As WCAR_DocTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControlRow") ,WCAR_DocTableControlRow)
            
                If (Not IsNothing(wCAR_DocTableControlObjRow) AndAlso Not IsNothing(wCAR_DocTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wCAR_DocTableControlObjRow.GetRecord().WCD_ID))
                    wc.iAND(WCAR_Doc_AttachTable.WCDA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, wCAR_DocTableControlObjRow.GetRecord().WCD_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WCAR_Doc_AttachTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WCAR_Doc_AttachTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
        
          Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
        
          Dim hasFiltersWCAR_DocTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWCAR_DocTableControl as String = DirectCast(HttpContext.Current.Session("WCAR_Doc_AttachTableControlWhereClause"), String)
            
            If Not selectedRecordInWCAR_DocTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWCAR_DocTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWCAR_DocTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WCAR_Doc_AttachTable.WCDA_WCD_ID) Then
            wc.iAND(WCAR_Doc_AttachTable.WCDA_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WCAR_Doc_AttachTable.WCDA_WCD_ID).ToString())
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
        
            If Me.Pagination3.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination3.PageSize.Text)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_AttachTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WCAR_Doc_AttachTableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_AttachTableControlRow"), WCAR_Doc_AttachTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WCAR_Doc_AttachRecord = New WCAR_Doc_AttachRecord()
        
                        If recControl.WCDA_Desc.Text <> "" Then
                            rec.Parse(recControl.WCDA_Desc.Text, WCAR_Doc_AttachTable.WCDA_Desc)
                        End If
                        If recControl.WCDA_File.Text <> "" Then
                            rec.Parse(recControl.WCDA_File.Text, WCAR_Doc_AttachTable.WCDA_File)
                        End If
                        If recControl.WCDA_WAT_ID.Text <> "" Then
                            rec.Parse(recControl.WCDA_WAT_ID.Text, WCAR_Doc_AttachTable.WCDA_WAT_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WCAR_Doc_AttachRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WCAR_Doc_AttachRecord)), WCAR_Doc_AttachRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WCAR_Doc_AttachTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WCAR_Doc_AttachTableControlRow) As Boolean
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
        
        Public Overridable Sub SetSortByLabel3()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel3.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl3()

              
            
                Me.PopulateSortControl3(GetSelectedValue(Me.SortControl3,  GetFromSession(Me.SortControl3)), 500)					
                    
        End Sub
            
        ' Get the filters' data for SortControl3
        Protected Overridable Sub PopulateSortControl3(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl3.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDA Description {Txt:Ascending}"), "WCDA_Desc Asc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDA Description {Txt:Descending}"), "WCDA_Desc Desc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wcda WAT {Txt:Ascending}"), "WCDA_WAT_ID Asc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wcda WAT {Txt:Descending}"), "WCDA_WAT_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl3, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl3.SelectedValue IsNot Nothing AndAlso Me.SortControl3.Items.FindByValue(Me.SortControl3.SelectedValue) Is Nothing
                Me.SortControl3.SelectedValue = Nothing
            End If

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
        
            Me.SaveToSession(Me.SortControl3, Me.SortControl3.SelectedValue)
                  
        
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
          
            Me.SaveToSession(Me.SortControl3, Me.SortControl3.SelectedValue)
                  
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl3)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WCAR_Doc_AttachTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination3")
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
                Me.ViewState("WCAR_Doc_AttachTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetFilters3Button()                
                      
         Dim themeButtonFilters3Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters3Button"), IThemeButtonWithArrow)
         themeButtonFilters3Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination3_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination3_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination3_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination3_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination3.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination3.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination3_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Filters3Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Protected Overridable Sub SortControl3_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
                Dim SelVal1 As String = Me.SortControl3.SelectedValue.ToUpper()
                Dim words1() As String = Split(SelVal1)
                If SelVal1 <> "" Then
                SelVal1 = SelVal1.Replace(words1(words1.Length() - 1), "").TrimEnd()
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WCAR_Doc_AttachTable.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WCAR_Doc_AttachTable.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WCAR_Doc_AttachTable.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not WCAR_Doc_AttachTable.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WCAR_Doc_AttachTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WCAR_Doc_AttachTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WCAR_Doc_AttachTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WCAR_Doc_AttachRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc_AttachRecord())
            End Get
            Set(ByVal value() As WCAR_Doc_AttachRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Filters3Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Filters3Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property Pagination3() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination3"), ePortalWFApproval.UI.IPaginationModern)
          End Get
          End Property
        
        Public ReadOnly Property SortByLabel3() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortByLabel3"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
          Public ReadOnly Property SortControl3() As System.Web.UI.WebControls.DropDownList
          Get
          Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortControl3"), System.Web.UI.WebControls.DropDownList)
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
                Dim recCtl As WCAR_Doc_AttachTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Doc_AttachRecord = Nothing     
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
                Dim recCtl As WCAR_Doc_AttachTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Doc_AttachRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WCAR_Doc_AttachTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WCAR_Doc_AttachTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WCAR_Doc_AttachTableControlRow)), WCAR_Doc_AttachTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WCAR_Doc_AttachTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WCAR_Doc_AttachTableControlRow
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

        Public Overridable Function GetRecordControls() As WCAR_Doc_AttachTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WCAR_Doc_AttachTableControlRow")
            Dim list As New List(Of WCAR_Doc_AttachTableControlRow)
            For Each recCtrl As WCAR_Doc_AttachTableControlRow In recCtrls
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

  
' Base class for the WCAR_Doc_CheckerTableControlRow control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in WCAR_Doc_CheckerTableControlRow.
Public Class BaseWCAR_Doc_CheckerTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCAR_Doc_CheckerTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WCAR_Doc_CheckerTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WCAR_Doc_Checker record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCAR_Doc_CheckerTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWCAR_Doc_CheckerTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WCAR_Doc_CheckerRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCAR_Doc_CheckerTableControlRow.
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
        
                SetWCDC_Rem()
                SetWCDC_RemLabel()
                SetWCDC_Status()
                SetWCDC_StatusLabel()
                SetWCDC_U_ID()
                SetWCDC_U_IDLabel()
      
      
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
        
        
        Public Overridable Sub SetWCDC_Rem()

                  
            
        
            ' Set the WCDC_Rem Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc_Checker database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc_Checker record retrieved from the database.
            ' Me.WCDC_Rem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDC_Rem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDC_RemSpecified Then
                				
                ' If the WCDC_Rem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc_CheckerTable.WCDC_Rem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCDC_Rem.Text = formattedValue
                
            Else 
            
                ' WCDC_Rem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDC_Rem.Text = WCAR_Doc_CheckerTable.WCDC_Rem.Format(WCAR_Doc_CheckerTable.WCDC_Rem.DefaultValue)
                        		
                End If
                 
            ' If the WCDC_Rem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDC_Rem.Text Is Nothing _
                OrElse Me.WCDC_Rem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDC_Rem.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDC_Status()

                  
            
        
            ' Set the WCDC_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc_Checker database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc_Checker record retrieved from the database.
            ' Me.WCDC_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDC_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDC_StatusSpecified Then
                				
                ' If the WCDC_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Doc_CheckerTable.WCDC_Status)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCDC_Status.Text = formattedValue
                
            Else 
            
                ' WCDC_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDC_Status.Text = WCAR_Doc_CheckerTable.WCDC_Status.Format(WCAR_Doc_CheckerTable.WCDC_Status.DefaultValue)
                        		
                End If
                 
            ' If the WCDC_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDC_Status.Text Is Nothing _
                OrElse Me.WCDC_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDC_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDC_U_ID()

                  
            
        
            ' Set the WCDC_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc_Checker database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc_Checker record retrieved from the database.
            ' Me.WCDC_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDC_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDC_U_IDSpecified Then
                				
                ' If the WCDC_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Doc_CheckerTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Doc_CheckerTable.WCDC_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_Doc_CheckerTable.WCDC_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_Doc_CheckerTable.GetDFKA(Me.DataSource.WCDC_U_ID.ToString(),WCAR_Doc_CheckerTable.WCDC_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_Doc_CheckerTable.WCDC_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCDC_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCDC_U_ID.Text = formattedValue
                
            Else 
            
                ' WCDC_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDC_U_ID.Text = WCAR_Doc_CheckerTable.WCDC_U_ID.Format(WCAR_Doc_CheckerTable.WCDC_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCDC_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDC_U_ID.Text Is Nothing _
                OrElse Me.WCDC_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDC_U_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDC_RemLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCDC_StatusLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCDC_U_IDLabel()

                  
                  
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

      
        
        ' To customize, override this method in WCAR_Doc_CheckerTableControlRow.
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
        
        Dim parentCtrl As WCAR_DocTableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControlRow"), WCAR_DocTableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WCDC_WCD_ID = parentCtrl.DataSource.WCD_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_CheckerTableControl"), WCAR_Doc_CheckerTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCAR_Doc_CheckerTableControl"), WCAR_Doc_CheckerTableControl).ResetData = True
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

        ' To customize, override this method in WCAR_Doc_CheckerTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCDC_Rem()
            GetWCDC_Status()
            GetWCDC_U_ID()
        End Sub
        
        
        Public Overridable Sub GetWCDC_Rem()
            
        End Sub
                
        Public Overridable Sub GetWCDC_Status()
            
        End Sub
                
        Public Overridable Sub GetWCDC_U_ID()
            
        End Sub
                
      
        ' To customize, override this method in WCAR_Doc_CheckerTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WCAR_Doc_CheckerTableControlRow.
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
          WCAR_Doc_CheckerTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WCAR_Doc_CheckerTableControl"), WCAR_Doc_CheckerTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WCAR_Doc_CheckerTableControl"), WCAR_Doc_CheckerTableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWCAR_Doc_CheckerTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCAR_Doc_CheckerTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCAR_Doc_CheckerRecord
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc_CheckerRecord)
            End Get
            Set(ByVal value As WCAR_Doc_CheckerRecord)
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
        
        Public ReadOnly Property WCDC_Rem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_Rem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCDC_RemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_RemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDC_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCDC_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDC_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCDC_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDC_U_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WCAR_Doc_CheckerRecord = Nothing
             
        
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
            
            Dim rec As WCAR_Doc_CheckerRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCAR_Doc_CheckerRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCAR_Doc_CheckerTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WCAR_Doc_CheckerTableControl control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in WCAR_Doc_CheckerTableControl.
Public Class BaseWCAR_Doc_CheckerTableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.SortControl4) 				
                    initialVal = Me.GetFromSession(Me.SortControl4)
                   
              
              End If

              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                initialVal = ""
                End If
              
              If initialVal <> ""				
                        
                        Me.SortControl4.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.SortControl4.SelectedValue = initialVal
                            
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
            
              AddHandler Me.Pagination4.FirstPage.Click, AddressOf Pagination4_FirstPage_Click
                        
              AddHandler Me.Pagination4.LastPage.Click, AddressOf Pagination4_LastPage_Click
                        
              AddHandler Me.Pagination4.NextPage.Click, AddressOf Pagination4_NextPage_Click
                        
              AddHandler Me.Pagination4.PageSizeButton.Click, AddressOf Pagination4_PageSizeButton_Click
                        
              AddHandler Me.Pagination4.PreviousPage.Click, AddressOf Pagination4_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.Filters4Button.Button.Click, AddressOf Filters4Button_Click
                        
            AddHandler Me.SortControl4.SelectedIndexChanged, AddressOf SortControl4_SelectedIndexChanged        
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WCAR_Doc_CheckerRecord)), WCAR_Doc_CheckerRecord())
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
                    For Each rc As WCAR_Doc_CheckerTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WCAR_Doc_CheckerRecord)), WCAR_Doc_CheckerRecord())
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
            ByVal pageSize As Integer) As WCAR_Doc_CheckerRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Doc_CheckerTable.Column1, True)         
            ' selCols.Add(WCAR_Doc_CheckerTable.Column2, True)          
            ' selCols.Add(WCAR_Doc_CheckerTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WCAR_Doc_CheckerTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WCAR_Doc_CheckerTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WCAR_Doc_CheckerRecord)), WCAR_Doc_CheckerRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Doc_CheckerTable.Column1, True)         
            ' selCols.Add(WCAR_Doc_CheckerTable.Column2, True)          
            ' selCols.Add(WCAR_Doc_CheckerTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WCAR_Doc_CheckerTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WCAR_Doc_CheckerTable
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_CheckerTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WCAR_Doc_CheckerTableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_CheckerTableControlRow"), WCAR_Doc_CheckerTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                SetSortByLabel4()
                SetSortControl4()
                SetFilters4Button()
              
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                
      
            ' this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls()
            
             
              SetFilters4Button()
                     
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WCAR_Doc_CheckerTable.WCDC_U_ID, Me.DataSource)
          
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
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination4.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination4.CurrentPage.Text = "0"
            End If
            Me.Pagination4.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for WCAR_Doc_CheckerTableControl pagination.
        
            Me.Pagination4.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination4.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination4.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination4.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination4.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination4.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination4.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.Pagination4.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WCAR_Doc_CheckerTableControlRow
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
            WCAR_Doc_CheckerTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wCAR_DocRecordObj as KeyValue
        wCAR_DocRecordObj = Nothing
      
              Dim wCAR_DocTableControlObjRow As WCAR_DocTableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControlRow") ,WCAR_DocTableControlRow)
            
                If (Not IsNothing(wCAR_DocTableControlObjRow) AndAlso Not IsNothing(wCAR_DocTableControlObjRow.GetRecord()) AndAlso Not IsNothing(wCAR_DocTableControlObjRow.GetRecord().WCD_ID))
                    wc.iAND(WCAR_Doc_CheckerTable.WCDC_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, wCAR_DocTableControlObjRow.GetRecord().WCD_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("WCAR_Doc_CheckerTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WCAR_Doc_CheckerTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
        
          Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
        
          Dim hasFiltersWCAR_DocTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWCAR_DocTableControl as String = DirectCast(HttpContext.Current.Session("WCAR_Doc_CheckerTableControlWhereClause"), String)
            
            If Not selectedRecordInWCAR_DocTableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWCAR_DocTableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWCAR_DocTableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WCAR_Doc_CheckerTable.WCDC_WCD_ID) Then
            wc.iAND(WCAR_Doc_CheckerTable.WCDC_WCD_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WCAR_Doc_CheckerTable.WCDC_WCD_ID).ToString())
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
        
            If Me.Pagination4.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pagination4.PageSize.Text)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_CheckerTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WCAR_Doc_CheckerTableControlRow = DirectCast(repItem.FindControl("WCAR_Doc_CheckerTableControlRow"), WCAR_Doc_CheckerTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WCAR_Doc_CheckerRecord = New WCAR_Doc_CheckerRecord()
        
                        If recControl.WCDC_Rem.Text <> "" Then
                            rec.Parse(recControl.WCDC_Rem.Text, WCAR_Doc_CheckerTable.WCDC_Rem)
                        End If
                        If recControl.WCDC_Status.Text <> "" Then
                            rec.Parse(recControl.WCDC_Status.Text, WCAR_Doc_CheckerTable.WCDC_Status)
                        End If
                        If recControl.WCDC_U_ID.Text <> "" Then
                            rec.Parse(recControl.WCDC_U_ID.Text, WCAR_Doc_CheckerTable.WCDC_U_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WCAR_Doc_CheckerRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WCAR_Doc_CheckerRecord)), WCAR_Doc_CheckerRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WCAR_Doc_CheckerTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WCAR_Doc_CheckerTableControlRow) As Boolean
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
        
        Public Overridable Sub SetSortByLabel4()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel4.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl4()

              
            
                Me.PopulateSortControl4(GetSelectedValue(Me.SortControl4,  GetFromSession(Me.SortControl4)), 500)					
                    
        End Sub
            
        ' Get the filters' data for SortControl4
        Protected Overridable Sub PopulateSortControl4(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl4.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl4.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl4.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC REM {Txt:Ascending}"), "WCDC_Rem Asc"))
                            							
            Me.SortControl4.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC REM {Txt:Descending}"), "WCDC_Rem Desc"))
                            							
            Me.SortControl4.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC Status {Txt:Ascending}"), "WCDC_Status Asc"))
                            							
            Me.SortControl4.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC Status {Txt:Descending}"), "WCDC_Status Desc"))
                            							
            Me.SortControl4.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC U {Txt:Ascending}"), "WCDC_U_ID Asc"))
                            							
            Me.SortControl4.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDC U {Txt:Descending}"), "WCDC_U_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl4, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl4.SelectedValue IsNot Nothing AndAlso Me.SortControl4.Items.FindByValue(Me.SortControl4.SelectedValue) Is Nothing
                Me.SortControl4.SelectedValue = Nothing
            End If

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
        
            Me.SaveToSession(Me.SortControl4, Me.SortControl4.SelectedValue)
                  
        
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
          
            Me.SaveToSession(Me.SortControl4, Me.SortControl4.SelectedValue)
                  
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl4)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WCAR_Doc_CheckerTableControl_OrderBy"), String)
          
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            
            Else 
                Me.CurrentSortOrder = New OrderBy(True, False)
            
            End If
            
            
            Dim Pagination As Control = Me.FindControl("Pagination4")
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
                Me.ViewState("WCAR_Doc_CheckerTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetFilters4Button()                
                      
         Dim themeButtonFilters4Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters4Button"), IThemeButtonWithArrow)
         themeButtonFilters4Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination4_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination4_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination4_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Pagination4_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.Pagination4.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.Pagination4.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pagination4_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub Filters4Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Protected Overridable Sub SortControl4_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
        
                Dim SelVal1 As String = Me.SortControl4.SelectedValue.ToUpper()
                Dim words1() As String = Split(SelVal1)
                If SelVal1 <> "" Then
                SelVal1 = SelVal1.Replace(words1(words1.Length() - 1), "").TrimEnd()
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WCAR_Doc_CheckerTable.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WCAR_Doc_CheckerTable.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WCAR_Doc_CheckerTable.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not WCAR_Doc_CheckerTable.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WCAR_Doc_CheckerTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WCAR_Doc_CheckerTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WCAR_Doc_CheckerTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WCAR_Doc_CheckerRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Doc_CheckerRecord())
            End Get
            Set(ByVal value() As WCAR_Doc_CheckerRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Filters4Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Filters4Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property Pagination4() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination4"), ePortalWFApproval.UI.IPaginationModern)
          End Get
          End Property
        
        Public ReadOnly Property SortByLabel4() As System.Web.UI.WebControls.Label
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortByLabel4"), System.Web.UI.WebControls.Label)
            End Get
        End Property
        
          Public ReadOnly Property SortControl4() As System.Web.UI.WebControls.DropDownList
          Get
          Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortControl4"), System.Web.UI.WebControls.DropDownList)
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
                Dim recCtl As WCAR_Doc_CheckerTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Doc_CheckerRecord = Nothing     
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
                Dim recCtl As WCAR_Doc_CheckerTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Doc_CheckerRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WCAR_Doc_CheckerTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WCAR_Doc_CheckerTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WCAR_Doc_CheckerTableControlRow)), WCAR_Doc_CheckerTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WCAR_Doc_CheckerTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WCAR_Doc_CheckerTableControlRow
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

        Public Overridable Function GetRecordControls() As WCAR_Doc_CheckerTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WCAR_Doc_CheckerTableControlRow")
            Dim list As New List(Of WCAR_Doc_CheckerTableControlRow)
            For Each recCtrl As WCAR_Doc_CheckerTableControlRow In recCtrls
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

  
' Base class for the WCAR_DocTableControlRow control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in WCAR_DocTableControlRow.
Public Class BaseWCAR_DocTableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCAR_DocTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WCAR_DocTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Show confirmation message on Click
              Me.DeleteRowButton.Attributes.Add("onClick", "return (confirm(""" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ePortalWFApproval") & """));")
                  
        
              ' Register the event handlers.
          
              AddHandler Me.DeleteRowButton.Click, AddressOf DeleteRowButton_Click
                        
              AddHandler Me.EditRowButton.Click, AddressOf EditRowButton_Click
                        
              AddHandler Me.ExpandRowButton.Click, AddressOf ExpandRowButton_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WF%dbo.WCAR_Doc record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCAR_DocTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWCAR_DocTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WCAR_DocRecord()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCAR_DocTableControlRow.
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
        
                
                
                
                
                
                
                
                
                
                
                
                SetWCAR_DocTabContainer()
                SetWCD_C_ID()
                SetWCD_C_IDLabel()
                SetWCD_Created()
                SetWCD_CreatedLabel()
                SetWCD_Exp_Budget()
                SetWCD_Exp_BudgetLabel()
                SetWCD_Exp_Cur_Yr()
                SetWCD_Exp_Cur_YrLabel()
                SetWCD_Exp_Nxt_Yr()
                SetWCD_Exp_Nxt_YrLabel()
                SetWCD_Exp_Prev_Total()
                SetWCD_Exp_Prev_TotalLabel()
                SetWCD_Exp_Sub_Yr()
                SetWCD_Exp_Sub_YrLabel()
                SetWCD_Exp_Total()
                SetWCD_Exp_TotalLabel()
                SetWCD_Exp_Under_Over_Budget()
                SetWCD_Exp_Under_Over_BudgetLabel()
                SetWCD_No()
                SetWCD_NoLabel()
                SetWCD_Proj_Inc_ACB()
                SetWCD_Proj_Inc_ACBLabel()
                SetWCD_Project_No()
                SetWCD_Project_NoLabel()
                SetWCD_Project_Title()
                SetWCD_Project_TitleLabel()
                SetWCD_Remark()
                SetWCD_RemarkLabel()
                SetWCD_Request_Date()
                SetWCD_Request_DateLabel()
                SetWCD_Status()
                SetWCD_StatusLabel()
                SetWCD_Submit()
                SetWCD_SubmitLabel()
                SetWCD_Supplementary()
                SetWCD_Supplementary_Manual()
                SetWCD_Supplementary_ManualLabel()
                SetWCD_Supplementary_WCD_ID()
                SetWCD_Supplementary_WCD_IDLabel()
                SetWCD_SupplementaryLabel()
                SetWCD_U_ID()
                SetWCD_U_IDLabel()
                SetWCD_Unit_Location()
                SetWCD_Unit_LocationLabel()
                SetWCD_WCur_ID()
                SetWCD_WCur_IDLabel()
                SetWCD_WDT_ID()
                SetWCD_WDT_IDLabel()
                SetDeleteRowButton()
              
                SetEditRowButton()
              
                SetExpandRowButton()
              
      
      
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
                      
        SetSel_WCAR_Activity_WCAR_DocTableControl()
                  
        SetWCAR_ActivityTableControl()
                  
        SetWCAR_Doc_AttachTableControl()
                  
        SetWCAR_Doc_CheckerTableControl()
        
        End Sub
        
        
        Public Overridable Sub SetWCD_C_ID()

                  
            
        
            ' Set the WCD_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_C_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_C_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_C_IDSpecified Then
                				
                ' If the WCD_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_DocTable.WCD_C_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_DocTable.GetDFKA(Me.DataSource.WCD_C_ID.ToString(),WCAR_DocTable.WCD_C_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_DocTable.WCD_C_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCD_C_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_C_ID.Text = formattedValue
                
            Else 
            
                ' WCD_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_C_ID.Text = WCAR_DocTable.WCD_C_ID.Format(WCAR_DocTable.WCD_C_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCD_C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_C_ID.Text Is Nothing _
                OrElse Me.WCD_C_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_C_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Created()

                  
            
        
            ' Set the WCD_Created Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Created is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Created()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_CreatedSpecified Then
                				
                ' If the WCD_Created is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Created, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Created.Text = formattedValue
                
            Else 
            
                ' WCD_Created is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Created.Text = WCAR_DocTable.WCD_Created.Format(WCAR_DocTable.WCD_Created.DefaultValue, "g")
                        		
                End If
                 
            ' If the WCD_Created is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Created.Text Is Nothing _
                OrElse Me.WCD_Created.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Created.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Budget()

                  
            
        
            ' Set the WCD_Exp_Budget Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Budget is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Budget()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_BudgetSpecified Then
                				
                ' If the WCD_Exp_Budget is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Exp_Budget)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Budget.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Budget is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Budget.Text = WCAR_DocTable.WCD_Exp_Budget.Format(WCAR_DocTable.WCD_Exp_Budget.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Exp_Budget is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Budget.Text Is Nothing _
                OrElse Me.WCD_Exp_Budget.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Budget.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Cur_Yr()

                  
            
        
            ' Set the WCD_Exp_Cur_Yr Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Cur_Yr is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Cur_Yr()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Cur_YrSpecified Then
                				
                ' If the WCD_Exp_Cur_Yr is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Exp_Cur_Yr)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Cur_Yr.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Cur_Yr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Cur_Yr.Text = WCAR_DocTable.WCD_Exp_Cur_Yr.Format(WCAR_DocTable.WCD_Exp_Cur_Yr.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Exp_Cur_Yr is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Cur_Yr.Text Is Nothing _
                OrElse Me.WCD_Exp_Cur_Yr.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Cur_Yr.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Nxt_Yr()

                  
            
        
            ' Set the WCD_Exp_Nxt_Yr Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Nxt_Yr is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Nxt_Yr()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Nxt_YrSpecified Then
                				
                ' If the WCD_Exp_Nxt_Yr is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Exp_Nxt_Yr)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Nxt_Yr.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Nxt_Yr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Nxt_Yr.Text = WCAR_DocTable.WCD_Exp_Nxt_Yr.Format(WCAR_DocTable.WCD_Exp_Nxt_Yr.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Exp_Nxt_Yr is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Nxt_Yr.Text Is Nothing _
                OrElse Me.WCD_Exp_Nxt_Yr.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Nxt_Yr.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Prev_Total()

                  
            
        
            ' Set the WCD_Exp_Prev_Total Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Prev_Total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Prev_Total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Prev_TotalSpecified Then
                				
                ' If the WCD_Exp_Prev_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Exp_Prev_Total)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Prev_Total.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Prev_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Prev_Total.Text = WCAR_DocTable.WCD_Exp_Prev_Total.Format(WCAR_DocTable.WCD_Exp_Prev_Total.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Exp_Prev_Total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Prev_Total.Text Is Nothing _
                OrElse Me.WCD_Exp_Prev_Total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Prev_Total.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Sub_Yr()

                  
            
        
            ' Set the WCD_Exp_Sub_Yr Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Sub_Yr is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Sub_Yr()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Sub_YrSpecified Then
                				
                ' If the WCD_Exp_Sub_Yr is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Exp_Sub_Yr)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Sub_Yr.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Sub_Yr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Sub_Yr.Text = WCAR_DocTable.WCD_Exp_Sub_Yr.Format(WCAR_DocTable.WCD_Exp_Sub_Yr.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Exp_Sub_Yr is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Sub_Yr.Text Is Nothing _
                OrElse Me.WCD_Exp_Sub_Yr.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Sub_Yr.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Total()

                  
            
        
            ' Set the WCD_Exp_Total Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_TotalSpecified Then
                				
                ' If the WCD_Exp_Total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Exp_Total)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Total.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Total.Text = WCAR_DocTable.WCD_Exp_Total.Format(WCAR_DocTable.WCD_Exp_Total.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Exp_Total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Total.Text Is Nothing _
                OrElse Me.WCD_Exp_Total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Total.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Exp_Under_Over_Budget()

                  
            
        
            ' Set the WCD_Exp_Under_Over_Budget Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Exp_Under_Over_Budget is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Exp_Under_Over_Budget()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Exp_Under_Over_BudgetSpecified Then
                				
                ' If the WCD_Exp_Under_Over_Budget is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Exp_Under_Over_Budget)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Exp_Under_Over_Budget.Text = formattedValue
                
            Else 
            
                ' WCD_Exp_Under_Over_Budget is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Exp_Under_Over_Budget.Text = WCAR_DocTable.WCD_Exp_Under_Over_Budget.Format(WCAR_DocTable.WCD_Exp_Under_Over_Budget.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Exp_Under_Over_Budget is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Exp_Under_Over_Budget.Text Is Nothing _
                OrElse Me.WCD_Exp_Under_Over_Budget.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Exp_Under_Over_Budget.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_No()

                  
            
        
            ' Set the WCD_No Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_No is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_No()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_NoSpecified Then
                				
                ' If the WCD_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_No)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_No.Text = formattedValue
                
            Else 
            
                ' WCD_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_No.Text = WCAR_DocTable.WCD_No.Format(WCAR_DocTable.WCD_No.DefaultValue)
                        		
                End If
                 
            ' If the WCD_No is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_No.Text Is Nothing _
                OrElse Me.WCD_No.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_No.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Proj_Inc_ACB()

                  
            
        
            ' Set the WCD_Proj_Inc_ACB Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Proj_Inc_ACB is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Proj_Inc_ACB()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Proj_Inc_ACBSpecified Then
                				
                ' If the WCD_Proj_Inc_ACB is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Proj_Inc_ACB)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Proj_Inc_ACB.Text = formattedValue
                
            Else 
            
                ' WCD_Proj_Inc_ACB is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Proj_Inc_ACB.Text = WCAR_DocTable.WCD_Proj_Inc_ACB.Format(WCAR_DocTable.WCD_Proj_Inc_ACB.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Proj_Inc_ACB is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Proj_Inc_ACB.Text Is Nothing _
                OrElse Me.WCD_Proj_Inc_ACB.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Proj_Inc_ACB.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Project_No()

                  
            
        
            ' Set the WCD_Project_No Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Project_No is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Project_No()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Project_NoSpecified Then
                				
                ' If the WCD_Project_No is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Project_No)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Project_No.Text = formattedValue
                
            Else 
            
                ' WCD_Project_No is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Project_No.Text = WCAR_DocTable.WCD_Project_No.Format(WCAR_DocTable.WCD_Project_No.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Project_No is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Project_No.Text Is Nothing _
                OrElse Me.WCD_Project_No.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Project_No.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Project_Title()

                  
            
        
            ' Set the WCD_Project_Title Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Project_Title is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Project_Title()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Project_TitleSpecified Then
                				
                ' If the WCD_Project_Title is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Project_Title)
                              
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    Dim originalLength As Integer = maxLength
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                                      
                        formattedValue = HttpUtility.HtmlEncode(formattedValue)
                          
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If originalLength >= popupThreshold Then
                      
                        Dim name As String = HttpUtility.HtmlEncode(WCAR_DocTable.WCD_Project_Title.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WCAR_DocTable, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WCD_Project_Title\"", \""WCD_Project_Title\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, Len(formattedValue))))
                      
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        Else
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    End If
                End If  
                
                Me.WCD_Project_Title.Text = formattedValue
                
            Else 
            
                ' WCD_Project_Title is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Project_Title.Text = WCAR_DocTable.WCD_Project_Title.Format(WCAR_DocTable.WCD_Project_Title.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Project_Title is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Project_Title.Text Is Nothing _
                OrElse Me.WCD_Project_Title.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Project_Title.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Remark()

                  
            
        
            ' Set the WCD_Remark Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Remark is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_RemarkSpecified Then
                				
                ' If the WCD_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Remark)
                              
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(300, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    Dim originalLength As Integer = maxLength
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                                      
                        formattedValue = HttpUtility.HtmlEncode(formattedValue)
                          
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If originalLength >= popupThreshold Then
                      
                        Dim name As String = HttpUtility.HtmlEncode(WCAR_DocTable.WCD_Remark.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.WCAR_DocTable, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WCD_Remark\"", \""WCD_Remark\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, Len(formattedValue))))
                      
                        If (maxLength = CType(300, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    Else
                        If maxLength = CType(300, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                        
                        Else
                        
                            formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                        End If
                    End If
                End If  
                
                Me.WCD_Remark.Text = formattedValue
                
            Else 
            
                ' WCD_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Remark.Text = WCAR_DocTable.WCD_Remark.Format(WCAR_DocTable.WCD_Remark.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Remark is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Remark.Text Is Nothing _
                OrElse Me.WCD_Remark.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Remark.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Request_Date()

                  
            
        
            ' Set the WCD_Request_Date Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Request_Date is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Request_Date()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Request_DateSpecified Then
                				
                ' If the WCD_Request_Date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Request_Date, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Request_Date.Text = formattedValue
                
            Else 
            
                ' WCD_Request_Date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Request_Date.Text = WCAR_DocTable.WCD_Request_Date.Format(WCAR_DocTable.WCD_Request_Date.DefaultValue, "g")
                        		
                End If
                 
            ' If the WCD_Request_Date is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Request_Date.Text Is Nothing _
                OrElse Me.WCD_Request_Date.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Request_Date.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Status()

                  
            
        
            ' Set the WCD_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_StatusSpecified Then
                				
                ' If the WCD_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Status)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Status.Text = formattedValue
                
            Else 
            
                ' WCD_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Status.Text = WCAR_DocTable.WCD_Status.Format(WCAR_DocTable.WCD_Status.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Status.Text Is Nothing _
                OrElse Me.WCD_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Submit()

                  
            
        
            ' Set the WCD_Submit Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Submit is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Submit()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_SubmitSpecified Then
                				
                ' If the WCD_Submit is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Submit)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Submit.Text = formattedValue
                
            Else 
            
                ' WCD_Submit is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Submit.Text = WCAR_DocTable.WCD_Submit.Format(WCAR_DocTable.WCD_Submit.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Submit is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Submit.Text Is Nothing _
                OrElse Me.WCD_Submit.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Submit.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Supplementary()

                  
            
        
            ' Set the WCD_Supplementary Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Supplementary is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Supplementary()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_SupplementarySpecified Then
                				
                ' If the WCD_Supplementary is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Supplementary)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Supplementary.Text = formattedValue
                
            Else 
            
                ' WCD_Supplementary is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Supplementary.Text = WCAR_DocTable.WCD_Supplementary.Format(WCAR_DocTable.WCD_Supplementary.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Supplementary is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Supplementary.Text Is Nothing _
                OrElse Me.WCD_Supplementary.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Supplementary.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Supplementary_Manual()

                  
            
        
            ' Set the WCD_Supplementary_Manual Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Supplementary_Manual is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Supplementary_Manual()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Supplementary_ManualSpecified Then
                				
                ' If the WCD_Supplementary_Manual is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Supplementary_Manual)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Supplementary_Manual.Text = formattedValue
                
            Else 
            
                ' WCD_Supplementary_Manual is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Supplementary_Manual.Text = WCAR_DocTable.WCD_Supplementary_Manual.Format(WCAR_DocTable.WCD_Supplementary_Manual.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Supplementary_Manual is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Supplementary_Manual.Text Is Nothing _
                OrElse Me.WCD_Supplementary_Manual.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Supplementary_Manual.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Supplementary_WCD_ID()

                  
            
        
            ' Set the WCD_Supplementary_WCD_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Supplementary_WCD_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Supplementary_WCD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Supplementary_WCD_IDSpecified Then
                				
                ' If the WCD_Supplementary_WCD_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Supplementary_WCD_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Supplementary_WCD_ID.Text = formattedValue
                
            Else 
            
                ' WCD_Supplementary_WCD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Supplementary_WCD_ID.Text = WCAR_DocTable.WCD_Supplementary_WCD_ID.Format(WCAR_DocTable.WCD_Supplementary_WCD_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Supplementary_WCD_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Supplementary_WCD_ID.Text Is Nothing _
                OrElse Me.WCD_Supplementary_WCD_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Supplementary_WCD_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_U_ID()

                  
            
        
            ' Set the WCD_U_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_U_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_U_IDSpecified Then
                				
                ' If the WCD_U_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_U_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_DocTable.WCD_U_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_DocTable.GetDFKA(Me.DataSource.WCD_U_ID.ToString(),WCAR_DocTable.WCD_U_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_DocTable.WCD_U_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCD_U_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_U_ID.Text = formattedValue
                
            Else 
            
                ' WCD_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_U_ID.Text = WCAR_DocTable.WCD_U_ID.Format(WCAR_DocTable.WCD_U_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCD_U_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_U_ID.Text Is Nothing _
                OrElse Me.WCD_U_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_U_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_Unit_Location()

                  
            
        
            ' Set the WCD_Unit_Location Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_Unit_Location is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_Unit_Location()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_Unit_LocationSpecified Then
                				
                ' If the WCD_Unit_Location is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_DocTable.WCD_Unit_Location)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_Unit_Location.Text = formattedValue
                
            Else 
            
                ' WCD_Unit_Location is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_Unit_Location.Text = WCAR_DocTable.WCD_Unit_Location.Format(WCAR_DocTable.WCD_Unit_Location.DefaultValue)
                        		
                End If
                 
            ' If the WCD_Unit_Location is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_Unit_Location.Text Is Nothing _
                OrElse Me.WCD_Unit_Location.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_Unit_Location.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_WCur_ID()

                  
            
        
            ' Set the WCD_WCur_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_WCur_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_WCur_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_WCur_IDSpecified Then
                				
                ' If the WCD_WCur_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_WCur_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_DocTable.WCD_WCur_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_DocTable.GetDFKA(Me.DataSource.WCD_WCur_ID.ToString(),WCAR_DocTable.WCD_WCur_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_DocTable.WCD_WCur_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCD_WCur_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_WCur_ID.Text = formattedValue
                
            Else 
            
                ' WCD_WCur_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_WCur_ID.Text = WCAR_DocTable.WCD_WCur_ID.Format(WCAR_DocTable.WCD_WCur_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCD_WCur_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_WCur_ID.Text Is Nothing _
                OrElse Me.WCD_WCur_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_WCur_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_WDT_ID()

                  
            
        
            ' Set the WCD_WDT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WF%dbo.WCAR_Doc database record.

            ' Me.DataSource is the DatabaseANFLO-WF%dbo.WCAR_Doc record retrieved from the database.
            ' Me.WCD_WDT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCD_WDT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCD_WDT_IDSpecified Then
                				
                ' If the WCD_WDT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_WDT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WCAR_DocTable.WCD_WDT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WCAR_DocTable.GetDFKA(Me.DataSource.WCD_WDT_ID.ToString(),WCAR_DocTable.WCD_WDT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WCAR_DocTable.WCD_WDT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.WCD_WDT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCD_WDT_ID.Text = formattedValue
                
            Else 
            
                ' WCD_WDT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCD_WDT_ID.Text = WCAR_DocTable.WCD_WDT_ID.Format(WCAR_DocTable.WCD_WDT_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCD_WDT_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCD_WDT_ID.Text Is Nothing _
                OrElse Me.WCD_WDT_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCD_WDT_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCD_C_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_CreatedLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_BudgetLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Cur_YrLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Nxt_YrLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Prev_TotalLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Sub_YrLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_TotalLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Exp_Under_Over_BudgetLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_NoLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Proj_Inc_ACBLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Project_NoLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Project_TitleLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_RemarkLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Request_DateLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_StatusLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_SubmitLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Supplementary_ManualLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Supplementary_WCD_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_SupplementaryLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_U_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_Unit_LocationLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_WCur_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCD_WDT_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCAR_DocTabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "WCAR_DocTabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "WCAR_DocTabContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetSel_WCAR_Activity_WCAR_DocTableControl()           
        
        
            If Sel_WCAR_Activity_WCAR_DocTableControl.Visible Then
                Sel_WCAR_Activity_WCAR_DocTableControl.LoadData()
                Sel_WCAR_Activity_WCAR_DocTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWCAR_ActivityTableControl()           
        
        
            If WCAR_ActivityTableControl.Visible Then
                WCAR_ActivityTableControl.LoadData()
                WCAR_ActivityTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWCAR_Doc_AttachTableControl()           
        
        
            If WCAR_Doc_AttachTableControl.Visible Then
                WCAR_Doc_AttachTableControl.LoadData()
                WCAR_Doc_AttachTableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWCAR_Doc_CheckerTableControl()           
        
        
            If WCAR_Doc_CheckerTableControl.Visible Then
                WCAR_Doc_CheckerTableControl.LoadData()
                WCAR_Doc_CheckerTableControl.DataBind()
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

      
        
        ' To customize, override this method in WCAR_DocTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WCAR_DocTableControl"), WCAR_DocTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCAR_DocTableControl"), WCAR_DocTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recSel_WCAR_Activity_WCAR_DocTableControl as Sel_WCAR_Activity_WCAR_DocTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WCAR_Activity_WCAR_DocTableControl"), Sel_WCAR_Activity_WCAR_DocTableControl)
        recSel_WCAR_Activity_WCAR_DocTableControl.SaveData()
          
        Dim recWCAR_ActivityTableControl as WCAR_ActivityTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_ActivityTableControl"), WCAR_ActivityTableControl)
        recWCAR_ActivityTableControl.SaveData()
          
        Dim recWCAR_Doc_AttachTableControl as WCAR_Doc_AttachTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_AttachTableControl"), WCAR_Doc_AttachTableControl)
        recWCAR_Doc_AttachTableControl.SaveData()
          
        Dim recWCAR_Doc_CheckerTableControl as WCAR_Doc_CheckerTableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WCAR_Doc_CheckerTableControl"), WCAR_Doc_CheckerTableControl)
        recWCAR_Doc_CheckerTableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WCAR_DocTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCD_C_ID()
            GetWCD_Created()
            GetWCD_Exp_Budget()
            GetWCD_Exp_Cur_Yr()
            GetWCD_Exp_Nxt_Yr()
            GetWCD_Exp_Prev_Total()
            GetWCD_Exp_Sub_Yr()
            GetWCD_Exp_Total()
            GetWCD_Exp_Under_Over_Budget()
            GetWCD_No()
            GetWCD_Proj_Inc_ACB()
            GetWCD_Project_No()
            GetWCD_Project_Title()
            GetWCD_Remark()
            GetWCD_Request_Date()
            GetWCD_Status()
            GetWCD_Submit()
            GetWCD_Supplementary()
            GetWCD_Supplementary_Manual()
            GetWCD_Supplementary_WCD_ID()
            GetWCD_U_ID()
            GetWCD_Unit_Location()
            GetWCD_WCur_ID()
            GetWCD_WDT_ID()
        End Sub
        
        
        Public Overridable Sub GetWCD_C_ID()
            
        End Sub
                
        Public Overridable Sub GetWCD_Created()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Budget()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Cur_Yr()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Nxt_Yr()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Prev_Total()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Sub_Yr()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Total()
            
        End Sub
                
        Public Overridable Sub GetWCD_Exp_Under_Over_Budget()
            
        End Sub
                
        Public Overridable Sub GetWCD_No()
            
        End Sub
                
        Public Overridable Sub GetWCD_Proj_Inc_ACB()
            
        End Sub
                
        Public Overridable Sub GetWCD_Project_No()
            
        End Sub
                
        Public Overridable Sub GetWCD_Project_Title()
            
        End Sub
                
        Public Overridable Sub GetWCD_Remark()
            
        End Sub
                
        Public Overridable Sub GetWCD_Request_Date()
            
        End Sub
                
        Public Overridable Sub GetWCD_Status()
            
        End Sub
                
        Public Overridable Sub GetWCD_Submit()
            
        End Sub
                
        Public Overridable Sub GetWCD_Supplementary()
            
        End Sub
                
        Public Overridable Sub GetWCD_Supplementary_Manual()
            
        End Sub
                
        Public Overridable Sub GetWCD_Supplementary_WCD_ID()
            
        End Sub
                
        Public Overridable Sub GetWCD_U_ID()
            
        End Sub
                
        Public Overridable Sub GetWCD_Unit_Location()
            
        End Sub
                
        Public Overridable Sub GetWCD_WCur_ID()
            
        End Sub
                
        Public Overridable Sub GetWCD_WDT_ID()
            
        End Sub
                
      
        ' To customize, override this method in WCAR_DocTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WCAR_DocTableControlRow.
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
          WCAR_DocTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WCAR_DocTableControl"), WCAR_DocTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WCAR_DocTableControl"), WCAR_DocTableControl).ResetData = True
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
        
        Public Overridable Sub SetDeleteRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetEditRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetExpandRowButton()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub DeleteRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                  Me.Delete()
              
            End If
      Me.Page.CommitTransaction(sender)
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
        Public Overridable Sub EditRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WCAR_Doc/Edit-WCAR-Doc.aspx?WCAR_Doc={PK}"
                  
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
        Public Overridable Sub ExpandRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
          Dim panelControl as WCAR_DocTableControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCAR_DocTableControl"), WCAR_DocTableControl)

          Dim repeatedRows() as WCAR_DocTableControlRow = panelControl.GetRecordControls()
          For Each repeatedRow as WCAR_DocTableControlRow in repeatedRows
              Dim altRow as System.Web.UI.Control= DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "WCAR_DocTableControlAltRow"), System.Web.UI.Control)
              If (altRow IsNot Nothing) Then
                  If (sender Is repeatedRow.ExpandRowButton) Then
                      altRow.Visible = Not altRow.Visible
                  
                  End If                      
                  If (altRow.Visible) Then        
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'")
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'")
                                     
                  Else
                   
                     repeatedRow.ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'")
                     repeatedRow.ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'")
                   
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
                Return CType(Me.ViewState("BaseWCAR_DocTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCAR_DocTableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCAR_DocRecord
            Get
                Return DirectCast(MyBase._DataSource, WCAR_DocRecord)
            End Get
            Set(ByVal value As WCAR_DocRecord)
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
        
        Public ReadOnly Property DeleteRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DeleteRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property EditRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EditRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property ExpandRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExpandRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Sel_WCAR_Activity_WCAR_DocTableControl() As Sel_WCAR_Activity_WCAR_DocTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WCAR_Activity_WCAR_DocTableControl"), Sel_WCAR_Activity_WCAR_DocTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WCAR_ActivityTableControl() As WCAR_ActivityTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_ActivityTableControl"), WCAR_ActivityTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WCAR_Doc_AttachTableControl() As WCAR_Doc_AttachTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_AttachTableControl"), WCAR_Doc_AttachTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WCAR_Doc_CheckerTableControl() As WCAR_Doc_CheckerTableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Doc_CheckerTableControl"), WCAR_Doc_CheckerTableControl)
            End Get
        End Property
        
        Public ReadOnly Property WCAR_DocTabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_DocTabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property WCD_C_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_C_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Created() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Created"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_CreatedLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_CreatedLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Budget() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Budget"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_BudgetLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_BudgetLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Cur_Yr() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Cur_Yr"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Cur_YrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Cur_YrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Nxt_Yr() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Nxt_Yr"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Nxt_YrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Nxt_YrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Prev_Total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Prev_Total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Prev_TotalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Prev_TotalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Sub_Yr() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Sub_Yr"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Sub_YrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Sub_YrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_TotalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_TotalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Exp_Under_Over_Budget() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Under_Over_Budget"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Exp_Under_Over_BudgetLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Exp_Under_Over_BudgetLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_No() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_No"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_NoLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_NoLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Proj_Inc_ACB() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Proj_Inc_ACB"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Proj_Inc_ACBLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Proj_Inc_ACBLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Project_No() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_No"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Project_NoLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_NoLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Project_Title() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_Title"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Project_TitleLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Project_TitleLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Remark"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Request_Date() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Request_Date"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Request_DateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Request_DateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Submit() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Submit"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_SubmitLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_SubmitLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Supplementary() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Supplementary"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Supplementary_Manual() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Supplementary_Manual"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Supplementary_ManualLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Supplementary_ManualLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Supplementary_WCD_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Supplementary_WCD_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Supplementary_WCD_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Supplementary_WCD_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_SupplementaryLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_SupplementaryLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_Unit_Location() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Unit_Location"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_Unit_LocationLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_Unit_LocationLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_WCur_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WCur_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_WCur_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WCur_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCD_WDT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WDT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCD_WDT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WDT_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WCAR_DocRecord = Nothing
             
        
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
            
            Dim rec As WCAR_DocRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCAR_DocRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCAR_DocTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WCAR_DocTableControl control on the Show_WCAR_Doc_Table page.
' Do not modify this class. Instead override any method in WCAR_DocTableControl.
Public Class BaseWCAR_DocTableControl
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
                If  Me.InSession(Me.WCD_WDT_IDFilter) 				
                    initialVal = Me.GetFromSession(Me.WCD_WDT_IDFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""WCD_WDT_ID"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Dim WCD_WDT_IDFilteritemListFromSession() As String = initialVal.Split(","c)
                        Dim index As Integer = 0
                        For Each item As String In WCD_WDT_IDFilteritemListFromSession
                            If index = 0 AndAlso _
                               item.ToString.Equals("") Then
                            Else
                                Me.WCD_WDT_IDFilter.Items.Add(item)
                                Me.WCD_WDT_IDFilter.Items.Item(index).Selected = True
                                index += 1
                            End If
                        Next
                        Dim listItem As ListItem
                        For Each listItem In Me.WCD_WDT_IDFilter.Items
                            listItem.Selected = True
                        Next
                            
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
                        
              AddHandler Me.ImportButton.Click, AddressOf ImportButton_Click
                        
              AddHandler Me.NewButton.Click, AddressOf NewButton_Click
                        
              AddHandler Me.PDFButton.Click, AddressOf PDFButton_Click
                        
              AddHandler Me.ResetButton.Click, AddressOf ResetButton_Click
                        
              AddHandler Me.WordButton.Click, AddressOf WordButton_Click
                        
              AddHandler Me.ActionsButton.Button.Click, AddressOf ActionsButton_Click
                        
              AddHandler Me.FilterButton.Button.Click, AddressOf FilterButton_Click
                        
              AddHandler Me.FiltersButton.Button.Click, AddressOf FiltersButton_Click
                        
            AddHandler Me.SortControl.SelectedIndexChanged, AddressOf SortControl_SelectedIndexChanged
              AddHandler Me.WCD_WDT_IDFilter.SelectedIndexChanged, AddressOf WCD_WDT_IDFilter_SelectedIndexChanged                  
                        
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WCAR_DocRecord)), WCAR_DocRecord())
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
                    For Each rc As WCAR_DocTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WCAR_DocRecord)), WCAR_DocRecord())
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
            ByVal pageSize As Integer) As WCAR_DocRecord()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_DocTable.Column1, True)         
            ' selCols.Add(WCAR_DocTable.Column2, True)          
            ' selCols.Add(WCAR_DocTable.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WCAR_DocTable.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WCAR_DocTable
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WCAR_DocRecord)), WCAR_DocRecord())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_DocTable.Column1, True)         
            ' selCols.Add(WCAR_DocTable.Column2, True)          
            ' selCols.Add(WCAR_DocTable.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WCAR_DocTable.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WCAR_DocTable
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_DocTableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WCAR_DocTableControlRow = DirectCast(repItem.FindControl("WCAR_DocTableControlRow"), WCAR_DocTableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                
                
                
                SetSortByLabel()
                SetSortControl()
                
                SetWCD_WDT_IDFilter()
                SetWCD_WDT_IDLabel1()
                
                SetExcelButton()
              
                SetImportButton()
              
                SetNewButton()
              
                SetPDFButton()
              
                SetResetButton()
              
                SetWordButton()
              
                SetActionsButton()
              
                SetFilterButton()
              
                SetFiltersButton()
              
            ' setting the state of expand or collapse alternative rows
      
            Dim expandFirstRow As Boolean= True
        
            Dim recControls() As WCAR_DocTableControlRow = Me.GetRecordControls()
            For i As Integer = 0 to recControls.Length - 1
                Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(recControls(i), "WCAR_DocTableControlAltRow"), System.Web.UI.Control)
                If (altRow IsNot Nothing) Then
                    If (expandFirstRow AndAlso i = 0) Then                
                        altRow.Visible = True
                   
                         recControls(i).ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif"
                         recControls(i).ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over.gif'")
                         recControls(i).ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow.gif'")
                   
                    Else                
                        altRow.Visible = False
                   
                         recControls(i).ExpandRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif"
                         recControls(i).ExpandRowButton.Attributes.Add("onmouseover", "this.src='../Images/icon_expandcollapserow_over2.gif'")
                         recControls(i).ExpandRowButton.Attributes.Add("onmouseout", "this.src='../Images/icon_expandcollapserow2.gif'")
                   
                    End If
                End If
            Next
      
    
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

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WCAR_DocTable.WCD_C_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_DocTable.WCD_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_DocTable.WCD_WCur_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_DocTable.WCD_WDT_ID, Me.DataSource)
          
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

            
            Me.WCD_WDT_IDFilter.ClearSelection()
            
            Me.SortControl.ClearSelection()
            
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

            ' Bind the buttons for WCAR_DocTableControl pagination.
        
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
            
            Dim recCtl As WCAR_DocTableControlRow
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
            WCAR_DocTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
      
        Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
      
        Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
      
        Dim hasFiltersWCAR_DocTableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              

                  Dim totalSelectedItemCount as Integer = 0
                  
            If IsValueSelected(Me.WCD_WDT_IDFilter) Then
    
              hasFiltersWCAR_DocTableControl = True            
    
                Dim item As ListItem
                Dim selectedItemCount As Integer = 0
                For Each item In Me.WCD_WDT_IDFilter.Items
                    If item.Selected Then
                        selectedItemCount += 1
                        
                          totalSelectedItemCount += 1
                        
                    End If
                Next
                
                Dim filter As WhereClause = New WhereClause
                For Each item In Me.WCD_WDT_IDFilter.Items
                    If item.Selected AndAlso (item.Value = "--ANY--" OrElse item.Value = "--PLEASE_SELECT--") AndAlso selectedItemCount > 1 Then
                        item.Selected = False
                    End If
                    If item.Selected Then
                        filter.iOR(WCAR_DocTable.WCD_WDT_ID, BaseFilter.ComparisonOperator.EqualsTo, item.Value, False, False)
                    End If
                Next
                wc.iAND(filter)
                
            End If
                  
                
                       
      If (totalSelectedItemCount > 50) Then
          Throw new Exception(Page.GetResourceValue("Err:SelectedItemOverLimit", "ePortalWFApproval").Replace("{Limit}", "50").Replace("{SelectedCount}", totalSelectedItemCount.ToString()))
      End If
      
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WCAR_DocTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
        
          Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
        
          Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
        
          Dim hasFiltersWCAR_DocTableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim WCD_WDT_IDFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WCD_WDT_IDFilter_Ajax"), String)
            If IsValueSelected(WCD_WDT_IDFilterSelectedValue) Then
    
              hasFiltersWCAR_DocTableControl = True            
    
            If Not isNothing(WCD_WDT_IDFilterSelectedValue) Then
                Dim WCD_WDT_IDFilteritemListFromSession() As String = WCD_WDT_IDFilterSelectedValue.Split(","c)
                Dim index As Integer = 0
                  
                Dim filter As WhereClause = New WhereClause
                For Each item As String In WCD_WDT_IDFilteritemListFromSession
                    If index = 0 AndAlso item.ToString.Equals("") Then
                    Else
                        filter.iOR(WCAR_DocTable.WCD_WDT_ID, BaseFilter.ComparisonOperator.EqualsTo, item, False, False)
                        index += 1
                    End If
                Next
                wc.iAND(filter)
                
             End If
                
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_DocTableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WCAR_DocTableControlRow = DirectCast(repItem.FindControl("WCAR_DocTableControlRow"), WCAR_DocTableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WCAR_DocRecord = New WCAR_DocRecord()
        
                        If recControl.WCD_C_ID.Text <> "" Then
                            rec.Parse(recControl.WCD_C_ID.Text, WCAR_DocTable.WCD_C_ID)
                        End If
                        If recControl.WCD_Created.Text <> "" Then
                            rec.Parse(recControl.WCD_Created.Text, WCAR_DocTable.WCD_Created)
                        End If
                        If recControl.WCD_Exp_Budget.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Budget.Text, WCAR_DocTable.WCD_Exp_Budget)
                        End If
                        If recControl.WCD_Exp_Cur_Yr.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Cur_Yr.Text, WCAR_DocTable.WCD_Exp_Cur_Yr)
                        End If
                        If recControl.WCD_Exp_Nxt_Yr.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Nxt_Yr.Text, WCAR_DocTable.WCD_Exp_Nxt_Yr)
                        End If
                        If recControl.WCD_Exp_Prev_Total.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Prev_Total.Text, WCAR_DocTable.WCD_Exp_Prev_Total)
                        End If
                        If recControl.WCD_Exp_Sub_Yr.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Sub_Yr.Text, WCAR_DocTable.WCD_Exp_Sub_Yr)
                        End If
                        If recControl.WCD_Exp_Total.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Total.Text, WCAR_DocTable.WCD_Exp_Total)
                        End If
                        If recControl.WCD_Exp_Under_Over_Budget.Text <> "" Then
                            rec.Parse(recControl.WCD_Exp_Under_Over_Budget.Text, WCAR_DocTable.WCD_Exp_Under_Over_Budget)
                        End If
                        If recControl.WCD_No.Text <> "" Then
                            rec.Parse(recControl.WCD_No.Text, WCAR_DocTable.WCD_No)
                        End If
                        If recControl.WCD_Proj_Inc_ACB.Text <> "" Then
                            rec.Parse(recControl.WCD_Proj_Inc_ACB.Text, WCAR_DocTable.WCD_Proj_Inc_ACB)
                        End If
                        If recControl.WCD_Project_No.Text <> "" Then
                            rec.Parse(recControl.WCD_Project_No.Text, WCAR_DocTable.WCD_Project_No)
                        End If
                        If recControl.WCD_Project_Title.Text <> "" Then
                            rec.Parse(recControl.WCD_Project_Title.Text, WCAR_DocTable.WCD_Project_Title)
                        End If
                        If recControl.WCD_Remark.Text <> "" Then
                            rec.Parse(recControl.WCD_Remark.Text, WCAR_DocTable.WCD_Remark)
                        End If
                        If recControl.WCD_Request_Date.Text <> "" Then
                            rec.Parse(recControl.WCD_Request_Date.Text, WCAR_DocTable.WCD_Request_Date)
                        End If
                        If recControl.WCD_Status.Text <> "" Then
                            rec.Parse(recControl.WCD_Status.Text, WCAR_DocTable.WCD_Status)
                        End If
                        If recControl.WCD_Submit.Text <> "" Then
                            rec.Parse(recControl.WCD_Submit.Text, WCAR_DocTable.WCD_Submit)
                        End If
                        If recControl.WCD_Supplementary.Text <> "" Then
                            rec.Parse(recControl.WCD_Supplementary.Text, WCAR_DocTable.WCD_Supplementary)
                        End If
                        If recControl.WCD_Supplementary_Manual.Text <> "" Then
                            rec.Parse(recControl.WCD_Supplementary_Manual.Text, WCAR_DocTable.WCD_Supplementary_Manual)
                        End If
                        If recControl.WCD_Supplementary_WCD_ID.Text <> "" Then
                            rec.Parse(recControl.WCD_Supplementary_WCD_ID.Text, WCAR_DocTable.WCD_Supplementary_WCD_ID)
                        End If
                        If recControl.WCD_U_ID.Text <> "" Then
                            rec.Parse(recControl.WCD_U_ID.Text, WCAR_DocTable.WCD_U_ID)
                        End If
                        If recControl.WCD_Unit_Location.Text <> "" Then
                            rec.Parse(recControl.WCD_Unit_Location.Text, WCAR_DocTable.WCD_Unit_Location)
                        End If
                        If recControl.WCD_WCur_ID.Text <> "" Then
                            rec.Parse(recControl.WCD_WCur_ID.Text, WCAR_DocTable.WCD_WCur_ID)
                        End If
                        If recControl.WCD_WDT_ID.Text <> "" Then
                            rec.Parse(recControl.WCD_WDT_ID.Text, WCAR_DocTable.WCD_WDT_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WCAR_DocRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WCAR_DocRecord)), WCAR_DocRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WCAR_DocTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WCAR_DocTableControlRow) As Boolean
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
        
        Public Overridable Sub SetSortByLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCD_WDT_IDLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortControl()

              
            
                Me.PopulateSortControl(GetSelectedValue(Me.SortControl,  GetFromSession(Me.SortControl)), 500)					
                    
        End Sub
            
        Public Overridable Sub SetWCD_WDT_IDFilter()

              
            
            Dim WCD_WDT_IDFilterselectedFilterItemList As New ArrayList()
            Dim WCD_WDT_IDFilteritemsString As String = Nothing
            If (Me.InSession(Me.WCD_WDT_IDFilter)) Then
                WCD_WDT_IDFilteritemsString = Me.GetFromSession(Me.WCD_WDT_IDFilter)
            End If
            
            If (WCD_WDT_IDFilteritemsString IsNot Nothing) Then
                Dim WCD_WDT_IDFilteritemListFromSession() As String = WCD_WDT_IDFilteritemsString.Split(","c)
                For Each item as String In WCD_WDT_IDFilteritemListFromSession
                    WCD_WDT_IDFilterselectedFilterItemList.Add(item)
                Next
            End If
              
            		
            Me.PopulateWCD_WDT_IDFilter(GetSelectedValueList(Me.WCD_WDT_IDFilter, WCD_WDT_IDFilterselectedFilterItemList), 500)
                    
              Dim url as String = Me.ModifyRedirectUrl("../WDoc_Type/WDoc-Type-QuickSelector.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WCD_WDT_IDFilter.ClientID & "&DFKA=" & CType(Me.Page, BaseApplicationPage).Encrypt("WDT_Name")& "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WDT_ID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--ANY--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:All")) & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WCD_WDT_IDFilter.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCD_WDT_IDFilter.AutoPostBack).ToLower() & ", event); return false;"        
                  
                                 
              End Sub	
            
        ' Get the filters' data for SortControl
        Protected Overridable Sub PopulateSortControl(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD C {Txt:Ascending}"), "WCD_C_ID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD C {Txt:Descending}"), "WCD_C_ID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Created {Txt:Ascending}"), "WCD_Created Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Created {Txt:Descending}"), "WCD_Created Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Expiration Budget {Txt:Ascending}"), "WCD_Exp_Budget Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Expiration Budget {Txt:Descending}"), "WCD_Exp_Budget Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Expiration CUR Year {Txt:Ascending}"), "WCD_Exp_Cur_Yr Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Expiration CUR Year {Txt:Descending}"), "WCD_Exp_Cur_Yr Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Number {Txt:Ascending}"), "WCD_No Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Number {Txt:Descending}"), "WCD_No Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Project Number {Txt:Ascending}"), "WCD_Project_No Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Project Number {Txt:Descending}"), "WCD_Project_No Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Request Date {Txt:Ascending}"), "WCD_Request_Date Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Request Date {Txt:Descending}"), "WCD_Request_Date Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Status {Txt:Ascending}"), "WCD_Status Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD Status {Txt:Descending}"), "WCD_Status Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD U {Txt:Ascending}"), "WCD_U_ID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD U {Txt:Descending}"), "WCD_U_ID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD WDT ID {Txt:Ascending}"), "WCD_WDT_ID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCD WDT ID {Txt:Descending}"), "WCD_WDT_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl.SelectedValue IsNot Nothing AndAlso Me.SortControl.Items.FindByValue(Me.SortControl.SelectedValue) Is Nothing
                Me.SortControl.SelectedValue = Nothing
            End If

              End Sub
            
        ' Get the filters' data for WCD_WDT_IDFilter
        Protected Overridable Sub PopulateWCD_WDT_IDFilter(ByVal selectedValue As ArrayList, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Dim wc As WhereClause = Me.CreateWhereClause_WCD_WDT_IDFilter()
            Me.WCD_WDT_IDFilter.Items.Clear()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCD_WDT_IDFilter function.
            ' It is better to customize the where clause there.
            

            Dim orderBy As OrderBy = New OrderBy(false, false)			
            
            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")
            

            Dim itemValues() As WDoc_TypeRecord = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = WDoc_TypeTable.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As WDoc_TypeRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WDT_IDSpecified Then
                            cvalue = itemValue.WDT_ID.ToString()

                            If counter < maxItems AndAlso Me.WCD_WDT_IDFilter.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_WDT_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCAR_DocTable.WCD_WDT_ID.IsApplyDisplayAs Then
                                    fvalue = WCAR_DocTable.GetDFKA(itemValue, WCAR_DocTable.WCD_WDT_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(WDoc_TypeTable.WDT_Name)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WCD_WDT_IDFilter.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCD_WDT_IDFilter.Items.Add(newItem)

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
                
            Catch
            End Try
            
            
            Me.WCD_WDT_IDFilter.SetFieldMaxLength(50)
                                 
                  
            ' Add the selected value.
            If Me.WCD_WDT_IDFilter.Items.Count = 0 Then
                Me.WCD_WDT_IDFilter.Items.Add(New ListItem(Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
            End If
            
            ' Mark all items to be selected.
            For Each item As ListItem in Me.WCD_WDT_IDFilter.Items
                item.Selected = True
            Next
                              
        End Sub
            
              

        Public Overridable Function CreateWhereClause_WCD_WDT_IDFilter() As WhereClause
          
              Dim hasFiltersSel_WCAR_Activity_WCAR_DocTableControl As Boolean = False
            
              Dim hasFiltersWCAR_ActivityTableControl As Boolean = False
            
              Dim hasFiltersWCAR_Doc_AttachTableControl As Boolean = False
            
              Dim hasFiltersWCAR_Doc_CheckerTableControl As Boolean = False
            
              Dim hasFiltersWCAR_DocTableControl As Boolean = False
            
            ' Create a where clause for the filter WCD_WDT_IDFilter.
            ' This function is called by the Populate method to load the items 
            ' in the WCD_WDT_IDFilterQuickSelector
            
            Dim WCD_WDT_IDFilterselectedFilterItemList As New ArrayList()
            Dim WCD_WDT_IDFilteritemsString As String = Nothing
            If (Me.InSession(Me.WCD_WDT_IDFilter)) Then
                WCD_WDT_IDFilteritemsString = Me.GetFromSession(Me.WCD_WDT_IDFilter)
            End If
            
            If (WCD_WDT_IDFilteritemsString IsNot Nothing) Then
                Dim WCD_WDT_IDFilteritemListFromSession() As String = WCD_WDT_IDFilteritemsString.Split(","c)
                For Each item as String In WCD_WDT_IDFilteritemListFromSession
                    WCD_WDT_IDFilterselectedFilterItemList.Add(item)
                Next
            End If
              
            WCD_WDT_IDFilterselectedFilterItemList = GetSelectedValueList(Me.WCD_WDT_IDFilter, WCD_WDT_IDFilterselectedFilterItemList) 
            Dim wc As New WhereClause
            If WCD_WDT_IDFilterselectedFilterItemList Is Nothing OrElse WCD_WDT_IDFilterselectedFilterItemList.Count = 0 Then
                wc.RunQuery = False
            Else            
                For Each item As String In WCD_WDT_IDFilterselectedFilterItemList
              
            	  
                    wc.iOR(WDoc_TypeTable.WDT_ID, BaseFilter.ComparisonOperator.EqualsTo, item)                  
                  
                                 
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
                  
            Dim WCD_WDT_IDFilterselectedFilterItemList As ArrayList = GetSelectedValueList(Me.WCD_WDT_IDFilter, Nothing)
            Dim WCD_WDT_IDFilterSessionString As String = ""
            If Not WCD_WDT_IDFilterselectedFilterItemList is Nothing Then
            For Each item As String In WCD_WDT_IDFilterselectedFilterItemList
                WCD_WDT_IDFilterSessionstring = WCD_WDT_IDFilterSessionstring & "," & item
            Next
            End If
            Me.SaveToSession(Me.WCD_WDT_IDFilter, WCD_WDT_IDFilterSessionstring)
                  
        
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
          
            Me.SaveToSession(Me.SortControl, Me.SortControl.SelectedValue)
                  
            Dim WCD_WDT_IDFilterselectedFilterItemList As ArrayList = GetSelectedValueList(Me.WCD_WDT_IDFilter, Nothing)
            Dim WCD_WDT_IDFilterSessionString As String = ""
            If Not WCD_WDT_IDFilterselectedFilterItemList is Nothing Then
            For Each item As String In WCD_WDT_IDFilterselectedFilterItemList
                WCD_WDT_IDFilterSessionstring = WCD_WDT_IDFilterSessionstring & "," & item
            Next
            End If
            Me.SaveToSession("WCD_WDT_IDFilter_Ajax", WCD_WDT_IDFilterSessionString)
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl)
            Me.RemoveFromSession(Me.WCD_WDT_IDFilter)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WCAR_DocTableControl_OrderBy"), String)
          
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
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
          
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("WCAR_DocTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetExcelButton()                
              
   
        End Sub
            
        Public Overridable Sub SetImportButton()                
              							
                    Me.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=WCAR_Doc" 
                    Me.ImportButton.Attributes.Item("onClick") = "window.open('" & Me.Page.EncryptUrlParameter(Me.ImportButton.PostBackUrl) & "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;"
                        
   
        End Sub
            
        Public Overridable Sub SetNewButton()                
              
              Try        
                    Dim url as String = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False"
              
                      
                    url = Me.ModifyRedirectUrl(url, "", True)
                    
                    url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
                    
                    url = url & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup") & "&Target=" & CType(Me.Page, BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(Me, "WCAR_DocTableControl_PostbackTracker").ClientID)                           
                                
                Dim javascriptCall as String = ""
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" & MiscUtils.FindControlRecursively(Me, "WCAR_DocTableControl_PostbackTracker").ClientID & "'), '" & url & "', true, event);"                                      
                       
                    Me.NewButton.Attributes.Item("onClick") = javascriptCall & "return false;"                  
                Catch
                    ' do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                End Try
                  
   
        End Sub
            
        Public Overridable Sub SetPDFButton()                
              
   
        End Sub
            
        Public Overridable Sub SetResetButton()                
              
   
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
    
      
            If (IsValueSelected(WCD_WDT_IDFilter)) Then
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
              Me.TotalRecords = WCAR_DocTable.GetRecordCount(join, wc)
              If Me.TotalRecords > 10000 Then
          
              ' Add each of the columns in order of export.
              Dim columns() as BaseColumn = New BaseColumn() { _
                         WCAR_DocTable.WCD_WDT_ID, _ 
             WCAR_DocTable.WCD_No, _ 
             WCAR_DocTable.WCD_Submit, _ 
             WCAR_DocTable.WCD_Status, _ 
             WCAR_DocTable.WCD_Remark, _ 
             WCAR_DocTable.WCD_Unit_Location, _ 
             WCAR_DocTable.WCD_Project_Title, _ 
             WCAR_DocTable.WCD_Project_No, _ 
             WCAR_DocTable.WCD_Request_Date, _ 
             WCAR_DocTable.WCD_Proj_Inc_ACB, _ 
             WCAR_DocTable.WCD_Exp_Total, _ 
             WCAR_DocTable.WCD_Exp_Prev_Total, _ 
             WCAR_DocTable.WCD_Exp_Budget, _ 
             WCAR_DocTable.WCD_Exp_Under_Over_Budget, _ 
             WCAR_DocTable.WCD_Exp_Cur_Yr, _ 
             WCAR_DocTable.WCD_Exp_Nxt_Yr, _ 
             WCAR_DocTable.WCD_Exp_Sub_Yr, _ 
             WCAR_DocTable.WCD_C_ID, _ 
             WCAR_DocTable.WCD_U_ID, _ 
             WCAR_DocTable.WCD_Created, _ 
             WCAR_DocTable.WCD_WCur_ID, _ 
             WCAR_DocTable.WCD_Supplementary, _ 
             WCAR_DocTable.WCD_Supplementary_WCD_ID, _ 
             WCAR_DocTable.WCD_Supplementary_Manual, _ 
             Nothing}
              Dim  exportData as ExportDataToCSV = New ExportDataToCSV(WCAR_DocTable.Instance, wc, orderBy, columns)
              exportData.StartExport(Me.Page.Response, True)

              Dim dataForCSV As DataForExport = New DataForExport(WCAR_DocTable.Instance, wc, orderBy, columns, join)

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
              Dim excelReport As ExportDataToExcel = New ExportDataToExcel(WCAR_DocTable.Instance, wc, orderBy)
              ' Add each of the columns in order of export.
              ' To customize the data type, change the second parameter of the new ExcelColumn to be
              ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              If Me.Page.Response Is Nothing Then
                Return
              End If

              excelReport.CreateExcelBook()

              Dim width As Integer = 0
              Dim columnCounter As Integer = 0
              Dim data As DataForExport = New DataForExport(WCAR_DocTable.Instance, wc, orderBy, Nothing, join)
                       data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_WDT_ID, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_No, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Submit, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Status, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Remark, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Unit_Location, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Project_Title, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Project_No, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Request_Date, "Short Date"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Proj_Inc_ACB, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Exp_Total, "Standard"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Exp_Prev_Total, "Standard"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Exp_Budget, "Standard"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Exp_Under_Over_Budget, "Standard"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Exp_Cur_Yr, "Standard"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Exp_Nxt_Yr, "Standard"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Exp_Sub_Yr, "Standard"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_C_ID, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_U_ID, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Created, "Short Date"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_WCur_ID, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Supplementary, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Supplementary_WCD_ID, "0"))
             data.ColumnList.Add(New ExcelColumn(WCAR_DocTable.WCD_Supplementary_Manual, "Default"))


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
                              val = WCAR_DocTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
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
        Public Overridable Sub ImportButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
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
        Public Overridable Sub NewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False"
                  
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
      
                    url = url & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup") & "&Target=" & CType(Me.Page, BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(Me, "WCAR_DocTableControl_PostbackTracker").ClientID)                           
                                
                Dim javascriptCall as String = ""
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" & MiscUtils.FindControlRecursively(Me, "WCAR_DocTableControl_PostbackTracker").ClientID & "'), '" & url & "', true, event);"                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "NewButton_Click", javascriptCall, True)
        
            End If
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub PDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("Show-WCAR-Doc-Table.PDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "WCAR_Doc"
                ' If Show-WCAR-Doc-Table.PDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(WCAR_DocTable.WCD_WDT_ID.Name, ReportEnum.Align.Left, "${WCD_WDT_ID}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_No.Name, ReportEnum.Align.Left, "${WCD_No}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Submit.Name, ReportEnum.Align.Left, "${WCD_Submit}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WCAR_DocTable.WCD_Status.Name, ReportEnum.Align.Left, "${WCD_Status}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Remark.Name, ReportEnum.Align.Left, "${WCD_Remark}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Unit_Location.Name, ReportEnum.Align.Left, "${WCD_Unit_Location}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Project_Title.Name, ReportEnum.Align.Left, "${WCD_Project_Title}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Project_No.Name, ReportEnum.Align.Left, "${WCD_Project_No}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Request_Date.Name, ReportEnum.Align.Left, "${WCD_Request_Date}", ReportEnum.Align.Left, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Proj_Inc_ACB.Name, ReportEnum.Align.Left, "${WCD_Proj_Inc_ACB}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Total.Name, ReportEnum.Align.Right, "${WCD_Exp_Total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Prev_Total.Name, ReportEnum.Align.Right, "${WCD_Exp_Prev_Total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Budget.Name, ReportEnum.Align.Right, "${WCD_Exp_Budget}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Under_Over_Budget.Name, ReportEnum.Align.Right, "${WCD_Exp_Under_Over_Budget}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Cur_Yr.Name, ReportEnum.Align.Right, "${WCD_Exp_Cur_Yr}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Nxt_Yr.Name, ReportEnum.Align.Right, "${WCD_Exp_Nxt_Yr}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Sub_Yr.Name, ReportEnum.Align.Right, "${WCD_Exp_Sub_Yr}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_C_ID.Name, ReportEnum.Align.Left, "${WCD_C_ID}", ReportEnum.Align.Left, 25)
                 report.AddColumn(WCAR_DocTable.WCD_U_ID.Name, ReportEnum.Align.Left, "${WCD_U_ID}", ReportEnum.Align.Left, 22)
                 report.AddColumn(WCAR_DocTable.WCD_Created.Name, ReportEnum.Align.Left, "${WCD_Created}", ReportEnum.Align.Left, 20)
                 report.AddColumn(WCAR_DocTable.WCD_WCur_ID.Name, ReportEnum.Align.Left, "${WCD_WCur_ID}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Supplementary.Name, ReportEnum.Align.Left, "${WCD_Supplementary}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WCAR_DocTable.WCD_Supplementary_WCD_ID.Name, ReportEnum.Align.Right, "${WCD_Supplementary_WCD_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(WCAR_DocTable.WCD_Supplementary_Manual.Name, ReportEnum.Align.Left, "${WCD_Supplementary_Manual}", ReportEnum.Align.Left, 28)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
                
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = WCAR_DocTable.GetRecordCount(joinFilter,whereClause)
                Dim columns As ColumnList = WCAR_DocTable.GetColumnList()
                Dim records As WCAR_DocRecord() = Nothing
            
                Do 
                    
                    records = WCAR_DocTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As WCAR_DocRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         If BaseClasses.Utils.MiscUtils.IsNull(record.WCD_WDT_ID) Then
                                 report.AddData("${WCD_WDT_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_WDT_ID)
                                 _DFKA = WCAR_DocTable.GetDFKA(record.WCD_WDT_ID.ToString(), WCAR_DocTable.WCD_WDT_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WCAR_DocTable.WCD_WDT_ID.IsApplyDisplayAs Then
                                     report.AddData("${WCD_WDT_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${WCD_WDT_ID}", record.Format(WCAR_DocTable.WCD_WDT_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${WCD_No}", record.Format(WCAR_DocTable.WCD_No), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Submit}", record.Format(WCAR_DocTable.WCD_Submit), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Status}", record.Format(WCAR_DocTable.WCD_Status), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Remark}", record.Format(WCAR_DocTable.WCD_Remark), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Unit_Location}", record.Format(WCAR_DocTable.WCD_Unit_Location), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Project_Title}", record.Format(WCAR_DocTable.WCD_Project_Title), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Project_No}", record.Format(WCAR_DocTable.WCD_Project_No), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Request_Date}", record.Format(WCAR_DocTable.WCD_Request_Date), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Proj_Inc_ACB}", record.Format(WCAR_DocTable.WCD_Proj_Inc_ACB), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Exp_Total}", record.Format(WCAR_DocTable.WCD_Exp_Total), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Prev_Total}", record.Format(WCAR_DocTable.WCD_Exp_Prev_Total), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Budget}", record.Format(WCAR_DocTable.WCD_Exp_Budget), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Under_Over_Budget}", record.Format(WCAR_DocTable.WCD_Exp_Under_Over_Budget), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Cur_Yr}", record.Format(WCAR_DocTable.WCD_Exp_Cur_Yr), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Nxt_Yr}", record.Format(WCAR_DocTable.WCD_Exp_Nxt_Yr), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Sub_Yr}", record.Format(WCAR_DocTable.WCD_Exp_Sub_Yr), ReportEnum.Align.Right, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.WCD_C_ID) Then
                                 report.AddData("${WCD_C_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_C_ID)
                                 _DFKA = WCAR_DocTable.GetDFKA(record.WCD_C_ID.ToString(), WCAR_DocTable.WCD_C_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WCAR_DocTable.WCD_C_ID.IsApplyDisplayAs Then
                                     report.AddData("${WCD_C_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${WCD_C_ID}", record.Format(WCAR_DocTable.WCD_C_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             If BaseClasses.Utils.MiscUtils.IsNull(record.WCD_U_ID) Then
                                 report.AddData("${WCD_U_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_U_ID)
                                 _DFKA = WCAR_DocTable.GetDFKA(record.WCD_U_ID.ToString(), WCAR_DocTable.WCD_U_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WCAR_DocTable.WCD_U_ID.IsApplyDisplayAs Then
                                     report.AddData("${WCD_U_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${WCD_U_ID}", record.Format(WCAR_DocTable.WCD_U_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${WCD_Created}", record.Format(WCAR_DocTable.WCD_Created), ReportEnum.Align.Left, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.WCD_WCur_ID) Then
                                 report.AddData("${WCD_WCur_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_WCur_ID)
                                 _DFKA = WCAR_DocTable.GetDFKA(record.WCD_WCur_ID.ToString(), WCAR_DocTable.WCD_WCur_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WCAR_DocTable.WCD_WCur_ID.IsApplyDisplayAs Then
                                     report.AddData("${WCD_WCur_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${WCD_WCur_ID}", record.Format(WCAR_DocTable.WCD_WCur_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${WCD_Supplementary}", record.Format(WCAR_DocTable.WCD_Supplementary), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Supplementary_WCD_ID}", record.Format(WCAR_DocTable.WCD_Supplementary_WCD_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Supplementary_Manual}", record.Format(WCAR_DocTable.WCD_Supplementary_Manual), ReportEnum.Align.Left, 300)

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
    
              Me.WCD_WDT_IDFilter.ClearSelection()
            Me.SortControl.ClearSelection()
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
        Public Overridable Sub WordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("Show-WCAR-Doc-Table.WordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "WCAR_Doc"
                ' If Show-WCAR-Doc-Table.WordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(WCAR_DocTable.WCD_WDT_ID.Name, ReportEnum.Align.Left, "${WCD_WDT_ID}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_No.Name, ReportEnum.Align.Left, "${WCD_No}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Submit.Name, ReportEnum.Align.Left, "${WCD_Submit}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WCAR_DocTable.WCD_Status.Name, ReportEnum.Align.Left, "${WCD_Status}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Remark.Name, ReportEnum.Align.Left, "${WCD_Remark}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Unit_Location.Name, ReportEnum.Align.Left, "${WCD_Unit_Location}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Project_Title.Name, ReportEnum.Align.Left, "${WCD_Project_Title}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Project_No.Name, ReportEnum.Align.Left, "${WCD_Project_No}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Request_Date.Name, ReportEnum.Align.Left, "${WCD_Request_Date}", ReportEnum.Align.Left, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Proj_Inc_ACB.Name, ReportEnum.Align.Left, "${WCD_Proj_Inc_ACB}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Total.Name, ReportEnum.Align.Right, "${WCD_Exp_Total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Prev_Total.Name, ReportEnum.Align.Right, "${WCD_Exp_Prev_Total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Budget.Name, ReportEnum.Align.Right, "${WCD_Exp_Budget}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Under_Over_Budget.Name, ReportEnum.Align.Right, "${WCD_Exp_Under_Over_Budget}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Cur_Yr.Name, ReportEnum.Align.Right, "${WCD_Exp_Cur_Yr}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Nxt_Yr.Name, ReportEnum.Align.Right, "${WCD_Exp_Nxt_Yr}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_Exp_Sub_Yr.Name, ReportEnum.Align.Right, "${WCD_Exp_Sub_Yr}", ReportEnum.Align.Right, 20)
                 report.AddColumn(WCAR_DocTable.WCD_C_ID.Name, ReportEnum.Align.Left, "${WCD_C_ID}", ReportEnum.Align.Left, 25)
                 report.AddColumn(WCAR_DocTable.WCD_U_ID.Name, ReportEnum.Align.Left, "${WCD_U_ID}", ReportEnum.Align.Left, 22)
                 report.AddColumn(WCAR_DocTable.WCD_Created.Name, ReportEnum.Align.Left, "${WCD_Created}", ReportEnum.Align.Left, 20)
                 report.AddColumn(WCAR_DocTable.WCD_WCur_ID.Name, ReportEnum.Align.Left, "${WCD_WCur_ID}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCAR_DocTable.WCD_Supplementary.Name, ReportEnum.Align.Left, "${WCD_Supplementary}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WCAR_DocTable.WCD_Supplementary_WCD_ID.Name, ReportEnum.Align.Right, "${WCD_Supplementary_WCD_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(WCAR_DocTable.WCD_Supplementary_Manual.Name, ReportEnum.Align.Left, "${WCD_Supplementary_Manual}", ReportEnum.Align.Left, 28)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = WCAR_DocTable.GetRecordCount(joinFilter,whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = WCAR_DocTable.GetColumnList()
                Dim records As WCAR_DocRecord() = Nothing
                Do
                    records = WCAR_DocTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As WCAR_DocRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             If BaseClasses.Utils.MiscUtils.IsNull(record.WCD_WDT_ID) Then
                                 report.AddData("${WCD_WDT_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_WDT_ID)
                                 _DFKA = WCAR_DocTable.GetDFKA(record.WCD_WDT_ID.ToString(), WCAR_DocTable.WCD_WDT_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WCAR_DocTable.WCD_WDT_ID.IsApplyDisplayAs Then
                                     report.AddData("${WCD_WDT_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${WCD_WDT_ID}", record.Format(WCAR_DocTable.WCD_WDT_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${WCD_No}", record.Format(WCAR_DocTable.WCD_No), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Submit}", record.Format(WCAR_DocTable.WCD_Submit), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Status}", record.Format(WCAR_DocTable.WCD_Status), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Remark}", record.Format(WCAR_DocTable.WCD_Remark), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Unit_Location}", record.Format(WCAR_DocTable.WCD_Unit_Location), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Project_Title}", record.Format(WCAR_DocTable.WCD_Project_Title), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Project_No}", record.Format(WCAR_DocTable.WCD_Project_No), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Request_Date}", record.Format(WCAR_DocTable.WCD_Request_Date), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Proj_Inc_ACB}", record.Format(WCAR_DocTable.WCD_Proj_Inc_ACB), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Exp_Total}", record.Format(WCAR_DocTable.WCD_Exp_Total), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Prev_Total}", record.Format(WCAR_DocTable.WCD_Exp_Prev_Total), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Budget}", record.Format(WCAR_DocTable.WCD_Exp_Budget), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Under_Over_Budget}", record.Format(WCAR_DocTable.WCD_Exp_Under_Over_Budget), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Cur_Yr}", record.Format(WCAR_DocTable.WCD_Exp_Cur_Yr), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Nxt_Yr}", record.Format(WCAR_DocTable.WCD_Exp_Nxt_Yr), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Exp_Sub_Yr}", record.Format(WCAR_DocTable.WCD_Exp_Sub_Yr), ReportEnum.Align.Right, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.WCD_C_ID) Then
                                 report.AddData("${WCD_C_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_C_ID)
                                 _DFKA = WCAR_DocTable.GetDFKA(record.WCD_C_ID.ToString(), WCAR_DocTable.WCD_C_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WCAR_DocTable.WCD_C_ID.IsApplyDisplayAs Then
                                     report.AddData("${WCD_C_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${WCD_C_ID}", record.Format(WCAR_DocTable.WCD_C_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             If BaseClasses.Utils.MiscUtils.IsNull(record.WCD_U_ID) Then
                                 report.AddData("${WCD_U_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_U_ID)
                                 _DFKA = WCAR_DocTable.GetDFKA(record.WCD_U_ID.ToString(), WCAR_DocTable.WCD_U_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WCAR_DocTable.WCD_U_ID.IsApplyDisplayAs Then
                                     report.AddData("${WCD_U_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${WCD_U_ID}", record.Format(WCAR_DocTable.WCD_U_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${WCD_Created}", record.Format(WCAR_DocTable.WCD_Created), ReportEnum.Align.Left, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.WCD_WCur_ID) Then
                                 report.AddData("${WCD_WCur_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WCAR_DocTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_DocTable.WCD_WCur_ID)
                                 _DFKA = WCAR_DocTable.GetDFKA(record.WCD_WCur_ID.ToString(), WCAR_DocTable.WCD_WCur_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WCAR_DocTable.WCD_WCur_ID.IsApplyDisplayAs Then
                                     report.AddData("${WCD_WCur_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${WCD_WCur_ID}", record.Format(WCAR_DocTable.WCD_WCur_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${WCD_Supplementary}", record.Format(WCAR_DocTable.WCD_Supplementary), ReportEnum.Align.Left, 300)
                             report.AddData("${WCD_Supplementary_WCD_ID}", record.Format(WCAR_DocTable.WCD_Supplementary_WCD_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${WCD_Supplementary_Manual}", record.Format(WCAR_DocTable.WCD_Supplementary_Manual), ReportEnum.Align.Left, 300)

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
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WCAR_DocTable.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WCAR_DocTable.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WCAR_DocTable.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not WCAR_DocTable.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WCAR_DocTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WCAR_DocTable.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub WCD_WDT_IDFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = WCAR_DocTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WCAR_DocRecord ()
            Get
                Return DirectCast(MyBase._DataSource, WCAR_DocRecord())
            End Get
            Set(ByVal value() As WCAR_DocRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property ActionsButton() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ActionsButton"), ePortalWFApproval.UI.IThemeButtonWithArrow)
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
        
        Public ReadOnly Property ImportButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ImportButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property NewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "NewButton"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property WCD_WDT_IDFilter() As BaseClasses.Web.UI.WebControls.QuickSelector
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WDT_IDFilter"), BaseClasses.Web.UI.WebControls.QuickSelector)
            End Get
        End Property
        
        Public ReadOnly Property WCD_WDT_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCD_WDT_IDLabel1"), System.Web.UI.WebControls.Literal)
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
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As WCAR_DocTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_DocRecord = Nothing     
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
                Dim recCtl As WCAR_DocTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_DocRecord = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WCAR_DocTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WCAR_DocTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WCAR_DocTableControlRow)), WCAR_DocTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WCAR_DocTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WCAR_DocTableControlRow
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

        Public Overridable Function GetRecordControls() As WCAR_DocTableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WCAR_DocTableControlRow")
            Dim list As New List(Of WCAR_DocTableControlRow)
            For Each recCtrl As WCAR_DocTableControlRow In recCtrls
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

  