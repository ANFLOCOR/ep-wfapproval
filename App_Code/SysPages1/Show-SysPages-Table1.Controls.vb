
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Show_SysPages_Table1.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.Show_SysPages_Table1

#Region "Section 1: Place your customizations here."

    
Public Class SysPages1TableControlRow
        Inherits BaseSysPages1TableControlRow
        ' The BaseSysPages1TableControlRow implements code for a ROW within the
        ' the SysPages1TableControl table.  The BaseSysPages1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of SysPages1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class SysPages1TableControl
        Inherits BaseSysPages1TableControl

    ' The BaseSysPages1TableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The SysPages1TableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the SysPages1TableControlRow control on the Show_SysPages_Table1 page.
' Do not modify this class. Instead override any method in SysPages1TableControlRow.
Public Class BaseSysPages1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in SysPages1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in SysPages1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Show confirmation message on Click
              Me.DeleteRowButton.Attributes.Add("onClick", "return (confirm(""" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ePortalWFApproval") & """));")
                  
        
              ' Register the event handlers.
          
              AddHandler Me.DeleteRowButton.Click, AddressOf DeleteRowButton_Click
                        
              AddHandler Me.EditRowButton.Click, AddressOf EditRowButton_Click
                        
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseGPEXTD%dbo.SysPages record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = SysPages1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSysPages1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New SysPages1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in SysPages1TableControlRow.
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
        
                SetChecked0()
                SetCheckedLabel()
                SetDateCreated()
                SetDateCreatedLabel()
                
                
                SetisDisplay()
                SetisDisplayLabel()
                SetLevel()
                SetLevelLabel()
                SetPageName()
                SetPageNameLabel()
                SetParentID()
                SetParentIDLabel()
                SetSorting()
                SetSortingLabel()
                SetSystemID()
                SetSystemIDLabel()
                SetURL()
                SetURLLabel()
                SetDeleteRowButton()
              
                SetEditRowButton()
              
      
      
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
        
        
        Public Overridable Sub SetChecked0()

                  
            
        
            ' Set the Checked Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.Checked0 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetChecked0()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.Checked0Specified Then
                				
                ' If the Checked is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.Checked0)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Checked0.Text = formattedValue
                
            Else 
            
                ' Checked is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Checked0.Text = SysPages1Table.Checked0.Format(SysPages1Table.Checked0.DefaultValue)
                        		
                End If
                 
            ' If the Checked is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Checked0.Text Is Nothing _
                OrElse Me.Checked0.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Checked0.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetDateCreated()

                  
            
        
            ' Set the DateCreated Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.DateCreated is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetDateCreated()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.DateCreatedSpecified Then
                				
                ' If the DateCreated is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.DateCreated, "g")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.DateCreated.Text = formattedValue
                
            Else 
            
                ' DateCreated is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.DateCreated.Text = SysPages1Table.DateCreated.Format(SysPages1Table.DateCreated.DefaultValue, "g")
                        		
                End If
                 
            ' If the DateCreated is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.DateCreated.Text Is Nothing _
                OrElse Me.DateCreated.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.DateCreated.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetisDisplay()

                  
            
        
            ' Set the isDisplay Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.isDisplay is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetisDisplay()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.isDisplaySpecified Then
                				
                ' If the isDisplay is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.isDisplay)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.isDisplay.Text = formattedValue
                
            Else 
            
                ' isDisplay is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.isDisplay.Text = SysPages1Table.isDisplay.Format(SysPages1Table.isDisplay.DefaultValue)
                        		
                End If
                 
            ' If the isDisplay is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.isDisplay.Text Is Nothing _
                OrElse Me.isDisplay.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.isDisplay.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetLevel()

                  
            
        
            ' Set the Level Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.Level is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetLevel()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.LevelSpecified Then
                				
                ' If the Level is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.Level)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Level.Text = formattedValue
                
            Else 
            
                ' Level is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Level.Text = SysPages1Table.Level.Format(SysPages1Table.Level.DefaultValue)
                        		
                End If
                 
            ' If the Level is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Level.Text Is Nothing _
                OrElse Me.Level.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Level.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetPageName()

                  
            
        
            ' Set the PageName Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.PageName is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetPageName()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.PageNameSpecified Then
                				
                ' If the PageName is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.PageName)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.PageName.Text = formattedValue
                
            Else 
            
                ' PageName is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.PageName.Text = SysPages1Table.PageName.Format(SysPages1Table.PageName.DefaultValue)
                        		
                End If
                 
            ' If the PageName is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.PageName.Text Is Nothing _
                OrElse Me.PageName.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.PageName.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetParentID()

                  
            
        
            ' Set the ParentID Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.ParentID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetParentID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ParentIDSpecified Then
                				
                ' If the ParentID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.ParentID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ParentID.Text = formattedValue
                
            Else 
            
                ' ParentID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.ParentID.Text = SysPages1Table.ParentID.Format(SysPages1Table.ParentID.DefaultValue)
                        		
                End If
                 
            ' If the ParentID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ParentID.Text Is Nothing _
                OrElse Me.ParentID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ParentID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetSorting()

                  
            
        
            ' Set the Sorting Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.Sorting is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSorting()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SortingSpecified Then
                				
                ' If the Sorting is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.Sorting)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.Sorting.Text = formattedValue
                
            Else 
            
                ' Sorting is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Sorting.Text = SysPages1Table.Sorting.Format(SysPages1Table.Sorting.DefaultValue)
                        		
                End If
                 
            ' If the Sorting is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.Sorting.Text Is Nothing _
                OrElse Me.Sorting.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.Sorting.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetSystemID()

                  
            
        
            ' Set the SystemID Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.SystemID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetSystemID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.SystemIDSpecified Then
                				
                ' If the SystemID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.SystemID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.SystemID.Text = formattedValue
                
            Else 
            
                ' SystemID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.SystemID.Text = SysPages1Table.SystemID.Format(SysPages1Table.SystemID.DefaultValue)
                        		
                End If
                 
            ' If the SystemID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.SystemID.Text Is Nothing _
                OrElse Me.SystemID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.SystemID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetURL()

                  
            
        
            ' Set the URL Literal on the webpage with value from the
            ' DatabaseGPEXTD%dbo.SysPages database record.

            ' Me.DataSource is the DatabaseGPEXTD%dbo.SysPages record retrieved from the database.
            ' Me.URL is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetURL()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.URLSpecified Then
                				
                ' If the URL is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(SysPages1Table.URL)
                              
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
                      
                        Dim name As String = HttpUtility.HtmlEncode(SysPages1Table.URL.Name)

                        If Not HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%") Then
                           name = HttpUtility.HtmlEncode(Me.Page.GetResourceValue("%ISD_DEFAULT%"))
                        End If

                        

                        formattedValue= "<a onclick='gPersist=true;' class='truncatedText' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ePortalWFApproval.Business.SysPages1Table, App_Code\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""URL\"", \""URL\"", \""" & NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) & "\"", \""" & Page.GetResourceValue("Btn:Close", "ePortalWFApproval") & "\"", false, 200," _
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
                
                Me.URL.Text = formattedValue
                
            Else 
            
                ' URL is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.URL.Text = SysPages1Table.URL.Format(SysPages1Table.URL.DefaultValue)
                        		
                End If
                 
            ' If the URL is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.URL.Text Is Nothing _
                OrElse Me.URL.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.URL.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetCheckedLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetDateCreatedLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetisDisplayLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLevelLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetPageNameLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetParentIDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortingLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSystemIDLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetURLLabel()

                  
                  
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

      
        
        ' To customize, override this method in SysPages1TableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "SysPages1TableControl"), SysPages1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "SysPages1TableControl"), SysPages1TableControl).ResetData = True
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

        ' To customize, override this method in SysPages1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetChecked0()
            GetDateCreated()
            GetisDisplay()
            GetLevel()
            GetPageName()
            GetParentID()
            GetSorting()
            GetSystemID()
            GetURL()
        End Sub
        
        
        Public Overridable Sub GetChecked0()
            
        End Sub
                
        Public Overridable Sub GetDateCreated()
            
        End Sub
                
        Public Overridable Sub GetisDisplay()
            
        End Sub
                
        Public Overridable Sub GetLevel()
            
        End Sub
                
        Public Overridable Sub GetPageName()
            
        End Sub
                
        Public Overridable Sub GetParentID()
            
        End Sub
                
        Public Overridable Sub GetSorting()
            
        End Sub
                
        Public Overridable Sub GetSystemID()
            
        End Sub
                
        Public Overridable Sub GetURL()
            
        End Sub
                
      
        ' To customize, override this method in SysPages1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSysPages1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in SysPages1TableControlRow.
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
          SysPages1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "SysPages1TableControl"), SysPages1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "SysPages1TableControl"), SysPages1TableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseSysPages1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSysPages1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As SysPages1Record
            Get
                Return DirectCast(MyBase._DataSource, SysPages1Record)
            End Get
            Set(ByVal value As SysPages1Record)
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
        
        Public ReadOnly Property Checked0() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Checked0"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property CheckedLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CheckedLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property DateCreated() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DateCreated"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property DateCreatedLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "DateCreatedLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
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
        
        Public ReadOnly Property isDisplay() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "isDisplay"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property isDisplayLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "isDisplayLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Level() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Level"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property LevelLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "LevelLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property PageName() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PageName"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property PageNameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PageNameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ParentID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ParentID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ParentIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ParentIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Sorting() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sorting"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SortingLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SortingLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property SystemID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SystemID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SystemIDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SystemIDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property URL() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "URL"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property URLLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "URLLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As SysPages1Record = Nothing
             
        
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
            
            Dim rec As SysPages1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As SysPages1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return SysPages1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the SysPages1TableControl control on the Show_SysPages_Table1 page.
' Do not modify this class. Instead override any method in SysPages1TableControl.
Public Class BaseSysPages1TableControl
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
                If  Me.InSession(Me.PageNameFilter) 				
                    initialVal = Me.GetFromSession(Me.PageNameFilter)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""PageName"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Dim PageNameFilteritemListFromSession() As String = initialVal.Split(","c)
                        Dim index As Integer = 0
                        For Each item As String In PageNameFilteritemListFromSession
                            If index = 0 AndAlso _
                               item.ToString.Equals("") Then
                            Else
                                Me.PageNameFilter.Items.Add(item)
                                Me.PageNameFilter.Items.Item(index).Selected = True
                                index += 1
                            End If
                        Next
                        Dim listItem As ListItem
                        For Each listItem In Me.PageNameFilter.Items
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
                        
              AddHandler Me.ImportButton.Click, AddressOf ImportButton_Click
                        
              AddHandler Me.NewButton.Click, AddressOf NewButton_Click
                        
              AddHandler Me.PDFButton.Click, AddressOf PDFButton_Click
                        
              AddHandler Me.ResetButton.Click, AddressOf ResetButton_Click
                        
              AddHandler Me.SearchButton.Click, AddressOf SearchButton_Click
                        
              AddHandler Me.WordButton.Click, AddressOf WordButton_Click
                        
              AddHandler Me.ActionsButton.Button.Click, AddressOf ActionsButton_Click
                        
              AddHandler Me.FilterButton.Button.Click, AddressOf FilterButton_Click
                        
              AddHandler Me.FiltersButton.Button.Click, AddressOf FiltersButton_Click
                        
            AddHandler Me.SortControl.SelectedIndexChanged, AddressOf SortControl_SelectedIndexChanged
              AddHandler Me.PageNameFilter.SelectedIndexChanged, AddressOf PageNameFilter_SelectedIndexChanged                  
                        
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(SysPages1Record)), SysPages1Record())
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
                    For Each rc As SysPages1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(SysPages1Record)), SysPages1Record())
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
            ByVal pageSize As Integer) As SysPages1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(SysPages1Table.Column1, True)         
            ' selCols.Add(SysPages1Table.Column2, True)          
            ' selCols.Add(SysPages1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return SysPages1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New SysPages1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(SysPages1Record)), SysPages1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(SysPages1Table.Column1, True)         
            ' selCols.Add(SysPages1Table.Column2, True)          
            ' selCols.Add(SysPages1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return SysPages1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New SysPages1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SysPages1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As SysPages1TableControlRow = DirectCast(repItem.FindControl("SysPages1TableControlRow"), SysPages1TableControlRow)
            recControl.DataSource = Me.DataSource(index)          
            If Me.UIData.Count > index Then
              recControl.PreviousUIData = Me.UIData(index)
            End If
            recControl.DataBind()
          
            recControl.Visible = Not Me.InDeletedRecordIds(recControl)
          
            index += 1
          Next
                 
            ' Call the Set methods for each controls on the panel
        
                
                
                
                
                
                
                SetPageNameFilter()
                SetPageNameLabel1()
                
                
                
                
                SetSearchText()
                SetSortByLabel()
                SetSortControl()
                
                
                SetExcelButton()
              
                SetImportButton()
              
                SetNewButton()
              
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

            
            Me.PageNameFilter.ClearSelection()
            
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

            ' Bind the buttons for SysPages1TableControl pagination.
        
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
            
            Dim recCtl As SysPages1TableControlRow
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
            SysPages1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSysPages1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              

                  Dim totalSelectedItemCount as Integer = 0
                  
            If IsValueSelected(Me.PageNameFilter) Then
    
              hasFiltersSysPages1TableControl = True            
    
                Dim item As ListItem
                Dim selectedItemCount As Integer = 0
                For Each item In Me.PageNameFilter.Items
                    If item.Selected Then
                        selectedItemCount += 1
                        
                          totalSelectedItemCount += 1
                        
                    End If
                Next
                
                Dim filter As WhereClause = New WhereClause
                For Each item In Me.PageNameFilter.Items
                    If item.Selected AndAlso (item.Value = "--ANY--" OrElse item.Value = "--PLEASE_SELECT--") AndAlso selectedItemCount > 1 Then
                        item.Selected = False
                    End If
                    If item.Selected Then
                        filter.iOR(SysPages1Table.PageName, BaseFilter.ComparisonOperator.EqualsTo, item.Value, False, False)
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
        
      cols.Add(SysPages1Table.PageName, True)
      
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
            SysPages1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSysPages1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim PageNameFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "PageNameFilter_Ajax"), String)
            If IsValueSelected(PageNameFilterSelectedValue) Then
    
              hasFiltersSysPages1TableControl = True            
    
            If Not isNothing(PageNameFilterSelectedValue) Then
                Dim PageNameFilteritemListFromSession() As String = PageNameFilterSelectedValue.Split(","c)
                Dim index As Integer = 0
                  
                Dim filter As WhereClause = New WhereClause
                For Each item As String In PageNameFilteritemListFromSession
                    If index = 0 AndAlso item.ToString.Equals("") Then
                    Else
                        filter.iOR(SysPages1Table.PageName, BaseFilter.ComparisonOperator.EqualsTo, item, False, False)
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
        
      cols.Add(SysPages1Table.PageName, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
      Next
    
                    Else
                        
      Dim cols As New ColumnList    
        
      cols.Add(SysPages1Table.PageName, True)
      
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
            Dim recordList () As ePortalWFApproval.Business.SysPages1Record = SysPages1Table.GetRecords(filterJoin, wc, Nothing, 0, count,count)
            Dim rec As SysPages1Record = Nothing
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
        
                resultItem = rec.Format(SysPages1Table.PageName)
                If resultItem IsNot Nothing Then
                    Dim prText As String = prefixText
                    If SysPages1Table.PageName.IsFullTextSearchable Then
                         Dim ft As FullTextExpression = New FullTextExpression()
                         prText = ft.GetFirstNonExcludedTerm(prText)
                    End If
                    If Not String.IsNullOrEmpty(prText) AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
  
                        Dim isAdded As Boolean = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, SysPages1Table.PageName.IsFullTextSearchable)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SysPages1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As SysPages1TableControlRow = DirectCast(repItem.FindControl("SysPages1TableControlRow"), SysPages1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As SysPages1Record = New SysPages1Record()
        
                        If recControl.Checked0.Text <> "" Then
                            rec.Parse(recControl.Checked0.Text, SysPages1Table.Checked0)
                        End If
                        If recControl.DateCreated.Text <> "" Then
                            rec.Parse(recControl.DateCreated.Text, SysPages1Table.DateCreated)
                        End If
                        If recControl.isDisplay.Text <> "" Then
                            rec.Parse(recControl.isDisplay.Text, SysPages1Table.isDisplay)
                        End If
                        If recControl.Level.Text <> "" Then
                            rec.Parse(recControl.Level.Text, SysPages1Table.Level)
                        End If
                        If recControl.PageName.Text <> "" Then
                            rec.Parse(recControl.PageName.Text, SysPages1Table.PageName)
                        End If
                        If recControl.ParentID.Text <> "" Then
                            rec.Parse(recControl.ParentID.Text, SysPages1Table.ParentID)
                        End If
                        If recControl.Sorting.Text <> "" Then
                            rec.Parse(recControl.Sorting.Text, SysPages1Table.Sorting)
                        End If
                        If recControl.SystemID.Text <> "" Then
                            rec.Parse(recControl.SystemID.Text, SysPages1Table.SystemID)
                        End If
                        If recControl.URL.Text <> "" Then
                            rec.Parse(recControl.URL.Text, SysPages1Table.URL)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New SysPages1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(SysPages1Record)), SysPages1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As SysPages1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As SysPages1TableControlRow) As Boolean
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
        
        Public Overridable Sub SetPageNameLabel1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortByLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.SortByLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetSortControl()

              
            
                Me.PopulateSortControl(GetSelectedValue(Me.SortControl,  GetFromSession(Me.SortControl)), 500)					
                    
        End Sub
            
        Public Overridable Sub SetPageNameFilter()

              
            
            Dim PageNameFilterselectedFilterItemList As New ArrayList()
            Dim PageNameFilteritemsString As String = Nothing
            If (Me.InSession(Me.PageNameFilter)) Then
                PageNameFilteritemsString = Me.GetFromSession(Me.PageNameFilter)
            End If
            
            If (PageNameFilteritemsString IsNot Nothing) Then
                Dim PageNameFilteritemListFromSession() As String = PageNameFilteritemsString.Split(","c)
                For Each item as String In PageNameFilteritemListFromSession
                    PageNameFilterselectedFilterItemList.Add(item)
                Next
            End If
              
            		
            Me.PopulatePageNameFilter(GetSelectedValueList(Me.PageNameFilter, PageNameFilterselectedFilterItemList), 500)
                    
              Dim url as String = Me.ModifyRedirectUrl("../SysPages1/SysPages-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.PageNameFilter.ClientID & "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("PageName")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--ANY--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:All")) & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.PageNameFilter.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(PageNameFilter.AutoPostBack).ToLower() & ", event); return false;"        
                  
                                 
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
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Checked {Txt:Ascending}"), "Checked Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Checked {Txt:Descending}"), "Checked Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Date Created {Txt:Ascending}"), "DateCreated Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Date Created {Txt:Descending}"), "DateCreated Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Is Display {Txt:Ascending}"), "isDisplay Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Is Display {Txt:Descending}"), "isDisplay Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Level {Txt:Ascending}"), "Level Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Level {Txt:Descending}"), "Level Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Page Name {Txt:Ascending}"), "PageName Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Page Name {Txt:Descending}"), "PageName Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Parent {Txt:Ascending}"), "ParentID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Parent {Txt:Descending}"), "ParentID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Sorting {Txt:Ascending}"), "Sorting Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Sorting {Txt:Descending}"), "Sorting Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("System {Txt:Ascending}"), "SystemID Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("System {Txt:Descending}"), "SystemID Desc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("URL {Txt:Ascending}"), "URL Asc"))
                            							
            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("URL {Txt:Descending}"), "URL Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl.SelectedValue IsNot Nothing AndAlso Me.SortControl.Items.FindByValue(Me.SortControl.SelectedValue) Is Nothing
                Me.SortControl.SelectedValue = Nothing
            End If

              End Sub
            
        ' Get the filters' data for PageNameFilter
        Protected Overridable Sub PopulatePageNameFilter(ByVal selectedValue As ArrayList, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Dim wc As WhereClause = Me.CreateWhereClause_PageNameFilter()
            Me.PageNameFilter.Items.Clear()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_PageNameFilter function.
            ' It is better to customize the where clause there.
            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(SysPages1Table.PageName, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = SysPages1Table.GetValues(SysPages1Table.PageName, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( SysPages1Table.PageName.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = SysPages1Table.PageName.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.PageNameFilter.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.PageNameFilter.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
            Catch
            End Try
            
            
            Me.PageNameFilter.SetFieldMaxLength(50)
                                 
                  
            ' Add the selected value.
            If Me.PageNameFilter.Items.Count = 0 Then
                Me.PageNameFilter.Items.Add(New ListItem(Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
            End If
            
            ' Mark all items to be selected.
            For Each item As ListItem in Me.PageNameFilter.Items
                item.Selected = True
            Next
                              
        End Sub
            
              

        Public Overridable Function CreateWhereClause_PageNameFilter() As WhereClause
          
              Dim hasFiltersSysPages1TableControl As Boolean = False
            
            ' Create a where clause for the filter PageNameFilter.
            ' This function is called by the Populate method to load the items 
            ' in the PageNameFilterQuickSelector
            
            Dim PageNameFilterselectedFilterItemList As New ArrayList()
            Dim PageNameFilteritemsString As String = Nothing
            If (Me.InSession(Me.PageNameFilter)) Then
                PageNameFilteritemsString = Me.GetFromSession(Me.PageNameFilter)
            End If
            
            If (PageNameFilteritemsString IsNot Nothing) Then
                Dim PageNameFilteritemListFromSession() As String = PageNameFilteritemsString.Split(","c)
                For Each item as String In PageNameFilteritemListFromSession
                    PageNameFilterselectedFilterItemList.Add(item)
                Next
            End If
              
            PageNameFilterselectedFilterItemList = GetSelectedValueList(Me.PageNameFilter, PageNameFilterselectedFilterItemList) 
            Dim wc As New WhereClause
            If PageNameFilterselectedFilterItemList Is Nothing OrElse PageNameFilterselectedFilterItemList.Count = 0 Then
                wc.RunQuery = False
            Else            
                For Each item As String In PageNameFilterselectedFilterItemList
              
            
      
   
                    wc.iOR(SysPages1Table.PageName, BaseFilter.ComparisonOperator.EqualsTo, item)

                                
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
                  
            Dim PageNameFilterselectedFilterItemList As ArrayList = GetSelectedValueList(Me.PageNameFilter, Nothing)
            Dim PageNameFilterSessionString As String = ""
            If Not PageNameFilterselectedFilterItemList is Nothing Then
            For Each item As String In PageNameFilterselectedFilterItemList
                PageNameFilterSessionstring = PageNameFilterSessionstring & "," & item
            Next
            End If
            Me.SaveToSession(Me.PageNameFilter, PageNameFilterSessionstring)
                  
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
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
            Me.SaveToSession(Me.SortControl, Me.SortControl.SelectedValue)
                  
            Dim PageNameFilterselectedFilterItemList As ArrayList = GetSelectedValueList(Me.PageNameFilter, Nothing)
            Dim PageNameFilterSessionString As String = ""
            If Not PageNameFilterselectedFilterItemList is Nothing Then
            For Each item As String In PageNameFilterselectedFilterItemList
                PageNameFilterSessionstring = PageNameFilterSessionstring & "," & item
            Next
            End If
            Me.SaveToSession("PageNameFilter_Ajax", PageNameFilterSessionString)
          
      Me.SaveToSession("SearchText_Ajax", Me.SearchText.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl)
            Me.RemoveFromSession(Me.PageNameFilter)
            Me.RemoveFromSession(Me.SearchText)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("SysPages1TableControl_OrderBy"), String)
          
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
                Me.ViewState("SysPages1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
              							
                    Me.ImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=SysPages1" 
                    Me.ImportButton.Attributes.Item("onClick") = "window.open('" & Me.Page.EncryptUrlParameter(Me.ImportButton.PostBackUrl) & "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;"
                        
   
        End Sub
            
        Public Overridable Sub SetNewButton()                
              
              Try        
                    Dim url as String = "../Shared/ConfigureAddRecord.aspx?TabVisible=False&SaveAndNewVisible=False"
              
                      
                    url = Me.ModifyRedirectUrl(url, "", True)
                    
                    url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
                    
                    url = url & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup") & "&Target=" & CType(Me.Page, BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(Me, "SysPages1TableControl_PostbackTracker").ClientID)                           
                                
                Dim javascriptCall as String = ""
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" & MiscUtils.FindControlRecursively(Me, "SysPages1TableControl_PostbackTracker").ClientID & "'), '" & url & "', true, event);"                                      
                       
                    Me.NewButton.Attributes.Item("onClick") = javascriptCall & "return false;"                  
                Catch
                    ' do nothing.  If the code above fails, server side click event, NewButton_ClickNewButton_Click will be trigger when user click the button.
                End Try
                  
   
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
    
      
            If (IsValueSelected(PageNameFilter)) Then
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
              Me.TotalRecords = SysPages1Table.GetRecordCount(join, wc)
              If Me.TotalRecords > 10000 Then
          
              ' Add each of the columns in order of export.
              Dim columns() as BaseColumn = New BaseColumn() { _
                         SysPages1Table.PageName, _ 
             SysPages1Table.ParentID, _ 
             SysPages1Table.Level, _ 
             SysPages1Table.URL, _ 
             SysPages1Table.DateCreated, _ 
             SysPages1Table.Sorting, _ 
             SysPages1Table.isDisplay, _ 
             SysPages1Table.Checked0, _ 
             SysPages1Table.SystemID, _ 
             Nothing}
              Dim  exportData as ExportDataToCSV = New ExportDataToCSV(SysPages1Table.Instance, wc, orderBy, columns)
              exportData.StartExport(Me.Page.Response, True)

              Dim dataForCSV As DataForExport = New DataForExport(SysPages1Table.Instance, wc, orderBy, columns, join)

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
              Dim excelReport As ExportDataToExcel = New ExportDataToExcel(SysPages1Table.Instance, wc, orderBy)
              ' Add each of the columns in order of export.
              ' To customize the data type, change the second parameter of the new ExcelColumn to be
              ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              If Me.Page.Response Is Nothing Then
                Return
              End If

              excelReport.CreateExcelBook()

              Dim width As Integer = 0
              Dim columnCounter As Integer = 0
              Dim data As DataForExport = New DataForExport(SysPages1Table.Instance, wc, orderBy, Nothing, join)
                       data.ColumnList.Add(New ExcelColumn(SysPages1Table.PageName, "Default"))
             data.ColumnList.Add(New ExcelColumn(SysPages1Table.ParentID, "0"))
             data.ColumnList.Add(New ExcelColumn(SysPages1Table.Level, "0"))
             data.ColumnList.Add(New ExcelColumn(SysPages1Table.URL, "Default"))
             data.ColumnList.Add(New ExcelColumn(SysPages1Table.DateCreated, "Short Date"))
             data.ColumnList.Add(New ExcelColumn(SysPages1Table.Sorting, "Default"))
             data.ColumnList.Add(New ExcelColumn(SysPages1Table.isDisplay, "Default"))
             data.ColumnList.Add(New ExcelColumn(SysPages1Table.Checked0, "Default"))
             data.ColumnList.Add(New ExcelColumn(SysPages1Table.SystemID, "0"))


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
                              val = SysPages1Table.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
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
      
                    url = url & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup") & "&Target=" & CType(Me.Page, BaseApplicationPage).Encrypt(MiscUtils.FindControlRecursively(Me, "SysPages1TableControl_PostbackTracker").ClientID)                           
                                
                Dim javascriptCall as String = ""
                
                    javascriptCall = "initializePopupPage2(document.getElementById('" & MiscUtils.FindControlRecursively(Me, "SysPages1TableControl_PostbackTracker").ClientID & "'), '" & url & "', true, event);"                                      
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "NewButton_Click", javascriptCall, True)
        
            End If
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub PDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
              
    Try
    
      ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("Show-SysPages-Table1.PDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "SysPages"
                ' If Show-SysPages-Table1.PDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(SysPages1Table.PageName.Name, ReportEnum.Align.Left, "${PageName}", ReportEnum.Align.Left, 28)
                 report.AddColumn(SysPages1Table.ParentID.Name, ReportEnum.Align.Right, "${ParentID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(SysPages1Table.Level.Name, ReportEnum.Align.Right, "${Level}", ReportEnum.Align.Right, 15)
                 report.AddColumn(SysPages1Table.URL.Name, ReportEnum.Align.Left, "${URL}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SysPages1Table.DateCreated.Name, ReportEnum.Align.Left, "${DateCreated}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SysPages1Table.Sorting.Name, ReportEnum.Align.Left, "${Sorting}", ReportEnum.Align.Left, 28)
                 report.AddColumn(SysPages1Table.isDisplay.Name, ReportEnum.Align.Left, "${isDisplay}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SysPages1Table.Checked0.Name, ReportEnum.Align.Left, "${Checked0}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SysPages1Table.SystemID.Name, ReportEnum.Align.Right, "${SystemID}", ReportEnum.Align.Right, 15)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
                
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = SysPages1Table.GetRecordCount(joinFilter,whereClause)
                Dim columns As ColumnList = SysPages1Table.GetColumnList()
                Dim records As SysPages1Record() = Nothing
            
                Do 
                    
                    records = SysPages1Table.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As SysPages1Record In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${PageName}", record.Format(SysPages1Table.PageName), ReportEnum.Align.Left, 300)
                             report.AddData("${ParentID}", record.Format(SysPages1Table.ParentID), ReportEnum.Align.Right, 300)
                             report.AddData("${Level}", record.Format(SysPages1Table.Level), ReportEnum.Align.Right, 300)
                             report.AddData("${URL}", record.Format(SysPages1Table.URL), ReportEnum.Align.Left, 300)
                             report.AddData("${DateCreated}", record.Format(SysPages1Table.DateCreated), ReportEnum.Align.Left, 300)
                             report.AddData("${Sorting}", record.Format(SysPages1Table.Sorting), ReportEnum.Align.Left, 300)
                             report.AddData("${isDisplay}", record.Format(SysPages1Table.isDisplay), ReportEnum.Align.Left, 300)
                             report.AddData("${Checked0}", record.Format(SysPages1Table.Checked0), ReportEnum.Align.Left, 300)
                             report.AddData("${SystemID}", record.Format(SysPages1Table.SystemID), ReportEnum.Align.Right, 300)

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
    
              Me.PageNameFilter.ClearSelection()
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
                report.SpecificReportFileName = Page.Server.MapPath("Show-SysPages-Table1.WordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "SysPages"
                ' If Show-SysPages-Table1.WordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(SysPages1Table.PageName.Name, ReportEnum.Align.Left, "${PageName}", ReportEnum.Align.Left, 28)
                 report.AddColumn(SysPages1Table.ParentID.Name, ReportEnum.Align.Right, "${ParentID}", ReportEnum.Align.Right, 15)
                 report.AddColumn(SysPages1Table.Level.Name, ReportEnum.Align.Right, "${Level}", ReportEnum.Align.Right, 15)
                 report.AddColumn(SysPages1Table.URL.Name, ReportEnum.Align.Left, "${URL}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SysPages1Table.DateCreated.Name, ReportEnum.Align.Left, "${DateCreated}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SysPages1Table.Sorting.Name, ReportEnum.Align.Left, "${Sorting}", ReportEnum.Align.Left, 28)
                 report.AddColumn(SysPages1Table.isDisplay.Name, ReportEnum.Align.Left, "${isDisplay}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SysPages1Table.Checked0.Name, ReportEnum.Align.Left, "${Checked0}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SysPages1Table.SystemID.Name, ReportEnum.Align.Right, "${SystemID}", ReportEnum.Align.Right, 15)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = SysPages1Table.GetRecordCount(joinFilter,whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = SysPages1Table.GetColumnList()
                Dim records As SysPages1Record() = Nothing
                Do
                    records = SysPages1Table.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As SysPages1Record In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${PageName}", record.Format(SysPages1Table.PageName), ReportEnum.Align.Left, 300)
                             report.AddData("${ParentID}", record.Format(SysPages1Table.ParentID), ReportEnum.Align.Right, 300)
                             report.AddData("${Level}", record.Format(SysPages1Table.Level), ReportEnum.Align.Right, 300)
                             report.AddData("${URL}", record.Format(SysPages1Table.URL), ReportEnum.Align.Left, 300)
                             report.AddData("${DateCreated}", record.Format(SysPages1Table.DateCreated), ReportEnum.Align.Left, 300)
                             report.AddData("${Sorting}", record.Format(SysPages1Table.Sorting), ReportEnum.Align.Left, 300)
                             report.AddData("${isDisplay}", record.Format(SysPages1Table.isDisplay), ReportEnum.Align.Left, 300)
                             report.AddData("${Checked0}", record.Format(SysPages1Table.Checked0), ReportEnum.Align.Left, 300)
                             report.AddData("${SystemID}", record.Format(SysPages1Table.SystemID), ReportEnum.Align.Right, 300)

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
                For Each ColumnNam As BaseClasses.Data.BaseColumn In SysPages1Table.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(SysPages1Table.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not SysPages1Table.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not SysPages1Table.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(SysPages1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(SysPages1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub PageNameFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = SysPages1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As SysPages1Record ()
            Get
                Return DirectCast(MyBase._DataSource, SysPages1Record())
            End Get
            Set(ByVal value() As SysPages1Record)
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
        
        Public ReadOnly Property PageNameFilter() As BaseClasses.Web.UI.WebControls.QuickSelector
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PageNameFilter"), BaseClasses.Web.UI.WebControls.QuickSelector)
            End Get
        End Property
        
        Public ReadOnly Property PageNameLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PageNameLabel1"), System.Web.UI.WebControls.Literal)
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
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
      
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me,includeSession)
        End Function
        
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As SysPages1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As SysPages1Record = Nothing     
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
                Dim recCtl As SysPages1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As SysPages1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As SysPages1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As SysPages1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(SysPages1TableControlRow)), SysPages1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As SysPages1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As SysPages1TableControlRow
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

        Public Overridable Function GetRecordControls() As SysPages1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "SysPages1TableControlRow")
            Dim list As New List(Of SysPages1TableControlRow)
            For Each recCtrl As SysPages1TableControlRow In recCtrls
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

  