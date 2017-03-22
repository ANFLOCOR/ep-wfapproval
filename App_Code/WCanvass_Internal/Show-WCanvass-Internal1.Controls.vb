
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' Show_WCanvass_Internal1.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ePortalWFApproval.UI.Controls.Show_WCanvass_Internal1

#Region "Section 1: Place your customizations here."

    
Public Class Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow
        Inherits BaseSel_WCanvass_Detail_Internal_WPR_Line1TableControlRow
        ' The BaseSel_WCanvass_Detail_Internal_WPR_Line1TableControlRow implements code for a ROW within the
        ' the Sel_WCanvass_Detail_Internal_WPR_Line1TableControl table.  The BaseSel_WCanvass_Detail_Internal_WPR_Line1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Sel_WCanvass_Detail_Internal_WPR_Line1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.

       
    End Class



    Public Class Sel_WCanvass_Detail_Internal_WPR_Line1TableControl
        Inherits BaseSel_WCanvass_Detail_Internal_WPR_Line1TableControl

        ' The BaseSel_WCanvass_Detail_Internal_WPR_Line1TableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


        Public Overrides Function CreateWhereClause() As WhereClause
            Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
            oHeader.LoadData()
            Sel_WCanvass_Detail_Internal_WPR_Line1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            If IsNumeric(oHeader.DataSource.WCI_WPRD_ID.ToString()) Then
                wc.iAND(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_WPRD_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_WPRD_ID.ToString())
                wc.iAND(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCI_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_ID.ToString())
                wc.iAND(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_WClass_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_WClass_ID.ToString())
            Else
                wc.iAND(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_WPRD_ID, BaseFilter.ComparisonOperator.EqualsTo, "0")
            End If
            Return wc
        End Function
    End Class


    Public Class WCanvass_Quotation_Internal1TableControlRow
        Inherits BaseWCanvass_Quotation_Internal1TableControlRow
        ' The BaseWCanvass_Quotation_Internal1TableControlRow implements code for a ROW within the
        ' the WCanvass_Quotation_Internal1TableControl table.  The BaseWCanvass_Quotation_Internal1TableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of WCanvass_Quotation_Internal1TableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.

        Public Overrides Sub SetWCQI_PM00200_Vendor_ID()
            If Me.DataSource.WCQI_PM00200_Vendor_IDSpecified Then

                System.Web.HttpContext.Current.Session("CI_C_ID") = Me.DataSource.WCQI_WCI_ID.ToString()

                Dim wc As WhereClause = New WhereClause()
                Dim sDesc As String = ""
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM00200View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCQI_PM00200_Vendor_ID.ToString())
                wc.iAND(sel_PM00200View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString()) 'oHeader.WCI_C_ID.SelectedValue.ToString()

                Dim itemValue As sel_PM00200Record
                For Each itemValue In sel_PM00200View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Me.WCQI_PM00200_Vendor_ID.Text = sDesc 'formattedValue

            Else
                Me.WCQI_PM00200_Vendor_ID.Text = WCanvass_Quotation_InternalTable.WCQI_PM00200_Vendor_ID.Format(WCanvass_Quotation_InternalTable.WCQI_PM00200_Vendor_ID.DefaultValue)
            End If
        End Sub


    End Class



    Public Class WCanvass_Quotation_Internal1TableControl
        Inherits BaseWCanvass_Quotation_Internal1TableControl

        ' The BaseWCanvass_Quotation_Internal1TableControl class implements the LoadData, DataBind, CreateWhereClause
        ' and other methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
        ' The WCanvass_Quotation_Internal1TableControlRow class offers another place where you can customize
        ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

    End Class


    'Public Class WCanvass_Internal1RecordControl
    '        Inherits BaseWCanvass_Internal1RecordControl
    '        ' The BaseWCanvass_Internal1RecordControl implements the LoadData, DataBind and other
    '        ' methods to load and display the data in a table control.
    '
    '        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
    '        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
    '        
    '
    'End Class
    '



    Public Class WCanvass_InternalRecordControl
        Inherits BaseWCanvass_InternalRecordControl
        ' The BaseWCanvass_InternalRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

    End Class
#End Region



#Region "Section 2: Do not modify this section."


    ' Base class for the Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow control on the Show_WCanvass_Internal1 page.
    ' Do not modify this class. Instead override any method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow.
    Public Class BaseSel_WCanvass_Detail_Internal_WPR_Line1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init


        End Sub

        '  To customize, override this method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


            ' Register the event handlers.

            AddHandler Me.imbAtt.Click, AddressOf imbAtt_Click

            AddHandler Me.imbAtt1.Click, AddressOf imbAtt1_Click

            AddHandler Me.imbAtt2.Click, AddressOf imbAtt2_Click

            AddHandler Me.imbAtt3.Click, AddressOf imbAtt3_Click

            AddHandler Me.imbAtt4.Click, AddressOf imbAtt4_Click

            AddHandler Me.imbAtt5.Click, AddressOf imbAtt5_Click

            AddHandler Me.imbAtt6.Click, AddressOf imbAtt6_Click

            AddHandler Me.imbAtt7.Click, AddressOf imbAtt7_Click

            AddHandler Me.imbAtt8.Click, AddressOf imbAtt8_Click

            AddHandler Me.imbAtt9.Click, AddressOf imbAtt9_Click

            AddHandler Me.imbBid.Click, AddressOf imbBid_Click

            AddHandler Me.imbBid1.Click, AddressOf imbBid1_Click

            AddHandler Me.imbBid2.Click, AddressOf imbBid2_Click

            AddHandler Me.imbBid3.Click, AddressOf imbBid3_Click

            AddHandler Me.imbBid4.Click, AddressOf imbBid4_Click

            AddHandler Me.imbBid5.Click, AddressOf imbBid5_Click

            AddHandler Me.imbBid6.Click, AddressOf imbBid6_Click

            AddHandler Me.imbBid7.Click, AddressOf imbBid7_Click

            AddHandler Me.imbBid8.Click, AddressOf imbBid8_Click

            AddHandler Me.imbBid9.Click, AddressOf imbBid9_Click

            AddHandler Me.imbHist.Click, AddressOf imbHist_Click

            AddHandler Me.imbHist1.Click, AddressOf imbHist1_Click

            AddHandler Me.imbHist2.Click, AddressOf imbHist2_Click

            AddHandler Me.imbHist3.Click, AddressOf imbHist3_Click

            AddHandler Me.imbHist4.Click, AddressOf imbHist4_Click

            AddHandler Me.imbHist5.Click, AddressOf imbHist5_Click

            AddHandler Me.imbHist6.Click, AddressOf imbHist6_Click

            AddHandler Me.imbHist7.Click, AddressOf imbHist7_Click

            AddHandler Me.imbHist8.Click, AddressOf imbHist8_Click

            AddHandler Me.imbHist9.Click, AddressOf imbHist9_Click

            AddHandler Me.imbVendor.Click, AddressOf imbVendor_Click

            AddHandler Me.imbVendor1.Click, AddressOf imbVendor1_Click

            AddHandler Me.imbVendor2.Click, AddressOf imbVendor2_Click

            AddHandler Me.imbVendor3.Click, AddressOf imbVendor3_Click

            AddHandler Me.imbVendor4.Click, AddressOf imbVendor4_Click

            AddHandler Me.imbVendor5.Click, AddressOf imbVendor5_Click

            AddHandler Me.imbVendor6.Click, AddressOf imbVendor6_Click

            AddHandler Me.imbVendor7.Click, AddressOf imbVendor7_Click

            AddHandler Me.imbVendor8.Click, AddressOf imbVendor8_Click

            AddHandler Me.imbVendor9.Click, AddressOf imbVendor9_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID.TextChanged, AddressOf WCDI_PM00200_Vendor_ID_TextChanged


        End Sub


        Public Overridable Sub LoadData()

            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.

            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSel_WCanvass_Detail_Internal_WPR_Line1TableControl when the data for the entire
            ' table is loaded.

            Me.DataSource = New Sel_WCanvass_Detail_Internal_WPR_Line1Record()



        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow.
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
































































            SetlitBreak()
            SetlitBreak1()
            SetlitBreak10()
            SetlitBreak11()
            SetlitBreak12()
            SetlitBreak13()
            SetlitBreak14()
            SetlitBreak15()
            SetlitBreak16()
            SetlitBreak17()
            SetlitBreak18()
            SetlitBreak19()
            SetlitBreak2()
            SetlitBreak20()
            SetlitBreak21()
            SetlitBreak22()
            SetlitBreak23()
            SetlitBreak24()
            SetlitBreak25()
            SetlitBreak26()
            SetlitBreak27()
            SetlitBreak28()
            SetlitBreak29()
            SetlitBreak3()
            SetlitBreak4()
            SetlitBreak5()
            SetlitBreak6()
            SetlitBreak7()
            SetlitBreak8()
            SetlitBreak9()
            SetlitOrig()
            SetlitPO()





































            SetWCDI_PM00200_Vendor_ID()


































            SetimbAtt()

            SetimbAtt1()

            SetimbAtt2()

            SetimbAtt3()

            SetimbAtt4()

            SetimbAtt5()

            SetimbAtt6()

            SetimbAtt7()

            SetimbAtt8()

            SetimbAtt9()

            SetimbBid()

            SetimbBid1()

            SetimbBid2()

            SetimbBid3()

            SetimbBid4()

            SetimbBid5()

            SetimbBid6()

            SetimbBid7()

            SetimbBid8()

            SetimbBid9()

            SetimbHist()

            SetimbHist1()

            SetimbHist2()

            SetimbHist3()

            SetimbHist4()

            SetimbHist5()

            SetimbHist6()

            SetimbHist7()

            SetimbHist8()

            SetimbHist9()

            SetimbVendor()

            SetimbVendor1()

            SetimbVendor2()

            SetimbVendor3()

            SetimbVendor4()

            SetimbVendor5()

            SetimbVendor6()

            SetimbVendor7()

            SetimbVendor8()

            SetimbVendor9()



            Me.IsNewRecord = True

            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False

            End If

            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False

        End Sub


        Public Overridable Sub SetlitBreak()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak1()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak1.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak10()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak10.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak11()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak11.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak12()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak12.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak13()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak13.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak14()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak14.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak15()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak15.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak16()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak16.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak17()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak17.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak18()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak18.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak19()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak19.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak2()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak2.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak20()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak20.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak21()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak21.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak22()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak22.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak23()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak23.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak24()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak24.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak25()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak25.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak26()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak26.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak27()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak27.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak28()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak28.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak29()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak29.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak3()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak3.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak4()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak4.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak5()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak5.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak6()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak6.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak7()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak7.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak8()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak8.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitBreak9()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litBreak9.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitOrig()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litOrig.Text = "Some value"

        End Sub

        Public Overridable Sub SetlitPO()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.litPO.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID()



            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID.ID) Then
                Me.WCDI_PM00200_Vendor_ID.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID.ID).ToString()
                Return
            End If

            Me.WCDI_PM00200_Vendor_ID.Text = EvaluateFormula("WCDI_PM00200_Vendor_ID1")

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

            If includeDS Then

            End If


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

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, Nothing)
        End Function


        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e As FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function


        Public Overridable Sub RegisterPostback()


        End Sub



        ' To customize, override this method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow.
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

                DirectCast(GetParentControlObject(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1TableControl"), Sel_WCanvass_Detail_Internal_WPR_Line1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1TableControl"), Sel_WCanvass_Detail_Internal_WPR_Line1TableControl).ResetData = True
            End If


            ' update session or cookie by formula


            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True

            ' For Master-Detail relationships, save data on the Detail table(s)

        End Sub

        ' To customize, override this method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.

            ' Call the Get methods for each of the user interface controls.

        End Sub



        ' To customize, override this method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow.

        Public Overridable Function CreateWhereClause() As WhereClause

            Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False

            Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False

            Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False

            Return Nothing

        End Function



        ' To customize, override this method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow.
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

        Public Overridable Sub SetimbAtt()


        End Sub

        Public Overridable Sub SetimbAtt1()


        End Sub

        Public Overridable Sub SetimbAtt2()


        End Sub

        Public Overridable Sub SetimbAtt3()


        End Sub

        Public Overridable Sub SetimbAtt4()


        End Sub

        Public Overridable Sub SetimbAtt5()


        End Sub

        Public Overridable Sub SetimbAtt6()


        End Sub

        Public Overridable Sub SetimbAtt7()


        End Sub

        Public Overridable Sub SetimbAtt8()


        End Sub

        Public Overridable Sub SetimbAtt9()


        End Sub

        Public Overridable Sub SetimbBid()


        End Sub

        Public Overridable Sub SetimbBid1()


        End Sub

        Public Overridable Sub SetimbBid2()


        End Sub

        Public Overridable Sub SetimbBid3()


        End Sub

        Public Overridable Sub SetimbBid4()


        End Sub

        Public Overridable Sub SetimbBid5()


        End Sub

        Public Overridable Sub SetimbBid6()


        End Sub

        Public Overridable Sub SetimbBid7()


        End Sub

        Public Overridable Sub SetimbBid8()


        End Sub

        Public Overridable Sub SetimbBid9()


        End Sub

        Public Overridable Sub SetimbHist()


        End Sub

        Public Overridable Sub SetimbHist1()


        End Sub

        Public Overridable Sub SetimbHist2()


        End Sub

        Public Overridable Sub SetimbHist3()


        End Sub

        Public Overridable Sub SetimbHist4()


        End Sub

        Public Overridable Sub SetimbHist5()


        End Sub

        Public Overridable Sub SetimbHist6()


        End Sub

        Public Overridable Sub SetimbHist7()


        End Sub

        Public Overridable Sub SetimbHist8()


        End Sub

        Public Overridable Sub SetimbHist9()


        End Sub

        Public Overridable Sub SetimbVendor()


        End Sub

        Public Overridable Sub SetimbVendor1()


        End Sub

        Public Overridable Sub SetimbVendor2()


        End Sub

        Public Overridable Sub SetimbVendor3()


        End Sub

        Public Overridable Sub SetimbVendor4()


        End Sub

        Public Overridable Sub SetimbVendor5()


        End Sub

        Public Overridable Sub SetimbVendor6()


        End Sub

        Public Overridable Sub SetimbVendor7()


        End Sub

        Public Overridable Sub SetimbVendor8()


        End Sub

        Public Overridable Sub SetimbVendor9()


        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt2_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt3_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt4_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt5_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt6_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt7_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt8_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbAtt9_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid2_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid3_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid4_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid5_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid6_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid7_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid8_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbBid9_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist2_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist3_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist4_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist5_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist6_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist7_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist8_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbHist9_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor2_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor3_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor4_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor5_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor6_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor7_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor8_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub imbVendor9_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

            Catch ex As Exception

                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally

            End Try

        End Sub

        Protected Overridable Sub WCDI_PM00200_Vendor_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)

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


        Public Property DataSource() As Sel_WCanvass_Detail_Internal_WPR_Line1Record
            Get
                Return DirectCast(MyBase._DataSource, Sel_WCanvass_Detail_Internal_WPR_Line1Record)
            End Get
            Set(ByVal value As Sel_WCanvass_Detail_Internal_WPR_Line1Record)
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

        Public ReadOnly Property imbAtt() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt2() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt2"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt3() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt3"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt4() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt4"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt5() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt5"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt6() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt6"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt7() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt7"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt8() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt8"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbAtt9() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbAtt9"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid2() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid2"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid3() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid3"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid4() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid4"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid5() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid5"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid6() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid6"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid7() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid7"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid8() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid8"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbBid9() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbBid9"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist2() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist2"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist3() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist3"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist4() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist4"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist5() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist5"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist6() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist6"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist7() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist7"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist8() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist8"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbHist9() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbHist9"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor2() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor2"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor3() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor3"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor4() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor4"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor5() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor5"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor6() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor6"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor7() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor7"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor8() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor8"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property imbVendor9() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "imbVendor9"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property Item() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Item"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property Item1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Item1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property ItemDescription() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemDescription"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory3() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory3"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory4() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory4"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory5() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory5"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory6() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory6"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory7() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory7"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory8() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory8"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorHistory9() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorHistory9"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory3() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory3"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory4() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory4"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory5() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory5"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory6() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory6"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory7() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory7"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory8() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory8"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property lbVendorItemHistory9() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lbVendorItemHistory9"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property litBreak() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak10() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak10"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak11() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak11"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak12() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak12"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak13() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak13"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak14() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak14"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak15() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak15"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak16() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak16"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak17() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak17"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak18() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak18"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak19() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak19"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak20() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak20"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak21() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak21"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak22() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak22"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak23() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak23"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak24() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak24"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak25() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak25"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak26() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak26"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak27() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak27"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak28() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak28"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak29() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak29"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak4() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak4"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak5() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak5"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak6() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak6"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak7() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak7"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak8() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak8"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litBreak9() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak9"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litOrig() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litOrig"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property litPO() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litPO"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property UnitOfMeasure() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UnitOfMeasure"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property UnitPrice() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UnitPrice"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Audit_Comment() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Audit_Comment"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw10() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw10"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw4() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw4"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw5() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw5"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw6() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw6"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw7() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw7"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw8() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw8"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Aw9() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Aw9"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award2() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award2"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award3() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award3"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award4() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award4"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award5() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award5"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award6() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award6"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award7() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award7"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award8() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award8"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award9() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award9"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid3() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid3"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid4() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid4"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid5() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid5"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid6() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid6"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid7() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid7"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid8() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid8"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid9() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid9"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Comment() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Comment"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_Net() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Net"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID10() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID10"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID11() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID11"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID12() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID12"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID13() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID13"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID14() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID14"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID15() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID15"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID16() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID16"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID17() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID17"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID18() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID18"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID19() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID19"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID3() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID3"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID4() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID4"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID5() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID5"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID6() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID6"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID7() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID7"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID8() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID8"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID9() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID9"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty3() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty3"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty4() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty4"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty5() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty5"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty6() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty6"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty7() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty7"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty8() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty8"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Qty9() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Qty9"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property

        Public ReadOnly Property WCDI_Vat() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Vat"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WCDI_WCur_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_WCur_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WPRL_Ext_Price() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRL_Ext_Price"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WPRL_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRL_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WPRL_Qty() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRL_Qty"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

#End Region

#Region "Helper Functions"

        Public Overloads Overrides Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overloads Overrides Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overloads Overrides Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String

            Dim rec As Sel_WCanvass_Detail_Internal_WPR_Line1Record = Nothing


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

        Public Overloads Overrides Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String

            Dim rec As Sel_WCanvass_Detail_Internal_WPR_Line1Record = Nothing


            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.

                Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ePortalWFApproval"))

            End If
            If includeSession Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt, False)
            End If
        End Function


        Public Overridable Function GetRecord() As Sel_WCanvass_Detail_Internal_WPR_Line1Record
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



    ' Base class for the Sel_WCanvass_Detail_Internal_WPR_Line1TableControl control on the Show_WCanvass_Internal1 page.
    ' Do not modify this class. Instead override any method in Sel_WCanvass_Detail_Internal_WPR_Line1TableControl.
    Public Class BaseSel_WCanvass_Detail_Internal_WPR_Line1TableControl
        Inherits ePortalWFApproval.UI.BaseApplicationTableControl


        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init



            ' Setup the filter and search.

            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If Me.InSession(Me.SortControl) Then
                    initialVal = Me.GetFromSession(Me.SortControl)


                End If


                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                    initialVal = ""
                End If

                If initialVal <> "" Then

                    Me.SortControl.Items.Add(New ListItem(initialVal, initialVal))

                    Me.SortControl.SelectedValue = initialVal

                End If

            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If Me.InSession(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText) Then
                    initialVal = Me.GetFromSession(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText)

                End If

                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                    initialVal = ""
                End If

                If initialVal <> "" Then

                    Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = initialVal

                End If

            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If Me.InSession(Me.WCDI_StatusFilter1) Then
                    initialVal = Me.GetFromSession(Me.WCDI_StatusFilter1)

                Else

                    initialVal = EvaluateFormula("URL(""WCDI_Status"")")

                End If

                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                    initialVal = ""
                End If

                If initialVal <> "" Then

                    Dim WCDI_StatusFilter1itemListFromSession() As String = initialVal.Split(","c)
                    Dim index As Integer = 0
                    For Each item As String In WCDI_StatusFilter1itemListFromSession
                        If index = 0 AndAlso _
                           item.ToString.Equals("") Then
                        Else
                            Me.WCDI_StatusFilter1.Items.Add(item)
                            Me.WCDI_StatusFilter1.Items.Item(index).Selected = True
                            index += 1
                        End If
                    Next
                    Dim listItem As ListItem
                    For Each listItem In Me.WCDI_StatusFilter1.Items
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

            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "20"))
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

            AddHandler Me.ItemDescriptionLabel.Click, AddressOf ItemDescriptionLabel_Click

            AddHandler Me.ItemLabel.Click, AddressOf ItemLabel_Click

            AddHandler Me.UnitOfMeasureLabel.Click, AddressOf UnitOfMeasureLabel_Click

            AddHandler Me.UnitPriceLabel.Click, AddressOf UnitPriceLabel_Click

            AddHandler Me.WCDI_Audit_CommentLabel.Click, AddressOf WCDI_Audit_CommentLabel_Click

            AddHandler Me.WCDI_Award1Label.Click, AddressOf WCDI_Award1Label_Click

            AddHandler Me.WCDI_Award1Label1.Click, AddressOf WCDI_Award1Label1_Click

            AddHandler Me.WCDI_Award1Label2.Click, AddressOf WCDI_Award1Label2_Click

            AddHandler Me.WCDI_Award1Label3.Click, AddressOf WCDI_Award1Label3_Click

            AddHandler Me.WCDI_Award1Label4.Click, AddressOf WCDI_Award1Label4_Click

            AddHandler Me.WCDI_Award1Label5.Click, AddressOf WCDI_Award1Label5_Click

            AddHandler Me.WCDI_Award1Label6.Click, AddressOf WCDI_Award1Label6_Click

            AddHandler Me.WCDI_Award1Label7.Click, AddressOf WCDI_Award1Label7_Click

            AddHandler Me.WCDI_Award1Label8.Click, AddressOf WCDI_Award1Label8_Click

            AddHandler Me.WCDI_Award1Label9.Click, AddressOf WCDI_Award1Label9_Click

            AddHandler Me.WCDI_Bid1Label.Click, AddressOf WCDI_Bid1Label_Click

            AddHandler Me.WCDI_Bid1Label1.Click, AddressOf WCDI_Bid1Label1_Click

            AddHandler Me.WCDI_Bid1Label2.Click, AddressOf WCDI_Bid1Label2_Click

            AddHandler Me.WCDI_Bid1Label3.Click, AddressOf WCDI_Bid1Label3_Click

            AddHandler Me.WCDI_Bid1Label4.Click, AddressOf WCDI_Bid1Label4_Click

            AddHandler Me.WCDI_Bid1Label5.Click, AddressOf WCDI_Bid1Label5_Click

            AddHandler Me.WCDI_Bid1Label6.Click, AddressOf WCDI_Bid1Label6_Click

            AddHandler Me.WCDI_Bid1Label7.Click, AddressOf WCDI_Bid1Label7_Click

            AddHandler Me.WCDI_Bid1Label8.Click, AddressOf WCDI_Bid1Label8_Click

            AddHandler Me.WCDI_Bid1Label9.Click, AddressOf WCDI_Bid1Label9_Click

            AddHandler Me.WCDI_CommentLabel.Click, AddressOf WCDI_CommentLabel_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label.Click, AddressOf WCDI_PM00200_Vendor_ID1Label_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label1.Click, AddressOf WCDI_PM00200_Vendor_ID1Label1_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label2.Click, AddressOf WCDI_PM00200_Vendor_ID1Label2_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label3.Click, AddressOf WCDI_PM00200_Vendor_ID1Label3_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label4.Click, AddressOf WCDI_PM00200_Vendor_ID1Label4_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label5.Click, AddressOf WCDI_PM00200_Vendor_ID1Label5_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label6.Click, AddressOf WCDI_PM00200_Vendor_ID1Label6_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label7.Click, AddressOf WCDI_PM00200_Vendor_ID1Label7_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label8.Click, AddressOf WCDI_PM00200_Vendor_ID1Label8_Click

            AddHandler Me.WCDI_PM00200_Vendor_ID1Label9.Click, AddressOf WCDI_PM00200_Vendor_ID1Label9_Click

            AddHandler Me.WPRL_Ext_PriceLabel.Click, AddressOf WPRL_Ext_PriceLabel_Click

            AddHandler Me.WPRL_QtyLabel.Click, AddressOf WPRL_QtyLabel_Click

            ' Setup the button events.

            AddHandler Me.ExcelButton.Click, AddressOf ExcelButton_Click

            AddHandler Me.PDFButton.Click, AddressOf PDFButton_Click

            AddHandler Me.ResetButton.Click, AddressOf ResetButton_Click

            AddHandler Me.SearchButton1.Click, AddressOf SearchButton1_Click

            AddHandler Me.WordButton.Click, AddressOf WordButton_Click

            AddHandler Me.ActionsButton.Button.Click, AddressOf ActionsButton_Click

            AddHandler Me.FilterButton.Button.Click, AddressOf FilterButton_Click

            AddHandler Me.FiltersButton.Button.Click, AddressOf FiltersButton_Click

            AddHandler Me.SortControl.SelectedIndexChanged, AddressOf SortControl_SelectedIndexChanged
            AddHandler Me.WCDI_StatusFilter1.SelectedIndexChanged, AddressOf WCDI_StatusFilter1_SelectedIndexChanged


            ' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "Sel_WCanvass_Detail_Internal_WPR_Line1SearchTextSearchBoxText", "setSearchBoxText(""" & BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) & """, """ & Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.ClientID & """);", True)

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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Sel_WCanvass_Detail_Internal_WPR_Line1Record)), Sel_WCanvass_Detail_Internal_WPR_Line1Record())
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
                    For Each rc As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Sel_WCanvass_Detail_Internal_WPR_Line1Record)), Sel_WCanvass_Detail_Internal_WPR_Line1Record())
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
            ByVal pageSize As Integer) As Sel_WCanvass_Detail_Internal_WPR_Line1Record()

            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList



            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.Column1, True)         
            ' selCols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.Column2, True)          
            ' selCols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.Column3, True)    



            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *

            If selCols.Count = 0 Then

                Return Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)

            Else
                Dim databaseTable As New Sel_WCanvass_Detail_Internal_WPR_Line1View
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)

                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True



                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(Sel_WCanvass_Detail_Internal_WPR_Line1Record)), Sel_WCanvass_Detail_Internal_WPR_Line1Record())
            End If

        End Function


        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList


            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.Column1, True)         
            ' selCols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.Column2, True)          
            ' selCols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *

            If selCols.Count = 0 Then

                Return Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecordCount(join, where)

            Else
                Dim databaseTable As New Sel_WCanvass_Detail_Internal_WPR_Line1View
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

            Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0

            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items

                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow = DirectCast(repItem.FindControl("Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow"), Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow)
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If
                recControl.DataBind()

                index += 1
            Next

            ' Call the Set methods for each controls on the panel





            SetItemDescriptionLabel()
            SetItemLabel()




            SetSel_WCanvass_Detail_Internal_WPR_Line1SearchText()
            SetSortByLabel()
            SetSortControl()

            SetUnitOfMeasureLabel()
            SetUnitPriceLabel()
            SetWCDI_Audit_CommentLabel()
            SetWCDI_Award1Label()
            SetWCDI_Award1Label1()
            SetWCDI_Award1Label2()
            SetWCDI_Award1Label3()
            SetWCDI_Award1Label4()
            SetWCDI_Award1Label5()
            SetWCDI_Award1Label6()
            SetWCDI_Award1Label7()
            SetWCDI_Award1Label8()
            SetWCDI_Award1Label9()
            SetWCDI_Bid1Label()
            SetWCDI_Bid1Label1()
            SetWCDI_Bid1Label2()
            SetWCDI_Bid1Label3()
            SetWCDI_Bid1Label4()
            SetWCDI_Bid1Label5()
            SetWCDI_Bid1Label6()
            SetWCDI_Bid1Label7()
            SetWCDI_Bid1Label8()
            SetWCDI_Bid1Label9()
            SetWCDI_CommentLabel()
            SetWCDI_PM00200_Vendor_ID1Label()
            SetWCDI_PM00200_Vendor_ID1Label1()
            SetWCDI_PM00200_Vendor_ID1Label2()
            SetWCDI_PM00200_Vendor_ID1Label3()
            SetWCDI_PM00200_Vendor_ID1Label4()
            SetWCDI_PM00200_Vendor_ID1Label5()
            SetWCDI_PM00200_Vendor_ID1Label6()
            SetWCDI_PM00200_Vendor_ID1Label7()
            SetWCDI_PM00200_Vendor_ID1Label8()
            SetWCDI_PM00200_Vendor_ID1Label9()
            SetWCDI_StatusFilter1()
            SetWCDI_StatusLabel2()

            SetWPRL_Ext_PriceLabel()
            SetWPRL_QtyLabel()
            SetExcelButton()

            SetPDFButton()

            SetResetButton()

            SetSearchButton1()

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

            Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me, "ExcelButton"))

            Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me, "PDFButton"))

            Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me, "WordButton"))


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

            If includeDS Then

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

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal includeDS As Boolean) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, Nothing)
        End Function


        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object)) As String
            Return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal format As String) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, format, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord, ByVal variables As System.Collections.Generic.IDictionary(Of String, Object), ByVal e As FormulaEvaluator) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, variables, True, e)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate As BaseClasses.Data.BaseRecord) As String
            Return Me.EvaluateFormula(formula, dataSourceForEvaluate, Nothing, Nothing, True, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String, ByVal includeDS As Boolean) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, includeDS, Nothing)
        End Function

        Public Overridable Function EvaluateFormula(ByVal formula As String) As String
            Return Me.EvaluateFormula(formula, Nothing, Nothing, Nothing, True, Nothing)
        End Function




        Public Overridable Sub ResetControl()


            Me.WCDI_StatusFilter1.ClearSelection()

            Me.SortControl.ClearSelection()

            Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = ""

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

            ' Bind the buttons for Sel_WCanvass_Detail_Internal_WPR_Line1TableControl pagination.

            Me.Pagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination.LastPage.Enabled = True
            ElseIf Me._TotalPages = 0 Then          ' if the total pages is determined and it is 0, enable last and next buttons
                Me.Pagination.LastPage.Enabled = False
            Else                               ' if the total pages is the last page, disable last and next buttons
                Me.Pagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            End If

            If Me._TotalPages < 0 Then      ' if the total pages is not determined yet, enable last and next buttons
                Me.Pagination.NextPage.Enabled = True
            ElseIf Me._TotalPages = 0 Then          ' if the total pages is determined and it is 0, enable last and next buttons
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

            Dim recCtl As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow
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
            Sel_WCanvass_Detail_Internal_WPR_Line1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False

            Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False

            Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.


            If IsValueSelected(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText) Then
                If Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) Then
                    Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = ""
                Else
                    ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.

                    If Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.StartsWith(BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing)) Then
                        Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = ""
                    Else

                        If Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.StartsWith("...") Then
                            Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.SubString(3, Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.Length - 3)
                        End If
                        If Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.EndsWith("...") Then
                            Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.SubString(0, Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.Length - 3)
                            ' Strip the last word as well as it is likely only a partial word
                            Dim endindex As Integer = Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.Length - 1
                            While (Not Char.IsWhiteSpace(Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text(endindex)) AndAlso endindex > 0)
                                endindex -= 1
                            End While
                            If endindex > 0 Then
                                Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text.Substring(0, endindex)
                            End If
                        End If
                    End If

                End If

                Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText, Me.GetFromSession(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText))

                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText) Then
                    ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    Dim search As WhereClause = New WhereClause()

                    Dim cols As New ColumnList

                    cols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription, True)

                    For Each col As BaseColumn In cols

                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText, Me.GetFromSession(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText)), True, False)

                    Next

                    wc.iAND(search)
                End If
            End If


            Dim totalSelectedItemCount As Integer = 0

            If IsValueSelected(Me.WCDI_StatusFilter1) Then

                hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl = True

                Dim item As ListItem
                Dim selectedItemCount As Integer = 0
                For Each item In Me.WCDI_StatusFilter1.Items
                    If item.Selected Then
                        selectedItemCount += 1

                        totalSelectedItemCount += 1

                    End If
                Next

                Dim filter As WhereClause = New WhereClause
                For Each item In Me.WCDI_StatusFilter1.Items
                    If item.Selected AndAlso (item.Value = "--ANY--" OrElse item.Value = "--PLEASE_SELECT--") AndAlso selectedItemCount > 1 Then
                        item.Selected = False
                    End If
                    If item.Selected Then
                        filter.iOR(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Status, BaseFilter.ComparisonOperator.EqualsTo, item.Value, False, False)
                    End If
                Next
                wc.iAND(filter)

            End If



            If (totalSelectedItemCount > 50) Then
                Throw New Exception(Page.GetResourceValue("Err:SelectedItemOverLimit", "ePortalWFApproval").Replace("{Limit}", "50").Replace("{SelectedCount}", totalSelectedItemCount.ToString()))
            End If


            Return wc
        End Function


        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Sel_WCanvass_Detail_Internal_WPR_Line1View.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()

            Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False

            Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False

            Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False

            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)

            ' Adds clauses if values are selected in Filter controls which are configured in the page.

            If IsValueSelected(searchText) And fromSearchControl = "Sel_WCanvass_Detail_Internal_WPR_Line1SearchText" Then
                Dim formatedSearchText As String = searchText
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If searchText.StartsWith("...") Then
                    formatedSearchText = searchText.SubString(3, searchText.Length - 3)
                End If
                If searchText.EndsWith("...") Then
                    formatedSearchText = searchText.SubString(0, searchText.Length - 3)
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

                        cols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription, True)

                        For Each col As BaseColumn In cols

                            search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                            search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)

                        Next

                    Else

                        Dim cols As New ColumnList

                        cols.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription, True)

                        For Each col As BaseColumn In cols

                            search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        Next

                    End If
                    wc.iAND(search)
                End If
            End If

            Dim WCDI_StatusFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WCDI_StatusFilter1_Ajax"), String)
            If IsValueSelected(WCDI_StatusFilter1SelectedValue) Then

                hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl = True

                If Not isNothing(WCDI_StatusFilter1SelectedValue) Then
                    Dim WCDI_StatusFilter1itemListFromSession() As String = WCDI_StatusFilter1SelectedValue.Split(","c)
                    Dim index As Integer = 0

                    Dim filter As WhereClause = New WhereClause
                    For Each item As String In WCDI_StatusFilter1itemListFromSession
                        If index = 0 AndAlso item.ToString.Equals("") Then
                        Else
                            filter.iOR(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Status, BaseFilter.ComparisonOperator.EqualsTo, item, False, False)
                            index += 1
                        End If
                    Next
                    wc.iAND(filter)

                End If

            End If



            Return wc
        End Function


        Public Overridable Function GetAutoCompletionList_Sel_WCanvass_Detail_Internal_WPR_Line1SearchText(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList

            Dim filterJoin As CompoundFilter = CreateCompoundJoinFilter()
            If count = 0 Then count = 10
            Dim wc As WhereClause = CreateWhereClause(prefixText, "Sel_WCanvass_Detail_Internal_WPR_Line1SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            Dim recordList() As ePortalWFApproval.Business.Sel_WCanvass_Detail_Internal_WPR_Line1Record = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecords(filterJoin, wc, Nothing, 0, count, count)
            Dim rec As Sel_WCanvass_Detail_Internal_WPR_Line1Record = Nothing
            Dim resultItem As String = ""
            For Each rec In recordList
                ' Exit the loop if recordList count has reached AutoTypeAheadListSize.
                If resultList.Count >= count Then
                    Exit For
                End If
                ' If the field is configured to Display as Foreign key, Format() method returns the 
                ' Display as Forien Key value instead of original field value.
                ' Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                ' We need to find relevent field to display which matches the prefixText and is not already present in the result list.

                resultItem = rec.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription)
                If resultItem IsNot Nothing Then
                    Dim prText As String = prefixText
                    If Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription.IsFullTextSearchable Then
                        Dim ft As FullTextExpression = New FullTextExpression()
                        prText = ft.GetFirstNonExcludedTerm(prText)
                    End If
                    If Not String.IsNullOrEmpty(prText) AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture)) Then

                        Dim isAdded As Boolean = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription.IsFullTextSearchable)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return


                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items

                    ' Loop through all rows in the table, set its DataSource and call DataBind().

                    Dim recControl As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow = DirectCast(repItem.FindControl("Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow"), Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow)


                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_WCanvass_Detail_Internal_WPR_Line1Record = New Sel_WCanvass_Detail_Internal_WPR_Line1Record()

                        newUIDataList.Add(recControl.PreservedUIData())
                        newRecordList.Add(rec)
                    End If
                Next
            End If


            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord

                newRecordList.Insert(0, New Sel_WCanvass_Detail_Internal_WPR_Line1Record())
                newUIDataList.Insert(0, New Hashtable())

            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then

                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Sel_WCanvass_Detail_Internal_WPR_Line1Record)), Sel_WCanvass_Detail_Internal_WPR_Line1Record())

            End If

            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If

        End Sub



        ' Create Set, WhereClause, and Populate Methods

        Public Overridable Sub SetItemDescriptionLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.ItemDescriptionLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetItemLabel()



        End Sub

        Public Overridable Sub SetSortByLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.SortByLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetUnitOfMeasureLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.UnitOfMeasureLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetUnitPriceLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.UnitPriceLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Audit_CommentLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Audit_CommentLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label1()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label1.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label2()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label2.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label3()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label3.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label4()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label4.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label5()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label5.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label6()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label6.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label7()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label7.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label8()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label8.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Award1Label9()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Award1Label9.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label1()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label1.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label2()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label2.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label3()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label3.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label4()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label4.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label5()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label5.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label6()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label6.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label7()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label7.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label8()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label8.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_Bid1Label9()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_Bid1Label9.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_CommentLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_CommentLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label1()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label1.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label2()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label2.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label3()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label3.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label4()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label4.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label5()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label5.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label6()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label6.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label7()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label7.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label8()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label8.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1Label9()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WCDI_PM00200_Vendor_ID1Label9.Text = "Some value"

        End Sub

        Public Overridable Sub SetWCDI_StatusLabel2()



        End Sub

        Public Overridable Sub SetWPRL_Ext_PriceLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WPRL_Ext_PriceLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetWPRL_QtyLabel()



            'Code for the text property is generated inside the .aspx file.
            'To override this property you can uncomment the following property and add your own value.
            'Me.WPRL_QtyLabel.Text = "Some value"

        End Sub

        Public Overridable Sub SetSortControl()



            Me.PopulateSortControl(GetSelectedValue(Me.SortControl, GetFromSession(Me.SortControl)), 500)

        End Sub

        Public Overridable Sub SetSel_WCanvass_Detail_Internal_WPR_Line1SearchText()



            Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "') {this.value='';this.className='Search_Input';}")
            Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "';this.className='Search_InputHint';}")

        End Sub

        Public Overridable Sub SetWCDI_StatusFilter1()



            Dim WCDI_StatusFilter1selectedFilterItemList As New ArrayList()
            Dim WCDI_StatusFilter1itemsString As String = Nothing
            If (Me.InSession(Me.WCDI_StatusFilter1)) Then
                WCDI_StatusFilter1itemsString = Me.GetFromSession(Me.WCDI_StatusFilter1)
            End If

            If (WCDI_StatusFilter1itemsString IsNot Nothing) Then
                Dim WCDI_StatusFilter1itemListFromSession() As String = WCDI_StatusFilter1itemsString.Split(","c)
                For Each item As String In WCDI_StatusFilter1itemListFromSession
                    WCDI_StatusFilter1selectedFilterItemList.Add(item)
                Next
            End If


            Me.PopulateWCDI_StatusFilter1(GetSelectedValueList(Me.WCDI_StatusFilter1, WCDI_StatusFilter1selectedFilterItemList), 500)

            Dim url As String = Me.ModifyRedirectUrl("../sel_WCanvass_Detail_Internal_WPR_Line1/Sel-WCanvass-Detail-Internal-WPR-Line-QuickSelector1.aspx", "", True)

            url = Me.Page.ModifyRedirectUrl(url, "", True)

            url &= "?Target=" & Me.WCDI_StatusFilter1.ClientID & "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WCDI_Status") & "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--ANY--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:All")) & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")


            Me.WCDI_StatusFilter1.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCDI_StatusFilter1.AutoPostBack).ToLower() & ", event); return false;"


        End Sub

        ' Get the filters' data for SortControl
        Protected Overridable Sub PopulateSortControl(ByVal selectedValue As String, ByVal maxItems As Integer)


            Me.SortControl.Items.Clear()

            ' 1. Setup the static list items

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Item {Txt:Ascending}"), "Item Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Item {Txt:Descending}"), "Item Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Site {Txt:Ascending}"), "Site Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Site {Txt:Descending}"), "Site Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Unit Of Measure {Txt:Ascending}"), "UnitOfMeasure Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Unit Of Measure {Txt:Descending}"), "UnitOfMeasure Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Unit Price {Txt:Ascending}"), "UnitPrice Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Unit Price {Txt:Descending}"), "UnitPrice Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wcdi {Txt:Ascending}"), "WCDI_ID Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wcdi {Txt:Descending}"), "WCDI_ID Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDI PM 00200 Vendor 1 {Txt:Ascending}"), "WCDI_PM00200_Vendor_ID1 Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCDI PM 00200 Vendor 1 {Txt:Descending}"), "WCDI_PM00200_Vendor_ID1 Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wcdi WCI {Txt:Ascending}"), "WCDI_WCI_ID Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("Wcdi WCI {Txt:Descending}"), "WCDI_WCI_ID Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WPRL Extension Price {Txt:Ascending}"), "WPRL_Ext_Price Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WPRL Extension Price {Txt:Descending}"), "WPRL_Ext_Price Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WPRL Quantity {Txt:Ascending}"), "WPRL_Qty Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WPRL Quantity {Txt:Descending}"), "WPRL_Qty Desc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WPRL WPRD ID {Txt:Ascending}"), "WPRL_WPRD_ID Asc"))

            Me.SortControl.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WPRL WPRD ID {Txt:Descending}"), "WPRL_WPRD_ID Desc"))


            Try
                ' Set the selected value.
                SetSelectedValue(Me.SortControl, selectedValue)


            Catch
            End Try

            If Me.SortControl.SelectedValue IsNot Nothing AndAlso Me.SortControl.Items.FindByValue(Me.SortControl.SelectedValue) Is Nothing Then
                Me.SortControl.SelectedValue = Nothing
            End If

        End Sub

        ' Get the filters' data for WCDI_StatusFilter1
        Protected Overridable Sub PopulateWCDI_StatusFilter1(ByVal selectedValue As ArrayList, ByVal maxItems As Integer)

            'Setup the WHERE clause.

            Dim wc As WhereClause = Me.CreateWhereClause_WCDI_StatusFilter1()
            Me.WCDI_StatusFilter1.Items.Clear()

            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCDI_StatusFilter1 function.
            ' It is better to customize the where clause there.



            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Status, OrderByItem.OrderDir.Asc)



            Dim values(-1) As String
            If wc.RunQuery Then

                values = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetValues(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Status, wc, orderBy, maxItems)

            End If


            Dim cvalue As String

            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If (Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Status.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Status.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If (fvalue.Length > 50) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.WCDI_StatusFilter1.Items.FindByText(fvalue)

                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length, 38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.WCDI_StatusFilter1.Items.Add(newItem)

                If listDuplicates.Contains(fvalue) AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length, 38)) & ")"
                End If
            Next


            Try

            Catch
            End Try


            Me.WCDI_StatusFilter1.SetFieldMaxLength(50)


            ' Add the selected value.
            If Me.WCDI_StatusFilter1.Items.Count = 0 Then
                Me.WCDI_StatusFilter1.Items.Add(New ListItem(Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
            End If

            ' Mark all items to be selected.
            For Each item As ListItem In Me.WCDI_StatusFilter1.Items
                item.Selected = True
            Next

        End Sub



        Public Overridable Function CreateWhereClause_WCDI_StatusFilter1() As WhereClause

            Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False

            Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False

            Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False

            ' Create a where clause for the filter WCDI_StatusFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the WCDI_StatusFilter1QuickSelector

            Dim WCDI_StatusFilter1selectedFilterItemList As New ArrayList()
            Dim WCDI_StatusFilter1itemsString As String = Nothing
            If (Me.InSession(Me.WCDI_StatusFilter1)) Then
                WCDI_StatusFilter1itemsString = Me.GetFromSession(Me.WCDI_StatusFilter1)
            End If

            If (WCDI_StatusFilter1itemsString IsNot Nothing) Then
                Dim WCDI_StatusFilter1itemListFromSession() As String = WCDI_StatusFilter1itemsString.Split(","c)
                For Each item As String In WCDI_StatusFilter1itemListFromSession
                    WCDI_StatusFilter1selectedFilterItemList.Add(item)
                Next
            End If

            WCDI_StatusFilter1selectedFilterItemList = GetSelectedValueList(Me.WCDI_StatusFilter1, WCDI_StatusFilter1selectedFilterItemList)
            Dim wc As New WhereClause
            If WCDI_StatusFilter1selectedFilterItemList Is Nothing OrElse WCDI_StatusFilter1selectedFilterItemList.Count = 0 Then
                wc.RunQuery = False
            Else
                For Each item As String In WCDI_StatusFilter1selectedFilterItemList




                    wc.iOR(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Status, BaseFilter.ComparisonOperator.EqualsTo, item)


                Next
            End If
            Return wc

        End Function




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

            ' Save filter controls to values to session.

            Me.SaveToSession(Me.SortControl, Me.SortControl.SelectedValue)

            Me.SaveToSession(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText, Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text)

            Dim WCDI_StatusFilter1selectedFilterItemList As ArrayList = GetSelectedValueList(Me.WCDI_StatusFilter1, Nothing)
            Dim WCDI_StatusFilter1SessionString As String = ""
            If Not WCDI_StatusFilter1selectedFilterItemList Is Nothing Then
                For Each item As String In WCDI_StatusFilter1selectedFilterItemList
                    WCDI_StatusFilter1Sessionstring = WCDI_StatusFilter1Sessionstring & "," & item
                Next
            End If
            Me.SaveToSession(Me.WCDI_StatusFilter1, WCDI_StatusFilter1Sessionstring)


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

        Protected Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.

            Me.SaveToSession(Me.SortControl, Me.SortControl.SelectedValue)

            Me.SaveToSession("Sel_WCanvass_Detail_Internal_WPR_Line1SearchText_Ajax", Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text)

            Dim WCDI_StatusFilter1selectedFilterItemList As ArrayList = GetSelectedValueList(Me.WCDI_StatusFilter1, Nothing)
            Dim WCDI_StatusFilter1SessionString As String = ""
            If Not WCDI_StatusFilter1selectedFilterItemList Is Nothing Then
                For Each item As String In WCDI_StatusFilter1selectedFilterItemList
                    WCDI_StatusFilter1Sessionstring = WCDI_StatusFilter1Sessionstring & "," & item
                Next
            End If
            Me.SaveToSession("WCDI_StatusFilter1_Ajax", WCDI_StatusFilter1SessionString)

            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath

        End Sub

        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.

            Me.RemoveFromSession(Me.SortControl)
            Me.RemoveFromSession(Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText)
            Me.RemoveFromSession(Me.WCDI_StatusFilter1)

            ' Clear pagination state from session.


            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")

        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Sel_WCanvass_Detail_Internal_WPR_Line1TableControl_OrderBy"), String)

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
                Me.ViewState("Sel_WCanvass_Detail_Internal_WPR_Line1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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

        Public Overridable Sub SetSearchButton1()


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


            If (IsValueSelected(WCDI_StatusFilter1)) Then
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

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.

        ' This is default code for the FieldSort event.


        ' Generate the event handling functions for button events.

        ' event handler for ImageButton
        Public Overridable Sub ExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

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
                Me.TotalRecords = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecordCount(join, wc)
                If Me.TotalRecords > 10000 Then

                    ' Add each of the columns in order of export.
                    Dim columns() As BaseColumn = New BaseColumn() { _
                               Nothing}
                    Dim exportData As ExportDataToCSV = New ExportDataToCSV(Sel_WCanvass_Detail_Internal_WPR_Line1View.Instance, wc, orderBy, columns)
                    exportData.StartExport(Me.Page.Response, True)

                    Dim dataForCSV As DataForExport = New DataForExport(Sel_WCanvass_Detail_Internal_WPR_Line1View.Instance, wc, orderBy, columns, join)

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
                    Dim excelReport As ExportDataToExcel = New ExportDataToExcel(Sel_WCanvass_Detail_Internal_WPR_Line1View.Instance, wc, orderBy)
                    ' Add each of the columns in order of export.
                    ' To customize the data type, change the second parameter of the new ExcelColumn to be
                    ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

                    If Me.Page.Response Is Nothing Then
                        Return
                    End If

                    excelReport.CreateExcelBook()

                    Dim width As Integer = 0
                    Dim columnCounter As Integer = 0
                    Dim data As DataForExport = New DataForExport(Sel_WCanvass_Detail_Internal_WPR_Line1View.Instance, wc, orderBy, Nothing, join)


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
                                    val = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
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
                DbUtils.EndTransaction()
            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub PDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction()

                Dim report As PDFReport = New PDFReport()
                report.SpecificReportFileName = Page.Server.MapPath("Show-WCanvass-Internal1.PDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "sel_WCanvass_Detail_Internal_WPR_Line"
                ' If Show-WCanvass-Internal1.PDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			


                Dim rowsPerQuery As Integer = 5000
                Dim recordCount As Integer = 0

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
                Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()

                Dim pageNum As Integer = 0
                Dim totalRows As Integer = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecordCount(joinFilter, whereClause)
                Dim columns As ColumnList = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetColumnList()
                Dim records As Sel_WCanvass_Detail_Internal_WPR_Line1Record() = Nothing

                Do

                    records = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecords(joinFilter, whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As Sel_WCanvass_Detail_Internal_WPR_Line1Record In records

                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown

                            report.WriteRow()
                        Next
                        pageNum = pageNum + 1
                        recordCount += records.Length
                    End If
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows AndAlso whereClause.RunQuery

                report.Close()
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
            End Try

        End Sub

        ' event handler for ImageButton
        Public Overridable Sub ResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

            Try

                Me.WCDI_StatusFilter1.ClearSelection()
                Me.SortControl.ClearSelection()
                Me.Sel_WCanvass_Detail_Internal_WPR_Line1SearchText.Text = ""
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
        Public Overridable Sub SearchButton1_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)

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
                DbUtils.StartTransaction()

                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("Show-WCanvass-Internal1.WordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "sel_WCanvass_Detail_Internal_WPR_Line"
                ' If Show-WCanvass-Internal1.WordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column

                Dim whereClause As WhereClause = CreateWhereClause

                Dim orderBy As OrderBy = CreateOrderBy
                Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()

                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecordCount(joinFilter, whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetColumnList()
                Dim records As Sel_WCanvass_Detail_Internal_WPR_Line1Record() = Nothing
                Do
                    records = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecords(joinFilter, whereClause, orderBy, pageNum, rowsPerQuery)

                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As Sel_WCanvass_Detail_Internal_WPR_Line1Record In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown

                            report.WriteRow()
                        Next
                        pageNum = pageNum + 1
                        recordCount += records.Length
                    End If
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows AndAlso whereClause.RunQuery
                report.save()
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, True)

            Catch ex As Exception

                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)

            Finally
                DbUtils.EndTransaction()
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
                For Each ColumnNam As BaseClasses.Data.BaseColumn In Sel_WCanvass_Detail_Internal_WPR_Line1View.GetColumns()
                    If ColumnNam.Name.ToUpper = SelVal1 Then
                        SelVal1 = ColumnNam.InternalName.ToString
                    End If
                Next
            End If

            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Sel_WCanvass_Detail_Internal_WPR_Line1View.GetColumnByName(SelVal1))
            If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not Sel_WCanvass_Detail_Internal_WPR_Line1View.GetColumnByName(SelVal1) Is Nothing Then
                    Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)


                If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not Sel_WCanvass_Detail_Internal_WPR_Line1View.GetColumnByName(SelVal1) Is Nothing Then
                    If words1(words1.Length() - 1).Contains("ASC") Then
                        Me.CurrentSortOrder.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.GetColumnByName(SelVal1), OrderByItem.OrderDir.Asc)
                    ElseIf words1(words1.Length() - 1).Contains("DESC") Then
                        Me.CurrentSortOrder.Add(Sel_WCanvass_Detail_Internal_WPR_Line1View.GetColumnByName(SelVal1), OrderByItem.OrderDir.Desc)
                    End If
                End If


            End If
            Me.DataChanged = True


        End Sub

        ' event handler for FieldFilter
        Protected Overridable Sub WCDI_StatusFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True



        End Sub


        ' Generate the event handling functions for others




        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 Then
                    _TotalRecords = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
            Set(ByVal value As OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property

        Public Property DataSource() As Sel_WCanvass_Detail_Internal_WPR_Line1Record()
            Get
                Return DirectCast(MyBase._DataSource, Sel_WCanvass_Detail_Internal_WPR_Line1Record())
            End Get
            Set(ByVal value As Sel_WCanvass_Detail_Internal_WPR_Line1Record())
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

        Public ReadOnly Property ItemDescriptionLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemDescriptionLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property ItemLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemLabel"), System.Web.UI.WebControls.LinkButton)
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

        Public ReadOnly Property SearchButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SearchButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property Sel_WCanvass_Detail_Internal_WPR_Line1SearchText() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1SearchText"), System.Web.UI.WebControls.TextBox)
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

        Public ReadOnly Property UnitOfMeasureLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UnitOfMeasureLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property UnitPriceLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UnitPriceLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Audit_CommentLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Audit_CommentLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label3() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label3"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label4() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label4"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label5() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label5"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label6() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label6"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label7() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label7"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label8() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label8"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Award1Label9() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label9"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label3() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label3"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label4() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label4"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label5() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label5"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label6() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label6"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label7() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label7"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label8() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label8"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_Bid1Label9() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label9"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_CommentLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_CommentLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label3() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label3"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label4() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label4"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label5() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label5"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label6() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label6"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label7() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label7"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label8() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label8"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label9() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label9"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WCDI_StatusFilter1() As BaseClasses.Web.UI.WebControls.QuickSelector
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_StatusFilter1"), BaseClasses.Web.UI.WebControls.QuickSelector)
            End Get
        End Property

        Public ReadOnly Property WCDI_StatusLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_StatusLabel2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property

        Public ReadOnly Property WordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WordButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property

        Public ReadOnly Property WPRL_Ext_PriceLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRL_Ext_PriceLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property

        Public ReadOnly Property WPRL_QtyLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRL_QtyLabel"), System.Web.UI.WebControls.LinkButton)
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
          
        Public Overridable Function GetSelectedRecordControl() As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow)), Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow
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

        Public Overridable Function GetRecordControls() As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow")
            Dim list As New List(Of Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow)
            For Each recCtrl As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow In recCtrls
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

  
' Base class for the WCanvass_Quotation_Internal1TableControlRow control on the Show_WCanvass_Internal1 page.
' Do not modify this class. Instead override any method in WCanvass_Quotation_Internal1TableControlRow.
Public Class BaseWCanvass_Quotation_Internal1TableControlRow
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCanvass_Quotation_Internal1TableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

          
        End Sub

        '  To customize, override this method in WCanvass_Quotation_Internal1TableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
                     
        
              ' Register the event handlers.
          
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCanvass_Quotation_Internal1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseWCanvass_Quotation_Internal1TableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New WCanvass_Quotation_Internal1Record()
          
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCanvass_Quotation_Internal1TableControlRow.
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
        
                SetWCQI_Desc()
                SetWCQI_DescLabel()
                SetWCQI_File()
                SetWCQI_FileLabel()
                SetWCQI_PM00200_Vendor_ID()
                SetWCQI_PM00200_Vendor_IDLabel()
      
      
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
        
        
        Public Overridable Sub SetWCQI_Desc()

                  
            
        
            ' Set the WCQI_Desc Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal record retrieved from the database.
            ' Me.WCQI_Desc is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCQI_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCQI_DescSpecified Then
                				
                ' If the WCQI_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Quotation_Internal1Table.WCQI_Desc)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCQI_Desc.Text = formattedValue
                
            Else 
            
                ' WCQI_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCQI_Desc.Text = WCanvass_Quotation_Internal1Table.WCQI_Desc.Format(WCanvass_Quotation_Internal1Table.WCQI_Desc.DefaultValue)
                        		
                End If
                 
            ' If the WCQI_Desc is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCQI_Desc.Text Is Nothing _
                OrElse Me.WCQI_Desc.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCQI_Desc.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCQI_File()

                  
                
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCQI_FileSpecified Then
                
                Me.WCQI_File.Text = Page.GetResourceValue("Txt:OpenFile", "ePortalWFApproval")
                        
                Me.WCQI_File.OnClientClick = "window.open('../Shared/ExportFieldValue.aspx?Table=" & _
                            Me.Page.Encrypt("WCanvass_Quotation_Internal1") & _
                            "&Field=" & Me.Page.Encrypt("WCQI_File") & _
                            "&Record=" & Me.Page.Encrypt(HttpUtility.UrlEncode(Me.DataSource.GetID().ToString())) & _
                                "','','left=100,top=50,width=400,height=300,resizable,scrollbars=1');return false;"
                   
                Me.WCQI_File.Visible = True
            Else
                Me.WCQI_File.Visible = False
            End If
        End Sub
                
        Public Overridable Sub SetWCQI_PM00200_Vendor_ID()

                  
            
        
            ' Set the WCQI_PM00200_Vendor_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal record retrieved from the database.
            ' Me.WCQI_PM00200_Vendor_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCQI_PM00200_Vendor_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCQI_PM00200_Vendor_IDSpecified Then
                				
                ' If the WCQI_PM00200_Vendor_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCQI_PM00200_Vendor_ID.Text = formattedValue
                
            Else 
            
                ' WCQI_PM00200_Vendor_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCQI_PM00200_Vendor_ID.Text = WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.Format(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCQI_PM00200_Vendor_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCQI_PM00200_Vendor_ID.Text Is Nothing _
                OrElse Me.WCQI_PM00200_Vendor_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCQI_PM00200_Vendor_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCQI_DescLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCQI_FileLabel()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCQI_PM00200_Vendor_IDLabel()

                  
                  
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

      
        
        ' To customize, override this method in WCanvass_Quotation_Internal1TableControlRow.
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
        
        Dim parentCtrl As WCanvass_InternalRecordControl
          
          				  
          parentCtrl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ePortalWFApproval"))
            End If
            
            Me.DataSource.WCQI_WCI_ID = parentCtrl.DataSource.WCI_ID
              
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
              
                DirectCast(GetParentControlObject(Me, "WCanvass_Quotation_Internal1TableControl"), WCanvass_Quotation_Internal1TableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "WCanvass_Quotation_Internal1TableControl"), WCanvass_Quotation_Internal1TableControl).ResetData = True
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

        ' To customize, override this method in WCanvass_Quotation_Internal1TableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCQI_Desc()
            GetWCQI_PM00200_Vendor_ID()
        End Sub
        
        
        Public Overridable Sub GetWCQI_Desc()
            
        End Sub
                
        Public Overridable Sub GetWCQI_PM00200_Vendor_ID()
            
        End Sub
                
      
        ' To customize, override this method in WCanvass_Quotation_Internal1TableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False
      
        Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False
      
        Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False
      
            Return Nothing
            
        End Function
        
    

        ' To customize, override this method in WCanvass_Quotation_Internal1TableControlRow.
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
          WCanvass_Quotation_Internal1Table.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "WCanvass_Quotation_Internal1TableControl"), WCanvass_Quotation_Internal1TableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "WCanvass_Quotation_Internal1TableControl"), WCanvass_Quotation_Internal1TableControl).ResetData = True
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
                Return CType(Me.ViewState("BaseWCanvass_Quotation_Internal1TableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCanvass_Quotation_Internal1TableControlRow_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCanvass_Quotation_Internal1Record
            Get
                Return DirectCast(MyBase._DataSource, WCanvass_Quotation_Internal1Record)
            End Get
            Set(ByVal value As WCanvass_Quotation_Internal1Record)
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
        
        Public ReadOnly Property WCQI_Desc() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_Desc"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCQI_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCQI_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property WCQI_FileLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_FileLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCQI_PM00200_Vendor_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_PM00200_Vendor_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCQI_PM00200_Vendor_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_PM00200_Vendor_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WCanvass_Quotation_Internal1Record = Nothing
             
        
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
            
            Dim rec As WCanvass_Quotation_Internal1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCanvass_Quotation_Internal1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCanvass_Quotation_Internal1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the WCanvass_Quotation_Internal1TableControl control on the Show_WCanvass_Internal1 page.
' Do not modify this class. Instead override any method in WCanvass_Quotation_Internal1TableControl.
Public Class BaseWCanvass_Quotation_Internal1TableControl
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
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WCanvass_Quotation_Internal1SearchText) 				
                    initialVal = Me.GetFromSession(Me.WCanvass_Quotation_Internal1SearchText)
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Me.WCanvass_Quotation_Internal1SearchText.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.WCQI_PM00200_Vendor_IDFilter1) 				
                    initialVal = Me.GetFromSession(Me.WCQI_PM00200_Vendor_IDFilter1)
                
                Else
                    
                    initialVal = EvaluateFormula("URL(""WCQI_PM00200_Vendor_ID"")")
                
              End If
              
                If InvariantEquals(initialVal, "Search for", True) Or InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing), True) Then
                  initialVal = ""
                End If
              
                If initialVal <> ""				
                        
                        Dim WCQI_PM00200_Vendor_IDFilter1itemListFromSession() As String = initialVal.Split(","c)
                        Dim index As Integer = 0
                        For Each item As String In WCQI_PM00200_Vendor_IDFilter1itemListFromSession
                            If index = 0 AndAlso _
                               item.ToString.Equals("") Then
                            Else
                                Me.WCQI_PM00200_Vendor_IDFilter1.Items.Add(item)
                                Me.WCQI_PM00200_Vendor_IDFilter1.Items.Item(index).Selected = True
                                index += 1
                            End If
                        Next
                        Dim listItem As ListItem
                        For Each listItem In Me.WCQI_PM00200_Vendor_IDFilter1.Items
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
            
              AddHandler Me.Pagination1.FirstPage.Click, AddressOf Pagination1_FirstPage_Click
                        
              AddHandler Me.Pagination1.LastPage.Click, AddressOf Pagination1_LastPage_Click
                        
              AddHandler Me.Pagination1.NextPage.Click, AddressOf Pagination1_NextPage_Click
                        
              AddHandler Me.Pagination1.PageSizeButton.Click, AddressOf Pagination1_PageSizeButton_Click
                        
              AddHandler Me.Pagination1.PreviousPage.Click, AddressOf Pagination1_PreviousPage_Click
                                    
            Dim url As String = ""  'to avoid warning in VS 
            url = "" 'to avoid warning in VS 
            ' Setup the sorting events.
          
            ' Setup the button events.
          
              AddHandler Me.ExcelButton1.Click, AddressOf ExcelButton1_Click
                        
              AddHandler Me.PDFButton1.Click, AddressOf PDFButton1_Click
                        
              AddHandler Me.ResetButton1.Click, AddressOf ResetButton1_Click
                        
              AddHandler Me.SearchButton3.Click, AddressOf SearchButton3_Click
                        
              AddHandler Me.WordButton1.Click, AddressOf WordButton1_Click
                        
              AddHandler Me.Actions1Button.Button.Click, AddressOf Actions1Button_Click
                        
              AddHandler Me.FilterButton1.Button.Click, AddressOf FilterButton1_Click
                        
              AddHandler Me.Filters1Button.Button.Click, AddressOf Filters1Button_Click
                        
            AddHandler Me.SortControl1.SelectedIndexChanged, AddressOf SortControl1_SelectedIndexChanged
              AddHandler Me.WCQI_PM00200_Vendor_IDFilter1.SelectedIndexChanged, AddressOf WCQI_PM00200_Vendor_IDFilter1_SelectedIndexChanged                  
                        
        
          ' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(Me, Me.GetType(), "WCanvass_Quotation_Internal1SearchTextSearchBoxText", "setSearchBoxText(""" & BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) & """, """ & WCanvass_Quotation_Internal1SearchText.ClientID & """);", True)                  
            
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(WCanvass_Quotation_Internal1Record)), WCanvass_Quotation_Internal1Record())
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
                    For Each rc As WCanvass_Quotation_Internal1TableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(WCanvass_Quotation_Internal1Record)), WCanvass_Quotation_Internal1Record())
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
            ByVal pageSize As Integer) As WCanvass_Quotation_Internal1Record()
            
            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList     
                        

    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCanvass_Quotation_Internal1Table.Column1, True)         
            ' selCols.Add(WCanvass_Quotation_Internal1Table.Column2, True)          
            ' selCols.Add(WCanvass_Quotation_Internal1Table.Column3, True)    
   
            
            
            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
              
                Return WCanvass_Quotation_Internal1Table.GetRecords(join, where, orderBy, Me.PageIndex, Me.PageSize)
                 
            Else
                Dim databaseTable As New WCanvass_Quotation_Internal1Table
                databaseTable.SelectedColumns.Clear()
                databaseTable.SelectedColumns.AddRange(selCols)
                
                ' Stored Procedures provided by Iron Speed Designer specifies to query all columns, in order to query a subset of columns, it is necessary to disable stored procedures                  
                databaseTable.DataAdapter.DisableStoredProcedures = True 
                
            
                
                Dim recList As ArrayList
                orderBy.ExpandForeignKeyColums = False
                recList = databaseTable.GetRecordList(join, where.GetFilter(), Nothing, orderBy, pageIndex, pageSize)
                Return CType(recList.ToArray(GetType(WCanvass_Quotation_Internal1Record)), WCanvass_Quotation_Internal1Record())
            End If            
            
        End Function        
        
        
        Public Overridable Function GetRecordCount(ByVal join As BaseFilter, ByVal where As WhereClause) As Integer


            ' By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            Dim selCols As New ColumnList                 
               
    
            ' If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            ' However, if you don't specify PK, row button click might show an error message.
            ' And make sure you write similar code in GetRecordCount as well
            ' selCols.Add(WCanvass_Quotation_Internal1Table.Column1, True)         
            ' selCols.Add(WCanvass_Quotation_Internal1Table.Column2, True)          
            ' selCols.Add(WCanvass_Quotation_Internal1Table.Column3, True)          


            ' If the parameters doesn't specify specific columns in the Select statement, then run Select *
            ' Alternatively, if the parameters specifies to include PK, also run Select *
            
            If selCols.Count = 0 Then                    
                     
                Return WCanvass_Quotation_Internal1Table.GetRecordCount(join, where)

            Else
                Dim databaseTable As New WCanvass_Quotation_Internal1Table
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
          
          Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCanvass_Quotation_Internal1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
          If rep Is Nothing Then Return
          rep.DataSource = DataSource()
          rep.DataBind()
                  
          Dim index As Integer = 0
          
          For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
          
            ' Loop through all rows in the table, set its DataSource and call DataBind().
            Dim recControl As WCanvass_Quotation_Internal1TableControlRow = DirectCast(repItem.FindControl("WCanvass_Quotation_Internal1TableControlRow"), WCanvass_Quotation_Internal1TableControlRow)
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
                
                SetWCanvass_Quotation_Internal1SearchText()
                SetWCQI_PM00200_Vendor_IDFilter1()
                SetWCQI_PM00200_Vendor_IDLabel2()
                
                SetExcelButton1()
              
                SetPDFButton1()
              
                SetResetButton1()
              
                SetSearchButton3()
              
                SetWordButton1()
              
                SetActions1Button()
              
                SetFilterButton1()
              
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

            
            Me.WCQI_PM00200_Vendor_IDFilter1.ClearSelection()
            
            Me.SortControl1.ClearSelection()
            
            Me.WCanvass_Quotation_Internal1SearchText.Text = ""
            
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

            ' Bind the buttons for WCanvass_Quotation_Internal1TableControl pagination.
        
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
            
            Dim recCtl As WCanvass_Quotation_Internal1TableControlRow
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
            WCanvass_Quotation_Internal1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
            
        Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False
      
        Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False
      
        Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False
      
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim wCanvass_InternalRecordControlObj as WCanvass_InternalRecordControl = DirectCast(MiscUtils.GetParentControlObject(Me, "WCanvass_InternalRecordControl") ,WCanvass_InternalRecordControl)
                              
                If (Not IsNothing(wCanvass_InternalRecordControlObj) AndAlso Not IsNothing(wCanvass_InternalRecordControlObj.GetRecord()) AndAlso wCanvass_InternalRecordControlObj.GetRecord().IsCreated AndAlso Not IsNothing(wCanvass_InternalRecordControlObj.GetRecord().WCI_ID))
                    wc.iAND(WCanvass_Quotation_Internal1Table.WCQI_WCI_ID, BaseFilter.ComparisonOperator.EqualsTo, wCanvass_InternalRecordControlObj.GetRecord().WCI_ID.ToString())
                    selectedRecordKeyValue.AddElement(WCanvass_Quotation_Internal1Table.WCQI_WCI_ID.InternalName, wCanvass_InternalRecordControlObj.GetRecord().WCI_ID.ToString())
                Else
                    wc.RunQuery = False
                    Return wc                    
                End If          
              
      HttpContext.Current.Session("WCanvass_Quotation_Internal1TableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            If IsValueSelected(Me.WCanvass_Quotation_Internal1SearchText) Then
              If Me.WCanvass_Quotation_Internal1SearchText.Text = BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) Then
                 Me.WCanvass_Quotation_Internal1SearchText.Text = ""
              Else
              ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
              
                If Me.WCanvass_Quotation_Internal1SearchText.Text.StartsWith(BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing)) Then
                Me.WCanvass_Quotation_Internal1SearchText.Text = ""
                Else
              
                    If Me.WCanvass_Quotation_Internal1SearchText.Text.StartsWith("...") Then
                        Me.WCanvass_Quotation_Internal1SearchText.Text = Me.WCanvass_Quotation_Internal1SearchText.Text.SubString(3,Me.WCanvass_Quotation_Internal1SearchText.Text.Length-3)
                    End If
                    If Me.WCanvass_Quotation_Internal1SearchText.Text.EndsWith("...") then
                        Me.WCanvass_Quotation_Internal1SearchText.Text = Me.WCanvass_Quotation_Internal1SearchText.Text.SubString(0,Me.WCanvass_Quotation_Internal1SearchText.Text.Length-3)
                        ' Strip the last word as well as it is likely only a partial word
                        Dim endindex As Integer = WCanvass_Quotation_Internal1SearchText.Text.Length - 1
                        While (Not Char.IsWhiteSpace(WCanvass_Quotation_Internal1SearchText.Text(endindex)) AndAlso endindex > 0)
                            endindex -= 1
                        End While
                        If endindex > 0 Then
                            WCanvass_Quotation_Internal1SearchText.Text = WCanvass_Quotation_Internal1SearchText.Text.Substring(0, endindex)
                        End If
              End If
            End If
            
              End If
            
              Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.WCanvass_Quotation_Internal1SearchText, Me.GetFromSession(Me.WCanvass_Quotation_Internal1SearchText))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.WCanvass_Quotation_Internal1SearchText) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    Dim search As WhereClause = New WhereClause()
                    
      Dim cols As New ColumnList    
        
      cols.Add(WCanvass_Quotation_Internal1Table.WCQI_Desc, True)
      
      For Each col As BaseColumn in cols
      
                    search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.WCanvass_Quotation_Internal1SearchText, Me.GetFromSession(Me.WCanvass_Quotation_Internal1SearchText)), True, False)
        
      Next
    
                    wc.iAND(search)
                End If
            End If
                  

                  Dim totalSelectedItemCount as Integer = 0
                  
            If IsValueSelected(Me.WCQI_PM00200_Vendor_IDFilter1) Then
    
              hasFiltersWCanvass_Quotation_Internal1TableControl = True            
    
                Dim item As ListItem
                Dim selectedItemCount As Integer = 0
                For Each item In Me.WCQI_PM00200_Vendor_IDFilter1.Items
                    If item.Selected Then
                        selectedItemCount += 1
                        
                          totalSelectedItemCount += 1
                        
                    End If
                Next
                
                Dim filter As WhereClause = New WhereClause
                For Each item In Me.WCQI_PM00200_Vendor_IDFilter1.Items
                    If item.Selected AndAlso (item.Value = "--ANY--" OrElse item.Value = "--PLEASE_SELECT--") AndAlso selectedItemCount > 1 Then
                        item.Selected = False
                    End If
                    If item.Selected Then
                        filter.iOR(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID, BaseFilter.ComparisonOperator.EqualsTo, item.Value, False, False)
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
            WCanvass_Quotation_Internal1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
          Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False
        
          Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False
        
          Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False
        
      ' Compose the WHERE clause consist of:
      ' 1. Static clause defined at design time.
      ' 2. User selected search criteria.
      ' 3. User selected filter criteria.

      Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
      
            Dim selectedRecordInWCanvass_InternalRecordControl as String = DirectCast(HttpContext.Current.Session("WCanvass_Quotation_Internal1TableControlWhereClause"), String)
            
            If Not selectedRecordInWCanvass_InternalRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInWCanvass_InternalRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInWCanvass_InternalRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(WCanvass_Quotation_Internal1Table.WCQI_WCI_ID) Then
            wc.iAND(WCanvass_Quotation_Internal1Table.WCQI_WCI_ID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(WCanvass_Quotation_Internal1Table.WCQI_WCI_ID).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            If IsValueSelected(searchText) and fromSearchControl = "WCanvass_Quotation_Internal1SearchText" Then
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
        
      cols.Add(WCanvass_Quotation_Internal1Table.WCQI_Desc, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
      Next
    
                    Else
                        
      Dim cols As New ColumnList    
        
      cols.Add(WCanvass_Quotation_Internal1Table.WCQI_Desc, True)
      
      For Each col As BaseColumn in cols
      
                        search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
      Next
    
                    End If
                    wc.iAND(search)
                End If
            End If
                  
            Dim WCQI_PM00200_Vendor_IDFilter1SelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "WCQI_PM00200_Vendor_IDFilter1_Ajax"), String)
            If IsValueSelected(WCQI_PM00200_Vendor_IDFilter1SelectedValue) Then
    
              hasFiltersWCanvass_Quotation_Internal1TableControl = True            
    
            If Not isNothing(WCQI_PM00200_Vendor_IDFilter1SelectedValue) Then
                Dim WCQI_PM00200_Vendor_IDFilter1itemListFromSession() As String = WCQI_PM00200_Vendor_IDFilter1SelectedValue.Split(","c)
                Dim index As Integer = 0
                  
                Dim filter As WhereClause = New WhereClause
                For Each item As String In WCQI_PM00200_Vendor_IDFilter1itemListFromSession
                    If index = 0 AndAlso item.ToString.Equals("") Then
                    Else
                        filter.iOR(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID, BaseFilter.ComparisonOperator.EqualsTo, item, False, False)
                        index += 1
                    End If
                Next
                wc.iAND(filter)
                
             End If
                
             End If
                      
      
      
            Return wc
        End Function

      
        Public Overridable Function GetAutoCompletionList_WCanvass_Quotation_Internal1SearchText(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            
            Dim filterJoin As CompoundFilter = CreateCompoundJoinFilter()
            If count = 0 Then count = 10
            Dim wc As WhereClause = CreateWhereClause(prefixText,"WCanvass_Quotation_Internal1SearchText", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            Dim recordList () As ePortalWFApproval.Business.WCanvass_Quotation_Internal1Record = WCanvass_Quotation_Internal1Table.GetRecords(filterJoin, wc, Nothing, 0, count,count)
            Dim rec As WCanvass_Quotation_Internal1Record = Nothing
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
        
                resultItem = rec.Format(WCanvass_Quotation_Internal1Table.WCQI_Desc)
                If resultItem IsNot Nothing Then
                    Dim prText As String = prefixText
                    If WCanvass_Quotation_Internal1Table.WCQI_Desc.IsFullTextSearchable Then
                         Dim ft As FullTextExpression = New FullTextExpression()
                         prText = ft.GetFirstNonExcludedTerm(prText)
                    End If
                    If Not String.IsNullOrEmpty(prText) AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
  
                        Dim isAdded As Boolean = FormatSuggestions(prText, resultItem, 50, "InMiddleOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, WCanvass_Quotation_Internal1Table.WCQI_Desc.IsFullTextSearchable)
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCanvass_Quotation_Internal1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As WCanvass_Quotation_Internal1TableControlRow = DirectCast(repItem.FindControl("WCanvass_Quotation_Internal1TableControlRow"), WCanvass_Quotation_Internal1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As WCanvass_Quotation_Internal1Record = New WCanvass_Quotation_Internal1Record()
        
                        If recControl.WCQI_Desc.Text <> "" Then
                            rec.Parse(recControl.WCQI_Desc.Text, WCanvass_Quotation_Internal1Table.WCQI_Desc)
                        End If
                        If recControl.WCQI_File.Text <> "" Then
                            rec.Parse(recControl.WCQI_File.Text, WCanvass_Quotation_Internal1Table.WCQI_File)
                        End If
                        If recControl.WCQI_PM00200_Vendor_ID.Text <> "" Then
                            rec.Parse(recControl.WCQI_PM00200_Vendor_ID.Text, WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If
            
    
            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
              
                newRecordList.Insert(0, New WCanvass_Quotation_Internal1Record())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
              
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(WCanvass_Quotation_Internal1Record)), WCanvass_Quotation_Internal1Record())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As WCanvass_Quotation_Internal1TableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As WCanvass_Quotation_Internal1TableControlRow) As Boolean
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
                
        Public Overridable Sub SetWCQI_PM00200_Vendor_IDLabel2()

                  
                  
                  End Sub
                
        Public Overridable Sub SetSortControl1()

              
            
                Me.PopulateSortControl1(GetSelectedValue(Me.SortControl1,  GetFromSession(Me.SortControl1)), 500)					
                    
        End Sub
            
        Public Overridable Sub SetWCanvass_Quotation_Internal1SearchText()

              
                                            
          Me.WCanvass_Quotation_Internal1SearchText.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "') {this.value='';this.className='Search_Input';}")
          Me.WCanvass_Quotation_Internal1SearchText.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", Nothing) + "';this.className='Search_InputHint';}")
                                   
              End Sub	
            
        Public Overridable Sub SetWCQI_PM00200_Vendor_IDFilter1()

              
            
            Dim WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList As New ArrayList()
            Dim WCQI_PM00200_Vendor_IDFilter1itemsString As String = Nothing
            If (Me.InSession(Me.WCQI_PM00200_Vendor_IDFilter1)) Then
                WCQI_PM00200_Vendor_IDFilter1itemsString = Me.GetFromSession(Me.WCQI_PM00200_Vendor_IDFilter1)
            End If
            
            If (WCQI_PM00200_Vendor_IDFilter1itemsString IsNot Nothing) Then
                Dim WCQI_PM00200_Vendor_IDFilter1itemListFromSession() As String = WCQI_PM00200_Vendor_IDFilter1itemsString.Split(","c)
                For Each item as String In WCQI_PM00200_Vendor_IDFilter1itemListFromSession
                    WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList.Add(item)
                Next
            End If
              
            		
            Me.PopulateWCQI_PM00200_Vendor_IDFilter1(GetSelectedValueList(Me.WCQI_PM00200_Vendor_IDFilter1, WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList), 500)
                    
              Dim url as String = Me.ModifyRedirectUrl("../WCanvass_Quotation_Internal1/WCanvass-Quotation-Internal-QuickSelector1.aspx", "", True)
              
              url = Me.Page.ModifyRedirectUrl(url, "", True)                                  
              
              url &= "?Target=" & Me.WCQI_PM00200_Vendor_IDFilter1.ClientID & "&IndexField=" & CType(Me.Page, BaseApplicationPage).Encrypt("WCQI_PM00200_Vendor_ID")& "&EmptyValue=" & CType(Me.Page, BaseApplicationPage).Encrypt("--ANY--") & "&EmptyDisplayText=" & CType(Me.Page, BaseApplicationPage).Encrypt(Me.Page.GetResourceValue("Txt:All")) & "&RedirectStyle=" & CType(Me.Page, BaseApplicationPage).Encrypt("Popup")
              
              
              Me.WCQI_PM00200_Vendor_IDFilter1.Attributes.Item("onClick") = "initializePopupPage(this, '" & url & "', " & Convert.ToString(WCQI_PM00200_Vendor_IDFilter1.AutoPostBack).ToLower() & ", event); return false;"        
                  
                                 
              End Sub	
            
        ' Get the filters' data for SortControl1
        Protected Overridable Sub PopulateSortControl1(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
                Me.SortControl1.Items.Clear()

                ' 1. Setup the static list items
                							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCQI Description {Txt:Ascending}"), "WCQI_Desc Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCQI Description {Txt:Descending}"), "WCQI_Desc Desc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCQI PM 00200 Vendor {Txt:Ascending}"), "WCQI_PM00200_Vendor_ID Asc"))
                            							
            Me.SortControl1.Items.Add(New ListItem(Me.Page.ExpandResourceValue("WCQI PM 00200 Vendor {Txt:Descending}"), "WCQI_PM00200_Vendor_ID Desc"))
                            

            Try    
                ' Set the selected value.
                SetSelectedValue(Me.SortControl1, selectedValue)

                
            Catch
            End Try
            
            If Me.SortControl1.SelectedValue IsNot Nothing AndAlso Me.SortControl1.Items.FindByValue(Me.SortControl1.SelectedValue) Is Nothing
                Me.SortControl1.SelectedValue = Nothing
            End If

              End Sub
            
        ' Get the filters' data for WCQI_PM00200_Vendor_IDFilter1
        Protected Overridable Sub PopulateWCQI_PM00200_Vendor_IDFilter1(ByVal selectedValue As ArrayList, ByVal maxItems As Integer)
                    
            'Setup the WHERE clause.
            
            Dim wc As WhereClause = Me.CreateWhereClause_WCQI_PM00200_Vendor_IDFilter1()
            Me.WCQI_PM00200_Vendor_IDFilter1.Items.Clear()
            		  			
            ' Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCQI_PM00200_Vendor_IDFilter1 function.
            ' It is better to customize the where clause there.
            
            
            
            Dim orderBy As OrderBy = New OrderBy(False, False)
            orderBy.Add(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID, OrderByItem.OrderDir.Asc)                
            
            	

            Dim values(-1) As String
            If wc.RunQuery Then
            
                values = WCanvass_Quotation_Internal1Table.GetValues(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID, wc, orderBy, maxItems)
            
            End If
            
                  
            Dim cvalue As String
            
            Dim listDuplicates As New ArrayList()
            For Each cvalue In values
                ' Create the item and add to the list.
                Dim fvalue As String
                If ( WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.IsColumnValueTypeBoolean()) Then
                    fvalue = cvalue
                Else
                    fvalue = WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.Format(cvalue)
                End If

                If (IsNothing(fvalue)) Then
                    fvalue = ""
                End If

                fvalue = fvalue.Trim()

                If ( fvalue.Length > 50 ) Then
                    fvalue = fvalue.Substring(0, 50) & "..."
                End If

                Dim dupItem As ListItem = Me.WCQI_PM00200_Vendor_IDFilter1.Items.FindByText(fvalue)
                
                If Not IsNothing(dupItem) Then
                    listDuplicates.Add(fvalue)
                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                    End If
                End If

                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                Me.WCQI_PM00200_Vendor_IDFilter1.Items.Add(newItem)

                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                End If
            Next
                                  

            Try    
                
            Catch
            End Try
            
            
            Me.WCQI_PM00200_Vendor_IDFilter1.SetFieldMaxLength(50)
                                 
                  
            ' Add the selected value.
            If Me.WCQI_PM00200_Vendor_IDFilter1.Items.Count = 0 Then
                Me.WCQI_PM00200_Vendor_IDFilter1.Items.Add(New ListItem(Page.GetResourceValue("Txt:All", "ePortalWFApproval"), "--ANY--"))
            End If
            
            ' Mark all items to be selected.
            For Each item As ListItem in Me.WCQI_PM00200_Vendor_IDFilter1.Items
                item.Selected = True
            Next
                              
        End Sub
            
              

        Public Overridable Function CreateWhereClause_WCQI_PM00200_Vendor_IDFilter1() As WhereClause
          
              Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False
            
              Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False
            
              Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False
            
            ' Create a where clause for the filter WCQI_PM00200_Vendor_IDFilter1.
            ' This function is called by the Populate method to load the items 
            ' in the WCQI_PM00200_Vendor_IDFilter1QuickSelector
            
            Dim WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList As New ArrayList()
            Dim WCQI_PM00200_Vendor_IDFilter1itemsString As String = Nothing
            If (Me.InSession(Me.WCQI_PM00200_Vendor_IDFilter1)) Then
                WCQI_PM00200_Vendor_IDFilter1itemsString = Me.GetFromSession(Me.WCQI_PM00200_Vendor_IDFilter1)
            End If
            
            If (WCQI_PM00200_Vendor_IDFilter1itemsString IsNot Nothing) Then
                Dim WCQI_PM00200_Vendor_IDFilter1itemListFromSession() As String = WCQI_PM00200_Vendor_IDFilter1itemsString.Split(","c)
                For Each item as String In WCQI_PM00200_Vendor_IDFilter1itemListFromSession
                    WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList.Add(item)
                Next
            End If
              
            WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList = GetSelectedValueList(Me.WCQI_PM00200_Vendor_IDFilter1, WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList) 
            Dim wc As New WhereClause
            If WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList Is Nothing OrElse WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList.Count = 0 Then
                wc.RunQuery = False
            Else            
                For Each item As String In WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList
              
            
      
   
                    wc.iOR(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID, BaseFilter.ComparisonOperator.EqualsTo, item)

                                
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
        
            Me.SaveToSession(Me.SortControl1, Me.SortControl1.SelectedValue)
                  
            Me.SaveToSession(Me.WCanvass_Quotation_Internal1SearchText, Me.WCanvass_Quotation_Internal1SearchText.Text)
                  
            Dim WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList As ArrayList = GetSelectedValueList(Me.WCQI_PM00200_Vendor_IDFilter1, Nothing)
            Dim WCQI_PM00200_Vendor_IDFilter1SessionString As String = ""
            If Not WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList is Nothing Then
            For Each item As String In WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList
                WCQI_PM00200_Vendor_IDFilter1Sessionstring = WCQI_PM00200_Vendor_IDFilter1Sessionstring & "," & item
            Next
            End If
            Me.SaveToSession(Me.WCQI_PM00200_Vendor_IDFilter1, WCQI_PM00200_Vendor_IDFilter1Sessionstring)
                  
        
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
                  
      Me.SaveToSession("WCanvass_Quotation_Internal1SearchText_Ajax", Me.WCanvass_Quotation_Internal1SearchText.Text)
              
            Dim WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList As ArrayList = GetSelectedValueList(Me.WCQI_PM00200_Vendor_IDFilter1, Nothing)
            Dim WCQI_PM00200_Vendor_IDFilter1SessionString As String = ""
            If Not WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList is Nothing Then
            For Each item As String In WCQI_PM00200_Vendor_IDFilter1selectedFilterItemList
                WCQI_PM00200_Vendor_IDFilter1Sessionstring = WCQI_PM00200_Vendor_IDFilter1Sessionstring & "," & item
            Next
            End If
            Me.SaveToSession("WCQI_PM00200_Vendor_IDFilter1_Ajax", WCQI_PM00200_Vendor_IDFilter1SessionString)
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.SortControl1)
            Me.RemoveFromSession(Me.WCanvass_Quotation_Internal1SearchText)
            Me.RemoveFromSession(Me.WCQI_PM00200_Vendor_IDFilter1)
    
            ' Clear pagination state from session.
         
    
    ' Clear table properties from the session.
    Me.RemoveFromSession(Me, "Order_By")
    Me.RemoveFromSession(Me, "Page_Index")
    Me.RemoveFromSession(Me, "Page_Size")
    
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("WCanvass_Quotation_Internal1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WCanvass_Quotation_Internal1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
            
        Public Overridable Sub SetActions1Button()                
              
   
        End Sub
            
        Public Overridable Sub SetFilterButton1()                
              
   
        End Sub
            
        Public Overridable Sub SetFilters1Button()                
                      
         Dim themeButtonFilters1Button As IThemeButtonWithArrow = DirectCast(MiscUtils.FindControlRecursively(Me, "Filters1Button"), IThemeButtonWithArrow)
         themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png"
    
      
            If (IsValueSelected(WCQI_PM00200_Vendor_IDFilter1)) Then
                themeButtonFilters1Button.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png"
            End If
        
   
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
              Me.TotalRecords = WCanvass_Quotation_Internal1Table.GetRecordCount(join, wc)
              If Me.TotalRecords > 10000 Then
          
              ' Add each of the columns in order of export.
              Dim columns() as BaseColumn = New BaseColumn() { _
                         WCanvass_Quotation_Internal1Table.WCQI_Desc, _ 
             WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID, _ 
             Nothing}
              Dim  exportData as ExportDataToCSV = New ExportDataToCSV(WCanvass_Quotation_Internal1Table.Instance, wc, orderBy, columns)
              exportData.StartExport(Me.Page.Response, True)

              Dim dataForCSV As DataForExport = New DataForExport(WCanvass_Quotation_Internal1Table.Instance, wc, orderBy, columns, join)

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
              Dim excelReport As ExportDataToExcel = New ExportDataToExcel(WCanvass_Quotation_Internal1Table.Instance, wc, orderBy)
              ' Add each of the columns in order of export.
              ' To customize the data type, change the second parameter of the new ExcelColumn to be
              ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              If Me.Page.Response Is Nothing Then
                Return
              End If

              excelReport.CreateExcelBook()

              Dim width As Integer = 0
              Dim columnCounter As Integer = 0
              Dim data As DataForExport = New DataForExport(WCanvass_Quotation_Internal1Table.Instance, wc, orderBy, Nothing, join)
                       data.ColumnList.Add(New ExcelColumn(WCanvass_Quotation_Internal1Table.WCQI_Desc, "Default"))
             data.ColumnList.Add(New ExcelColumn(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID, "Default"))


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
                              val = WCanvass_Quotation_Internal1Table.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, Nothing)
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
                report.SpecificReportFileName = Page.Server.MapPath("Show-WCanvass-Internal1.PDFButton1.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "WCanvass_Quotation_Internal"
                ' If Show-WCanvass-Internal1.PDFButton1.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(WCanvass_Quotation_Internal1Table.WCQI_Desc.Name, ReportEnum.Align.Left, "${WCQI_Desc}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.Name, ReportEnum.Align.Left, "${WCQI_PM00200_Vendor_ID}", ReportEnum.Align.Left, 15)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
                
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = WCanvass_Quotation_Internal1Table.GetRecordCount(joinFilter,whereClause)
                Dim columns As ColumnList = WCanvass_Quotation_Internal1Table.GetColumnList()
                Dim records As WCanvass_Quotation_Internal1Record() = Nothing
            
                Do 
                    
                    records = WCanvass_Quotation_Internal1Table.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As WCanvass_Quotation_Internal1Record In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${WCQI_Desc}", record.Format(WCanvass_Quotation_Internal1Table.WCQI_Desc), ReportEnum.Align.Left, 300)
                             report.AddData("${WCQI_PM00200_Vendor_ID}", record.Format(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID), ReportEnum.Align.Left, 300)

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
    
              Me.WCQI_PM00200_Vendor_IDFilter1.ClearSelection()
            Me.SortControl1.ClearSelection()
              Me.WCanvass_Quotation_Internal1SearchText.Text = ""
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
                report.SpecificReportFileName = Page.Server.MapPath("Show-WCanvass-Internal1.WordButton1.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "WCanvass_Quotation_Internal"
                ' If Show-WCanvass-Internal1.WordButton1.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(WCanvass_Quotation_Internal1Table.WCQI_Desc.Name, ReportEnum.Align.Left, "${WCQI_Desc}", ReportEnum.Align.Left, 28)
                 report.AddColumn(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.Name, ReportEnum.Align.Left, "${WCQI_PM00200_Vendor_ID}", ReportEnum.Align.Left, 15)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
              Dim joinFilter As BaseFilter = CreateCompoundJoinFilter()
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = WCanvass_Quotation_Internal1Table.GetRecordCount(joinFilter,whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ePortalWFApproval")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = WCanvass_Quotation_Internal1Table.GetColumnList()
                Dim records As WCanvass_Quotation_Internal1Record() = Nothing
                Do
                    records = WCanvass_Quotation_Internal1Table.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery)
                    
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                      For Each record As WCanvass_Quotation_Internal1Record In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${WCQI_Desc}", record.Format(WCanvass_Quotation_Internal1Table.WCQI_Desc), ReportEnum.Align.Left, 300)
                             report.AddData("${WCQI_PM00200_Vendor_ID}", record.Format(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID), ReportEnum.Align.Left, 300)

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
        Public Overridable Sub Actions1Button_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
                For Each ColumnNam As BaseClasses.Data.BaseColumn In WCanvass_Quotation_Internal1Table.GetColumns()
                If ColumnNam.Name.ToUpper = SelVal1 Then
                SelVal1 = ColumnNam.InternalName.ToString
                End If
                Next
                End If
              
                Dim sd As OrderByItem= Me.CurrentSortOrder.Find(WCanvass_Quotation_Internal1Table.GetColumnByName(SelVal1))
                If sd Is Nothing Or Not Me.CurrentSortOrder.Items Is Nothing Then
                'First time sort, so add sort order for Discontinued.
                If Not WCanvass_Quotation_Internal1Table.GetColumnByName(SelVal1) Is Nothing Then
                  Me.CurrentSortOrder.Reset()
                End If
                'If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
                 If TypeOf Me.CurrentSortOrder Is GeoOrderBy Then Me.CurrentSortOrder = New OrderBy(True, False)

          
            If SelVal1 <> "--PLEASE_SELECT--" AndAlso Not WCanvass_Quotation_Internal1Table.GetColumnByName(SelVal1) Is Nothing Then
                  If  words1(words1.Length() - 1).Contains("ASC") Then
            Me.CurrentSortOrder.Add(WCanvass_Quotation_Internal1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Asc)
                  Elseif words1(words1.Length() - 1).Contains("DESC") Then
            Me.CurrentSortOrder.Add(WCanvass_Quotation_Internal1Table.GetColumnByName(SelVal1),OrderByItem.OrderDir.Desc)
                  End If
                End If

              
             End If
              Me.DataChanged = true
              
            	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub WCQI_PM00200_Vendor_IDFilter1_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
                    _TotalRecords = WCanvass_Quotation_Internal1Table.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause())
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
        
        Public Property DataSource() As WCanvass_Quotation_Internal1Record ()
            Get
                Return DirectCast(MyBase._DataSource, WCanvass_Quotation_Internal1Record())
            End Get
            Set(ByVal value() As WCanvass_Quotation_Internal1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Actions1Button() As ePortalWFApproval.UI.IThemeButtonWithArrow
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Actions1Button"), ePortalWFApproval.UI.IThemeButtonWithArrow)
          End Get
          End Property
        
        Public ReadOnly Property ExcelButton1() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ExcelButton1"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property FilterButton1() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "FilterButton1"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
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
        
        Public ReadOnly Property Title1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Title1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCanvass_Quotation_Internal1SearchText() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCanvass_Quotation_Internal1SearchText"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property WCQI_PM00200_Vendor_IDFilter1() As BaseClasses.Web.UI.WebControls.QuickSelector
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_PM00200_Vendor_IDFilter1"), BaseClasses.Web.UI.WebControls.QuickSelector)
            End Get
        End Property
        
        Public ReadOnly Property WCQI_PM00200_Vendor_IDLabel2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_PM00200_Vendor_IDLabel2"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As WCanvass_Quotation_Internal1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCanvass_Quotation_Internal1Record = Nothing     
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
                Dim recCtl As WCanvass_Quotation_Internal1TableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
                End If
                Dim rec As WCanvass_Quotation_Internal1Record = Nothing     
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
        
          
        Public Overridable Function GetSelectedRecordControl() As WCanvass_Quotation_Internal1TableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As WCanvass_Quotation_Internal1TableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(WCanvass_Quotation_Internal1TableControlRow)), WCanvass_Quotation_Internal1TableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As WCanvass_Quotation_Internal1TableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ePortalWFApproval"))
            End If
            
            Dim recCtl As WCanvass_Quotation_Internal1TableControlRow
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

        Public Overridable Function GetRecordControls() As WCanvass_Quotation_Internal1TableControlRow()
            Dim recCtrls() As Control = BaseClasses.Utils.MiscUtils.FindControlsRecursively(Me, "WCanvass_Quotation_Internal1TableControlRow")
            Dim list As New List(Of WCanvass_Quotation_Internal1TableControlRow)
            For Each recCtrl As WCanvass_Quotation_Internal1TableControlRow In recCtrls
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

  
' Base class for the WCanvass_InternalRecordControl control on the Show_WCanvass_Internal1 page.
' Do not modify this class. Instead override any method in WCanvass_InternalRecordControl.
Public Class BaseWCanvass_InternalRecordControl
        Inherits ePortalWFApproval.UI.BaseApplicationRecordControl

        '  To customize, override this method in WCanvass_InternalRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init

      
            ' Setup the filter and search events.
            
        End Sub

        '  To customize, override this method in WCanvass_InternalRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
         
              ' Setup the pagination events.	  
                     
        
              ' Register the event handlers.
          
              AddHandler Me.btnBack.Button.Click, AddressOf btnBack_Click
                        
              AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
                        
              AddHandler Me.EditButton.Button.Click, AddressOf EditButton_Click
                        
              AddHandler Me.WCI_C_ID.SelectedIndexChanged, AddressOf WCI_C_ID_SelectedIndexChanged
            
              AddHandler Me.WCI_Vendors.SelectedIndexChanged, AddressOf WCI_Vendors_SelectedIndexChanged
            
              AddHandler Me.WCI_WClass_ID.SelectedIndexChanged, AddressOf WCI_WClass_ID_SelectedIndexChanged
            
              AddHandler Me.WCI_WPRD_ID.SelectedIndexChanged, AddressOf WCI_WPRD_ID_SelectedIndexChanged
            
              AddHandler Me.WCI_Date.TextChanged, AddressOf WCI_Date_TextChanged
            
              AddHandler Me.WCI_Status.TextChanged, AddressOf WCI_Status_TextChanged
            
    
        End Sub

        
        Public Overridable Sub LoadData()        
                
            ' Load the data from the database into the DataSource DatabaseANFLO-WFN%dbo.WCanvass_Internal record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = WCanvass_Internal1Table.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WCanvass_InternalRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New WCanvass_Internal1Record()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As WCanvass_Internal1Record = WCanvass_Internal1Table.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = WCanvass_Internal1Table.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
    
    
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in WCanvass_InternalRecordControl.
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
        
                
                
                
                SetlitAuditors()
                SetLiteral()
                SetLiteral1()
                SetLiteral2()
                SetLiteral3()
                
                
                SetWCanvass_InternalTabContainer()
                
                
                
                SetWCI_C_ID()
                SetWCI_C_IDLabel()
                SetWCI_Date()
                SetWCI_DateLabel()
                
                SetWCI_Status()
                SetWCI_StatusLabel()
                
                
                SetWCI_Vendors()
                SetWCI_VendorsLabel()
                SetWCI_WClass_ID()
                SetWCI_WClass_IDLabel()
                SetWCI_WPRD_ID()
                SetWCI_WPRD_IDLabel()
                SetbtnBack()
              
                SetCancelButton()
              
                SetEditButton()
              
      
      
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
            
        SetSel_WCanvass_Detail_Internal_WPR_Line1TableControl()
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              WCanvass_Quotation_Internal1TableControl.ResetControl()
            End IF
                    
        SetWCanvass_Quotation_Internal1TableControl()
        
        End Sub
        
        
        Public Overridable Sub SetWCI_C_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WCI_C_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_C_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_C_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_C_IDSpecified Then
                            
                ' If the WCI_C_ID is non-NULL, then format the value.
                ' The Format method will use the Display Format
                selectedValue = Me.DataSource.WCI_C_ID.ToString()
            Else
                
                ' WCI_C_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCanvass_Internal1Table.WCI_C_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCI_C_IDDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCI_Date()

                  
            
        
            ' Set the WCI_Date TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_Date is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_Date()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_DateSpecified Then
                				
                ' If the WCI_Date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Internal1Table.WCI_Date, "g")
                              
                Me.WCI_Date.Text = formattedValue
                
            Else 
            
                ' WCI_Date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCI_Date.Text = WCanvass_Internal1Table.WCI_Date.Format(WCanvass_Internal1Table.WCI_Date.DefaultValue, "g")
                        		
                End If
                 
              AddHandler Me.WCI_Date.TextChanged, AddressOf WCI_Date_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCI_Status()

                  
            
        
            ' Set the WCI_Status TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_Status is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_Status()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_StatusSpecified Then
                				
                ' If the WCI_Status is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Internal1Table.WCI_Status)
                              
                Me.WCI_Status.Text = formattedValue
                
            Else 
            
                ' WCI_Status is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCI_Status.Text = WCanvass_Internal1Table.WCI_Status.Format(WCanvass_Internal1Table.WCI_Status.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCI_Status.TextChanged, AddressOf WCI_Status_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCI_Vendors()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WCI_Vendors DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_Vendors is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_Vendors()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_VendorsSpecified Then
                            
                ' If the WCI_Vendors is non-NULL, then format the value.
                ' The Format method will use the Display Format
                selectedValue = Me.DataSource.WCI_Vendors.ToString()
            Else
                
                ' WCI_Vendors is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCanvass_Internal1Table.WCI_Vendors.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCI_VendorsDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCI_WClass_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WCI_WClass_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_WClass_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_WClass_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_WClass_IDSpecified Then
                            
                ' If the WCI_WClass_ID is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = Me.DataSource.WCI_WClass_ID.ToString()
            Else
                
                ' WCI_WClass_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCanvass_Internal1Table.WCI_WClass_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCI_WClass_IDDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetWCI_WPRD_ID()

                  
            

            Dim selectedValue As String = Nothing
            
            ' figure out the selectedValue
                  
            
        
            ' Set the WCI_WPRD_ID DropDownList on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.
            
            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_WPRD_ID is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_WPRD_ID()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_WPRD_IDSpecified Then
                            
                ' If the WCI_WPRD_ID is non-NULL, then format the value.
                ' The Format method will use the Display Format
                selectedValue = Me.DataSource.WCI_WPRD_ID.ToString()
            Else
                
                ' WCI_WPRD_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    selectedValue = Nothing
                Else
                    selectedValue = WCanvass_Internal1Table.WCI_WPRD_ID.DefaultValue
                End If
                				
            End If			
                
            
                  
            ' Populate the item(s) to the control
            
            Me.PopulateWCI_WPRD_IDDropDownList(selectedValue, 100)              
                
                  
           
             
        End Sub
                
        Public Overridable Sub SetlitAuditors()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litAuditors.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetLiteral()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral1()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral2()

                  
                  
                  End Sub
                
        Public Overridable Sub SetLiteral3()

                  
                  
                  End Sub
                
        Public Overridable Sub SetWCI_C_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCI_C_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCI_DateLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCI_DateLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCI_StatusLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCI_StatusLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCI_VendorsLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCI_VendorsLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCI_WClass_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCI_WClass_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCI_WPRD_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCI_WPRD_IDLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCanvass_InternalTabContainer()           
                        
                   
            If EvaluateFormula("URL(""TabVisible"")").ToLower() = "true" Then
                MiscUtils.FindControlRecursively(Me, "WCanvass_InternalTabContainer").Visible = True
            ElseIf EvaluateFormula("URL(""TabVisible"")").ToLower() = "false" Then
                MiscUtils.FindControlRecursively(Me, "WCanvass_InternalTabContainer").Visible = False
            End If
         
  
        End Sub        
      
        Public Overridable Sub SetSel_WCanvass_Detail_Internal_WPR_Line1TableControl()           
        
        
            If Sel_WCanvass_Detail_Internal_WPR_Line1TableControl.Visible Then
                Sel_WCanvass_Detail_Internal_WPR_Line1TableControl.LoadData()
                Sel_WCanvass_Detail_Internal_WPR_Line1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub SetWCanvass_Quotation_Internal1TableControl()           
        
        
            If WCanvass_Quotation_Internal1TableControl.Visible Then
                WCanvass_Quotation_Internal1TableControl.LoadData()
                WCanvass_Quotation_Internal1TableControl.DataBind()
            End If
        End Sub        
      
        Public Overridable Sub ResetControl()
          
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

      
        
        ' To customize, override this method in WCanvass_InternalRecordControl.
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
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "WCanvass_InternalRecordControlPanel"), System.Web.UI.WebControls.Panel)

          If ((Not IsNothing(Panel)) AndAlso (Not Panel.Visible)) OrElse IsNothing(Me.DataSource) Then
              Return
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
              
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            Me.CheckSum = ""
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        Dim recSel_WCanvass_Detail_Internal_WPR_Line1TableControl as Sel_WCanvass_Detail_Internal_WPR_Line1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1TableControl"), Sel_WCanvass_Detail_Internal_WPR_Line1TableControl)
        recSel_WCanvass_Detail_Internal_WPR_Line1TableControl.SaveData()
          
        Dim recWCanvass_Quotation_Internal1TableControl as WCanvass_Quotation_Internal1TableControl= DirectCast(MiscUtils.FindControlRecursively(Me, "WCanvass_Quotation_Internal1TableControl"), WCanvass_Quotation_Internal1TableControl)
        recWCanvass_Quotation_Internal1TableControl.SaveData()
          
        End Sub

        ' To customize, override this method in WCanvass_InternalRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
      
            ' Call the Get methods for each of the user interface controls.
        
            GetWCI_C_ID()
            GetWCI_Date()
            GetWCI_Status()
            GetWCI_Vendors()
            GetWCI_WClass_ID()
            GetWCI_WPRD_ID()
        End Sub
        
        
        Public Overridable Sub GetWCI_C_ID()
         
        End Sub
                
        Public Overridable Sub GetWCI_Date()
            
        End Sub
                
        Public Overridable Sub GetWCI_Status()
            
        End Sub
                
        Public Overridable Sub GetWCI_Vendors()
         
        End Sub
                
        Public Overridable Sub GetWCI_WClass_ID()
         
        End Sub
                
        Public Overridable Sub GetWCI_WPRD_ID()
         
        End Sub
                
      
        ' To customize, override this method in WCanvass_InternalRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
        Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False
      
        Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False
      
        Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False
      
            Dim wc As WhereClause
            WCanvass_Internal1Table.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
                  Dim recId As String = DirectCast(Me.Page, BaseApplicationPage).Decrypt(Me.Page.Request.QueryString.Item("WCanvass_Internal1"))
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "ePortalWFApproval").Replace("{URL}", "WCanvass_Internal1"))
            End If
            HttpContext.Current.Session("QueryString in Show-WCanvass-Internal1") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(WCanvass_Internal1Table.WCI_ID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(WCanvass_Internal1Table.WCI_ID))
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(WCanvass_Internal1Table.WCI_ID, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            WCanvass_Internal1Table.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
                Dim hasFiltersSel_WCanvass_Detail_Internal_WPR_Line1TableControl As Boolean = False
              
                Dim hasFiltersWCanvass_InternalRecordControl As Boolean = False
              
                Dim hasFiltersWCanvass_Quotation_Internal1TableControl As Boolean = False
              
            ' Compose the WHERE clause consist of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
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
         
        'Formats the resultItem and adds it to the list of suggestions.
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
        
    

        ' To customize, override this method in WCanvass_InternalRecordControl.
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
          WCanvass_Internal1Table.DeleteRecord(pkValue)
          
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
        
        
        ' Generate the event handling functions for pagination events.
            
      
        ' Generate the event handling functions for filter and search events.
            
    
        ' Generate set method for buttons
        
        Public Overridable Sub SetbtnBack()                
              
   
        End Sub
            
        Public Overridable Sub SetCancelButton()                
              
   
        End Sub
            
        Public Overridable Sub SetEditButton()                
              
   
        End Sub
            
                        
        Public Overridable Function CreateWhereClause_WCI_C_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
                        
        Public Overridable Function CreateWhereClause_WCI_VendorsDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
                        
        Public Overridable Function CreateWhereClause_WCI_WClass_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.WClassification table.
            ' Examples:
            ' wc.iAND(WClassification1Table.WClass_Name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(WClassification1Table.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
                        
        Public Overridable Function CreateWhereClause_WCI_WPRD_IDDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
                  
        ' Fill the WCI_C_ID list.
        Protected Overridable Sub PopulateWCI_C_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCI_C_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WCI_C_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCI_C_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WCI_C_IDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
                
            ' 3. Read a total of maxItems from the database and insert them								
            Dim orderBy As OrderBy = New OrderBy(False, False)
             orderBy.Add(WCanvass_Internal1Table.WCI_C_ID, OrderByItem.OrderDir.Asc)
            
            Dim itemValue As String
            Dim listDuplicates As New ArrayList()

            If wc.RunQuery
                For Each itemValue In WCanvass_Internal1Table.GetValues(WCanvass_Internal1Table.WCI_C_ID, wc, orderBy, maxItems)
                    ' Create the dropdown list item and add it to the list.
                    Dim fvalue As String = WCanvass_Internal1Table.WCI_C_ID.Format(itemValue)
                    If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = itemValue
                    Dim dupItem As ListItem = Me.WCI_C_ID.Items.FindByText(fvalue)
          
                    If Not IsNothing(dupItem) Then
                        listDuplicates.Add(fvalue)
                        If Not String.IsNullOrEmpty(dupItem.Value) Then
                            dupItem.Text = fvalue & " (ID " & dupItem.Value & ")"
                        End If
                    End If

                    Dim newItem As ListItem = New ListItem(fvalue, itemValue)
                    Me.WCI_C_ID.Items.Add(newItem)

                    If listDuplicates.Contains(fvalue) AndAlso Not String.IsNullOrEmpty(itemValue) Then
                        newItem.Text = fvalue & " (ID " & itemValue & ")"
                    End If
                Next
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCI_C_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_C_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_C_ID, WCanvass_Internal1Table.WCI_C_ID.Format(selectedValue))Then
                Dim fvalue As String = WCanvass_Internal1Table.WCI_C_ID.Format(selectedValue)
                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                ResetSelectedItem(Me.WCI_C_ID, New ListItem(fvalue, selectedValue))
            End If					
            
                
        End Sub
        
              
        ' Fill the WCI_Vendors list.
        Protected Overridable Sub PopulateWCI_VendorsDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCI_Vendors.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("1"), "1"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("2"), "2"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("3"), "3"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("4"), "4"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("5"), "5"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("6"), "6"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("7"), "7"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("8"), "8"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("9"), "9"))
                            							
            Me.WCI_Vendors.Items.Add(New ListItem(Me.Page.ExpandResourceValue("10"), "10"))
                            		  
            ' Skip step 2 and 3 because no need to load data from database and insert data
                    
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCI_Vendors, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_Vendors, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_Vendors, WCanvass_Internal1Table.WCI_Vendors.Format(selectedValue))Then
                Dim fvalue As String = WCanvass_Internal1Table.WCI_Vendors.Format(selectedValue)
                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                ResetSelectedItem(Me.WCI_Vendors, New ListItem(fvalue, selectedValue))
            End If					
            
                
        End Sub
        
              
        ' Fill the WCI_WClass_ID list.
        Protected Overridable Sub PopulateWCI_WClass_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCI_WClass_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WCI_WClass_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCI_WClass_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WCI_WClass_IDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WClassification1Table.WClass_Name, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As WClassification1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = WClassification1Table.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As WClassification1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WClass_IDSpecified Then
                            cvalue = itemValue.WClass_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.WCI_WClass_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCanvass_Internal1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCanvass_Internal1Table.WCI_WClass_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCanvass_Internal1Table.WCI_WClass_ID.IsApplyDisplayAs Then
                                fvalue = WCanvass_Internal1Table.GetDFKA(itemValue, WCanvass_Internal1Table.WCI_WClass_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(WClassification1Table.WClass_Name)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WCI_WClass_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCI_WClass_ID.Items.Add(newItem)

                                If listDuplicates.Contains(fvalue)  AndAlso Not String.IsNullOrEmpty(cvalue) Then
                                    newItem.Text = fvalue & " (ID " & cvalue.Substring(0, Math.Min(cvalue.Length,38)) & ")"
                                End If

                                counter += 1			  
                            End If
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCI_WClass_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_WClass_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WClassification.WClass_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WClassification1Table.WClass_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WClassification1Record = WClassification1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WClassification1Record = DirectCast(rc(0), WClassification1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WClass_IDSpecified Then
                            cvalue = itemValue.WClass_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCanvass_Internal1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCanvass_Internal1Table.WCI_WClass_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCanvass_Internal1Table.WCI_WClass_ID.IsApplyDisplayAs Then
                          fvalue = WCanvass_Internal1Table.GetDFKA(itemValue, WCanvass_Internal1Table.WCI_WClass_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WClassification1Table.WClass_Name)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCI_WClass_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

            End If					
                        
                
        End Sub
        
              
        ' Fill the WCI_WPRD_ID list.
        Protected Overridable Sub PopulateWCI_WPRD_IDDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.WCI_WPRD_ID.Items.Clear()
            
                    
            ' 1. Setup the static list items        
            
            ' Add the Please Select item.
            Me.WCI_WPRD_ID.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:PleaseSelect", "ePortalWFApproval"), "--PLEASE_SELECT--"))
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_WCI_WPRD_IDDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_WCI_WPRD_IDDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
                
            ' 3. Read a total of maxItems from the database and insert them								
            Dim orderBy As OrderBy = New OrderBy(False, False)
             orderBy.Add(WCanvass_Internal1Table.WCI_WPRD_ID, OrderByItem.OrderDir.Asc)
            
            Dim itemValue As String
            Dim listDuplicates As New ArrayList()

            If wc.RunQuery
                For Each itemValue In WCanvass_Internal1Table.GetValues(WCanvass_Internal1Table.WCI_WPRD_ID, wc, orderBy, maxItems)
                    ' Create the dropdown list item and add it to the list.
                    Dim fvalue As String = WCanvass_Internal1Table.WCI_WPRD_ID.Format(itemValue)
                    If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = itemValue
                    Dim dupItem As ListItem = Me.WCI_WPRD_ID.Items.FindByText(fvalue)
          
                    If Not IsNothing(dupItem) Then
                        listDuplicates.Add(fvalue)
                        If Not String.IsNullOrEmpty(dupItem.Value) Then
                            dupItem.Text = fvalue & " (ID " & dupItem.Value & ")"
                        End If
                    End If

                    Dim newItem As ListItem = New ListItem(fvalue, itemValue)
                    Me.WCI_WPRD_ID.Items.Add(newItem)

                    If listDuplicates.Contains(fvalue) AndAlso Not String.IsNullOrEmpty(itemValue) Then
                        newItem.Text = fvalue & " (ID " & itemValue & ")"
                    End If
                Next
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.WCI_WPRD_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_WPRD_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_WPRD_ID, WCanvass_Internal1Table.WCI_WPRD_ID.Format(selectedValue))Then
                Dim fvalue As String = WCanvass_Internal1Table.WCI_WPRD_ID.Format(selectedValue)
                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                ResetSelectedItem(Me.WCI_WPRD_ID, New ListItem(fvalue, selectedValue))
            End If					
            
                
        End Sub
        
              
        ' event handler for Button
        Public Overridable Sub btnBack_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub CancelButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        ' event handler for Button
        Public Overridable Sub EditButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Custom Properties or Actions.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            
              
                  Dim url As String = "../we_PR_Group_Detail/EditWCanvass_Internal.aspx?WCanvass_Internal={PK}"
                  
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
        
        Protected Overridable Sub WCI_C_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCI_C_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCI_C_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCI_C_ID.Items.Add(New ListItem(displayText, val))
                Me.WCI_C_ID.SelectedIndex = Me.WCI_C_ID.Items.Count - 1
                Me.Page.Session.Remove(WCI_C_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCI_C_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WCI_Vendors_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCI_Vendors.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCI_Vendors.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCI_Vendors.Items.Add(New ListItem(displayText, val))
                Me.WCI_Vendors.SelectedIndex = Me.WCI_Vendors.Items.Count - 1
                Me.Page.Session.Remove(WCI_Vendors.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCI_Vendors.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WCI_WClass_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCI_WClass_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCI_WClass_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCI_WClass_ID.Items.Add(New ListItem(displayText, val))
                Me.WCI_WClass_ID.SelectedIndex = Me.WCI_WClass_ID.Items.Count - 1
                Me.Page.Session.Remove(WCI_WClass_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCI_WClass_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WCI_WPRD_ID_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)

            ' for the value inserted by quick add button or large list selector, 
            ' the value is necessary to be inserted by this event during postback 
            Dim val As String = CType(Me.Page.Session()(WCI_WPRD_ID.ClientID & "_SelectedValue"), String)
            Dim displayText As String = CType(Me.Page.Session()(WCI_WPRD_ID.ClientID & "_SelectedDisplayText"), String)
            If displayText <> "" AndAlso val <> "" Then
                Me.WCI_WPRD_ID.Items.Add(New ListItem(displayText, val))
                Me.WCI_WPRD_ID.SelectedIndex = Me.WCI_WPRD_ID.Items.Count - 1
                Me.Page.Session.Remove(WCI_WPRD_ID.ClientID & "_SelectedValue")
                Me.Page.Session.Remove(WCI_WPRD_ID.ClientID & "_SelectedDisplayText")
            End If

          									
                
                
        End Sub
            
        Protected Overridable Sub WCI_Date_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCI_Status_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
                Return CType(Me.ViewState("BaseWCanvass_InternalRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseWCanvass_InternalRecordControl_Rec") = value
            End Set
        End Property
            
        Public Property DataSource() As WCanvass_Internal1Record
            Get
                Return DirectCast(MyBase._DataSource, WCanvass_Internal1Record)
            End Get
            Set(ByVal value As WCanvass_Internal1Record)
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
    
        Private _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property
    
        Private _TotalRecords As Integer
        Public Property TotalRecords() As Integer
            Get
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                End If

                Me._TotalRecords = value
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
        
        Public ReadOnly Property btnBack() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "btnBack"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property CancelButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CancelButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property EditButton() As ePortalWFApproval.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "EditButton"), ePortalWFApproval.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property litAuditors() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litAuditors"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property Literal3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Sel_WCanvass_Detail_Internal_WPR_Line1TableControl() As Sel_WCanvass_Detail_Internal_WPR_Line1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1TableControl"), Sel_WCanvass_Detail_Internal_WPR_Line1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WCanvass_InternalTabContainer() As AjaxControlToolkit.TabContainer
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCanvass_InternalTabContainer"), AjaxControlToolkit.TabContainer)
            End Get
        End Property
        
        Public ReadOnly Property WCanvass_InternalTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCanvass_InternalTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCanvass_Quotation_Internal1TableControl() As WCanvass_Quotation_Internal1TableControl
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCanvass_Quotation_Internal1TableControl"), WCanvass_Quotation_Internal1TableControl)
            End Get
        End Property
        
        Public ReadOnly Property WCI_C_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_C_ID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WCI_C_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_C_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCI_Date() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_Date"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCI_DateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_DateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCI_ID() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_ID"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property WCI_Status() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_Status"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCI_StatusLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_StatusLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCI_Submit() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_Submit"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
            
        Public ReadOnly Property WCI_U_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_U_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCI_Vendors() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_Vendors"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WCI_VendorsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_VendorsLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCI_WClass_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_WClass_ID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WCI_WClass_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_WClass_IDLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCI_WPRD_ID() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_WPRD_ID"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property WCI_WPRD_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCI_WPRD_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As WCanvass_Internal1Record = Nothing
             
        
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
            
            Dim rec As WCanvass_Internal1Record = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As WCanvass_Internal1Record
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return WCanvass_Internal1Table.GetRecord(Me.RecordUniqueId, True)
                
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

  

#End Region
    
  
End Namespace

  