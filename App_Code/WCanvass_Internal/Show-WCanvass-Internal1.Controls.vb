
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
        


        Public Overrides Sub SetWCDI_PM00200_Vendor_ID1()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID1Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)

                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID1.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString()) 'oHeader.WCI_C_ID.SelectedValue.ToString()
                oHeader.LoadData()
                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Dim formattedValue As String = Me.DataSource.WCDI_PM00200_Vendor_ID1.ToString()
                Me.WCDI_PM00200_Vendor_ID1.Text = sDesc 'formattedValue  
            Else
                Me.WCDI_PM00200_Vendor_ID1.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID3()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID2Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID2.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Dim formattedValue As String = Me.DataSource.WCDI_PM00200_Vendor_ID2.ToString()
                Me.WCDI_PM00200_Vendor_ID3.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID3.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID5()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID3Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID3.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Dim formattedValue As String = Me.DataSource.WCDI_PM00200_Vendor_ID3.ToString()
                Me.WCDI_PM00200_Vendor_ID5.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID5.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID7()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID4Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID4.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Dim formattedValue As String = Me.DataSource.WCDI_PM00200_Vendor_ID4.ToString()
                Me.WCDI_PM00200_Vendor_ID7.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID7.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID9()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID5Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID5.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Dim formattedValue As String = Me.DataSource.WCDI_PM00200_Vendor_ID5.ToString()
                Me.WCDI_PM00200_Vendor_ID9.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID9.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID11()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID6Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID6.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Me.WCDI_PM00200_Vendor_ID11.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID11.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID13()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID7Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID7.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Me.WCDI_PM00200_Vendor_ID13.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID13.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID15()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID8Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID8.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Me.WCDI_PM00200_Vendor_ID15.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID15.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID17()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID9Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID9.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Me.WCDI_PM00200_Vendor_ID17.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID17.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub SetWCDI_PM00200_Vendor_ID19()
            Dim sDesc As String = ""

            If Me.DataSource.WCDI_PM00200_Vendor_ID10Specified Then
                Dim wc As WhereClause = New WhereClause()
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCDI_PM00200_Vendor_ID10.ToString())
                wc.iAND(sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString())

                Dim itemValue As sel_PM002002Record
                For Each itemValue In sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
                    sDesc = itemValue.VENDNAME
                Next

                Me.WCDI_PM00200_Vendor_ID19.Text = sDesc 'formattedValue          
            Else
                Me.WCDI_PM00200_Vendor_ID19.Text = sDesc 'Sel_WCanvass_Detail_Internal_WPR_LineView.WCDI_PM00200_Vendor_ID1.DefaultValue
            End If
        End Sub

        Public Overrides Sub DataBind()
            MyBase.DataBind()

            If Me.DataSource Is Nothing Then
                Return
            End If

            SetItem()
            SetItemDescription()
            SetUnitOfMeasure()
            SetUnitPrice()
            SetWCDI_Audit_Comment()
            SetWCDI_Award()
            SetWCDI_Award1()
            SetWCDI_Award2()
            SetWCDI_Award3()
            SetWCDI_Award4()
            SetWCDI_Award5()
            SetWCDI_Award6()
            SetWCDI_Award7()
            SetWCDI_Award8()
            SetWCDI_Award9()
            SetWCDI_Bid()
            SetWCDI_Bid1()
            SetWCDI_Bid2()
            SetWCDI_Bid3()
            SetWCDI_Bid4()
            SetWCDI_Bid5()
            SetWCDI_Bid6()
            SetWCDI_Bid7()
            SetWCDI_Bid8()
            SetWCDI_Bid9()
            SetWCDI_Comment()
            SetWCDI_ID()
            SetWCDI_PM00200_Vendor_ID()
            SetWCDI_PM00200_Vendor_ID1()
            SetWCDI_PM00200_Vendor_ID10()
            SetWCDI_PM00200_Vendor_ID11()
            SetWCDI_PM00200_Vendor_ID12()
            SetWCDI_PM00200_Vendor_ID13()
            SetWCDI_PM00200_Vendor_ID14()
            SetWCDI_PM00200_Vendor_ID15()
            SetWCDI_PM00200_Vendor_ID16()
            SetWCDI_PM00200_Vendor_ID17()
            SetWCDI_PM00200_Vendor_ID18()
            SetWCDI_PM00200_Vendor_ID19()
            SetWCDI_PM00200_Vendor_ID2()
            SetWCDI_PM00200_Vendor_ID3()
            SetWCDI_PM00200_Vendor_ID4()
            SetWCDI_PM00200_Vendor_ID5()
            SetWCDI_PM00200_Vendor_ID6()
            SetWCDI_PM00200_Vendor_ID7()
            SetWCDI_PM00200_Vendor_ID8()
            SetWCDI_PM00200_Vendor_ID9()
            'SetWCDI_Status()
            SetWPRL_Ext_Price()
            SetWPRL_ID()
            SetWPRL_Qty()

            Me.IsNewRecord = True
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
            End If

            Dim shouldResetControl As Boolean = False

            If Me.WCDI_Award.Checked Then 'And bInGP Then 
                Me.WCDI_Award.Enabled = False
                'Me.Literal2.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award1.Checked Then 'And bInGP Then 
                Me.WCDI_Award1.Enabled = False
                'Me.Literal3.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award2.Checked Then 'And bInGP Then  
                Me.WCDI_Award2.Enabled = False
                'Me.Literal4.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award3.Checked Then 'And bInGP Then  
                Me.WCDI_Award3.Enabled = False
                'Me.Literal6.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award4.Checked Then 'And bInGP Then  
                Me.WCDI_Award4.Enabled = False
                'Me.Literal7.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award5.Checked Then 'And bInGP Then  
                Me.WCDI_Award5.Enabled = False
                'Me.Literal8.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award6.Checked Then 'And bInGP Then  
                Me.WCDI_Award6.Enabled = False
                'Me.Literal9.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award7.Checked Then 'And bInGP Then  
                Me.WCDI_Award7.Enabled = False
                'Me.Literal11.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award8.Checked Then 'And bInGP Then  
                Me.WCDI_Award8.Enabled = False
                'Me.Literal12.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            If Me.WCDI_Award9.Checked Then 'And bInGP Then  
                Me.WCDI_Award9.Enabled = False
                'Me.Literal13.Text = "******[&nbsp;BID&nbsp;IS&nbsp;CLOSED&nbsp;FOR&nbsp;THIS&nbsp;VENDOR&nbsp;]******"
            End If

            Me.Item.Attributes.Add("onClick", "OpenItemInquiry('" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid1.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID2.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid2.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID4.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid3.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID6.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid4.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID8.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid5.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID10.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid6.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID12.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid7.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID14.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid8.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID16.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
            Me.imbBid9.Attributes.Add("onClick", "OpenVendorItemInquiry('" & Me.WCDI_PM00200_Vendor_ID18.ClientID & "','" & Me.DataSource.Item.ToString() & "');return false;")
        End Sub

        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            AddHandler Me.Item.Click, AddressOf Item_Click
            'Me.Item.Attributes.Add("onClick", "OpenItemInquiry('" & Me.Item.Text & "');return false;")	
            Me.imbHist.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID.ClientID & "');return false;")
            Me.imbHist1.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID2.ClientID & "');return false;")
            Me.imbHist2.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID4.ClientID & "');return false;")
            Me.imbHist3.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID6.ClientID & "');return false;")
            Me.imbHist4.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID8.ClientID & "');return false;")
            Me.imbHist5.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID10.ClientID & "');return false;")
            Me.imbHist6.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID12.ClientID & "');return false;")
            Me.imbHist7.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID14.ClientID & "');return false;")
            Me.imbHist8.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID16.ClientID & "');return false;")
            Me.imbHist9.Attributes.Add("onClick", "OpenVendorInquiry('" & Me.WCDI_PM00200_Vendor_ID18.ClientID & "');return false;")

            Dim oHead As WCanvass_InternalRecordControl = DirectCast(GetParentControlObject(Me, "WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)

            Me.imbAtt.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID.ClientID & "');return false;")
            Me.imbAtt1.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID2.ClientID & "');return false;")
            Me.imbAtt2.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID4.ClientID & "');return false;")
            Me.imbAtt3.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID6.ClientID & "');return false;")
            Me.imbAtt4.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID8.ClientID & "');return false;")
            Me.imbAtt5.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID10.ClientID & "');return false;")
            Me.imbAtt6.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID12.ClientID & "');return false;")
            Me.imbAtt7.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID14.ClientID & "');return false;")
            Me.imbAtt8.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID16.ClientID & "');return false;")
            Me.imbAtt9.Attributes.Add("onClick", "OpenAttachInquiry('" & oHead.WCI_ID.Text & "','" & Me.WCDI_PM00200_Vendor_ID18.ClientID & "');return false;")
        End Sub

       
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
                wc.iAND(Sel_PM002002View.VENDORID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCQI_PM00200_Vendor_ID.ToString())
                wc.iAND(Sel_PM002002View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, oHeader.DataSource.WCI_C_ID.ToString()) 'oHeader.WCI_C_ID.SelectedValue.ToString()

                Dim itemValue As Sel_PM002002Record
                For Each itemValue In Sel_PM002002View.GetRecords(wc, Nothing, 0, 10)
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


    Public Class WCanvass_InternalRecordControl
        Inherits BaseWCanvass_InternalRecordControl
       

        Public Overrides Sub CancelButton_Click(ByVal sender As Object, ByVal args As EventArgs)

            Dim url As String = ""
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing

            Dim poNum As String = CStr(System.Web.HttpContext.Current.Session("PONO"))


            Try
                DbUtils.StartTransaction()

                url = "../sel_WPO_WFTask/WPO_WFTaskN.aspx?POP10100_PO=" & Trim(poNum) & "&POP10100_Co=" & Me.WCI_C_ID.SelectedValue.ToString



                url = Me.ModifyRedirectUrl(url, "", False)
                url = Me.Page.ModifyRedirectUrl(url, "", False)
                Me.Page.CommitTransaction(sender)



            Catch ex As Exception
                shouldRedirect = False
                Me.Page.ErrorOnPage = True

                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally

            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso Not shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.CloseWindow(True)
            End If
        End Sub

        Private Function Stuff_Zero(Num As String) As String
            Dim iLoop As Integer
            Dim sTemp As String
            For iLoop = 1 To 2 - Num.Length
                sTemp &= "0"
            Next
            Return sTemp & Num
        End Function

        Private Sub Java_Auto_Select()
            Dim jsAward As String = "var listOfAward = new Array();" & vbcrlf & " var a = 0;"
            Dim listOfAward As String = ""
            Dim sAward As String = "ctl00_PageContent_WCanvass_InternalTabContainer_WCanvass_Detail_InternalTabPanel_Sel_WCanvass_Detail_Internal_WPR_LineTableControlRepeater_ctl@_WCDI_Award#"
            Dim iCtrl As Integer = 0
            Dim iCol As Integer = 0
            Dim sTemp As String = ""
            Dim sCheckScript As String

            For iCtrl = 0 To 19 'place checkbox control to single array
                sTemp = replace(sAward, "@", Stuff_Zero(iCtrl.ToString()))
                sTemp = replace(sTemp, "#", "")
                listOfAward &= "listOfAward[a++] = '" & sTemp & "';" & vbcrlf
                For iCol = 1 To 9 '5
                    sTemp = replace(sAward, "@", Stuff_Zero(iCtrl.ToString()))
                    sTemp = replace(sTemp, "#", iCol.ToString())
                    listOfAward &= "listOfAward[a++] = '" & sTemp & "';" & vbcrlf
                Next
                sTemp = replace(sAward, "@", Stuff_Zero(iCtrl.ToString()))
                sTemp = replace(sTemp, "#", "")
                listOfAward &= "listOfAward[a++] = '" & sTemp & "';" & vbcrlf
            Next

            sCheckScript = "<script language=""javascript"">" & vbCrLf & _
            "function CheckColumn(Checker) {" & vbcrlf & _
            "  " & jsAward & vbcrlf & "  " & listOfAward & vbcrlf & _
            "  var temp = document.getElementById(Checker).name;" & vbcrlf & _
            "  temp = temp.slice(155,157);" & vbcrlf & _
            "  var ctrl = '';" & vbcrlf & _
            "  if (listOfAward.length > 0) {" & vbcrlf & _
            "    for (var a = 0; a < listOfAward.length; a++) {" & vbcrlf & _
            "      //ctrl = document.getElementById(listOfAward[a]).name;" & vbcrlf & _
            "      ctrl = listOfAward[a].slice(155,157);" & vbcrlf & _
            "      if (temp == ctrl) {" & vbcrlf & _
            "	     if (document.getElementById(listOfAward[a])) {" & vbcrlf & _
            "          document.getElementById(listOfAward[a]).checked = document.getElementById(Checker).checked;}}" & vbcrlf & _
            "  }}}" & vbcrlf & _
            "</script>"

            Me.Page.ClientScript.RegisterStartupScript(GetType(Page), "CheckColumn", sCheckScript)
        End Sub

        Private Sub MyPreRender( _
            ByVal sender As Object, _
            ByVal e As System.EventArgs) Handles MyBase.PreRender
            Me.Java_Auto_Select()
        End Sub

        Protected Overrides Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'AddHandler Me.WCI_C_ID.SelectedIndexChanged, AddressOf WCI_C_ID_SelectedIndexChanged        
            'AddHandler Me.WCI_Vendors.SelectedIndexChanged, AddressOf WCI_Vendors_SelectedIndexChanged        
            'AddHandler Me.WCI_WPRD_ID.SelectedIndexChanged, AddressOf WCI_WPRD_ID_SelectedIndexChanged
            'AddHandler Me.btnBack.Button.Click, AddressOf btnBack_Click
            AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
            Dim control1 As System.Web.UI.HtmlControls.HtmlGenericControl = CType(Page.Master.FindControl("Body1"), HtmlGenericControl)
            control1.Attributes.Add("onFocus", "javascript:jq_toggle_col_vis2('tblVendor','" & Me.WCI_Vendors.ClientID & "');")
        End Sub

        Public Overrides Sub SetWCI_C_ID()

            If Me.DataSource.WCI_C_IDSpecified Then

                System.Web.HttpContext.Current.Session("CI_C_ID") = Me.DataSource.WCI_C_ID.ToString()

                Dim wc As WhereClause = New WhereClause()
                Dim cDesc As String = ""
                Dim oHeader As WCanvass_InternalRecordControl = DirectCast(Me.Page.FindControlRecursively("WCanvass_InternalRecordControl"), WCanvass_InternalRecordControl)
                oHeader.LoadData()
                wc.iAND(Sel_WF_DYNAMICS_Company1View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, Me.DataSource.WCI_C_ID.ToString())

                Dim itemValue As Sel_WF_DYNAMICS_Company1Record
                For Each itemValue In Sel_WF_DYNAMICS_Company1View.GetRecords(wc, Nothing, 0, 10)
                    cDesc = itemValue.Company_Desc
                Next

                Me.WCI_C_ID.Text = cDesc 'formattedValue

                'Else
                '    Me.WCI_C_ID.Text = WCanvass_Quotation_InternalTable.WCQI_PM00200_Vendor_ID.Format(WCanvass_Quotation_InternalTable.WCQI_PM00200_Vendor_ID.DefaultValue)
            End If

        End Sub

        Public Overrides Sub DataBind()
            MyBase.DataBind()

            If Me.DataSource Is Nothing Then
                Return
            End If

            If Not Me.DataSource.GetCheckSumValue() Is Nothing AndAlso _
                (Me.CheckSum Is Nothing OrElse Me.CheckSum.Trim = "") Then
                Me.CheckSum = Me.DataSource.GetCheckSumValue().Value
            End If

            SetWCI_C_ID()
            SetWCI_Date()
            SetWCI_ID()
            SetWCI_Status()
            SetWCI_Submit()
            SetWCI_Vendors()
            SetWCI_WClass_ID()
            SetWCI_WPRD_ID()

            Me.IsNewRecord = True
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False

                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If

            Dim shouldResetControl As Boolean = False
        End Sub

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
                        
              AddHandler Me.Item.Click, AddressOf Item_Click
                        
              AddHandler Me.WCDI_Award.CheckedChanged, AddressOf WCDI_Award_CheckedChanged
            
              AddHandler Me.WCDI_Award1.CheckedChanged, AddressOf WCDI_Award1_CheckedChanged
            
              AddHandler Me.WCDI_Award2.CheckedChanged, AddressOf WCDI_Award2_CheckedChanged
            
              AddHandler Me.WCDI_Award3.CheckedChanged, AddressOf WCDI_Award3_CheckedChanged
            
              AddHandler Me.WCDI_Award4.CheckedChanged, AddressOf WCDI_Award4_CheckedChanged
            
              AddHandler Me.WCDI_Award5.CheckedChanged, AddressOf WCDI_Award5_CheckedChanged
            
              AddHandler Me.WCDI_Award6.CheckedChanged, AddressOf WCDI_Award6_CheckedChanged
            
              AddHandler Me.WCDI_Award7.CheckedChanged, AddressOf WCDI_Award7_CheckedChanged
            
              AddHandler Me.WCDI_Award8.CheckedChanged, AddressOf WCDI_Award8_CheckedChanged
            
              AddHandler Me.WCDI_Award9.CheckedChanged, AddressOf WCDI_Award9_CheckedChanged
            
              AddHandler Me.WCDI_Audit_Comment.TextChanged, AddressOf WCDI_Audit_Comment_TextChanged
            
              AddHandler Me.WCDI_Bid.TextChanged, AddressOf WCDI_Bid_TextChanged
            
              AddHandler Me.WCDI_Bid1.TextChanged, AddressOf WCDI_Bid1_TextChanged
            
              AddHandler Me.WCDI_Bid2.TextChanged, AddressOf WCDI_Bid2_TextChanged
            
              AddHandler Me.WCDI_Bid3.TextChanged, AddressOf WCDI_Bid3_TextChanged
            
              AddHandler Me.WCDI_Bid4.TextChanged, AddressOf WCDI_Bid4_TextChanged
            
              AddHandler Me.WCDI_Bid5.TextChanged, AddressOf WCDI_Bid5_TextChanged
            
              AddHandler Me.WCDI_Bid6.TextChanged, AddressOf WCDI_Bid6_TextChanged
            
              AddHandler Me.WCDI_Bid7.TextChanged, AddressOf WCDI_Bid7_TextChanged
            
              AddHandler Me.WCDI_Bid8.TextChanged, AddressOf WCDI_Bid8_TextChanged
            
              AddHandler Me.WCDI_Bid9.TextChanged, AddressOf WCDI_Bid9_TextChanged
            
              AddHandler Me.WCDI_Comment.TextChanged, AddressOf WCDI_Comment_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID1.TextChanged, AddressOf WCDI_PM00200_Vendor_ID1_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID10.TextChanged, AddressOf WCDI_PM00200_Vendor_ID10_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID11.TextChanged, AddressOf WCDI_PM00200_Vendor_ID11_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID12.TextChanged, AddressOf WCDI_PM00200_Vendor_ID12_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID13.TextChanged, AddressOf WCDI_PM00200_Vendor_ID13_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID14.TextChanged, AddressOf WCDI_PM00200_Vendor_ID14_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID15.TextChanged, AddressOf WCDI_PM00200_Vendor_ID15_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID16.TextChanged, AddressOf WCDI_PM00200_Vendor_ID16_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID17.TextChanged, AddressOf WCDI_PM00200_Vendor_ID17_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID18.TextChanged, AddressOf WCDI_PM00200_Vendor_ID18_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID19.TextChanged, AddressOf WCDI_PM00200_Vendor_ID19_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID2.TextChanged, AddressOf WCDI_PM00200_Vendor_ID2_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID3.TextChanged, AddressOf WCDI_PM00200_Vendor_ID3_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID4.TextChanged, AddressOf WCDI_PM00200_Vendor_ID4_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID5.TextChanged, AddressOf WCDI_PM00200_Vendor_ID5_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID6.TextChanged, AddressOf WCDI_PM00200_Vendor_ID6_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID7.TextChanged, AddressOf WCDI_PM00200_Vendor_ID7_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID8.TextChanged, AddressOf WCDI_PM00200_Vendor_ID8_TextChanged
            
              AddHandler Me.WCDI_PM00200_Vendor_ID9.TextChanged, AddressOf WCDI_PM00200_Vendor_ID9_TextChanged
            
              AddHandler Me.WCDI_Qty.TextChanged, AddressOf WCDI_Qty_TextChanged
            
              AddHandler Me.WCDI_Qty1.TextChanged, AddressOf WCDI_Qty1_TextChanged
            
              AddHandler Me.WCDI_Qty2.TextChanged, AddressOf WCDI_Qty2_TextChanged
            
              AddHandler Me.WCDI_Qty3.TextChanged, AddressOf WCDI_Qty3_TextChanged
            
              AddHandler Me.WCDI_Qty4.TextChanged, AddressOf WCDI_Qty4_TextChanged
            
              AddHandler Me.WCDI_Qty5.TextChanged, AddressOf WCDI_Qty5_TextChanged
            
              AddHandler Me.WCDI_Qty6.TextChanged, AddressOf WCDI_Qty6_TextChanged
            
              AddHandler Me.WCDI_Qty7.TextChanged, AddressOf WCDI_Qty7_TextChanged
            
              AddHandler Me.WCDI_Qty8.TextChanged, AddressOf WCDI_Qty8_TextChanged
            
              AddHandler Me.WCDI_Qty9.TextChanged, AddressOf WCDI_Qty9_TextChanged
            					
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
        
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                SetItem()
                SetItemDescription()
                SetlitBreak()
                SetlitBreak1()
                SetlitBreak12()
                SetlitBreak14()
                SetlitBreak16()
                SetlitBreak18()
                SetlitBreak3()
                SetlitBreak5()
                SetlitBreak7()
                SetlitBreak9()
                SetUnitOfMeasure()
                SetUnitPrice()
                SetWCDI_Audit_Comment()
                SetWCDI_Aw1()
                SetWCDI_Aw10()
                SetWCDI_Aw2()
                SetWCDI_Aw3()
                SetWCDI_Aw4()
                SetWCDI_Aw5()
                SetWCDI_Aw6()
                SetWCDI_Aw7()
                SetWCDI_Aw8()
                SetWCDI_Aw9()
                SetWCDI_Award()
                SetWCDI_Award1()
                SetWCDI_Award2()
                SetWCDI_Award3()
                SetWCDI_Award4()
                SetWCDI_Award5()
                SetWCDI_Award6()
                SetWCDI_Award7()
                SetWCDI_Award8()
                SetWCDI_Award9()
                SetWCDI_Bid()
                SetWCDI_Bid1()
                SetWCDI_Bid2()
                SetWCDI_Bid3()
                SetWCDI_Bid4()
                SetWCDI_Bid5()
                SetWCDI_Bid6()
                SetWCDI_Bid7()
                SetWCDI_Bid8()
                SetWCDI_Bid9()
                SetWCDI_Comment()
                SetWCDI_ID()
                SetWCDI_PM00200_Vendor_ID()
                SetWCDI_PM00200_Vendor_ID1()
                SetWCDI_PM00200_Vendor_ID10()
                SetWCDI_PM00200_Vendor_ID11()
                SetWCDI_PM00200_Vendor_ID12()
                SetWCDI_PM00200_Vendor_ID13()
                SetWCDI_PM00200_Vendor_ID14()
                SetWCDI_PM00200_Vendor_ID15()
                SetWCDI_PM00200_Vendor_ID16()
                SetWCDI_PM00200_Vendor_ID17()
                SetWCDI_PM00200_Vendor_ID18()
                SetWCDI_PM00200_Vendor_ID19()
                SetWCDI_PM00200_Vendor_ID2()
                SetWCDI_PM00200_Vendor_ID3()
                SetWCDI_PM00200_Vendor_ID4()
                SetWCDI_PM00200_Vendor_ID5()
                SetWCDI_PM00200_Vendor_ID6()
                SetWCDI_PM00200_Vendor_ID7()
                SetWCDI_PM00200_Vendor_ID8()
                SetWCDI_PM00200_Vendor_ID9()
                SetWCDI_Qty()
                SetWCDI_Qty1()
                SetWCDI_Qty2()
                SetWCDI_Qty3()
                SetWCDI_Qty4()
                SetWCDI_Qty5()
                SetWCDI_Qty6()
                SetWCDI_Qty7()
                SetWCDI_Qty8()
                SetWCDI_Qty9()
                SetWPRL_Ext_Price()
                SetWPRL_ID()
                SetWPRL_Qty()
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
        
        
        Public Overridable Sub SetItem()

                  
            
        
            ' Set the Item LinkButton on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.Item is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetItem()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ItemSpecified Then
                				
                ' If the Item is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.Item)
                              
                Me.Item.Text = formattedValue
                
                Me.Item.ToolTip = "Go to " & Me.Item.Text.Replace("<wbr/>", "")
                
            Else 
            
                ' Item is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.Item.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.Item.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.Item.DefaultValue)
                        		
                End If
                                      
        End Sub
                
        Public Overridable Sub SetItemDescription()

                  
            
        
            ' Set the ItemDescription Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.ItemDescription is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetItemDescription()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ItemDescriptionSpecified Then
                				
                ' If the ItemDescription is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                              
                    Dim maxLength as Integer = Len(formattedValue)                   
                    If (maxLength >= CType(300, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(300, Integer)
                        'First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue)                       
                        
                    End If                    
                    If maxLength = CType(300, Integer) Then
                        formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,Math.Min(maxLength, Len(formattedValue))))
                        formattedValue = formattedValue & "..."
                            
                    End If
                End If  
                
                Me.ItemDescription.Text = formattedValue
                
            Else 
            
                ' ItemDescription is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.ItemDescription.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription.DefaultValue)
                        		
                End If
                 
            ' If the ItemDescription is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ItemDescription.Text Is Nothing _
                OrElse Me.ItemDescription.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ItemDescription.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetUnitOfMeasure()

                  
            
        
            ' Set the UnitOfMeasure Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.UnitOfMeasure is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUnitOfMeasure()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UnitOfMeasureSpecified Then
                				
                ' If the UnitOfMeasure is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.UnitOfMeasure)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UnitOfMeasure.Text = formattedValue
                
            Else 
            
                ' UnitOfMeasure is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.UnitOfMeasure.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.UnitOfMeasure.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.UnitOfMeasure.DefaultValue)
                        		
                End If
                 
            ' If the UnitOfMeasure is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UnitOfMeasure.Text Is Nothing _
                OrElse Me.UnitOfMeasure.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UnitOfMeasure.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetUnitPrice()

                  
            
        
            ' Set the UnitPrice Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.UnitPrice is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetUnitPrice()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.UnitPriceSpecified Then
                				
                ' If the UnitPrice is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.UnitPrice, "#,#.0000")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.UnitPrice.Text = formattedValue
                
            Else 
            
                ' UnitPrice is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.UnitPrice.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.UnitPrice.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.UnitPrice.DefaultValue, "#,#.0000")
                        		
                End If
                 
            ' If the UnitPrice is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.UnitPrice.Text Is Nothing _
                OrElse Me.UnitPrice.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.UnitPrice.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Audit_Comment()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Audit_Comment.ID) Then
            
                Me.WCDI_Audit_Comment.Text = Me.PreviousUIData(Me.WCDI_Audit_Comment.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Audit_Comment TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Audit_Comment is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Audit_Comment()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Audit_CommentSpecified Then
                				
                ' If the WCDI_Audit_Comment is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Audit_Comment)
                              
                Me.WCDI_Audit_Comment.Text = formattedValue
                
            Else 
            
                ' WCDI_Audit_Comment is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Audit_Comment.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Audit_Comment.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Audit_Comment.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_Audit_Comment.TextChanged, AddressOf WCDI_Audit_Comment_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Aw1()

                  
            
        
            ' Set the WCDI_Aw1 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw1Specified Then
                				
                ' If the WCDI_Aw1 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw1)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw1.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw1.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw1.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw1.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw1 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw1.Text Is Nothing _
                OrElse Me.WCDI_Aw1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw1.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw10()

                  
            
        
            ' Set the WCDI_Aw10 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw10 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw10()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw10Specified Then
                				
                ' If the WCDI_Aw10 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw10)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw10.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw10 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw10.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw10.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw10.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw10 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw10.Text Is Nothing _
                OrElse Me.WCDI_Aw10.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw10.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw2()

                  
            
        
            ' Set the WCDI_Aw2 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw2Specified Then
                				
                ' If the WCDI_Aw2 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw2)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw2.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw2 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw2.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw2.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw2.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw2 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw2.Text Is Nothing _
                OrElse Me.WCDI_Aw2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw2.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw3()

                  
            
        
            ' Set the WCDI_Aw3 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw3 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw3()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw3Specified Then
                				
                ' If the WCDI_Aw3 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw3)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw3.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw3 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw3.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw3.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw3.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw3 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw3.Text Is Nothing _
                OrElse Me.WCDI_Aw3.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw3.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw4()

                  
            
        
            ' Set the WCDI_Aw4 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw4 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw4()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw4Specified Then
                				
                ' If the WCDI_Aw4 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw4)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw4.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw4 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw4.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw4.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw4.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw4 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw4.Text Is Nothing _
                OrElse Me.WCDI_Aw4.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw4.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw5()

                  
            
        
            ' Set the WCDI_Aw5 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw5 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw5()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw5Specified Then
                				
                ' If the WCDI_Aw5 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw5)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw5.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw5 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw5.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw5.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw5.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw5 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw5.Text Is Nothing _
                OrElse Me.WCDI_Aw5.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw5.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw6()

                  
            
        
            ' Set the WCDI_Aw6 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw6 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw6()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw6Specified Then
                				
                ' If the WCDI_Aw6 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw6)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw6.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw6 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw6.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw6.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw6.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw6 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw6.Text Is Nothing _
                OrElse Me.WCDI_Aw6.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw6.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw7()

                  
            
        
            ' Set the WCDI_Aw7 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw7 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw7()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw7Specified Then
                				
                ' If the WCDI_Aw7 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw7)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw7.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw7 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw7.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw7.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw7.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw7 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw7.Text Is Nothing _
                OrElse Me.WCDI_Aw7.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw7.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw8()

                  
            
        
            ' Set the WCDI_Aw8 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw8 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw8()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw8Specified Then
                				
                ' If the WCDI_Aw8 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw8)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw8.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw8 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw8.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw8.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw8.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw8 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw8.Text Is Nothing _
                OrElse Me.WCDI_Aw8.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw8.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Aw9()

                  
            
        
            ' Set the WCDI_Aw9 Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Aw9 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Aw9()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Aw9Specified Then
                				
                ' If the WCDI_Aw9 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw9)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                formattedValue = String.Format("PREFERRED VENDOR: <font color=blue>{0}</font>", formattedValue)
                Me.WCDI_Aw9.Text = formattedValue
                
            Else 
            
                ' WCDI_Aw9 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Aw9.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw9.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw9.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_Aw9 is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_Aw9.Text Is Nothing _
                OrElse Me.WCDI_Aw9.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_Aw9.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_Award()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award.ID) Then
                Me.WCDI_Award.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award1 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Award1Specified Then
                									
                ' If the WCDI_Award1 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.WCDI_Award.Checked = Me.DataSource.WCDI_Award1
            Else
            
                ' WCDI_Award1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award1.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award1.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award1()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award1.ID) Then
                Me.WCDI_Award1.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award1.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award2 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award1 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award1()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award2 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award2")).Equals("true") Then
                    Me.WCDI_Award1.Checked = True
                Else
                    Me.WCDI_Award1.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award2 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award1.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award2.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award2.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award2()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award2.ID) Then
                Me.WCDI_Award2.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award2.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award3 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award2 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award2()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award3 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award3")).Equals("true") Then
                    Me.WCDI_Award2.Checked = True
                Else
                    Me.WCDI_Award2.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award3 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award2.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award3.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award3.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award3()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award3.ID) Then
                Me.WCDI_Award3.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award3.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award4 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award3 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award3()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award4 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award4")).Equals("true") Then
                    Me.WCDI_Award3.Checked = True
                Else
                    Me.WCDI_Award3.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award4 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award3.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award4.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award4.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award4()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award4.ID) Then
                Me.WCDI_Award4.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award4.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award5 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award4 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award4()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award5 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award5")).Equals("true") Then
                    Me.WCDI_Award4.Checked = True
                Else
                    Me.WCDI_Award4.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award5 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award4.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award5.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award5.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award5()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award5.ID) Then
                Me.WCDI_Award5.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award5.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award6 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award5 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award5()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award6 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award6")).Equals("true") Then
                    Me.WCDI_Award5.Checked = True
                Else
                    Me.WCDI_Award5.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award6 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award5.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award6.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award6.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award6()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award6.ID) Then
                Me.WCDI_Award6.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award6.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award7 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award6 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award6()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award7 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award7")).Equals("true") Then
                    Me.WCDI_Award6.Checked = True
                Else
                    Me.WCDI_Award6.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award7 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award6.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award7.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award7.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award7()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award7.ID) Then
                Me.WCDI_Award7.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award7.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award8 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award7 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award7()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award8 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award8")).Equals("true") Then
                    Me.WCDI_Award7.Checked = True
                Else
                    Me.WCDI_Award7.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award8 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award7.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award8.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award8.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award8()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award8.ID) Then
                Me.WCDI_Award8.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award8.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award9 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award8 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award8()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award9 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award9")).Equals("true") Then
                    Me.WCDI_Award8.Checked = True
                Else
                    Me.WCDI_Award8.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award9 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award8.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award9.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award9.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Award9()

                      
            							
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Award9.ID) Then
                Me.WCDI_Award9.Checked = Convert.ToBoolean(Me.PreviousUIData(Me.WCDI_Award9.ID))
                Return
            End If		
            
        
            ' Set the WCDI_Award10 CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Award9 is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCDI_Award9()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                									
                ' If the WCDI_Award10 is non-NULL, then format the value.
                ' The Format method will use the Display Format
                If InvariantLCase(EvaluateFormula("WCDI_Award10")).Equals("true") Then
                    Me.WCDI_Award9.Checked = True
                Else
                    Me.WCDI_Award9.Checked = False
                End If
                    
            Else
            
                ' WCDI_Award10 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCDI_Award9.Checked = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award10.ParseValue(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Award10.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCDI_Bid()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid.ID) Then
            
                Me.WCDI_Bid.Text = Me.PreviousUIData(Me.WCDI_Bid.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid1 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Bid1Specified Then
                				
                ' If the WCDI_Bid1 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid1, "#,#.0000")
                              
                Me.WCDI_Bid.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid1.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid1.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid.TextChanged, AddressOf WCDI_Bid_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid1.ID) Then
            
                Me.WCDI_Bid1.Text = Me.PreviousUIData(Me.WCDI_Bid1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid2 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid2 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid2", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid1.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid2 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid1.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid2.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid2.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid1.TextChanged, AddressOf WCDI_Bid1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid2()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid2.ID) Then
            
                Me.WCDI_Bid2.Text = Me.PreviousUIData(Me.WCDI_Bid2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid3 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid3 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid3", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid2.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid3 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid2.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid3.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid3.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid2.TextChanged, AddressOf WCDI_Bid2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid3()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid3.ID) Then
            
                Me.WCDI_Bid3.Text = Me.PreviousUIData(Me.WCDI_Bid3.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid4 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid3 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid3()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid4 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid4", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid3.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid4 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid3.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid4.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid4.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid3.TextChanged, AddressOf WCDI_Bid3_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid4()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid4.ID) Then
            
                Me.WCDI_Bid4.Text = Me.PreviousUIData(Me.WCDI_Bid4.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid5 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid4 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid4()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid5 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid5", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid4.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid5 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid4.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid5.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid5.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid4.TextChanged, AddressOf WCDI_Bid4_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid5()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid5.ID) Then
            
                Me.WCDI_Bid5.Text = Me.PreviousUIData(Me.WCDI_Bid5.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid6 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid5 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid5()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid6 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid6", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid5.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid6 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid5.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid6.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid6.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid5.TextChanged, AddressOf WCDI_Bid5_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid6()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid6.ID) Then
            
                Me.WCDI_Bid6.Text = Me.PreviousUIData(Me.WCDI_Bid6.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid7 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid6 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid6()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid7 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid7", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid6.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid7 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid6.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid7.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid7.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid6.TextChanged, AddressOf WCDI_Bid6_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid7()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid7.ID) Then
            
                Me.WCDI_Bid7.Text = Me.PreviousUIData(Me.WCDI_Bid7.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid8 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid7 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid7()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid8 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid8", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid7.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid8 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid7.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid8.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid8.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid7.TextChanged, AddressOf WCDI_Bid7_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid8()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid8.ID) Then
            
                Me.WCDI_Bid8.Text = Me.PreviousUIData(Me.WCDI_Bid8.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid9 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid8 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid8()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid9 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid9", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid8.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid9 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid8.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid9.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid9.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid8.TextChanged, AddressOf WCDI_Bid8_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Bid9()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Bid9.ID) Then
            
                Me.WCDI_Bid9.Text = Me.PreviousUIData(Me.WCDI_Bid9.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Bid10 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Bid9 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Bid9()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Bid10 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Bid10", Me.DataSource, "#,#.0000")
                Me.WCDI_Bid9.Text = formattedValue
                
            Else 
            
                ' WCDI_Bid10 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Bid9.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid10.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid10.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Bid9.TextChanged, AddressOf WCDI_Bid9_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Comment()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Comment.ID) Then
            
                Me.WCDI_Comment.Text = Me.PreviousUIData(Me.WCDI_Comment.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Comment TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Comment is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Comment()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_CommentSpecified Then
                				
                ' If the WCDI_Comment is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Comment)
                              
                Me.WCDI_Comment.Text = formattedValue
                
            Else 
            
                ' WCDI_Comment is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Comment.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Comment.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Comment.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_Comment.TextChanged, AddressOf WCDI_Comment_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_ID()

                  
            
        
            ' Set the WCDI_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_IDSpecified Then
                				
                ' If the WCDI_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCDI_ID.Text = formattedValue
                
            Else 
            
                ' WCDI_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_ID.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_ID.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_ID.DefaultValue)
                        		
                End If
                 
            ' If the WCDI_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WCDI_ID.Text Is Nothing _
                OrElse Me.WCDI_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WCDI_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID1.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID1.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID1 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_PM00200_Vendor_ID1Specified Then
                				
                ' If the WCDI_PM00200_Vendor_ID1 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = ""
                Dim _isExpandableNonCompositeForeignKey As Boolean = Sel_WCanvass_Detail_Internal_WPR_Line1View.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID1)
                If _isExpandableNonCompositeForeignKey AndAlso Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID1.IsApplyDisplayAs Then
                                  
                       formattedValue = Sel_WCanvass_Detail_Internal_WPR_Line1View.GetDFKA(Me.DataSource.WCDI_PM00200_Vendor_ID1.ToString(),Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID1, Nothing)
                                    
                       If (formattedValue Is Nothing) Then
                              formattedValue = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID1)
                       End If
                Else
                       formattedValue = Me.DataSource.WCDI_PM00200_Vendor_ID1.ToString()
                End If
                                
                Me.WCDI_PM00200_Vendor_ID1.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID1.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID1.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID1.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID1.TextChanged, AddressOf WCDI_PM00200_Vendor_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID10()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID10.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID10.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID10.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID6 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID10 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID10()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID6 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID6", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID10.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID6 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID10.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID6.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID6.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID10.TextChanged, AddressOf WCDI_PM00200_Vendor_ID10_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID11()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID11.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID11.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID11.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID6 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID11 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID11()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID6 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID6", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID11.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID6 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID11.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID6.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID6.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID11.TextChanged, AddressOf WCDI_PM00200_Vendor_ID11_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID12()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID12.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID12.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID12.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID7 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID12 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID12()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID7 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID7", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID12.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID7 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID12.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID7.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID7.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID12.TextChanged, AddressOf WCDI_PM00200_Vendor_ID12_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID13()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID13.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID13.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID13.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID7 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID13 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID13()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID7 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID7", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID13.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID7 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID13.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID7.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID7.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID13.TextChanged, AddressOf WCDI_PM00200_Vendor_ID13_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID14()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID14.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID14.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID14.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID8 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID14 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID14()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID8 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID8", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID14.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID8 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID14.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID8.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID8.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID14.TextChanged, AddressOf WCDI_PM00200_Vendor_ID14_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID15()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID15.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID15.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID15.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID8 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID15 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID15()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID8 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID8", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID15.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID8 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID15.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID8.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID8.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID15.TextChanged, AddressOf WCDI_PM00200_Vendor_ID15_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID16()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID16.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID16.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID16.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID9 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID16 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID16()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID9 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID9", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID16.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID9 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID16.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID9.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID9.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID16.TextChanged, AddressOf WCDI_PM00200_Vendor_ID16_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID17()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID17.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID17.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID17.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID9 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID17 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID17()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID9 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID9", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID17.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID9 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID17.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID9.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID9.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID17.TextChanged, AddressOf WCDI_PM00200_Vendor_ID17_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID18()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID18.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID18.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID18.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID10 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID18 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID18()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID10 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID10", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID18.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID10 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID18.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID10.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID10.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID18.TextChanged, AddressOf WCDI_PM00200_Vendor_ID18_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID19()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID19.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID19.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID19.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID10 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID19 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID19()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID10 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID10", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID19.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID10 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID19.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID10.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID10.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID19.TextChanged, AddressOf WCDI_PM00200_Vendor_ID19_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID2()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID2.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID2.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID2 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID2 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID2", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID2.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID2 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID2.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID2.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID2.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID2.TextChanged, AddressOf WCDI_PM00200_Vendor_ID2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID3()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID3.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID3.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID3.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID2 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID3 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID3()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID2 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID2", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID3.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID2 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID3.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID2.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID2.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID3.TextChanged, AddressOf WCDI_PM00200_Vendor_ID3_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID4()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID4.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID4.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID4.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID3 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID4 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID4()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID3 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID3", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID4.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID3 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID4.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID3.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID3.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID4.TextChanged, AddressOf WCDI_PM00200_Vendor_ID4_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID5()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID5.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID5.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID5.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID3 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID5 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID5()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID3 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID3", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID5.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID3 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID5.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID3.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID3.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID5.TextChanged, AddressOf WCDI_PM00200_Vendor_ID5_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID6()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID6.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID6.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID6.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID4 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID6 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID6()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID4 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID4", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID6.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID4 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID6.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID4.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID4.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID6.TextChanged, AddressOf WCDI_PM00200_Vendor_ID6_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID7()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID7.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID7.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID7.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID4 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID7 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID7()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID4 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID4", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID7.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID4 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID7.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID4.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID4.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID7.TextChanged, AddressOf WCDI_PM00200_Vendor_ID7_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID8()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID8.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID8.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID8.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID5 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID8 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID8()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID5 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID5", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID8.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID5 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID8.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID5.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID5.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID8.TextChanged, AddressOf WCDI_PM00200_Vendor_ID8_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_PM00200_Vendor_ID9()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_PM00200_Vendor_ID9.ID) Then
            
                Me.WCDI_PM00200_Vendor_ID9.Text = Me.PreviousUIData(Me.WCDI_PM00200_Vendor_ID9.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_PM00200_Vendor_ID5 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_PM00200_Vendor_ID9 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_PM00200_Vendor_ID9()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_PM00200_Vendor_ID5 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                Dim formattedValue As String = EvaluateFormula("WCDI_PM00200_Vendor_ID5", Me.DataSource)
                Me.WCDI_PM00200_Vendor_ID9.Text = formattedValue
                
            Else 
            
                ' WCDI_PM00200_Vendor_ID5 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_PM00200_Vendor_ID9.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID5.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID5.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCDI_PM00200_Vendor_ID9.TextChanged, AddressOf WCDI_PM00200_Vendor_ID9_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty.ID) Then
            
                Me.WCDI_Qty.Text = Me.PreviousUIData(Me.WCDI_Qty.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty1 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCDI_Qty1Specified Then
                				
                ' If the WCDI_Qty1 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty1, "#,#.0000")
                              
                Me.WCDI_Qty.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty1.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty1.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty.TextChanged, AddressOf WCDI_Qty_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty1.ID) Then
            
                Me.WCDI_Qty1.Text = Me.PreviousUIData(Me.WCDI_Qty1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty2 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty2 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty2", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty1.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty2 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty1.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty2.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty2.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty1.TextChanged, AddressOf WCDI_Qty1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty2()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty2.ID) Then
            
                Me.WCDI_Qty2.Text = Me.PreviousUIData(Me.WCDI_Qty2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty3 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty3 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty3", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty2.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty3 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty2.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty3.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty3.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty2.TextChanged, AddressOf WCDI_Qty2_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty3()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty3.ID) Then
            
                Me.WCDI_Qty3.Text = Me.PreviousUIData(Me.WCDI_Qty3.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty4 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty3 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty3()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty4 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty4", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty3.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty4 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty3.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty4.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty4.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty3.TextChanged, AddressOf WCDI_Qty3_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty4()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty4.ID) Then
            
                Me.WCDI_Qty4.Text = Me.PreviousUIData(Me.WCDI_Qty4.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty5 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty4 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty4()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty5 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty5", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty4.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty5 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty4.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty5.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty5.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty4.TextChanged, AddressOf WCDI_Qty4_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty5()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty5.ID) Then
            
                Me.WCDI_Qty5.Text = Me.PreviousUIData(Me.WCDI_Qty5.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty6 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty5 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty5()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty6 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty6", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty5.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty6 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty5.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty6.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty6.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty5.TextChanged, AddressOf WCDI_Qty5_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty6()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty6.ID) Then
            
                Me.WCDI_Qty6.Text = Me.PreviousUIData(Me.WCDI_Qty6.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty7 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty6 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty6()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty7 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty7", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty6.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty7 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty6.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty7.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty7.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty6.TextChanged, AddressOf WCDI_Qty6_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty7()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty7.ID) Then
            
                Me.WCDI_Qty7.Text = Me.PreviousUIData(Me.WCDI_Qty7.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty8 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty7 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty7()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty8 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty8", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty7.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty8 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty7.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty8.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty8.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty7.TextChanged, AddressOf WCDI_Qty7_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty8()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty8.ID) Then
            
                Me.WCDI_Qty8.Text = Me.PreviousUIData(Me.WCDI_Qty8.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty9 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty8 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty8()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty9 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty9", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty8.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty9 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty8.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty9.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty9.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty8.TextChanged, AddressOf WCDI_Qty8_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCDI_Qty9()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCDI_Qty9.ID) Then
            
                Me.WCDI_Qty9.Text = Me.PreviousUIData(Me.WCDI_Qty9.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCDI_Qty10 TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WCDI_Qty9 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCDI_Qty9()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                				
                ' If the WCDI_Qty10 is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = EvaluateFormula("WCDI_Qty10", Me.DataSource, "#,#.0000")
                Me.WCDI_Qty9.Text = formattedValue
                
            Else 
            
                ' WCDI_Qty10 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCDI_Qty9.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty10.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty10.DefaultValue, "#,#.0000")
                        		
                End If
                 
              AddHandler Me.WCDI_Qty9.TextChanged, AddressOf WCDI_Qty9_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWPRL_Ext_Price()

                  
            
        
            ' Set the WPRL_Ext_Price Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WPRL_Ext_Price is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPRL_Ext_Price()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPRL_Ext_PriceSpecified Then
                				
                ' If the WPRL_Ext_Price is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_Ext_Price, "#,#.00")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPRL_Ext_Price.Text = formattedValue
                
            Else 
            
                ' WPRL_Ext_Price is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPRL_Ext_Price.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_Ext_Price.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_Ext_Price.DefaultValue, "#,#.00")
                        		
                End If
                 
            ' If the WPRL_Ext_Price is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPRL_Ext_Price.Text Is Nothing _
                OrElse Me.WPRL_Ext_Price.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPRL_Ext_Price.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPRL_ID()

                  
            
        
            ' Set the WPRL_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WPRL_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPRL_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPRL_IDSpecified Then
                				
                ' If the WPRL_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPRL_ID.Text = formattedValue
                
            Else 
            
                ' WPRL_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPRL_ID.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_ID.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_ID.DefaultValue)
                        		
                End If
                 
            ' If the WPRL_ID is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPRL_ID.Text Is Nothing _
                OrElse Me.WPRL_ID.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPRL_ID.Text = "&nbsp;"
            End If
                                       
        End Sub
                
        Public Overridable Sub SetWPRL_Qty()

                  
            
        
            ' Set the WPRL_Qty Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.sel_WCanvass_Detail_Internal_WPR_Line record retrieved from the database.
            ' Me.WPRL_Qty is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWPRL_Qty()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WPRL_QtySpecified Then
                				
                ' If the WPRL_Qty is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_Qty, "#,#.0000")
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WPRL_Qty.Text = formattedValue
                
            Else 
            
                ' WPRL_Qty is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WPRL_Qty.Text = Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_Qty.Format(Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_Qty.DefaultValue, "#,#.0000")
                        		
                End If
                 
            ' If the WPRL_Qty is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.WPRL_Qty.Text Is Nothing _
                OrElse Me.WPRL_Qty.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.WPRL_Qty.Text = "&nbsp;"
            End If
                                       
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
                
        Public Overridable Sub SetlitBreak12()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litBreak12.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitBreak14()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litBreak14.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitBreak16()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litBreak16.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitBreak18()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litBreak18.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitBreak3()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litBreak3.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitBreak5()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litBreak5.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitBreak7()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litBreak7.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetlitBreak9()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.litBreak9.Text = "Some value"
                    
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
        
            GetItem()
            GetItemDescription()
            GetUnitOfMeasure()
            GetUnitPrice()
            GetWCDI_Audit_Comment()
            GetWCDI_Aw1()
            GetWCDI_Aw10()
            GetWCDI_Aw2()
            GetWCDI_Aw3()
            GetWCDI_Aw4()
            GetWCDI_Aw5()
            GetWCDI_Aw6()
            GetWCDI_Aw7()
            GetWCDI_Aw8()
            GetWCDI_Aw9()
            GetWCDI_Award()
            GetWCDI_Award1()
            GetWCDI_Award2()
            GetWCDI_Award3()
            GetWCDI_Award4()
            GetWCDI_Award5()
            GetWCDI_Award6()
            GetWCDI_Award7()
            GetWCDI_Award8()
            GetWCDI_Award9()
            GetWCDI_Bid()
            GetWCDI_Bid1()
            GetWCDI_Bid2()
            GetWCDI_Bid3()
            GetWCDI_Bid4()
            GetWCDI_Bid5()
            GetWCDI_Bid6()
            GetWCDI_Bid7()
            GetWCDI_Bid8()
            GetWCDI_Bid9()
            GetWCDI_Comment()
            GetWCDI_ID()
            GetWCDI_PM00200_Vendor_ID1()
            GetWCDI_PM00200_Vendor_ID10()
            GetWCDI_PM00200_Vendor_ID11()
            GetWCDI_PM00200_Vendor_ID12()
            GetWCDI_PM00200_Vendor_ID13()
            GetWCDI_PM00200_Vendor_ID14()
            GetWCDI_PM00200_Vendor_ID15()
            GetWCDI_PM00200_Vendor_ID16()
            GetWCDI_PM00200_Vendor_ID17()
            GetWCDI_PM00200_Vendor_ID18()
            GetWCDI_PM00200_Vendor_ID19()
            GetWCDI_PM00200_Vendor_ID2()
            GetWCDI_PM00200_Vendor_ID3()
            GetWCDI_PM00200_Vendor_ID4()
            GetWCDI_PM00200_Vendor_ID5()
            GetWCDI_PM00200_Vendor_ID6()
            GetWCDI_PM00200_Vendor_ID7()
            GetWCDI_PM00200_Vendor_ID8()
            GetWCDI_PM00200_Vendor_ID9()
            GetWCDI_Qty()
            GetWCDI_Qty1()
            GetWCDI_Qty2()
            GetWCDI_Qty3()
            GetWCDI_Qty4()
            GetWCDI_Qty5()
            GetWCDI_Qty6()
            GetWCDI_Qty7()
            GetWCDI_Qty8()
            GetWCDI_Qty9()
            GetWPRL_Ext_Price()
            GetWPRL_ID()
            GetWPRL_Qty()
        End Sub
        
        
        Public Overridable Sub GetItem()
            
        End Sub
                
        Public Overridable Sub GetItemDescription()
            
        End Sub
                
        Public Overridable Sub GetUnitOfMeasure()
            
        End Sub
                
        Public Overridable Sub GetUnitPrice()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Audit_Comment()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw1()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw10()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw2()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw3()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw4()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw5()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw6()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw7()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw8()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Aw9()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Award()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award1()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award2()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award3()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award4()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award5()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award6()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award7()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award8()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Award9()
        
        End Sub
                
        Public Overridable Sub GetWCDI_Bid()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid1()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid2()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid3()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid4()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid5()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid6()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid7()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid8()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Bid9()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Comment()
            
        End Sub
                
        Public Overridable Sub GetWCDI_ID()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID1()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID10()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID11()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID12()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID13()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID14()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID15()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID16()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID17()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID18()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID19()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID2()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID3()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID4()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID5()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID6()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID7()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID8()
            
        End Sub
                
        Public Overridable Sub GetWCDI_PM00200_Vendor_ID9()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty1()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty2()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty3()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty4()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty5()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty6()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty7()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty8()
            
        End Sub
                
        Public Overridable Sub GetWCDI_Qty9()
            
        End Sub
                
        Public Overridable Sub GetWPRL_Ext_Price()
            
        End Sub
                
        Public Overridable Sub GetWPRL_ID()
            
        End Sub
                
        Public Overridable Sub GetWPRL_Qty()
            
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
        
        ' event handler for LinkButton
        Public Overridable Sub Item_Click(ByVal sender As Object, ByVal args As EventArgs)
              
    Try
    
            Catch ex As Exception
            
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
    
            Finally
    
            End Try
    
        End Sub
        
        Protected Overridable Sub WCDI_Award_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award1_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award2_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award3_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award4_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award5_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award6_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award7_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award8_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Award9_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCDI_Audit_Comment_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid3_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid4_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid5_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid6_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid7_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid8_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Bid9_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Comment_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID10_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID11_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID12_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID13_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID14_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID15_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID16_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID17_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID18_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID19_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID3_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID4_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID5_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID6_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID7_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID8_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_PM00200_Vendor_ID9_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty3_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty4_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty5_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty6_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty7_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty8_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCDI_Qty9_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
            
        Public ReadOnly Property ItemDescription() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemDescription"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property litBreak12() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak12"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litBreak14() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak14"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litBreak16() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak16"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litBreak18() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak18"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litBreak3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litBreak5() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak5"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litBreak7() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak7"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property litBreak9() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "litBreak9"), System.Web.UI.WebControls.Literal)
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

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
        
        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean, ByVal includeSession As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
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

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean,ByVal includeSession as Boolean) As String
            
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
            If includeSession  Then
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            Else
                Return EvaluateExpressions(url, arg, rec, bEncrypt,False)  
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
          
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
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
                SetWPRL_Ext_PriceLabel()
                SetWPRL_QtyLabel()
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
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID1, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID6, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID6, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID7, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID7, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID8, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID8, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID9, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID9, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID10, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID10, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID2, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID2, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID3, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID3, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID4, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID4, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID5, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID5, Me.DataSource)
          
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
        

            ' Bind the buttons for Sel_WCanvass_Detail_Internal_WPR_Line1TableControl pagination.
        


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

                
    
    Return wc
    End Function

    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
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
    Dim rep As System.Web.UI.WebControls.Repeater = CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRepeater"), System.Web.UI.WebControls.Repeater)
    If rep Is Nothing Then Return

    
    Dim repItem As System.Web.UI.WebControls.RepeaterItem
    For Each repItem In rep.Items
      
    ' Loop through all rows in the table, set its DataSource and call DataBind().
    
    Dim recControl As Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow = DirectCast(repItem.FindControl("Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow"), Sel_WCanvass_Detail_Internal_WPR_Line1TableControlRow)
    

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                        Dim rec As Sel_WCanvass_Detail_Internal_WPR_Line1Record = New Sel_WCanvass_Detail_Internal_WPR_Line1Record()
        
                        If recControl.Item.Text <> "" Then
                            rec.Parse(recControl.Item.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.Item)
                        End If
                        If recControl.ItemDescription.Text <> "" Then
                            rec.Parse(recControl.ItemDescription.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.ItemDescription)
                        End If
                        If recControl.UnitOfMeasure.Text <> "" Then
                            rec.Parse(recControl.UnitOfMeasure.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.UnitOfMeasure)
                        End If
                        If recControl.UnitPrice.Text <> "" Then
                            rec.Parse(recControl.UnitPrice.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.UnitPrice)
                        End If
                        If recControl.WCDI_Audit_Comment.Text <> "" Then
                            rec.Parse(recControl.WCDI_Audit_Comment.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Audit_Comment)
                        End If
                        If recControl.WCDI_Aw1.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw1.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw1)
                        End If
                        If recControl.WCDI_Aw10.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw10.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw10)
                        End If
                        If recControl.WCDI_Aw2.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw2.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw2)
                        End If
                        If recControl.WCDI_Aw3.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw3.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw3)
                        End If
                        If recControl.WCDI_Aw4.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw4.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw4)
                        End If
                        If recControl.WCDI_Aw5.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw5.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw5)
                        End If
                        If recControl.WCDI_Aw6.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw6.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw6)
                        End If
                        If recControl.WCDI_Aw7.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw7.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw7)
                        End If
                        If recControl.WCDI_Aw8.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw8.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw8)
                        End If
                        If recControl.WCDI_Aw9.Text <> "" Then
                            rec.Parse(recControl.WCDI_Aw9.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Aw9)
                        End If
                        rec.WCDI_Award1 = recControl.WCDI_Award.Checked
                
                        rec.WCDI_Award2 = recControl.WCDI_Award1.Checked
                
                        rec.WCDI_Award3 = recControl.WCDI_Award2.Checked
                
                        rec.WCDI_Award4 = recControl.WCDI_Award3.Checked
                
                        rec.WCDI_Award5 = recControl.WCDI_Award4.Checked
                
                        rec.WCDI_Award6 = recControl.WCDI_Award5.Checked
                
                        rec.WCDI_Award7 = recControl.WCDI_Award6.Checked
                
                        rec.WCDI_Award8 = recControl.WCDI_Award7.Checked
                
                        rec.WCDI_Award9 = recControl.WCDI_Award8.Checked
                
                        rec.WCDI_Award10 = recControl.WCDI_Award9.Checked
                
                        If recControl.WCDI_Bid.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid1)
                        End If
                        If recControl.WCDI_Bid1.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid1.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid2)
                        End If
                        If recControl.WCDI_Bid2.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid2.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid3)
                        End If
                        If recControl.WCDI_Bid3.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid3.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid4)
                        End If
                        If recControl.WCDI_Bid4.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid4.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid5)
                        End If
                        If recControl.WCDI_Bid5.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid5.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid6)
                        End If
                        If recControl.WCDI_Bid6.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid6.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid7)
                        End If
                        If recControl.WCDI_Bid7.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid7.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid8)
                        End If
                        If recControl.WCDI_Bid8.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid8.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid9)
                        End If
                        If recControl.WCDI_Bid9.Text <> "" Then
                            rec.Parse(recControl.WCDI_Bid9.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Bid10)
                        End If
                        If recControl.WCDI_Comment.Text <> "" Then
                            rec.Parse(recControl.WCDI_Comment.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Comment)
                        End If
                        If recControl.WCDI_ID.Text <> "" Then
                            rec.Parse(recControl.WCDI_ID.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_ID)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID1.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID1.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID1)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID10.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID10.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID6)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID11.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID11.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID6)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID12.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID12.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID7)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID13.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID13.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID7)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID14.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID14.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID8)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID15.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID15.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID8)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID16.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID16.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID9)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID17.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID17.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID9)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID18.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID18.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID10)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID19.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID19.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID10)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID2.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID2.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID2)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID3.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID3.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID2)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID4.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID4.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID3)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID5.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID5.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID3)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID6.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID6.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID4)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID7.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID7.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID4)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID8.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID8.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID5)
                        End If
                        If recControl.WCDI_PM00200_Vendor_ID9.Text <> "" Then
                            rec.Parse(recControl.WCDI_PM00200_Vendor_ID9.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_PM00200_Vendor_ID5)
                        End If
                        If recControl.WCDI_Qty.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty1)
                        End If
                        If recControl.WCDI_Qty1.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty1.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty2)
                        End If
                        If recControl.WCDI_Qty2.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty2.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty3)
                        End If
                        If recControl.WCDI_Qty3.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty3.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty4)
                        End If
                        If recControl.WCDI_Qty4.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty4.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty5)
                        End If
                        If recControl.WCDI_Qty5.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty5.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty6)
                        End If
                        If recControl.WCDI_Qty6.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty6.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty7)
                        End If
                        If recControl.WCDI_Qty7.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty7.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty8)
                        End If
                        If recControl.WCDI_Qty8.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty8.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty9)
                        End If
                        If recControl.WCDI_Qty9.Text <> "" Then
                            rec.Parse(recControl.WCDI_Qty9.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WCDI_Qty10)
                        End If
                        If recControl.WPRL_Ext_Price.Text <> "" Then
                            rec.Parse(recControl.WPRL_Ext_Price.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_Ext_Price)
                        End If
                        If recControl.WPRL_ID.Text <> "" Then
                            rec.Parse(recControl.WPRL_ID.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_ID)
                        End If
                        If recControl.WPRL_Qty.Text <> "" Then
                            rec.Parse(recControl.WPRL_Qty.Text, Sel_WCanvass_Detail_Internal_WPR_Line1View.WPRL_Qty)
                        End If
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
    
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Sel_WCanvass_Detail_Internal_WPR_Line1TableControl_OrderBy"), String)
          
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
                

        ' Generate the event handling functions for pagination events.
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

        ' Generate the event handling functions for filter and search events.
        
    
        ' Generate the event handling functions for others
        
      


        Protected _TotalRecords As Integer = -1
        Public Property TotalRecords() As Integer
            Get
                If _TotalRecords < 0 
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
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Public Property DataSource() As Sel_WCanvass_Detail_Internal_WPR_Line1Record ()
            Get
                Return DirectCast(MyBase._DataSource, Sel_WCanvass_Detail_Internal_WPR_Line1Record())
            End Get
            Set(ByVal value() As Sel_WCanvass_Detail_Internal_WPR_Line1Record)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property ItemDescriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemDescriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ItemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ItemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UnitOfMeasureLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UnitOfMeasureLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property UnitPriceLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "UnitPriceLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Audit_CommentLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Audit_CommentLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label4() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label4"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label5() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label5"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label6() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label6"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label7() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label7"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label8() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label8"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Award1Label9() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Award1Label9"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label4() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label4"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label5() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label5"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label6() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label6"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label7() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label7"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label8() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label8"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_Bid1Label9() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_Bid1Label9"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_CommentLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_CommentLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label3() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label3"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label4() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label4"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label5() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label5"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label6() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label6"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label7() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label7"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label8() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label8"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCDI_PM00200_Vendor_ID1Label9() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCDI_PM00200_Vendor_ID1Label9"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPRL_Ext_PriceLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRL_Ext_PriceLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WPRL_QtyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WPRL_QtyLabel"), System.Web.UI.WebControls.Literal)
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
          
              AddHandler Me.WCQI_Desc.TextChanged, AddressOf WCQI_Desc_TextChanged
            
              AddHandler Me.WCQI_PM00200_Vendor_ID.TextChanged, AddressOf WCQI_PM00200_Vendor_ID_TextChanged
            
              AddHandler Me.WCQI_PM00200_Vendor_ID1.TextChanged, AddressOf WCQI_PM00200_Vendor_ID1_TextChanged
            
    
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
        
                SetLiteral4()
                SetWCQI_Desc()
                SetWCQI_File()
                SetWCQI_PM00200_Vendor_ID()
                SetWCQI_PM00200_Vendor_ID1()
      
      
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

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCQI_Desc.ID) Then
            
                Me.WCQI_Desc.Text = Me.PreviousUIData(Me.WCQI_Desc.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCQI_Desc TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal record retrieved from the database.
            ' Me.WCQI_Desc is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCQI_Desc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCQI_DescSpecified Then
                				
                ' If the WCQI_Desc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Quotation_Internal1Table.WCQI_Desc)
                              
                Me.WCQI_Desc.Text = formattedValue
                
            Else 
            
                ' WCQI_Desc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCQI_Desc.Text = WCanvass_Quotation_Internal1Table.WCQI_Desc.Format(WCanvass_Quotation_Internal1Table.WCQI_Desc.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCQI_Desc.TextChanged, AddressOf WCQI_Desc_TextChanged
                                 
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

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCQI_PM00200_Vendor_ID.ID) Then
            
                Me.WCQI_PM00200_Vendor_ID.Text = Me.PreviousUIData(Me.WCQI_PM00200_Vendor_ID.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCQI_PM00200_Vendor_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal record retrieved from the database.
            ' Me.WCQI_PM00200_Vendor_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCQI_PM00200_Vendor_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCQI_PM00200_Vendor_IDSpecified Then
                				
                ' If the WCQI_PM00200_Vendor_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID)
                              
                Me.WCQI_PM00200_Vendor_ID.Text = formattedValue
                
            Else 
            
                ' WCQI_PM00200_Vendor_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCQI_PM00200_Vendor_ID.Text = WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.Format(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCQI_PM00200_Vendor_ID.TextChanged, AddressOf WCQI_PM00200_Vendor_ID_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCQI_PM00200_Vendor_ID1()

                  
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.WCQI_PM00200_Vendor_ID1.ID) Then
            
                Me.WCQI_PM00200_Vendor_ID1.Text = Me.PreviousUIData(Me.WCQI_PM00200_Vendor_ID1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the WCQI_PM00200_Vendor_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Quotation_Internal record retrieved from the database.
            ' Me.WCQI_PM00200_Vendor_ID1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCQI_PM00200_Vendor_ID1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCQI_PM00200_Vendor_IDSpecified Then
                				
                ' If the WCQI_PM00200_Vendor_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID)
                              
                Me.WCQI_PM00200_Vendor_ID1.Text = formattedValue
                
            Else 
            
                ' WCQI_PM00200_Vendor_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCQI_PM00200_Vendor_ID1.Text = WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.Format(WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCQI_PM00200_Vendor_ID1.TextChanged, AddressOf WCQI_PM00200_Vendor_ID1_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetLiteral4()

                  
                  
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
            GetWCQI_PM00200_Vendor_ID1()
        End Sub
        
        
        Public Overridable Sub GetWCQI_Desc()
            
        End Sub
                
        Public Overridable Sub GetWCQI_PM00200_Vendor_ID()
            
        End Sub
                
        Public Overridable Sub GetWCQI_PM00200_Vendor_ID1()
            
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
        
        Protected Overridable Sub WCQI_Desc_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCQI_PM00200_Vendor_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCQI_PM00200_Vendor_ID1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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
        
        Public ReadOnly Property Literal4() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Literal4"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCQI_Desc() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_Desc"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCQI_File() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_File"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property WCQI_PM00200_Vendor_ID() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_PM00200_Vendor_ID"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property WCQI_PM00200_Vendor_ID1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_PM00200_Vendor_ID1"), System.Web.UI.WebControls.TextBox)
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
        
                SetWCQI_DescLabel()
                SetWCQI_FileLabel()
                SetWCQI_PM00200_Vendor_IDLabel()
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
        

            ' Bind the buttons for WCanvass_Quotation_Internal1TableControl pagination.
        


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
                        If recControl.WCQI_PM00200_Vendor_ID1.Text <> "" Then
                            rec.Parse(recControl.WCQI_PM00200_Vendor_ID1.Text, WCanvass_Quotation_Internal1Table.WCQI_PM00200_Vendor_ID)
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
        
        Public Overridable Sub SetWCQI_DescLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCQI_DescLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCQI_FileLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCQI_FileLabel.Text = "Some value"
                    
                  End Sub
                
        Public Overridable Sub SetWCQI_PM00200_Vendor_IDLabel()

                  
                  
                      'Code for the text property is generated inside the .aspx file.
                      'To override this property you can uncomment the following property and add your own value.
                      'Me.WCQI_PM00200_Vendor_IDLabel.Text = "Some value"
                    
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

            Dim orderByStr As String = CType(ViewState("WCanvass_Quotation_Internal1TableControl_OrderBy"), String)
          
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
                Me.ViewState("WCanvass_Quotation_Internal1TableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
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
        
        Public ReadOnly Property WCQI_DescLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_DescLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCQI_FileLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_FileLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property WCQI_PM00200_Vendor_IDLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "WCQI_PM00200_Vendor_IDLabel"), System.Web.UI.WebControls.Literal)
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
            
              AddHandler Me.WCI_Submit.CheckedChanged, AddressOf WCI_Submit_CheckedChanged
            
              AddHandler Me.WCI_Date.TextChanged, AddressOf WCI_Date_TextChanged
            
              AddHandler Me.WCI_Status.TextChanged, AddressOf WCI_Status_TextChanged
            
              AddHandler Me.WCI_U_ID.TextChanged, AddressOf WCI_U_ID_TextChanged
            
    
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
                SetWCI_ID()
                SetWCI_Status()
                SetWCI_StatusLabel()
                SetWCI_Submit()
                SetWCI_U_ID()
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
                ' The Format method will return the Display Foreign Key As (DFKA) value
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
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Internal1Table.WCI_Date, "d")
                              
                Me.WCI_Date.Text = formattedValue
                
            Else 
            
                ' WCI_Date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCI_Date.Text = WCanvass_Internal1Table.WCI_Date.Format(WCanvass_Internal1Table.WCI_Date.DefaultValue, "d")
                        		
                End If
                 
              AddHandler Me.WCI_Date.TextChanged, AddressOf WCI_Date_TextChanged
                                 
        End Sub
                
        Public Overridable Sub SetWCI_ID()

                  
            
        
            ' Set the WCI_ID Literal on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_ID is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_IDSpecified Then
                				
                ' If the WCI_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Internal1Table.WCI_ID)
                              
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.WCI_ID.Text = formattedValue
                
            Else 
            
                ' WCI_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCI_ID.Text = WCanvass_Internal1Table.WCI_ID.Format(WCanvass_Internal1Table.WCI_ID.DefaultValue)
                        		
                End If
                                      
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
                
        Public Overridable Sub SetWCI_Submit()

                      
            
        
            ' Set the WCI_Submit CheckBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_Submit is the ASP:CheckBox on the webpage.

            ' You can modify this method directly, or replace it with a call to
            ' MyBase.SetWCI_Submit()
            ' and add your own code before or after the call to the MyBase function.

                    
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_SubmitSpecified Then
                									
                ' If the WCI_Submit is non-NULL, then format the value.
                ' The Format method will use the Display Format
                Me.WCI_Submit.Checked = Me.DataSource.WCI_Submit
            Else
            
                ' WCI_Submit is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Not Me.DataSource.IsCreated Then
                    Me.WCI_Submit.Checked = WCanvass_Internal1Table.WCI_Submit.ParseValue(WCanvass_Internal1Table.WCI_Submit.DefaultValue).ToBoolean()
                End If
                    				
            End If
                
        End Sub
                
        Public Overridable Sub SetWCI_U_ID()

                  
            
        
            ' Set the WCI_U_ID TextBox on the webpage with value from the
            ' DatabaseANFLO-WFN%dbo.WCanvass_Internal database record.

            ' Me.DataSource is the DatabaseANFLO-WFN%dbo.WCanvass_Internal record retrieved from the database.
            ' Me.WCI_U_ID is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.SetWCI_U_ID()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.WCI_U_IDSpecified Then
                				
                ' If the WCI_U_ID is non-NULL, then format the value.

                ' The Format method will use the Display Format
                Dim formattedValue As String = Me.DataSource.Format(WCanvass_Internal1Table.WCI_U_ID)
                              
                Me.WCI_U_ID.Text = formattedValue
                
            Else 
            
                ' WCI_U_ID is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                 Me.WCI_U_ID.Text = WCanvass_Internal1Table.WCI_U_ID.Format(WCanvass_Internal1Table.WCI_U_ID.DefaultValue)
                        		
                End If
                 
              AddHandler Me.WCI_U_ID.TextChanged, AddressOf WCI_U_ID_TextChanged
                                 
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
                ' The Format method will return the Display Foreign Key As (DFKA) value
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
            GetWCI_ID()
            GetWCI_Status()
            GetWCI_Submit()
            GetWCI_U_ID()
            GetWCI_Vendors()
            GetWCI_WClass_ID()
            GetWCI_WPRD_ID()
        End Sub
        
        
        Public Overridable Sub GetWCI_C_ID()
         
        End Sub
                
        Public Overridable Sub GetWCI_Date()
            
        End Sub
                
        Public Overridable Sub GetWCI_ID()
            
        End Sub
                
        Public Overridable Sub GetWCI_Status()
            
        End Sub
                
        Public Overridable Sub GetWCI_Submit()
        
        End Sub
                
        Public Overridable Sub GetWCI_U_ID()
            
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
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.sel_WF_DYNAMICS_Company table.
            ' Examples:
            ' wc.iAND(Sel_WF_DYNAMICS_Company1View.Company_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(Sel_WF_DYNAMICS_Company1View.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
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
            						
            ' This WhereClause is for the DatabaseANFLO-WFN%dbo.WPR_Doc table.
            ' Examples:
            ' wc.iAND(WPR_Doc1Table.WPRD_ID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(WPR_Doc1Table.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
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
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(Sel_WF_DYNAMICS_Company1View.Company_Desc, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As Sel_WF_DYNAMICS_Company1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = Sel_WF_DYNAMICS_Company1View.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As Sel_WF_DYNAMICS_Company1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.Company_IDSpecified Then
                            cvalue = itemValue.Company_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.WCI_C_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCanvass_Internal1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCanvass_Internal1Table.WCI_C_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCanvass_Internal1Table.WCI_C_ID.IsApplyDisplayAs Then
                                fvalue = WCanvass_Internal1Table.GetDFKA(itemValue, WCanvass_Internal1Table.WCI_C_ID)
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

                                Dim dupItem As ListItem = Me.WCI_C_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCI_C_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WCI_C_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_C_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.sel_WF_DYNAMICS_Company.Company_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Sel_WF_DYNAMICS_Company1View.Company_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Sel_WF_DYNAMICS_Company1Record = Sel_WF_DYNAMICS_Company1View.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As Sel_WF_DYNAMICS_Company1Record = DirectCast(rc(0), Sel_WF_DYNAMICS_Company1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.Company_IDSpecified Then
                            cvalue = itemValue.Company_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCanvass_Internal1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCanvass_Internal1Table.WCI_C_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCanvass_Internal1Table.WCI_C_ID.IsApplyDisplayAs Then
                          fvalue = WCanvass_Internal1Table.GetDFKA(itemValue, WCanvass_Internal1Table.WCI_C_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(Sel_WF_DYNAMICS_Company1View.Company_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCI_C_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

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
                

            Dim orderBy As OrderBy = New OrderBy(false, false)			
                          orderBy.Add(WPR_Doc1Table.WPRD_No, OrderByItem.OrderDir.Asc)

                      Dim variables As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As WPR_Doc1Record = Nothing
            Dim evaluator As New FormulaEvaluator                
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Dim listDuplicates As New ArrayList()

                Do
                    itemValues = WPR_Doc1Table.GetRecords(wc, orderBy, pageNum, maxItems)
                    For each itemValue As WPR_Doc1Record In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WPRD_IDSpecified Then
                            cvalue = itemValue.WPRD_ID.ToString() 
                            
                            If counter < maxItems AndAlso Me.WCI_WPRD_ID.Items.FindByValue(cvalue) Is Nothing Then
                            
                                Dim _isExpandableNonCompositeForeignKey As Boolean = WCanvass_Internal1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCanvass_Internal1Table.WCI_WPRD_ID)
                                If _isExpandableNonCompositeForeignKey AndAlso WCanvass_Internal1Table.WCI_WPRD_ID.IsApplyDisplayAs Then
                                fvalue = WCanvass_Internal1Table.GetDFKA(itemValue, WCanvass_Internal1Table.WCI_WPRD_ID)
                                End If
                                If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                                fvalue = itemValue.Format(WPR_Doc1Table.WPRD_ID)
                                End If
                              
                                If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue

                                If (IsNothing(fvalue)) Then
                                   fvalue = ""
                                End If

                                fvalue = fvalue.Trim()

                                If ( fvalue.Length > 50 ) Then
                                    fvalue = fvalue.Substring(0, 50) & "..."
                                End If

                                Dim dupItem As ListItem = Me.WCI_WPRD_ID.Items.FindByText(fvalue)
                          
                                If Not IsNothing(dupItem) Then
                                    listDuplicates.Add(fvalue)
                                    If Not String.IsNullOrEmpty(dupItem.Value) Then
                                        dupItem.Text = fvalue & " (ID " & dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) & ")"
                                    End If
                                End If

                                Dim newItem As ListItem = New ListItem(fvalue, cvalue)
                                Me.WCI_WPRD_ID.Items.Add(newItem)

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
                Not SetSelectedValue(Me.WCI_WPRD_ID, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.WCI_WPRD_ID, selectedValue)Then

                ' construct a whereclause to query a record with DatabaseANFLO-WFN%dbo.WPR_Doc.WPRD_ID = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(WPR_Doc1Table.WPRD_ID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As WPR_Doc1Record = WPR_Doc1Table.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)
                      Dim vars As System.Collections.Generic.IDictionary(Of String, Object) = New System.Collections.Generic.Dictionary(Of String, Object)
                      ' if find a record, add it to the dropdown and set it as selected item
                      If rc IsNot Nothing AndAlso rc.Length = 1 Then
                      Dim itemValue As WPR_Doc1Record = DirectCast(rc(0), WPR_Doc1Record)
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.WPRD_IDSpecified Then
                            cvalue = itemValue.WPRD_ID.ToString() 
                          Dim _isExpandableNonCompositeForeignKey As Boolean = WCanvass_Internal1Table.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(WCanvass_Internal1Table.WCI_WPRD_ID)
                          If _isExpandableNonCompositeForeignKey AndAlso WCanvass_Internal1Table.WCI_WPRD_ID.IsApplyDisplayAs Then
                          fvalue = WCanvass_Internal1Table.GetDFKA(itemValue, WCanvass_Internal1Table.WCI_WPRD_ID)
                          End If
                          If (Not _isExpandableNonCompositeForeignKey) Or (String.IsNullOrEmpty(fvalue)) Then
                          fvalue = itemValue.Format(WPR_Doc1Table.WPRD_ID)
                          End If
                        
                              If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                              ResetSelectedItem(Me.WCI_WPRD_ID, New ListItem(fvalue, cvalue))
                            End If
                        End If
                Catch
                End Try

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
            
        Protected Overridable Sub WCI_Submit_CheckedChanged(ByVal sender As Object, ByVal args As EventArgs)                
             

        End Sub
            
        Protected Overridable Sub WCI_Date_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCI_Status_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
              End Sub
            
        Protected Overridable Sub WCI_U_ID_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    
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

  