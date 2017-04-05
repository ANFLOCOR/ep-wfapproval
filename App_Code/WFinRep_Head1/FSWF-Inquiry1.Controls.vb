
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' FSWF_Inquiry1.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.FSWF_Inquiry1

#Region "Section 1: Place your customizations here."

    
Public Class WFinRep_Activity1TableControlRow
        Inherits BaseWFinRep_Activity1TableControlRow
        ' The BaseWFinRep_Activity1TableControlRow implements code for a ROW within the
        ' the WFinRep_Activity1TableControl table.  The BaseWFinRep_Activity1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_Activity1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WFinRep_Activity1TableControl
        Inherits BaseWFinRep_Activity1TableControl

    ' The BaseWFinRep_Activity1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRep_Activity1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class WFinRep_Head1TableControlRow
        Inherits BaseWFinRep_Head1TableControlRow
        ' The BaseWFinRep_Head1TableControlRow implements code for a ROW within the
        ' the WFinRep_Head1TableControl table.  The BaseWFinRep_Head1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_Head1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class WFinRep_Head1TableControl
        Inherits BaseWFinRep_Head1TableControl

    ' The BaseWFinRep_Head1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRep_Head1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


		Public Overrides Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
            ' You can add your own sort order, or modify it on the Query Wizard. 
            Dim obC As OrderBy = New OrderBy(False, False)
            obC.Add(WFinRep_Head1Table.HFIN_Year, OrderByItem.OrderDir.Desc)
            obC.Add(WFinRep_Head1Table.HFIN_Month, OrderByItem.OrderDir.Asc)
            Return obC
        End Function

        Public Overrides Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            WFinRep_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.


            If IsValueSelected(Me.HFIN_C_IDFilter1) Then

                wc.iAND(WFinRep_Head1Table.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_C_IDFilter1, Me.GetFromSession(Me.HFIN_C_IDFilter1)), False, False)

            End If



            If IsValueSelected(Me.HFIN_MonthFilter1) Then

                wc.iAND(WFinRep_Head1Table.HFIN_Month, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_MonthFilter1, Me.GetFromSession(Me.HFIN_MonthFilter1)), False, False)

            End If



            If IsValueSelected(Me.HFIN_StatusFilter2) Then

                wc.iAND(WFinRep_Head1Table.HFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_StatusFilter2, Me.GetFromSession(Me.HFIN_StatusFilter2)), False, False)

            End If



            If IsValueSelected(Me.HFIN_YearFromFilter1) Then

                wc.iAND(WFinRep_Head1Table.HFIN_Year, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(Me.HFIN_YearFromFilter1, Me.GetFromSession(Me.HFIN_YearFromFilter1)), False, False)

            End If

            wc.iand("HFIN_C_ID in (SELECT Company_ID FROM sel_W_User_DYNAMICS_Company_WASP where W_U_User_Name = '" & DirectCast(Me.Page, BaseApplicationPage).CurrentSecurity.GetUserStatus().ToString() & "')")


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
                Dim fvalue As String = WFinRep_Head1Table.HFIN_C_ID.Format(selectedValue)
                Dim item As ListItem = New ListItem(fvalue, selectedValue)
                item.Selected = True
                Me.HFIN_C_IDFilter1.Items.Insert(0, item)
            End If
        End Sub

        Protected Overrides Sub PopulateHFIN_StatusFilter2(ByVal selectedValue As String, ByVal maxItems As Integer)


            Me.HFIN_StatusFilter2.Items.Clear()



            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_StatusFilter2 function.
            ' It is better to customize the where clause there.



            'Setup the WHERE clause.
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_StatusFilter2()
            wc.iAND(WFin_ApprovalStatus1Table.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "0")
            wc.iOR(WFin_ApprovalStatus1Table.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "4")
            wc.iOR(WFin_ApprovalStatus1Table.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "6")
            wc.iOR(WFin_ApprovalStatus1Table.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "7")
            wc.iOR(WFin_ApprovalStatus1Table.WPO_STAT_CD, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, "9")
            ' Setup the static list items        

            Me.HFIN_StatusFilter2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:All}"), "--ANY--"))


            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(WFin_ApprovalStatus1Table.WPO_STAT_DESC, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)



            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "EPORTAL")


            Dim itemValues() As WFin_ApprovalStatus1Record = Nothing

            If wc.RunQuery Then
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()



                Do

                    itemValues = WFin_ApprovalStatus1Table.GetRecords(wc, orderBy, pageNum, maxItems)

                    For Each itemValue As WFin_ApprovalStatus1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WPO_STAT_CDSpecified Then
                            cvalue = itemValue.WPO_STAT_CD.ToString()

                            If counter < maxItems AndAlso Me.HFIN_StatusFilter2.Items.FindByValue(cvalue) Is Nothing Then

                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Status)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Status.IsApplyDisplayAs Then
                                    fvalue = WFinRep_Head1Table.GetDFKA(itemValue, WFinRep_Head1Table.HFIN_Status)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(WFin_ApprovalStatus1Table.WPO_STAT_CD)
                                End If

                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                    fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If (fvalue.Length > 50) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.HFIN_StatusFilter2.Items.FindByText(fvalue)

                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length, 38)) & ")"
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_StatusFilter2.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length, 38)) & ")"
                                End If

                                counter += 1
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If






            ' Set the selected value.
            SetSelectedValue(Me.HFIN_StatusFilter2, selectedValue)


        End Sub
End Class

  

Public Class WFinRep_DocAttach1TableControl
        Inherits BaseWFinRep_DocAttach1TableControl

    ' The BaseWFinRep_DocAttach1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The WFinRep_DocAttach1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class
Public Class WFinRep_DocAttach1TableControlRow
        Inherits BaseWFinRep_DocAttach1TableControlRow
        ' The BaseWFinRep_DocAttach1TableControlRow implements code for a ROW within the
        ' the WFinRep_DocAttach1TableControl table.  The BaseWFinRep_DocAttach1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WFinRep_DocAttach1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class
Public Class Vw_FS_WFinRep_Attachment_PerReportType1TableControl
        Inherits BaseVw_FS_WFinRep_Attachment_PerReportType1TableControl

    ' The BaseVw_FS_WFinRep_Attachment_PerReportType1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class
Public Class Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow
        Inherits BaseVw_FS_WFinRep_Attachment_PerReportType1TableControlRow
        ' The BaseVw_FS_WFinRep_Attachment_PerReportType1TableControlRow implements code for a ROW within the
        ' the Vw_FS_WFinRep_Attachment_PerReportType1TableControl table.  The BaseVw_FS_WFinRep_Attachment_PerReportType1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Vw_FS_WFinRep_Attachment_PerReportType1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class
#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow control on the FSWF_Inquiry1 page.
' Do not modify this class. Instead override any method in Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow.
Public Class BaseVw_FS_WFinRep_Attachment_PerReportType1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseVw_FS_WFinRep_Attachment_PerReportType1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Vw_FS_WFinRep_Attachment_PerReportType1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow.
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
        
                SetWFRA_Desc()
                SetWFRA_DescLabel()
                SetWFRA_FIN_ID()
                SetWFRA_FIN_IDLabel()
                SetWFRA_ID()
                SetWFRA_IDLabel()
                SetWFRT_Description()
                SetWFRT_DescriptionLabel()
                SetWFRT_SortOrder()
                SetWFRT_SortOrderLabel()
      
      
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
        
        
        Public Overridable Sub SetWFRA_Desc()

                  
            
        
            ' Set the WFRA_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRA_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRA_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRA_DescSpecified Then
                				
                ' If the WFRA_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRA_Desc.Text = formattedValue
                
            Else 
            
                ' WFRA_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRA_Desc.Text = Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc.DefaultValue)
                        		
                End If
                 
            ' If the WFRA_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRA_Desc.Text Is Nothing _
                OrElse Me.WFRA_Desc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRA_Desc.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRA_FIN_ID()

                  
            
        
            ' Set the WFRA_FIN_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRA_FIN_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRA_FIN_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRA_FIN_IDSpecified Then
                				
                ' If the WFRA_FIN_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRA_FIN_ID.Text = formattedValue
                
            Else 
            
                ' WFRA_FIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRA_FIN_ID.Text = Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID.DefaultValue)
                        		
                End If
                 
            ' If the WFRA_FIN_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRA_FIN_ID.Text Is Nothing _
                OrElse Me.WFRA_FIN_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRA_FIN_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRA_ID()

                  
            
        
            ' Set the WFRA_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRA_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRA_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRA_IDSpecified Then
                				
                ' If the WFRA_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRA_ID.Text = formattedValue
                
            Else 
            
                ' WFRA_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRA_ID.Text = Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID.DefaultValue)
                        		
                End If
                 
            ' If the WFRA_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRA_ID.Text Is Nothing _
                OrElse Me.WFRA_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRA_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRT_Description()

                  
            
        
            ' Set the WFRT_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRT_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRT_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRT_DescriptionSpecified Then
                				
                ' If the WFRT_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.Vw_FS_WFinRep_Attachment_PerReportType1View, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""WFRT_Description\"", \""WFRT_Description\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
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
                
                Me.WFRT_Description.Text = formattedValue
                
            Else 
            
                ' WFRT_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRT_Description.Text = Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.DefaultValue)
                        		
                End If
                 
            ' If the WFRT_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRT_Description.Text Is Nothing _
                OrElse Me.WFRT_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRT_Description.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRT_SortOrder()

                  
            
        
            ' Set the WFRT_SortOrder Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.vw_FS_WFinRep_Attachment_PerReportType record retrieved from the database.
            ' Me.WFRT_SortOrder is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWFRT_SortOrder()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WFRT_SortOrderSpecified Then
                				
                ' If the WFRT_SortOrder is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WFRT_SortOrder.Text = formattedValue
                
            Else 
            
                ' WFRT_SortOrder is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WFRT_SortOrder.Text = Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder.DefaultValue)
                        		
                End If
                 
            ' If the WFRT_SortOrder is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WFRT_SortOrder.Text Is Nothing _
                OrElse Me.WFRT_SortOrder.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WFRT_SortOrder.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWFRA_DescLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWFRA_FIN_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWFRA_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWFRT_DescriptionLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWFRT_SortOrderLabel()

                  
                  
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

      
        
        ' To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow.
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
        
        Dim parentCtrl As WFinRep_Head1TableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_Head1TableControlRow"), WFinRep_Head1TableControlRow)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.FIN_HFIN_ID = parentCtrl.DataSource.HFIN_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControl"), Vw_FS_WFinRep_Attachment_PerReportType1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControl"), Vw_FS_WFinRep_Attachment_PerReportType1TableControl).ResetData = True
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

        ' To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWFRA_Desc()
            GetWFRA_FIN_ID()
            GetWFRA_ID()
            GetWFRT_Description()
            GetWFRT_SortOrder()
        End Sub
        
        
        Public Overridable Sub GetWFRA_Desc()
            
        End Sub
                
        Public Overridable Sub GetWFRA_FIN_ID()
            
        End Sub
                
        Public Overridable Sub GetWFRA_ID()
            
        End Sub
                
        Public Overridable Sub GetWFRT_Description()
            
        End Sub
                
        Public Overridable Sub GetWFRT_SortOrder()
            
        End Sub
                
      
        ' To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow.
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
          Vw_FS_WFinRep_Attachment_PerReportType1View.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControl"), Vw_FS_WFinRep_Attachment_PerReportType1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControl"), Vw_FS_WFinRep_Attachment_PerReportType1TableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseVw_FS_WFinRep_Attachment_PerReportType1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseVw_FS_WFinRep_Attachment_PerReportType1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As Vw_FS_WFinRep_Attachment_PerReportType1Record
            Get
                Return DirectCast(MyBase._DataSource, Vw_FS_WFinRep_Attachment_PerReportType1Record)
            End Get
            Set(ByVal value As Vw_FS_WFinRep_Attachment_PerReportType1Record)
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
        
        Public ReadOnly Property WFRA_Desc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_Desc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRA_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRA_FIN_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_FIN_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRA_FIN_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_FIN_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRA_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRA_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRT_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRT_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRT_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRT_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFRT_SortOrder() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRT_SortOrder"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WFRT_SortOrderLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRT_SortOrderLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing
             
        
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
            
            Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Vw_FS_WFinRep_Attachment_PerReportType1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Vw_FS_WFinRep_Attachment_PerReportType1TableControl control on the FSWF_Inquiry1 page.
' Do not modify this class. Instead override any method in Vw_FS_WFinRep_Attachment_PerReportType1TableControl.
Public Class BaseVw_FS_WFinRep_Attachment_PerReportType1TableControl
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
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText) 				
                    initialVal = Me.GetFromSession(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText)
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WFRA_DescFilter1) 				
                    initialVal = Me.GetFromSession(Me.WFRA_DescFilter1)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""WFRA_Desc"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Dim WFRA_DescFilter1itemListFromSession() As String = initialVal.Split(","c)
                        Dim index As Integer = 0
                        For Each item As String In WFRA_DescFilter1itemListFromSession
                            If index = 0 AndAlso _
                               item.ToString.Equals("") Then
                            Else
                                Me.WFRA_DescFilter1.Items.Add(item)
                                Me.WFRA_DescFilter1.Items.Item(index).Selected = True
                                index += 1
                            End If
                        Next
                        Dim listItem As ListItem
                        For Each listItem In Me.WFRA_DescFilter1.Items
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
            
              AddHandler Me.Pagination3.FirstPage.Click, AddressOf Pagination3_FirstPage_Click
                        
              AddHandler Me.Pagination3.LastPage.Click, AddressOf Pagination3_LastPage_Click
                        
              AddHandler Me.Pagination3.NextPage.Click, AddressOf Pagination3_NextPage_Click
                        
              AddHandler Me.Pagination3.PageSizeButton.Click, AddressOf Pagination3_PageSizeButton_Click
                        
              AddHandler Me.Pagination3.PreviousPage.Click, AddressOf Pagination3_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.ExcelButton1.Click, AddressOf ExcelButton1_Click
                        
              AddHandler Me.PDFButton1.Click, AddressOf PDFButton1_Click
                        
              AddHandler Me.ResetButton1.Click, AddressOf ResetButton1_Click
                        
              AddHandler Me.SearchButton3.Click, AddressOf SearchButton3_Click
                        
              AddHandler Me.WordButton1.Click, AddressOf WordButton1_Click
                        
              AddHandler Me.Actions3Button.Button.Click, AddressOf Actions3Button_Click
                        
              AddHandler Me.FilterButton2.Button.Click, AddressOf FilterButton2_Click
                        
              AddHandler Me.Filters3Button.Button.Click, AddressOf Filters3Button_Click
                        
            AddHandler Me.SortControl3.SelectedIndexChanged, AddressOf SortControl3_SelectedIndexChanged
              AddHandler Me.WFRA_DescFilter1.SelectedIndexChanged, AddressOf WFRA_DescFilter1_SelectedIndexChanged                  
                        
        
          ' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "Vw_FS_WFinRep_Attachment_PerReportType1SearchTextSearchBoxText", "setSearchBoxText(""" & BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) & """, """ & Vw_FS_WFinRep_Attachment_PerReportType1SearchText.ClientID & """);", True)                  
            
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1Record)), Vw_FS_WFinRep_Attachment_PerReportType1Record())
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
                    For Each rc As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1Record)), Vw_FS_WFinRep_Attachment_PerReportType1Record())
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
            ByVal pageSize As Integer) As Vw_FS_WFinRep_Attachment_PerReportType1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column1, True)         
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column2, True)          
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New Vw_FS_WFinRep_Attachment_PerReportType1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1Record)), Vw_FS_WFinRep_Attachment_PerReportType1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column1, True)         
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column2, True)          
            ' selCols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Vw_FS_WFinRep_Attachment_PerReportType1View
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow = DirectCast(repItem.FindControl("Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow"), Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow)
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
                
                SetVw_FS_WFinRep_Attachment_PerReportType1SearchText()
                SetWFRA_DescFilter1()
                SetWFRA_DescLabel2()
                
                SetExcelButton1()
              
                SetPDFButton1()
              
                SetResetButton1()
              
                SetSearchButton3()
              
                SetWordButton1()
              
                SetActions3Button()
              
                SetFilterButton2()
              
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

    
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"ExcelButton1"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"PDFButton1"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"WordButton1"))
                        
        
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

            ' Bind the buttons for Vw_FS_WFinRep_Attachment_PerReportType1TableControl pagination.
        
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
            
            Dim recCtl As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow
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
            Vw_FS_WFinRep_Attachment_PerReportType1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRep_Head1RecordObj as KeyValue
        wFinRep_Head1RecordObj = Nothing
      
              Dim wFinRep_Head1TableControlObjRow As WFinRep_Head1TableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_Head1TableControlRow") ,WFinRep_Head1TableControlRow)
            
                If (Not IsNothing(wFinRep_Head1TableControlObjRow) AndAlso Not IsNothing(wFinRep_Head1TableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRep_Head1TableControlObjRow.GetRecord().HFIN_ID))
                    wc.iAND(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_Head1TableControlObjRow.GetRecord().HFIN_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If
              
      HttpContext.Current.Session("Vw_FS_WFinRep_Attachment_PerReportType1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            If IsValueSelected(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText) Then
              If Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text = BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) Then
                 Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text = ""
              Else
              ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
              
                If Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.StartsWith(BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing)) Then
                Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text = ""
                Else
              
                    If Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.StartsWith("...") Then
                        Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text = Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.SubString(3,Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.Length-3)
                    End If
                    If Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.EndsWith("...") then
                        Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text = Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.SubString(0,Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.Length-3)
                        ' Strip the last word as well as it is likely only a partial word
                        Dim endindex As Integer = Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.Length - 1
                        While (Not Char.IsWhiteSpace(Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text(endindex)) AndAlso endindex > 0)
                            endindex -= 1
                        End While
                        If endindex > 0 Then
                            Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text = Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text.Substring(0, endindex)
                        End If
              End If
            End If
            
              End If
            
              Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText, Me.GetFromSession(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    Dim search As WhereClause = New WhereClause()
                    
      Dim cols As New ColumnList    
        
      cols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description, True)
      
      For Each col As BaseColumn in cols
      
                    search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText, Me.GetFromSession(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText)), True, False)
        
      Next
    
                    wc.iAND(search)
                End If
            End If
                  

                  Dim totalSelectedItemCount as Integer = 0
                  
            If IsValueSelected(Me.WFRA_DescFilter1) Then
    
              hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl = True            
    
                Dim item As ListItem
                Dim selectedItemCount As Integer = 0
                For Each item In Me.WFRA_DescFilter1.Items
                    If item.Selected Then
                        selectedItemCount += 1
                        
                          totalSelectedItemCount += 1
                        
                    End If
                Next
                
                Dim filter As WhereClause = New WhereClause
                For Each item In Me.WFRA_DescFilter1.Items
                    If item.Selected AndAlso (item.Value = "--ANY--" OrElse item.Value = "--PLEASE_SELECT--") AndAlso selectedItemCount > 1 Then
                        item.Selected = False
                    End If
                    If item.Selected Then
                        filter.iOR(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc, BaseFilter.ComparisonOperator.EqualsTo, item.Value, False, False)
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
            Vw_FS_WFinRep_Attachment_PerReportType1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRep_Head1TableControl as String = DirectCast(HttpContext.Current.Session("Vw_FS_WFinRep_Attachment_PerReportType1TableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRep_Head1TableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRep_Head1TableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRep_Head1TableControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID) Then
            wc.iAND(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Vw_FS_WFinRep_Attachment_PerReportType1View.FIN_HFIN_ID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            If IsValueSelected(searchText) and fromSearchControl = "Vw_FS_WFinRep_Attachment_PerReportType1SearchText" Then
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
        
      cols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
      Next
    
                    Else
                        
      Dim cols As New ColumnList    
        
      cols.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
      Next
    
                    End If
                    wc.iAND(search)
                End If
            End If
                  
            Dim WFRA_DescFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WFRA_DescFilter1_Ajax"), String)
            If IsValueSelected(WFRA_DescFilter1SelectedValue) Then
    
              hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl = True            
    
            If Not isNothing(WFRA_DescFilter1SelectedValue) Then
                Dim WFRA_DescFilter1itemListFromSession() As String = WFRA_DescFilter1SelectedValue.Split(","c)
                Dim index As Integer = 0
                  
                Dim filter As WhereClause = New WhereClause
                For Each item As String In WFRA_DescFilter1itemListFromSession
                    If index = 0 AndAlso item.ToString.Equals("") Then
                    Else
                        filter.iOR(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc, BaseFilter.ComparisonOperator.EqualsTo, item, False, False)
                        index += 1
                    End If
                Next
                wc.iAND(filter)
                
             End If
                
             End If
                      
      
      
            Return wc
        End Function

      
        Public Overridable Function GetAutoCompletionList_Vw_FS_WFinRep_Attachment_PerReportType1SearchText(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            
            Dim filterJoin As CompoundFilter = CreateCompoundJoinFilter()
            If count = 0 Then count = 10
            Dim wc As WhereClause = CreateWhereClause(prefixText,"Vw_FS_WFinRep_Attachment_PerReportType1SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            Dim recordList () As ePortalWFApproval.Business.Vw_FS_WFinRep_Attachment_PerReportType1Record = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecords(filterJoin, wc, Nothing, 0, count,count)
            Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing
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
        
                resultItem = rec.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description)
                If resultItem IsNot Nothing Then
                    Dim prText As String = prefixText
                    If Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.IsFullTextSearchable Then
                         Dim ft As FullTextExpression = New FullTextExpression()
                         prText = ft.GetFirstNonExcludedTerm(prText)
                    End If
                    If Not String.IsNullOrEmpty(prText) AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
  
                        Dim isAdded As Boolean = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.IsFullTextSearchable)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow = DirectCast(repItem.FindControl("Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow"), Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = New Vw_FS_WFinRep_Attachment_PerReportType1Record()
        
                        If recControl.WFRA_Desc.Text <> "" Then
                            rec.Parse(recControl.WFRA_Desc.Text, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc)
                        End If
                        If recControl.WFRA_FIN_ID.Text <> "" Then
                            rec.Parse(recControl.WFRA_FIN_ID.Text, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID)
                        End If
                        If recControl.WFRA_ID.Text <> "" Then
                            rec.Parse(recControl.WFRA_ID.Text, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID)
                        End If
                        If recControl.WFRT_Description.Text <> "" Then
                            rec.Parse(recControl.WFRT_Description.Text, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description)
                        End If
                        If recControl.WFRT_SortOrder.Text <> "" Then
                            rec.Parse(recControl.WFRT_SortOrder.Text, Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New Vw_FS_WFinRep_Attachment_PerReportType1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1Record)), Vw_FS_WFinRep_Attachment_PerReportType1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow) As Boolean
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
                
        Public Overridable Sub SetWFRA_DescLabel2()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortControl3()

              
            
                Me.PopulateSortControl3(GetSelectedValue(Me.SortControl3,  GetFromSession(Me.SortControl3)), 500)					
                    
        End Sub
            
        Public Overridable Sub SetVw_FS_WFinRep_Attachment_PerReportType1SearchText()

              
                                            
          Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "') {this.value='';this.className='Search_Input';}")
          Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "';this.className='Search_InputHint';}")
                                   
              End Sub	
            
        Public Overridable Sub SetWFRA_DescFilter1()

              
            
            Dim WFRA_DescFilter1selectedFilterItemList As New ArrayList()
            Dim WFRA_DescFilter1itemsString As String = Nothing
            If (Me.InSession(Me.WFRA_DescFilter1)) Then
                WFRA_DescFilter1itemsString = Me.GetFromSession(Me.WFRA_DescFilter1)
            End If
            
            If (WFRA_DescFilter1itemsString IsNot Nothing) Then
                Dim WFRA_DescFilter1itemListFromSession() As String = WFRA_DescFilter1itemsString.Split(","c)
                For Each item as String In WFRA_DescFilter1itemListFromSession
                    WFRA_DescFilter1selectedFilterItemList.Add(item)
                Next
            End If
              
            		
            Me.PopulateWFRA_DescFilter1(GetSelectedValueList(Me.WFRA_DescFilter1, WFRA_DescFilter1selectedFilterItemList), 500)
                    
              Dim url as String = Me.ModifyRedirectUrl("../vw_FS_WFinRep_Attachment_PerReportType1/Vw-FS-WFinRep-Attachment-PerReportType-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WFRA_DescFilter1.ClientID & "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WFRA_Desc")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--ANY--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:All")) & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WFRA_DescFilter1.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WFRA_DescFilter1.AutoPostBack).ToLower() & ", event); return false;"        
                  
                                 
              End Sub	
            
        ' Get the filters' data for SortControl3
        Protected Overridable Sub PopulateSortControl3(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl3.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WFRA Description {Txt:Ascending}"), "WFRA_Desc Asc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WFRA Description {Txt:Descending}"), "WFRA_Desc Desc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wfra Fin {Txt:Ascending}"), "WFRA_FIN_ID Asc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wfra Fin {Txt:Descending}"), "WFRA_FIN_ID Desc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wfra {Txt:Ascending}"), "WFRA_ID Asc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wfra {Txt:Descending}"), "WFRA_ID Desc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WFRT Description {Txt:Ascending}"), "WFRT_Description Asc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WFRT Description {Txt:Descending}"), "WFRT_Description Desc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WFRT Sort Order {Txt:Ascending}"), "WFRT_SortOrder Asc"))
                            							
            Me.SortControl3.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WFRT Sort Order {Txt:Descending}"), "WFRT_SortOrder Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl3, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl3.SelectedValue IsNot Nothing AndAlso Me.SortControl3.Items.FindByValue(Me.SortControl3.SelectedValue) Is Nothing
                Me.SortControl3.SelectedValue = Nothing
            End If

              End Sub
            
        ' Get the filters' data for WFRA_DescFilter1
        Protected Overridable Sub PopulateWFRA_DescFilter1(ByVal selectedValue As ArrayList, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Dim wc As WhereClause = Me.CreateWhereClause_WFRA_DescFilter1()
            Me.WFRA_DescFilter1.Items.Clear()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WFRA_DescFilter1 function.
            ' It is better to customize the where clause there.
            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = Vw_FS_WFinRep_Attachment_PerReportType1View.GetValues(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.WFRA_DescFilter1.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.WFRA_DescFilter1.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
            Catch
            End Try
            
            
            Me.WFRA_DescFilter1.SetFieldMaxLength(50)
                                 
                  
            ' Add the selected value.
            If Me.WFRA_DescFilter1.Items.Count = 0 Then
                Me.WFRA_DescFilter1.Items.Add(New ListItem(Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
            End If
            
            ' Mark all items to be selected.
            For Each item As ListItem in Me.WFRA_DescFilter1.Items
                item.Selected = True
            Next
                              
        End Sub
            
              

        Public Overridable Function CreateWhereClause_WFRA_DescFilter1() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
            
            ' Create a where clause for the filter WFRA_DescFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the WFRA_DescFilter1QuickSelector
            
            Dim WFRA_DescFilter1selectedFilterItemList As New ArrayList()
            Dim WFRA_DescFilter1itemsString As String = Nothing
            If (Me.InSession(Me.WFRA_DescFilter1)) Then
                WFRA_DescFilter1itemsString = Me.GetFromSession(Me.WFRA_DescFilter1)
            End If
            
            If (WFRA_DescFilter1itemsString IsNot Nothing) Then
                Dim WFRA_DescFilter1itemListFromSession() As String = WFRA_DescFilter1itemsString.Split(","c)
                For Each item as String In WFRA_DescFilter1itemListFromSession
                    WFRA_DescFilter1selectedFilterItemList.Add(item)
                Next
            End If
              
            WFRA_DescFilter1selectedFilterItemList = GetSelectedValueList(Me.WFRA_DescFilter1, WFRA_DescFilter1selectedFilterItemList) 
            Dim wc As New WhereClause
            If WFRA_DescFilter1selectedFilterItemList Is Nothing OrElse WFRA_DescFilter1selectedFilterItemList.Count = 0 Then
                wc.RunQuery = False
            Else            
                For Each item As String In WFRA_DescFilter1selectedFilterItemList
              
            
      
   
                    wc.iOR(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc, BaseFilter.ComparisonOperator.EqualsTo, item)

                                
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
        
            Me.SaveToSession(Me.SortControl3, Me.SortControl3.SelectedValue)
                  
            Me.SaveToSession(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText, Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text)
                  
            Dim WFRA_DescFilter1selectedFilterItemList As ArrayList = GetSelectedValueList(Me.WFRA_DescFilter1, Nothing)
            Dim WFRA_DescFilter1SessionString As String = ""
            If Not WFRA_DescFilter1selectedFilterItemList is Nothing Then
            For Each item As String In WFRA_DescFilter1selectedFilterItemList
                WFRA_DescFilter1Sessionstring = WFRA_DescFilter1Sessionstring & "," & item
            Next
            End If
            Me.SaveToSession(Me.WFRA_DescFilter1, WFRA_DescFilter1Sessionstring)
                  
        
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
                  
      Me.SaveToSession("Vw_FS_WFinRep_Attachment_PerReportType1SearchText_Ajax", Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text)
              
            Dim WFRA_DescFilter1selectedFilterItemList As ArrayList = GetSelectedValueList(Me.WFRA_DescFilter1, Nothing)
            Dim WFRA_DescFilter1SessionString As String = ""
            If Not WFRA_DescFilter1selectedFilterItemList is Nothing Then
            For Each item As String In WFRA_DescFilter1selectedFilterItemList
                WFRA_DescFilter1Sessionstring = WFRA_DescFilter1Sessionstring & "," & item
            Next
            End If
            Me.SaveToSession("WFRA_DescFilter1_Ajax", WFRA_DescFilter1SessionString)
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl3)
            Me.RemoveFromSession(Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText)
            Me.RemoveFromSession(Me.WFRA_DescFilter1)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Vw_FS_WFinRep_Attachment_PerReportType1TableControl_OrderBy"), String)
          
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
                Me.ViewState("Vw_FS_WFinRep_Attachment_PerReportType1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetExcelButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetPDFButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetResetButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetSearchButton3()                
              
   
        End Sub
            
        Public Overridable Sub SetWordButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetActions3Button()                
              
   
        End Sub
            
        Public Overridable Sub SetFilterButton2()                
              
   
        End Sub
            
        Public Overridable Sub SetFilters3Button()                
                      
         Dim themeButtonFilters3Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters3Button"), IThemeButtonWithArrow)
         themeButtonFilters3Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
            If (IsValueSelected(WFRA_DescFilter1)) Then
                themeButtonFilters3Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png"
            End If
        
   
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
        
        ' event handler for ImageButton
        Public Overridable Sub ExcelButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
              Me.TotalRecords = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecordCount(join, wc)
              If Me.TotalRecords > 10000 Then
          
              ' Add each of the columns in order of export.
              Dim columns() as BaseColumn = New BaseColumn() { _
                         Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID, _ 
             Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID, _ 
             Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc, _ 
             Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description, _ 
             Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder, _ 
             Nothing}
              Dim  exportData as ExportDataToCSV = New ExportDataToCSV(Vw_FS_WFinRep_Attachment_PerReportType1View.Instance, wc, orderBy, columns)
              exportData.StartExport(Me.Page.Response, True)

              Dim dataForCSV As DataForExport = New DataForExport(Vw_FS_WFinRep_Attachment_PerReportType1View.Instance, wc, orderBy, columns, join)

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
              Dim excelReport As ExportDataToExcel = New ExportDataToExcel(Vw_FS_WFinRep_Attachment_PerReportType1View.Instance, wc, orderBy)
              ' Add each of the columns in order of export.
              ' To customize the data type, change the second parameter of the new ExcelColumn to be
              ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              If Me.Page.Response Is Nothing Then
                Return
              End If

              excelReport.CreateExcelBook()

              Dim width As Integer = 0
              Dim columnCounter As Integer = 0
              Dim data As DataForExport = New DataForExport(Vw_FS_WFinRep_Attachment_PerReportType1View.Instance, wc, orderBy, Nothing, join)
                       data.ColumnList.Add(New ExcelColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID, "0"))
             data.ColumnList.Add(New ExcelColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID, "0"))
             data.ColumnList.Add(New ExcelColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc, "Default"))
             data.ColumnList.Add(New ExcelColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description, "Default"))
             data.ColumnList.Add(New ExcelColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder, "0"))


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
                              val = Vw_FS_WFinRep_Attachment_PerReportType1View.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
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
        Public Overridable Sub PDFButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("FSWF-Inquiry1.PDFButton1.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_FS_WFinRep_Attachment_PerReportType"
                ' If FSWF-Inquiry1.PDFButton1.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID.Name, ReportEnum.Align.Right, "${WFRA_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID.Name, ReportEnum.Align.Right, "${WFRA_FIN_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc.Name, ReportEnum.Align.Left, "${WFRA_Desc}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.Name, ReportEnum.Align.Left, "${WFRT_Description}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder.Name, ReportEnum.Align.Right, "${WFRT_SortOrder}", ReportEnum.Align.Right, 15)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
                
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecordCount(joinFilter,whereClause)
                Dim columns As ColumnList = Vw_FS_WFinRep_Attachment_PerReportType1View.GetColumnList()
                Dim records As Vw_FS_WFinRep_Attachment_PerReportType1Record() = Nothing
            
                Do 
                    
                    records = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As Vw_FS_WFinRep_Attachment_PerReportType1Record In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${WFRA_ID}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${WFRA_FIN_ID}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${WFRA_Desc}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc), ReportEnum.Align.Left, 300)
                             report.AddData("${WFRT_Description}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description), ReportEnum.Align.Left, 300)
                             report.AddData("${WFRT_SortOrder}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder), ReportEnum.Align.Right, 300)

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
        Public Overridable Sub ResetButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
              Me.WFRA_DescFilter1.ClearSelection()
            Me.SortControl3.ClearSelection()
              Me.Vw_FS_WFinRep_Attachment_PerReportType1SearchText.Text = ""
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
        Public Overridable Sub SearchButton3_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub WordButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("FSWF-Inquiry1.WordButton1.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vw_FS_WFinRep_Attachment_PerReportType"
                ' If FSWF-Inquiry1.WordButton1.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID.Name, ReportEnum.Align.Right, "${WFRA_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID.Name, ReportEnum.Align.Right, "${WFRA_FIN_ID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc.Name, ReportEnum.Align.Left, "${WFRA_Desc}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description.Name, ReportEnum.Align.Left, "${WFRT_Description}", ReportEnum.Align.Left, 28)
                 report.AddColumn(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder.Name, ReportEnum.Align.Right, "${WFRT_SortOrder}", ReportEnum.Align.Right, 15)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecordCount(joinFilter,whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = Vw_FS_WFinRep_Attachment_PerReportType1View.GetColumnList()
                Dim records As Vw_FS_WFinRep_Attachment_PerReportType1Record() = Nothing
                Do
                    records = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As Vw_FS_WFinRep_Attachment_PerReportType1Record In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${WFRA_ID}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${WFRA_FIN_ID}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_FIN_ID), ReportEnum.Align.Right, 300)
                             report.AddData("${WFRA_Desc}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRA_Desc), ReportEnum.Align.Left, 300)
                             report.AddData("${WFRT_Description}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_Description), ReportEnum.Align.Left, 300)
                             report.AddData("${WFRT_SortOrder}", record.Format(Vw_FS_WFinRep_Attachment_PerReportType1View.WFRT_SortOrder), ReportEnum.Align.Right, 300)

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
        Public Overridable Sub Actions3Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Public Overridable Sub FilterButton2_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
                For Each ColumnNam As BaseClasses.Data.BaseColumn In Vw_FS_WFinRep_Attachment_PerReportType1View.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(Vw_FS_WFinRep_Attachment_PerReportType1View.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not Vw_FS_WFinRep_Attachment_PerReportType1View.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not Vw_FS_WFinRep_Attachment_PerReportType1View.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(Vw_FS_WFinRep_Attachment_PerReportType1View.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub WFRA_DescFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = Vw_FS_WFinRep_Attachment_PerReportType1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As Vw_FS_WFinRep_Attachment_PerReportType1Record ()
            Get
                Return DirectCast(MyBase._DataSource, Vw_FS_WFinRep_Attachment_PerReportType1Record())
            End Get
            Set(ByVal value() As Vw_FS_WFinRep_Attachment_PerReportType1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Actions3Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Actions3Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property ExcelButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExcelButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property FilterButton2() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FilterButton2"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
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
        
        Public ReadOnly Property PDFButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PDFButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property ResetButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ResetButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SearchButton3() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SearchButton3"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property Title2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Vw_FS_WFinRep_Attachment_PerReportType1SearchText() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportType1SearchText"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property WFRA_DescFilter1() As BaseClasses.Web.UI.WebControls.QuickSelector
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_DescFilter1"), BaseClasses.Web.UI.WebControls.QuickSelector)
            End Get
        End Property
        
        Public ReadOnly Property WFRA_DescLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFRA_DescLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WordButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WordButton1"), System.Web.UI.WebControls.ImageButton)
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
                Dim recCtl As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing     
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
                Dim recCtl As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As Vw_FS_WFinRep_Attachment_PerReportType1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow)), Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow
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

        Public Overridable Function GetRecordControls() As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow")
            Dim list As New List(Of Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow)
            For Each recCtrl As Vw_FS_WFinRep_Attachment_PerReportType1TableControlRow In recCtrls
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

  
' Base class for the WFinRep_Activity1TableControlRow control on the FSWF_Inquiry1 page.
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
        
                SetAFIN_Code()
                SetAFIN_CodeLabel()
                SetAFIN_Date_Action()
                SetAFIN_Date_ActionLabel()
                SetAFIN_Date_Assign()
                SetAFIN_Date_AssignLabel()
                SetAFIN_FinID()
                SetAFIN_FinIDLabel()
                SetAFIN_Is_Done()
                SetAFIN_Is_DoneLabel()
                SetAFIN_Remark()
                SetAFIN_RemarkLabel()
                SetAFIN_Status()
                SetAFIN_StatusLabel()
                SetAFIN_W_U_ID()
                SetAFIN_W_U_ID_Delegate()
                SetAFIN_W_U_ID_DelegateLabel()
                SetAFIN_W_U_IDLabel()
                SetAFIN_WDT_ID()
                SetAFIN_WDT_IDLabel()
                SetAFIN_WS_ID()
                SetAFIN_WS_IDLabel()
                SetAFIN_WSD_ID()
                SetAFIN_WSD_IDLabel()
      
      
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
        
        
        Public Overridable Sub SetAFIN_Code()

                  
            
        
            ' Set the AFIN_Code Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Code is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_CodeSpecified Then
                				
                ' If the AFIN_Code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Code)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Code.Text = formattedValue
                
            Else 
            
                ' AFIN_Code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Code.Text = WFinRep_Activity1Table.AFIN_Code.Format(WFinRep_Activity1Table.AFIN_Code.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_Code is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Code.Text Is Nothing _
                OrElse Me.AFIN_Code.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Code.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Date_Action()

                  
            
        
            ' Set the AFIN_Date_Action Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Date_Action is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Action()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_ActionSpecified Then
                				
                ' If the AFIN_Date_Action is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Date_Action, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Action.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Action is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Action.Text = WFinRep_Activity1Table.AFIN_Date_Action.Format(WFinRep_Activity1Table.AFIN_Date_Action.DefaultValue, "g")
                        		
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
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Date_Assign is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Date_Assign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Date_AssignSpecified Then
                				
                ' If the AFIN_Date_Assign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Date_Assign, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Date_Assign.Text = formattedValue
                
            Else 
            
                ' AFIN_Date_Assign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Date_Assign.Text = WFinRep_Activity1Table.AFIN_Date_Assign.Format(WFinRep_Activity1Table.AFIN_Date_Assign.DefaultValue, "g")
                        		
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
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_FinID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_FinID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_FinIDSpecified Then
                				
                ' If the AFIN_FinID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_FinID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_FinID.Text = formattedValue
                
            Else 
            
                ' AFIN_FinID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_FinID.Text = WFinRep_Activity1Table.AFIN_FinID.Format(WFinRep_Activity1Table.AFIN_FinID.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_FinID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_FinID.Text Is Nothing _
                OrElse Me.AFIN_FinID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_FinID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_Is_Done()

                  
            
        
            ' Set the AFIN_Is_Done Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Is_Done is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Is_Done()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_Is_DoneSpecified Then
                				
                ' If the AFIN_Is_Done is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_Is_Done)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_Is_Done.Text = formattedValue
                
            Else 
            
                ' AFIN_Is_Done is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Is_Done.Text = WFinRep_Activity1Table.AFIN_Is_Done.Format(WFinRep_Activity1Table.AFIN_Is_Done.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_Is_Done is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Is_Done.Text Is Nothing _
                OrElse Me.AFIN_Is_Done.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Is_Done.Text = "&nbsp;"
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
                
        Public Overridable Sub SetAFIN_Status()

                  
            
        
            ' Set the AFIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_Status()
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
                Me.AFIN_Status.Text = formattedValue
                
            Else 
            
                ' AFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_Status.Text = WFinRep_Activity1Table.AFIN_Status.Format(WFinRep_Activity1Table.AFIN_Status.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_Status.Text Is Nothing _
                OrElse Me.AFIN_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_Status.Text = "&nbsp;"
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
                
        Public Overridable Sub SetAFIN_W_U_ID_Delegate()

                  
            
        
            ' Set the AFIN_W_U_ID_Delegate Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_W_U_ID_Delegate is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_W_U_ID_Delegate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_W_U_ID_DelegateSpecified Then
                				
                ' If the AFIN_W_U_ID_Delegate is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Activity1Table.AFIN_W_U_ID_Delegate)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Activity1Table.AFIN_W_U_ID_Delegate.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Activity1Table.GetDFKA(Me.DataSource.AFIN_W_U_ID_Delegate.ToString(),WFinRep_Activity1Table.AFIN_W_U_ID_Delegate, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_W_U_ID_Delegate)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_W_U_ID_Delegate.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_W_U_ID_Delegate.Text = formattedValue
                
            Else 
            
                ' AFIN_W_U_ID_Delegate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_W_U_ID_Delegate.Text = WFinRep_Activity1Table.AFIN_W_U_ID_Delegate.Format(WFinRep_Activity1Table.AFIN_W_U_ID_Delegate.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_W_U_ID_Delegate is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_W_U_ID_Delegate.Text Is Nothing _
                OrElse Me.AFIN_W_U_ID_Delegate.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_W_U_ID_Delegate.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_WDT_ID()

                  
            
        
            ' Set the AFIN_WDT_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_WDT_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_WDT_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_WDT_IDSpecified Then
                				
                ' If the AFIN_WDT_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Activity1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Activity1Table.AFIN_WDT_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Activity1Table.AFIN_WDT_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Activity1Table.GetDFKA(Me.DataSource.AFIN_WDT_ID.ToString(),WFinRep_Activity1Table.AFIN_WDT_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_WDT_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.AFIN_WDT_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_WDT_ID.Text = formattedValue
                
            Else 
            
                ' AFIN_WDT_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_WDT_ID.Text = WFinRep_Activity1Table.AFIN_WDT_ID.Format(WFinRep_Activity1Table.AFIN_WDT_ID.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_WDT_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_WDT_ID.Text Is Nothing _
                OrElse Me.AFIN_WDT_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_WDT_ID.Text = "&nbsp;"
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
                
        Public Overridable Sub SetAFIN_WSD_ID()

                  
            
        
            ' Set the AFIN_WSD_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Activity database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Activity record retrieved from the database.
            ' Me.AFIN_WSD_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetAFIN_WSD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.AFIN_WSD_IDSpecified Then
                				
                ' If the AFIN_WSD_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Activity1Table.AFIN_WSD_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.AFIN_WSD_ID.Text = formattedValue
                
            Else 
            
                ' AFIN_WSD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.AFIN_WSD_ID.Text = WFinRep_Activity1Table.AFIN_WSD_ID.Format(WFinRep_Activity1Table.AFIN_WSD_ID.DefaultValue)
                        		
                End If
                 
            ' If the AFIN_WSD_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.AFIN_WSD_ID.Text Is Nothing _
                OrElse Me.AFIN_WSD_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.AFIN_WSD_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetAFIN_CodeLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_Date_ActionLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_Date_AssignLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_FinIDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_Is_DoneLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_RemarkLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_StatusLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_W_U_ID_DelegateLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_W_U_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_WDT_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_WS_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetAFIN_WSD_IDLabel()

                  
                  
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
        
        Dim parentCtrl As WFinRep_Head1TableControlRow
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_Head1TableControlRow"), WFinRep_Head1TableControlRow)				  
              
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
        
            GetAFIN_Code()
            GetAFIN_Date_Action()
            GetAFIN_Date_Assign()
            GetAFIN_FinID()
            GetAFIN_Is_Done()
            GetAFIN_Remark()
            GetAFIN_Status()
            GetAFIN_W_U_ID()
            GetAFIN_W_U_ID_Delegate()
            GetAFIN_WDT_ID()
            GetAFIN_WS_ID()
            GetAFIN_WSD_ID()
        End Sub
        
        
        Public Overridable Sub GetAFIN_Code()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Date_Action()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Date_Assign()
            
        End Sub
                
        Public Overridable Sub GetAFIN_FinID()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Is_Done()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Remark()
            
        End Sub
                
        Public Overridable Sub GetAFIN_Status()
            
        End Sub
                
        Public Overridable Sub GetAFIN_W_U_ID()
            
        End Sub
                
        Public Overridable Sub GetAFIN_W_U_ID_Delegate()
            
        End Sub
                
        Public Overridable Sub GetAFIN_WDT_ID()
            
        End Sub
                
        Public Overridable Sub GetAFIN_WS_ID()
            
        End Sub
                
        Public Overridable Sub GetAFIN_WSD_ID()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_Activity1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
      
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
        
        Public ReadOnly Property AFIN_Code() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Code"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_CodeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_CodeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_Date_Action() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_Action"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Date_ActionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_ActionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_Date_Assign() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_Assign"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Date_AssignLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Date_AssignLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_FinID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_FinID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_FinIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_FinIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_Is_Done() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Is_Done"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_Is_DoneLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Is_DoneLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_Remark() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Remark"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_RemarkLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_RemarkLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_W_U_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_W_U_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_W_U_ID_Delegate() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_W_U_ID_Delegate"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_W_U_ID_DelegateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_W_U_ID_DelegateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_W_U_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_W_U_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_WDT_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WDT_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_WDT_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WDT_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_WS_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WS_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_WS_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WS_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property AFIN_WSD_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WSD_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property AFIN_WSD_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "AFIN_WSD_IDLabel"), System.Web.UI.WebControls.Literal)
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

  

' Base class for the WFinRep_Activity1TableControl control on the FSWF_Inquiry1 page.
' Do not modify this class. Instead override any method in WFinRep_Activity1TableControl.
Public Class BaseWFinRep_Activity1TableControl
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
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_W_U_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_W_U_ID_Delegate, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Activity1Table.AFIN_WDT_ID, Me.DataSource)
          
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
        
            If DbUtils.GetCreatedRecords(Me.DataSource).Length > 0 Then                      
                    
                Me.Pagination1.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pagination1.CurrentPage.Text = "0"
            End If
            Me.Pagination1.PageSize.Text = Me.PageSize.ToString()

            ' Bind the buttons for WFinRep_Activity1TableControl pagination.
        
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
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
        Dim wFinRep_Head1RecordObj as KeyValue
        wFinRep_Head1RecordObj = Nothing
      
              Dim wFinRep_Head1TableControlObjRow As WFinRep_Head1TableControlRow = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_Head1TableControlRow") ,WFinRep_Head1TableControlRow)
            
                If (Not IsNothing(wFinRep_Head1TableControlObjRow) AndAlso Not IsNothing(wFinRep_Head1TableControlObjRow.GetRecord()) AndAlso Not IsNothing(wFinRep_Head1TableControlObjRow.GetRecord().HFIN_ID))
                    wc.iAND(WFinRep_Activity1Table.AFIN_HFIN_ID, BaseFilter.ComparisonOperator.EqualsTo, wFinRep_Head1TableControlObjRow.GetRecord().HFIN_ID.ToString())
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
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWFinRep_Head1TableControl as String = DirectCast(HttpContext.Current.Session("WFinRep_Activity1TableControlWhereClause"), String)
            
            If Not selectedRecordInWFinRep_Head1TableControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWFinRep_Head1TableControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWFinRep_Head1TableControl)
                
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_Activity1TableControlRow = DirectCast(repItem.FindControl("WFinRep_Activity1TableControlRow"), WFinRep_Activity1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_Activity1Record = New WFinRep_Activity1Record()
        
                        If recControl.AFIN_Code.Text <> "" Then
                            rec.Parse(recControl.AFIN_Code.Text, WFinRep_Activity1Table.AFIN_Code)
                        End If
                        If recControl.AFIN_Date_Action.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Action.Text, WFinRep_Activity1Table.AFIN_Date_Action)
                        End If
                        If recControl.AFIN_Date_Assign.Text <> "" Then
                            rec.Parse(recControl.AFIN_Date_Assign.Text, WFinRep_Activity1Table.AFIN_Date_Assign)
                        End If
                        If recControl.AFIN_FinID.Text <> "" Then
                            rec.Parse(recControl.AFIN_FinID.Text, WFinRep_Activity1Table.AFIN_FinID)
                        End If
                        If recControl.AFIN_Is_Done.Text <> "" Then
                            rec.Parse(recControl.AFIN_Is_Done.Text, WFinRep_Activity1Table.AFIN_Is_Done)
                        End If
                        If recControl.AFIN_Remark.Text <> "" Then
                            rec.Parse(recControl.AFIN_Remark.Text, WFinRep_Activity1Table.AFIN_Remark)
                        End If
                        If recControl.AFIN_Status.Text <> "" Then
                            rec.Parse(recControl.AFIN_Status.Text, WFinRep_Activity1Table.AFIN_Status)
                        End If
                        If recControl.AFIN_W_U_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_W_U_ID.Text, WFinRep_Activity1Table.AFIN_W_U_ID)
                        End If
                        If recControl.AFIN_W_U_ID_Delegate.Text <> "" Then
                            rec.Parse(recControl.AFIN_W_U_ID_Delegate.Text, WFinRep_Activity1Table.AFIN_W_U_ID_Delegate)
                        End If
                        If recControl.AFIN_WDT_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_WDT_ID.Text, WFinRep_Activity1Table.AFIN_WDT_ID)
                        End If
                        If recControl.AFIN_WS_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_WS_ID.Text, WFinRep_Activity1Table.AFIN_WS_ID)
                        End If
                        If recControl.AFIN_WSD_ID.Text <> "" Then
                            rec.Parse(recControl.AFIN_WSD_ID.Text, WFinRep_Activity1Table.AFIN_WSD_ID)
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
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Code {Txt:Ascending}"), "AFIN_Code Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Code {Txt:Descending}"), "AFIN_Code Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Date Action {Txt:Ascending}"), "AFIN_Date_Action Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Date Action {Txt:Descending}"), "AFIN_Date_Action Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Date Assign {Txt:Ascending}"), "AFIN_Date_Assign Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Date Assign {Txt:Descending}"), "AFIN_Date_Assign Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Fin {Txt:Ascending}"), "AFIN_FinID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Fin {Txt:Descending}"), "AFIN_FinID Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Is Done {Txt:Ascending}"), "AFIN_Is_Done Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Is Done {Txt:Descending}"), "AFIN_Is_Done Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Status {Txt:Ascending}"), "AFIN_Status Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("AFIN Status {Txt:Descending}"), "AFIN_Status Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Afin W U {Txt:Ascending}"), "AFIN_W_U_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Afin W U {Txt:Descending}"), "AFIN_W_U_ID Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Afin WDT {Txt:Ascending}"), "AFIN_WDT_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Afin WDT {Txt:Descending}"), "AFIN_WDT_ID Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Afin WS {Txt:Ascending}"), "AFIN_WS_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Afin WS {Txt:Descending}"), "AFIN_WS_ID Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Afin WSD {Txt:Ascending}"), "AFIN_WSD_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Afin WSD {Txt:Descending}"), "AFIN_WSD_ID Desc"))
                            

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

            Dim orderByStr As String = CType(ViewState("WFinRep_Activity1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRep_Activity1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WFinRep_Activity1Table.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WFinRep_Activity1Table.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WFinRep_Activity1Table.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not WFinRep_Activity1Table.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WFinRep_Activity1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WFinRep_Activity1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
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

  
' Base class for the WFinRep_DocAttach1TableControlRow control on the FSWF_Inquiry1 page.
' Do not modify this class. Instead override any method in WFinRep_DocAttach1TableControlRow.
Public Class BaseWFinRep_DocAttach1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_DocAttach1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_DocAttach1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_DocAttach1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_DocAttach1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_DocAttach1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_DocAttach1TableControlRow.
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
        
                SetFIN_Company()
                SetFIN_CompanyLabel()
                SetFIn_Description()
                SetFIn_DescriptionLabel()
                SetFIN_File()
                SetFIN_File1()
                SetFIN_File1Label()
                SetFIN_FileLabel()
                SetFIN_HFIN_ID()
                SetFIN_HFIN_IDLabel()
                SetFIN_Month()
                SetFIN_MonthLabel()
                SetFIN_Post()
                SetFIN_PostLabel()
                SetFIN_RptID()
                SetFIN_RptIDLabel()
                SetFIN_RWRem()
                SetFIN_RWRemLabel()
                SetFIN_Status()
                SetFIN_StatusLabel()
                SetFIN_Type()
                SetFIN_TypeLabel()
                SetFIN_Year()
                SetFIN_YearLabel()
      
      
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
        
        
        Public Overridable Sub SetFIN_Company()

                  
            
        
            ' Set the FIN_Company Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Company is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Company()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_CompanySpecified Then
                				
                ' If the FIN_Company is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Company)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttach1Table.FIN_Company.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttach1Table.GetDFKA(Me.DataSource.FIN_Company.ToString(),WFinRep_DocAttach1Table.FIN_Company, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_Company)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Company.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Company.Text = formattedValue
                
            Else 
            
                ' FIN_Company is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Company.Text = WFinRep_DocAttach1Table.FIN_Company.Format(WFinRep_DocAttach1Table.FIN_Company.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Company is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Company.Text Is Nothing _
                OrElse Me.FIN_Company.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Company.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIn_Description()

                  
            
        
            ' Set the FIn_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIn_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIn_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIn_DescriptionSpecified Then
                				
                ' If the FIn_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIn_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIn_Description.Text = formattedValue
                
            Else 
            
                ' FIn_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIn_Description.Text = WFinRep_DocAttach1Table.FIn_Description.Format(WFinRep_DocAttach1Table.FIn_Description.DefaultValue)
                        		
                End If
                 
            ' If the FIn_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIn_Description.Text Is Nothing _
                OrElse Me.FIn_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIn_Description.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_FileSpecified Then
                
                Me.FIN_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.FIN_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRep_DocAttach1") & _
                            "&Field=" & Me.Page.Encrypt("FIN_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.FIN_File.Visible = True
            Else
                Me.FIN_File.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetFIN_File1()

                  
            
        
            ' Set the FIN_File1 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_File1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_File1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_File1Specified Then
                				
                ' If the FIN_File1 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_File1)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_File1.Text = formattedValue
                
            Else 
            
                ' FIN_File1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_File1.Text = WFinRep_DocAttach1Table.FIN_File1.Format(WFinRep_DocAttach1Table.FIN_File1.DefaultValue)
                        		
                End If
                 
            ' If the FIN_File1 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_File1.Text Is Nothing _
                OrElse Me.FIN_File1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_File1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_HFIN_ID()

                  
            
        
            ' Set the FIN_HFIN_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_HFIN_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_HFIN_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_HFIN_IDSpecified Then
                				
                ' If the FIN_HFIN_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_HFIN_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttach1Table.FIN_HFIN_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttach1Table.GetDFKA(Me.DataSource.FIN_HFIN_ID.ToString(),WFinRep_DocAttach1Table.FIN_HFIN_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_HFIN_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_HFIN_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_HFIN_ID.Text = formattedValue
                
            Else 
            
                ' FIN_HFIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_HFIN_ID.Text = WFinRep_DocAttach1Table.FIN_HFIN_ID.Format(WFinRep_DocAttach1Table.FIN_HFIN_ID.DefaultValue)
                        		
                End If
                 
            ' If the FIN_HFIN_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_HFIN_ID.Text Is Nothing _
                OrElse Me.FIN_HFIN_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_HFIN_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Month()

                  
            
        
            ' Set the FIN_Month Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Month is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_MonthSpecified Then
                				
                ' If the FIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttach1Table.FIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttach1Table.GetDFKA(Me.DataSource.FIN_Month.ToString(),WFinRep_DocAttach1Table.FIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Month.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Month.Text = formattedValue
                
            Else 
            
                ' FIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Month.Text = WFinRep_DocAttach1Table.FIN_Month.Format(WFinRep_DocAttach1Table.FIN_Month.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Month is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Month.Text Is Nothing _
                OrElse Me.FIN_Month.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Month.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Post()

                  
            
        
            ' Set the FIN_Post Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Post is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Post()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_PostSpecified Then
                				
                ' If the FIN_Post is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_Post)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Post.Text = formattedValue
                
            Else 
            
                ' FIN_Post is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Post.Text = WFinRep_DocAttach1Table.FIN_Post.Format(WFinRep_DocAttach1Table.FIN_Post.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Post is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Post.Text Is Nothing _
                OrElse Me.FIN_Post.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Post.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_RptID()

                  
            
        
            ' Set the FIN_RptID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_RptID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_RptID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_RptIDSpecified Then
                				
                ' If the FIN_RptID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_RptID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_RptID.Text = formattedValue
                
            Else 
            
                ' FIN_RptID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_RptID.Text = WFinRep_DocAttach1Table.FIN_RptID.Format(WFinRep_DocAttach1Table.FIN_RptID.DefaultValue)
                        		
                End If
                 
            ' If the FIN_RptID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_RptID.Text Is Nothing _
                OrElse Me.FIN_RptID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_RptID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_RWRem()

                  
            
        
            ' Set the FIN_RWRem Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_RWRem is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_RWRem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_RWRemSpecified Then
                				
                ' If the FIN_RWRem is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_RWRem)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_RWRem.Text = formattedValue
                
            Else 
            
                ' FIN_RWRem is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_RWRem.Text = WFinRep_DocAttach1Table.FIN_RWRem.Format(WFinRep_DocAttach1Table.FIN_RWRem.DefaultValue)
                        		
                End If
                 
            ' If the FIN_RWRem is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_RWRem.Text Is Nothing _
                OrElse Me.FIN_RWRem.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_RWRem.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Status()

                  
            
        
            ' Set the FIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Status is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_StatusSpecified Then
                				
                ' If the FIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttach1Table.FIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_DocAttach1Table.GetDFKA(Me.DataSource.FIN_Status.ToString(),WFinRep_DocAttach1Table.FIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.FIN_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Status.Text = formattedValue
                
            Else 
            
                ' FIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Status.Text = WFinRep_DocAttach1Table.FIN_Status.Format(WFinRep_DocAttach1Table.FIN_Status.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Status.Text Is Nothing _
                OrElse Me.FIN_Status.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Status.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Type()

                  
            
        
            ' Set the FIN_Type Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Type is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_TypeSpecified Then
                				
                ' If the FIN_Type is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_Type)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Type.Text = formattedValue
                
            Else 
            
                ' FIN_Type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Type.Text = WFinRep_DocAttach1Table.FIN_Type.Format(WFinRep_DocAttach1Table.FIN_Type.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Type is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Type.Text Is Nothing _
                OrElse Me.FIN_Type.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Type.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_Year()

                  
            
        
            ' Set the FIN_Year Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_DocAttach database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_DocAttach record retrieved from the database.
            ' Me.FIN_Year is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetFIN_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.FIN_YearSpecified Then
                				
                ' If the FIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_DocAttach1Table.FIN_Year)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.FIN_Year.Text = formattedValue
                
            Else 
            
                ' FIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.FIN_Year.Text = WFinRep_DocAttach1Table.FIN_Year.Format(WFinRep_DocAttach1Table.FIN_Year.DefaultValue)
                        		
                End If
                 
            ' If the FIN_Year is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.FIN_Year.Text Is Nothing _
                OrElse Me.FIN_Year.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.FIN_Year.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetFIN_CompanyLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIn_DescriptionLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_File1Label()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_FileLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_HFIN_IDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_MonthLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_PostLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_RptIDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_RWRemLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_StatusLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_TypeLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetFIN_YearLabel()

                  
                  
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

      
        
        ' To customize, override this method in WFinRep_DocAttach1TableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WFinRep_DocAttach1TableControl"), WFinRep_DocAttach1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRep_DocAttach1TableControl"), WFinRep_DocAttach1TableControl).ResetData = True
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

        ' To customize, override this method in WFinRep_DocAttach1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetFIN_Company()
            GetFIn_Description()
            GetFIN_File1()
            GetFIN_HFIN_ID()
            GetFIN_Month()
            GetFIN_Post()
            GetFIN_RptID()
            GetFIN_RWRem()
            GetFIN_Status()
            GetFIN_Type()
            GetFIN_Year()
        End Sub
        
        
        Public Overridable Sub GetFIN_Company()
            
        End Sub
                
        Public Overridable Sub GetFIn_Description()
            
        End Sub
                
        Public Overridable Sub GetFIN_File1()
            
        End Sub
                
        Public Overridable Sub GetFIN_HFIN_ID()
            
        End Sub
                
        Public Overridable Sub GetFIN_Month()
            
        End Sub
                
        Public Overridable Sub GetFIN_Post()
            
        End Sub
                
        Public Overridable Sub GetFIN_RptID()
            
        End Sub
                
        Public Overridable Sub GetFIN_RWRem()
            
        End Sub
                
        Public Overridable Sub GetFIN_Status()
            
        End Sub
                
        Public Overridable Sub GetFIN_Type()
            
        End Sub
                
        Public Overridable Sub GetFIN_Year()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_DocAttach1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRep_DocAttach1TableControlRow.
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
          WFinRep_DocAttach1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRep_DocAttach1TableControl"), WFinRep_DocAttach1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRep_DocAttach1TableControl"), WFinRep_DocAttach1TableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWFinRep_DocAttach1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRep_DocAttach1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRep_DocAttach1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_DocAttach1Record)
            End Get
            Set(ByVal value As WFinRep_DocAttach1Record)
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
        
        Public ReadOnly Property FIN_Company() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Company"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_CompanyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_CompanyLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIn_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIn_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIn_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIn_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property FIN_File1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_File1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_File1Label() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_File1Label"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_FileLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_FileLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_HFIN_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_HFIN_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_HFIN_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_HFIN_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_Month() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Month"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_MonthLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_MonthLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_Post() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Post"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_PostLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_PostLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_RptID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_RptID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_RptIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_RptIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_RWRem() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_RWRem"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_RWRemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_RWRemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_Status() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Status"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_Type() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Type"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_TypeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_TypeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property FIN_Year() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_Year"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property FIN_YearLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_YearLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WFinRep_DocAttach1Record = Nothing
             
        
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
            
            Dim rec As WFinRep_DocAttach1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_DocAttach1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_DocAttach1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRep_DocAttach1TableControl control on the FSWF_Inquiry1 page.
' Do not modify this class. Instead override any method in WFinRep_DocAttach1TableControl.
Public Class BaseWFinRep_DocAttach1TableControl
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
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.FIN_StatusFilter1) 				
                    initialVal = Me.GetFromSession(Me.FIN_StatusFilter1)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""FIN_Status"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Dim FIN_StatusFilter1itemListFromSession() As String = initialVal.Split(","c)
                        Dim index As Integer = 0
                        For Each item As String In FIN_StatusFilter1itemListFromSession
                            If index = 0 AndAlso _
                               item.ToString.Equals("") Then
                            Else
                                Me.FIN_StatusFilter1.Items.Add(item)
                                Me.FIN_StatusFilter1.Items.Item(index).Selected = True
                                index += 1
                            End If
                        Next
                        Dim listItem As ListItem
                        For Each listItem In Me.FIN_StatusFilter1.Items
                            listItem.Selected = True
                        Next
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WFinRep_DocAttach1SearchText) 				
                    initialVal = Me.GetFromSession(Me.WFinRep_DocAttach1SearchText)
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.WFinRep_DocAttach1SearchText.Text = initialVal
                            
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
          
              AddHandler Me.ExcelButton.Click, AddressOf ExcelButton_Click
                        
              AddHandler Me.PDFButton.Click, AddressOf PDFButton_Click
                        
              AddHandler Me.ResetButton.Click, AddressOf ResetButton_Click
                        
              AddHandler Me.SearchButton4.Click, AddressOf SearchButton4_Click
                        
              AddHandler Me.WordButton.Click, AddressOf WordButton_Click
                        
              AddHandler Me.Actions2Button.Button.Click, AddressOf Actions2Button_Click
                        
              AddHandler Me.FilterButton1.Button.Click, AddressOf FilterButton1_Click
                        
              AddHandler Me.Filters2Button.Button.Click, AddressOf Filters2Button_Click
                        
            AddHandler Me.SortControl2.SelectedIndexChanged, AddressOf SortControl2_SelectedIndexChanged
              AddHandler Me.FIN_StatusFilter1.SelectedIndexChanged, AddressOf FIN_StatusFilter1_SelectedIndexChanged                  
                        
        
          ' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "WFinRep_DocAttach1SearchTextSearchBoxText", "setSearchBoxText(""" & BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) & """, """ & WFinRep_DocAttach1SearchText.ClientID & """);", True)                  
            
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_DocAttach1Record)), WFinRep_DocAttach1Record())
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
                    For Each rc As WFinRep_DocAttach1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_DocAttach1Record)), WFinRep_DocAttach1Record())
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
            ByVal pageSize As Integer) As WFinRep_DocAttach1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_DocAttach1Table.Column1, True)         
            ' selCols.Add(WFinRep_DocAttach1Table.Column2, True)          
            ' selCols.Add(WFinRep_DocAttach1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_DocAttach1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_DocAttach1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_DocAttach1Record)), WFinRep_DocAttach1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_DocAttach1Table.Column1, True)         
            ' selCols.Add(WFinRep_DocAttach1Table.Column2, True)          
            ' selCols.Add(WFinRep_DocAttach1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_DocAttach1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_DocAttach1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttach1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRep_DocAttach1TableControlRow = DirectCast(repItem.FindControl("WFinRep_DocAttach1TableControlRow"), WFinRep_DocAttach1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                
                
                SetFIN_StatusFilter1()
                SetFIN_StatusLabel2()
                
                
                
                
                SetSortByLabel2()
                SetSortControl2()
                
                SetWFinRep_DocAttach1SearchText()
                
                SetExcelButton()
              
                SetPDFButton()
              
                SetResetButton()
              
                SetSearchButton4()
              
                SetWordButton()
              
                SetActions2Button()
              
                SetFilterButton1()
              
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
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttach1Table.FIN_Company, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttach1Table.FIN_HFIN_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttach1Table.FIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_DocAttach1Table.FIN_Status, Me.DataSource)
          
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

            ' Bind the buttons for WFinRep_DocAttach1TableControl pagination.
        
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
            
            Dim recCtl As WFinRep_DocAttach1TableControlRow
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
            WFinRep_DocAttach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              

                  Dim totalSelectedItemCount as Integer = 0
                  
            If IsValueSelected(Me.FIN_StatusFilter1) Then
    
              hasFiltersWFinRep_DocAttach1TableControl = True            
    
                Dim item As ListItem
                Dim selectedItemCount As Integer = 0
                For Each item In Me.FIN_StatusFilter1.Items
                    If item.Selected Then
                        selectedItemCount += 1
                        
                          totalSelectedItemCount += 1
                        
                    End If
                Next
                
                Dim filter As WhereClause = New WhereClause
                For Each item In Me.FIN_StatusFilter1.Items
                    If item.Selected AndAlso (item.Value = "--ANY--" OrElse item.Value = "--PLEASE_SELECT--") AndAlso selectedItemCount > 1 Then
                        item.Selected = False
                    End If
                    If item.Selected Then
                        filter.iOR(WFinRep_DocAttach1Table.FIN_Status, BaseFilter.ComparisonOperator.EqualsTo, item.Value, False, False)
                    End If
                Next
                wc.iAND(filter)
                
            End If
                  
                
                       
            If IsValueSelected(Me.WFinRep_DocAttach1SearchText) Then
              If Me.WFinRep_DocAttach1SearchText.Text = BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) Then
                 Me.WFinRep_DocAttach1SearchText.Text = ""
              Else
              ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
              
                If Me.WFinRep_DocAttach1SearchText.Text.StartsWith(BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing)) Then
                Me.WFinRep_DocAttach1SearchText.Text = ""
                Else
              
                    If Me.WFinRep_DocAttach1SearchText.Text.StartsWith("...") Then
                        Me.WFinRep_DocAttach1SearchText.Text = Me.WFinRep_DocAttach1SearchText.Text.SubString(3,Me.WFinRep_DocAttach1SearchText.Text.Length-3)
                    End If
                    If Me.WFinRep_DocAttach1SearchText.Text.EndsWith("...") then
                        Me.WFinRep_DocAttach1SearchText.Text = Me.WFinRep_DocAttach1SearchText.Text.SubString(0,Me.WFinRep_DocAttach1SearchText.Text.Length-3)
                        ' Strip the last word as well as it is likely only a partial word
                        Dim endindex As Integer = WFinRep_DocAttach1SearchText.Text.Length - 1
                        While (Not Char.IsWhiteSpace(WFinRep_DocAttach1SearchText.Text(endindex)) AndAlso endindex > 0)
                            endindex -= 1
                        End While
                        If endindex > 0 Then
                            WFinRep_DocAttach1SearchText.Text = WFinRep_DocAttach1SearchText.Text.Substring(0, endindex)
                        End If
              End If
            End If
            
              End If
            
              Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.WFinRep_DocAttach1SearchText, Me.GetFromSession(Me.WFinRep_DocAttach1SearchText))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.WFinRep_DocAttach1SearchText) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    Dim search As WhereClause = New WhereClause()
                    
      Dim cols As New ColumnList    
        
      cols.Add(WFinRep_DocAttach1Table.FIn_Description, True)
      
      For Each col As BaseColumn in cols
      
                    search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.WFinRep_DocAttach1SearchText, Me.GetFromSession(Me.WFinRep_DocAttach1SearchText)), True, False)
        
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
            WFinRep_DocAttach1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim FIN_StatusFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "FIN_StatusFilter1_Ajax"), String)
            If IsValueSelected(FIN_StatusFilter1SelectedValue) Then
    
              hasFiltersWFinRep_DocAttach1TableControl = True            
    
            If Not isNothing(FIN_StatusFilter1SelectedValue) Then
                Dim FIN_StatusFilter1itemListFromSession() As String = FIN_StatusFilter1SelectedValue.Split(","c)
                Dim index As Integer = 0
                  
                Dim filter As WhereClause = New WhereClause
                For Each item As String In FIN_StatusFilter1itemListFromSession
                    If index = 0 AndAlso item.ToString.Equals("") Then
                    Else
                        filter.iOR(WFinRep_DocAttach1Table.FIN_Status, BaseFilter.ComparisonOperator.EqualsTo, item, False, False)
                        index += 1
                    End If
                Next
                wc.iAND(filter)
                
             End If
                
             End If
                      
            If IsValueSelected(searchText) and fromSearchControl = "WFinRep_DocAttach1SearchText" Then
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
        
      cols.Add(WFinRep_DocAttach1Table.FIn_Description, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
      Next
    
                    Else
                        
      Dim cols As New ColumnList    
        
      cols.Add(WFinRep_DocAttach1Table.FIn_Description, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
      Next
    
                    End If
                    wc.iAND(search)
                End If
            End If
                  
      
      
            Return wc
        End Function

      
        Public Overridable Function GetAutoCompletionList_WFinRep_DocAttach1SearchText(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            
            Dim filterJoin As CompoundFilter = CreateCompoundJoinFilter()
            If count = 0 Then count = 10
            Dim wc As WhereClause = CreateWhereClause(prefixText,"WFinRep_DocAttach1SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            Dim recordList () As ePortalWFApproval.Business.WFinRep_DocAttach1Record = WFinRep_DocAttach1Table.GetRecords(filterJoin, wc, Nothing, 0, count,count)
            Dim rec As WFinRep_DocAttach1Record = Nothing
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
        
                resultItem = rec.Format(WFinRep_DocAttach1Table.FIn_Description)
                If resultItem IsNot Nothing Then
                    Dim prText As String = prefixText
                    If WFinRep_DocAttach1Table.FIn_Description.IsFullTextSearchable Then
                         Dim ft As FullTextExpression = New FullTextExpression()
                         prText = ft.GetFirstNonExcludedTerm(prText)
                    End If
                    If Not String.IsNullOrEmpty(prText) AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
  
                        Dim isAdded As Boolean = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, WFinRep_DocAttach1Table.FIn_Description.IsFullTextSearchable)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttach1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_DocAttach1TableControlRow = DirectCast(repItem.FindControl("WFinRep_DocAttach1TableControlRow"), WFinRep_DocAttach1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_DocAttach1Record = New WFinRep_DocAttach1Record()
        
                        If recControl.FIN_Company.Text <> "" Then
                            rec.Parse(recControl.FIN_Company.Text, WFinRep_DocAttach1Table.FIN_Company)
                        End If
                        If recControl.FIn_Description.Text <> "" Then
                            rec.Parse(recControl.FIn_Description.Text, WFinRep_DocAttach1Table.FIn_Description)
                        End If
                        If recControl.FIN_File.Text <> "" Then
                            rec.Parse(recControl.FIN_File.Text, WFinRep_DocAttach1Table.FIN_File)
                        End If
                        If recControl.FIN_File1.Text <> "" Then
                            rec.Parse(recControl.FIN_File1.Text, WFinRep_DocAttach1Table.FIN_File1)
                        End If
                        If recControl.FIN_HFIN_ID.Text <> "" Then
                            rec.Parse(recControl.FIN_HFIN_ID.Text, WFinRep_DocAttach1Table.FIN_HFIN_ID)
                        End If
                        If recControl.FIN_Month.Text <> "" Then
                            rec.Parse(recControl.FIN_Month.Text, WFinRep_DocAttach1Table.FIN_Month)
                        End If
                        If recControl.FIN_Post.Text <> "" Then
                            rec.Parse(recControl.FIN_Post.Text, WFinRep_DocAttach1Table.FIN_Post)
                        End If
                        If recControl.FIN_RptID.Text <> "" Then
                            rec.Parse(recControl.FIN_RptID.Text, WFinRep_DocAttach1Table.FIN_RptID)
                        End If
                        If recControl.FIN_RWRem.Text <> "" Then
                            rec.Parse(recControl.FIN_RWRem.Text, WFinRep_DocAttach1Table.FIN_RWRem)
                        End If
                        If recControl.FIN_Status.Text <> "" Then
                            rec.Parse(recControl.FIN_Status.Text, WFinRep_DocAttach1Table.FIN_Status)
                        End If
                        If recControl.FIN_Type.Text <> "" Then
                            rec.Parse(recControl.FIN_Type.Text, WFinRep_DocAttach1Table.FIN_Type)
                        End If
                        If recControl.FIN_Year.Text <> "" Then
                            rec.Parse(recControl.FIN_Year.Text, WFinRep_DocAttach1Table.FIN_Year)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_DocAttach1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_DocAttach1Record)), WFinRep_DocAttach1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRep_DocAttach1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRep_DocAttach1TableControlRow) As Boolean
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
        
        Public Overridable Sub SetFIN_StatusLabel2()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortByLabel2()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel2.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl2()

              
            
                Me.PopulateSortControl2(GetSelectedValue(Me.SortControl2,  GetFromSession(Me.SortControl2)), 500)					
                    
        End Sub
            
        Public Overridable Sub SetFIN_StatusFilter1()

              
            
            Dim FIN_StatusFilter1selectedFilterItemList As New ArrayList()
            Dim FIN_StatusFilter1itemsString As String = Nothing
            If (Me.InSession(Me.FIN_StatusFilter1)) Then
                FIN_StatusFilter1itemsString = Me.GetFromSession(Me.FIN_StatusFilter1)
            End If
            
            If (FIN_StatusFilter1itemsString IsNot Nothing) Then
                Dim FIN_StatusFilter1itemListFromSession() As String = FIN_StatusFilter1itemsString.Split(","c)
                For Each item as String In FIN_StatusFilter1itemListFromSession
                    FIN_StatusFilter1selectedFilterItemList.Add(item)
                Next
            End If
              
            		
            Me.PopulateFIN_StatusFilter1(GetSelectedValueList(Me.FIN_StatusFilter1, FIN_StatusFilter1selectedFilterItemList), 500)
                    
              Dim url as String = Me.ModifyRedirectUrl("../WFin_ApprovalStatus1/WFin-ApprovalStatus-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.FIN_StatusFilter1.ClientID & "&Formula=" & CType(Me.Page, BaseApplicationPage).Encrypt("= WFin_ApprovalStatus1.WPO_STAT_DESC")& "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WPO_STAT_CD")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--ANY--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:All")) & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.FIN_StatusFilter1.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(FIN_StatusFilter1.AutoPostBack).ToLower() & ", event); return false;"        
                  
                                 
              End Sub	
            
        Public Overridable Sub SetWFinRep_DocAttach1SearchText()

              
                                            
          Me.WFinRep_DocAttach1SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "') {this.value='';this.className='Search_Input';}")
          Me.WFinRep_DocAttach1SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "';this.className='Search_InputHint';}")
                                   
              End Sub	
            
        ' Get the filters' data for SortControl2
        Protected Overridable Sub PopulateSortControl2(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl2.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Company {Txt:Ascending}"), "FIN_Company Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Company {Txt:Descending}"), "FIN_Company Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN File 1 {Txt:Ascending}"), "FIN_File1 Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN File 1 {Txt:Descending}"), "FIN_File1 Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Fin Hfin {Txt:Ascending}"), "FIN_HFIN_ID Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Fin Hfin {Txt:Descending}"), "FIN_HFIN_ID Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Month {Txt:Ascending}"), "FIN_Month Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Month {Txt:Descending}"), "FIN_Month Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Post {Txt:Ascending}"), "FIN_Post Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Post {Txt:Descending}"), "FIN_Post Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Report {Txt:Ascending}"), "FIN_RptID Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Report {Txt:Descending}"), "FIN_RptID Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN RWRem {Txt:Ascending}"), "FIN_RWRem Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN RWRem {Txt:Descending}"), "FIN_RWRem Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Status {Txt:Ascending}"), "FIN_Status Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Status {Txt:Descending}"), "FIN_Status Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Type {Txt:Ascending}"), "FIN_Type Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Type {Txt:Descending}"), "FIN_Type Desc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Year {Txt:Ascending}"), "FIN_Year Asc"))
                            							
            Me.SortControl2.Items.Add(New ListItem(Me.Page.ExpandResourceValue("FIN Year {Txt:Descending}"), "FIN_Year Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl2, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl2.SelectedValue IsNot Nothing AndAlso Me.SortControl2.Items.FindByValue(Me.SortControl2.SelectedValue) Is Nothing
                Me.SortControl2.SelectedValue = Nothing
            End If

              End Sub
            
        ' Get the filters' data for FIN_StatusFilter1
        Protected Overridable Sub PopulateFIN_StatusFilter1(ByVal selectedValue As ArrayList, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Dim wc As WhereClause = Me.CreateWhereClause_FIN_StatusFilter1()
            Me.FIN_StatusFilter1.Items.Clear()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_FIN_StatusFilter1 function.
            ' It is better to customize the where clause there.
            

            Dim orderBy As OrderBy = New OrderBy(false, false)			
            
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

                            If counter < maxItems AndAlso Me.FIN_StatusFilter1.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Status)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_DocAttach1Table.FIN_Status.IsApplyDisplayAs Then
                                    fvalue = WFinRep_DocAttach1Table.GetDFKA(itemValue, WFinRep_DocAttach1Table.FIN_Status)
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

                                Dim dupItem As ListItem = Me.FIN_StatusFilter1.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.FIN_StatusFilter1.Items.Add(newItem)

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
            
            
            Me.FIN_StatusFilter1.SetFieldMaxLength(50)
                                 
                  
            ' Add the selected value.
            If Me.FIN_StatusFilter1.Items.Count = 0 Then
                Me.FIN_StatusFilter1.Items.Add(New ListItem(Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
            End If
            
            ' Mark all items to be selected.
            For Each item As ListItem in Me.FIN_StatusFilter1.Items
                item.Selected = True
            Next
                              
        End Sub
            
              

        Public Overridable Function CreateWhereClause_FIN_StatusFilter1() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
            
            ' Create a where clause for the filter FIN_StatusFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the FIN_StatusFilter1QuickSelector
            
            Dim FIN_StatusFilter1selectedFilterItemList As New ArrayList()
            Dim FIN_StatusFilter1itemsString As String = Nothing
            If (Me.InSession(Me.FIN_StatusFilter1)) Then
                FIN_StatusFilter1itemsString = Me.GetFromSession(Me.FIN_StatusFilter1)
            End If
            
            If (FIN_StatusFilter1itemsString IsNot Nothing) Then
                Dim FIN_StatusFilter1itemListFromSession() As String = FIN_StatusFilter1itemsString.Split(","c)
                For Each item as String In FIN_StatusFilter1itemListFromSession
                    FIN_StatusFilter1selectedFilterItemList.Add(item)
                Next
            End If
              
            FIN_StatusFilter1selectedFilterItemList = GetSelectedValueList(Me.FIN_StatusFilter1, FIN_StatusFilter1selectedFilterItemList) 
            Dim wc As New WhereClause
            If FIN_StatusFilter1selectedFilterItemList Is Nothing OrElse FIN_StatusFilter1selectedFilterItemList.Count = 0 Then
                wc.RunQuery = False
            Else            
                For Each item As String In FIN_StatusFilter1selectedFilterItemList
              
            	  
                    wc.iOR(WFin_ApprovalStatus1Table.WPO_STAT_CD, BaseFilter.ComparisonOperator.EqualsTo, item)                  
                  
                                 
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
        
            Me.SaveToSession(Me.SortControl2, Me.SortControl2.SelectedValue)
                  
            Dim FIN_StatusFilter1selectedFilterItemList As ArrayList = GetSelectedValueList(Me.FIN_StatusFilter1, Nothing)
            Dim FIN_StatusFilter1SessionString As String = ""
            If Not FIN_StatusFilter1selectedFilterItemList is Nothing Then
            For Each item As String In FIN_StatusFilter1selectedFilterItemList
                FIN_StatusFilter1Sessionstring = FIN_StatusFilter1Sessionstring & "," & item
            Next
            End If
            Me.SaveToSession(Me.FIN_StatusFilter1, FIN_StatusFilter1Sessionstring)
                  
            Me.SaveToSession(Me.WFinRep_DocAttach1SearchText, Me.WFinRep_DocAttach1SearchText.Text)
                  
        
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
                  
            Dim FIN_StatusFilter1selectedFilterItemList As ArrayList = GetSelectedValueList(Me.FIN_StatusFilter1, Nothing)
            Dim FIN_StatusFilter1SessionString As String = ""
            If Not FIN_StatusFilter1selectedFilterItemList is Nothing Then
            For Each item As String In FIN_StatusFilter1selectedFilterItemList
                FIN_StatusFilter1Sessionstring = FIN_StatusFilter1Sessionstring & "," & item
            Next
            End If
            Me.SaveToSession("FIN_StatusFilter1_Ajax", FIN_StatusFilter1SessionString)
          
      Me.SaveToSession("WFinRep_DocAttach1SearchText_Ajax", Me.WFinRep_DocAttach1SearchText.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl2)
            Me.RemoveFromSession(Me.FIN_StatusFilter1)
            Me.RemoveFromSession(Me.WFinRep_DocAttach1SearchText)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WFinRep_DocAttach1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRep_DocAttach1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
            
        Public Overridable Sub SetPDFButton()                
              
   
        End Sub
            
        Public Overridable Sub SetResetButton()                
              
   
        End Sub
            
        Public Overridable Sub SetSearchButton4()                
              
   
        End Sub
            
        Public Overridable Sub SetWordButton()                
              
   
        End Sub
            
        Public Overridable Sub SetActions2Button()                
              
   
        End Sub
            
        Public Overridable Sub SetFilterButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetFilters2Button()                
                      
         Dim themeButtonFilters2Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters2Button"), IThemeButtonWithArrow)
         themeButtonFilters2Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
            If (IsValueSelected(FIN_StatusFilter1)) Then
                themeButtonFilters2Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png"
            End If
        
   
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
              Me.TotalRecords = WFinRep_DocAttach1Table.GetRecordCount(join, wc)
              If Me.TotalRecords > 10000 Then
          
              ' Add each of the columns in order of export.
              Dim columns() as BaseColumn = New BaseColumn() { _
                         WFinRep_DocAttach1Table.FIN_Year, _ 
             WFinRep_DocAttach1Table.FIN_Month, _ 
             WFinRep_DocAttach1Table.FIN_Type, _ 
             WFinRep_DocAttach1Table.FIn_Description, _ 
             WFinRep_DocAttach1Table.FIN_Company, _ 
             WFinRep_DocAttach1Table.FIN_Status, _ 
             WFinRep_DocAttach1Table.FIN_File1, _ 
             WFinRep_DocAttach1Table.FIN_RptID, _ 
             WFinRep_DocAttach1Table.FIN_Post, _ 
             WFinRep_DocAttach1Table.FIN_RWRem, _ 
             WFinRep_DocAttach1Table.FIN_HFIN_ID, _ 
             Nothing}
              Dim  exportData as ExportDataToCSV = New ExportDataToCSV(WFinRep_DocAttach1Table.Instance, wc, orderBy, columns)
              exportData.StartExport(Me.Page.Response, True)

              Dim dataForCSV As DataForExport = New DataForExport(WFinRep_DocAttach1Table.Instance, wc, orderBy, columns, join)

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
              Dim excelReport As ExportDataToExcel = New ExportDataToExcel(WFinRep_DocAttach1Table.Instance, wc, orderBy)
              ' Add each of the columns in order of export.
              ' To customize the data type, change the second parameter of the new ExcelColumn to be
              ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              If Me.Page.Response Is Nothing Then
                Return
              End If

              excelReport.CreateExcelBook()

              Dim width As Integer = 0
              Dim columnCounter As Integer = 0
              Dim data As DataForExport = New DataForExport(WFinRep_DocAttach1Table.Instance, wc, orderBy, Nothing, join)
                       data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_Year, "0"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_Month, "Default"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_Type, "Default"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIn_Description, "Default"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_Company, "Default"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_Status, "Default"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_File1, "Default"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_RptID, "0"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_Post, "Default"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_RWRem, "Default"))
             data.ColumnList.Add(New ExcelColumn(WFinRep_DocAttach1Table.FIN_HFIN_ID, "Default"))


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
                              val = WFinRep_DocAttach1Table.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
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
                report.SpecificReportFileName = Page.Server.MapPath("FSWF-Inquiry1.PDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "WFinRep_DocAttach"
                ' If FSWF-Inquiry1.PDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Year.Name, ReportEnum.Align.Right, "${FIN_Year}", ReportEnum.Align.Right, 15)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Month.Name, ReportEnum.Align.Left, "${FIN_Month}", ReportEnum.Align.Left, 27)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Type.Name, ReportEnum.Align.Left, "${FIN_Type}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WFinRep_DocAttach1Table.FIn_Description.Name, ReportEnum.Align.Left, "${FIn_Description}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Company.Name, ReportEnum.Align.Left, "${FIN_Company}", ReportEnum.Align.Left, 26)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Status.Name, ReportEnum.Align.Left, "${FIN_Status}", ReportEnum.Align.Left, 24)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_File1.Name, ReportEnum.Align.Left, "${FIN_File1}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_RptID.Name, ReportEnum.Align.Right, "${FIN_RptID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Post.Name, ReportEnum.Align.Left, "${FIN_Post}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_RWRem.Name, ReportEnum.Align.Left, "${FIN_RWRem}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_HFIN_ID.Name, ReportEnum.Align.Left, "${FIN_HFIN_ID}", ReportEnum.Align.Left, 17)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
                
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = WFinRep_DocAttach1Table.GetRecordCount(joinFilter,whereClause)
                Dim columns As ColumnList = WFinRep_DocAttach1Table.GetColumnList()
                Dim records As WFinRep_DocAttach1Record() = Nothing
            
                Do 
                    
                    records = WFinRep_DocAttach1Table.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As WFinRep_DocAttach1Record In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${FIN_Year}", record.Format(WFinRep_DocAttach1Table.FIN_Year), ReportEnum.Align.Right, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.FIN_Month) Then
                                 report.AddData("${FIN_Month}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Month)
                                 _DFKA = WFinRep_DocAttach1Table.GetDFKA(record.FIN_Month.ToString(), WFinRep_DocAttach1Table.FIN_Month,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WFinRep_DocAttach1Table.FIN_Month.IsApplyDisplayAs Then
                                     report.AddData("${FIN_Month}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${FIN_Month}", record.Format(WFinRep_DocAttach1Table.FIN_Month), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${FIN_Type}", record.Format(WFinRep_DocAttach1Table.FIN_Type), ReportEnum.Align.Left, 300)
                             report.AddData("${FIn_Description}", record.Format(WFinRep_DocAttach1Table.FIn_Description), ReportEnum.Align.Left, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.FIN_Company) Then
                                 report.AddData("${FIN_Company}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Company)
                                 _DFKA = WFinRep_DocAttach1Table.GetDFKA(record.FIN_Company.ToString(), WFinRep_DocAttach1Table.FIN_Company,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WFinRep_DocAttach1Table.FIN_Company.IsApplyDisplayAs Then
                                     report.AddData("${FIN_Company}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${FIN_Company}", record.Format(WFinRep_DocAttach1Table.FIN_Company), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             If BaseClasses.Utils.MiscUtils.IsNull(record.FIN_Status) Then
                                 report.AddData("${FIN_Status}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Status)
                                 _DFKA = WFinRep_DocAttach1Table.GetDFKA(record.FIN_Status.ToString(), WFinRep_DocAttach1Table.FIN_Status,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WFinRep_DocAttach1Table.FIN_Status.IsApplyDisplayAs Then
                                     report.AddData("${FIN_Status}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${FIN_Status}", record.Format(WFinRep_DocAttach1Table.FIN_Status), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${FIN_File1}", record.Format(WFinRep_DocAttach1Table.FIN_File1), ReportEnum.Align.Left, 300)
                             report.AddData("${FIN_RptID}", record.Format(WFinRep_DocAttach1Table.FIN_RptID), ReportEnum.Align.Right, 300)
                             report.AddData("${FIN_Post}", record.Format(WFinRep_DocAttach1Table.FIN_Post), ReportEnum.Align.Left, 300)
                             report.AddData("${FIN_RWRem}", record.Format(WFinRep_DocAttach1Table.FIN_RWRem), ReportEnum.Align.Left, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.FIN_HFIN_ID) Then
                                 report.AddData("${FIN_HFIN_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_HFIN_ID)
                                 _DFKA = WFinRep_DocAttach1Table.GetDFKA(record.FIN_HFIN_ID.ToString(), WFinRep_DocAttach1Table.FIN_HFIN_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WFinRep_DocAttach1Table.FIN_HFIN_ID.IsApplyDisplayAs Then
                                     report.AddData("${FIN_HFIN_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${FIN_HFIN_ID}", record.Format(WFinRep_DocAttach1Table.FIN_HFIN_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If

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
    
              Me.FIN_StatusFilter1.ClearSelection()
            Me.SortControl2.ClearSelection()
              Me.WFinRep_DocAttach1SearchText.Text = ""
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
        Public Overridable Sub SearchButton4_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
                report.SpecificReportFileName = Page.Server.MapPath("FSWF-Inquiry1.WordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "WFinRep_DocAttach"
                ' If FSWF-Inquiry1.WordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Year.Name, ReportEnum.Align.Right, "${FIN_Year}", ReportEnum.Align.Right, 15)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Month.Name, ReportEnum.Align.Left, "${FIN_Month}", ReportEnum.Align.Left, 27)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Type.Name, ReportEnum.Align.Left, "${FIN_Type}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WFinRep_DocAttach1Table.FIn_Description.Name, ReportEnum.Align.Left, "${FIn_Description}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Company.Name, ReportEnum.Align.Left, "${FIN_Company}", ReportEnum.Align.Left, 26)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Status.Name, ReportEnum.Align.Left, "${FIN_Status}", ReportEnum.Align.Left, 24)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_File1.Name, ReportEnum.Align.Left, "${FIN_File1}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_RptID.Name, ReportEnum.Align.Right, "${FIN_RptID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_Post.Name, ReportEnum.Align.Left, "${FIN_Post}", ReportEnum.Align.Left, 15)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_RWRem.Name, ReportEnum.Align.Left, "${FIN_RWRem}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WFinRep_DocAttach1Table.FIN_HFIN_ID.Name, ReportEnum.Align.Left, "${FIN_HFIN_ID}", ReportEnum.Align.Left, 17)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = WFinRep_DocAttach1Table.GetRecordCount(joinFilter,whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = WFinRep_DocAttach1Table.GetColumnList()
                Dim records As WFinRep_DocAttach1Record() = Nothing
                Do
                    records = WFinRep_DocAttach1Table.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As WFinRep_DocAttach1Record In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${FIN_Year}", record.Format(WFinRep_DocAttach1Table.FIN_Year), ReportEnum.Align.Right, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.FIN_Month) Then
                                 report.AddData("${FIN_Month}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Month)
                                 _DFKA = WFinRep_DocAttach1Table.GetDFKA(record.FIN_Month.ToString(), WFinRep_DocAttach1Table.FIN_Month,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WFinRep_DocAttach1Table.FIN_Month.IsApplyDisplayAs Then
                                     report.AddData("${FIN_Month}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${FIN_Month}", record.Format(WFinRep_DocAttach1Table.FIN_Month), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${FIN_Type}", record.Format(WFinRep_DocAttach1Table.FIN_Type), ReportEnum.Align.Left, 300)
                             report.AddData("${FIn_Description}", record.Format(WFinRep_DocAttach1Table.FIn_Description), ReportEnum.Align.Left, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.FIN_Company) Then
                                 report.AddData("${FIN_Company}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Company)
                                 _DFKA = WFinRep_DocAttach1Table.GetDFKA(record.FIN_Company.ToString(), WFinRep_DocAttach1Table.FIN_Company,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WFinRep_DocAttach1Table.FIN_Company.IsApplyDisplayAs Then
                                     report.AddData("${FIN_Company}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${FIN_Company}", record.Format(WFinRep_DocAttach1Table.FIN_Company), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             If BaseClasses.Utils.MiscUtils.IsNull(record.FIN_Status) Then
                                 report.AddData("${FIN_Status}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_Status)
                                 _DFKA = WFinRep_DocAttach1Table.GetDFKA(record.FIN_Status.ToString(), WFinRep_DocAttach1Table.FIN_Status,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WFinRep_DocAttach1Table.FIN_Status.IsApplyDisplayAs Then
                                     report.AddData("${FIN_Status}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${FIN_Status}", record.Format(WFinRep_DocAttach1Table.FIN_Status), ReportEnum.Align.Left, 300)
                                 End If
                             End If
                             report.AddData("${FIN_File1}", record.Format(WFinRep_DocAttach1Table.FIN_File1), ReportEnum.Align.Left, 300)
                             report.AddData("${FIN_RptID}", record.Format(WFinRep_DocAttach1Table.FIN_RptID), ReportEnum.Align.Right, 300)
                             report.AddData("${FIN_Post}", record.Format(WFinRep_DocAttach1Table.FIN_Post), ReportEnum.Align.Left, 300)
                             report.AddData("${FIN_RWRem}", record.Format(WFinRep_DocAttach1Table.FIN_RWRem), ReportEnum.Align.Left, 300)
                             If BaseClasses.Utils.MiscUtils.IsNull(record.FIN_HFIN_ID) Then
                                 report.AddData("${FIN_HFIN_ID}", "",ReportEnum.Align.Left, 300)
                             Else 
                                 Dim _isExpandableNonCompositeForeignKey as Boolean
                                 Dim _DFKA as String = ""
                                 _isExpandableNonCompositeForeignKey = WFinRep_DocAttach1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_DocAttach1Table.FIN_HFIN_ID)
                                 _DFKA = WFinRep_DocAttach1Table.GetDFKA(record.FIN_HFIN_ID.ToString(), WFinRep_DocAttach1Table.FIN_HFIN_ID,Nothing)
                                 If _isExpandableNonCompositeForeignKey AndAlso  (not _DFKA  Is Nothing)  AndAlso  WFinRep_DocAttach1Table.FIN_HFIN_ID.IsApplyDisplayAs Then
                                     report.AddData("${FIN_HFIN_ID}", _DFKA,ReportEnum.Align.Left, 300)
                                 Else 
                                     report.AddData("${FIN_HFIN_ID}", record.Format(WFinRep_DocAttach1Table.FIN_HFIN_ID), ReportEnum.Align.Left, 300)
                                 End If
                             End If

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
        Public Overridable Sub Actions2Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Public Overridable Sub FilterButton1_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WFinRep_DocAttach1Table.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WFinRep_DocAttach1Table.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WFinRep_DocAttach1Table.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not WFinRep_DocAttach1Table.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WFinRep_DocAttach1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WFinRep_DocAttach1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub FIN_StatusFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = WFinRep_DocAttach1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRep_DocAttach1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_DocAttach1Record())
            End Get
            Set(ByVal value() As WFinRep_DocAttach1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Actions2Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Actions2Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property ExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property FilterButton1() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FilterButton1"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property Filters2Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Filters2Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property FIN_StatusFilter1() As BaseClasses.Web.UI.WebControls.QuickSelector
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_StatusFilter1"), BaseClasses.Web.UI.WebControls.QuickSelector)
            End Get
        End Property
        
        Public ReadOnly Property FIN_StatusLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FIN_StatusLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Pagination2() As ePortalWFApproval.UI.IPaginationModern
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pagination2"), ePortalWFApproval.UI.IPaginationModern)
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
        
        Public ReadOnly Property SearchButton4() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SearchButton4"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property Title1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_DocAttach1SearchText() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttach1SearchText"), System.Web.UI.WebControls.TextBox)
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
                Dim recCtl As WFinRep_DocAttach1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_DocAttach1Record = Nothing     
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
                Dim recCtl As WFinRep_DocAttach1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_DocAttach1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRep_DocAttach1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRep_DocAttach1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRep_DocAttach1TableControlRow)), WFinRep_DocAttach1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRep_DocAttach1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRep_DocAttach1TableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRep_DocAttach1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRep_DocAttach1TableControlRow")
            Dim list As New List(Of WFinRep_DocAttach1TableControlRow)
            For Each recCtrl As WFinRep_DocAttach1TableControlRow In recCtrls
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

  
' Base class for the WFinRep_Head1TableControlRow control on the FSWF_Inquiry1 page.
' Do not modify this class. Instead override any method in WFinRep_Head1TableControlRow.
Public Class BaseWFinRep_Head1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WFinRep_Head1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WFinRep_Head1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
              AddHandler Me.EditRowButton.Click, AddressOf EditRowButton_Click
                        
              AddHandler Me.ExpandRowButton.Click, AddressOf ExpandRowButton_Click
                        
              AddHandler Me.ViewRowButton.Click, AddressOf ViewRowButton_Click
                        
              AddHandler Me.btnEdit.Button.Click, AddressOf btnEdit_Click
                        
              AddHandler Me.btnGenPDF.Button.Click, AddressOf btnGenPDF_Click
                        
              AddHandler Me.btnPreview1.Button.Click, AddressOf btnPreview1_Click
                        
              AddHandler Me.btnPreview2.Button.Click, AddressOf btnPreview2_Click
                        
              AddHandler Me.HFIN_C_ID1.TextChanged, AddressOf HFIN_C_ID1_TextChanged
            
              AddHandler Me.HFIN_Description1.TextChanged, AddressOf HFIN_Description1_TextChanged
            
              AddHandler Me.HFIN_ID.TextChanged, AddressOf HFIN_ID_TextChanged
            
              AddHandler Me.HFIN_Month1.TextChanged, AddressOf HFIN_Month1_TextChanged
            
              AddHandler Me.HFIN_Status.TextChanged, AddressOf HFIN_Status_TextChanged
            
              AddHandler Me.HFIN_Year1.TextChanged, AddressOf HFIN_Year1_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WFinRep_Head record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WFinRep_Head1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWFinRep_Head1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WFinRep_Head1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WFinRep_Head1TableControlRow.
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
        
                
                
                
                
                
                
                SetHFIN_C_ID()
                SetHFIN_C_ID1()
                SetHFIN_Description()
                SetHFIN_Description1()
                SetHFIN_File()
                SetHFIN_ID()
                SetHFIN_Month()
                SetHFIN_Month1()
                SetHFIN_RptCount()
                SetHFIN_Status()
                SetHFIN_Status1()
                SetHFIN_Year()
                SetHFIN_Year1()
                
                
                
                
                SetWFinRep_Head1TableControlTabContainer()
                SetEditRowButton()
              
                SetExpandRowButton()
              
                SetViewRowButton()
              
                SetbtnEdit()
              
                SetbtnGenPDF()
              
                SetbtnPreview1()
              
                SetbtnPreview2()
              
      
      
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
                      
        SetVw_FS_WFinRep_Attachment_PerReportType1TableControl()
                  
        SetWFinRep_Activity1TableControl()
        
        SetWFinRep_DocAttach1TableControl()
        
        End Sub
        
        
        Public Overridable Sub SetHFIN_C_ID()

                  
            
        
            ' Set the HFIN_C_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then
                				
                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_C_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_C_ID.ToString(),WFinRep_Head1Table.HFIN_C_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_C_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_C_ID.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_C_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_C_ID.Text = WFinRep_Head1Table.HFIN_C_ID.Format(WFinRep_Head1Table.HFIN_C_ID.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_C_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_C_ID.Text Is Nothing _
                OrElse Me.HFIN_C_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_C_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_C_ID1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_C_ID1.ID) Then
            
                Me.HFIN_C_ID1.Text = Me.PreviousUIData(Me.HFIN_C_ID1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_C_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_C_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_C_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_C_IDSpecified Then
                				
                ' If the HFIN_C_ID is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_C_ID)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_C_ID.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_C_ID.ToString(),WFinRep_Head1Table.HFIN_C_ID, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_C_ID)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_C_ID.ToString()
                End If
                                
                Me.HFIN_C_ID1.Text = formattedValue
                
            Else 
            
                ' HFIN_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_C_ID1.Text = WFinRep_Head1Table.HFIN_C_ID.Format(WFinRep_Head1Table.HFIN_C_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_C_ID1.TextChanged, AddressOf HFIN_C_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Description()

                  
            
        
            ' Set the HFIN_Description Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DescriptionSpecified Then
                				
                ' If the HFIN_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Description)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Description.Text = formattedValue
                
            Else 
            
                ' HFIN_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Description.Text = WFinRep_Head1Table.HFIN_Description.Format(WFinRep_Head1Table.HFIN_Description.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Description.Text Is Nothing _
                OrElse Me.HFIN_Description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Description.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Description1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Description1.ID) Then
            
                Me.HFIN_Description1.Text = Me.PreviousUIData(Me.HFIN_Description1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Description TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Description1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Description1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_DescriptionSpecified Then
                				
                ' If the HFIN_Description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Description)
                              
                Me.HFIN_Description1.Text = formattedValue
                
            Else 
            
                ' HFIN_Description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Description1.Text = WFinRep_Head1Table.HFIN_Description.Format(WFinRep_Head1Table.HFIN_Description.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Description1.TextChanged, AddressOf HFIN_Description1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_FileSpecified Then
                
                Me.HFIN_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.HFIN_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WFinRep_Head1") & _
                            "&Field=" & Me.Page.Encrypt("HFIN_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.HFIN_File.Visible = True
            Else
                Me.HFIN_File.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetHFIN_ID()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_ID.ID) Then
            
                Me.HFIN_ID.Text = Me.PreviousUIData(Me.HFIN_ID.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_IDSpecified Then
                				
                ' If the HFIN_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_ID)
                              
                Me.HFIN_ID.Text = formattedValue
                
            Else 
            
                ' HFIN_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_ID.Text = WFinRep_Head1Table.HFIN_ID.Format(WFinRep_Head1Table.HFIN_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_ID.TextChanged, AddressOf HFIN_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Month()

                  
            
        
            ' Set the HFIN_Month Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Month is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Month()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_MonthSpecified Then
                				
                ' If the HFIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_Month.ToString(),WFinRep_Head1Table.HFIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Month.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Month.Text = formattedValue
                
            Else 
            
                ' HFIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Month.Text = WFinRep_Head1Table.HFIN_Month.Format(WFinRep_Head1Table.HFIN_Month.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Month is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Month.Text Is Nothing _
                OrElse Me.HFIN_Month.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Month.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Month1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Month1.ID) Then
            
                Me.HFIN_Month1.Text = Me.PreviousUIData(Me.HFIN_Month1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Month TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Month1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Month1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_MonthSpecified Then
                				
                ' If the HFIN_Month is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Month)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Month.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_Month.ToString(),WFinRep_Head1Table.HFIN_Month, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Month)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Month.ToString()
                End If
                                
                Me.HFIN_Month1.Text = formattedValue
                
            Else 
            
                ' HFIN_Month is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Month1.Text = WFinRep_Head1Table.HFIN_Month.Format(WFinRep_Head1Table.HFIN_Month.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Month1.TextChanged, AddressOf HFIN_Month1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_RptCount()

                  
            
        
            ' Set the HFIN_RptCount Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_RptCount is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_RptCount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_RptCountSpecified Then
                				
                ' If the HFIN_RptCount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_RptCount)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_RptCount.Text = formattedValue
                
            Else 
            
                ' HFIN_RptCount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_RptCount.Text = WFinRep_Head1Table.HFIN_RptCount.Format(WFinRep_Head1Table.HFIN_RptCount.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_RptCount is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_RptCount.Text Is Nothing _
                OrElse Me.HFIN_RptCount.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_RptCount.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Status()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Status.ID) Then
            
                Me.HFIN_Status.Text = Me.PreviousUIData(Me.HFIN_Status.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Status is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_StatusSpecified Then
                				
                ' If the HFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_Status.ToString(),WFinRep_Head1Table.HFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Status.ToString()
                End If
                                
                Me.HFIN_Status.Text = formattedValue
                
            Else 
            
                ' HFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Status.Text = WFinRep_Head1Table.HFIN_Status.Format(WFinRep_Head1Table.HFIN_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Status.TextChanged, AddressOf HFIN_Status_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetHFIN_Status1()

                  
            
        
            ' Set the HFIN_Status Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Status1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Status1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_StatusSpecified Then
                				
                ' If the HFIN_Status is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Status)
                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Status.IsApplyDisplayAs Then
                                  
                       formattedValue = WFinRep_Head1Table.GetDFKA(Me.DataSource.HFIN_Status.ToString(),WFinRep_Head1Table.HFIN_Status, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Status)
                       End If
                Else
                       formattedValue = Me.DataSource.HFIN_Status.ToString()
                End If
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Status1.Text = formattedValue
                
            Else 
            
                ' HFIN_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Status1.Text = WFinRep_Head1Table.HFIN_Status.Format(WFinRep_Head1Table.HFIN_Status.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Status is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Status1.Text Is Nothing _
                OrElse Me.HFIN_Status1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Status1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Year()

                  
            
        
            ' Set the HFIN_Year Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Year is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_YearSpecified Then
                				
                ' If the HFIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Year)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.HFIN_Year.Text = formattedValue
                
            Else 
            
                ' HFIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Year.Text = WFinRep_Head1Table.HFIN_Year.Format(WFinRep_Head1Table.HFIN_Year.DefaultValue)
                        		
                End If
                 
            ' If the HFIN_Year is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.HFIN_Year.Text Is Nothing _
                OrElse Me.HFIN_Year.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.HFIN_Year.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetHFIN_Year1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.HFIN_Year1.ID) Then
            
                Me.HFIN_Year1.Text = Me.PreviousUIData(Me.HFIN_Year1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the HFIN_Year TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WFinRep_Head database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WFinRep_Head record retrieved from the database.
            ' Me.HFIN_Year1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetHFIN_Year1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.HFIN_YearSpecified Then
                				
                ' If the HFIN_Year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WFinRep_Head1Table.HFIN_Year)
                              
                Me.HFIN_Year1.Text = formattedValue
                
            Else 
            
                ' HFIN_Year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.HFIN_Year1.Text = WFinRep_Head1Table.HFIN_Year.Format(WFinRep_Head1Table.HFIN_Year.DefaultValue)
                        		
                End If
                 
              AddHandler Me.HFIN_Year1.TextChanged, AddressOf HFIN_Year1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWFinRep_Head1TableControlTabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "WFinRep_Head1TableControlTabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "WFinRep_Head1TableControlTabContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetVw_FS_WFinRep_Attachment_PerReportType1TableControl()           
        
        
            If Vw_FS_WFinRep_Attachment_PerReportType1TableControl.Visible Then
                Vw_FS_WFinRep_Attachment_PerReportType1TableControl.LoadData()
                Vw_FS_WFinRep_Attachment_PerReportType1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRep_Activity1TableControl()           
        
        
            If WFinRep_Activity1TableControl.Visible Then
                WFinRep_Activity1TableControl.LoadData()
                WFinRep_Activity1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWFinRep_DocAttach1TableControl()           
        
        
            If WFinRep_DocAttach1TableControl.Visible Then
                WFinRep_DocAttach1TableControl.LoadData()
                WFinRep_DocAttach1TableControl.DataBind()
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

      
        
        ' To customize, override this method in WFinRep_Head1TableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "WFinRep_Head1TableControl"), WFinRep_Head1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WFinRep_Head1TableControl"), WFinRep_Head1TableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recVw_FS_WFinRep_Attachment_PerReportType1TableControl as Vw_FS_WFinRep_Attachment_PerReportType1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControl"), Vw_FS_WFinRep_Attachment_PerReportType1TableControl)
        recVw_FS_WFinRep_Attachment_PerReportType1TableControl.SaveData()
          
        Dim recWFinRep_Activity1TableControl as WFinRep_Activity1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl)
        recWFinRep_Activity1TableControl.SaveData()
          
        Dim recWFinRep_DocAttach1TableControl as WFinRep_DocAttach1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttach1TableControl"), WFinRep_DocAttach1TableControl)
        recWFinRep_DocAttach1TableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WFinRep_Head1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetHFIN_C_ID()
            GetHFIN_C_ID1()
            GetHFIN_Description()
            GetHFIN_Description1()
            GetHFIN_ID()
            GetHFIN_Month()
            GetHFIN_Month1()
            GetHFIN_RptCount()
            GetHFIN_Status()
            GetHFIN_Status1()
            GetHFIN_Year()
            GetHFIN_Year1()
        End Sub
        
        
        Public Overridable Sub GetHFIN_C_ID()
            
        End Sub
                
        Public Overridable Sub GetHFIN_C_ID1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Description()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Description1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_ID()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Month()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Month1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_RptCount()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Status()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Status1()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Year()
            
        End Sub
                
        Public Overridable Sub GetHFIN_Year1()
            
        End Sub
                
      
        ' To customize, override this method in WFinRep_Head1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WFinRep_Head1TableControlRow.
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
          WFinRep_Head1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WFinRep_Head1TableControl"), WFinRep_Head1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WFinRep_Head1TableControl"), WFinRep_Head1TableControl).ResetData = True
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
        
        Public Overridable Sub SetEditRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetExpandRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetViewRowButton()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnEdit()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnGenPDF()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnPreview1()                
              
   
        End Sub
            
        Public Overridable Sub SetbtnPreview2()                
              
   
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub EditRowButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../WFinRep_Head/Edit-WFinRep-Head.aspx?WFinRep_Head={PK}"
                  
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
    
          Dim panelControl as WFinRep_Head1TableControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WFinRep_Head1TableControl"), WFinRep_Head1TableControl)

          Dim repeatedRows() as WFinRep_Head1TableControlRow = panelControl.GetRecordControls()
          For Each repeatedRow as WFinRep_Head1TableControlRow in repeatedRows
              Dim altRow as System.Web.UI.Control= DirectCast(MiscUtils.FindControlRecursively(repeatedRow, "WFinRep_Head1TableControlAltRow"), System.Web.UI.Control)
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
        
        ' event handler for Button
        Public Overridable Sub btnEdit_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnGenPDF_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnPreview1_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub btnPreview2_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        Protected Overridable Sub HFIN_C_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Description1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Month1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Status_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub HFIN_Year1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseWFinRep_Head1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWFinRep_Head1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WFinRep_Head1Record
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Head1Record)
            End Get
            Set(ByVal value As WFinRep_Head1Record)
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
        
        Public ReadOnly Property btnEdit() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnEdit"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property btnGenPDF() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnGenPDF"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property btnPreview1() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnPreview1"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property btnPreview2() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnPreview2"), ePortalWFApproval.UI.IThemeButton)
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
        
        Public ReadOnly Property HFIN_C_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_C_ID1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_ID1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Description1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Description1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Month() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Month"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Month1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Month1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_RptCount() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RptCount"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Status() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Status"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Status1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Status1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Year() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Year"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property HFIN_Year1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_Year1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ViewRowButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ViewRowButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Vw_FS_WFinRep_Attachment_PerReportType1TableControl() As Vw_FS_WFinRep_Attachment_PerReportType1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Vw_FS_WFinRep_Attachment_PerReportType1TableControl"), Vw_FS_WFinRep_Attachment_PerReportType1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_Activity1TableControl() As WFinRep_Activity1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Activity1TableControl"), WFinRep_Activity1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_DocAttach1TableControl() As WFinRep_DocAttach1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_DocAttach1TableControl"), WFinRep_DocAttach1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_Head1TableControlTabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Head1TableControlTabContainer"), AjaxControlToolkit.TabContainer)
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
            
            Dim rec As WFinRep_Head1Record = Nothing
             
        
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
            
            Dim rec As WFinRep_Head1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WFinRep_Head1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WFinRep_Head1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WFinRep_Head1TableControl control on the FSWF_Inquiry1 page.
' Do not modify this class. Instead override any method in WFinRep_Head1TableControl.
Public Class BaseWFinRep_Head1TableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl

        
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      
    
           ' Setup the filter and search.
        
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
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HFIN_MonthFilter1) 				
                    initialVal = Me.GetFromSession(Me.HFIN_MonthFilter1)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""HFIN_Month"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.HFIN_MonthFilter1.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.HFIN_MonthFilter1.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HFIN_StatusFilter2) 				
                    initialVal = Me.GetFromSession(Me.HFIN_StatusFilter2)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""HFIN_Status"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.HFIN_StatusFilter2.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.HFIN_StatusFilter2.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HFIN_YearFromFilter1) 				
                    initialVal = Me.GetFromSession(Me.HFIN_YearFromFilter1)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""HFIN_YearFrom"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.HFIN_YearFromFilter1.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.HFIN_YearFromFilter1.SelectedValue = initialVal
                            
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
            
              AddHandler Me.WFinRep_HeadPagination.FirstPage.Click, AddressOf WFinRep_HeadPagination_FirstPage_Click
                        
              AddHandler Me.WFinRep_HeadPagination.LastPage.Click, AddressOf WFinRep_HeadPagination_LastPage_Click
                        
              AddHandler Me.WFinRep_HeadPagination.NextPage.Click, AddressOf WFinRep_HeadPagination_NextPage_Click
                        
              AddHandler Me.WFinRep_HeadPagination.PageSizeButton.Click, AddressOf WFinRep_HeadPagination_PageSizeButton_Click
                        
              AddHandler Me.WFinRep_HeadPagination.PreviousPage.Click, AddressOf WFinRep_HeadPagination_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.WFinRep_HeadFilterButton.Button.Click, AddressOf WFinRep_HeadFilterButton_Click
                        
              AddHandler Me.HFIN_C_IDFilter1.SelectedIndexChanged, AddressOf HFIN_C_IDFilter1_SelectedIndexChanged
            
              AddHandler Me.HFIN_MonthFilter1.SelectedIndexChanged, AddressOf HFIN_MonthFilter1_SelectedIndexChanged
            
              AddHandler Me.HFIN_StatusFilter2.SelectedIndexChanged, AddressOf HFIN_StatusFilter2_SelectedIndexChanged
            
              AddHandler Me.HFIN_YearFromFilter1.SelectedIndexChanged, AddressOf HFIN_YearFromFilter1_SelectedIndexChanged
                    
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WFinRep_Head1Record)), WFinRep_Head1Record())
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
                    For Each rc As WFinRep_Head1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WFinRep_Head1Record)), WFinRep_Head1Record())
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
            ByVal pageSize As Integer) As WFinRep_Head1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_Head1Table.Column1, True)         
            ' selCols.Add(WFinRep_Head1Table.Column2, True)          
            ' selCols.Add(WFinRep_Head1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WFinRep_Head1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WFinRep_Head1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WFinRep_Head1Record)), WFinRep_Head1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WFinRep_Head1Table.Column1, True)         
            ' selCols.Add(WFinRep_Head1Table.Column2, True)          
            ' selCols.Add(WFinRep_Head1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WFinRep_Head1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WFinRep_Head1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Head1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WFinRep_Head1TableControlRow = DirectCast(repItem.FindControl("WFinRep_Head1TableControlRow"), WFinRep_Head1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                SetHFIN_C_IDFilter1()
                SetHFIN_C_IDLabel()
                SetHFIN_C_IDLabel1()
                SetHFIN_DescriptionLabel()
                SetHFIN_MonthFilter1()
                SetHFIN_MonthLabel()
                SetHFIN_MonthLabel1()
                SetHFIN_RptCountLabel()
                SetHFIN_StatusFilter2()
                SetHFIN_StatusLabel()
                SetHFIN_StatusLabel1()
                SetHFIN_YearFromFilter1()
                SetHFIN_YearLabel()
                SetHFIN_YearLabel1()
                
                
                
                
                
                
                SetWFinRep_HeadFilterButton()
              
            ' setting the state of expand or collapse alternative rows
      
            Dim expandFirstRow As Boolean= False   
        
            Dim recControls() As WFinRep_Head1TableControlRow = Me.GetRecordControls()
            For i As Integer = 0 to recControls.Length - 1
                Dim altRow As System.Web.UI.Control = DirectCast(MiscUtils.FindControlRecursively(recControls(i), "WFinRep_Head1TableControlAltRow"), System.Web.UI.Control)
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
            
                    
            
      End Sub
      
        Public Overridable Sub SetFormulaControls()
            ' this method calls Set methods for the control that has special formula
        
        

    End Sub

    
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_C_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_C_ID, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_Month, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_Status, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(WFinRep_Head1Table.HFIN_Status, Me.DataSource)
          
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

            
            Me.HFIN_C_IDFilter1.ClearSelection()
            
            Me.HFIN_MonthFilter1.ClearSelection()
            
            Me.HFIN_StatusFilter2.ClearSelection()
            
            Me.HFIN_YearFromFilter1.ClearSelection()
            
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
                    
                Me.WFinRep_HeadPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.WFinRep_HeadPagination.CurrentPage.Text = "0"
            End If
            Me.WFinRep_HeadPagination.PageSize.Text = Me.PageSize.ToString()
            Me.WFinRep_HeadPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.WFinRep_HeadPagination.TotalPages.Text = Me.TotalPages.ToString()

            ' Bind the buttons for WFinRep_Head1TableControl pagination.
        
            Me.WFinRep_HeadPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.WFinRep_HeadPagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.WFinRep_HeadPagination.LastPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.WFinRep_HeadPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.WFinRep_HeadPagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.WFinRep_HeadPagination.NextPage.Enabled = False            
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.WFinRep_HeadPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If
          
            Me.WFinRep_HeadPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)


        End Sub

   
    
        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As WFinRep_Head1TableControlRow
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
            WFinRep_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
      
        Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.HFIN_C_IDFilter1) Then
    
              hasFiltersWFinRep_Head1TableControl = True            
    
                wc.iAND(WFinRep_Head1Table.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_C_IDFilter1, Me.GetFromSession(Me.HFIN_C_IDFilter1)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.HFIN_MonthFilter1) Then
    
              hasFiltersWFinRep_Head1TableControl = True            
    
                wc.iAND(WFinRep_Head1Table.HFIN_Month, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_MonthFilter1, Me.GetFromSession(Me.HFIN_MonthFilter1)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.HFIN_StatusFilter2) Then
    
              hasFiltersWFinRep_Head1TableControl = True            
    
                wc.iAND(WFinRep_Head1Table.HFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.HFIN_StatusFilter2, Me.GetFromSession(Me.HFIN_StatusFilter2)), False, False)
            
            End If
                  
                
                       
            If IsValueSelected(Me.HFIN_YearFromFilter1) Then
    
              hasFiltersWFinRep_Head1TableControl = True            
    
                wc.iAND(WFinRep_Head1Table.HFIN_Year, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, MiscUtils.GetSelectedValue(Me.HFIN_YearFromFilter1, Me.GetFromSession(Me.HFIN_YearFromFilter1)), False, False)
            
            End If
                  
                
                       
            Dim bAnyFiltersChanged As Boolean = False
            
            If IsValueSelected(Me.HFIN_C_IDFilter1) OrElse Me.InSession(Me.HFIN_C_IDFilter1) Then
                bAnyFiltersChanged = True
            End If
            
            If IsValueSelected(Me.HFIN_MonthFilter1) OrElse Me.InSession(Me.HFIN_MonthFilter1) Then
                bAnyFiltersChanged = True
            End If
            
            If IsValueSelected(Me.HFIN_StatusFilter2) OrElse Me.InSession(Me.HFIN_StatusFilter2) Then
                bAnyFiltersChanged = True
            End If
            
            If IsValueSelected(Me.HFIN_YearFromFilter1) OrElse Me.InSession(Me.HFIN_YearFromFilter1) Then
                bAnyFiltersChanged = True
            End If
            
            If Not(bAnyFiltersChanged) Then
                wc.RunQuery = False
            End If 
          
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            WFinRep_Head1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
        
          Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim HFIN_C_IDFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_C_IDFilter1_Ajax"), String)
            If IsValueSelected(HFIN_C_IDFilter1SelectedValue) Then
    
              hasFiltersWFinRep_Head1TableControl = True            
    
                 wc.iAND(WFinRep_Head1Table.HFIN_C_ID, BaseFilter.ComparisonOperator.EqualsTo, HFIN_C_IDFilter1SelectedValue, false, False)
             
             End If
                      
            Dim HFIN_MonthFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_MonthFilter1_Ajax"), String)
            If IsValueSelected(HFIN_MonthFilter1SelectedValue) Then
    
              hasFiltersWFinRep_Head1TableControl = True            
    
                 wc.iAND(WFinRep_Head1Table.HFIN_Month, BaseFilter.ComparisonOperator.EqualsTo, HFIN_MonthFilter1SelectedValue, false, False)
             
             End If
                      
            Dim HFIN_StatusFilter2SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_StatusFilter2_Ajax"), String)
            If IsValueSelected(HFIN_StatusFilter2SelectedValue) Then
    
              hasFiltersWFinRep_Head1TableControl = True            
    
                 wc.iAND(WFinRep_Head1Table.HFIN_Status, BaseFilter.ComparisonOperator.EqualsTo, HFIN_StatusFilter2SelectedValue, false, False)
             
             End If
                      
            Dim HFIN_YearFromFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "HFIN_YearFromFilter1_Ajax"), String)
            If IsValueSelected(HFIN_YearFromFilter1SelectedValue) Then
    
              hasFiltersWFinRep_Head1TableControl = True            
    
                 wc.iAND(WFinRep_Head1Table.HFIN_Year, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, HFIN_YearFromFilter1SelectedValue, false, False)
             
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
        
            If Me.WFinRep_HeadPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.WFinRep_HeadPagination.PageSize.Text)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_Head1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WFinRep_Head1TableControlRow = DirectCast(repItem.FindControl("WFinRep_Head1TableControlRow"), WFinRep_Head1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WFinRep_Head1Record = New WFinRep_Head1Record()
        
                        If recControl.HFIN_C_ID.Text <> "" Then
                            rec.Parse(recControl.HFIN_C_ID.Text, WFinRep_Head1Table.HFIN_C_ID)
                        End If
                        If recControl.HFIN_C_ID1.Text <> "" Then
                            rec.Parse(recControl.HFIN_C_ID1.Text, WFinRep_Head1Table.HFIN_C_ID)
                        End If
                        If recControl.HFIN_Description.Text <> "" Then
                            rec.Parse(recControl.HFIN_Description.Text, WFinRep_Head1Table.HFIN_Description)
                        End If
                        If recControl.HFIN_Description1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Description1.Text, WFinRep_Head1Table.HFIN_Description)
                        End If
                        If recControl.HFIN_File.Text <> "" Then
                            rec.Parse(recControl.HFIN_File.Text, WFinRep_Head1Table.HFIN_File)
                        End If
                        If recControl.HFIN_ID.Text <> "" Then
                            rec.Parse(recControl.HFIN_ID.Text, WFinRep_Head1Table.HFIN_ID)
                        End If
                        If recControl.HFIN_Month.Text <> "" Then
                            rec.Parse(recControl.HFIN_Month.Text, WFinRep_Head1Table.HFIN_Month)
                        End If
                        If recControl.HFIN_Month1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Month1.Text, WFinRep_Head1Table.HFIN_Month)
                        End If
                        If recControl.HFIN_RptCount.Text <> "" Then
                            rec.Parse(recControl.HFIN_RptCount.Text, WFinRep_Head1Table.HFIN_RptCount)
                        End If
                        If recControl.HFIN_Status.Text <> "" Then
                            rec.Parse(recControl.HFIN_Status.Text, WFinRep_Head1Table.HFIN_Status)
                        End If
                        If recControl.HFIN_Status1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Status1.Text, WFinRep_Head1Table.HFIN_Status)
                        End If
                        If recControl.HFIN_Year.Text <> "" Then
                            rec.Parse(recControl.HFIN_Year.Text, WFinRep_Head1Table.HFIN_Year)
                        End If
                        If recControl.HFIN_Year1.Text <> "" Then
                            rec.Parse(recControl.HFIN_Year1.Text, WFinRep_Head1Table.HFIN_Year)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WFinRep_Head1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WFinRep_Head1Record)), WFinRep_Head1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WFinRep_Head1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WFinRep_Head1TableControlRow) As Boolean
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
        
        Public Overridable Sub SetHFIN_C_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_C_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_C_IDLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_C_IDLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_DescriptionLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_DescriptionLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_MonthLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_MonthLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_MonthLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_MonthLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_RptCountLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_RptCountLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_StatusLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_StatusLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_YearLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_YearLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_YearLabel1()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.HFIN_YearLabel1.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetHFIN_C_IDFilter1()

              
            
                Me.PopulateHFIN_C_IDFilter1(GetSelectedValue(Me.HFIN_C_IDFilter1,  GetFromSession(Me.HFIN_C_IDFilter1)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetHFIN_MonthFilter1()

              
            
                Me.PopulateHFIN_MonthFilter1(GetSelectedValue(Me.HFIN_MonthFilter1,  GetFromSession(Me.HFIN_MonthFilter1)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetHFIN_StatusFilter2()

              
            
                Me.PopulateHFIN_StatusFilter2(GetSelectedValue(Me.HFIN_StatusFilter2,  GetFromSession(Me.HFIN_StatusFilter2)), 500)					
                                     
              End Sub	
            
        Public Overridable Sub SetHFIN_YearFromFilter1()

              
            
                Me.PopulateHFIN_YearFromFilter1(GetSelectedValue(Me.HFIN_YearFromFilter1,  GetFromSession(Me.HFIN_YearFromFilter1)), 500)					
                                     
              End Sub	
            
        ' Get the filters' data for HFIN_C_IDFilter1
        Protected Overridable Sub PopulateHFIN_C_IDFilter1(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_C_IDFilter1.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_C_IDFilter1()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_C_IDFilter1 function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_C_IDFilter1.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            

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
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_C_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_C_ID.IsApplyDisplayAs Then
                                    fvalue = WFinRep_Head1Table.GetDFKA(itemValue, WFinRep_Head1Table.HFIN_C_ID)
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
            
        ' Get the filters' data for HFIN_MonthFilter1
        Protected Overridable Sub PopulateHFIN_MonthFilter1(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_MonthFilter1.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_MonthFilter1()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_MonthFilter1 function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_MonthFilter1.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Vw_WFinRep_DocAttach_FIN_Month1View.Mo, OrderByItem.OrderDir.Asc)
              orderBy.Add(Vw_WFinRep_DocAttach_FIN_Month1View.MoName, OrderByItem.OrderDir.Asc)

            Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)

            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ePortalWFApproval")
            

            Dim itemValues() As Vw_WFinRep_DocAttach_FIN_Month1Record = Nothing
            
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim evaluator As New FormulaEvaluator
                Dim listDuplicates As New ArrayList()

                
                
                Do
                    
                    itemValues = Vw_WFinRep_DocAttach_FIN_Month1View.GetRecords(wc, orderBy, pageNum, maxItems)
                                    
                    For each itemValue As Vw_WFinRep_DocAttach_FIN_Month1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.MoSpecified Then
                            cvalue = itemValue.Mo.ToString()

                            If counter < maxItems AndAlso Me.HFIN_MonthFilter1.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Month)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Month.IsApplyDisplayAs Then
                                    fvalue = WFinRep_Head1Table.GetDFKA(itemValue, WFinRep_Head1Table.HFIN_Month)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                    fvalue = itemValue.Format(Vw_WFinRep_DocAttach_FIN_Month1View.Mo)
                                End If
                                    
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                   fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.HFIN_MonthFilter1.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_MonthFilter1.Items.Add(newItem)

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
                SetSelectedValue(Me.HFIN_MonthFilter1, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.HFIN_MonthFilter1.SelectedValue IsNot Nothing AndAlso Me.HFIN_MonthFilter1.Items.FindByValue(Me.HFIN_MonthFilter1.SelectedValue) Is Nothing
                Me.HFIN_MonthFilter1.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for HFIN_StatusFilter2
        Protected Overridable Sub PopulateHFIN_StatusFilter2(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_StatusFilter2.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_StatusFilter2()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_StatusFilter2 function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_StatusFilter2.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            

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

                            If counter < maxItems AndAlso Me.HFIN_StatusFilter2.Items.FindByValue(cvalue) Is Nothing  Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WFinRep_Head1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WFinRep_Head1Table.HFIN_Status)
                                If _isExpandableNonCompositeForeignKey AndAlso WFinRep_Head1Table.HFIN_Status.IsApplyDisplayAs Then
                                    fvalue = WFinRep_Head1Table.GetDFKA(itemValue, WFinRep_Head1Table.HFIN_Status)
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

                                Dim dupItem As ListItem = Me.HFIN_StatusFilter2.Items.FindByText(fvalue)
                
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.HFIN_StatusFilter2.Items.Add(newItem)

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
                SetSelectedValue(Me.HFIN_StatusFilter2, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.HFIN_StatusFilter2.SelectedValue IsNot Nothing AndAlso Me.HFIN_StatusFilter2.Items.FindByValue(Me.HFIN_StatusFilter2.SelectedValue) Is Nothing
                Me.HFIN_StatusFilter2.SelectedValue = Nothing
            End If            
                          
        End Sub
            
        ' Get the filters' data for HFIN_YearFromFilter1
        Protected Overridable Sub PopulateHFIN_YearFromFilter1(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Me.HFIN_YearFromFilter1.Items.Clear()
            Dim wc As WhereClause = Me.CreateWhereClause_HFIN_YearFromFilter1()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_HFIN_YearFromFilter1 function.
            ' It is better to customize the where clause there.
            
            ' Setup the static list items        
            
            ' Add the Please Select item.
            Me.HFIN_YearFromFilter1.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(WFinRep_Head1Table.HFIN_Year, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = WFinRep_Head1Table.GetValues(WFinRep_Head1Table.HFIN_Year, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( WFinRep_Head1Table.HFIN_Year.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = WFinRep_Head1Table.HFIN_Year.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.HFIN_YearFromFilter1.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.HFIN_YearFromFilter1.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
                ' Set the selected value.
                SetSelectedValue(Me.HFIN_YearFromFilter1, selectedValue)
                    
            Catch
            End Try
            
                        
            If Me.HFIN_YearFromFilter1.SelectedValue IsNot Nothing AndAlso Me.HFIN_YearFromFilter1.Items.FindByValue(Me.HFIN_YearFromFilter1.SelectedValue) Is Nothing
                Me.HFIN_YearFromFilter1.SelectedValue = Nothing
            End If            
                          
        End Sub
            
              

        Public Overridable Function CreateWhereClause_HFIN_C_IDFilter1() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_C_IDFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_C_IDFilter1DropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_HFIN_MonthFilter1() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_MonthFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_MonthFilter1DropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_HFIN_StatusFilter2() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_StatusFilter2.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_StatusFilter2DropDownList
            
            Dim wc As WhereClause= New WhereClause()
            Return wc
            
        End Function			
            
              

        Public Overridable Function CreateWhereClause_HFIN_YearFromFilter1() As WhereClause
          
              Dim hasFiltersVw_FS_WFinRep_Attachment_PerReportType1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Activity1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_DocAttach1TableControl As Boolean = False
            
              Dim hasFiltersWFinRep_Head1TableControl As Boolean = False
            
            ' Create a where clause for the filter HFIN_YearFromFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the HFIN_YearFromFilter1DropDownList
            
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
        
            Me.SaveToSession(Me.HFIN_C_IDFilter1, Me.HFIN_C_IDFilter1.SelectedValue)
                  
            Me.SaveToSession(Me.HFIN_MonthFilter1, Me.HFIN_MonthFilter1.SelectedValue)
                  
            Me.SaveToSession(Me.HFIN_StatusFilter2, Me.HFIN_StatusFilter2.SelectedValue)
                  
            Me.SaveToSession(Me.HFIN_YearFromFilter1, Me.HFIN_YearFromFilter1.SelectedValue)
                  
        
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
          
      Me.SaveToSession("HFIN_C_IDFilter1_Ajax", Me.HFIN_C_IDFilter1.SelectedValue)
              
      Me.SaveToSession("HFIN_MonthFilter1_Ajax", Me.HFIN_MonthFilter1.SelectedValue)
              
      Me.SaveToSession("HFIN_StatusFilter2_Ajax", Me.HFIN_StatusFilter2.SelectedValue)
              
      Me.SaveToSession("HFIN_YearFromFilter1_Ajax", Me.HFIN_YearFromFilter1.SelectedValue)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.HFIN_C_IDFilter1)
            Me.RemoveFromSession(Me.HFIN_MonthFilter1)
            Me.RemoveFromSession(Me.HFIN_StatusFilter2)
            Me.RemoveFromSession(Me.HFIN_YearFromFilter1)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WFinRep_Head1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WFinRep_Head1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
            
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
    
            ' Load view state for pagination control.
          
    
            Return MyBase.SaveViewState()
        End Function
        
        ' Generate set method for buttons
        
        Public Overridable Sub SetWFinRep_HeadFilterButton()                
              
   
        End Sub
                    

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub WFinRep_HeadPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub WFinRep_HeadPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub WFinRep_HeadPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub WFinRep_HeadPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Me.DataChanged = True
      
            Me.PageSize = Me.WFinRep_HeadPagination.GetCurrentPageSize()
      
            Me.PageIndex = Integer.Parse(Me.WFinRep_HeadPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub WFinRep_HeadPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
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
        Public Overridable Sub WFinRep_HeadFilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Protected Overridable Sub HFIN_C_IDFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub HFIN_MonthFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub HFIN_StatusFilter2_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	                   
              
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub HFIN_YearFromFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = WFinRep_Head1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WFinRep_Head1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WFinRep_Head1Record())
            End Get
            Set(ByVal value() As WFinRep_Head1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property HFIN_C_IDFilter1() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDFilter1"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_C_IDLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_C_IDLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_DescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_DescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_MonthFilter1() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_MonthFilter1"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_MonthLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_MonthLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_MonthLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_MonthLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_RptCountLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_RptCountLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_StatusFilter2() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_StatusFilter2"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_StatusLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_StatusLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_YearFromFilter1() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_YearFromFilter1"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_YearLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_YearLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HFIN_YearLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HFIN_YearLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WFinRep_HeadFilterButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadFilterButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property WFinRep_HeadPagination() As ePortalWFApproval.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadPagination"), ePortalWFApproval.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property WFinRep_HeadTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WFinRep_HeadTitle"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WFinRep_Head1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_Head1Record = Nothing     
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
                Dim recCtl As WFinRep_Head1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WFinRep_Head1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WFinRep_Head1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WFinRep_Head1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WFinRep_Head1TableControlRow)), WFinRep_Head1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WFinRep_Head1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WFinRep_Head1TableControlRow
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

        Public Overridable Function GetRecordControls() As WFinRep_Head1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WFinRep_Head1TableControlRow")
            Dim list As New List(Of WFinRep_Head1TableControlRow)
            For Each recCtrl As WFinRep_Head1TableControlRow In recCtrls
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

  