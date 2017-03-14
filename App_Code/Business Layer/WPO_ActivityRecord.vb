' This is a "safe" class, meaning that it is created once 
' and never overwritten. Any custom code you add to this class 
' will be preserved when you regenerate your application.
'
' Typical customizations that may be done in this class include
'  - adding custom event handlers
'  - overriding base class methods

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ePortalWFApproval.Business

''' <summary>
''' Provides access to the data in a database record.
''' Also provides access to the <see cref="WPO_ActivityTable"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="WPO_ActivityTable"></seealso>

<Serializable()> Public Class WPO_ActivityRecord
	Inherits BaseWPO_ActivityRecord

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	

        Public Shared Sub AddRecord(ByVal WPO_WS_ID As String, ByVal WPO_WSD_ID As String, ByVal WPO_WDT_ID As String, _
            ByVal U_ID As String, ByVal U_ID_Delegate As String, ByVal poNum As String, Optional ByVal WPO_Remark As String = "")

            Dim rec As New WPO_ActivityRecord

            Try
                Utils.DbUtils.StartTransaction()
                rec.WPO_WS_ID = WPO_WS_ID
                rec.WPO_WSD_ID = WPO_WSD_ID
                rec.WPO_WDT_ID = WPO_WDT_ID
                rec.WPO_W_U_ID = U_ID
                rec.WPO_W_U_ID_Delegate = U_ID_Delegate
                rec.WPO_PONum = poNum
                rec.WPO_Status = 4 'NOTE: Change WFApprovalStatus from 4 to 9
                rec.WPO_Date_Assign = Now().ToString() '.ToShortDateString()

                rec.WPO_Remark = WPO_Remark
                rec.WPO_Is_Done = 0

                rec.Save()
                Utils.DbUtils.CommitTransaction()
            Catch ex As Exception
                Utils.DbUtils.RollBackTransaction()
            End Try
        End Sub

        Public Shared Sub UpdateRecord(ByVal WPO_ID As String, ByVal WPO_Status As String)

            Dim ws As String = "WPO_ID = " & WPO_ID
            Dim rec As New WPO_ActivityRecord
            rec = WPO_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                WPO_ID = rec.WPO_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WPO_ActivityTable.GetRecord(WPO_ID, True)
                    rec.WPO_Status = WPO_Status
                    rec.WPO_Date_Action = Now().ToString() 'ToShortDateString()
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If

        End Sub

        Public Shared Sub UpdateRecord(ByVal WPO_ID As String, ByVal WPO_Status As String, ByVal WPO_W_U_ID As String)

            Dim ws As String = "WPO_ID = " & WPO_ID
            Dim rec As New WPO_ActivityRecord
            rec = WPO_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                WPO_ID = rec.WPO_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WPO_ActivityTable.GetRecord(WPO_ID, True)
                    rec.WPO_Status = WPO_Status
                    rec.WPO_Date_Action = Now().ToString() 'ToShortDateString()
                    rec.WPO_W_U_ID = WPO_W_U_ID 'Approver
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If

        End Sub

        Public Shared Sub UpdateRecord_Final_Approved(ByVal WPO_ID As String)

            Dim ws As String = "WPO_ID = " & WPO_ID
            Dim rec As New WPO_ActivityRecord
            rec = WPO_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                WPO_ID = rec.WPO_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WPO_ActivityTable.GetRecord(WPO_ID, True)
                    rec.WPO_Is_Done = "1"
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub



        Public Shared Sub AssignTo(ByVal WPO_ID As String, ByVal WPO_W_U_ID_Assign As String)

            Dim ws As String = "WPO_ID = " & WPO_ID
            Dim rec As New WPO_ActivityRecord
            rec = WPO_ActivityTable.GetRecord(ws)

            If Not rec Is Nothing Then
                WPO_ID = rec.WPO_ID.ToString()
                Utils.DbUtils.StartTransaction()
                Try
                    rec = WPO_ActivityTable.GetRecord(WPO_ID, True)

                    rec.WPO_W_U_ID = WPO_W_U_ID_Assign
                    rec.Save()
                    Utils.DbUtils.CommitTransaction()
                Catch ex As Exception
                    Utils.DbUtils.RollBackTransaction()
                End Try
            End If
        End Sub


	

End Class
End Namespace
