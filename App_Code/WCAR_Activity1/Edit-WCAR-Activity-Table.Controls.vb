
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Edit_WCAR_Activity_Table.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.Edit_WCAR_Activity_Table

#Region "Section 1: Place your customizations here."

    
Public Class WCAR_Activity1TableControlRow
        Inherits BaseWCAR_Activity1TableControlRow
        ' The BaseWCAR_Activity1TableControlRow implements code for a ROW within the
        ' the WCAR_Activity1TableControl table.  The BaseWCAR_Activity1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WCAR_Activity1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WCAR_Activity1TableControl
        Inherits BaseWCAR_Activity1TableControl

    ' The BaseWCAR_Activity1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WCAR_Activity1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the WCAR_Activity1TableControlRow control on the Edit_WCAR_Activity_Table page.
' Do not modify this class. Instead override any method in WCAR_Activity1TableControlRow.
Public Class BaseWCAR_Activity1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCAR_Activity1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WCAR_Activity1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Show confirmation message on Click
              Me.DeleteRowButton.Attributes.Add("onClick", "return (confirm(""" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ePortalWFApproval") & """));")
                  
        
              ' Register the event handlers.
          
              AddHandler Me.DeleteRowButton.Click, AddressOf DeleteRowButton_Click
                        
              AddHandler Me.EditRowButton.Click, AddressOf EditRowButton_Click
                        
              AddHandler Me.ViewRowButton.Click, AddressOf ViewRowButton_Click
                        
              AddHandler Me.WCA_W_U_ID.SelectedIndexChanged, AddressOf WCA_W_U_ID_SelectedIndexChanged                  
                
              AddHandler Me.WCA_W_U_ID_Delegate.SelectedIndexChanged, AddressOf WCA_W_U_ID_Delegate_SelectedIndexChanged                  
                
              AddHandler Me.WCA_WCD_ID.SelectedIndexChanged, AddressOf WCA_WCD_ID_SelectedIndexChanged                  
                
              AddHandler Me.WCA_WDT_ID.SelectedIndexChanged, AddressOf WCA_WDT_ID_SelectedIndexChanged                  
                
              AddHandler Me.WCA_WS_ID.SelectedIndexChanged, AddressOf WCA_WS_ID_SelectedIndexChanged                  
                
              AddHandler Me.WCA_WSD_ID.SelectedIndexChanged, AddressOf WCA_WSD_ID_SelectedIndexChanged                  
                
              AddHandler Me.WCA_Is_Done.CheckedChanged, AddressOf WCA_Is_Done_CheckedChanged
            
              AddHandler Me.WCA_Date_Action.TextChanged, AddressOf WCA_Date_Action_TextChanged
            
              AddHandler Me.WCA_Date_Assign.TextChanged, AddressOf WCA_Date_Assign_TextChanged
            
              AddHandler Me.WCA_Remark.TextChanged, AddressOf WCA_Remark_TextChanged
            
              AddHandler Me.WCA_Status.TextChanged, AddressOf WCA_Status_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCAR_Activity1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWCAR_Activity1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WCAR_Activity1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCAR_Activity1TableControlRow.
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
        
                
                
                
                
                SetWCA_Date_Action()
                SetWCA_Date_ActionLabel()
                SetWCA_Date_Assign()
                SetWCA_Date_AssignLabel()
                SetWCA_Is_Done()
                SetWCA_Is_DoneLabel()
                SetWCA_Remark()
                SetWCA_RemarkLabel()
                SetWCA_Status()
                SetWCA_StatusLabel()
                SetWCA_W_U_ID()
                SetWCA_W_U_ID_Delegate()
                SetWCA_W_U_ID_DelegateLabel()
                SetWCA_W_U_IDLabel()
                SetWCA_WCD_ID()
                SetWCA_WCD_IDLabel()
                SetWCA_WDT_ID()
                SetWCA_WDT_IDLabel()
                SetWCA_WS_ID()
                SetWCA_WS_IDLabel()
                SetWCA_WSD_ID()
                SetWCA_WSD_IDLabel()
                SetDeleteRowButton()
              
                SetEditRowButton()
              
                SetViewRowButton()
              
      
      
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
        
        
        Public Overridable Sub SetWCA_Date_Action()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_Date_Action.ID) Then
            
                Me.WCA_Date_Action.Text = Me.PreviousUIData(Me.WCA_Date_Action.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCA_Date_Action TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Date_Action is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Date_ActionSpecified Then
                				
                ' If the WCA_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Activity1Table.WCA_Date_Action, "g")
                              
                Me.WCA_Date_Action.Text = formattedValue
                
            Else 
            
                ' WCA_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Date_Action.Text = WCAR_Activity1Table.WCA_Date_Action.Format(WCAR_Activity1Table.WCA_Date_Action.DefaultValue, "g")
                        		
                End If
                 
              AddHandler Me.WCA_Date_Action.TextChanged, AddressOf WCA_Date_Action_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCA_Date_Assign()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_Date_Assign.ID) Then
            
                Me.WCA_Date_Assign.Text = Me.PreviousUIData(Me.WCA_Date_Assign.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCA_Date_Assign TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Date_Assign is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Date_AssignSpecified Then
                				
                ' If the WCA_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Activity1Table.WCA_Date_Assign, "g")
                              
                Me.WCA_Date_Assign.Text = formattedValue
                
            Else 
            
                ' WCA_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Date_Assign.Text = WCAR_Activity1Table.WCA_Date_Assign.Format(WCAR_Activity1Table.WCA_Date_Assign.DefaultValue, "g")
                        		
                End If
                 
              AddHandler Me.WCA_Date_Assign.TextChanged, AddressOf WCA_Date_Assign_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCA_Is_Done()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_Is_Done.ID) Then
                Me.WCA_Is_Done.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCA_Is_Done.ID))
                Return
            End If		
            
        
            ' Set the WCA_Is_Done CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Is_Done is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCA_Is_Done()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_Is_DoneSpecified Then
                									
                ' If the WCA_Is_Done is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.WCA_Is_Done.Checked = Me.DataSource.WCA_Is_Done
            Else
            
                ' WCA_Is_Done is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCA_Is_Done.Checked = WCAR_Activity1Table.WCA_Is_Done.ParseValue(WCAR_Activity1Table.WCA_Is_Done.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCA_Remark()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_Remark.ID) Then
            
                Me.WCA_Remark.Text = Me.PreviousUIData(Me.WCA_Remark.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCA_Remark TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Remark is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Remark()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_RemarkSpecified Then
                				
                ' If the WCA_Remark is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Activity1Table.WCA_Remark)
                              
                Me.WCA_Remark.Text = formattedValue
                
            Else 
            
                ' WCA_Remark is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Remark.Text = WCAR_Activity1Table.WCA_Remark.Format(WCAR_Activity1Table.WCA_Remark.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCA_Remark.TextChanged, AddressOf WCA_Remark_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCA_Status()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_Status.ID) Then
            
                Me.WCA_Status.Text = Me.PreviousUIData(Me.WCA_Status.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCA_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_Status is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_StatusSpecified Then
                				
                ' If the WCA_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCAR_Activity1Table.WCA_Status)
                              
                Me.WCA_Status.Text = formattedValue
                
            Else 
            
                ' WCA_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCA_Status.Text = WCAR_Activity1Table.WCA_Status.Format(WCAR_Activity1Table.WCA_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCA_Status.TextChanged, AddressOf WCA_Status_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCA_W_U_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_W_U_ID.ID) Then
                If Me.PreviousUIData(Me.WCA_W_U_ID.ID) Is Nothing
                    selectedValue = Nothing
                Else
                    selectedValue = Me.PreviousUIData(Me.WCA_W_U_ID.ID).ToString()
                End If
            End If
            
        
            ' Set the WCA_W_U_ID QuickSelector on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_W_U_ID is the ASP:QuickSelector on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_W_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_W_U_IDSpecified Then
                            
                ' If the WCA_W_U_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCA_W_U_ID.ToString()
            Else
                
                ' WCA_W_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Activity1Table.WCA_W_U_ID.DefaultValue
                End If
                				
            End If			
                
            ' Add the Please Select item.
            If selectedValue Is Nothing OrElse selectedValue = ""  Then
                  MiscUtils.ResetSelectedItem(Me.WCA_W_U_ID, New ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
            End If              
            
            
                  
            ' Populate the item(s) to the control
            
            Me.WCA_W_U_ID.SetFieldMaxLength(50)
            
            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) 
            variables = New System.Collections.Generic.Dictionary(Of String, Object)              
            Dim evaluator As FormulaEvaluator
            evaluator = New FormulaEvaluator
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCA_W_U_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCA_W_U_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.sel_WASP_User.W_U_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Sel_WASP_User1View.W_U_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Sel_WASP_User1Record = Sel_WASP_User1View.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As Sel_WASP_User1Record = DirectCast(rc(0), Sel_WASP_User1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.W_U_IDSpecified Then
                            cvalue = itemValue.W_U_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Activity1Table.WCA_W_U_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Activity1Table.WCA_W_U_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Activity1Table.GetDFKA(itemValue, WCAR_Activity1Table.WCA_W_U_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(Sel_WASP_User1View.W_U_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCA_W_U_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
              Dim url as String = Me.ModifyRedirectUrl("../sel_WASP_User1/Sel-WASP-User-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WCA_W_U_ID.ClientID & "&Formula=" & CType(Me.Page, BaseApplicationPage).Encrypt("= Sel_WASP_User1.W_U_Full_Name")& "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("W_U_ID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--PLEASE_SELECT--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:PleaseSelect"))& "&Mode=" & CType(Me.Page, BaseApplicationPage).Encrypt("FieldValueSingleSelection") & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WCA_W_U_ID.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCA_W_U_ID.AutoPostBack).ToLower() & ", event); return false;"        
                  
                    
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCA_W_U_ID_Delegate()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_W_U_ID_Delegate.ID) Then
                If Me.PreviousUIData(Me.WCA_W_U_ID_Delegate.ID) Is Nothing
                    selectedValue = Nothing
                Else
                    selectedValue = Me.PreviousUIData(Me.WCA_W_U_ID_Delegate.ID).ToString()
                End If
            End If
            
        
            ' Set the WCA_W_U_ID_Delegate QuickSelector on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_W_U_ID_Delegate is the ASP:QuickSelector on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_W_U_ID_Delegate()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_W_U_ID_DelegateSpecified Then
                            
                ' If the WCA_W_U_ID_Delegate is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCA_W_U_ID_Delegate.ToString()
            Else
                
                ' WCA_W_U_ID_Delegate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Activity1Table.WCA_W_U_ID_Delegate.DefaultValue
                End If
                				
            End If			
                
            ' Add the Please Select item.
            If selectedValue Is Nothing OrElse selectedValue = ""  Then
                  MiscUtils.ResetSelectedItem(Me.WCA_W_U_ID_Delegate, New ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
            End If              
            
            
                  
            ' Populate the item(s) to the control
            
            Me.WCA_W_U_ID_Delegate.SetFieldMaxLength(50)
            
            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) 
            variables = New System.Collections.Generic.Dictionary(Of String, Object)              
            Dim evaluator As FormulaEvaluator
            evaluator = New FormulaEvaluator
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCA_W_U_ID_Delegate, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCA_W_U_ID_Delegate, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.sel_WASP_User.W_U_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Sel_WASP_User1View.W_U_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Sel_WASP_User1Record = Sel_WASP_User1View.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As Sel_WASP_User1Record = DirectCast(rc(0), Sel_WASP_User1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.W_U_IDSpecified Then
                            cvalue = itemValue.W_U_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Activity1Table.WCA_W_U_ID_Delegate)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Activity1Table.WCA_W_U_ID_Delegate.IsApplyDisplayAs Then
                          fvalue = WCAR_Activity1Table.GetDFKA(itemValue, WCAR_Activity1Table.WCA_W_U_ID_Delegate)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(Sel_WASP_User1View.W_U_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCA_W_U_ID_Delegate, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
              Dim url as String = Me.ModifyRedirectUrl("../sel_WASP_User1/Sel-WASP-User-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WCA_W_U_ID_Delegate.ClientID & "&Formula=" & CType(Me.Page, BaseApplicationPage).Encrypt("= Sel_WASP_User1.W_U_Full_Name")& "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("W_U_ID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--PLEASE_SELECT--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:PleaseSelect"))& "&Mode=" & CType(Me.Page, BaseApplicationPage).Encrypt("FieldValueSingleSelection") & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WCA_W_U_ID_Delegate.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCA_W_U_ID_Delegate.AutoPostBack).ToLower() & ", event); return false;"        
                  
                    
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCA_WCD_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_WCD_ID.ID) Then
                If Me.PreviousUIData(Me.WCA_WCD_ID.ID) Is Nothing
                    selectedValue = Nothing
                Else
                    selectedValue = Me.PreviousUIData(Me.WCA_WCD_ID.ID).ToString()
                End If
            End If
            
        
            ' Set the WCA_WCD_ID QuickSelector on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_WCD_ID is the ASP:QuickSelector on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WCD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WCD_IDSpecified Then
                            
                ' If the WCA_WCD_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCA_WCD_ID.ToString()
            Else
                
                ' WCA_WCD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Activity1Table.WCA_WCD_ID.DefaultValue
                End If
                				
            End If			
                
            ' Add the Please Select item.
            If selectedValue Is Nothing OrElse selectedValue = ""  Then
                  MiscUtils.ResetSelectedItem(Me.WCA_WCD_ID, New ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
            End If              
            
            
                  
            ' Populate the item(s) to the control
            
            Me.WCA_WCD_ID.SetFieldMaxLength(50)
            
            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) 
            variables = New System.Collections.Generic.Dictionary(Of String, Object)              
            Dim evaluator As FormulaEvaluator
            evaluator = New FormulaEvaluator
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCA_WCD_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCA_WCD_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WCAR_Doc.WCD_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WCAR_Doc1Table.WCD_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WCAR_Doc1Record = WCAR_Doc1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WCAR_Doc1Record = DirectCast(rc(0), WCAR_Doc1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WCD_IDSpecified Then
                            cvalue = itemValue.WCD_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Activity1Table.WCA_WCD_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Activity1Table.WCA_WCD_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Activity1Table.GetDFKA(itemValue, WCAR_Activity1Table.WCA_WCD_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WCAR_Doc1Table.WCD_No)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCA_WCD_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
              Dim url as String = Me.ModifyRedirectUrl("../WCAR_Doc1/WCAR-Doc-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WCA_WCD_ID.ClientID & "&DFKA=" & CType(Me.Page, BaseApplicationPage).Encrypt("WCD_No")& "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WCD_ID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--PLEASE_SELECT--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:PleaseSelect"))& "&Mode=" & CType(Me.Page, BaseApplicationPage).Encrypt("FieldValueSingleSelection") & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WCA_WCD_ID.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCA_WCD_ID.AutoPostBack).ToLower() & ", event); return false;"        
                  
                    
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCA_WDT_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_WDT_ID.ID) Then
                If Me.PreviousUIData(Me.WCA_WDT_ID.ID) Is Nothing
                    selectedValue = Nothing
                Else
                    selectedValue = Me.PreviousUIData(Me.WCA_WDT_ID.ID).ToString()
                End If
            End If
            
        
            ' Set the WCA_WDT_ID QuickSelector on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_WDT_ID is the ASP:QuickSelector on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WDT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WDT_IDSpecified Then
                            
                ' If the WCA_WDT_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCA_WDT_ID.ToString()
            Else
                
                ' WCA_WDT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Activity1Table.WCA_WDT_ID.DefaultValue
                End If
                				
            End If			
                
            ' Add the Please Select item.
            If selectedValue Is Nothing OrElse selectedValue = ""  Then
                  MiscUtils.ResetSelectedItem(Me.WCA_WDT_ID, New ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
            End If              
            
            
                  
            ' Populate the item(s) to the control
            
            Me.WCA_WDT_ID.SetFieldMaxLength(50)
            
            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) 
            variables = New System.Collections.Generic.Dictionary(Of String, Object)              
            Dim evaluator As FormulaEvaluator
            evaluator = New FormulaEvaluator
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCA_WDT_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCA_WDT_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WDoc_Type.WDT_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WDoc_Type1Table.WDT_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WDoc_Type1Record = WDoc_Type1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WDoc_Type1Record = DirectCast(rc(0), WDoc_Type1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WDT_IDSpecified Then
                            cvalue = itemValue.WDT_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Activity1Table.WCA_WDT_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Activity1Table.WCA_WDT_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Activity1Table.GetDFKA(itemValue, WCAR_Activity1Table.WCA_WDT_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WDoc_Type1Table.WDT_Name)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCA_WDT_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
              Dim url as String = Me.ModifyRedirectUrl("../WDoc_Type1/WDoc-Type-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WCA_WDT_ID.ClientID & "&DFKA=" & CType(Me.Page, BaseApplicationPage).Encrypt("WDT_Name")& "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WDT_ID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--PLEASE_SELECT--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:PleaseSelect"))& "&Mode=" & CType(Me.Page, BaseApplicationPage).Encrypt("FieldValueSingleSelection") & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WCA_WDT_ID.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCA_WDT_ID.AutoPostBack).ToLower() & ", event); return false;"        
                  
                    
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCA_WS_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_WS_ID.ID) Then
                If Me.PreviousUIData(Me.WCA_WS_ID.ID) Is Nothing
                    selectedValue = Nothing
                Else
                    selectedValue = Me.PreviousUIData(Me.WCA_WS_ID.ID).ToString()
                End If
            End If
            
        
            ' Set the WCA_WS_ID QuickSelector on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_WS_ID is the ASP:QuickSelector on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WS_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WS_IDSpecified Then
                            
                ' If the WCA_WS_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCA_WS_ID.ToString()
            Else
                
                ' WCA_WS_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Activity1Table.WCA_WS_ID.DefaultValue
                End If
                				
            End If			
                
            ' Add the Please Select item.
            If selectedValue Is Nothing OrElse selectedValue = ""  Then
                  MiscUtils.ResetSelectedItem(Me.WCA_WS_ID, New ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
            End If              
            
            
                  
            ' Populate the item(s) to the control
            
            Me.WCA_WS_ID.SetFieldMaxLength(50)
            
            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) 
            variables = New System.Collections.Generic.Dictionary(Of String, Object)              
            Dim evaluator As FormulaEvaluator
            evaluator = New FormulaEvaluator
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCA_WS_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCA_WS_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WStep.WS_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WStep1Table.WS_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WStep1Record = WStep1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WStep1Record = DirectCast(rc(0), WStep1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WS_IDSpecified Then
                            cvalue = itemValue.WS_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Activity1Table.WCA_WS_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Activity1Table.WCA_WS_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Activity1Table.GetDFKA(itemValue, WCAR_Activity1Table.WCA_WS_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WStep1Table.WS_Desc)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCA_WS_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
              Dim url as String = Me.ModifyRedirectUrl("../WStep1/WStep-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WCA_WS_ID.ClientID & "&DFKA=" & CType(Me.Page, BaseApplicationPage).Encrypt("WS_Desc")& "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WS_ID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--PLEASE_SELECT--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:PleaseSelect"))& "&Mode=" & CType(Me.Page, BaseApplicationPage).Encrypt("FieldValueSingleSelection") & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WCA_WS_ID.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCA_WS_ID.AutoPostBack).ToLower() & ", event); return false;"        
                  
                    
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCA_WSD_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCA_WSD_ID.ID) Then
                If Me.PreviousUIData(Me.WCA_WSD_ID.ID) Is Nothing
                    selectedValue = Nothing
                Else
                    selectedValue = Me.PreviousUIData(Me.WCA_WSD_ID.ID).ToString()
                End If
            End If
            
        
            ' Set the WCA_WSD_ID QuickSelector on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCAR_Activity database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCAR_Activity record retrieved from the database.
            ' Me.WCA_WSD_ID is the ASP:QuickSelector on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCA_WSD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCA_WSD_IDSpecified Then
                            
                ' If the WCA_WSD_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCA_WSD_ID.ToString()
            Else
                
                ' WCA_WSD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCAR_Activity1Table.WCA_WSD_ID.DefaultValue
                End If
                				
            End If			
                
            ' Add the Please Select item.
            If selectedValue Is Nothing OrElse selectedValue = ""  Then
                  MiscUtils.ResetSelectedItem(Me.WCA_WSD_ID, New ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
            End If              
            
            
                  
            ' Populate the item(s) to the control
            
            Me.WCA_WSD_ID.SetFieldMaxLength(50)
            
            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) 
            variables = New System.Collections.Generic.Dictionary(Of String, Object)              
            Dim evaluator As FormulaEvaluator
            evaluator = New FormulaEvaluator
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCA_WSD_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCA_WSD_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WStep_Detail.WSD_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WStep_Detail1Table.WSD_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WStep_Detail1Record = WStep_Detail1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WStep_Detail1Record = DirectCast(rc(0), WStep_Detail1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WSD_IDSpecified Then
                            cvalue = itemValue.WSD_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCAR_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCAR_Activity1Table.WCA_WSD_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCAR_Activity1Table.WCA_WSD_ID.IsApplyDisplayAs Then
                          fvalue = WCAR_Activity1Table.GetDFKA(itemValue, WCAR_Activity1Table.WCA_WSD_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WStep_Detail1Table.WSD_Desc)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCA_WSD_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
              Dim url as String = Me.ModifyRedirectUrl("../WStep_Detail1/WStep-Detail-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WCA_WSD_ID.ClientID & "&DFKA=" & CType(Me.Page, BaseApplicationPage).Encrypt("WSD_Desc")& "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WSD_ID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--PLEASE_SELECT--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:PleaseSelect"))& "&Mode=" & CType(Me.Page, BaseApplicationPage).Encrypt("FieldValueSingleSelection") & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WCA_WSD_ID.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCA_WSD_ID.AutoPostBack).ToLower() & ", event); return false;"        
                  
                    
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCA_Date_ActionLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_Date_AssignLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_Is_DoneLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_RemarkLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_StatusLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_W_U_ID_DelegateLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_W_U_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WCD_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WDT_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WS_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCA_WSD_IDLabel()

                  
                  
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

      
        
        ' To customize, override this method in WCAR_Activity1TableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WCAR_Activity1TableControl"), WCAR_Activity1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCAR_Activity1TableControl"), WCAR_Activity1TableControl).ResetData = True
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

        ' To customize, override this method in WCAR_Activity1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCA_Date_Action()
            GetWCA_Date_Assign()
            GetWCA_Is_Done()
            GetWCA_Remark()
            GetWCA_Status()
            GetWCA_W_U_ID()
            GetWCA_W_U_ID_Delegate()
            GetWCA_WCD_ID()
            GetWCA_WDT_ID()
            GetWCA_WS_ID()
            GetWCA_WSD_ID()
        End Sub
        
        
        Public Overridable Sub GetWCA_Date_Action()
            
            ' Retrieve the value entered by the user on the WCA_Date_Action ASP:TextBox, and
            ' save it into the WCA_Date_Action field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCA_Date_Action.Text, WCAR_Activity1Table.WCA_Date_Action)			

                      
        End Sub
                
        Public Overridable Sub GetWCA_Date_Assign()
            
            ' Retrieve the value entered by the user on the WCA_Date_Assign ASP:TextBox, and
            ' save it into the WCA_Date_Assign field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCA_Date_Assign.Text, WCAR_Activity1Table.WCA_Date_Assign)			

                      
        End Sub
                
        Public Overridable Sub GetWCA_Is_Done()
        
        
            ' Retrieve the value entered by the user on the WCA_Is_Done ASP:CheckBox, and
            ' save it into the WCA_Is_Done field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
            ' Custom validation should be performed in Validate, not here.
            
            
            Me.DataSource.WCA_Is_Done = Me.WCA_Is_Done.Checked
                    
        End Sub
                
        Public Overridable Sub GetWCA_Remark()
            
            ' Retrieve the value entered by the user on the WCA_Remark ASP:TextBox, and
            ' save it into the WCA_Remark field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCA_Remark.Text, WCAR_Activity1Table.WCA_Remark)			

                      
        End Sub
                
        Public Overridable Sub GetWCA_Status()
            
            ' Retrieve the value entered by the user on the WCA_Status ASP:TextBox, and
            ' save it into the WCA_Status field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.WCA_Status.Text, WCAR_Activity1Table.WCA_Status)			

                      
        End Sub
                
        Public Overridable Sub GetWCA_W_U_ID()
         
            ' Retrieve the value entered by the user on the WCA_W_U_ID ASP:QuickSelector, and
            ' save it into the WCA_W_U_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCA_W_U_ID), WCAR_Activity1Table.WCA_W_U_ID)				
            
        End Sub
                
        Public Overridable Sub GetWCA_W_U_ID_Delegate()
         
            ' Retrieve the value entered by the user on the WCA_W_U_ID_Delegate ASP:QuickSelector, and
            ' save it into the WCA_W_U_ID_Delegate field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCA_W_U_ID_Delegate), WCAR_Activity1Table.WCA_W_U_ID_Delegate)				
            
        End Sub
                
        Public Overridable Sub GetWCA_WCD_ID()
         
            ' Retrieve the value entered by the user on the WCA_WCD_ID ASP:QuickSelector, and
            ' save it into the WCA_WCD_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCA_WCD_ID), WCAR_Activity1Table.WCA_WCD_ID)				
            
        End Sub
                
        Public Overridable Sub GetWCA_WDT_ID()
         
            ' Retrieve the value entered by the user on the WCA_WDT_ID ASP:QuickSelector, and
            ' save it into the WCA_WDT_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCA_WDT_ID), WCAR_Activity1Table.WCA_WDT_ID)				
            
        End Sub
                
        Public Overridable Sub GetWCA_WS_ID()
         
            ' Retrieve the value entered by the user on the WCA_WS_ID ASP:QuickSelector, and
            ' save it into the WCA_WS_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCA_WS_ID), WCAR_Activity1Table.WCA_WS_ID)				
            
        End Sub
                
        Public Overridable Sub GetWCA_WSD_ID()
         
            ' Retrieve the value entered by the user on the WCA_WSD_ID ASP:QuickSelector, and
            ' save it into the WCA_WSD_ID field in DataSource DatabaseANFLO-WFN%dbo.WCAR_Activity record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.WCA_WSD_ID), WCAR_Activity1Table.WCA_WSD_ID)				
            
        End Sub
                
      
        ' To customize, override this method in WCAR_Activity1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersWCAR_Activity1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WCAR_Activity1TableControlRow.
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
          WCAR_Activity1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WCAR_Activity1TableControl"), WCAR_Activity1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WCAR_Activity1TableControl"), WCAR_Activity1TableControl).ResetData = True
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
            
        Public Overridable Sub SetViewRowButton()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub DeleteRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As WCAR_Activity1TableControl = DirectCast(GetParentControlObject(Me, "WCAR_Activity1TableControl"), WCAR_Activity1TableControl)
                If Not (IsNothing(tc)) Then
                    If Not Me.IsNewRecord Then
                        tc.AddToDeletedRecordIds(DirectCast(Me, WCAR_Activity1TableControlRow))
                    End If
                    Me.Visible = False
                    tc.SetFormulaControls()
                End If
              
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
        Public Overridable Sub EditRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Shared/ConfigureEditRecord.aspx"
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
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
        Public Overridable Sub ViewRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../Shared/ConfigureViewRecord.aspx"
                  
                  If Me.Page.Request("RedirectStyle") <> "" Then url &= "?RedirectStyle=" & Me.Page.Request("RedirectStyle")
                  
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
        
        Protected Overridable Sub WCA_W_U_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)


          									
                
                
        End Sub
                      
                    
        Protected Overridable Sub WCA_W_U_ID_Delegate_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)


          									
                
                
        End Sub
                      
                    
        Protected Overridable Sub WCA_WCD_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)


          									
                
                
        End Sub
                      
                    
        Protected Overridable Sub WCA_WDT_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)


          									
                
                
        End Sub
                      
                    
        Protected Overridable Sub WCA_WS_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)


          									
                
                
        End Sub
                      
                    
        Protected Overridable Sub WCA_WSD_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)


          									
                
                
        End Sub
                      
                    
        Protected Overridable Sub WCA_Is_Done_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCA_Date_Action_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCA_Date_Assign_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCA_Remark_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCA_Status_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseWCAR_Activity1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCAR_Activity1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCAR_Activity1Record
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Activity1Record)
            End Get
            Set(ByVal value As WCAR_Activity1Record)
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
        
        Public ReadOnly Property SelectRow() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SelectRow"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property ViewRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ViewRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Date_Action() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_Action"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Date_ActionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_ActionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Date_Assign() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_Assign"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Date_AssignLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Date_AssignLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Is_Done() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Is_Done"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property WCA_Is_DoneLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Is_DoneLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Remark() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Remark"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCA_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_Status() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_Status"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCA_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
              Public ReadOnly Property WCA_W_U_ID() As BaseClasses.Web.UI.WebControls.QuickSelector
                  Get
                      Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_ID"), BaseClasses.Web.UI.WebControls.QuickSelector)
              End Get
              End Property
            
              Public ReadOnly Property WCA_W_U_ID_Delegate() As BaseClasses.Web.UI.WebControls.QuickSelector
                  Get
                      Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_ID_Delegate"), BaseClasses.Web.UI.WebControls.QuickSelector)
              End Get
              End Property
            
        Public ReadOnly Property WCA_W_U_ID_DelegateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_ID_DelegateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCA_W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_W_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
              Public ReadOnly Property WCA_WCD_ID() As BaseClasses.Web.UI.WebControls.QuickSelector
                  Get
                      Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WCD_ID"), BaseClasses.Web.UI.WebControls.QuickSelector)
              End Get
              End Property
            
        Public ReadOnly Property WCA_WCD_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WCD_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
              Public ReadOnly Property WCA_WDT_ID() As BaseClasses.Web.UI.WebControls.QuickSelector
                  Get
                      Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WDT_ID"), BaseClasses.Web.UI.WebControls.QuickSelector)
              End Get
              End Property
            
        Public ReadOnly Property WCA_WDT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WDT_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
              Public ReadOnly Property WCA_WS_ID() As BaseClasses.Web.UI.WebControls.QuickSelector
                  Get
                      Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WS_ID"), BaseClasses.Web.UI.WebControls.QuickSelector)
              End Get
              End Property
            
        Public ReadOnly Property WCA_WS_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WS_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
              Public ReadOnly Property WCA_WSD_ID() As BaseClasses.Web.UI.WebControls.QuickSelector
                  Get
                      Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WSD_ID"), BaseClasses.Web.UI.WebControls.QuickSelector)
              End Get
              End Property
            
        Public ReadOnly Property WCA_WSD_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCA_WSD_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WCAR_Activity1Record = Nothing
             
        
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
            
            Dim rec As WCAR_Activity1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCAR_Activity1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCAR_Activity1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WCAR_Activity1TableControl control on the Edit_WCAR_Activity_Table page.
' Do not modify this class. Instead override any method in WCAR_Activity1TableControl.
Public Class BaseWCAR_Activity1TableControl
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
            
              AddHandler Me.Pagination.FirstPage.Click, AddressOf Pagination_FirstPage_Click
                        
              AddHandler Me.Pagination.LastPage.Click, AddressOf Pagination_LastPage_Click
                        
              AddHandler Me.Pagination.NextPage.Click, AddressOf Pagination_NextPage_Click
                        
              AddHandler Me.Pagination.PageSizeButton.Click, AddressOf Pagination_PageSizeButton_Click
                        
              AddHandler Me.Pagination.PreviousPage.Click, AddressOf Pagination_PreviousPage_Click
                                    
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WCAR_Activity1Record)), WCAR_Activity1Record())
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
                    For Each rc As WCAR_Activity1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WCAR_Activity1Record)), WCAR_Activity1Record())
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
            ByVal pageSize As Integer) As WCAR_Activity1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Activity1Table.Column1, True)         
            ' selCols.Add(WCAR_Activity1Table.Column2, True)          
            ' selCols.Add(WCAR_Activity1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WCAR_Activity1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WCAR_Activity1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WCAR_Activity1Record)), WCAR_Activity1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCAR_Activity1Table.Column1, True)         
            ' selCols.Add(WCAR_Activity1Table.Column2, True)          
            ' selCols.Add(WCAR_Activity1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WCAR_Activity1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WCAR_Activity1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WCAR_Activity1TableControlRow = DirectCast(repItem.FindControl("WCAR_Activity1TableControlRow"), WCAR_Activity1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                
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
          
            Me.Page.PregetDfkaRecords(WCAR_Activity1Table.WCA_W_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_Activity1Table.WCA_W_U_ID_Delegate, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_Activity1Table.WCA_WCD_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_Activity1Table.WCA_WDT_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_Activity1Table.WCA_WS_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WCAR_Activity1Table.WCA_WSD_ID, Me.DataSource)
          
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
                    
                Me.Pagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination.CurrentPage.Text = "0"
            End If
            Me.Pagination.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for WCAR_Activity1TableControl pagination.
        
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
            
            Dim recCtl As WCAR_Activity1TableControlRow
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
            WCAR_Activity1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersWCAR_Activity1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WCAR_Activity1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersWCAR_Activity1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCAR_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WCAR_Activity1TableControlRow = DirectCast(repItem.FindControl("WCAR_Activity1TableControlRow"), WCAR_Activity1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WCAR_Activity1Record = New WCAR_Activity1Record()
        
                        If recControl.WCA_Date_Action.Text <> "" Then
                            rec.Parse(recControl.WCA_Date_Action.Text, WCAR_Activity1Table.WCA_Date_Action)
                        End If
                        If recControl.WCA_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.WCA_Date_Assign.Text, WCAR_Activity1Table.WCA_Date_Assign)
                        End If
                        rec.WCA_Is_Done = recControl.WCA_Is_Done.Checked
                
                        If recControl.WCA_Remark.Text <> "" Then
                            rec.Parse(recControl.WCA_Remark.Text, WCAR_Activity1Table.WCA_Remark)
                        End If
                        If recControl.WCA_Status.Text <> "" Then
                            rec.Parse(recControl.WCA_Status.Text, WCAR_Activity1Table.WCA_Status)
                        End If
                        If MiscUtils.IsValueSelected(recControl.WCA_W_U_ID) Then
                            rec.Parse(recControl.WCA_W_U_ID.SelectedItem.Value, WCAR_Activity1Table.WCA_W_U_ID)
                        End If
                        If MiscUtils.IsValueSelected(recControl.WCA_W_U_ID_Delegate) Then
                            rec.Parse(recControl.WCA_W_U_ID_Delegate.SelectedItem.Value, WCAR_Activity1Table.WCA_W_U_ID_Delegate)
                        End If
                        If MiscUtils.IsValueSelected(recControl.WCA_WCD_ID) Then
                            rec.Parse(recControl.WCA_WCD_ID.SelectedItem.Value, WCAR_Activity1Table.WCA_WCD_ID)
                        End If
                        If MiscUtils.IsValueSelected(recControl.WCA_WDT_ID) Then
                            rec.Parse(recControl.WCA_WDT_ID.SelectedItem.Value, WCAR_Activity1Table.WCA_WDT_ID)
                        End If
                        If MiscUtils.IsValueSelected(recControl.WCA_WS_ID) Then
                            rec.Parse(recControl.WCA_WS_ID.SelectedItem.Value, WCAR_Activity1Table.WCA_WS_ID)
                        End If
                        If MiscUtils.IsValueSelected(recControl.WCA_WSD_ID) Then
                            rec.Parse(recControl.WCA_WSD_ID.SelectedItem.Value, WCAR_Activity1Table.WCA_WSD_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WCAR_Activity1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WCAR_Activity1Record)), WCAR_Activity1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WCAR_Activity1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WCAR_Activity1TableControlRow) As Boolean
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
        

    
    
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
                Me.RegisterPostback()
                
                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                  
                
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Dim added As Boolean = Me.AddNewRecord > 0
                    Me.LoadData()
                    Me.DataBind()
                    
                    If added Then
                        Me.SetFocusToAddedRow()
                    End If
                    
                End If
                
               
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        'this function sets focus to the first editable element in the new added row in the editable table	
        Protected Overridable Sub SetFocusToAddedRow()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("WCAR_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
                Dim recControl As WCAR_Activity1TableControlRow = DirectCast(repItem.FindControl("WCAR_Activity1TableControlRow"), WCAR_Activity1TableControlRow)
                If recControl.IsNewRecord Then
                    For Each field As Control In recControl.Controls
                        If field.Visible AndAlso Me.Page.IsControlEditable(field, False) Then
                            'set focus on the first editable field in the new row
                            field.Focus()
                            Dim updPan As UpdatePanel = DirectCast(Me.Page.FindControlRecursively("UpdatePanel1"), UpdatePanel)
                            If Not updPan Is Nothing Then updPan.Update()
                            Return
                        End If
                    Next
                    Return
                End If
            Next
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

            Dim orderByStr As String = CType(ViewState("WCAR_Activity1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WCAR_Activity1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
                

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
        
      

        ' Generate the event handling functions for filter and search events.
        
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
                    _TotalRecords = WCAR_Activity1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WCAR_Activity1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WCAR_Activity1Record())
            End Get
            Set(ByVal value() As WCAR_Activity1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Pagination() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination"), ePortalWFApproval.UI.IPaginationModern)
          End Get
          End Property
        
        Public ReadOnly Property Title0() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title0"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ToggleAll"), System.Web.UI.WebControls.CheckBox)
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
                Dim recCtl As WCAR_Activity1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Activity1Record = Nothing     
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
                Dim recCtl As WCAR_Activity1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCAR_Activity1Record = Nothing     
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
            Dim recControl As WCAR_Activity1TableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.SelectRow.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As WCAR_Activity1TableControlRow
            Dim selectedList() As WCAR_Activity1TableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WCAR_Activity1TableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As WCAR_Activity1TableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.SelectRow IsNot Nothing AndAlso recControl.SelectRow.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(WCAR_Activity1TableControlRow)), WCAR_Activity1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WCAR_Activity1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WCAR_Activity1TableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.SelectRow.Checked = False
                
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

        Public Overridable Function GetRecordControls() As WCAR_Activity1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WCAR_Activity1TableControlRow")
            Dim list As New List(Of WCAR_Activity1TableControlRow)
            For Each recCtrl As WCAR_Activity1TableControlRow In recCtrls
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

  